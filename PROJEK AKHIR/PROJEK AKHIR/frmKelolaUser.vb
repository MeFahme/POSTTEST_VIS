Public Class frmKelolaUser

    Private idUserDipilih As Integer = 0

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmKelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboRole()
        MuatDataUser()
        ResetForm()
    End Sub

    ' ================================================================
    '  ISI COMBO ROLE
    ' ================================================================
    Private Sub IsiComboRole()
        cboRole.Items.Clear()
        cboRole.Items.Add("kasir")
        cboRole.Items.Add("mekanik")
        cboRole.SelectedIndex = 0

        cboFilter.Items.Clear()
        cboFilter.Items.Add("Semua Role")
        cboFilter.Items.Add("admin")
        cboFilter.Items.Add("kasir")
        cboFilter.Items.Add("mekanik")
        cboFilter.SelectedIndex = 0
    End Sub

    ' ================================================================
    '  MUAT DATA USER KE DATAGRIDVIEW
    ' ================================================================
    Private Sub MuatDataUser()
        Dim dt As DataTable = GetAllUsers()
        If dt Is Nothing Then Exit Sub

        dgvUser.DataSource = dt

        With dgvUser
            If .Columns.Contains("id_user")  Then .Columns("id_user").Visible     = False
            If .Columns.Contains("nama")      Then .Columns("nama").HeaderText      = "Nama Lengkap"
            If .Columns.Contains("username")  Then .Columns("username").HeaderText  = "Username"
            If .Columns.Contains("role")      Then .Columns("role").HeaderText      = "Role"
        End With

        WarnaiRole()
        UpdateStatusBar()
    End Sub

    Private Sub WarnaiRole()
        For Each row As DataGridViewRow In dgvUser.Rows
            If row.IsNewRow Then Continue For
            Select Case row.Cells("role").Value?.ToString()
                Case "admin"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(168, 100, 220)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 20, 40)
                Case "kasir"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 25, 40)
                Case "mekanik"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 25, 15)
            End Select
        Next
    End Sub

    Private Sub UpdateStatusBar()
        Dim total As Integer   = 0
        Dim admin As Integer   = 0
        Dim kasir As Integer   = 0
        Dim mekanik As Integer = 0

        For Each row As DataGridViewRow In dgvUser.Rows
            If row.IsNewRow Then Continue For
            total += 1
            Select Case row.Cells("role").Value?.ToString()
                Case "admin"   : admin += 1
                Case "kasir"   : kasir += 1
                Case "mekanik" : mekanik += 1
            End Select
        Next

        lblStatusBar.Text = String.Format(
            "Total: {0} user   |   Admin: {1}   |   Kasir: {2}   |   Mekanik: {3}   |   ⚠ Akun Admin tidak dapat dihapus",
            total, admin, kasir, mekanik)
    End Sub

    ' ================================================================
    '  KLIK BARIS — isi form
    ' ================================================================
    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvUser.Rows(e.RowIndex)
        idUserDipilih = Convert.ToInt32(row.Cells("id_user").Value)

        txtNama.Text     = row.Cells("nama").Value?.ToString()
        txtUsername.Text = row.Cells("username").Value?.ToString()
        txtPassword.Text = ""   ' password tidak ditampilkan

        Dim role As String = row.Cells("role").Value?.ToString()
        Dim idx As Integer = cboRole.Items.IndexOf(role)
        If idx >= 0 Then cboRole.SelectedIndex = idx

        ' Admin tidak boleh dihapus dan role-nya tidak bisa diubah
        Dim isAdmin As Boolean = (role = "admin")
        btnHapus.Enabled  = Not isAdmin
        cboRole.Enabled   = Not isAdmin
        lblFormTitle.Text = "Edit User"
    End Sub

    ' ================================================================
    '  FILTER & SEARCH
    ' ================================================================
    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    Private Sub TerapkanFilter()
        If dgvUser.DataSource Is Nothing Then Exit Sub

        Dim dt As DataTable = CType(dgvUser.DataSource, DataTable)
        Dim dv As New DataView(dt)

        Dim kondisi As String = ""

        If cboFilter.SelectedIndex > 0 Then
            kondisi = "role = '" & cboFilter.SelectedItem.ToString() & "'"
        End If

        Dim cari As String = txtCari.Text.Trim()
        If cari <> "" Then
            Dim cariKondisi As String =
                "nama LIKE '%" & cari & "%' OR username LIKE '%" & cari & "%'"
            kondisi = If(kondisi = "", cariKondisi, kondisi & " AND (" & cariKondisi & ")")
        End If

        dv.RowFilter    = kondisi
        dgvUser.DataSource = dv
        WarnaiRole()
    End Sub

    ' ================================================================
    '  TOMBOL SIMPAN
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiForm() Then Exit Sub

        Dim nama     As String = txtNama.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role     As String = cboRole.SelectedItem.ToString()

        If idUserDipilih = 0 Then
            ' MODE TAMBAH — password wajib diisi
            If String.IsNullOrWhiteSpace(password) Then
                MsgBox("Password wajib diisi untuk user baru.", MsgBoxStyle.Exclamation, "Validasi")
                txtPassword.Focus() : Exit Sub
            End If
            If TambahUser(nama, username, password, role) Then
                MsgBox("User berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataUser()
            End If
        Else
            ' MODE EDIT
            If EditUser(idUserDipilih, nama, username, password, role) Then
                MsgBox("Data user berhasil diperbarui.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataUser()
            End If
        End If
    End Sub

    ' ================================================================
    '  TOMBOL HAPUS
    ' ================================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idUserDipilih = 0 Then Exit Sub

        Dim konfirmasi As MsgBoxResult =
            MsgBox("Yakin ingin menghapus user " & txtNama.Text & "?" & vbNewLine &
                   "Tindakan ini tidak dapat dibatalkan.",
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Konfirmasi Hapus")

        If konfirmasi = MsgBoxResult.Yes Then
            If HapusUser(idUserDipilih) Then
                MsgBox("User berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataUser()
            End If
        End If
    End Sub

    ' ================================================================
    '  TOMBOL BARU / RESET
    ' ================================================================
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        idUserDipilih    = 0
        txtNama.Text     = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        cboRole.SelectedIndex = 0
        cboRole.Enabled  = True
        btnHapus.Enabled = False
        lblFormTitle.Text = "Tambah User Baru"
        txtNama.Focus()
    End Sub

    ' ================================================================
    '  VALIDASI
    ' ================================================================
    Private Function ValidasiForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama lengkap tidak boleh kosong.", MsgBoxStyle.Exclamation, "Validasi")
            txtNama.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Username tidak boleh kosong.", MsgBoxStyle.Exclamation, "Validasi")
            txtUsername.Focus() : Return False
        End If
        If txtUsername.Text.Contains(" ") Then
            MsgBox("Username tidak boleh mengandung spasi.", MsgBoxStyle.Exclamation, "Validasi")
            txtUsername.Focus() : Return False
        End If
        Return True
    End Function

End Class
