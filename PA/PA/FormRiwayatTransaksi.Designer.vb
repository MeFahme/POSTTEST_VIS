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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlBody = New Panel()
        pnlDetail = New Panel()
        lblDetNoTrx = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        pnlServiceInfo = New Panel()
        DataGridView1 = New DataGridView()
        pnlToolbar = New Panel()
        btnHariIni = New Guna.UI2.WinForms.Guna2Button()
        btnTampilkan = New Guna.UI2.WinForms.Guna2Button()
        dtpSampai = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpDari = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        lblDetStatus = New Label()
        lblDetPelanggan = New Label()
        lblDetNoHp = New Label()
        lblDetJenis = New Label()
        lblDetWaktu = New Label()
        lblDetTotal = New Label()
        Label11 = New Label()
        dgvDetail = New DataGridView()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        lblDetServis = New Label()
        lblDetBiayaJasa = New Label()
        lblDetStatusMotor = New Label()
        lblStatusBar = New Label()
        pnlBody.SuspendLayout()
        pnlDetail.SuspendLayout()
        pnlServiceInfo.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlToolbar.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlBody
        ' 
        pnlBody.Controls.Add(pnlDetail)
        pnlBody.Controls.Add(DataGridView1)
        pnlBody.Location = New Point(0, 46)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(1020, 629)
        pnlBody.TabIndex = 0
        ' 
        ' pnlDetail
        ' 
        pnlDetail.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        pnlDetail.Controls.Add(Label12)
        pnlDetail.Controls.Add(dgvDetail)
        pnlDetail.Controls.Add(Label11)
        pnlDetail.Controls.Add(lblDetTotal)
        pnlDetail.Controls.Add(lblDetWaktu)
        pnlDetail.Controls.Add(lblDetJenis)
        pnlDetail.Controls.Add(lblDetNoHp)
        pnlDetail.Controls.Add(lblDetPelanggan)
        pnlDetail.Controls.Add(lblDetStatus)
        pnlDetail.Controls.Add(lblDetNoTrx)
        pnlDetail.Controls.Add(Label9)
        pnlDetail.Controls.Add(Label8)
        pnlDetail.Controls.Add(Label7)
        pnlDetail.Controls.Add(Label6)
        pnlDetail.Controls.Add(Label5)
        pnlDetail.Controls.Add(Label4)
        pnlDetail.Controls.Add(Label3)
        pnlDetail.Controls.Add(pnlServiceInfo)
        pnlDetail.Location = New Point(720, 0)
        pnlDetail.Name = "pnlDetail"
        pnlDetail.Size = New Size(300, 629)
        pnlDetail.TabIndex = 1
        ' 
        ' lblDetNoTrx
        ' 
        lblDetNoTrx.AutoSize = True
        lblDetNoTrx.BackColor = Color.Transparent
        lblDetNoTrx.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetNoTrx.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetNoTrx.Location = New Point(7, 53)
        lblDetNoTrx.Name = "lblDetNoTrx"
        lblDetNoTrx.Size = New Size(12, 15)
        lblDetNoTrx.TabIndex = 20
        lblDetNoTrx.Text = "-"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGray
        Label9.Location = New Point(5, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 15)
        Label9.TabIndex = 18
        Label9.Text = "STATUS BAYAR"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGray
        Label8.Location = New Point(5, 203)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 15)
        Label8.TabIndex = 17
        Label8.Text = "WAKTU"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGray
        Label7.Location = New Point(5, 160)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 16
        Label7.Text = "JENIS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGray
        Label6.Location = New Point(5, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 15
        Label6.Text = "NO. HP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGray
        Label5.Location = New Point(5, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 14
        Label5.Text = "PELANGGAN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGray
        Label4.Location = New Point(5, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 13
        Label4.Text = "NO. TRANSAKSI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(3, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 21)
        Label3.TabIndex = 3
        Label3.Text = "Detail Transaksi"
        ' 
        ' pnlServiceInfo
        ' 
        pnlServiceInfo.Controls.Add(lblDetStatusMotor)
        pnlServiceInfo.Controls.Add(lblDetBiayaJasa)
        pnlServiceInfo.Controls.Add(lblDetServis)
        pnlServiceInfo.Controls.Add(Label15)
        pnlServiceInfo.Controls.Add(Label14)
        pnlServiceInfo.Controls.Add(Label13)
        pnlServiceInfo.Location = New Point(0, 445)
        pnlServiceInfo.Name = "pnlServiceInfo"
        pnlServiceInfo.Size = New Size(300, 128)
        pnlServiceInfo.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(720, 629)
        DataGridView1.TabIndex = 0
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
        pnlToolbar.Location = New Point(0, 0)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1020, 46)
        pnlToolbar.TabIndex = 1
        ' 
        ' btnHariIni
        ' 
        btnHariIni.BorderColor = Color.DimGray
        btnHariIni.BorderRadius = 5
        btnHariIni.BorderThickness = 1
        btnHariIni.CustomizableEdges = CustomizableEdges9
        btnHariIni.DisabledState.BorderColor = Color.DarkGray
        btnHariIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnHariIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHariIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHariIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnHariIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHariIni.ForeColor = Color.White
        btnHariIni.Location = New Point(452, 6)
        btnHariIni.Name = "btnHariIni"
        btnHariIni.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnHariIni.Size = New Size(94, 34)
        btnHariIni.TabIndex = 12
        btnHariIni.Text = "Hari Ini"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BorderRadius = 5
        btnTampilkan.CustomizableEdges = CustomizableEdges11
        btnTampilkan.DisabledState.BorderColor = Color.DarkGray
        btnTampilkan.DisabledState.CustomBorderColor = Color.DarkGray
        btnTampilkan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTampilkan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTampilkan.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnTampilkan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(339, 6)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnTampilkan.Size = New Size(94, 34)
        btnTampilkan.TabIndex = 11
        btnTampilkan.Text = "Tampilkan"
        ' 
        ' dtpSampai
        ' 
        dtpSampai.BorderRadius = 5
        dtpSampai.Checked = True
        dtpSampai.CustomizableEdges = CustomizableEdges13
        dtpSampai.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpSampai.Font = New Font("Segoe UI", 9F)
        dtpSampai.ForeColor = Color.LightGray
        dtpSampai.Format = DateTimePickerFormat.Short
        dtpSampai.Location = New Point(201, 6)
        dtpSampai.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpSampai.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpSampai.Name = "dtpSampai"
        dtpSampai.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        dtpSampai.Size = New Size(121, 34)
        dtpSampai.TabIndex = 10
        dtpSampai.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' dtpDari
        ' 
        dtpDari.BorderRadius = 5
        dtpDari.Checked = True
        dtpDari.CustomizableEdges = CustomizableEdges15
        dtpDari.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpDari.Font = New Font("Segoe UI", 9F)
        dtpDari.ForeColor = Color.LightGray
        dtpDari.Format = DateTimePickerFormat.Short
        dtpDari.Location = New Point(44, 6)
        dtpDari.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDari.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDari.Name = "dtpDari"
        dtpDari.ShadowDecoration.CustomizableEdges = CustomizableEdges16
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
        Panel3.Location = New Point(0, 673)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1020, 26)
        Panel3.TabIndex = 2
        ' 
        ' lblDetStatus
        ' 
        lblDetStatus.AutoSize = True
        lblDetStatus.BackColor = Color.Transparent
        lblDetStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetStatus.ForeColor = Color.Lime
        lblDetStatus.Location = New Point(5, 262)
        lblDetStatus.Name = "lblDetStatus"
        lblDetStatus.Size = New Size(12, 15)
        lblDetStatus.TabIndex = 21
        lblDetStatus.Text = "-"
        ' 
        ' lblDetPelanggan
        ' 
        lblDetPelanggan.AutoSize = True
        lblDetPelanggan.BackColor = Color.Transparent
        lblDetPelanggan.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetPelanggan.ForeColor = Color.White
        lblDetPelanggan.Location = New Point(5, 94)
        lblDetPelanggan.Name = "lblDetPelanggan"
        lblDetPelanggan.Size = New Size(12, 15)
        lblDetPelanggan.TabIndex = 22
        lblDetPelanggan.Text = "-"
        ' 
        ' lblDetNoHp
        ' 
        lblDetNoHp.AutoSize = True
        lblDetNoHp.BackColor = Color.Transparent
        lblDetNoHp.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetNoHp.ForeColor = Color.White
        lblDetNoHp.Location = New Point(5, 135)
        lblDetNoHp.Name = "lblDetNoHp"
        lblDetNoHp.Size = New Size(12, 15)
        lblDetNoHp.TabIndex = 23
        lblDetNoHp.Text = "-"
        ' 
        ' lblDetJenis
        ' 
        lblDetJenis.AutoSize = True
        lblDetJenis.BackColor = Color.Transparent
        lblDetJenis.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetJenis.ForeColor = Color.White
        lblDetJenis.Location = New Point(4, 178)
        lblDetJenis.Name = "lblDetJenis"
        lblDetJenis.Size = New Size(12, 15)
        lblDetJenis.TabIndex = 24
        lblDetJenis.Text = "-"
        ' 
        ' lblDetWaktu
        ' 
        lblDetWaktu.AutoSize = True
        lblDetWaktu.BackColor = Color.Transparent
        lblDetWaktu.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetWaktu.ForeColor = Color.White
        lblDetWaktu.Location = New Point(6, 220)
        lblDetWaktu.Name = "lblDetWaktu"
        lblDetWaktu.Size = New Size(12, 15)
        lblDetWaktu.TabIndex = 25
        lblDetWaktu.Text = "-"
        ' 
        ' lblDetTotal
        ' 
        lblDetTotal.AutoSize = True
        lblDetTotal.BackColor = Color.Transparent
        lblDetTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetTotal.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetTotal.Location = New Point(5, 597)
        lblDetTotal.Name = "lblDetTotal"
        lblDetTotal.Size = New Size(40, 21)
        lblDetTotal.TabIndex = 26
        lblDetTotal.Text = "Rp -"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGray
        Label11.Location = New Point(5, 286)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 15)
        Label11.TabIndex = 27
        Label11.Text = "DAFTAR PART"
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
        dgvDetail.GridColor = Color.FromArgb(CByte(30), CByte(33), CByte(48))
        dgvDetail.Location = New Point(7, 304)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.Size = New Size(287, 135)
        dgvDetail.TabIndex = 28
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.ForeColor = Color.DarkGray
        Label12.Location = New Point(7, 582)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 15)
        Label12.TabIndex = 29
        Label12.Text = "TOTAL BAYAR"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label13.ForeColor = Color.DarkGray
        Label13.Location = New Point(7, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 15)
        Label13.TabIndex = 30
        Label13.Text = "MOTOR"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label14.ForeColor = Color.DarkGray
        Label14.Location = New Point(7, 62)
        Label14.Name = "Label14"
        Label14.Size = New Size(71, 15)
        Label14.TabIndex = 31
        Label14.Text = "BIAYA JASA"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label15.ForeColor = Color.DarkGray
        Label15.Location = New Point(7, 99)
        Label15.Name = "Label15"
        Label15.Size = New Size(93, 15)
        Label15.TabIndex = 32
        Label15.Text = "STATUS SERVIS"
        ' 
        ' lblDetServis
        ' 
        lblDetServis.AutoSize = True
        lblDetServis.BackColor = Color.Transparent
        lblDetServis.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetServis.ForeColor = Color.White
        lblDetServis.Location = New Point(9, 35)
        lblDetServis.Name = "lblDetServis"
        lblDetServis.Size = New Size(12, 15)
        lblDetServis.TabIndex = 30
        lblDetServis.Text = "-"
        ' 
        ' lblDetBiayaJasa
        ' 
        lblDetBiayaJasa.AutoSize = True
        lblDetBiayaJasa.BackColor = Color.Transparent
        lblDetBiayaJasa.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetBiayaJasa.ForeColor = Color.White
        lblDetBiayaJasa.Location = New Point(146, 63)
        lblDetBiayaJasa.Name = "lblDetBiayaJasa"
        lblDetBiayaJasa.Size = New Size(12, 15)
        lblDetBiayaJasa.TabIndex = 33
        lblDetBiayaJasa.Text = "-"
        ' 
        ' lblDetStatusMotor
        ' 
        lblDetStatusMotor.AutoSize = True
        lblDetStatusMotor.BackColor = Color.Transparent
        lblDetStatusMotor.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetStatusMotor.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDetStatusMotor.Location = New Point(146, 100)
        lblDetStatusMotor.Name = "lblDetStatusMotor"
        lblDetStatusMotor.Size = New Size(12, 15)
        lblDetStatusMotor.TabIndex = 34
        lblDetStatusMotor.Text = "-"
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
        ' FormRiwayatTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        ClientSize = New Size(1020, 700)
        Controls.Add(Panel3)
        Controls.Add(pnlToolbar)
        Controls.Add(pnlBody)
        Name = "FormRiwayatTransaksi"
        Text = "FormRiwayatTransaksi"
        pnlBody.ResumeLayout(False)
        pnlDetail.ResumeLayout(False)
        pnlDetail.PerformLayout()
        pnlServiceInfo.ResumeLayout(False)
        pnlServiceInfo.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents pnlServiceInfo As Panel
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
    Friend WithEvents lblDetTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDetStatusMotor As Label
    Friend WithEvents lblDetBiayaJasa As Label
    Friend WithEvents lblDetServis As Label
    Friend WithEvents lblStatusBar As Label
End Class
