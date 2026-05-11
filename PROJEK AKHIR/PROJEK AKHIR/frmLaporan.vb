Imports System.IO
Imports System.Text
Imports MySqlConnector

Public Class frmLaporan

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlKartu.Controls.Clear()

        ' Panggil prosedur BuatKartuRingkasan untuk masing-masing data
        ' Format: (Label_Angka, Label_Judul, Teks_Judul, Posisi_X, Warna_Aksen)
        BuatKartuRingkasan(Me.lblTotalTrx, Me.lblTotalTrxLbl, "Total Transaksi", 0, Color.FromArgb(255, 140, 0))
        BuatKartuRingkasan(Me.lblTotalOmzet, Me.lblTotalOmzetLbl, "Total Omzet", 228, Color.FromArgb(46, 204, 113))
        BuatKartuRingkasan(Me.lblTotalLunas, Me.lblTotalLunasLbl, "Sudah Lunas", 456, Color.FromArgb(52, 152, 219))
        BuatKartuRingkasan(Me.lblTotalBelum, Me.lblTotalBelumLbl, "Belum Lunas", 684, Color.FromArgb(231, 76, 60))
        ' Default filter: bulan ini
        dtpDari.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpSampai.Value = Now.Date

        MuatLaporanPenjualan()
    End Sub

    ' Prosedur untuk membuat kartu secara dinamis tanpa merusak Designer
    Private Sub BuatKartuRingkasan(ByRef lblVal As Label, ByRef lblLbl As Label, caption As String, x As Integer, accent As Color)
        ' 1. Buat Panel pembungkus kartu
        Dim pnl As New Panel
        pnl.BackColor = Color.FromArgb(26, 29, 42)
        pnl.Size = New Size(220, 58)
        pnl.Location = New Point(x, 10)

        ' 2. Buat garis aksen warna di samping kanan
        Dim acc As New Panel()
        acc.BackColor = accent
        acc.Size = New Size(4, 58)
        acc.Location = New Point(216, 0)

        ' 3. Atur Label Nilai (Angka)
        lblVal.Text = "0"
        lblVal.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblVal.ForeColor = Color.FromArgb(232, 232, 240)
        lblVal.AutoSize = True
        lblVal.Location = New Point(12, 8)

        ' 4. Atur Label Keterangan (Teks)
        lblLbl.Text = caption
        lblLbl.Font = New Font("Segoe UI", 8)
        lblLbl.ForeColor = Color.FromArgb(85, 102, 119)
        lblLbl.AutoSize = True
        lblLbl.Location = New Point(12, 36)

        ' 5. Masukkan ke dalam panel kartu, lalu masukkan ke panel utama (pnlKartu)
        pnl.Controls.Add(acc)
        pnl.Controls.Add(lblVal)
        pnl.Controls.Add(lblLbl)
        Me.pnlKartu.Controls.Add(pnl)
    End Sub

    ' ================================================================
    '  TAB BERUBAH
    ' ================================================================
    Private Sub tabLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabLaporan.SelectedIndexChanged
        Select Case tabLaporan.SelectedIndex
            Case 0 : MuatLaporanPenjualan()
            Case 1 : MuatLaporanStok()
        End Select
    End Sub

    ' ================================================================
    '  MUAT LAPORAN PENJUALAN
    ' ================================================================
    Private Sub MuatLaporanPenjualan()
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim sql As String =
                "SELECT no_transaksi, tgl_transaksi, jenis, nama_pelanggan, " &
                "       nama_kasir, total_harga, status_bayar " &
                "FROM v_laporan_penjualan " &
                "WHERE DATE(tgl_transaksi) BETWEEN @dari AND @sampai " &
                "ORDER BY tgl_transaksi DESC"

            ' PERBAIKAN: Menggunakan MySqlCommand langsung (tanpa MySql.Data)
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@dari", dtpDari.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@sampai", dtpSampai.Value.ToString("yyyy-MM-dd"))

                ' PERBAIKAN: Menggunakan MySqlDataAdapter langsung
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvLaporan.DataSource = dt
                AturKolomPenjualan()
                HitungRingkasanPenjualan(dt)
                UpdateStatusBar(dt.Rows.Count)
            End Using

        Catch ex As Exception
            MsgBox("Error muat laporan penjualan: " & ex.Message)
        End Try
    End Sub

    Private Sub AturKolomPenjualan()
        With dgvLaporan
            If .Columns.Contains("no_transaksi") Then .Columns("no_transaksi").HeaderText = "No. Transaksi"
            If .Columns.Contains("tgl_transaksi") Then .Columns("tgl_transaksi").HeaderText = "Tanggal"
            If .Columns.Contains("jenis") Then .Columns("jenis").HeaderText = "Jenis"
            If .Columns.Contains("nama_pelanggan") Then .Columns("nama_pelanggan").HeaderText = "Pelanggan"
            If .Columns.Contains("nama_kasir") Then .Columns("nama_kasir").HeaderText = "Kasir"
            If .Columns.Contains("total_harga") Then
                .Columns("total_harga").HeaderText = "Total"
                .Columns("total_harga").DefaultCellStyle.Format = "N0"
            End If
            If .Columns.Contains("status_bayar") Then .Columns("status_bayar").HeaderText = "Status"
        End With
        WarnaiPenjualan()
    End Sub

    Private Sub WarnaiPenjualan()
        For Each row As DataGridViewRow In dgvLaporan.Rows
            If row.IsNewRow Then Continue For
            Select Case If(row.Cells("status_bayar").Value IsNot Nothing, row.Cells("status_bayar").Value.ToString(), "")
                Case "lunas"
                    row.Cells("status_bayar").Style.ForeColor = Drawing.Color.FromArgb(46, 204, 113)
                Case "belum"
                    row.Cells("status_bayar").Style.ForeColor = Drawing.Color.FromArgb(231, 76, 60)
            End Select
            Select Case If(row.Cells("jenis").Value IsNot Nothing, row.Cells("jenis").Value.ToString(), "")
                Case "part"
                    row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(52, 152, 219)
                Case "servis"
                    row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(255, 140, 0)
                Case "keduanya"
                    row.Cells("jenis").Style.ForeColor = Drawing.Color.FromArgb(168, 100, 220)
            End Select
        Next
    End Sub

    Private Sub HitungRingkasanPenjualan(dt As DataTable)
        Dim totalTrx As Integer = dt.Rows.Count
        Dim totalOmzet As Decimal = 0
        Dim totalLunas As Decimal = 0
        Dim totalBelum As Decimal = 0

        For Each row As DataRow In dt.Rows
            Dim nominal As Decimal = Convert.ToDecimal(row("total_harga"))
            totalOmzet += nominal
            If row("status_bayar").ToString() = "lunas" Then
                totalLunas += nominal
            Else
                totalBelum += nominal
            End If
        Next

        lblTotalTrx.Text = totalTrx.ToString()
        lblTotalOmzet.Text = "Rp " & Format(totalOmzet, "#,##0")
        lblTotalLunas.Text = "Rp " & Format(totalLunas, "#,##0")
        lblTotalBelum.Text = "Rp " & Format(totalBelum, "#,##0")
    End Sub

    ' ================================================================
    '  MUAT LAPORAN STOK
    ' ================================================================
    Private Sub MuatLaporanStok()
        Dim dt As DataTable = GetStokSparepart()
        If dt Is Nothing Then Exit Sub

        dgvLaporan.DataSource = dt
        AturKolomStok()
        UpdateStatusBar(dt.Rows.Count)

        ' Sembunyikan kartu ringkasan (tidak relevan untuk stok)
        pnlKartu.Visible = False
    End Sub

    Private Sub AturKolomStok()
        With dgvLaporan
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
    End Sub

    Private Sub WarnaiStok()
        For Each row As DataGridViewRow In dgvLaporan.Rows
            If row.IsNewRow Then Continue For
            Select Case If(row.Cells("keterangan_stok").Value IsNot Nothing, row.Cells("keterangan_stok").Value.ToString(), "")
                Case "Habis"
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(231, 76, 60)
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(30, 14, 14)
                Case "Hampir Habis"
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 140, 0)
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(30, 24, 12)
                Case Else
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(138, 153, 153)
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(19, 21, 31)
            End Select
        Next
    End Sub

    Private Sub UpdateStatusBar(jumlah As Integer)
        lblStatusBar.Text = "Menampilkan " & jumlah & " data"
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

        If tabLaporan.SelectedIndex = 0 Then
            pnlKartu.Visible = True
            MuatLaporanPenjualan()
        Else
            MuatLaporanStok()
        End If
    End Sub

    Private Sub btnHariIni_Click(sender As Object, e As EventArgs) Handles btnHariIni.Click
        dtpDari.Value = Now.Date
        dtpSampai.Value = Now.Date
        btnTampilkan_Click(Nothing, Nothing)
    End Sub

    Private Sub btnBulanIni_Click(sender As Object, e As EventArgs) Handles btnBulanIni.Click
        dtpDari.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpSampai.Value = Now.Date
        btnTampilkan_Click(Nothing, Nothing)
    End Sub

    ' ================================================================
    '  EXPORT CSV
    ' ================================================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvLaporan.Rows.Count = 0 Then
            MsgBox("Tidak ada data untuk di-export.", MsgBoxStyle.Exclamation, "Export")
            Exit Sub
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = "Laporan_" & Format(Now, "yyyyMMdd_HHmm") & ".csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim sb As New StringBuilder()

                ' Header kolom
                Dim headers As New List(Of String)
                For Each col As DataGridViewColumn In dgvLaporan.Columns
                    If col.Visible Then headers.Add(col.HeaderText)
                Next
                sb.AppendLine(String.Join(",", headers))

                ' Isi data
                For Each row As DataGridViewRow In dgvLaporan.Rows
                    If row.IsNewRow Then Continue For
                    Dim cells As New List(Of String)
                    For Each col As DataGridViewColumn In dgvLaporan.Columns
                        If col.Visible Then
                            ' PERBAIKAN: Mengganti ?. dan ?? dengan fungsi If() VB.NET
                            Dim cellVal = row.Cells(col.Index).Value
                            Dim val As String = If(cellVal IsNot Nothing, cellVal.ToString(), "")

                            ' Escape koma dan tanda kutip
                            If val.Contains(",") OrElse val.Contains("""") Then
                                val = """" & val.Replace("""", """""") & """"
                            End If
                            cells.Add(val)
                        End If
                    Next
                    sb.AppendLine(String.Join(",", cells))
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                MsgBox("Data berhasil diexport ke:" & vbNewLine & sfd.FileName,
                       MsgBoxStyle.Information, "Export Berhasil")
            End If
        End Using
    End Sub

End Class
