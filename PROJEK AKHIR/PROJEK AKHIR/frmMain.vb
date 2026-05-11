Imports MySqlConnector
Public Class frmMain

    ' ================================================================
    '  FORM LOAD — setup tampilan sesuai role yang login
    ' ================================================================
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sembunyikan form utama sebentar[cite: 22]
        Me.Hide()

        ' Tampilkan login secara modal (mengunci layar belakang)
        Using login As New frmLogin()
            If login.ShowDialog() = DialogResult.OK Then
                Me.Show()
                TampilkanMenuSesuaiRole() ' Update menu[cite: 22]
                TampilkanInfoUser()
                pnlDashboard.Visible = True ' Memastikan panel dashboard muncul
                pnlDashboard.BringToFront() '
                MuatDashboard() ' Isi data dashboard[cite: 22]
            Else
                ' Jika user menutup form login tanpa masuk, matikan aplikasi
                Application.Exit()
            End If
        End Using
    End Sub

    ' ================================================================
    '  TAMPILKAN MENU SESUAI ROLE
    '  Menu disembunyikan dulu semua, lalu ditampilkan sesuai role
    ' ================================================================
    Private Sub TampilkanMenuSesuaiRole()
        ' Sembunyikan semua menu khusus dulu
        mnuKelolaUser.Visible = False
        mnuSparepart.Visible = False
        mnuLaporan.Visible = False
        mnuTransaksi.Visible = False
        mnuRiwayat.Visible = False
        mnuDaftarMotor.Visible = False
        mnuDetailServis.Visible = False

        ' Gunakan ToLower untuk menghindari error penulisan kapital di database
        Dim role As String = frmLogin.SessionRole.Trim().ToLower()

        Select Case role
            Case "admin"
                mnuKelolaUser.Visible = True
                mnuSparepart.Visible = True
                mnuLaporan.Visible = True

            Case "kasir"
                mnuTransaksi.Visible = True
                mnuRiwayat.Visible = True

            Case "mekanik"
                mnuDaftarMotor.Visible = True
                mnuDetailServis.Visible = True
        End Select
    End Sub

    ' ================================================================
    '  TAMPILKAN INFO USER DI LABEL ATAS
    ' ================================================================
    Private Sub TampilkanInfoUser()
        Dim roleLabel As String = ""
        Select Case frmLogin.SessionRole
            Case "admin" : roleLabel = "Admin"
            Case "kasir" : roleLabel = "Kasir"
            Case "mekanik" : roleLabel = "Mekanik"
        End Select

        lblUserInfo.Text = frmLogin.SessionNama & " · " & roleLabel
        lblTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
        lblJam.Text = Format(Now, "HH:mm")
    End Sub

    ' Timer untuk update jam setiap detik
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        lblJam.Text = Format(Now, "HH:mm")
    End Sub

    ' ================================================================
    '  MUAT DASHBOARD — kartu ringkasan + tabel status motor
    ' ================================================================
    Public Sub MuatDashboard()
        MuatKartuRingkasan()
        MuatTabelStatusMotor()
        If frmLogin.SessionRole = "mekanik" Then
            ' Geser tabel ke atas karena kartu ringkasan disembunyikan
            lblStatusMotor.Location = New Point(20, 80) ' Posisi awal pnlKartu[cite: 16]
            dgvStatusMotor.Location = New Point(20, 105)
        Else
            ' Kembalikan ke posisi normal untuk Admin/Kasir[cite: 16]
            lblStatusMotor.Location = New Point(20, 186)
            dgvStatusMotor.Location = New Point(20, 208)
        End If
    End Sub

    Private Sub MuatKartuRingkasan()
        pnlKartu.Visible = True
        ' Hanya admin dan kasir yang lihat ringkasan transaksi
        If frmLogin.SessionRole = "mekanik" Then
            pnlKartu.Visible = False
            Exit Sub
        End If

        Try
            ' PERBAIKAN: Gunakan MySqlCommand secara langsung tanpa prefix MySql.Data

            ' 1. Total transaksi hari ini
            Dim sqlTrx As String = "SELECT COUNT(*) FROM transaksi WHERE DATE(tgl_transaksi) = CURDATE()"
            Using cmd As New MySqlCommand(sqlTrx, KoneksiDB)
                lblTotalTrx.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' 2. Motor sedang aktif servis
            Dim sqlMotor As String = "SELECT COUNT(*) FROM servis WHERE status <> 'selesai'"
            Using cmd As New MySqlCommand(sqlMotor, KoneksiDB)
                lblMotorAktif.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' 3. Stok kritis (stok < 5) — hanya tampil untuk admin
            If frmLogin.SessionRole = "admin" Then
                Dim sqlStok As String = "SELECT COUNT(*) FROM sparepart WHERE stok < 5"
                Using cmd As New MySqlCommand(sqlStok, KoneksiDB)
                    lblStokKritis.Text = cmd.ExecuteScalar().ToString()
                End Using
                lblStokKritis.Visible = True
                lblStokKritisLabel.Visible = True
            Else
                lblStokKritis.Visible = False
                lblStokKritisLabel.Visible = False
            End If

        Catch ex As Exception
            ' Abaikan jika query gagal, dashboard tetap tampil
        End Try
    End Sub

    Private Sub MuatTabelStatusMotor()
        Dim dt As DataTable = GetStatusMotor()
        If dt Is Nothing Then Exit Sub

        dgvStatusMotor.DataSource = dt

        ' Atur header kolom agar lebih rapi
        With dgvStatusMotor
            .Columns("no_servis").HeaderText = "No. Servis"
            .Columns("nama_pelanggan").HeaderText = "Pelanggan"
            .Columns("no_polisi").HeaderText = "No. Polisi"
            .Columns("merk_motor").HeaderText = "Motor"
            .Columns("status").HeaderText = "Status"
            .Columns("nama_mekanik").HeaderText = "Mekanik"
            .Columns("update_terakhir").HeaderText = "Update"

            ' Sembunyikan kolom yang tidak perlu ditampilkan
            .Columns("keluhan").Visible = False
            .Columns("tgl_masuk").Visible = False
            .Columns("tgl_selesai").Visible = False
            .Columns("catatan_terakhir").Visible = False
        End With

        ' Warnai baris berdasarkan status
        WarnaiStatusMotor()
    End Sub

    Private Sub WarnaiStatusMotor()
        For Each row As DataGridViewRow In dgvStatusMotor.Rows
            If row.IsNewRow Then Continue For
            Dim status As String = row.Cells("status").Value?.ToString()
            Select Case status
                Case "antri"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(38, 41, 58)
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(119, 136, 153)
                Case "proses"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(50, 40, 20)
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 140, 0)
                Case "menunggu_part"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(50, 20, 20)
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(231, 76, 60)
                Case "selesai"
                    row.DefaultCellStyle.BackColor = Color.FromArgb(20, 40, 30)
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(46, 204, 113)
            End Select
        Next
    End Sub

    ' ================================================================
    '  MENU — ADMIN
    ' ================================================================
    Private Sub mnuKelolaUser_Click(sender As Object, e As EventArgs) Handles mnuKelolaUser.Click
        BukaForm(New frmKelolaUser())
    End Sub

    Private Sub mnuSparepart_Click(sender As Object, e As EventArgs) Handles mnuSparepart.Click
        BukaForm(New frmKelolaSparepart())
    End Sub

    Private Sub mnuLaporan_Click(sender As Object, e As EventArgs) Handles mnuLaporan.Click
        BukaForm(New frmLaporan())
    End Sub

    ' ================================================================
    '  MENU — KASIR
    ' ================================================================
    Private Sub mnuTransaksi_Click(sender As Object, e As EventArgs) Handles mnuTransaksi.Click
        BukaForm(New frmTransaksi())
    End Sub

    Private Sub mnuRiwayat_Click(sender As Object, e As EventArgs) Handles mnuRiwayat.Click
        BukaForm(New frmRiwayatTransaksi())
    End Sub

    ' ================================================================
    '  MENU — MEKANIK
    ' ================================================================
    Private Sub mnuDaftarMotor_Click(sender As Object, e As EventArgs) Handles mnuDaftarMotor.Click
        BukaForm(New frmDaftarMotor())
    End Sub

    ' ================================================================
    '  MENU — DASHBOARD (semua role)
    ' ================================================================
    Private Sub mnuDashboard_Click(sender As Object, e As EventArgs) Handles mnuDashboard.Click
        ' Tutup semua MDIChild[cite: 22]
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        ' Munculkan kembali dashboard dan refresh data[cite: 22]
        pnlDashboard.Visible = True
        pnlDashboard.BringToFront()
        MuatDashboard()
    End Sub

    ' ================================================================
    '  MENU — LOGOUT
    ' ================================================================
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim pesan = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo)

        If pesan = DialogResult.Yes Then
            ' Reset variabel sesi[cite: 21]
            frmLogin.SessionRole = ""

            ' Tutup semua form anak[cite: 22]
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next

            ' Tampilkan login kembali
            Me.Hide()
            If frmLogin.ShowDialog() = DialogResult.OK Then
                Me.Show()
                TampilkanMenuSesuaiRole()
                TampilkanInfoUser()        ' Update label nama & role
                pnlDashboard.Visible = True
                pnlDashboard.BringToFront()
                MuatDashboard()
            Else
                Application.Exit()
            End If
        End If
        ' Jika pilih NO, maka tidak terjadi apa-apa (Logika Benar)
    End Sub

    ' ================================================================
    '  HELPER — buka form sebagai MDIChild
    '  Jika form sudah terbuka, fokus ke form itu (tidak dobel buka)
    ' ================================================================
    Private Sub BukaForm(frm As Form)
        ' 1. Sembunyikan panel dashboard agar tidak menutupi area MDI
        If pnlDashboard IsNot Nothing Then
            pnlDashboard.Visible = False
        End If

        ' 2. Cek apakah form tipe ini sudah terbuka
        For Each f As Form In Me.MdiChildren
            If f.GetType() Is frm.GetType() Then
                f.BringToFront()
                f.Focus()
                frm.Dispose()
                Exit Sub
            End If
        Next

        ' 3. Konfigurasi dan tampilkan form baru
        frm.MdiParent = Me
        frm.Show()
    End Sub

    ' ================================================================
    '  TOMBOL REFRESH STATUS MOTOR di toolbar
    ' ================================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MuatDashboard()
    End Sub

    ' ================================================================
    '  FORM CLOSING
    ' ================================================================
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Yakin ingin keluar dari aplikasi?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                  "Keluar") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            TutupKoneksi()
            Application.Exit()
        End If
    End Sub

End Class
