<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaksi
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlKiri = New Panel()
        lblJenisTrx = New Label()
        btnJenisPart = New Button()
        btnJenisServisPart = New Button()
        btnJenisServis = New Button()
        lblDataPelanggan = New Label()
        lblNamaPelanggan = New Label()
        txtNamaPelanggan = New TextBox()
        lblNoHp = New Label()
        txtNoHp = New TextBox()
        pnlServis = New Panel()
        lblDataServis = New Label()
        lblNoPolisi = New Label()
        txtNoPolisi = New TextBox()
        lblMerk = New Label()
        cboMerk = New ComboBox()
        lblMekanik = New Label()
        cboMekanik = New ComboBox()
        lblKeluhan = New Label()
        txtKeluhan = New TextBox()
        lblBiayaJasaLbl = New Label()
        txtBiayaJasa = New TextBox()
        lblStatusBayarLbl = New Label()
        cboStatusBayar = New ComboBox()
        pnlKanan = New Panel()
        pnlTopBar = New Panel()
        lblPageTitle = New Label()
        lblNoTransaksi = New Label()
        lblNoServis = New Label()
        lblInfoKasir = New Label()
        pnlCart = New Panel()
        lblAddPart = New Label()
        cboPart = New ComboBox()
        txtQty = New TextBox()
        btnTambahPart = New Button()
        lblDaftarPart = New Label()
        dgvCart = New DataGridView()
        pnlSummary = New Panel()
        lblBiayaJasaTitle = New Label()
        lblBiayaJasa = New Label()
        lblTotalPartTitle = New Label()
        lblTotalPart = New Label()
        lblTotalBayarTitle = New Label()
        lblTotalBayar = New Label()
        btnReset = New Button()
        btnBayar = New Button()
        pnlStatusBar = New Panel()
        lblStatusBar = New Label()
        pnlKiri.SuspendLayout()
        pnlServis.SuspendLayout()
        pnlKanan.SuspendLayout()
        pnlTopBar.SuspendLayout()
        pnlCart.SuspendLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummary.SuspendLayout()
        pnlStatusBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKiri
        ' 
        pnlKiri.AutoScroll = True
        pnlKiri.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlKiri.Controls.Add(lblJenisTrx)
        pnlKiri.Controls.Add(btnJenisPart)
        pnlKiri.Controls.Add(btnJenisServisPart)
        pnlKiri.Controls.Add(lblMerk)
        pnlKiri.Controls.Add(btnJenisServis)
        pnlKiri.Controls.Add(cboMerk)
        pnlKiri.Controls.Add(lblDataPelanggan)
        pnlKiri.Controls.Add(lblNamaPelanggan)
        pnlKiri.Controls.Add(txtNamaPelanggan)
        pnlKiri.Controls.Add(lblNoHp)
        pnlKiri.Controls.Add(txtNoHp)
        pnlKiri.Controls.Add(pnlServis)
        pnlKiri.Dock = DockStyle.Left
        pnlKiri.Location = New Point(0, 0)
        pnlKiri.Name = "pnlKiri"
        pnlKiri.Size = New Size(330, 632)
        pnlKiri.TabIndex = 1
        ' 
        ' lblJenisTrx
        ' 
        lblJenisTrx.AutoSize = True
        lblJenisTrx.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblJenisTrx.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblJenisTrx.Location = New Point(18, 18)
        lblJenisTrx.Name = "lblJenisTrx"
        lblJenisTrx.Size = New Size(99, 13)
        lblJenisTrx.TabIndex = 0
        lblJenisTrx.Text = "JENIS TRANSAKSI"
        ' 
        ' btnJenisPart
        ' 
        btnJenisPart.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        btnJenisPart.Cursor = Cursors.Hand
        btnJenisPart.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(45), CByte(62))
        btnJenisPart.FlatStyle = FlatStyle.Flat
        btnJenisPart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnJenisPart.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        btnJenisPart.Location = New Point(18, 40)
        btnJenisPart.Name = "btnJenisPart"
        btnJenisPart.Size = New Size(88, 34)
        btnJenisPart.TabIndex = 1
        btnJenisPart.Text = "🔩 Part Saja"
        btnJenisPart.UseVisualStyleBackColor = False
        ' 
        ' btnJenisServisPart
        ' 
        btnJenisServisPart.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        btnJenisServisPart.Cursor = Cursors.Hand
        btnJenisServisPart.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(45), CByte(62))
        btnJenisServisPart.FlatStyle = FlatStyle.Flat
        btnJenisServisPart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnJenisServisPart.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        btnJenisServisPart.Location = New Point(112, 40)
        btnJenisServisPart.Name = "btnJenisServisPart"
        btnJenisServisPart.Size = New Size(104, 34)
        btnJenisServisPart.TabIndex = 2
        btnJenisServisPart.Text = "🔧 Servis+Part"
        btnJenisServisPart.UseVisualStyleBackColor = False
        ' 
        ' btnJenisServis
        ' 
        btnJenisServis.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        btnJenisServis.Cursor = Cursors.Hand
        btnJenisServis.FlatAppearance.BorderColor = Color.FromArgb(CByte(42), CByte(45), CByte(62))
        btnJenisServis.FlatStyle = FlatStyle.Flat
        btnJenisServis.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnJenisServis.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        btnJenisServis.Location = New Point(222, 40)
        btnJenisServis.Name = "btnJenisServis"
        btnJenisServis.Size = New Size(88, 34)
        btnJenisServis.TabIndex = 3
        btnJenisServis.Text = "🛠 Servis Saja"
        btnJenisServis.UseVisualStyleBackColor = False
        ' 
        ' lblDataPelanggan
        ' 
        lblDataPelanggan.AutoSize = True
        lblDataPelanggan.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblDataPelanggan.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblDataPelanggan.Location = New Point(18, 92)
        lblDataPelanggan.Name = "lblDataPelanggan"
        lblDataPelanggan.Size = New Size(107, 13)
        lblDataPelanggan.TabIndex = 4
        lblDataPelanggan.Text = "DATA PELANGGAN"
        ' 
        ' lblNamaPelanggan
        ' 
        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblNamaPelanggan.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblNamaPelanggan.Location = New Point(18, 112)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(115, 13)
        lblNamaPelanggan.TabIndex = 5
        lblNamaPelanggan.Text = "NAMA PELANGGAN"
        ' 
        ' txtNamaPelanggan
        ' 
        txtNamaPelanggan.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtNamaPelanggan.BorderStyle = BorderStyle.FixedSingle
        txtNamaPelanggan.Font = New Font("Segoe UI", 10.0F)
        txtNamaPelanggan.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtNamaPelanggan.Location = New Point(18, 130)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.Size = New Size(292, 25)
        txtNamaPelanggan.TabIndex = 6
        ' 
        ' lblNoHp
        ' 
        lblNoHp.AutoSize = True
        lblNoHp.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblNoHp.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblNoHp.Location = New Point(18, 170)
        lblNoHp.Name = "lblNoHp"
        lblNoHp.Size = New Size(45, 13)
        lblNoHp.TabIndex = 7
        lblNoHp.Text = "NO. HP"
        ' 
        ' txtNoHp
        ' 
        txtNoHp.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtNoHp.BorderStyle = BorderStyle.FixedSingle
        txtNoHp.Font = New Font("Segoe UI", 10.0F)
        txtNoHp.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtNoHp.Location = New Point(18, 188)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.Size = New Size(292, 25)
        txtNoHp.TabIndex = 8
        ' 
        ' pnlServis
        ' 
        pnlServis.BackColor = Color.Transparent
        pnlServis.Controls.Add(lblDataServis)
        pnlServis.Controls.Add(lblNoPolisi)
        pnlServis.Controls.Add(txtNoPolisi)
        pnlServis.Controls.Add(lblMekanik)
        pnlServis.Controls.Add(cboMekanik)
        pnlServis.Controls.Add(lblKeluhan)
        pnlServis.Controls.Add(txtKeluhan)
        pnlServis.Controls.Add(lblBiayaJasaLbl)
        pnlServis.Controls.Add(txtBiayaJasa)
        pnlServis.Controls.Add(lblStatusBayarLbl)
        pnlServis.Controls.Add(cboStatusBayar)
        pnlServis.Location = New Point(0, 291)
        pnlServis.Name = "pnlServis"
        pnlServis.Size = New Size(330, 272)
        pnlServis.TabIndex = 9
        pnlServis.Visible = False
        ' 
        ' lblDataServis
        ' 
        lblDataServis.AutoSize = True
        lblDataServis.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblDataServis.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblDataServis.Location = New Point(19, 13)
        lblDataServis.Name = "lblDataServis"
        lblDataServis.Size = New Size(119, 13)
        lblDataServis.TabIndex = 0
        lblDataServis.Text = "DATA MOTOR & SERVIS"
        ' 
        ' lblNoPolisi
        ' 
        lblNoPolisi.AutoSize = True
        lblNoPolisi.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblNoPolisi.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblNoPolisi.Location = New Point(19, 35)
        lblNoPolisi.Name = "lblNoPolisi"
        lblNoPolisi.Size = New Size(63, 13)
        lblNoPolisi.TabIndex = 1
        lblNoPolisi.Text = "NO. POLISI"
        ' 
        ' txtNoPolisi
        ' 
        txtNoPolisi.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtNoPolisi.BorderStyle = BorderStyle.FixedSingle
        txtNoPolisi.Font = New Font("Segoe UI", 10.0F)
        txtNoPolisi.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtNoPolisi.Location = New Point(19, 53)
        txtNoPolisi.Name = "txtNoPolisi"
        txtNoPolisi.Size = New Size(292, 25)
        txtNoPolisi.TabIndex = 2
        ' 
        ' lblMerk
        ' 
        lblMerk.AutoSize = True
        lblMerk.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMerk.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblMerk.Location = New Point(18, 227)
        lblMerk.Name = "lblMerk"
        lblMerk.Size = New Size(81, 13)
        lblMerk.TabIndex = 3
        lblMerk.Text = "MERK MOTOR"
        ' 
        ' cboMerk
        ' 
        cboMerk.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        cboMerk.DropDownStyle = ComboBoxStyle.DropDownList
        cboMerk.FlatStyle = FlatStyle.Flat
        cboMerk.Font = New Font("Segoe UI", 10.0F)
        cboMerk.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        cboMerk.Location = New Point(18, 246)
        cboMerk.Name = "cboMerk"
        cboMerk.Size = New Size(292, 25)
        cboMerk.TabIndex = 4
        ' 
        ' lblMekanik
        ' 
        lblMekanik.AutoSize = True
        lblMekanik.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblMekanik.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblMekanik.Location = New Point(19, 93)
        lblMekanik.Name = "lblMekanik"
        lblMekanik.Size = New Size(58, 13)
        lblMekanik.TabIndex = 5
        lblMekanik.Text = "MEKANIK"
        ' 
        ' cboMekanik
        ' 
        cboMekanik.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        cboMekanik.DropDownStyle = ComboBoxStyle.DropDownList
        cboMekanik.FlatStyle = FlatStyle.Flat
        cboMekanik.Font = New Font("Segoe UI", 10.0F)
        cboMekanik.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        cboMekanik.Location = New Point(19, 111)
        cboMekanik.Name = "cboMekanik"
        cboMekanik.Size = New Size(292, 25)
        cboMekanik.TabIndex = 6
        ' 
        ' lblKeluhan
        ' 
        lblKeluhan.AutoSize = True
        lblKeluhan.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblKeluhan.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblKeluhan.Location = New Point(19, 151)
        lblKeluhan.Name = "lblKeluhan"
        lblKeluhan.Size = New Size(59, 13)
        lblKeluhan.TabIndex = 7
        lblKeluhan.Text = "KELUHAN"
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtKeluhan.BorderStyle = BorderStyle.FixedSingle
        txtKeluhan.Font = New Font("Segoe UI", 10.0F)
        txtKeluhan.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtKeluhan.Location = New Point(19, 169)
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(292, 25)
        txtKeluhan.TabIndex = 8
        ' 
        ' lblBiayaJasaLbl
        ' 
        lblBiayaJasaLbl.AutoSize = True
        lblBiayaJasaLbl.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblBiayaJasaLbl.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblBiayaJasaLbl.Location = New Point(19, 209)
        lblBiayaJasaLbl.Name = "lblBiayaJasaLbl"
        lblBiayaJasaLbl.Size = New Size(93, 13)
        lblBiayaJasaLbl.TabIndex = 9
        lblBiayaJasaLbl.Text = "BIAYA JASA (Rp)"
        ' 
        ' txtBiayaJasa
        ' 
        txtBiayaJasa.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtBiayaJasa.BorderStyle = BorderStyle.FixedSingle
        txtBiayaJasa.Font = New Font("Segoe UI", 10.0F)
        txtBiayaJasa.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtBiayaJasa.Location = New Point(19, 227)
        txtBiayaJasa.Name = "txtBiayaJasa"
        txtBiayaJasa.Size = New Size(138, 25)
        txtBiayaJasa.TabIndex = 10
        txtBiayaJasa.Text = "0"
        ' 
        ' lblStatusBayarLbl
        ' 
        lblStatusBayarLbl.AutoSize = True
        lblStatusBayarLbl.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblStatusBayarLbl.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblStatusBayarLbl.Location = New Point(165, 209)
        lblStatusBayarLbl.Name = "lblStatusBayarLbl"
        lblStatusBayarLbl.Size = New Size(83, 13)
        lblStatusBayarLbl.TabIndex = 11
        lblStatusBayarLbl.Text = "STATUS BAYAR"
        ' 
        ' cboStatusBayar
        ' 
        cboStatusBayar.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        cboStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusBayar.FlatStyle = FlatStyle.Flat
        cboStatusBayar.Font = New Font("Segoe UI", 10.0F)
        cboStatusBayar.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        cboStatusBayar.Location = New Point(165, 227)
        cboStatusBayar.Name = "cboStatusBayar"
        cboStatusBayar.Size = New Size(146, 25)
        cboStatusBayar.TabIndex = 12
        ' 
        ' pnlKanan
        ' 
        pnlKanan.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        pnlKanan.Controls.Add(pnlTopBar)
        pnlKanan.Controls.Add(pnlCart)
        pnlKanan.Controls.Add(pnlSummary)
        pnlKanan.Dock = DockStyle.Fill
        pnlKanan.Location = New Point(330, 0)
        pnlKanan.Name = "pnlKanan"
        pnlKanan.Padding = New Padding(16, 14, 16, 0)
        pnlKanan.Size = New Size(730, 632)
        pnlKanan.TabIndex = 0
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.Transparent
        pnlTopBar.Controls.Add(lblPageTitle)
        pnlTopBar.Controls.Add(lblNoTransaksi)
        pnlTopBar.Controls.Add(lblNoServis)
        pnlTopBar.Controls.Add(lblInfoKasir)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(16, 14)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(698, 44)
        pnlTopBar.TabIndex = 0
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblPageTitle.Location = New Point(0, 10)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(172, 25)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = ChrW(55357) & ChrW(57042) & "  Transaksi Baru"
        ' 
        ' lblNoTransaksi
        ' 
        lblNoTransaksi.AutoSize = True
        lblNoTransaksi.BackColor = Color.FromArgb(CByte(40), CByte(30), CByte(10))
        lblNoTransaksi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNoTransaksi.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        lblNoTransaksi.Location = New Point(220, 13)
        lblNoTransaksi.Name = "lblNoTransaksi"
        lblNoTransaksi.Padding = New Padding(6, 2, 6, 2)
        lblNoTransaksi.Size = New Size(56, 19)
        lblNoTransaksi.TabIndex = 1
        lblNoTransaksi.Text = "TRX-..."
        ' 
        ' lblNoServis
        ' 
        lblNoServis.AutoSize = True
        lblNoServis.Font = New Font("Segoe UI", 9.0F)
        lblNoServis.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblNoServis.Location = New Point(351, 16)
        lblNoServis.Name = "lblNoServis"
        lblNoServis.Size = New Size(41, 15)
        lblNoServis.TabIndex = 2
        lblNoServis.Text = "SRV-..."
        ' 
        ' lblInfoKasir
        ' 
        lblInfoKasir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblInfoKasir.AutoSize = True
        lblInfoKasir.Font = New Font("Segoe UI", 8.0F)
        lblInfoKasir.ForeColor = Color.FromArgb(CByte(68), CByte(85), CByte(102))
        lblInfoKasir.Location = New Point(1058, 15)
        lblInfoKasir.Name = "lblInfoKasir"
        lblInfoKasir.Size = New Size(46, 13)
        lblInfoKasir.TabIndex = 3
        lblInfoKasir.Text = "Kasir: ..."
        ' 
        ' pnlCart
        ' 
        pnlCart.BackColor = Color.Transparent
        pnlCart.Controls.Add(lblAddPart)
        pnlCart.Controls.Add(cboPart)
        pnlCart.Controls.Add(txtQty)
        pnlCart.Controls.Add(btnTambahPart)
        pnlCart.Controls.Add(lblDaftarPart)
        pnlCart.Controls.Add(dgvCart)
        pnlCart.Dock = DockStyle.Fill
        pnlCart.Location = New Point(16, 14)
        pnlCart.Name = "pnlCart"
        pnlCart.Padding = New Padding(0, 0, 0, 140)
        pnlCart.Size = New Size(698, 478)
        pnlCart.TabIndex = 1
        ' 
        ' lblAddPart
        ' 
        lblAddPart.AutoSize = True
        lblAddPart.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblAddPart.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblAddPart.Location = New Point(0, 48)
        lblAddPart.Name = "lblAddPart"
        lblAddPart.Size = New Size(117, 13)
        lblAddPart.TabIndex = 0
        lblAddPart.Text = "TAMBAH SPAREPART"
        ' 
        ' cboPart
        ' 
        cboPart.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cboPart.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        cboPart.DropDownStyle = ComboBoxStyle.DropDownList
        cboPart.FlatStyle = FlatStyle.Flat
        cboPart.Font = New Font("Segoe UI", 9.0F)
        cboPart.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        cboPart.Location = New Point(0, 68)
        cboPart.Name = "cboPart"
        cboPart.Size = New Size(487, 23)
        cboPart.TabIndex = 1
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtQty.BorderStyle = BorderStyle.FixedSingle
        txtQty.Font = New Font("Segoe UI", 9.0F)
        txtQty.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtQty.Location = New Point(510, 68)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(60, 23)
        txtQty.TabIndex = 2
        txtQty.Text = "1"
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTambahPart
        ' 
        btnTambahPart.BackColor = Color.FromArgb(CByte(40), CByte(30), CByte(10))
        btnTambahPart.Cursor = Cursors.Hand
        btnTambahPart.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        btnTambahPart.FlatStyle = FlatStyle.Flat
        btnTambahPart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTambahPart.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        btnTambahPart.Location = New Point(590, 68)
        btnTambahPart.Name = "btnTambahPart"
        btnTambahPart.Size = New Size(90, 23)
        btnTambahPart.TabIndex = 3
        btnTambahPart.Text = "＋ Tambah"
        btnTambahPart.UseVisualStyleBackColor = False
        ' 
        ' lblDaftarPart
        ' 
        lblDaftarPart.AutoSize = True
        lblDaftarPart.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblDaftarPart.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblDaftarPart.Location = New Point(0, 98)
        lblDaftarPart.Name = "lblDaftarPart"
        lblDaftarPart.Size = New Size(79, 13)
        lblDaftarPart.TabIndex = 4
        lblDaftarPart.Text = "DAFTAR PART"
        ' 
        ' dgvCart
        ' 
        dgvCart.AllowUserToAddRows = False
        dgvCart.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(34))
        dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvCart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCart.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvCart.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCart.DefaultCellStyle = DataGridViewCellStyle3
        dgvCart.EnableHeadersVisualStyles = False
        dgvCart.Font = New Font("Segoe UI", 9F)
        dgvCart.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvCart.Location = New Point(0, 116)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersVisible = False
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(698, 344)
        dgvCart.TabIndex = 5
        ' 
        ' pnlSummary
        ' 
        pnlSummary.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlSummary.Controls.Add(lblBiayaJasaTitle)
        pnlSummary.Controls.Add(lblBiayaJasa)
        pnlSummary.Controls.Add(lblTotalPartTitle)
        pnlSummary.Controls.Add(lblTotalPart)
        pnlSummary.Controls.Add(lblTotalBayarTitle)
        pnlSummary.Controls.Add(lblTotalBayar)
        pnlSummary.Controls.Add(btnReset)
        pnlSummary.Controls.Add(btnBayar)
        pnlSummary.Dock = DockStyle.Bottom
        pnlSummary.Location = New Point(16, 492)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Padding = New Padding(14, 12, 14, 12)
        pnlSummary.Size = New Size(698, 140)
        pnlSummary.TabIndex = 2
        ' 
        ' lblBiayaJasaTitle
        ' 
        lblBiayaJasaTitle.AutoSize = True
        lblBiayaJasaTitle.Font = New Font("Segoe UI", 9F)
        lblBiayaJasaTitle.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        lblBiayaJasaTitle.Location = New Point(14, 14)
        lblBiayaJasaTitle.Name = "lblBiayaJasaTitle"
        lblBiayaJasaTitle.Size = New Size(92, 15)
        lblBiayaJasaTitle.TabIndex = 0
        lblBiayaJasaTitle.Text = "Biaya Jasa Servis"
        ' 
        ' lblBiayaJasa
        ' 
        lblBiayaJasa.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblBiayaJasa.AutoSize = True
        lblBiayaJasa.Font = New Font("Segoe UI", 9F)
        lblBiayaJasa.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        lblBiayaJasa.Location = New Point(1038, 14)
        lblBiayaJasa.Name = "lblBiayaJasa"
        lblBiayaJasa.Size = New Size(30, 15)
        lblBiayaJasa.TabIndex = 1
        lblBiayaJasa.Text = "Rp 0"
        ' 
        ' lblTotalPartTitle
        ' 
        lblTotalPartTitle.AutoSize = True
        lblTotalPartTitle.Font = New Font("Segoe UI", 9F)
        lblTotalPartTitle.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        lblTotalPartTitle.Location = New Point(14, 36)
        lblTotalPartTitle.Name = "lblTotalPartTitle"
        lblTotalPartTitle.Size = New Size(85, 15)
        lblTotalPartTitle.TabIndex = 2
        lblTotalPartTitle.Text = "Total Sparepart"
        ' 
        ' lblTotalPart
        ' 
        lblTotalPart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalPart.AutoSize = True
        lblTotalPart.Font = New Font("Segoe UI", 9F)
        lblTotalPart.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        lblTotalPart.Location = New Point(1038, 36)
        lblTotalPart.Name = "lblTotalPart"
        lblTotalPart.Size = New Size(30, 15)
        lblTotalPart.TabIndex = 3
        lblTotalPart.Text = "Rp 0"
        ' 
        ' lblTotalBayarTitle
        ' 
        lblTotalBayarTitle.AutoSize = True
        lblTotalBayarTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTotalBayarTitle.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblTotalBayarTitle.Location = New Point(14, 62)
        lblTotalBayarTitle.Name = "lblTotalBayarTitle"
        lblTotalBayarTitle.Size = New Size(107, 20)
        lblTotalBayarTitle.TabIndex = 4
        lblTotalBayarTitle.Text = "TOTAL BAYAR"
        ' 
        ' lblTotalBayar
        ' 
        lblTotalBayar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalBayar.AutoSize = True
        lblTotalBayar.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTotalBayar.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        lblTotalBayar.Location = New Point(978, 58)
        lblTotalBayar.Name = "lblTotalBayar"
        lblTotalBayar.Size = New Size(50, 25)
        lblTotalBayar.TabIndex = 5
        lblTotalBayar.Text = "Rp 0"
        ' 
        ' btnReset
        ' 
        btnReset.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnReset.BackColor = Color.FromArgb(CByte(42), CByte(45), CByte(62))
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderColor = Color.FromArgb(CByte(51), CByte(51), CByte(68))
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnReset.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        btnReset.Location = New Point(14, 100)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(120, 36)
        btnReset.TabIndex = 6
        btnReset.Text = "↺  Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnBayar
        ' 
        btnBayar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnBayar.BackColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        btnBayar.Cursor = Cursors.Hand
        btnBayar.FlatAppearance.BorderSize = 0
        btnBayar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(90), CByte(0))
        btnBayar.FlatStyle = FlatStyle.Flat
        btnBayar.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnBayar.ForeColor = Color.White
        btnBayar.Location = New Point(440, 85)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(240, 40)
        btnBayar.TabIndex = 7
        btnBayar.Text = "💳  Proses Pembayaran"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' pnlStatusBar
        ' 
        pnlStatusBar.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        pnlStatusBar.Controls.Add(lblStatusBar)
        pnlStatusBar.Dock = DockStyle.Bottom
        pnlStatusBar.Location = New Point(0, 632)
        pnlStatusBar.Name = "pnlStatusBar"
        pnlStatusBar.Size = New Size(1060, 28)
        pnlStatusBar.TabIndex = 2
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.AutoSize = True
        lblStatusBar.Font = New Font("Segoe UI", 8F)
        lblStatusBar.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblStatusBar.Location = New Point(14, 7)
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(124, 13)
        lblStatusBar.TabIndex = 0
        lblStatusBar.Text = "● Database terhubung"
        ' 
        ' frmTransaksi
        ' 
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        ClientSize = New Size(1060, 660)
        Controls.Add(pnlKanan)
        Controls.Add(pnlKiri)
        Controls.Add(pnlStatusBar)
        MinimumSize = New Size(860, 540)
        Name = "frmTransaksi"
        StartPosition = FormStartPosition.CenterParent
        Text = "Transaksi Baru"
        pnlKiri.ResumeLayout(False)
        pnlKiri.PerformLayout()
        pnlServis.ResumeLayout(False)
        pnlServis.PerformLayout()
        pnlKanan.ResumeLayout(False)
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlCart.ResumeLayout(False)
        pnlCart.PerformLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        pnlStatusBar.ResumeLayout(False)
        pnlStatusBar.PerformLayout()
        ResumeLayout(False)

    End Sub

    ' ============================================================
    '  DEKLARASI CONTROL
    ' ============================================================
    Friend WithEvents pnlKiri           As System.Windows.Forms.Panel
    Friend WithEvents lblJenisTrx       As System.Windows.Forms.Label
    Friend WithEvents btnJenisPart      As System.Windows.Forms.Button
    Friend WithEvents btnJenisServisPart As System.Windows.Forms.Button
    Friend WithEvents btnJenisServis    As System.Windows.Forms.Button
    Friend WithEvents lblDataPelanggan  As System.Windows.Forms.Label
    Friend WithEvents lblNamaPelanggan  As System.Windows.Forms.Label
    Friend WithEvents txtNamaPelanggan  As System.Windows.Forms.TextBox
    Friend WithEvents lblNoHp           As System.Windows.Forms.Label
    Friend WithEvents txtNoHp           As System.Windows.Forms.TextBox
    Friend WithEvents pnlServis         As System.Windows.Forms.Panel
    Friend WithEvents lblDataServis     As System.Windows.Forms.Label
    Friend WithEvents lblNoPolisi       As System.Windows.Forms.Label
    Friend WithEvents txtNoPolisi       As System.Windows.Forms.TextBox
    Friend WithEvents lblMerk           As System.Windows.Forms.Label
    Friend WithEvents cboMerk           As System.Windows.Forms.ComboBox
    Friend WithEvents lblMekanik        As System.Windows.Forms.Label
    Friend WithEvents cboMekanik        As System.Windows.Forms.ComboBox
    Friend WithEvents lblKeluhan        As System.Windows.Forms.Label
    Friend WithEvents txtKeluhan        As System.Windows.Forms.TextBox
    Friend WithEvents lblBiayaJasaLbl   As System.Windows.Forms.Label
    Friend WithEvents txtBiayaJasa      As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusBayarLbl As System.Windows.Forms.Label
    Friend WithEvents cboStatusBayar    As System.Windows.Forms.ComboBox
    Friend WithEvents pnlKanan          As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar         As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle      As System.Windows.Forms.Label
    Friend WithEvents lblNoTransaksi    As System.Windows.Forms.Label
    Friend WithEvents lblNoServis       As System.Windows.Forms.Label
    Friend WithEvents lblInfoKasir      As System.Windows.Forms.Label
    Friend WithEvents pnlCart           As System.Windows.Forms.Panel
    Friend WithEvents lblAddPart        As System.Windows.Forms.Label
    Friend WithEvents cboPart           As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty            As System.Windows.Forms.TextBox
    Friend WithEvents btnTambahPart     As System.Windows.Forms.Button
    Friend WithEvents lblDaftarPart     As System.Windows.Forms.Label
    Friend WithEvents dgvCart           As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSummary        As System.Windows.Forms.Panel
    Friend WithEvents lblBiayaJasaTitle As System.Windows.Forms.Label
    Friend WithEvents lblBiayaJasa      As System.Windows.Forms.Label
    Friend WithEvents lblTotalPartTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalPart      As System.Windows.Forms.Label
    Friend WithEvents lblTotalBayarTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalBayar     As System.Windows.Forms.Label
    Friend WithEvents btnBayar          As System.Windows.Forms.Button
    Friend WithEvents btnReset          As System.Windows.Forms.Button
    Friend WithEvents pnlStatusBar      As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar      As System.Windows.Forms.Label

End Class
