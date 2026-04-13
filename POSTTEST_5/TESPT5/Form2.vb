Public Class Form2

    Private dtKeranjang As DataTable

    Private Sub InitKeranjang()
        dtKeranjang = New DataTable()
        dtKeranjang.Columns.Add("KodePart",    GetType(String))
        dtKeranjang.Columns.Add("NamaPart",    GetType(String))
        dtKeranjang.Columns.Add("HargaSatuan", GetType(Decimal))
        dtKeranjang.Columns.Add("Jumlah",      GetType(Integer))
        dtKeranjang.Columns.Add("Subtotal",    GetType(Decimal))
    End Sub

    Private Sub TampilKeranjang()
        dgvKeranjang.DataSource = Nothing
        dgvKeranjang.DataSource = dtKeranjang

        For Each col As DataGridViewColumn In dgvKeranjang.Columns
            If col.Name.Contains("Harga") Or col.Name.Contains("Subtotal") Then
                col.DefaultCellStyle.Format = "N0"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        HitungTotal()
    End Sub
    Private Sub HitungTotal()
        Dim totalItem  As Integer = 0
        Dim totalHarga As Decimal = 0
        For Each row As DataRow In dtKeranjang.Rows
            totalItem  += Convert.ToInt32(row("Jumlah"))
            totalHarga += Convert.ToDecimal(row("Subtotal"))
        Next
        lblTotalItem.Text  = "Total Item : " & totalItem
        lblTotalHarga.Text = "Total Harga: Rp " & totalHarga.ToString("N0")
    End Sub

    Private Sub TampilRiwayat()
        dgvRiwayat.DataSource = GetAllPenjualan()

        If dgvRiwayat.Columns.Contains("TotalHarga") Then
            dgvRiwayat.Columns("TotalHarga").DefaultCellStyle.Format = "N0"
            dgvRiwayat.Columns("TotalHarga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        lblJumlahNota.Text = "Total Nota: " & dgvRiwayat.RowCount
    End Sub

    Private Sub IsiCmbPart()
        Dim dt As DataTable = GetAllPart()
        cmbPilihPart.DataSource    = dt
        cmbPilihPart.DisplayMember = "NamaPart"
        cmbPilihPart.ValueMember   = "KodePart"
        cmbPilihPart.SelectedIndex = -1
    End Sub

    Private Sub ResetFormTransaksi()
        txtNomorNota.Text   = GenerateNomorNota()
        dtpTanggal.Value    = DateTime.Now
        txtNamaPembeli.Clear()
        txtKeterangan.Clear()
        InitKeranjang()
        TampilKeranjang()
        cmbPilihPart.SelectedIndex = -1
        txtJumlahBeli.Text = "1"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiCmbPart()
        ResetFormTransaksi()
        TampilRiwayat()
    End Sub

    Private Sub btnDataPart_Click(sender As Object, e As EventArgs) Handles btnDataPart.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmbPilihPart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPilihPart.SelectedIndexChanged
        If cmbPilihPart.SelectedValue Is Nothing OrElse cmbPilihPart.SelectedIndex = -1 Then
            txtHargaPart.Text = ""
            txtStokPart.Text  = ""
            Exit Sub
        End If
        Dim kode As String = cmbPilihPart.SelectedValue.ToString()
        Dim dt As DataTable = GetPartByKode(kode)
        If dt.Rows.Count > 0 Then
            txtHargaPart.Text = dt.Rows(0)("Harga").ToString()
            txtStokPart.Text  = "Stok: " & dt.Rows(0)("Stok").ToString()
        End If
    End Sub

    Private Sub btnTambahKeranjang_Click(sender As Object, e As EventArgs) Handles btnTambahKeranjang.Click
        If cmbPilihPart.SelectedValue Is Nothing OrElse cmbPilihPart.SelectedIndex = -1 Then
            MessageBox.Show("Pilih part terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jumlah As Integer
        If Not Integer.TryParse(txtJumlahBeli.Text.Trim(), jumlah) OrElse jumlah < 1 Then
            MessageBox.Show("Jumlah harus berupa angka minimal 1!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlahBeli.Focus()
            Exit Sub
        End If

        Dim kodePart As String = cmbPilihPart.SelectedValue.ToString()
        Dim namaPart As String = cmbPilihPart.Text
        Dim harga As Decimal = CDec(txtHargaPart.Text.Trim())

        If Not CekStokCukup(kodePart, jumlah) Then
            MessageBox.Show("Stok tidak mencukupi! " & txtStokPart.Text,
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataRow In dtKeranjang.Rows
            If row("KodePart").ToString() = kodePart Then
                Dim jumlahBaru As Integer = Convert.ToInt32(row("Jumlah")) + jumlah
                If Not CekStokCukup(kodePart, jumlahBaru) Then
                    MessageBox.Show("Total jumlah melebihi stok! " & txtStokPart.Text,
                                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                row("Jumlah") = jumlahBaru
                row("Subtotal") = CDec(row("HargaSatuan")) * jumlahBaru
                TampilKeranjang()
                Exit Sub
            End If
        Next

        Dim newRow As DataRow = dtKeranjang.NewRow()
        newRow("KodePart") = kodePart
        newRow("NamaPart") = namaPart
        newRow("HargaSatuan") = harga
        newRow("Jumlah") = jumlah
        newRow("Subtotal") = harga * jumlah
        dtKeranjang.Rows.Add(newRow)
        TampilKeranjang()
    End Sub

    Private Sub btnHapusItem_Click(sender As Object, e As EventArgs) Handles btnHapusItem.Click
        If dgvKeranjang.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih item yang akan dihapus dari keranjang!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        dtKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index)
        TampilKeranjang()
    End Sub

    Private Sub btnSimpanTransaksi_Click(sender As Object, e As EventArgs) Handles btnSimpanTransaksi.Click
        If txtNamaPembeli.Text.Trim() = "" Then
            MessageBox.Show("Nama pembeli tidak boleh kosong!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaPembeli.Focus()
            Exit Sub
        End If
        If dtKeranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang masih kosong! Tambah part terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim totalItem As Integer = 0
        Dim totalHarga As Decimal = 0
        For Each row As DataRow In dtKeranjang.Rows
            totalItem += Convert.ToInt32(row("Jumlah"))
            totalHarga += Convert.ToDecimal(row("Subtotal"))
        Next

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Simpan transaksi penjualan?" & vbNewLine &
                            "Total: Rp " & totalHarga.ToString("N0"),
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If SimpanPenjualan(
                txtNomorNota.Text.Trim(),
                dtpTanggal.Value.ToString("yyyy-MM-dd"),
                txtNamaPembeli.Text.Trim(),
                totalItem, totalHarga,
                txtKeterangan.Text.Trim(),
                dtKeranjang) Then

                MessageBox.Show("Transaksi berhasil disimpan!" & vbNewLine &
                                "No. Nota: " & txtNomorNota.Text,
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilRiwayat()
                ResetFormTransaksi()
                IsiCmbPart()
            End If
        End If
    End Sub

    Private Sub btnBatalTransaksi_Click(sender As Object, e As EventArgs) Handles btnBatalTransaksi.Click
        If dtKeranjang.Rows.Count > 0 Then
            Dim konfirmasi As DialogResult =
                MessageBox.Show("Batalkan transaksi ini? Keranjang akan dikosongkan.",
                                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.No Then Exit Sub
        End If
        ResetFormTransaksi()
    End Sub

    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim nota As String = dgvRiwayat.Rows(e.RowIndex).Cells("NomorNota").Value.ToString()

        dgvDetail.DataSource = GetDetailPenjualan(nota)

        For Each col As DataGridViewColumn In dgvDetail.Columns
            If col.Name.Contains("Harga") Or col.Name.Contains("Subtotal") Then
                col.DefaultCellStyle.Format = "N0"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next

        lblNomorNotaDetail.Text = "Detail Nota: " & nota
    End Sub

    Private Sub btnHapusNota_Click(sender As Object, e As EventArgs) Handles btnHapusNota.Click
        If dgvRiwayat.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih nota yang akan dihapus!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim nota As String = dgvRiwayat.CurrentRow.Cells("NomorNota").Value.ToString()
        Dim konfirmasi As DialogResult =
            MessageBox.Show("Hapus nota " & nota & "?" & vbNewLine &
                            "Stok part akan dikembalikan.",
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusPenjualan(nota) Then
                MessageBox.Show("Nota berhasil dihapus, stok dikembalikan.",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvDetail.DataSource = Nothing
                lblNomorNotaDetail.Text = "Detail Nota: -"
                TampilRiwayat()
                IsiCmbPart()
            End If
        End If
    End Sub

    Private Sub txtSearchNota_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNota.TextChanged
        JalankanFilterRiwayat()
    End Sub

    Private Sub dtpFilterMulai_ValueChanged(sender As Object, e As EventArgs)
        If chkFilterTanggal.Checked Then JalankanFilterRiwayat
    End Sub

    Private Sub dtpFilterAkhir_ValueChanged(sender As Object, e As EventArgs)
        If chkFilterTanggal.Checked Then JalankanFilterRiwayat
    End Sub

    Private Sub chkFilterTanggal_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterTanggal.CheckedChanged
        dtpFilterMulai.Enabled = chkFilterTanggal.Checked
        dtpFilterAkhir.Enabled = chkFilterTanggal.Checked
        JalankanFilterRiwayat()
    End Sub

    Private Sub JalankanFilterRiwayat()
        Dim keyword  As String = txtSearchNota.Text.Trim()
        Dim tglMulai As String = ""
        Dim tglAkhir As String = ""
        If chkFilterTanggal.Checked Then
            tglMulai = dtpFilterMulai.Value.ToString("yyyy-MM-dd")
            tglAkhir = dtpFilterAkhir.Value.ToString("yyyy-MM-dd")
        End If
        dgvRiwayat.DataSource = FilterPenjualan(keyword, tglMulai, tglAkhir)
        lblJumlahNota.Text = "Total Nota: " & dgvRiwayat.RowCount
    End Sub

    Private Sub btnResetFilterNota_Click(sender As Object, e As EventArgs) Handles btnResetFilterNota.Click
        txtSearchNota.Clear()
        chkFilterTanggal.Checked = False
        TampilRiwayat()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub txtJumlahBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBeli.KeyPress
        HanyaAngka(e)
    End Sub

End Class
