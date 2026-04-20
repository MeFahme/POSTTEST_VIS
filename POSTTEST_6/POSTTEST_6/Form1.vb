Public Class Form1

    Private Sub Kosong()
        txtKodePart.Clear()
        txtNamaPart.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        cmbKategori.SelectedIndex = -1
        cmbMerk.SelectedIndex = -1
        ErrorProvider1.Clear()
        txtKodePart.Focus()
    End Sub

    Private Function GetKodeKategori() As String
        If cmbKategori.SelectedValue IsNot Nothing Then Return cmbKategori.SelectedValue.ToString()
        Return ""
    End Function

    Private Function GetKodeMerk() As String
        If cmbMerk.SelectedValue IsNot Nothing Then Return cmbMerk.SelectedValue.ToString()
        Return ""
    End Function

    Private Sub TampilData()
        dgvPart.DataSource = GetAllPart()
        lblJumlahData.Text = "Total: " & dgvPart.RowCount & " data"
        If dgvPart.Columns.Contains("Harga") Then
            dgvPart.Columns("Harga").DefaultCellStyle.Format = "N0"
        End If
    End Sub

    Private Sub IsiKategori()
        Dim dtForm As DataTable = GetAllKategori()
        cmbKategori.DataSource = dtForm
        cmbKategori.DisplayMember = "NamaKategori"
        cmbKategori.ValueMember = "KodeKategori"
        cmbKategori.SelectedIndex = -1

        Dim dtFilter As DataTable = GetAllKategori()
        Dim rowAll As DataRow = dtFilter.NewRow()
        rowAll("KodeKategori") = ""
        rowAll("NamaKategori") = "Semua Kategori"
        dtFilter.Rows.InsertAt(rowAll, 0)
        cmbFilterKategori.DataSource = dtFilter
        cmbFilterKategori.DisplayMember = "NamaKategori"
        cmbFilterKategori.ValueMember = "KodeKategori"
        cmbFilterKategori.SelectedIndex = 0
    End Sub

    Private Sub IsiMerk()
        Dim dtForm As DataTable = GetAllMerk()
        cmbMerk.DataSource = dtForm
        cmbMerk.DisplayMember = "NamaMerk"
        cmbMerk.ValueMember = "KodeMerk"
        cmbMerk.SelectedIndex = -1

        Dim dtFilter As DataTable = GetAllMerk()
        Dim rowAll As DataRow = dtFilter.NewRow()
        rowAll("KodeMerk") = ""
        rowAll("NamaMerk") = "Semua Merk"
        dtFilter.Rows.InsertAt(rowAll, 0)
        cmbFilterMerk.DataSource = dtFilter
        cmbFilterMerk.DisplayMember = "NamaMerk"
        cmbFilterMerk.ValueMember = "KodeMerk"
        cmbFilterMerk.SelectedIndex = 0
    End Sub

    Private Sub JalankanFilter()
        Dim kodeKat As String = If(cmbFilterKategori.SelectedValue IsNot Nothing, cmbFilterKategori.SelectedValue.ToString(), "")
        Dim kodeMerk As String = If(cmbFilterMerk.SelectedValue IsNot Nothing, cmbFilterMerk.SelectedValue.ToString(), "")
        Dim keyword As String = txtSearch.Text.Trim()
        dgvPart.DataSource = FilterPart(kodeKat, kodeMerk, keyword)
        lblJumlahData.Text = "Total: " & dgvPart.RowCount & " data"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiKategori()
        IsiMerk()
        TampilData()
        Kosong()
    End Sub

    Private Sub btnKePenjualan_Click(sender As Object, e As EventArgs) Handles btnKePenjualan.Click
        Hide
        Form2.Show
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiFormPart(ErrorProvider1, txtKodePart, txtNamaPart,
                                cmbKategori, cmbMerk, txtHarga, txtStok) Then Exit Sub

        Dim kode = txtKodePart.Text.Trim
        If KodePartSudahAda(kode) Then
            MessageBox.Show("Kode Part '" & kode & "' sudah terdaftar!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePart.Focus()
            Exit Sub
        End If

        If SimpanPart(kode, txtNamaPart.Text.Trim,
                      GetKodeKategori, GetKodeMerk,
                      CDec(txtHarga.Text.Trim),
                      CInt(txtStok.Text.Trim)) Then
            MessageBox.Show("Data part berhasil disimpan!",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click_1(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiFormPart(ErrorProvider1, txtKodePart, txtNamaPart,
                                cmbKategori, cmbMerk, txtHarga, txtStok) Then Exit Sub

        Dim konfirmasi = MessageBox.Show("Yakin ingin mengubah data part ini?",
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            If UbahPart(txtKodePart.Text.Trim, txtNamaPart.Text.Trim,
                        GetKodeKategori, GetKodeMerk,
                        CDec(txtHarga.Text.Trim()),
                        CInt(txtStok.Text.Trim())) Then
                MessageBox.Show("Data part berhasil diubah!",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            Else
                MessageBox.Show("Data tidak ditemukan, ubah gagal.",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePart.Text.Trim() = "" Then
            MessageBox.Show("Pilih data part yang akan dihapus terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim konfirmasi As DialogResult =
            MessageBox.Show("Yakin ingin menghapus part '" & txtNamaPart.Text & "'?",
                            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            If HapusPart(txtKodePart.Text.Trim()) Then
                MessageBox.Show("Data part berhasil dihapus!",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvPart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPart.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim kode As String = dgvPart.Rows(e.RowIndex).Cells("KodePart").Value.ToString()
        Dim dt As DataTable = GetPartByKode(kode)
        If dt.Rows.Count = 0 Then Exit Sub
        Dim r As DataRow = dt.Rows(0)
        txtKodePart.Text = r("KodePart").ToString()
        txtNamaPart.Text = r("NamaPart").ToString()
        txtHarga.Text = r("Harga").ToString()
        txtStok.Text = r("Stok").ToString()
        cmbKategori.SelectedValue = r("KodeKategori").ToString()
        cmbMerk.SelectedValue = r("KodeMerk").ToString()
    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        JalankanFilter()
    End Sub

    Private Sub cmbFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKategori.SelectedIndexChanged
        JalankanFilter()
    End Sub

    Private Sub cmbFilterMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterMerk.SelectedIndexChanged
        JalankanFilter()
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        txtSearch.Clear()
        cmbFilterKategori.SelectedIndex = 0
        cmbFilterMerk.SelectedIndex = 0
        TampilData()
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngkaDanTitik(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtKodePart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodePart.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetPartByKode(txtKodePart.Text.Trim())
            If dt.Rows.Count > 0 Then
                Dim r As DataRow = dt.Rows(0)
                txtNamaPart.Text = r("NamaPart").ToString()
                txtHarga.Text = r("Harga").ToString()
                txtStok.Text = r("Stok").ToString()
                cmbKategori.SelectedValue = r("KodeKategori").ToString()
                cmbMerk.SelectedValue = r("KodeMerk").ToString()
            End If
            txtNamaPart.Focus()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim konfirmasi As DialogResult =
                MessageBox.Show("Keluar dari aplikasi?",
                                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.No Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub

End Class
