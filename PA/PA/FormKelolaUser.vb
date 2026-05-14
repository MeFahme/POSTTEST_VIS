Imports MySqlConnector

Public Class FormKelolaUser
    Dim idUserDipilih As String = ""

    Private Sub FormKelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        AturDGV()
        ResetInput()
    End Sub

    Sub RefreshData()
        ' Mengambil data user (Password tidak ditampilkan demi keamanan)
        DataModule.LoadToDGV("SELECT id_user, nama, username, role FROM users", dgvUser)
    End Sub

    Sub AturDGV()
        ' Merapikan tampilan kolom
        If dgvUser.ColumnCount > 0 Then
            dgvUser.Columns(0).Visible = False
            dgvUser.Columns(1).HeaderText = "Nama Lengkap"
            dgvUser.Columns(2).HeaderText = "Username"
            dgvUser.Columns(3).HeaderText = "Role"
            dgvUser.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Sub ResetInput()
        ErrorProvider1.Clear()
        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cboRole.SelectedIndex = -1
        idUserDipilih = ""
        btnSimpan.Text = "Simpan"
        btnHapus.Enabled = False
    End Sub

    ' SIMPAN & UPDATE
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi sederhana
        If ValidasiInput() = False Then
            ' Jika ada yang salah, hentikan proses (user akan melihat ikon merah di samping input)
            Return
        End If

        Dim query As String
        Dim params As MySqlParameter()

        If idUserDipilih = "" Then
            ' MODE INSERT
            query = "INSERT INTO users (nama, username, password, role) VALUES (@nama, @user, @pass, @role)"
            params = {
                New MySqlParameter("@nama", txtNama.Text),
                New MySqlParameter("@user", txtUsername.Text),
                New MySqlParameter("@pass", txtPassword.Text), ' Sebaiknya di-hash di masa depan
                New MySqlParameter("@role", cboRole.Text)
            }
        Else
            ' MODE UPDATE
            If txtPassword.Text <> "" Then
                query = "UPDATE users SET nama=@nama, username=@user, password=@pass, role=@role WHERE id_user=@id"
                params = {
                    New MySqlParameter("@nama", txtNama.Text),
                    New MySqlParameter("@user", txtUsername.Text),
                    New MySqlParameter("@pass", txtPassword.Text),
                    New MySqlParameter("@role", cboRole.Text),
                    New MySqlParameter("@id", idUserDipilih)
                }
            Else
                ' Update tanpa ganti password
                query = "UPDATE users SET nama=@nama, username=@user, role=@role WHERE id_user=@id"
                params = {
                    New MySqlParameter("@nama", txtNama.Text),
                    New MySqlParameter("@user", txtUsername.Text),
                    New MySqlParameter("@role", cboRole.Text),
                    New MySqlParameter("@id", idUserDipilih)
                }
            End If
        End If

        If DataModule.EksekusiSQL(query, params) Then
            MsgBox("Data berhasil diproses!")
            RefreshData()
            ResetInput()
        End If
    End Sub

    ' AMBIL DATA DARI TABEL KE INPUTAN
    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUser.Rows(e.RowIndex)
            idUserDipilih = row.Cells(0).Value.ToString()
            txtNama.Text = row.Cells(1).Value.ToString()
            txtUsername.Text = row.Cells(2).Value.ToString()
            cboRole.Text = row.Cells(3).Value.ToString()

            btnSimpan.Text = "Update"
            btnHapus.Enabled = True
            txtPassword.PlaceholderText = "*Kosongkan jika tidak ubah"
        End If
    End Sub

    ' HAPUS DATA
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus user ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim query As String = "DELETE FROM users WHERE id_user = @id"
            Dim params As MySqlParameter() = {New MySqlParameter("@id", idUserDipilih)}

            If DataModule.EksekusiSQL(query, params) Then
                RefreshData()
                ResetInput()
            End If
        End If
    End Sub

    ' RESET/BATAL
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        ResetInput()
    End Sub

    Private Function ValidasiInput() As Boolean
        Dim adaYangKosong As Boolean = False

        If ValidationModule.CekKosong(txtNama, ErrorProvider1, "Nama lengkap harus diisi!") Then adaYangKosong = True
        If ValidationModule.CekKosong(txtUsername, ErrorProvider1, "Username tidak boleh kosong!") Then adaYangKosong = True

        If btnSimpan.Text = "Simpan" Then
            If ValidationModule.CekKosong(txtPassword, ErrorProvider1, "Password wajib diisi!") Then adaYangKosong = True
        End If

        If ValidationModule.CekKosong(cboRole, ErrorProvider1, "Pilih role user!") Then adaYangKosong = True
        Return Not adaYangKosong
    End Function
    Sub CariData()
        Dim sql As String = "SELECT id_user, nama, username, role FROM users WHERE 1=1"

        ' Filter berdasarkan Teks
        If txtCari.Text <> "" Then
            sql &= " AND (nama LIKE '%" & txtCari.Text & "%' OR username LIKE '%" & txtCari.Text & "%')"
        End If

        ' Filter berdasarkan Role (Hanya satu pengecekan saja)
        If cboFilter.SelectedIndex > 0 Then
            sql &= " AND role = '" & cboFilter.Text.Trim() & "'"
        End If

        DataModule.FilterDGV(sql, dgvUser)
        AturDGV()
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        CariData()
    End Sub
    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        CariData()
    End Sub
End Class