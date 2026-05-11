Imports MySqlConnector
Public Class frmRiwayatTransaksi

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmRiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = Now.Date
        dtpSampai.Value = Now.Date
        MuatRiwayat()
        BersihkanDetail()
    End Sub

    ' ================================================================
    '  MUAT RIWAYAT TRANSAKSI
    ' ================================================================
    Private Sub MuatRiwayat()
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim sql As String =
                "SELECT no_transaksi, tgl_transaksi, nama_pelanggan, no_hp, " &
                "       jenis, total_harga, status_bayar " &
                "FROM transaksi " &
                "WHERE DATE(tgl_transaksi) BETWEEN @dari AND @sampai " &
                "ORDER BY tgl_transaksi DESC"

            ' PERBAIKAN: Hapus awalan 'MySql.Data.MySqlClient'
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@dari", dtpDari.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@sampai", dtpSampai.Value.ToString("yyyy-MM-dd"))

                ' PERBAIKAN: Gunakan MySqlDataAdapter langsung
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvRiwayat.DataSource = dt
                AturKolom()
                WarnaiStatus()
                UpdateStatusBar(dt)
            End Using

        Catch ex As Exception
            MsgBox("Error muat riwayat: " & ex.Message)
        End Try
    End Sub

    Private Sub AturKolom()
        With dgvRiwayat
            If .Columns.Contains("no_transaksi") Then .Columns("no_transaksi").HeaderText = "No. Transaksi"
            If .Columns.Contains("tgl_transaksi") Then .Columns("tgl_transaksi").HeaderText = "Waktu"
            If .Columns.Contains("nama_pelanggan") Then .Columns("nama_pelanggan").HeaderText = "Pelanggan"
            If .Columns.Contains("no_hp") Then .Columns("no_hp").Visible = False
            If .Columns.Contains("jenis") Then .Columns("jenis").HeaderText = "Jenis"
            If .Columns.Contains("total_harga") Then
                .Columns("total_harga").HeaderText = "Total"
                .Columns("total_harga").DefaultCellStyle.Format = "N0"
            End If
            If .Columns.Contains("status_bayar") Then .Columns("status_bayar").HeaderText = "Status"
        End With
    End Sub

    Private Sub WarnaiStatus()
        For Each row As DataGridViewRow In dgvRiwayat.Rows
            If row.IsNewRow Then Continue For
            Select Case row.Cells("status_bayar").Value?.ToString()
                Case "lunas"
                    row.Cells("status_bayar").Style.ForeColor = Drawing.Color.FromArgb(46, 204, 113)
                Case "belum"
                    row.Cells("status_bayar").Style.ForeColor = Drawing.Color.FromArgb(231, 76, 60)
            End Select
            Select Case row.Cells("jenis").Value?.ToString()
                Case "part" : row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(52, 152, 219)
                Case "servis" : row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(255, 140, 0)
                Case "keduanya" : row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(168, 100, 220)
            End Select
        Next
    End Sub

    Private Sub UpdateStatusBar(dt As DataTable)
        Dim lunas As Integer = 0
        Dim belum As Integer = 0
        Dim total As Decimal = 0

        For Each row As DataRow In dt.Rows
            If row("status_bayar").ToString() = "lunas" Then lunas += 1 Else belum += 1
            total += Convert.ToDecimal(row("total_harga"))
        Next

        lblStatusBar.Text = String.Format(
            "{0} transaksi   |   Lunas: {1}   |   Belum: {2}   |   Total: Rp {3}",
            dt.Rows.Count, lunas, belum, Format(total, "#,##0"))
    End Sub

    ' ================================================================
    '  KLIK BARIS — tampilkan detail di panel kanan
    ' ================================================================
    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim noTrx As String = dgvRiwayat.Rows(e.RowIndex).Cells("no_transaksi").Value?.ToString()
        If String.IsNullOrEmpty(noTrx) Then Exit Sub
        MuatDetail(noTrx, e.RowIndex)
    End Sub

    Private Sub MuatDetail(noTrx As String, rowIndex As Integer)
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim row As DataGridViewRow = dgvRiwayat.Rows(rowIndex)
            lblDetNoTrx.Text = noTrx
            lblDetPelanggan.Text = row.Cells("nama_pelanggan").Value?.ToString()
            lblDetNoHp.Text = row.Cells("no_hp").Value?.ToString()
            lblDetJenis.Text = row.Cells("jenis").Value?.ToString().Replace("keduanya", "Servis + Part")
            lblDetWaktu.Text = Format(Convert.ToDateTime(row.Cells("tgl_transaksi").Value), "dd/MM/yyyy HH:mm")
            lblDetTotal.Text = "Rp " & Format(Convert.ToDecimal(row.Cells("total_harga").Value), "#,##0")

            Dim statusBayar As String = row.Cells("status_bayar").Value?.ToString()
            lblDetStatus.Text = statusBayar.ToUpper()
            lblDetStatus.ForeColor = If(statusBayar = "lunas",
                Drawing.Color.FromArgb(46, 204, 113),
                Drawing.Color.FromArgb(231, 76, 60))

            ' Muat detail part
            Dim sqlDetail As String =
                "SELECT sp.nama_part, dt.qty, dt.harga_satuan, dt.subtotal " &
                "FROM detail_transaksi dt " &
                "JOIN sparepart sp ON dt.id_part = sp.id_part " &
                "WHERE dt.no_transaksi = @no"

            ' PERBAIKAN: Gunakan MySqlCommand dan MySqlDataAdapter tanpa prefix MySql.Data
            Using cmd As New MySqlCommand(sqlDetail, KoneksiDB)
                cmd.Parameters.AddWithValue("@no", noTrx)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dtDetail As New DataTable()
                da.Fill(dtDetail)

                dgvDetail.DataSource = dtDetail
                ' ... (Pengaturan kolom dgvDetail)
            End Using

            ' Muat info servis jika ada
            Dim sqlServis As String =
                "SELECT no_polisi, merk_motor, biaya_jasa, status " &
                "FROM servis WHERE no_transaksi = @no LIMIT 1"

            ' PERBAIKAN: Gunakan MySqlCommand dan MySqlDataAdapter tanpa prefix MySql.Data
            Using cmd As New MySqlCommand(sqlServis, KoneksiDB)
                cmd.Parameters.AddWithValue("@no", noTrx)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dtServis As New DataTable()
                da.Fill(dtServis)

                If dtServis.Rows.Count > 0 Then
                    Dim rs As DataRow = dtServis.Rows(0)
                    lblDetServis.Text = rs("no_polisi") & " · " & rs("merk_motor")
                    lblDetBiayaJasa.Text = "Rp " & Format(Convert.ToDecimal(rs("biaya_jasa")), "#,##0")
                    lblDetStatusMotor.Text = rs("status").ToString().Replace("_", " ").ToUpper()
                    pnlServisInfo.Visible = True
                Else
                    pnlServisInfo.Visible = False
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error muat detail: " & ex.Message)
        End Try
    End Sub

    Private Sub BersihkanDetail()
        lblDetNoTrx.Text = "-"
        lblDetPelanggan.Text = "-"
        lblDetNoHp.Text = "-"
        lblDetJenis.Text = "-"
        lblDetWaktu.Text = "-"
        lblDetTotal.Text = "-"
        lblDetStatus.Text = "-"
        dgvDetail.DataSource = Nothing
        pnlServisInfo.Visible = False
    End Sub

    ' ================================================================
    '  TOMBOL FILTER
    ' ================================================================
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If dtpDari.Value > dtpSampai.Value Then
            MsgBox("Tanggal 'Dari' tidak boleh lebih besar dari 'Sampai'.",
                   MsgBoxStyle.Exclamation, "Filter Tidak Valid")
            Exit Sub
        End If
        BersihkanDetail()
        MuatRiwayat()
    End Sub

    Private Sub btnHariIni_Click(sender As Object, e As EventArgs) Handles btnHariIni.Click
        dtpDari.Value = Now.Date
        dtpSampai.Value = Now.Date
        BersihkanDetail()
        MuatRiwayat()
    End Sub

End Class
