Public Class FormMain
    Dim isExiting As Boolean = False
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuKelolaUser.Visible = False
        mnuSparepart.Visible = False
        mnuLaporan.Visible = False
        mnuTransaksi.Visible = False
        mnuRiwayat.Visible = False
        mnuDaftarMotor.Visible = False
        mnuDetailServis.Visible = False
        If RoleUserLogin = "admin" Then
            mnuKelolaUser.Visible = True
            mnuSparepart.Visible = True
            mnuLaporan.Visible = True
        ElseIf RoleUserLogin = "kasir" Then
            mnuTransaksi.Visible = True
            mnuRiwayat.Visible = True
            pnlStok.Visible = False
            Panel7.Visible = False
        ElseIf RoleUserLogin = "mekanik" Then
            pnlKartu.Visible = False
            mnuDaftarMotor.Visible = True
            mnuDetailServis.Visible = True
            Label9.Location = New Point(17, 101)
            dgvStatusMotor.Location = New Point(17, 131)
        End If
        RefreshDashboardData()
        mnuUser.Text = "User: " & NamaUserLogin
    End Sub
    Private Sub FormMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshDashboardData()
    End Sub

    Private Sub RefreshDashboardData()
        Try
            DataModule.LoadDashboard(lblTotalTrx, lblMotorAktif, lblStokKritis)
            Dim queryStatus As String = "SELECT no_polisi AS 'No Polisi', " &
                                        "merk_motor AS 'Merk Motor', " &
                                        "nama_pelanggan AS 'Pelanggan', " &
                                        "nama_mekanik AS 'Mekanik', " &
                                        "status AS 'Status', " &
                                        "tgl_masuk AS 'Tgl Masuk', " &
                                        "update_terakhir AS 'Update Terakhir' " &
                                        "FROM v_status_motor " &
                                        "WHERE status <> 'selesai'"
            DataModule.LoadToDGV(queryStatus, dgvStatusMotor)
            If dgvStatusMotor.ColumnCount > 0 Then
                dgvStatusMotor.Columns("Pelanggan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                dgvStatusMotor.Columns("Tgl Masuk").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                dgvStatusMotor.Columns("Update Terakhir").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data status motor: " & ex.Message)
        End Try
    End Sub
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim dialog As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            NamaUserLogin = ""
            RoleUserLogin = ""
            IDUserLogin = 0
            FormLogin.Show()
            RemoveHandler Me.FormClosing, AddressOf FormMain_FormClosing
            Me.Dispose()
        End If
    End Sub
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isExiting Then Return
        If e.CloseReason = CloseReason.UserClosing Then
            If ValidationModule.KonfirmasiKeluar() Then
                isExiting = True
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub mnuDashboard_Click(sender As Object, e As EventArgs) Handles mnuDashboard.Click
        pnlDashboard.Controls.Clear()
        pnlDashboard.Controls.Add(Label1)
        pnlDashboard.Controls.Add(Label2)
        pnlDashboard.Controls.Add(pnlKartu)
        pnlDashboard.Controls.Add(dgvStatusMotor)
        pnlDashboard.Controls.Add(Label9)
        RefreshDashboardData()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDashboardData()
    End Sub
    Private Sub mnuKelolaUser_Click(sender As Object, e As EventArgs) Handles mnuKelolaUser.Click
        PindahHalaman(New FormKelolaUser())
    End Sub
    Private Sub mnuSparepart_Click(sender As Object, e As EventArgs) Handles mnuSparepart.Click
        PindahHalaman(New FormKelolaSparepart())
    End Sub
    Public Sub PindahHalaman(ByVal frm As Form)
        pnlDashboard.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlDashboard.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub tmrJam_Tick(sender As Object, e As EventArgs) Handles tmrJam.Tick
        lblJam.Text = Format(Now, "HH:mm")
        lblTanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub mnuLaporan_Click(sender As Object, e As EventArgs) Handles mnuLaporan.Click
        PindahHalaman(New FormLaporan())
    End Sub

    Private Sub mnuTransaksi_Click(sender As Object, e As EventArgs) Handles mnuTransaksi.Click
        PindahHalaman(New FormTransaksi())
    End Sub

    Private Sub mnuRiwayat_Click(sender As Object, e As EventArgs) Handles mnuRiwayat.Click
        PindahHalaman(New FormRiwayatTransaksi())
    End Sub

    Private Sub mnuDaftarMotor_Click(sender As Object, e As EventArgs) Handles mnuDaftarMotor.Click
        PindahHalaman(New FormDaftarMotor())
    End Sub
End Class