<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRiwayatTransaksi
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
        pnlBody = New Panel()
        Panel1 = New Panel()
        dgvRiwayat = New DataGridView()
        pnlDetail = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        pnlTransaksi = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblDetWaktu = New Label()
        Label8 = New Label()
        lblDetJenis = New Label()
        Label9 = New Label()
        lblDetNoHp = New Label()
        lblDetNoTrx = New Label()
        lblDetPelanggan = New Label()
        lblDetStatus = New Label()
        pnlDgvDetail = New Panel()
        dgvDetail = New DataGridView()
        pnlServiceInfo = New Panel()
        Label16 = New Label()
        lblDetMekanik = New Label()
        lblDetStatusMotor = New Label()
        lblDetBiayaJasa = New Label()
        Label15 = New Label()
        Label14 = New Label()
        pnlTotal = New Panel()
        Label12 = New Label()
        lblDetTotal = New Label()
        pnlToolbar = New Panel()
        btnHariIni = New Guna.UI2.WinForms.Guna2Button()
        btnTampilkan = New Guna.UI2.WinForms.Guna2Button()
        dtpSampai = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpDari = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        lblStatusBar = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        pnlBody.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        pnlDetail.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        pnlTransaksi.SuspendLayout()
        pnlDgvDetail.SuspendLayout()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        pnlServiceInfo.SuspendLayout()
        pnlTotal.SuspendLayout()
        pnlToolbar.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.Controls.Add(Panel1)
        pnlBody.Controls.Add(pnlDetail)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(3, 53)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1014, 627)
        pnlBody.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dgvRiwayat)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(660, 627)
        Panel1.TabIndex = 2
        ' 
        ' dgvRiwayat
        ' 
        dgvRiwayat.AllowUserToAddRows = False
        dgvRiwayat.AllowUserToDeleteRows = False
        dgvRiwayat.AllowUserToResizeColumns = False
        dgvRiwayat.AllowUserToResizeRows = False
        dgvRiwayat.BackgroundColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvRiwayat.DefaultCellStyle = DataGridViewCellStyle1
        dgvRiwayat.Dock = DockStyle.Fill
        dgvRiwayat.Location = New Point(0, 0)
        dgvRiwayat.Name = "dgvRiwayat"
        dgvRiwayat.ReadOnly = True
        dgvRiwayat.RowHeadersVisible = False
        dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRiwayat.Size = New Size(660, 627)
        dgvRiwayat.TabIndex = 0
        ' 
        ' pnlDetail
        ' 
        pnlDetail.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        pnlDetail.Controls.Add(TableLayoutPanel2)
        pnlDetail.Dock = DockStyle.Right
        pnlDetail.Location = New Point(660, 0)
        pnlDetail.Name = "pnlDetail"
        pnlDetail.Size = New Size(354, 627)
        pnlDetail.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(pnlTransaksi, 0, 0)
        TableLayoutPanel2.Controls.Add(pnlDgvDetail, 0, 1)
        TableLayoutPanel2.Controls.Add(pnlServiceInfo, 0, 2)
        TableLayoutPanel2.Controls.Add(pnlTotal, 0, 3)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.Size = New Size(354, 627)
        TableLayoutPanel2.TabIndex = 32
        ' 
        ' pnlTransaksi
        ' 
        pnlTransaksi.Controls.Add(Label3)
        pnlTransaksi.Controls.Add(Label4)
        pnlTransaksi.Controls.Add(Label5)
        pnlTransaksi.Controls.Add(Label11)
        pnlTransaksi.Controls.Add(Label6)
        pnlTransaksi.Controls.Add(Label7)
        pnlTransaksi.Controls.Add(lblDetWaktu)
        pnlTransaksi.Controls.Add(Label8)
        pnlTransaksi.Controls.Add(lblDetJenis)
        pnlTransaksi.Controls.Add(Label9)
        pnlTransaksi.Controls.Add(lblDetNoHp)
        pnlTransaksi.Controls.Add(lblDetNoTrx)
        pnlTransaksi.Controls.Add(lblDetPelanggan)
        pnlTransaksi.Controls.Add(lblDetStatus)
        pnlTransaksi.Dock = DockStyle.Fill
        pnlTransaksi.Location = New Point(3, 3)
        pnlTransaksi.Name = "pnlTransaksi"
        pnlTransaksi.Size = New Size(348, 307)
        pnlTransaksi.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(3, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 21)
        Label3.TabIndex = 3
        Label3.Text = "Detail Transaksi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGray
        Label4.Location = New Point(5, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 13
        Label4.Text = "NO. TRANSAKSI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGray
        Label5.Location = New Point(5, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 14
        Label5.Text = "PELANGGAN"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGray
        Label11.Location = New Point(5, 279)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 15)
        Label11.TabIndex = 27
        Label11.Text = "DAFTAR PART"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGray
        Label6.Location = New Point(5, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 15
        Label6.Text = "NO. HP"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGray
        Label7.Location = New Point(5, 155)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 16
        Label7.Text = "JENIS"
        ' 
        ' lblDetWaktu
        ' 
        lblDetWaktu.AutoSize = True
        lblDetWaktu.BackColor = Color.Transparent
        lblDetWaktu.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetWaktu.ForeColor = Color.White
        lblDetWaktu.Location = New Point(6, 215)
        lblDetWaktu.Name = "lblDetWaktu"
        lblDetWaktu.Size = New Size(12, 15)
        lblDetWaktu.TabIndex = 25
        lblDetWaktu.Text = "-"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGray
        Label8.Location = New Point(5, 198)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 15)
        Label8.TabIndex = 17
        Label8.Text = "WAKTU"
        ' 
        ' lblDetJenis
        ' 
        lblDetJenis.AutoSize = True
        lblDetJenis.BackColor = Color.Transparent
        lblDetJenis.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetJenis.ForeColor = Color.White
        lblDetJenis.Location = New Point(4, 173)
        lblDetJenis.Name = "lblDetJenis"
        lblDetJenis.Size = New Size(12, 15)
        lblDetJenis.TabIndex = 24
        lblDetJenis.Text = "-"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGray
        Label9.Location = New Point(5, 239)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 15)
        Label9.TabIndex = 18
        Label9.Text = "STATUS BAYAR"
        ' 
        ' lblDetNoHp
        ' 
        lblDetNoHp.AutoSize = True
        lblDetNoHp.BackColor = Color.Transparent
        lblDetNoHp.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetNoHp.ForeColor = Color.White
        lblDetNoHp.Location = New Point(5, 130)
        lblDetNoHp.Name = "lblDetNoHp"
        lblDetNoHp.Size = New Size(12, 15)
        lblDetNoHp.TabIndex = 23
        lblDetNoHp.Text = "-"
        ' 
        ' lblDetNoTrx
        ' 
        lblDetNoTrx.AutoSize = True
        lblDetNoTrx.BackColor = Color.Transparent
        lblDetNoTrx.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetNoTrx.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetNoTrx.Location = New Point(7, 48)
        lblDetNoTrx.Name = "lblDetNoTrx"
        lblDetNoTrx.Size = New Size(12, 15)
        lblDetNoTrx.TabIndex = 20
        lblDetNoTrx.Text = "-"
        ' 
        ' lblDetPelanggan
        ' 
        lblDetPelanggan.AutoSize = True
        lblDetPelanggan.BackColor = Color.Transparent
        lblDetPelanggan.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetPelanggan.ForeColor = Color.White
        lblDetPelanggan.Location = New Point(5, 89)
        lblDetPelanggan.Name = "lblDetPelanggan"
        lblDetPelanggan.Size = New Size(12, 15)
        lblDetPelanggan.TabIndex = 22
        lblDetPelanggan.Text = "-"
        ' 
        ' lblDetStatus
        ' 
        lblDetStatus.AutoSize = True
        lblDetStatus.BackColor = Color.Transparent
        lblDetStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetStatus.ForeColor = Color.Lime
        lblDetStatus.Location = New Point(5, 257)
        lblDetStatus.Name = "lblDetStatus"
        lblDetStatus.Size = New Size(12, 15)
        lblDetStatus.TabIndex = 21
        lblDetStatus.Text = "-"
        ' 
        ' pnlDgvDetail
        ' 
        pnlDgvDetail.Controls.Add(dgvDetail)
        pnlDgvDetail.Dock = DockStyle.Fill
        pnlDgvDetail.Location = New Point(3, 316)
        pnlDgvDetail.Name = "pnlDgvDetail"
        pnlDgvDetail.Size = New Size(348, 150)
        pnlDgvDetail.TabIndex = 29
        ' 
        ' dgvDetail
        ' 
        dgvDetail.BackgroundColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDetail.DefaultCellStyle = DataGridViewCellStyle2
        dgvDetail.Dock = DockStyle.Fill
        dgvDetail.Location = New Point(0, 0)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.ReadOnly = True
        dgvDetail.RowHeadersVisible = False
        dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetail.Size = New Size(348, 150)
        dgvDetail.TabIndex = 28
        ' 
        ' pnlServiceInfo
        ' 
        pnlServiceInfo.Controls.Add(Label16)
        pnlServiceInfo.Controls.Add(lblDetMekanik)
        pnlServiceInfo.Controls.Add(lblDetStatusMotor)
        pnlServiceInfo.Controls.Add(lblDetBiayaJasa)
        pnlServiceInfo.Controls.Add(Label15)
        pnlServiceInfo.Controls.Add(Label14)
        pnlServiceInfo.Dock = DockStyle.Fill
        pnlServiceInfo.Location = New Point(3, 472)
        pnlServiceInfo.Name = "pnlServiceInfo"
        pnlServiceInfo.Size = New Size(348, 88)
        pnlServiceInfo.TabIndex = 2
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label16.ForeColor = Color.DarkGray
        Label16.Location = New Point(7, 38)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 15)
        Label16.TabIndex = 36
        Label16.Text = "MEKANIK"
        ' 
        ' lblDetMekanik
        ' 
        lblDetMekanik.AutoSize = True
        lblDetMekanik.BackColor = Color.Transparent
        lblDetMekanik.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetMekanik.ForeColor = Color.White
        lblDetMekanik.Location = New Point(146, 38)
        lblDetMekanik.Name = "lblDetMekanik"
        lblDetMekanik.Size = New Size(12, 15)
        lblDetMekanik.TabIndex = 35
        lblDetMekanik.Text = "-"
        ' 
        ' lblDetStatusMotor
        ' 
        lblDetStatusMotor.AutoSize = True
        lblDetStatusMotor.BackColor = Color.Transparent
        lblDetStatusMotor.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetStatusMotor.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetStatusMotor.Location = New Point(146, 63)
        lblDetStatusMotor.Name = "lblDetStatusMotor"
        lblDetStatusMotor.Size = New Size(12, 15)
        lblDetStatusMotor.TabIndex = 34
        lblDetStatusMotor.Text = "-"
        ' 
        ' lblDetBiayaJasa
        ' 
        lblDetBiayaJasa.AutoSize = True
        lblDetBiayaJasa.BackColor = Color.Transparent
        lblDetBiayaJasa.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetBiayaJasa.ForeColor = Color.White
        lblDetBiayaJasa.Location = New Point(146, 12)
        lblDetBiayaJasa.Name = "lblDetBiayaJasa"
        lblDetBiayaJasa.Size = New Size(12, 15)
        lblDetBiayaJasa.TabIndex = 33
        lblDetBiayaJasa.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label15.ForeColor = Color.DarkGray
        Label15.Location = New Point(8, 63)
        Label15.Name = "Label15"
        Label15.Size = New Size(93, 15)
        Label15.TabIndex = 32
        Label15.Text = "STATUS SERVIS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label14.ForeColor = Color.DarkGray
        Label14.Location = New Point(7, 11)
        Label14.Name = "Label14"
        Label14.Size = New Size(71, 15)
        Label14.TabIndex = 31
        Label14.Text = "BIAYA JASA"
        ' 
        ' pnlTotal
        ' 
        pnlTotal.Controls.Add(Label12)
        pnlTotal.Controls.Add(lblDetTotal)
        pnlTotal.Dock = DockStyle.Fill
        pnlTotal.Location = New Point(3, 566)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New Size(348, 58)
        pnlTotal.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.ForeColor = Color.DarkGray
        Label12.Location = New Point(7, 11)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 15)
        Label12.TabIndex = 29
        Label12.Text = "TOTAL BAYAR"
        ' 
        ' lblDetTotal
        ' 
        lblDetTotal.AutoSize = True
        lblDetTotal.BackColor = Color.Transparent
        lblDetTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetTotal.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetTotal.Location = New Point(7, 26)
        lblDetTotal.Name = "lblDetTotal"
        lblDetTotal.Size = New Size(40, 21)
        lblDetTotal.TabIndex = 26
        lblDetTotal.Text = "Rp -"
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        pnlToolbar.Controls.Add(btnHariIni)
        pnlToolbar.Controls.Add(btnTampilkan)
        pnlToolbar.Controls.Add(dtpSampai)
        pnlToolbar.Controls.Add(dtpDari)
        pnlToolbar.Controls.Add(Label2)
        pnlToolbar.Controls.Add(Label1)
        pnlToolbar.Dock = DockStyle.Fill
        pnlToolbar.Location = New Point(3, 3)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1014, 44)
        pnlToolbar.TabIndex = 1
        ' 
        ' btnHariIni
        ' 
        btnHariIni.BorderColor = Color.DimGray
        btnHariIni.BorderRadius = 5
        btnHariIni.BorderThickness = 1
        btnHariIni.CustomizableEdges = CustomizableEdges1
        btnHariIni.DisabledState.BorderColor = Color.DarkGray
        btnHariIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnHariIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHariIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHariIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnHariIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHariIni.ForeColor = Color.White
        btnHariIni.Location = New Point(452, 6)
        btnHariIni.Name = "btnHariIni"
        btnHariIni.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnHariIni.Size = New Size(94, 34)
        btnHariIni.TabIndex = 12
        btnHariIni.Text = "Hari Ini"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BorderRadius = 5
        btnTampilkan.CustomizableEdges = CustomizableEdges3
        btnTampilkan.DisabledState.BorderColor = Color.DarkGray
        btnTampilkan.DisabledState.CustomBorderColor = Color.DarkGray
        btnTampilkan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTampilkan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTampilkan.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnTampilkan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(339, 6)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnTampilkan.Size = New Size(94, 34)
        btnTampilkan.TabIndex = 11
        btnTampilkan.Text = "Tampilkan"
        ' 
        ' dtpSampai
        ' 
        dtpSampai.BorderRadius = 5
        dtpSampai.Checked = True
        dtpSampai.CustomizableEdges = CustomizableEdges5
        dtpSampai.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpSampai.Font = New Font("Segoe UI", 9F)
        dtpSampai.ForeColor = Color.LightGray
        dtpSampai.Format = DateTimePickerFormat.Short
        dtpSampai.Location = New Point(201, 6)
        dtpSampai.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpSampai.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpSampai.Name = "dtpSampai"
        dtpSampai.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dtpSampai.Size = New Size(121, 34)
        dtpSampai.TabIndex = 10
        dtpSampai.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' dtpDari
        ' 
        dtpDari.BorderRadius = 5
        dtpDari.Checked = True
        dtpDari.CustomizableEdges = CustomizableEdges7
        dtpDari.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpDari.Font = New Font("Segoe UI", 9F)
        dtpDari.ForeColor = Color.LightGray
        dtpDari.Format = DateTimePickerFormat.Short
        dtpDari.Location = New Point(44, 6)
        dtpDari.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDari.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDari.Name = "dtpDari"
        dtpDari.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        dtpDari.Size = New Size(121, 34)
        dtpDari.TabIndex = 9
        dtpDari.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGray
        Label2.Location = New Point(171, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 8
        Label2.Text = "s/d"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGray
        Label1.Location = New Point(5, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 7
        Label1.Text = "Dari"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblStatusBar)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 686)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1014, 31)
        Panel3.TabIndex = 2
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.AutoSize = True
        lblStatusBar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatusBar.ForeColor = Color.DarkGray
        lblStatusBar.Location = New Point(5, 6)
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(66, 15)
        lblStatusBar.TabIndex = 13
        lblStatusBar.Text = "0 transaksi"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(pnlBody, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel3, 0, 2)
        TableLayoutPanel1.Controls.Add(pnlToolbar, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 7F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 88F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel1.Size = New Size(1020, 720)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' FormRiwayatTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        ClientSize = New Size(1020, 720)
        Controls.Add(TableLayoutPanel1)
        Name = "FormRiwayatTransaksi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRiwayatTransaksi"
        pnlBody.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        pnlDetail.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        pnlTransaksi.ResumeLayout(False)
        pnlTransaksi.PerformLayout()
        pnlDgvDetail.ResumeLayout(False)
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
        pnlServiceInfo.ResumeLayout(False)
        pnlServiceInfo.PerformLayout()
        pnlTotal.ResumeLayout(False)
        pnlTotal.PerformLayout()
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnHariIni As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTampilkan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpSampai As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpDari As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDetNoTrx As Label
    Friend WithEvents lblDetStatus As Label
    Friend WithEvents lblDetJenis As Label
    Friend WithEvents lblDetNoHp As Label
    Friend WithEvents lblDetPelanggan As Label
    Friend WithEvents lblDetWaktu As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents lblStatusBar As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlTransaksi As Panel
    Friend WithEvents pnlDgvDetail As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pnlServiceInfo As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDetMekanik As Label
    Friend WithEvents lblDetStatusMotor As Label
    Friend WithEvents lblDetBiayaJasa As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlTotal As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDetTotal As Label
End Class
