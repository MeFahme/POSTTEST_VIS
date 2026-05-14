Imports System.Reflection.Emit

Public Class FormMain
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
    Private Sub RefreshDashboardData()
        DataModule.LoadDashboard(lblTotalTrx, lblMotorAktif, lblStokKritis)
    End Sub
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim dialog As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            NamaUserLogin = ""
            RoleUserLogin = ""
            IDUserLogin = 0
            TutupKoneksi()
            FormLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If NamaUserLogin <> "" Then
                If ValidationModule.KonfirmasiKeluar() = True Then
                    Application.ExitThread()
                Else
                    e.Cancel = True
                End If
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


End Class