<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        mnuStrip = New MenuStrip()
        mnuDashboard = New ToolStripMenuItem()
        mnuKelolaUser = New ToolStripMenuItem()
        mnuSparepart = New ToolStripMenuItem()
        mnuLaporan = New ToolStripMenuItem()
        mnuTransaksi = New ToolStripMenuItem()
        mnuRiwayat = New ToolStripMenuItem()
        mnuDaftarMotor = New ToolStripMenuItem()
        mnuDetailServis = New ToolStripMenuItem()
        mnuSep1 = New ToolStripSeparator()
        lblUserInfo = New ToolStripLabel()
        mnuLogout = New ToolStripMenuItem()
        pnlToolbar = New Panel()
        btnRefresh = New Button()
        lblTanggal = New Label()
        lblJam = New Label()
        pnlDashboard = New Panel()
        lblDashTitle = New Label()
        lblDashSub = New Label()
        pnlKartu = New Panel()
        pnlTrx = New Panel()
        lblTotalTrx = New Label()
        lblTotalTrxLabel = New Label()
        accTrx = New Panel()
        pnlMotor = New Panel()
        lblMotorAktif = New Label()
        lblMotorAktifLabel = New Label()
        accMotor = New Panel()
        pnlStok = New Panel()
        lblStokKritis = New Label()
        lblStokKritisLabel = New Label()
        accStok = New Panel()
        lblStatusMotor = New Label()
        dgvStatusMotor = New DataGridView()
        pnlStatusBar = New Panel()
        lblStatus = New Label()
        lblVersi = New Label()
        tmrJam = New Timer(components)
        mnuStrip.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlKartu.SuspendLayout()
        pnlTrx.SuspendLayout()
        pnlMotor.SuspendLayout()
        pnlStok.SuspendLayout()
        CType(dgvStatusMotor, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatusBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuStrip
        ' 
        mnuStrip.BackColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        mnuStrip.Font = New Font("Segoe UI", 9.5F)
        mnuStrip.ForeColor = Color.FromArgb(CByte(154), CByte(170), CByte(170))
        mnuStrip.Items.AddRange(New ToolStripItem() {mnuDashboard, mnuKelolaUser, mnuSparepart, mnuLaporan, mnuTransaksi, mnuRiwayat, mnuDaftarMotor, mnuDetailServis, mnuSep1, lblUserInfo, mnuLogout})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.Padding = New Padding(4, 2, 0, 2)
        mnuStrip.Size = New Size(1100, 27)
        mnuStrip.TabIndex = 4
        ' 
        ' mnuDashboard
        ' 
        mnuDashboard.Name = "mnuDashboard"
        mnuDashboard.Size = New Size(109, 23)
        mnuDashboard.Text = "🏠  Dashboard"
        ' 
        ' mnuKelolaUser
        ' 
        mnuKelolaUser.Name = "mnuKelolaUser"
        mnuKelolaUser.Size = New Size(113, 23)
        mnuKelolaUser.Text = "👥  Kelola User"
        ' 
        ' mnuSparepart
        ' 
        mnuSparepart.Name = "mnuSparepart"
        mnuSparepart.Size = New Size(100, 23)
        mnuSparepart.Text = "🔩  Sparepart"
        ' 
        ' mnuLaporan
        ' 
        mnuLaporan.Name = "mnuLaporan"
        mnuLaporan.Size = New Size(93, 23)
        mnuLaporan.Text = "📊  Laporan"
        ' 
        ' mnuTransaksi
        ' 
        mnuTransaksi.Name = "mnuTransaksi"
        mnuTransaksi.Size = New Size(129, 23)
        mnuTransaksi.Text = ChrW(55357) & ChrW(57042) & "  Transaksi Baru"
        ' 
        ' mnuRiwayat
        ' 
        mnuRiwayat.Name = "mnuRiwayat"
        mnuRiwayat.Size = New Size(144, 23)
        mnuRiwayat.Text = "📋  Riwayat Transaksi"
        ' 
        ' mnuDaftarMotor
        ' 
        mnuDaftarMotor.Name = "mnuDaftarMotor"
        mnuDaftarMotor.Size = New Size(123, 23)
        mnuDaftarMotor.Text = "🏍  Daftar Motor"
        ' 
        ' mnuDetailServis
        ' 
        mnuDetailServis.Name = "mnuDetailServis"
        mnuDetailServis.Size = New Size(117, 23)
        mnuDetailServis.Text = "🔧  Detail Servis"
        mnuDetailServis.Visible = False
        ' 
        ' mnuSep1
        ' 
        mnuSep1.Name = "mnuSep1"
        mnuSep1.Size = New Size(6, 23)
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.Alignment = ToolStripItemAlignment.Right
        lblUserInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUserInfo.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(59, 20)
        lblUserInfo.Text = "Loading..."
        ' 
        ' mnuLogout
        ' 
        mnuLogout.Alignment = ToolStripItemAlignment.Right
        mnuLogout.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(77, 23)
        mnuLogout.Text = ChrW(9211) & "  Logout"
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(lblTanggal)
        pnlToolbar.Controls.Add(lblJam)
        pnlToolbar.Dock = DockStyle.Top
        pnlToolbar.Location = New Point(0, 27)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1100, 44)
        pnlToolbar.TabIndex = 2
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(34), CByte(37), CByte(58))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(46), CByte(50), CByte(71))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(154), CByte(170), CByte(170))
        btnRefresh.Location = New Point(14, 8)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 28)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "↻  Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 9.0F)
        lblTanggal.ForeColor = Color.FromArgb(CByte(51), CByte(68), CByte(85))
        lblTanggal.Location = New Point(900, 14)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(128, 15)
        lblTanggal.TabIndex = 1
        lblTanggal.Text = "Thursday, 30 April 2026"
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJam.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblJam.Location = New Point(1040, 14)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(38, 15)
        lblJam.TabIndex = 2
        lblJam.Text = "00:02"
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        pnlDashboard.Controls.Add(lblDashTitle)
        pnlDashboard.Controls.Add(lblDashSub)
        pnlDashboard.Controls.Add(pnlKartu)
        pnlDashboard.Controls.Add(lblStatusMotor)
        pnlDashboard.Controls.Add(dgvStatusMotor)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.Location = New Point(0, 71)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Padding = New Padding(20)
        pnlDashboard.Size = New Size(1100, 581)
        pnlDashboard.TabIndex = 1
        ' 
        ' lblDashTitle
        ' 
        lblDashTitle.AutoSize = True
        lblDashTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblDashTitle.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblDashTitle.Location = New Point(20, 20)
        lblDashTitle.Name = "lblDashTitle"
        lblDashTitle.Size = New Size(126, 30)
        lblDashTitle.TabIndex = 0
        lblDashTitle.Text = "Dashboard"
        ' 
        ' lblDashSub
        ' 
        lblDashSub.AutoSize = True
        lblDashSub.Font = New Font("Segoe UI", 9.0F)
        lblDashSub.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblDashSub.Location = New Point(22, 50)
        lblDashSub.Name = "lblDashSub"
        lblDashSub.Size = New Size(146, 15)
        lblDashSub.TabIndex = 1
        lblDashSub.Text = "Ringkasan aktivitas hari ini"
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.Transparent
        pnlKartu.Controls.Add(pnlTrx)
        pnlKartu.Controls.Add(pnlMotor)
        pnlKartu.Controls.Add(pnlStok)
        pnlKartu.Location = New Point(20, 80)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(760, 90)
        pnlKartu.TabIndex = 2
        ' 
        ' pnlTrx
        ' 
        pnlTrx.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlTrx.Controls.Add(lblTotalTrx)
        pnlTrx.Controls.Add(lblTotalTrxLabel)
        pnlTrx.Controls.Add(accTrx)
        pnlTrx.Location = New Point(0, 0)
        pnlTrx.Name = "pnlTrx"
        pnlTrx.Size = New Size(230, 80)
        pnlTrx.TabIndex = 0
        ' 
        ' lblTotalTrx
        ' 
        lblTotalTrx.AutoSize = True
        lblTotalTrx.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblTotalTrx.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblTotalTrx.Location = New Point(16, 14)
        lblTotalTrx.Name = "lblTotalTrx"
        lblTotalTrx.Size = New Size(35, 41)
        lblTotalTrx.TabIndex = 0
        lblTotalTrx.Text = "0"
        ' 
        ' lblTotalTrxLabel
        ' 
        lblTotalTrxLabel.AutoSize = True
        lblTotalTrxLabel.Font = New Font("Segoe UI", 9.0F)
        lblTotalTrxLabel.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblTotalTrxLabel.Location = New Point(16, 54)
        lblTotalTrxLabel.Name = "lblTotalTrxLabel"
        lblTotalTrxLabel.Size = New Size(95, 15)
        lblTotalTrxLabel.TabIndex = 1
        lblTotalTrxLabel.Text = "Transaksi Hari Ini"
        ' 
        ' accTrx
        ' 
        accTrx.BackColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        accTrx.Location = New Point(226, 0)
        accTrx.Name = "accTrx"
        accTrx.Size = New Size(4, 80)
        accTrx.TabIndex = 2
        ' 
        ' pnlMotor
        ' 
        pnlMotor.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlMotor.Controls.Add(lblMotorAktif)
        pnlMotor.Controls.Add(lblMotorAktifLabel)
        pnlMotor.Controls.Add(accMotor)
        pnlMotor.Location = New Point(246, 0)
        pnlMotor.Name = "pnlMotor"
        pnlMotor.Size = New Size(230, 80)
        pnlMotor.TabIndex = 1
        ' 
        ' lblMotorAktif
        ' 
        lblMotorAktif.AutoSize = True
        lblMotorAktif.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblMotorAktif.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblMotorAktif.Location = New Point(16, 14)
        lblMotorAktif.Name = "lblMotorAktif"
        lblMotorAktif.Size = New Size(35, 41)
        lblMotorAktif.TabIndex = 0
        lblMotorAktif.Text = "0"
        ' 
        ' lblMotorAktifLabel
        ' 
        lblMotorAktifLabel.AutoSize = True
        lblMotorAktifLabel.Font = New Font("Segoe UI", 9.0F)
        lblMotorAktifLabel.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblMotorAktifLabel.Location = New Point(16, 54)
        lblMotorAktifLabel.Name = "lblMotorAktifLabel"
        lblMotorAktifLabel.Size = New Size(115, 15)
        lblMotorAktifLabel.TabIndex = 1
        lblMotorAktifLabel.Text = "Motor Sedang Servis"
        ' 
        ' accMotor
        ' 
        accMotor.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        accMotor.Location = New Point(226, 0)
        accMotor.Name = "accMotor"
        accMotor.Size = New Size(4, 80)
        accMotor.TabIndex = 2
        ' 
        ' pnlStok
        ' 
        pnlStok.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlStok.Controls.Add(lblStokKritis)
        pnlStok.Controls.Add(lblStokKritisLabel)
        pnlStok.Controls.Add(accStok)
        pnlStok.Location = New Point(492, 0)
        pnlStok.Name = "pnlStok"
        pnlStok.Size = New Size(230, 80)
        pnlStok.TabIndex = 2
        ' 
        ' lblStokKritis
        ' 
        lblStokKritis.AutoSize = True
        lblStokKritis.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
        lblStokKritis.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblStokKritis.Location = New Point(16, 14)
        lblStokKritis.Name = "lblStokKritis"
        lblStokKritis.Size = New Size(35, 41)
        lblStokKritis.TabIndex = 0
        lblStokKritis.Text = "0"
        ' 
        ' lblStokKritisLabel
        ' 
        lblStokKritisLabel.AutoSize = True
        lblStokKritisLabel.Font = New Font("Segoe UI", 9.0F)
        lblStokKritisLabel.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblStokKritisLabel.Location = New Point(16, 54)
        lblStokKritisLabel.Name = "lblStokKritisLabel"
        lblStokKritisLabel.Size = New Size(87, 15)
        lblStokKritisLabel.TabIndex = 1
        lblStokKritisLabel.Text = "Stok Kritis (< 5)"
        ' 
        ' accStok
        ' 
        accStok.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        accStok.Location = New Point(226, 0)
        accStok.Name = "accStok"
        accStok.Size = New Size(4, 80)
        accStok.TabIndex = 2
        ' 
        ' lblStatusMotor
        ' 
        lblStatusMotor.AutoSize = True
        lblStatusMotor.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblStatusMotor.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblStatusMotor.Location = New Point(20, 186)
        lblStatusMotor.Name = "lblStatusMotor"
        lblStatusMotor.Size = New Size(121, 13)
        lblStatusMotor.TabIndex = 3
        lblStatusMotor.Text = "STATUS MOTOR AKTIF"
        ' 
        ' dgvStatusMotor
        ' 
        dgvStatusMotor.AllowUserToAddRows = False
        dgvStatusMotor.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(34))
        dgvStatusMotor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvStatusMotor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStatusMotor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStatusMotor.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvStatusMotor.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvStatusMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvStatusMotor.DefaultCellStyle = DataGridViewCellStyle3
        dgvStatusMotor.EnableHeadersVisualStyles = False
        dgvStatusMotor.Font = New Font("Segoe UI", 9.0F)
        dgvStatusMotor.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvStatusMotor.Location = New Point(20, 208)
        dgvStatusMotor.Name = "dgvStatusMotor"
        dgvStatusMotor.ReadOnly = True
        dgvStatusMotor.RowHeadersVisible = False
        dgvStatusMotor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStatusMotor.Size = New Size(1920, 841)
        dgvStatusMotor.TabIndex = 4
        ' 
        ' pnlStatusBar
        ' 
        pnlStatusBar.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        pnlStatusBar.Controls.Add(lblStatus)
        pnlStatusBar.Controls.Add(lblVersi)
        pnlStatusBar.Dock = DockStyle.Bottom
        pnlStatusBar.Location = New Point(0, 652)
        pnlStatusBar.Name = "pnlStatusBar"
        pnlStatusBar.Size = New Size(1100, 28)
        pnlStatusBar.TabIndex = 3
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 8.0F)
        lblStatus.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblStatus.Location = New Point(14, 7)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(293, 13)
        lblStatus.TabIndex = 0
        lblStatus.Text = "● Database terhubung · db_sparepart_motor · localhost"
        ' 
        ' lblVersi
        ' 
        lblVersi.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblVersi.AutoSize = True
        lblVersi.Font = New Font("Segoe UI", 8.0F)
        lblVersi.ForeColor = Color.FromArgb(CByte(51), CByte(68), CByte(85))
        lblVersi.Location = New Point(1960, 7)
        lblVersi.Name = "lblVersi"
        lblVersi.Size = New Size(36, 13)
        lblVersi.TabIndex = 1
        lblVersi.Text = "v1.0.0"
        ' 
        ' tmrJam
        ' 
        tmrJam.Enabled = True
        tmrJam.Interval = 60000
        ' 
        ' frmMain
        ' 
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        ClientSize = New Size(1100, 680)
        Controls.Add(pnlDashboard)
        Controls.Add(pnlToolbar)
        Controls.Add(pnlStatusBar)
        Controls.Add(mnuStrip)
        IsMdiContainer = True
        MainMenuStrip = mnuStrip
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen & Inventori Sparepart Motor"
        WindowState = FormWindowState.Maximized
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
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
        pnlStatusBar.ResumeLayout(False)
        pnlStatusBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' ============================================================
    '  DEKLARASI SEMUA CONTROL
    ' ============================================================
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDashboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKelolaUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSparepart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRiwayat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDaftarMotor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDetailServis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblUserInfo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
    Friend WithEvents lblDashTitle As System.Windows.Forms.Label
    Friend WithEvents lblDashSub As System.Windows.Forms.Label
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTrx As System.Windows.Forms.Label
    Friend WithEvents lblTotalTrxLabel As System.Windows.Forms.Label
    Friend WithEvents lblMotorAktif As System.Windows.Forms.Label
    Friend WithEvents lblMotorAktifLabel As System.Windows.Forms.Label
    Friend WithEvents lblStokKritis As System.Windows.Forms.Label
    Friend WithEvents lblStokKritisLabel As System.Windows.Forms.Label
    Friend WithEvents lblStatusMotor As System.Windows.Forms.Label
    Friend WithEvents dgvStatusMotor As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblVersi As System.Windows.Forms.Label
    Friend WithEvents tmrJam As System.Windows.Forms.Timer
    Friend WithEvents pnlTrx As Panel
    Friend WithEvents accTrx As Panel
    Friend WithEvents pnlMotor As Panel
    Friend WithEvents accMotor As Panel
    Friend WithEvents pnlStok As Panel
    Friend WithEvents accStok As Panel

End Class
