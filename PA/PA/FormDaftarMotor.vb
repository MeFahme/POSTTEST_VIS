Imports MySqlConnector

Public Class FormDaftarMotor

    Private Sub FormDaftarMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set kultur mata uang & tanggal ke Indonesia
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")

        ' Muat data ke GridView saat form pertama kali dibuka
        RefreshData()
    End Sub

    ''' <summary>
    ''' Memperbarui data kendaraan di kedua DataGridView
    ''' </summary>
    Public Sub RefreshData()
        MuatMotorAktif()
        MuatMotorSelesai()
    End Sub

    ''' <summary>
    ''' Mengambil data motor yang statusnya masih antri, proses, atau menunggu part
    ''' </summary>
    Private Sub MuatMotorAktif()
        ' Menggunakan View v_status_motor yang sudah ada di database Anda
        Dim sql As String = "SELECT no_servis, no_polisi, nama_pelanggan, merk_motor, status, keluhan, nama_mekanik " &
                            "FROM v_status_motor " &
                            "WHERE status IN ('antri', 'proses', 'menunggu_part') " &
                            "ORDER BY tgl_masuk ASC"

        DataModule.LoadToDGV(sql, dgvMotorAktif)
        AturFormatGrid(dgvMotorAktif)

        ' Update info total motor aktif di lblStatusBar
        Dim jumlahAktif As Integer = dgvMotorAktif.Rows.Count
        lblStatusBar.Text = "Motor aktif dalam bengkel: " & jumlahAktif & " Unit"
    End Sub

    ''' <summary>
    ''' Mengambil data motor yang status servisnya sudah selesai
    ''' </summary>
    Private Sub MuatMotorSelesai()
        Dim sql As String = "SELECT no_servis, no_polisi, nama_pelanggan, merk_motor, status, catatan_terakhir, tgl_selesai " &
                            "FROM v_status_motor " &
                            "WHERE status = 'selesai' " &
                            "ORDER BY tgl_selesai DESC"

        DataModule.LoadToDGV(sql, dgvMotorSelesai)
        AturFormatGrid(dgvMotorSelesai)
    End Sub

    ''' <summary>
    ''' Mengatur header dan tata letak DataGridView agar rapi
    ''' </summary>
    Private Sub AturFormatGrid(dgv As DataGridView)
        If dgv.ColumnCount > 0 Then
            dgv.Columns("no_servis").HeaderText = "No. Servis"
            dgv.Columns("no_servis").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            dgv.Columns("no_polisi").HeaderText = "No. Polisi"
            dgv.Columns("no_polisi").Width = 100

            dgv.Columns("nama_pelanggan").HeaderText = "Pelanggan"
            dgv.Columns("nama_pelanggan").Width = 130

            dgv.Columns("merk_motor").HeaderText = "Unit Motor"
            dgv.Columns("merk_motor").Width = 130

            dgv.Columns("status").HeaderText = "Status Mekanik"
            dgv.Columns("status").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            ' Pengkondisian kolom kondisional tergantung grid aktif/selesai
            If dgv.Columns.Contains("keluhan") Then
                dgv.Columns("keluhan").HeaderText = "Keluhan Utama"
                dgv.Columns("keluhan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            If dgv.Columns.Contains("nama_mekanik") Then
                dgv.Columns("nama_mekanik").HeaderText = "Mekanik"
                dgv.Columns("nama_mekanik").Width = 110
            End If

            If dgv.Columns.Contains("catatan_terakhir") Then
                dgv.Columns("catatan_terakhir").HeaderText = "Riwayat Tindakan"
                dgv.Columns("catatan_terakhir").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

            If dgv.Columns.Contains("tgl_selesai") Then
                dgv.Columns("tgl_selesai").HeaderText = "Waktu Jam Selesai"
                dgv.Columns("tgl_selesai").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                dgv.Columns("tgl_selesai").Width = 130
            End If
        End If
    End Sub

    ' Memicu pembaruan data secara berkala atau manual saat tab diganti oleh user
    Private Sub tabMotor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMotor.SelectedIndexChanged
        RefreshData()
    End Sub
    Private Sub dgvMotorAktif_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMotorAktif.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim noSrv As String = dgvMotorAktif.Rows(e.RowIndex).Cells("no_servis").Value.ToString()

            Dim frmDetail As New FormDetailServis()
            frmDetail.NoServisDipilih = noSrv ' Kirim data ID ke form detail
            frmDetail.ShowDialog() ' Tampilkan secara modal pop-up
        End If
    End Sub
End Class