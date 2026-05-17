<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tabLaporan = New Guna.UI2.WinForms.Guna2TabControl()
        tabPenjualan = New TabPage()
        pnlKartu = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        pnlDisplay = New Panel()
        pnlTrx = New Panel()
        Label4 = New Label()
        lblTotalTrx = New Label()
        Panel8 = New Panel()
        Label8 = New Label()
        lblTotalBelum = New Label()
        Panel9 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        lblTotalOmzet = New Label()
        Panel6 = New Panel()
        Label6 = New Label()
        lblTotalLunas = New Label()
        Panel7 = New Panel()
        Panel5 = New Panel()
        dgvLaporan = New DataGridView()
        tabStok = New TabPage()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel2 = New Panel()
        Panel10 = New Panel()
        Label5 = New Label()
        lblTotalItem = New Label()
        Panel11 = New Panel()
        Label9 = New Label()
        lblStokKritis = New Label()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel14 = New Panel()
        Label11 = New Label()
        lblTotalAset = New Label()
        Panel17 = New Panel()
        dgvStok = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        dtpDari = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpSampai = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnTampilkan = New Guna.UI2.WinForms.Guna2Button()
        btnHariIni = New Guna.UI2.WinForms.Guna2Button()
        btnBulanIni = New Guna.UI2.WinForms.Guna2Button()
        Panel1 = New Panel()
        tabLaporan.SuspendLayout()
        tabPenjualan.SuspendLayout()
        pnlKartu.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        pnlDisplay.SuspendLayout()
        pnlTrx.SuspendLayout()
        Panel8.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        tabStok.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel14.SuspendLayout()
        CType(dgvStok, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabLaporan
        ' 
        tabLaporan.Controls.Add(tabPenjualan)
        tabLaporan.Controls.Add(tabStok)
        tabLaporan.Dock = DockStyle.Fill
        tabLaporan.ItemSize = New Size(180, 40)
        tabLaporan.Location = New Point(0, 56)
        tabLaporan.Name = "tabLaporan"
        tabLaporan.SelectedIndex = 0
        tabLaporan.Size = New Size(1000, 476)
        tabLaporan.TabButtonHoverState.BorderColor = Color.Empty
        tabLaporan.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tabLaporan.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F)
        tabLaporan.TabButtonHoverState.ForeColor = Color.White
        tabLaporan.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tabLaporan.TabButtonIdleState.BorderColor = Color.Empty
        tabLaporan.TabButtonIdleState.FillColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabLaporan.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F)
        tabLaporan.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        tabLaporan.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabLaporan.TabButtonSelectedState.BorderColor = Color.Empty
        tabLaporan.TabButtonSelectedState.FillColor = Color.FromArgb(CByte(29), CByte(37), CByte(49))
        tabLaporan.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F)
        tabLaporan.TabButtonSelectedState.ForeColor = Color.White
        tabLaporan.TabButtonSelectedState.InnerColor = Color.FromArgb(CByte(76), CByte(132), CByte(255))
        tabLaporan.TabButtonSize = New Size(180, 40)
        tabLaporan.TabIndex = 1
        tabLaporan.TabMenuBackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabLaporan.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        ' 
        ' tabPenjualan
        ' 
        tabPenjualan.BackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabPenjualan.Controls.Add(pnlKartu)
        tabPenjualan.Location = New Point(4, 44)
        tabPenjualan.Name = "tabPenjualan"
        tabPenjualan.Padding = New Padding(3)
        tabPenjualan.Size = New Size(992, 428)
        tabPenjualan.TabIndex = 0
        tabPenjualan.Text = "Laporan Penjualan"
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlKartu.Controls.Add(TableLayoutPanel1)
        pnlKartu.Dock = DockStyle.Fill
        pnlKartu.Location = New Point(3, 3)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(986, 422)
        pnlKartu.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(pnlDisplay, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvLaporan, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(986, 422)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' pnlDisplay
        ' 
        pnlDisplay.Controls.Add(pnlTrx)
        pnlDisplay.Controls.Add(Panel8)
        pnlDisplay.Controls.Add(Panel9)
        pnlDisplay.Controls.Add(Panel4)
        pnlDisplay.Controls.Add(Panel3)
        pnlDisplay.Controls.Add(Panel6)
        pnlDisplay.Controls.Add(Panel7)
        pnlDisplay.Controls.Add(Panel5)
        pnlDisplay.Dock = DockStyle.Fill
        pnlDisplay.Location = New Point(3, 3)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Size = New Size(980, 91)
        pnlDisplay.TabIndex = 5
        ' 
        ' pnlTrx
        ' 
        pnlTrx.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlTrx.Controls.Add(Label4)
        pnlTrx.Controls.Add(lblTotalTrx)
        pnlTrx.Location = New Point(3, 3)
        pnlTrx.Name = "pnlTrx"
        pnlTrx.Size = New Size(205, 86)
        pnlTrx.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label4.Location = New Point(16, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 17)
        Label4.TabIndex = 1
        Label4.Text = "Jumlah Transaksi"
        ' 
        ' lblTotalTrx
        ' 
        lblTotalTrx.AutoSize = True
        lblTotalTrx.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTrx.ForeColor = SystemColors.ButtonFace
        lblTotalTrx.Location = New Point(10, 11)
        lblTotalTrx.Name = "lblTotalTrx"
        lblTotalTrx.Size = New Size(38, 45)
        lblTotalTrx.TabIndex = 0
        lblTotalTrx.Text = "0"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel8.Controls.Add(Label8)
        Panel8.Controls.Add(lblTotalBelum)
        Panel8.Location = New Point(766, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(205, 86)
        Panel8.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label8.Location = New Point(16, 57)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 17)
        Label8.TabIndex = 1
        Label8.Text = "Belum Lunas"
        ' 
        ' lblTotalBelum
        ' 
        lblTotalBelum.AutoSize = True
        lblTotalBelum.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblTotalBelum.ForeColor = SystemColors.ButtonFace
        lblTotalBelum.Location = New Point(13, 11)
        lblTotalBelum.Name = "lblTotalBelum"
        lblTotalBelum.Size = New Size(58, 30)
        lblTotalBelum.TabIndex = 0
        lblTotalBelum.Text = "Rp 0"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Red
        Panel9.Location = New Point(965, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 86)
        Panel9.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Location = New Point(202, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 86)
        Panel4.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(lblTotalOmzet)
        Panel3.Location = New Point(260, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(205, 86)
        Panel3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label3.Location = New Point(12, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 17)
        Label3.TabIndex = 1
        Label3.Text = "Total Omzet"
        ' 
        ' lblTotalOmzet
        ' 
        lblTotalOmzet.AutoSize = True
        lblTotalOmzet.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOmzet.ForeColor = SystemColors.ButtonFace
        lblTotalOmzet.Location = New Point(9, 11)
        lblTotalOmzet.Name = "lblTotalOmzet"
        lblTotalOmzet.Size = New Size(58, 30)
        lblTotalOmzet.TabIndex = 0
        lblTotalOmzet.Text = "Rp 0"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(lblTotalLunas)
        Panel6.Location = New Point(508, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(205, 86)
        Panel6.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label6.Location = New Point(15, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 17)
        Label6.TabIndex = 1
        Label6.Text = "Sudah Lunas"
        ' 
        ' lblTotalLunas
        ' 
        lblTotalLunas.AutoSize = True
        lblTotalLunas.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblTotalLunas.ForeColor = SystemColors.ButtonFace
        lblTotalLunas.Location = New Point(12, 11)
        lblTotalLunas.Name = "lblTotalLunas"
        lblTotalLunas.Size = New Size(58, 30)
        lblTotalLunas.TabIndex = 0
        lblTotalLunas.Text = "Rp 0"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Cyan
        Panel7.Location = New Point(707, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 86)
        Panel7.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Lime
        Panel5.Location = New Point(459, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 86)
        Panel5.TabIndex = 4
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.AllowUserToAddRows = False
        dgvLaporan.AllowUserToDeleteRows = False
        dgvLaporan.AllowUserToResizeColumns = False
        dgvLaporan.AllowUserToResizeRows = False
        dgvLaporan.BackgroundColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvLaporan.DefaultCellStyle = DataGridViewCellStyle1
        dgvLaporan.Dock = DockStyle.Fill
        dgvLaporan.Location = New Point(3, 100)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.ReadOnly = True
        dgvLaporan.RowHeadersVisible = False
        dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLaporan.Size = New Size(980, 319)
        dgvLaporan.TabIndex = 0
        ' 
        ' tabStok
        ' 
        tabStok.BackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabStok.Controls.Add(TableLayoutPanel2)
        tabStok.Location = New Point(4, 44)
        tabStok.Name = "tabStok"
        tabStok.Padding = New Padding(3)
        tabStok.Size = New Size(992, 428)
        tabStok.TabIndex = 1
        tabStok.Text = "Laporan Stok"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel2.Controls.Add(dgvStok, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.Size = New Size(986, 422)
        TableLayoutPanel2.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel10)
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(Panel12)
        Panel2.Controls.Add(Panel13)
        Panel2.Controls.Add(Panel14)
        Panel2.Controls.Add(Panel17)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(986, 91)
        Panel2.TabIndex = 6
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel10.Controls.Add(Label5)
        Panel10.Controls.Add(lblTotalItem)
        Panel10.Location = New Point(3, 3)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(205, 86)
        Panel10.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label5.Location = New Point(16, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 17)
        Label5.TabIndex = 1
        Label5.Text = "Total Item"
        ' 
        ' lblTotalItem
        ' 
        lblTotalItem.AutoSize = True
        lblTotalItem.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalItem.ForeColor = SystemColors.ButtonFace
        lblTotalItem.Location = New Point(10, 11)
        lblTotalItem.Name = "lblTotalItem"
        lblTotalItem.Size = New Size(38, 45)
        lblTotalItem.TabIndex = 0
        lblTotalItem.Text = "0"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel11.Controls.Add(Label9)
        Panel11.Controls.Add(lblStokKritis)
        Panel11.Location = New Point(516, 3)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(205, 86)
        Panel11.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label9.Location = New Point(16, 57)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 17)
        Label9.TabIndex = 1
        Label9.Text = "Stok Kritis ( < 5 )"
        ' 
        ' lblStokKritis
        ' 
        lblStokKritis.AutoSize = True
        lblStokKritis.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblStokKritis.ForeColor = SystemColors.ButtonFace
        lblStokKritis.Location = New Point(13, 11)
        lblStokKritis.Name = "lblStokKritis"
        lblStokKritis.Size = New Size(25, 30)
        lblStokKritis.TabIndex = 0
        lblStokKritis.Text = "0"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Red
        Panel12.Location = New Point(715, 3)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(10, 86)
        Panel12.TabIndex = 4
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel13.Location = New Point(202, 3)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(10, 86)
        Panel13.TabIndex = 2
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel14.Controls.Add(Label11)
        Panel14.Controls.Add(lblTotalAset)
        Panel14.Location = New Point(260, 3)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(205, 86)
        Panel14.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Label11.Location = New Point(12, 57)
        Label11.Name = "Label11"
        Label11.Size = New Size(70, 17)
        Label11.TabIndex = 1
        Label11.Text = "Total Aset"
        ' 
        ' lblTotalAset
        ' 
        lblTotalAset.AutoSize = True
        lblTotalAset.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAset.ForeColor = SystemColors.ButtonFace
        lblTotalAset.Location = New Point(9, 11)
        lblTotalAset.Name = "lblTotalAset"
        lblTotalAset.Size = New Size(58, 30)
        lblTotalAset.TabIndex = 0
        lblTotalAset.Text = "Rp 0"
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.Lime
        Panel17.Location = New Point(459, 3)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(10, 86)
        Panel17.TabIndex = 4
        ' 
        ' dgvStok
        ' 
        dgvStok.AllowUserToAddRows = False
        dgvStok.AllowUserToDeleteRows = False
        dgvStok.AllowUserToResizeColumns = False
        dgvStok.AllowUserToResizeRows = False
        dgvStok.BackgroundColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvStok.DefaultCellStyle = DataGridViewCellStyle2
        dgvStok.Dock = DockStyle.Fill
        dgvStok.Location = New Point(3, 100)
        dgvStok.Name = "dgvStok"
        dgvStok.ReadOnly = True
        dgvStok.RowHeadersVisible = False
        dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStok.Size = New Size(986, 422)
        dgvStok.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGray
        Label1.Location = New Point(14, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "Dari"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGray
        Label2.Location = New Point(180, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 1
        Label2.Text = "s/d"
        ' 
        ' dtpDari
        ' 
        dtpDari.BorderRadius = 5
        dtpDari.Checked = True
        dtpDari.CustomizableEdges = CustomizableEdges1
        dtpDari.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpDari.Font = New Font("Segoe UI", 9F)
        dtpDari.ForeColor = Color.LightGray
        dtpDari.Format = DateTimePickerFormat.Short
        dtpDari.Location = New Point(53, 9)
        dtpDari.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDari.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDari.Name = "dtpDari"
        dtpDari.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dtpDari.Size = New Size(121, 34)
        dtpDari.TabIndex = 2
        dtpDari.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' dtpSampai
        ' 
        dtpSampai.BorderRadius = 5
        dtpSampai.Checked = True
        dtpSampai.CustomizableEdges = CustomizableEdges3
        dtpSampai.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpSampai.Font = New Font("Segoe UI", 9F)
        dtpSampai.ForeColor = Color.LightGray
        dtpSampai.Format = DateTimePickerFormat.Short
        dtpSampai.Location = New Point(210, 9)
        dtpSampai.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpSampai.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpSampai.Name = "dtpSampai"
        dtpSampai.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        dtpSampai.Size = New Size(121, 34)
        dtpSampai.TabIndex = 3
        dtpSampai.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BorderRadius = 5
        btnTampilkan.CustomizableEdges = CustomizableEdges5
        btnTampilkan.DisabledState.BorderColor = Color.DarkGray
        btnTampilkan.DisabledState.CustomBorderColor = Color.DarkGray
        btnTampilkan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTampilkan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTampilkan.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnTampilkan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(348, 9)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnTampilkan.Size = New Size(94, 34)
        btnTampilkan.TabIndex = 4
        btnTampilkan.Text = "Tampilkan"
        ' 
        ' btnHariIni
        ' 
        btnHariIni.BorderColor = Color.DimGray
        btnHariIni.BorderRadius = 5
        btnHariIni.BorderThickness = 1
        btnHariIni.CustomizableEdges = CustomizableEdges7
        btnHariIni.DisabledState.BorderColor = Color.DarkGray
        btnHariIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnHariIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHariIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHariIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnHariIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHariIni.ForeColor = Color.White
        btnHariIni.Location = New Point(461, 9)
        btnHariIni.Name = "btnHariIni"
        btnHariIni.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnHariIni.Size = New Size(94, 34)
        btnHariIni.TabIndex = 5
        btnHariIni.Text = "Hari Ini"
        ' 
        ' btnBulanIni
        ' 
        btnBulanIni.BorderColor = Color.DimGray
        btnBulanIni.BorderRadius = 5
        btnBulanIni.BorderThickness = 1
        btnBulanIni.CustomizableEdges = CustomizableEdges9
        btnBulanIni.DisabledState.BorderColor = Color.DarkGray
        btnBulanIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnBulanIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBulanIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBulanIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnBulanIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBulanIni.ForeColor = Color.White
        btnBulanIni.Location = New Point(574, 9)
        btnBulanIni.Name = "btnBulanIni"
        btnBulanIni.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnBulanIni.Size = New Size(94, 34)
        btnBulanIni.TabIndex = 6
        btnBulanIni.Text = "Bulan Ini"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        Panel1.Controls.Add(btnBulanIni)
        Panel1.Controls.Add(btnHariIni)
        Panel1.Controls.Add(btnTampilkan)
        Panel1.Controls.Add(dtpSampai)
        Panel1.Controls.Add(dtpDari)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 56)
        Panel1.TabIndex = 0
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 532)
        Controls.Add(tabLaporan)
        Controls.Add(Panel1)
        MinimumSize = New Size(1016, 550)
        Name = "FormLaporan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLaporan"
        tabLaporan.ResumeLayout(False)
        tabPenjualan.ResumeLayout(False)
        pnlKartu.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        pnlDisplay.ResumeLayout(False)
        pnlTrx.ResumeLayout(False)
        pnlTrx.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        tabStok.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        CType(dgvStok, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tabLaporan As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabPenjualan As TabPage
    Friend WithEvents tabStok As TabPage
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents dgvStok As DataGridView
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents pnlTrx As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalOmzet As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalTrx As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalBelum As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalLunas As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDari As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpSampai As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnTampilkan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHariIni As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBulanIni As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalItem As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStokKritis As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalAset As Label
    Friend WithEvents Panel17 As Panel
End Class
