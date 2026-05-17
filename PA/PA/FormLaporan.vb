Imports MySqlConnector
Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        dtpDari.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpSampai.Value = Now

        TampilkanLaporanPenjualan()
        TampilkanLaporanStok()
        HitungRingkasan()
        HitungRingkasanStok()
    End Sub
    Sub TampilkanLaporanPenjualan()
        Dim sql As String = "SELECT t.no_transaksi, t.tgl_transaksi, t.nama_pelanggan, u.nama As Kasir, " &
                       "CASE " &
                       "  WHEN (SELECT COUNT(*) FROM detail_transaksi WHERE no_transaksi = t.no_transaksi) > 0 " &
                       "       AND (SELECT COUNT(*) FROM servis WHERE no_transaksi = t.no_transaksi) > 0 THEN 'Service + Part' " &
                       "  WHEN (SELECT COUNT(*) FROM servis WHERE no_transaksi = t.no_transaksi) > 0 THEN 'Service' " &
                       "  ELSE 'Part' " &
                       "END As jenis_layanan, " &
                       "t.total_harga, t.status_bayar " &
                       "FROM transaksi t " &
                       "JOIN users u ON t.id_user = u.id_user " &
                       "WHERE t.tgl_transaksi BETWEEN @tgl1 AND @tgl2 " &
                       "ORDER BY t.tgl_transaksi DESC"
        Dim tgl1 As String = dtpDari.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim tgl2 As String = dtpSampai.Value.ToString("yyyy-MM-dd 23:59:59")
        Dim filterSql As String = sql.Replace("@tgl1", "'" & tgl1 & "'").Replace("@tgl2", "'" & tgl2 & "'")
        DataModule.LoadToDGV(filterSql, dgvLaporan)
        AturDGVLaporan()
    End Sub

    Sub TampilkanLaporanStok()
        Dim sql As String = "SELECT nama_part, kategori, merk_motor, stok, harga_jual FROM sparepart ORDER BY stok ASC"
        DataModule.LoadToDGV(sql, dgvStok)
        AturDGVStok()
    End Sub
    Sub HitungRingkasan()
        Try
            BukaKoneksi()
            Dim tgl1 As String = dtpDari.Value.ToString("yyyy-MM-dd 00:00:00")
            Dim tgl2 As String = dtpSampai.Value.ToString("yyyy-MM-dd 23:59:59")
            Dim sqlOmzet As String = "SELECT SUM(total_harga) FROM transaksi WHERE status_bayar = 'lunas' AND tgl_transaksi BETWEEN @t1 AND @t2"
            Using cmd As New MySqlCommand(sqlOmzet, conn)
                cmd.Parameters.AddWithValue("@t1", tgl1)
                cmd.Parameters.AddWithValue("@t2", tgl2)
                Dim res = cmd.ExecuteScalar()
                lblTotalOmzet.Text = If(IsDBNull(res), "Rp 0", "Rp " & Convert.ToDecimal(res).ToString("N0"))
            End Using
            Dim sqlTrx As String = "SELECT COUNT(*) FROM transaksi WHERE tgl_transaksi BETWEEN @t1 AND @t2"
            Using cmd As New MySqlCommand(sqlTrx, conn)
                cmd.Parameters.AddWithValue("@t1", tgl1)
                cmd.Parameters.AddWithValue("@t2", tgl2)
                lblTotalTrx.Text = cmd.ExecuteScalar().ToString()
            End Using
            Dim sqlLunas As String = "SELECT SUM(total_harga) FROM transaksi WHERE status_bayar = 'lunas' AND tgl_transaksi BETWEEN @t1 AND @t2"
            Using cmd As New MySqlCommand(sqlLunas, conn)
                cmd.Parameters.AddWithValue("@t1", tgl1)
                cmd.Parameters.AddWithValue("@t2", tgl2)
                Dim res = cmd.ExecuteScalar()
                lblTotalLunas.Text = If(IsDBNull(res) OrElse res Is Nothing, "Rp 0", "Rp " & Convert.ToDecimal(res).ToString("N0"))
            End Using
            Dim sqlBelum As String = "SELECT SUM(total_harga) FROM transaksi WHERE status_bayar = 'belum' AND tgl_transaksi BETWEEN @t1 AND @t2"
            Using cmd As New MySqlCommand(sqlBelum, conn)
                cmd.Parameters.AddWithValue("@t1", tgl1)
                cmd.Parameters.AddWithValue("@t2", tgl2)
                Dim res = cmd.ExecuteScalar()
                lblTotalBelum.Text = If(IsDBNull(res), "Rp 0", "Rp " & Convert.ToDecimal(res).ToString("N0"))
            End Using
        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal hitung ringkasan: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Sub HitungRingkasanStok()
        Try
            BukaKoneksi()
            Dim sqlKritis As String = "SELECT COUNT(*) FROM sparepart WHERE stok < 5"
            Using cmd As New MySqlCommand(sqlKritis, conn)
                lblStokKritis.Text = cmd.ExecuteScalar().ToString() & " Item"
            End Using
            Dim sqlAset As String = "SELECT SUM(stok * harga_jual) FROM sparepart"
            Using cmd As New MySqlCommand(sqlAset, conn)
                Dim res = cmd.ExecuteScalar()
                lblTotalAset.Text = If(IsDBNull(res), "Rp 0", "Rp " & Convert.ToDecimal(res).ToString("N0"))
            End Using
            Dim sqlTotal As String = "SELECT COUNT(*) FROM sparepart"
            Using cmd As New MySqlCommand(sqlTotal, conn)
                lblTotalItem.Text = cmd.ExecuteScalar().ToString() & " Jenis"
            End Using
        Catch ex As Exception
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Sub AturDGVLaporan()
        If dgvLaporan.ColumnCount > 0 Then
            dgvLaporan.Columns(0).HeaderText = "No. Transaksi"
            dgvLaporan.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvLaporan.Columns(1).HeaderText = "Tanggal"
            dgvLaporan.Columns(1).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dgvLaporan.Columns(1).Width = 130
            dgvLaporan.Columns(2).HeaderText = "Pelanggan"
            dgvLaporan.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvLaporan.Columns(3).HeaderText = "Kasir"
            dgvLaporan.Columns(4).HeaderText = "Jenis Layanan"
            dgvLaporan.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvLaporan.Columns(5).HeaderText = "Total Harga"
            dgvLaporan.Columns(5).DefaultCellStyle.Format = "N0"
            dgvLaporan.Columns(6).HeaderText = "Status"
        End If
    End Sub
    Sub AturDGVStok()
        If dgvStok.ColumnCount > 0 Then
            dgvStok.Columns(0).HeaderText = "Nama Sparepart"
            dgvStok.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvStok.Columns(1).HeaderText = "Kategori"

            ' Menambahkan pengaturan untuk kolom baru (index 2)
            dgvStok.Columns(2).HeaderText = "Merk Motor"

            dgvStok.Columns(3).HeaderText = "Stok"
            dgvStok.Columns(4).HeaderText = "Harga Jual"
            dgvStok.Columns(4).DefaultCellStyle.Format = "N0"
        End If
    End Sub
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanLaporanPenjualan()
        HitungRingkasan()
    End Sub
    Private Sub btnHariIni_Click(sender As Object, e As EventArgs) Handles btnHariIni.Click
        dtpDari.Value = Now
        dtpSampai.Value = Now
        btnTampilkan.PerformClick()
    End Sub
    Private Sub btnBulanIni_Click(sender As Object, e As EventArgs) Handles btnBulanIni.Click
        dtpDari.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpSampai.Value = Now
        btnTampilkan.PerformClick()
    End Sub
End Class