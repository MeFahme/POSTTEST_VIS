<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetailServis
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
        pnlInfo = New Panel()
        lblStatusAktif = New Label()
        lblNoServis = New Label()
        lblTglSelesai = New Label()
        lblStatusLbl = New Label()
        lblTglMasuk = New Label()
        lblMekanik = New Label()
        lblMerkMotor = New Label()
        lblNoPolisi = New Label()
        lblPelanggan = New Label()
        lblKeluhan = New Label()
        lblMerkLbl = New Label()
        lblTglSelesaiLbl = New Label()
        lblKeluhanLbl = New Label()
        lblNoServisLbl = New Label()
        lblPelangganLbl = New Label()
        lblNoPolisiLbl = New Label()
        lblMekanikLbl = New Label()
        lblTglMasukLbl = New Label()
        pnlUpdate = New Panel()
        lblUpdateLbl = New Label()
        txtCatatan = New TextBox()
        btnUpdate = New Button()
        btnAntri = New Button()
        btnSelesai = New Button()
        btnMenungguPart = New Button()
        btnProses = New Button()
        pnlPart = New Panel()
        lblPartLbl = New Label()
        cboPart = New ComboBox()
        txtQtyPart = New TextBox()
        btnPakaiPart = New Button()
        pnlLog = New Panel()
        lblLogLbl = New Label()
        dgvLog = New DataGridView()
        pnlStatusBar = New Panel()
        lblStatusBar = New Label()
        pnlInfo.SuspendLayout()
        pnlUpdate.SuspendLayout()
        pnlPart.SuspendLayout()
        pnlLog.SuspendLayout()
        CType(dgvLog, ComponentModel.ISupportInitialize).BeginInit()
        pnlStatusBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlInfo.Controls.Add(lblStatusAktif)
        pnlInfo.Controls.Add(lblNoServis)
        pnlInfo.Controls.Add(lblTglSelesai)
        pnlInfo.Controls.Add(lblStatusLbl)
        pnlInfo.Controls.Add(lblTglMasuk)
        pnlInfo.Controls.Add(lblMekanik)
        pnlInfo.Controls.Add(lblMerkMotor)
        pnlInfo.Controls.Add(lblNoPolisi)
        pnlInfo.Controls.Add(lblPelanggan)
        pnlInfo.Controls.Add(lblKeluhan)
        pnlInfo.Controls.Add(lblMerkLbl)
        pnlInfo.Controls.Add(lblTglSelesaiLbl)
        pnlInfo.Controls.Add(lblKeluhanLbl)
        pnlInfo.Dock = DockStyle.Top
        pnlInfo.Location = New Point(0, 0)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Padding = New Padding(14, 12, 14, 10)
        pnlInfo.Size = New Size(620, 160)
        pnlInfo.TabIndex = 21
        ' 
        ' lblStatusAktif
        ' 
        lblStatusAktif.AutoSize = True
        lblStatusAktif.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatusAktif.ForeColor = Color.DarkOrange
        lblStatusAktif.Location = New Point(200, 32)
        lblStatusAktif.Name = "lblStatusAktif"
        lblStatusAktif.Size = New Size(46, 17)
        lblStatusAktif.TabIndex = 26
        lblStatusAktif.Text = "Status"
        ' 
        ' lblNoServis
        ' 
        lblNoServis.AutoSize = True
        lblNoServis.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoServis.ForeColor = Color.DarkOrange
        lblNoServis.Location = New Point(17, 32)
        lblNoServis.Name = "lblNoServis"
        lblNoServis.Size = New Size(32, 17)
        lblNoServis.TabIndex = 25
        lblNoServis.Text = "SRV"
        ' 
        ' lblTglSelesai
        ' 
        lblTglSelesai.AutoSize = True
        lblTglSelesai.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        lblTglSelesai.Location = New Point(329, 125)
        lblTglSelesai.Name = "lblTglSelesai"
        lblTglSelesai.Size = New Size(65, 15)
        lblTglSelesai.TabIndex = 24
        lblTglSelesai.Text = "05-12-2026"
        ' 
        ' lblStatusLbl
        ' 
        lblStatusLbl.AutoSize = True
        lblStatusLbl.BackColor = Color.Transparent
        lblStatusLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatusLbl.ForeColor = SystemColors.ButtonFace
        lblStatusLbl.Location = New Point(200, 12)
        lblStatusLbl.Name = "lblStatusLbl"
        lblStatusLbl.Size = New Size(50, 15)
        lblStatusLbl.TabIndex = 2
        lblStatusLbl.Text = "STATUS"
        ' 
        ' lblTglMasuk
        ' 
        lblTglMasuk.AutoSize = True
        lblTglMasuk.ForeColor = SystemColors.ButtonFace
        lblTglMasuk.Location = New Point(200, 125)
        lblTglMasuk.Name = "lblTglMasuk"
        lblTglMasuk.Size = New Size(65, 15)
        lblTglMasuk.TabIndex = 23
        lblTglMasuk.Text = "06-12-2026"
        ' 
        ' lblMekanik
        ' 
        lblMekanik.AutoSize = True
        lblMekanik.ForeColor = SystemColors.ButtonFace
        lblMekanik.Location = New Point(17, 124)
        lblMekanik.Name = "lblMekanik"
        lblMekanik.Size = New Size(52, 15)
        lblMekanik.TabIndex = 22
        lblMekanik.Text = "Mekanik"
        ' 
        ' lblMerkMotor
        ' 
        lblMerkMotor.AutoSize = True
        lblMerkMotor.ForeColor = SystemColors.ButtonFace
        lblMerkMotor.Location = New Point(329, 77)
        lblMerkMotor.Name = "lblMerkMotor"
        lblMerkMotor.Size = New Size(34, 15)
        lblMerkMotor.TabIndex = 21
        lblMerkMotor.Text = "Merk"
        ' 
        ' lblNoPolisi
        ' 
        lblNoPolisi.AutoSize = True
        lblNoPolisi.ForeColor = SystemColors.ButtonFace
        lblNoPolisi.Location = New Point(200, 77)
        lblNoPolisi.Name = "lblNoPolisi"
        lblNoPolisi.Size = New Size(20, 15)
        lblNoPolisi.TabIndex = 20
        lblNoPolisi.Text = "KT"
        ' 
        ' lblPelanggan
        ' 
        lblPelanggan.AutoSize = True
        lblPelanggan.ForeColor = SystemColors.ButtonFace
        lblPelanggan.Location = New Point(17, 77)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Size = New Size(39, 15)
        lblPelanggan.TabIndex = 19
        lblPelanggan.Text = "Nama"
        ' 
        ' lblKeluhan
        ' 
        lblKeluhan.AutoSize = True
        lblKeluhan.ForeColor = SystemColors.ButtonFace
        lblKeluhan.Location = New Point(494, 77)
        lblKeluhan.Name = "lblKeluhan"
        lblKeluhan.Size = New Size(50, 15)
        lblKeluhan.TabIndex = 18
        lblKeluhan.Text = "Keluhan"
        ' 
        ' lblMerkLbl
        ' 
        lblMerkLbl.AutoSize = True
        lblMerkLbl.BackColor = Color.Transparent
        lblMerkLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblMerkLbl.ForeColor = SystemColors.ButtonFace
        lblMerkLbl.Location = New Point(329, 58)
        lblMerkLbl.Name = "lblMerkLbl"
        lblMerkLbl.Size = New Size(51, 15)
        lblMerkLbl.TabIndex = 8
        lblMerkLbl.Text = "MOTOR"
        ' 
        ' lblTglSelesaiLbl
        ' 
        lblTglSelesaiLbl.AutoSize = True
        lblTglSelesaiLbl.BackColor = Color.Transparent
        lblTglSelesaiLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTglSelesaiLbl.ForeColor = SystemColors.ButtonFace
        lblTglSelesaiLbl.Location = New Point(329, 106)
        lblTglSelesaiLbl.Name = "lblTglSelesaiLbl"
        lblTglSelesaiLbl.Size = New Size(76, 15)
        lblTglSelesaiLbl.TabIndex = 14
        lblTglSelesaiLbl.Text = "TGL SELESAI"
        lblTglSelesaiLbl.Visible = False
        ' 
        ' lblKeluhanLbl
        ' 
        lblKeluhanLbl.AutoSize = True
        lblKeluhanLbl.BackColor = Color.Transparent
        lblKeluhanLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblKeluhanLbl.ForeColor = SystemColors.ButtonFace
        lblKeluhanLbl.Location = New Point(494, 58)
        lblKeluhanLbl.Name = "lblKeluhanLbl"
        lblKeluhanLbl.Size = New Size(62, 15)
        lblKeluhanLbl.TabIndex = 16
        lblKeluhanLbl.Text = "KELUHAN"
        ' 
        ' lblNoServisLbl
        ' 
        lblNoServisLbl.AutoSize = True
        lblNoServisLbl.BackColor = Color.Transparent
        lblNoServisLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNoServisLbl.ForeColor = SystemColors.ButtonFace
        lblNoServisLbl.Location = New Point(14, 12)
        lblNoServisLbl.Name = "lblNoServisLbl"
        lblNoServisLbl.Size = New Size(71, 15)
        lblNoServisLbl.TabIndex = 0
        lblNoServisLbl.Text = "NO. SERVIS"
        ' 
        ' lblPelangganLbl
        ' 
        lblPelangganLbl.AutoSize = True
        lblPelangganLbl.BackColor = Color.Transparent
        lblPelangganLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPelangganLbl.ForeColor = SystemColors.ButtonFace
        lblPelangganLbl.Location = New Point(14, 58)
        lblPelangganLbl.Name = "lblPelangganLbl"
        lblPelangganLbl.Size = New Size(78, 15)
        lblPelangganLbl.TabIndex = 4
        lblPelangganLbl.Text = "PELANGGAN"
        ' 
        ' lblNoPolisiLbl
        ' 
        lblNoPolisiLbl.AutoSize = True
        lblNoPolisiLbl.BackColor = Color.Transparent
        lblNoPolisiLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNoPolisiLbl.ForeColor = SystemColors.ButtonFace
        lblNoPolisiLbl.Location = New Point(200, 58)
        lblNoPolisiLbl.Name = "lblNoPolisiLbl"
        lblNoPolisiLbl.Size = New Size(68, 15)
        lblNoPolisiLbl.TabIndex = 6
        lblNoPolisiLbl.Text = "NO. POLISI"
        ' 
        ' lblMekanikLbl
        ' 
        lblMekanikLbl.AutoSize = True
        lblMekanikLbl.BackColor = Color.Transparent
        lblMekanikLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblMekanikLbl.ForeColor = SystemColors.ButtonFace
        lblMekanikLbl.Location = New Point(14, 106)
        lblMekanikLbl.Name = "lblMekanikLbl"
        lblMekanikLbl.Size = New Size(61, 15)
        lblMekanikLbl.TabIndex = 10
        lblMekanikLbl.Text = "MEKANIK"
        ' 
        ' lblTglMasukLbl
        ' 
        lblTglMasukLbl.AutoSize = True
        lblTglMasukLbl.BackColor = Color.Transparent
        lblTglMasukLbl.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTglMasukLbl.ForeColor = SystemColors.ButtonFace
        lblTglMasukLbl.Location = New Point(200, 106)
        lblTglMasukLbl.Name = "lblTglMasukLbl"
        lblTglMasukLbl.Size = New Size(75, 15)
        lblTglMasukLbl.TabIndex = 12
        lblTglMasukLbl.Text = "TGL MASUK"
        ' 
        ' pnlUpdate
        ' 
        pnlUpdate.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        pnlUpdate.Controls.Add(lblUpdateLbl)
        pnlUpdate.Controls.Add(txtCatatan)
        pnlUpdate.Controls.Add(btnUpdate)
        pnlUpdate.Controls.Add(btnAntri)
        pnlUpdate.Controls.Add(btnSelesai)
        pnlUpdate.Controls.Add(btnMenungguPart)
        pnlUpdate.Controls.Add(btnProses)
        pnlUpdate.Dock = DockStyle.Top
        pnlUpdate.Location = New Point(0, 160)
        pnlUpdate.Name = "pnlUpdate"
        pnlUpdate.Padding = New Padding(14, 10, 14, 8)
        pnlUpdate.Size = New Size(620, 148)
        pnlUpdate.TabIndex = 20
        ' 
        ' lblUpdateLbl
        ' 
        lblUpdateLbl.AutoSize = True
        lblUpdateLbl.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblUpdateLbl.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblUpdateLbl.Location = New Point(14, 10)
        lblUpdateLbl.Name = "lblUpdateLbl"
        lblUpdateLbl.Size = New Size(90, 13)
        lblUpdateLbl.TabIndex = 0
        lblUpdateLbl.Text = "UPDATE STATUS"
        ' 
        ' txtCatatan
        ' 
        txtCatatan.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtCatatan.BorderStyle = BorderStyle.FixedSingle
        txtCatatan.Font = New Font("Segoe UI", 9.0F)
        txtCatatan.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtCatatan.Location = New Point(14, 70)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.PlaceholderText = "Catatan pekerjaan..."
        txtCatatan.Size = New Size(589, 23)
        txtCatatan.TabIndex = 5
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(90), CByte(0))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(14, 108)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(589, 34)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update Status"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnAntri
        ' 
        btnAntri.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        btnAntri.Location = New Point(12, 26)
        btnAntri.Name = "btnAntri"
        btnAntri.Size = New Size(130, 30)
        btnAntri.TabIndex = 1
        btnAntri.Text = "Antri"
        ' 
        ' btnSelesai
        ' 
        btnSelesai.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        btnSelesai.Location = New Point(478, 26)
        btnSelesai.Name = "btnSelesai"
        btnSelesai.Size = New Size(130, 30)
        btnSelesai.TabIndex = 4
        btnSelesai.Text = "Selesai"
        ' 
        ' btnMenungguPart
        ' 
        btnMenungguPart.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        btnMenungguPart.Location = New Point(329, 26)
        btnMenungguPart.Name = "btnMenungguPart"
        btnMenungguPart.Size = New Size(130, 30)
        btnMenungguPart.TabIndex = 3
        btnMenungguPart.Text = "Menunggu Part"
        ' 
        ' btnProses
        ' 
        btnProses.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        btnProses.Location = New Point(176, 26)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(130, 30)
        btnProses.TabIndex = 2
        btnProses.Text = "Proses"
        ' 
        ' pnlPart
        ' 
        pnlPart.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlPart.Controls.Add(lblPartLbl)
        pnlPart.Controls.Add(cboPart)
        pnlPart.Controls.Add(txtQtyPart)
        pnlPart.Controls.Add(btnPakaiPart)
        pnlPart.Dock = DockStyle.Top
        pnlPart.Location = New Point(0, 308)
        pnlPart.Name = "pnlPart"
        pnlPart.Padding = New Padding(14, 8, 14, 8)
        pnlPart.Size = New Size(620, 68)
        pnlPart.TabIndex = 19
        ' 
        ' lblPartLbl
        ' 
        lblPartLbl.AutoSize = True
        lblPartLbl.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblPartLbl.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblPartLbl.Location = New Point(14, 8)
        lblPartLbl.Name = "lblPartLbl"
        lblPartLbl.Size = New Size(172, 13)
        lblPartLbl.TabIndex = 0
        lblPartLbl.Text = "CATAT PEMAKAIAN SPAREPART"
        ' 
        ' cboPart
        ' 
        cboPart.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        cboPart.DropDownStyle = ComboBoxStyle.DropDownList
        cboPart.FlatStyle = FlatStyle.Flat
        cboPart.Font = New Font("Segoe UI", 9.0F)
        cboPart.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        cboPart.Location = New Point(14, 28)
        cboPart.Name = "cboPart"
        cboPart.Size = New Size(445, 23)
        cboPart.TabIndex = 1
        ' 
        ' txtQtyPart
        ' 
        txtQtyPart.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtQtyPart.BorderStyle = BorderStyle.FixedSingle
        txtQtyPart.Font = New Font("Segoe UI", 9.0F)
        txtQtyPart.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtQtyPart.Location = New Point(467, 28)
        txtQtyPart.Name = "txtQtyPart"
        txtQtyPart.Size = New Size(50, 23)
        txtQtyPart.TabIndex = 2
        txtQtyPart.Text = "1"
        txtQtyPart.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPakaiPart
        ' 
        btnPakaiPart.BackColor = Color.FromArgb(CByte(14), CByte(28), CByte(20))
        btnPakaiPart.Cursor = Cursors.Hand
        btnPakaiPart.FlatAppearance.BorderColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnPakaiPart.FlatStyle = FlatStyle.Flat
        btnPakaiPart.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnPakaiPart.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnPakaiPart.Location = New Point(523, 28)
        btnPakaiPart.Name = "btnPakaiPart"
        btnPakaiPart.Size = New Size(80, 23)
        btnPakaiPart.TabIndex = 3
        btnPakaiPart.Text = "Pakai"
        btnPakaiPart.UseVisualStyleBackColor = False
        ' 
        ' pnlLog
        ' 
        pnlLog.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        pnlLog.Controls.Add(lblLogLbl)
        pnlLog.Controls.Add(dgvLog)
        pnlLog.Dock = DockStyle.Fill
        pnlLog.Location = New Point(0, 376)
        pnlLog.Name = "pnlLog"
        pnlLog.Padding = New Padding(14, 10, 14, 0)
        pnlLog.Size = New Size(620, 298)
        pnlLog.TabIndex = 18
        ' 
        ' lblLogLbl
        ' 
        lblLogLbl.AutoSize = True
        lblLogLbl.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblLogLbl.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblLogLbl.Location = New Point(14, 10)
        lblLogLbl.Name = "lblLogLbl"
        lblLogLbl.Size = New Size(95, 13)
        lblLogLbl.TabIndex = 0
        lblLogLbl.Text = "RIWAYAT STATUS"
        ' 
        ' dgvLog
        ' 
        dgvLog.AllowUserToAddRows = False
        dgvLog.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(22), CByte(24), CByte(34))
        dgvLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvLog.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLog.BackgroundColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        dgvLog.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLog.DefaultCellStyle = DataGridViewCellStyle3
        dgvLog.EnableHeadersVisualStyles = False
        dgvLog.Font = New Font("Segoe UI", 9.0F)
        dgvLog.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvLog.Location = New Point(14, 30)
        dgvLog.Name = "dgvLog"
        dgvLog.ReadOnly = True
        dgvLog.RowHeadersVisible = False
        dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLog.Size = New Size(992, 398)
        dgvLog.TabIndex = 1
        ' 
        ' pnlStatusBar
        ' 
        pnlStatusBar.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        pnlStatusBar.Controls.Add(lblStatusBar)
        pnlStatusBar.Dock = DockStyle.Bottom
        pnlStatusBar.Location = New Point(0, 674)
        pnlStatusBar.Name = "pnlStatusBar"
        pnlStatusBar.Size = New Size(620, 26)
        pnlStatusBar.TabIndex = 22
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.AutoSize = True
        lblStatusBar.Font = New Font("Segoe UI", 8.0F)
        lblStatusBar.ForeColor = Color.FromArgb(CByte(68), CByte(85), CByte(102))
        lblStatusBar.Location = New Point(12, 6)
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(294, 13)
        lblStatusBar.TabIndex = 0
        lblStatusBar.Text = "Update status akan tercatat di log & tampil ke pelanggan"
        ' 
        ' frmDetailServis
        ' 
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        ClientSize = New Size(620, 700)
        Controls.Add(lblNoServisLbl)
        Controls.Add(lblPelangganLbl)
        Controls.Add(lblNoPolisiLbl)
        Controls.Add(lblMekanikLbl)
        Controls.Add(lblTglMasukLbl)
        Controls.Add(pnlLog)
        Controls.Add(pnlPart)
        Controls.Add(pnlUpdate)
        Controls.Add(pnlStatusBar)
        Controls.Add(pnlInfo)
        MinimumSize = New Size(500, 580)
        Name = "frmDetailServis"
        StartPosition = FormStartPosition.CenterParent
        Text = "Detail Servis"
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        pnlUpdate.ResumeLayout(False)
        pnlUpdate.PerformLayout()
        pnlPart.ResumeLayout(False)
        pnlPart.PerformLayout()
        pnlLog.ResumeLayout(False)
        pnlLog.PerformLayout()
        CType(dgvLog, ComponentModel.ISupportInitialize).EndInit()
        pnlStatusBar.ResumeLayout(False)
        pnlStatusBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblNoServisLbl As System.Windows.Forms.Label
    Friend WithEvents lblStatusLbl As System.Windows.Forms.Label
    Friend WithEvents lblPelangganLbl As System.Windows.Forms.Label
    Friend WithEvents lblNoPolisiLbl As System.Windows.Forms.Label
    Friend WithEvents lblMerkLbl As System.Windows.Forms.Label
    Friend WithEvents lblMekanikLbl As System.Windows.Forms.Label
    Friend WithEvents lblTglMasukLbl As System.Windows.Forms.Label
    Friend WithEvents lblTglSelesaiLbl As System.Windows.Forms.Label
    Friend WithEvents lblKeluhanLbl As System.Windows.Forms.Label
    Friend WithEvents pnlUpdate As System.Windows.Forms.Panel
    Friend WithEvents lblUpdateLbl As System.Windows.Forms.Label
    Friend WithEvents btnAntri As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnMenungguPart As System.Windows.Forms.Button
    Friend WithEvents btnSelesai As System.Windows.Forms.Button
    Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents pnlPart As System.Windows.Forms.Panel
    Friend WithEvents lblPartLbl As System.Windows.Forms.Label
    Friend WithEvents cboPart As System.Windows.Forms.ComboBox
    Friend WithEvents txtQtyPart As System.Windows.Forms.TextBox
    Friend WithEvents btnPakaiPart As System.Windows.Forms.Button
    Friend WithEvents pnlLog As System.Windows.Forms.Panel
    Friend WithEvents lblLogLbl As System.Windows.Forms.Label
    Friend WithEvents dgvLog As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar As System.Windows.Forms.Label
    Friend WithEvents lblKeluhan As Label
    Friend WithEvents lblPelanggan As Label
    Friend WithEvents lblTglSelesai As Label
    Friend WithEvents lblTglMasuk As Label
    Friend WithEvents lblMekanik As Label
    Friend WithEvents lblMerkMotor As Label
    Friend WithEvents lblNoPolisi As Label
    Friend WithEvents lblStatusAktif As Label
    Friend WithEvents lblNoServis As Label

End Class
