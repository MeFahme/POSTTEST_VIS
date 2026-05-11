Public Class frmKelolaSparepart

    ' Simpan id_part yang sedang dipilih di tabel
    Private idPartDipilih As Integer = 0

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmKelolaSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboMerk()
        MuatDataSparepart()
        ResetForm()
    End Sub

    ' ================================================================
    '  ISI COMBO MERK MOTOR
    ' ================================================================
    Private Sub IsiComboMerk()
        cboMerk.Items.Clear()
        cboMerk.Items.Add("Honda Vario")
        cboMerk.Items.Add("Yamaha MX King")
        cboMerk.SelectedIndex = 0

        ' Combo filter di atas tabel
        cboFilter.Items.Clear()
        cboFilter.Items.Add("Semua Merk")
        cboFilter.Items.Add("Honda Vario")
        cboFilter.Items.Add("Yamaha MX King")
        cboFilter.SelectedIndex = 0
    End Sub

    ' ================================================================
    '  MUAT DATA SPAREPART KE DATAGRIDVIEW
    ' ================================================================
    Private Sub MuatDataSparepart()
        Dim dt As DataTable = GetStokSparepart()
        If dt Is Nothing Then Exit Sub

        dgvSparepart.DataSource = dt

        ' Atur header
        With dgvSparepart
            If .Columns.Contains("id_part") Then .Columns("id_part").Visible = False
            If .Columns.Contains("nama_part") Then .Columns("nama_part").HeaderText = "Nama Part"
            If .Columns.Contains("kategori") Then .Columns("kategori").HeaderText = "Kategori"
            If .Columns.Contains("merk_motor") Then .Columns("merk_motor").HeaderText = "Merk Motor"
            If .Columns.Contains("harga_jual") Then
                .Columns("harga_jual").HeaderText = "Harga Jual"
                .Columns("harga_jual").DefaultCellStyle.Format = "N0"
            End If
            If .Columns.Contains("stok") Then .Columns("stok").HeaderText = "Stok"
            If .Columns.Contains("keterangan_stok") Then .Columns("keterangan_stok").HeaderText = "Status Stok"
        End With

        WarnaiStok()
        UpdateStatusBar()
    End Sub

    ' Warnai baris berdasarkan status stok
    Private Sub WarnaiStok()
        For Each row As DataGridViewRow In dgvSparepart.Rows
            If row.IsNewRow Then Continue For
            Dim ket As String = row.Cells("keterangan_stok").Value?.ToString()
            Select Case ket
                Case "Habis"
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(231, 76, 60)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(50, 20, 20)
                Case "Hampir Habis"
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 140, 0)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(50, 40, 20)
                Case Else
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(138, 153, 153)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(19, 21, 31)
            End Select
        Next
    End Sub

    Private Sub UpdateStatusBar()
        Dim total As Integer = 0
        Dim habis As Integer = 0
        Dim hampir As Integer = 0
        Dim aman As Integer = 0

        For Each row As DataGridViewRow In dgvSparepart.Rows
            If row.IsNewRow Then Continue For
            total += 1
            Select Case row.Cells("keterangan_stok").Value?.ToString()
                Case "Habis"        : habis += 1
                Case "Hampir Habis" : hampir += 1
                Case Else           : aman += 1
            End Select
        Next

        lblStatusBar.Text = String.Format(
            "Total: {0} sparepart   |   Habis: {1}   |   Hampir Habis: {2}   |   Tersedia: {3}",
            total, habis, hampir, aman)
    End Sub

    ' ================================================================
    '  KLIK BARIS TABEL — isi form dengan data baris terpilih
    ' ================================================================
    Private Sub dgvSparepart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSparepart.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvSparepart.Rows(e.RowIndex)
        idPartDipilih = Convert.ToInt32(row.Cells("id_part").Value)

        txtNamaPart.Text = row.Cells("nama_part").Value?.ToString()
        txtKategori.Text = row.Cells("kategori").Value?.ToString()
        txtHarga.Text    = row.Cells("harga_jual").Value?.ToString()
        txtStok.Text     = row.Cells("stok").Value?.ToString()

        ' Set combo merk
        Dim merk As String = row.Cells("merk_motor").Value?.ToString()
        Dim idx As Integer = cboMerk.Items.IndexOf(merk)
        If idx >= 0 Then cboMerk.SelectedIndex = idx

        ' Aktifkan tombol hapus
        btnHapus.Enabled = True
        lblFormTitle.Text = "Edit Sparepart"
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
        If dgvSparepart.DataSource Is Nothing Then Exit Sub

        Dim dt As DataTable = CType(dgvSparepart.DataSource, DataTable)
        Dim dv As New DataView(dt)

        Dim filterMerk As String = ""
        Dim filterCari As String = txtCari.Text.Trim()

        If cboFilter.SelectedIndex > 0 Then
            filterMerk = cboFilter.SelectedItem.ToString()
        End If

        Dim kondisi As String = ""
        If filterMerk <> "" Then
            kondisi = "merk_motor = '" & filterMerk & "'"
        End If
        If filterCari <> "" Then
            Dim cariKondisi As String = "nama_part LIKE '%" & filterCari & "%'"
            kondisi = If(kondisi = "", cariKondisi, kondisi & " AND " & cariKondisi)
        End If

        dv.RowFilter = kondisi
        dgvSparepart.DataSource = dv
        WarnaiStok()
    End Sub

    ' ================================================================
    '  TOMBOL SIMPAN (Tambah atau Edit)
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiForm() Then Exit Sub

        Dim nama   As String  = txtNamaPart.Text.Trim()
        Dim kat    As String  = txtKategori.Text.Trim()
        Dim merk   As String  = cboMerk.SelectedItem.ToString()
        Dim harga  As Decimal = Convert.ToDecimal(txtHarga.Text.Replace(".", "").Replace(",", ""))
        Dim stok   As Integer = Convert.ToInt32(txtStok.Text)

        If idPartDipilih = 0 Then
            ' MODE TAMBAH
            If TambahSparepart(nama, kat, merk, harga, stok) Then
                MsgBox("Sparepart berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataSparepart()
            End If
        Else
            ' MODE EDIT
            If EditSparepart(idPartDipilih, nama, kat, merk, harga, stok) Then
                MsgBox("Sparepart berhasil diperbarui.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataSparepart()
            End If
        End If
    End Sub

    ' ================================================================
    '  TOMBOL HAPUS
    ' ================================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idPartDipilih = 0 Then Exit Sub

        Dim konfirmasi As MsgBoxResult =
            MsgBox("Yakin ingin menghapus sparepart ini?" & vbNewLine &
                   "Data yang sudah digunakan dalam transaksi tidak dapat dihapus.",
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Konfirmasi Hapus")

        If konfirmasi = MsgBoxResult.Yes Then
            If HapusSparepart(idPartDipilih) Then
                MsgBox("Sparepart berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
                ResetForm()
                MuatDataSparepart()
            End If
        End If
    End Sub

    ' ================================================================
    '  TOMBOL BARU / RESET FORM
    ' ================================================================
    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        idPartDipilih    = 0
        txtNamaPart.Text = ""
        txtKategori.Text = ""
        txtHarga.Text    = ""
        txtStok.Text     = ""
        cboMerk.SelectedIndex = 0
        btnHapus.Enabled = False
        lblFormTitle.Text = "Tambah Sparepart Baru"
        txtNamaPart.Focus()
    End Sub

    ' ================================================================
    '  VALIDASI FORM
    ' ================================================================
    Private Function ValidasiForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNamaPart.Text) Then
            MsgBox("Nama part tidak boleh kosong.", MsgBoxStyle.Exclamation, "Validasi")
            txtNamaPart.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtKategori.Text) Then
            MsgBox("Kategori tidak boleh kosong.", MsgBoxStyle.Exclamation, "Validasi")
            txtKategori.Focus() : Return False
        End If

        Dim hargaStr As String = txtHarga.Text.Replace(".", "").Replace(",", "")
        Dim hargaVal As Decimal
        If Not Decimal.TryParse(hargaStr, hargaVal) OrElse hargaVal < 0 Then
            MsgBox("Harga jual harus berupa angka.", MsgBoxStyle.Exclamation, "Validasi")
            txtHarga.Focus() : Return False
        End If

        Dim stokVal As Integer
        If Not Integer.TryParse(txtStok.Text, stokVal) OrElse stokVal < 0 Then
            MsgBox("Stok harus berupa angka dan tidak negatif.", MsgBoxStyle.Exclamation, "Validasi")
            txtStok.Focus() : Return False
        End If

        Return True
    End Function

    ' ================================================================
    '  FORMAT HARGA OTOMATIS saat keluar dari txtHarga
    ' ================================================================
    Private Sub txtHarga_Leave(sender As Object, e As EventArgs) Handles txtHarga.Leave
        Dim hargaStr As String = txtHarga.Text.Replace(".", "").Replace(",", "")
        Dim hargaVal As Decimal
        If Decimal.TryParse(hargaStr, hargaVal) Then
            txtHarga.Text = Format(hargaVal, "#,##0")
        End If
    End Sub

End Class
