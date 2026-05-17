Imports MySqlConnector
Public Class FormKelolaSparepart
    Dim idSparepartDipilih As String = ""
    Dim isReseting As Boolean = False
    Private Sub FormKelolaSparepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        RefreshData()
        AturDGV()
        ResetInput()
    End Sub
    Sub RefreshData()
        DataModule.LoadToDGV("SELECT id_part, nama_part, kategori, merk_motor, stok, harga_jual FROM sparepart", dgvSparepart)
    End Sub
    Sub AturDGV()
        If dgvSparepart.ColumnCount > 0 Then
            dgvSparepart.RowHeadersVisible = False
            dgvSparepart.Columns(0).Visible = False
            dgvSparepart.Columns(1).HeaderText = "Nama Sparepart"
            dgvSparepart.Columns(2).HeaderText = "Kategori"
            dgvSparepart.Columns(3).HeaderText = "Merk Motor"
            dgvSparepart.Columns(4).HeaderText = "Stok"
            dgvSparepart.Columns(5).HeaderText = "Harga (Rp)"
            dgvSparepart.Columns(5).DefaultCellStyle.Format = "N0"

            dgvSparepart.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub
    Sub ResetInput()
        isReseting = True
        txtNamaPart.Clear()
        txtKategori.Clear()
        cboMerk.SelectedIndex = -1
        txtStok.Clear()
        txtHarga.Clear()
        idSparepartDipilih = ""
        btnSimpan.Text = "Simpan"
        btnHapus.Enabled = False
        ErrorProvider1.Clear()
        isReseting = False
    End Sub
    Private Function ValidasiInput() As Boolean
        Dim adaYangKosong As Boolean = False
        If ValidationModule.CekKosong(txtNamaPart, ErrorProvider1, "Nama sparepart wajib diisi!") Then adaYangKosong = True
        If ValidationModule.CekKosong(txtKategori, ErrorProvider1, "Kategori wajib diisi!") Then adaYangKosong = True
        If ValidationModule.CekKosong(cboMerk, ErrorProvider1, "Pilih merk motor!") Then adaYangKosong = True
        If ValidationModule.CekKosong(txtStok, ErrorProvider1, "Stok tidak boleh kosong!") Then adaYangKosong = True
        If ValidationModule.CekKosong(txtHarga, ErrorProvider1, "Harga tidak boleh kosong!") Then adaYangKosong = True
        Return Not adaYangKosong
    End Function
    Private Sub txtNamaPart_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPart.TextChanged
        If isReseting Then Exit Sub
        ValidationModule.CekKosong(txtNamaPart, ErrorProvider1, "Nama sparepart wajib diisi!")
    End Sub
    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged
        If isReseting Then Exit Sub
        ValidationModule.CekKosong(txtStok, ErrorProvider1, "Stok wajib diisi!")
    End Sub
    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged
        If isReseting Then Exit Sub
        ValidationModule.CekKosong(txtHarga, ErrorProvider1, "Harga wajib diisi!")
    End Sub
    Private Sub txtKategori_TextChanged(sender As Object, e As EventArgs) Handles txtKategori.TextChanged
        If isReseting Then Exit Sub
        ValidationModule.CekKosong(txtKategori, ErrorProvider1, "Kategori wajib diisi!")
    End Sub
    Private Sub cboMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMerk.SelectedIndexChanged
        If isReseting Then Exit Sub
        ValidationModule.CekKosong(cboMerk, ErrorProvider1, "Pilih merk motor!")
    End Sub
    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Return
        Dim query As String
        Dim params As MySqlParameter()
        If idSparepartDipilih = "" Then
            query = "INSERT INTO sparepart (nama_part, kategori, merk_motor, stok, harga_jual) VALUES (@nama, @kat, @merk, @stok, @harga)"
            params = {
                New MySqlParameter("@nama", txtNamaPart.Text),
                New MySqlParameter("@kat", txtKategori.Text),
                New MySqlParameter("@merk", cboMerk.Text),
                New MySqlParameter("@stok", txtStok.Text),
                New MySqlParameter("@harga", txtHarga.Text)
            }
        Else
            query = "UPDATE sparepart SET nama_part=@nama, kategori=@kat, merk_motor=@merk, stok=@stok, harga_jual=@harga WHERE id_part=@id"
            params = {
                New MySqlParameter("@nama", txtNamaPart.Text),
                New MySqlParameter("@kat", txtKategori.Text),
                New MySqlParameter("@merk", cboMerk.Text),
                New MySqlParameter("@stok", txtStok.Text),
                New MySqlParameter("@harga", txtHarga.Text),
                New MySqlParameter("@id", idSparepartDipilih)
            }
        End If
        If DataModule.EksekusiSQL(query, params) Then
            ValidationModule.TampilkanInfo("Data Sparepart berhasil disimpan!")
            RefreshData()
            ResetInput()
        End If
    End Sub
    Private Sub dgvSparepart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSparepart.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSparepart.Rows(e.RowIndex)
            idSparepartDipilih = row.Cells(0).Value.ToString()
            txtNamaPart.Text = row.Cells(1).Value.ToString()
            txtKategori.Text = row.Cells(2).Value.ToString()
            cboMerk.Text = row.Cells(3).Value.ToString()
            txtStok.Text = row.Cells(4).Value.ToString()
            txtHarga.Text = row.Cells(5).Value.ToString()
            btnSimpan.Text = "Update"
            btnHapus.Enabled = True
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Hapus sparepart ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim params() As MySqlParameter = {New MySqlParameter("@id", idSparepartDipilih)}
            If DataModule.EksekusiSQL("DELETE FROM sparepart WHERE id_part=@id", params) Then
                RefreshData()
                ResetInput()
            End If
        End If
    End Sub
    Sub CariData()
        Dim sql As String = "SELECT id_part, nama_part, kategori, merk_motor, stok, harga_jual FROM sparepart WHERE 1=1"
        If txtCari.Text <> "" Then
            sql &= " AND nama_part LIKE '%" & txtCari.Text & "%'"
        End If
        If cboFilter.Text <> "Semua Merk" AndAlso cboFilter.SelectedIndex <> -1 Then
            sql &= " AND merk_motor = '" & cboFilter.Text & "'"
        End If
        DataModule.LoadToDGV(sql, dgvSparepart)
        AturDGV()
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        CariData()
    End Sub
    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        CariData()
    End Sub
End Class