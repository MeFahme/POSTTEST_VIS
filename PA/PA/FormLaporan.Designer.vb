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
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges29 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges30 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        btnBulanIni = New Guna.UI2.WinForms.Guna2Button()
        btnHariIni = New Guna.UI2.WinForms.Guna2Button()
        btnTampilkan = New Guna.UI2.WinForms.Guna2Button()
        dtpSampai = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpDari = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        tabLaporan = New Guna.UI2.WinForms.Guna2TabControl()
        tabPenjualan = New TabPage()
        pnlKartu = New Panel()
        Panel8 = New Panel()
        Label8 = New Label()
        lblTotalBelum = New Label()
        Panel9 = New Panel()
        Panel6 = New Panel()
        Label6 = New Label()
        lblTotalLunas = New Label()
        Panel7 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        lblTotalOmzet = New Label()
        Panel5 = New Panel()
        pnlTrx = New Panel()
        Label4 = New Label()
        lblTotalTrx = New Label()
        Panel4 = New Panel()
        tabStok = New TabPage()
        DataGridView2 = New DataGridView()
        dgvLaporan = New DataGridView()
        Panel1.SuspendLayout()
        tabLaporan.SuspendLayout()
        tabPenjualan.SuspendLayout()
        pnlKartu.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        pnlTrx.SuspendLayout()
        tabStok.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 56)
        Panel1.TabIndex = 0
        ' 
        ' btnBulanIni
        ' 
        btnBulanIni.BorderColor = Color.DimGray
        btnBulanIni.BorderRadius = 5
        btnBulanIni.BorderThickness = 1
        btnBulanIni.CustomizableEdges = CustomizableEdges21
        btnBulanIni.DisabledState.BorderColor = Color.DarkGray
        btnBulanIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnBulanIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBulanIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBulanIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnBulanIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBulanIni.ForeColor = Color.White
        btnBulanIni.Location = New Point(574, 9)
        btnBulanIni.Name = "btnBulanIni"
        btnBulanIni.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnBulanIni.Size = New Size(94, 34)
        btnBulanIni.TabIndex = 6
        btnBulanIni.Text = "Bulan Ini"
        ' 
        ' btnHariIni
        ' 
        btnHariIni.BorderColor = Color.DimGray
        btnHariIni.BorderRadius = 5
        btnHariIni.BorderThickness = 1
        btnHariIni.CustomizableEdges = CustomizableEdges23
        btnHariIni.DisabledState.BorderColor = Color.DarkGray
        btnHariIni.DisabledState.CustomBorderColor = Color.DarkGray
        btnHariIni.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHariIni.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHariIni.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(50))
        btnHariIni.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHariIni.ForeColor = Color.White
        btnHariIni.Location = New Point(461, 9)
        btnHariIni.Name = "btnHariIni"
        btnHariIni.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        btnHariIni.Size = New Size(94, 34)
        btnHariIni.TabIndex = 5
        btnHariIni.Text = "Hari Ini"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BorderRadius = 5
        btnTampilkan.CustomizableEdges = CustomizableEdges25
        btnTampilkan.DisabledState.BorderColor = Color.DarkGray
        btnTampilkan.DisabledState.CustomBorderColor = Color.DarkGray
        btnTampilkan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTampilkan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTampilkan.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnTampilkan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = Color.White
        btnTampilkan.Location = New Point(348, 9)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        btnTampilkan.Size = New Size(94, 34)
        btnTampilkan.TabIndex = 4
        btnTampilkan.Text = "Tampilkan"
        ' 
        ' dtpSampai
        ' 
        dtpSampai.BorderRadius = 5
        dtpSampai.Checked = True
        dtpSampai.CustomizableEdges = CustomizableEdges27
        dtpSampai.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpSampai.Font = New Font("Segoe UI", 9F)
        dtpSampai.ForeColor = Color.LightGray
        dtpSampai.Format = DateTimePickerFormat.Short
        dtpSampai.Location = New Point(210, 9)
        dtpSampai.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpSampai.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpSampai.Name = "dtpSampai"
        dtpSampai.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        dtpSampai.Size = New Size(121, 34)
        dtpSampai.TabIndex = 3
        dtpSampai.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
        ' 
        ' dtpDari
        ' 
        dtpDari.BorderRadius = 5
        dtpDari.Checked = True
        dtpDari.CustomizableEdges = CustomizableEdges29
        dtpDari.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        dtpDari.Font = New Font("Segoe UI", 9F)
        dtpDari.ForeColor = Color.LightGray
        dtpDari.Format = DateTimePickerFormat.Short
        dtpDari.Location = New Point(53, 9)
        dtpDari.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDari.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDari.Name = "dtpDari"
        dtpDari.ShadowDecoration.CustomizableEdges = CustomizableEdges30
        dtpDari.Size = New Size(121, 34)
        dtpDari.TabIndex = 2
        dtpDari.Value = New Date(2026, 5, 12, 13, 8, 27, 868)
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
        ' tabLaporan
        ' 
        tabLaporan.Controls.Add(tabPenjualan)
        tabLaporan.Controls.Add(tabStok)
        tabLaporan.ItemSize = New Size(180, 40)
        tabLaporan.Location = New Point(1, 55)
        tabLaporan.Name = "tabLaporan"
        tabLaporan.SelectedIndex = 0
        tabLaporan.Size = New Size(999, 477)
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
        tabPenjualan.Controls.Add(pnlKartu)
        tabPenjualan.Location = New Point(4, 44)
        tabPenjualan.Name = "tabPenjualan"
        tabPenjualan.Padding = New Padding(3)
        tabPenjualan.Size = New Size(991, 429)
        tabPenjualan.TabIndex = 0
        tabPenjualan.Text = "Laporan Penjualan"
        tabPenjualan.UseVisualStyleBackColor = True
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlKartu.Controls.Add(Panel8)
        pnlKartu.Controls.Add(Panel9)
        pnlKartu.Controls.Add(Panel6)
        pnlKartu.Controls.Add(Panel7)
        pnlKartu.Controls.Add(Panel3)
        pnlKartu.Controls.Add(Panel5)
        pnlKartu.Controls.Add(pnlTrx)
        pnlKartu.Controls.Add(Panel4)
        pnlKartu.Location = New Point(1, 1)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(991, 101)
        pnlKartu.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel8.Controls.Add(Label8)
        Panel8.Controls.Add(lblTotalBelum)
        Panel8.Location = New Point(773, 6)
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
        Panel9.Location = New Point(972, 6)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 86)
        Panel9.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(lblTotalLunas)
        Panel6.Location = New Point(517, 6)
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
        Panel7.Location = New Point(716, 6)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 86)
        Panel7.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(lblTotalOmzet)
        Panel3.Location = New Point(258, 6)
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
        ' Panel5
        ' 
        Panel5.BackColor = Color.Lime
        Panel5.Location = New Point(457, 6)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 86)
        Panel5.TabIndex = 4
        ' 
        ' pnlTrx
        ' 
        pnlTrx.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        pnlTrx.Controls.Add(Label4)
        pnlTrx.Controls.Add(lblTotalTrx)
        pnlTrx.Location = New Point(8, 6)
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
        Label4.Size = New Size(115, 17)
        Label4.TabIndex = 1
        Label4.Text = "Transaksi Hari Ini"
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
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel4.Location = New Point(207, 6)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 86)
        Panel4.TabIndex = 2
        ' 
        ' tabStok
        ' 
        tabStok.Controls.Add(DataGridView2)
        tabStok.Location = New Point(4, 44)
        tabStok.Name = "tabStok"
        tabStok.Padding = New Padding(3)
        tabStok.Size = New Size(991, 429)
        tabStok.TabIndex = 1
        tabStok.Text = "Laporan Stok"
        tabStok.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(0, 0)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(991, 433)
        DataGridView2.TabIndex = 1
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.BackgroundColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaporan.Location = New Point(6, 198)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.ReadOnly = True
        dgvLaporan.RowHeadersVisible = False
        dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLaporan.Size = New Size(990, 331)
        dgvLaporan.TabIndex = 0
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 532)
        Controls.Add(dgvLaporan)
        Controls.Add(tabLaporan)
        Controls.Add(Panel1)
        Name = "FormLaporan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLaporan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        tabLaporan.ResumeLayout(False)
        tabPenjualan.ResumeLayout(False)
        pnlKartu.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        pnlTrx.ResumeLayout(False)
        pnlTrx.PerformLayout()
        tabStok.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDari As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpSampai As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnTampilkan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHariIni As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBulanIni As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tabLaporan As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabPenjualan As TabPage
    Friend WithEvents tabStok As TabPage
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
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
End Class
