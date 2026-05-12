<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        mnuStrip = New MenuStrip()
        mnuDashboard = New ToolStripMenuItem()
        mnuKelolaUser = New ToolStripMenuItem()
        mnuSparepart = New ToolStripMenuItem()
        mnuLaporan = New ToolStripMenuItem()
        mnuTransaksi = New ToolStripMenuItem()
        mnuRiwayat = New ToolStripMenuItem()
        mnuDaftarMotor = New ToolStripMenuItem()
        mnuDetailServis = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        pnlToolbar = New Panel()
        pnlDashboard = New Panel()
        btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Label2 = New Label()
        pnlKartu = New Panel()
        pnlTrx = New Panel()
        Panel4 = New Panel()
        pnlMotor = New Panel()
        Panel5 = New Panel()
        pnlStok = New Panel()
        Panel7 = New Panel()
        lblTotalTrx = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblMotorAktif = New Label()
        Label7 = New Label()
        lblStokKritis = New Label()
        Label9 = New Label()
        dgvStatusMotor = New DataGridView()
        mnuStrip.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlKartu.SuspendLayout()
        pnlTrx.SuspendLayout()
        pnlMotor.SuspendLayout()
        pnlStok.SuspendLayout()
        CType(dgvStatusMotor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mnuStrip
        ' 
        mnuStrip.BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        mnuStrip.Items.AddRange(New ToolStripItem() {mnuDashboard, mnuKelolaUser, mnuSparepart, mnuLaporan, mnuTransaksi, mnuRiwayat, mnuDaftarMotor, mnuDetailServis, LogoutToolStripMenuItem})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Size = New Size(974, 25)
        mnuStrip.TabIndex = 0
        mnuStrip.Text = "MenuStrip1"
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuDashboard.ForeColor = Color.LightGray
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Size = New Size(87, 21)
        mnuDashboard.Text = "Dashboard"
        ' 
        ' mnuKelolaUser
        ' 
        mnuKelolaUser.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuKelolaUser.ForeColor = Color.LightGray
        mnuKelolaUser.Name = "mnuKelolaUser"
        mnuKelolaUser.Size = New Size(89, 21)
        mnuKelolaUser.Text = "Kelola User"
        ' 
        ' mnuSparepart
        ' 
        mnuSparepart.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuSparepart.ForeColor = Color.LightGray
        mnuSparepart.Name = "mnuSparepart"
        mnuSparepart.Size = New Size(79, 21)
        mnuSparepart.Text = "Sparepart"
        ' 
        ' mnuLaporan
        ' 
        mnuLaporan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuLaporan.ForeColor = Color.LightGray
        mnuLaporan.Name = "mnuLaporan"
        mnuLaporan.Size = New Size(70, 21)
        mnuLaporan.Text = "Laporan"
        ' 
        ' mnuTransaksi
        ' 
        mnuTransaksi.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuTransaksi.ForeColor = Color.LightGray
        mnuTransaksi.Name = "mnuTransaksi"
        mnuTransaksi.Size = New Size(109, 21)
        mnuTransaksi.Text = "Transaksi Baru"
        ' 
        ' mnuRiwayat
        ' 
        mnuRiwayat.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuRiwayat.ForeColor = Color.LightGray
        mnuRiwayat.Name = "mnuRiwayat"
        mnuRiwayat.Size = New Size(129, 21)
        mnuRiwayat.Text = "Riwayat Transaksi"
        ' 
        ' mnuDaftarMotor
        ' 
        mnuDaftarMotor.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuDaftarMotor.ForeColor = Color.LightGray
        mnuDaftarMotor.Name = "mnuDaftarMotor"
        mnuDaftarMotor.Size = New Size(101, 21)
        mnuDaftarMotor.Text = "Daftar Motor"
        ' 
        ' mnuDetailServis
        ' 
        mnuDetailServis.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuDetailServis.ForeColor = Color.LightGray
        mnuDetailServis.Name = "mnuDetailServis"
        mnuDetailServis.Size = New Size(98, 21)
        mnuDetailServis.Text = "Detail Servis"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutToolStripMenuItem.ForeColor = Color.Red
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(64, 21)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Location = New Point(0, 24)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(974, 51)
        pnlToolbar.TabIndex = 1
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        pnlDashboard.Controls.Add(dgvStatusMotor)
        pnlDashboard.Controls.Add(Label9)
        pnlDashboard.Controls.Add(Label2)
        pnlDashboard.Controls.Add(Label1)
        pnlDashboard.Controls.Add(pnlKartu)
        pnlDashboard.Location = New Point(0, 73)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(974, 528)
        pnlDashboard.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BorderColor = Color.DimGray
        btnRefresh.BorderThickness = 1
        btnRefresh.CustomBorderColor = Color.White
        btnRefresh.CustomizableEdges = CustomizableEdges3
        btnRefresh.DisabledState.BorderColor = Color.DarkGray
        btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefresh.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefresh.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefresh.FillColor = Color.FromArgb(CByte(34), CByte(37), CByte(58))
        btnRefresh.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.LightGray
        btnRefresh.Location = New Point(12, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnRefresh.Size = New Size(103, 33)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "↻  Refresh"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 32)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(17, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 15)
        Label2.TabIndex = 1
        Label2.Text = "Ringkasan Aktivitas Hari Ini"
        ' 
        ' pnlKartu
        ' 
        pnlKartu.Controls.Add(pnlStok)
        pnlKartu.Controls.Add(Panel7)
        pnlKartu.Controls.Add(pnlMotor)
        pnlKartu.Controls.Add(Panel5)
        pnlKartu.Controls.Add(pnlTrx)
        pnlKartu.Controls.Add(Panel4)
        pnlKartu.Location = New Point(17, 101)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(708, 86)
        pnlKartu.TabIndex = 2
        ' 
        ' pnlTrx
        ' 
        pnlTrx.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlTrx.Controls.Add(Label4)
        pnlTrx.Controls.Add(lblTotalTrx)
        pnlTrx.Location = New Point(0, 0)
        pnlTrx.Name = "pnlTrx"
        pnlTrx.Size = New Size(205, 86)
        pnlTrx.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Location = New Point(199, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 86)
        Panel4.TabIndex = 0
        ' 
        ' pnlMotor
        ' 
        pnlMotor.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlMotor.Controls.Add(Label5)
        pnlMotor.Controls.Add(lblMotorAktif)
        pnlMotor.Location = New Point(249, 0)
        pnlMotor.Name = "pnlMotor"
        pnlMotor.Size = New Size(205, 86)
        pnlMotor.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel5.Location = New Point(448, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 86)
        Panel5.TabIndex = 2
        ' 
        ' pnlStok
        ' 
        pnlStok.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlStok.Controls.Add(Label7)
        pnlStok.Controls.Add(lblStokKritis)
        pnlStok.Location = New Point(495, 0)
        pnlStok.Name = "pnlStok"
        pnlStok.Size = New Size(205, 86)
        pnlStok.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Red
        Panel7.Location = New Point(694, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 86)
        Panel7.TabIndex = 4
        ' 
        ' lblTotalTrx
        ' 
        lblTotalTrx.AutoSize = True
        lblTotalTrx.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTrx.ForeColor = SystemColors.ButtonFace
        lblTotalTrx.Location = New Point(14, 11)
        lblTotalTrx.Name = "lblTotalTrx"
        lblTotalTrx.Size = New Size(38, 45)
        lblTotalTrx.TabIndex = 0
        lblTotalTrx.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label4.Location = New Point(22, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 17)
        Label4.TabIndex = 1
        Label4.Text = "Transaksi Hari Ini"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label5.Location = New Point(26, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 17)
        Label5.TabIndex = 3
        Label5.Text = "Motor Sedang Diservice"
        ' 
        ' lblMotorAktif
        ' 
        lblMotorAktif.AutoSize = True
        lblMotorAktif.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMotorAktif.ForeColor = SystemColors.ButtonFace
        lblMotorAktif.Location = New Point(18, 11)
        lblMotorAktif.Name = "lblMotorAktif"
        lblMotorAktif.Size = New Size(38, 45)
        lblMotorAktif.TabIndex = 2
        lblMotorAktif.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label7.Location = New Point(28, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 17)
        Label7.TabIndex = 5
        Label7.Text = "Stok Kritis"
        ' 
        ' lblStokKritis
        ' 
        lblStokKritis.AutoSize = True
        lblStokKritis.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStokKritis.ForeColor = SystemColors.ButtonFace
        lblStokKritis.Location = New Point(20, 11)
        lblStokKritis.Name = "lblStokKritis"
        lblStokKritis.Size = New Size(38, 45)
        lblStokKritis.TabIndex = 4
        lblStokKritis.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label9.Location = New Point(17, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(149, 21)
        Label9.TabIndex = 3
        Label9.Text = "Status Motor Aktif"
        ' 
        ' dgvStatusMotor
        ' 
        dgvStatusMotor.BackgroundColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvStatusMotor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStatusMotor.DefaultCellStyle = DataGridViewCellStyle2
        dgvStatusMotor.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvStatusMotor.Location = New Point(17, 253)
        dgvStatusMotor.Name = "dgvStatusMotor"
        dgvStatusMotor.Size = New Size(940, 260)
        dgvStatusMotor.TabIndex = 4
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 598)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlToolbar)
        Controls.Add(mnuStrip)
        Name = "FormMain"
        Text = "FormMain"
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        pnlToolbar.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlDashboard.PerformLayout()
        pnlKartu.ResumeLayout(False)
        pnlTrx.ResumeLayout(False)
        pnlTrx.PerformLayout()
        pnlMotor.ResumeLayout(False)
        pnlMotor.PerformLayout()
        pnlStok.ResumeLayout(False)
        pnlStok.PerformLayout()
        CType(dgvStatusMotor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents mnuDashboard As ToolStripMenuItem
    Friend WithEvents mnuKelolaUser As ToolStripMenuItem
    Friend WithEvents mnuSparepart As ToolStripMenuItem
    Friend WithEvents mnuLaporan As ToolStripMenuItem
    Friend WithEvents mnuTransaksi As ToolStripMenuItem
    Friend WithEvents mnuRiwayat As ToolStripMenuItem
    Friend WithEvents mnuDaftarMotor As ToolStripMenuItem
    Friend WithEvents mnuDetailServis As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents pnlTrx As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlStok As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pnlMotor As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStokKritis As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMotorAktif As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalTrx As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvStatusMotor As DataGridView
End Class
