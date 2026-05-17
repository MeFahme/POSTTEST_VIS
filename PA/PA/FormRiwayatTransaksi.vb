Imports MySqlConnector

Public Class FormRiwayatTransaksi

    Private Sub FormRiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur format mata uang sesuai Indonesia
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")

        ' Atur default tanggal filter
        dtpDari.Value = New DateTime(Now.Year, Now.Month, 1)
        dtpSampai.Value = Now

        ' Sembunyikan panel detail di awal
        pnlDetail.Visible = False

        TampilkanRiwayat()
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanRiwayat()
        pnlDetail.Visible = False
    End Sub

    Private Sub TampilkanRiwayat()
        Try
            Dim tglDari As String = dtpDari.Value.ToString("yyyy-MM-dd") & " 00:00:00"
            Dim tglSampai As String = dtpSampai.Value.ToString("yyyy-MM-dd") & " 23:59:59"

            Dim query As String = "SELECT no_transaksi AS 'No Transaksi', " &
                                  "tgl_transaksi AS 'Tanggal', " &
                                  "jenis AS 'Jenis', " &
                                  "nama_pelanggan AS 'Pelanggan', " &
                                  "no_hp AS 'No HP', " &
                                  "nama_kasir AS 'Kasir', " &
                                  "total_harga AS 'Total Harga', " &
                                  "status_bayar AS 'Status' " &
                                  "FROM v_laporan_penjualan " &
                                  "WHERE tgl_transaksi BETWEEN '" & tglDari & "' AND '" & tglSampai & "'"

            DataModule.LoadToDGV(query, dgvRiwayat)

            ' Atur lebar & format kolom dgvRiwayat (Gaya ringkas sesuai referensi)
            If dgvRiwayat.ColumnCount > 0 Then
                dgvRiwayat.Columns("Total Harga").DefaultCellStyle.Format = "C0"
                dgvRiwayat.Columns("Tanggal").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"

                ' Kolom Pelanggan otomatis memenuhi ruang kosong tabel
                dgvRiwayat.Columns("Pelanggan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal memuat riwayat: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            ' Ambil No Transaksi dari baris dgvRiwayat yang diklik
            Dim noTrx As String = dgvRiwayat.Rows(e.RowIndex).Cells("No Transaksi").Value.ToString()

            ' 1. Ambil Data Detail Sparepart ke dgvDetail
            Dim queryDetail As String = "SELECT dt.id_part AS 'ID Part', sp.nama_part AS 'Nama Sparepart', " &
                                        "dt.harga_satuan AS 'Harga Satuan', dt.qty AS 'Qty', dt.subtotal AS 'Subtotal' " &
                                        "FROM detail_transaksi dt " &
                                        "JOIN sparepart sp ON dt.id_part = sp.id_part " &
                                        "WHERE dt.no_transaksi = '" & noTrx & "'"

            DataModule.LoadToDGV(queryDetail, dgvDetail)

            ' Atur format & lebar kolom dgvDetail agar rapi (Sesuai referensi ringkas Anda)
            If dgvDetail.ColumnCount > 0 Then
                If dgvDetail.Columns.Contains("ID Part") Then dgvDetail.Columns("ID Part").Visible = False
                dgvDetail.Columns("Harga Satuan").DefaultCellStyle.Format = "C0"
                dgvDetail.Columns("Subtotal").DefaultCellStyle.Format = "C0"

                ' Solusi Lebar Kolom: Qty pas dengan isinya, Nama Sparepart memenuhi sisa tabel
                dgvDetail.Columns("Qty").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvDetail.Columns("Nama Sparepart").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            ' 2. Isi data teks ke Label Detail Utama
            lblDetNoTrx.Text = noTrx
            lblDetPelanggan.Text = dgvRiwayat.Rows(e.RowIndex).Cells("Pelanggan").Value.ToString()
            lblDetNoHp.Text = dgvRiwayat.Rows(e.RowIndex).Cells("No HP").Value.ToString()
            lblDetJenis.Text = dgvRiwayat.Rows(e.RowIndex).Cells("Jenis").Value.ToString()
            lblDetStatus.Text = dgvRiwayat.Rows(e.RowIndex).Cells("Status").Value.ToString()

            Dim tgl As DateTime = Convert.ToDateTime(dgvRiwayat.Rows(e.RowIndex).Cells("Tanggal").Value)
            lblDetWaktu.Text = tgl.ToString("dd MMMM yyyy HH:mm")

            Dim total As Decimal = Convert.ToDecimal(dgvRiwayat.Rows(e.RowIndex).Cells("Total Harga").Value)
            lblDetTotal.Text = total.ToString("C0")

            ' 3. Tarik data dari TABLE servis jika jenis transaksinya melibatkan Servis
            Dim jenisTrx As String = dgvRiwayat.Rows(e.RowIndex).Cells("Jenis").Value.ToString().ToLower()

            If jenisTrx = "servis" OrElse jenisTrx = "keduanya" Then
                pnlServiceInfo.Visible = True

                ' Query mengambil data status, biaya jasa, dan nama mekanik dari database
                Dim queryServis As String = "SELECT s.status, s.biaya_jasa, u.nama AS nama_mekanik " &
                                            "FROM servis s " &
                                            "JOIN users u ON s.id_mekanik = u.id_user " &
                                            "WHERE s.no_transaksi = @no_trx"

                BukaKoneksi()
                Using cmd As New MySqlCommand(queryServis, conn)
                    cmd.Parameters.AddWithValue("@no_trx", noTrx)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Tampilkan data ke label yang ada di dalam pnlServiceInfo Anda
                            lblDetStatusMotor.Text = reader("status").ToString().ToUpper()
                            lblDetMekanik.Text = reader("nama_mekanik").ToString()
                            Dim biayaJasa As Decimal = Convert.ToDecimal(reader("biaya_jasa"))
                            lblDetBiayaJasa.Text = biayaJasa.ToString("C0")
                        End If
                    End Using
                End Using
                TutupKoneksi()
            Else
                ' Sembunyikan panel jika hanya transaksi penjualan sparepart saja
                pnlServiceInfo.Visible = False
            End If

            ' Munculkan panel detail utama setelah semua data siap
            pnlDetail.Visible = True

        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal memuat detail transaksi: " & ex.Message)
            TutupKoneksi() ' Memastikan koneksi ditutup jika terjadi error mendadak
        End Try
    End Sub
End Class