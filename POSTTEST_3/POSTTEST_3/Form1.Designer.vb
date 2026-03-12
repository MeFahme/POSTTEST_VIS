<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfil = New PictureBox()
        btnGambar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        cbBertapa = New CheckBox()
        cbMenempa = New CheckBox()
        cbGame = New CheckBox()
        cbBerkebun = New CheckBox()
        cbMendaki = New CheckBox()
        cbBerburu = New CheckBox()
        cbMancing = New CheckBox()
        cbRenang = New CheckBox()
        cbBaca = New CheckBox()
        cbMasak = New CheckBox()
        cbNulis = New CheckBox()
        cbLukis = New CheckBox()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpLahir = New DateTimePicker()
        rbCowo = New RadioButton()
        GroupBox1 = New GroupBox()
        rbCewe = New RadioButton()
        PictureBox2 = New PictureBox()
        btnCetak = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        PictureBox1 = New PictureBox()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.BurlyWood
        picProfil.Image = My.Resources.Resources.child
        picProfil.Location = New Point(68, 102)
        picProfil.Margin = New Padding(3, 4, 3, 4)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(212, 364)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnGambar
        ' 
        btnGambar.BackColor = Color.SandyBrown
        btnGambar.FlatAppearance.BorderColor = Color.Peru
        btnGambar.FlatAppearance.BorderSize = 2
        btnGambar.FlatStyle = FlatStyle.Flat
        btnGambar.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGambar.Location = New Point(68, 476)
        btnGambar.Margin = New Padding(3, 4, 3, 4)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(212, 28)
        btnGambar.TabIndex = 1
        btnGambar.Text = "Browse"
        btnGambar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(304, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 18)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(304, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 18)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(304, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 18)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(411, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 18)
        Label4.TabIndex = 5
        Label4.Text = "No Telpon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(304, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 18)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.BurlyWood
        GroupBox2.Controls.Add(cbBertapa)
        GroupBox2.Controls.Add(cbMenempa)
        GroupBox2.Controls.Add(cbGame)
        GroupBox2.Controls.Add(cbBerkebun)
        GroupBox2.Controls.Add(cbMendaki)
        GroupBox2.Controls.Add(cbBerburu)
        GroupBox2.Controls.Add(cbMancing)
        GroupBox2.Controls.Add(cbRenang)
        GroupBox2.Controls.Add(cbBaca)
        GroupBox2.Controls.Add(cbMasak)
        GroupBox2.Controls.Add(cbNulis)
        GroupBox2.Controls.Add(cbLukis)
        GroupBox2.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(495, 335)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(366, 130)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' cbBertapa
        ' 
        cbBertapa.AutoSize = True
        cbBertapa.Location = New Point(266, 31)
        cbBertapa.Margin = New Padding(3, 4, 3, 4)
        cbBertapa.Name = "cbBertapa"
        cbBertapa.Size = New Size(70, 22)
        cbBertapa.TabIndex = 11
        cbBertapa.Text = "Bertapa"
        cbBertapa.UseVisualStyleBackColor = True
        ' 
        ' cbMenempa
        ' 
        cbMenempa.AutoSize = True
        cbMenempa.Location = New Point(266, 90)
        cbMenempa.Margin = New Padding(3, 4, 3, 4)
        cbMenempa.Name = "cbMenempa"
        cbMenempa.Size = New Size(81, 22)
        cbMenempa.TabIndex = 10
        cbMenempa.Text = "Menempa"
        cbMenempa.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(266, 60)
        cbGame.Margin = New Padding(3, 4, 3, 4)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(68, 22)
        cbGame.TabIndex = 9
        cbGame.Text = "Gaming"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' cbBerkebun
        ' 
        cbBerkebun.AutoSize = True
        cbBerkebun.Location = New Point(180, 60)
        cbBerkebun.Margin = New Padding(3, 4, 3, 4)
        cbBerkebun.Name = "cbBerkebun"
        cbBerkebun.Size = New Size(81, 22)
        cbBerkebun.TabIndex = 8
        cbBerkebun.Text = "Berkebun"
        cbBerkebun.UseVisualStyleBackColor = True
        ' 
        ' cbMendaki
        ' 
        cbMendaki.AutoSize = True
        cbMendaki.Location = New Point(180, 90)
        cbMendaki.Margin = New Padding(3, 4, 3, 4)
        cbMendaki.Name = "cbMendaki"
        cbMendaki.Size = New Size(75, 22)
        cbMendaki.TabIndex = 7
        cbMendaki.Text = "Mendaki"
        cbMendaki.UseVisualStyleBackColor = True
        ' 
        ' cbBerburu
        ' 
        cbBerburu.AutoSize = True
        cbBerburu.Location = New Point(180, 31)
        cbBerburu.Margin = New Padding(3, 4, 3, 4)
        cbBerburu.Name = "cbBerburu"
        cbBerburu.Size = New Size(72, 22)
        cbBerburu.TabIndex = 6
        cbBerburu.Text = "Berburu"
        cbBerburu.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(86, 31)
        cbMancing.Margin = New Padding(3, 4, 3, 4)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(90, 22)
        cbMancing.TabIndex = 5
        cbMancing.Text = "Memancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbRenang
        ' 
        cbRenang.AutoSize = True
        cbRenang.Location = New Point(86, 91)
        cbRenang.Margin = New Padding(3, 4, 3, 4)
        cbRenang.Name = "cbRenang"
        cbRenang.Size = New Size(79, 22)
        cbRenang.TabIndex = 4
        cbRenang.Text = "Berenang"
        cbRenang.UseVisualStyleBackColor = True
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.Location = New Point(86, 60)
        cbBaca.Margin = New Padding(3, 4, 3, 4)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(79, 22)
        cbBaca.TabIndex = 3
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = True
        ' 
        ' cbMasak
        ' 
        cbMasak.AutoSize = True
        cbMasak.FlatAppearance.BorderSize = 0
        cbMasak.FlatAppearance.CheckedBackColor = Color.Lime
        cbMasak.Location = New Point(6, 31)
        cbMasak.Margin = New Padding(3, 4, 3, 4)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(78, 22)
        cbMasak.TabIndex = 2
        cbMasak.Text = "Memasak"
        cbMasak.UseVisualStyleBackColor = True
        ' 
        ' cbNulis
        ' 
        cbNulis.AutoSize = True
        cbNulis.Location = New Point(6, 90)
        cbNulis.Margin = New Padding(3, 4, 3, 4)
        cbNulis.Name = "cbNulis"
        cbNulis.Size = New Size(71, 22)
        cbNulis.TabIndex = 1
        cbNulis.Text = "Menulis"
        cbNulis.UseVisualStyleBackColor = True
        ' 
        ' cbLukis
        ' 
        cbLukis.AutoSize = True
        cbLukis.Location = New Point(6, 60)
        cbLukis.Margin = New Padding(3, 4, 3, 4)
        cbLukis.Name = "cbLukis"
        cbLukis.Size = New Size(71, 22)
        cbLukis.TabIndex = 0
        cbLukis.Text = "Melukis"
        cbLukis.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.BurlyWood
        txtNama.BorderStyle = BorderStyle.None
        txtNama.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(304, 122)
        txtNama.Margin = New Padding(5, 4, 3, 4)
        txtNama.MaxLength = 30
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(298, 14)
        txtNama.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.BurlyWood
        txtUmur.BorderStyle = BorderStyle.None
        txtUmur.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUmur.Location = New Point(304, 169)
        txtUmur.Margin = New Padding(3, 4, 3, 4)
        txtUmur.MaxLength = 3
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(101, 14)
        txtUmur.TabIndex = 10
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.BackColor = Color.BurlyWood
        txtNoTelp.BorderStyle = BorderStyle.None
        txtNoTelp.Location = New Point(411, 169)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.MaxLength = 13
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(191, 14)
        txtNoTelp.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtAlamat.BackColor = Color.BurlyWood
        txtAlamat.BorderStyle = BorderStyle.None
        txtAlamat.Location = New Point(2, 3)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.MaxLength = 20
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(298, 51)
        txtAlamat.TabIndex = 12
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dtpLahir.CalendarMonthBackground = Color.BurlyWood
        dtpLahir.Location = New Point(304, 216)
        dtpLahir.Margin = New Padding(3, 4, 3, 4)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(268, 21)
        dtpLahir.TabIndex = 13
        ' 
        ' rbCowo
        ' 
        rbCowo.Appearance = Appearance.Button
        rbCowo.BackColor = Color.Transparent
        rbCowo.BackgroundImage = CType(resources.GetObject("rbCowo.BackgroundImage"), Image)
        rbCowo.BackgroundImageLayout = ImageLayout.Zoom
        rbCowo.FlatAppearance.BorderColor = Color.White
        rbCowo.FlatAppearance.BorderSize = 0
        rbCowo.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        rbCowo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        rbCowo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        rbCowo.FlatStyle = FlatStyle.Flat
        rbCowo.Font = New Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbCowo.ForeColor = Color.BurlyWood
        rbCowo.Location = New Point(14, 22)
        rbCowo.Margin = New Padding(3, 4, 3, 4)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(68, 92)
        rbCowo.TabIndex = 6
        rbCowo.TabStop = True
        rbCowo.Text = "Pria"
        rbCowo.TextAlign = ContentAlignment.BottomCenter
        rbCowo.TextImageRelation = TextImageRelation.ImageAboveText
        rbCowo.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.BurlyWood
        GroupBox1.Controls.Add(rbCewe)
        GroupBox1.Controls.Add(rbCowo)
        GroupBox1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(304, 334)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(175, 130)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbCewe
        ' 
        rbCewe.Appearance = Appearance.Button
        rbCewe.BackColor = Color.Transparent
        rbCewe.BackgroundImage = CType(resources.GetObject("rbCewe.BackgroundImage"), Image)
        rbCewe.BackgroundImageLayout = ImageLayout.Zoom
        rbCewe.FlatAppearance.BorderColor = Color.White
        rbCewe.FlatAppearance.BorderSize = 0
        rbCewe.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        rbCewe.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        rbCewe.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        rbCewe.FlatStyle = FlatStyle.Flat
        rbCewe.Font = New Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCewe.ForeColor = Color.BurlyWood
        rbCewe.Location = New Point(88, 22)
        rbCewe.Margin = New Padding(3, 4, 3, 4)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(68, 92)
        rbCewe.TabIndex = 7
        rbCewe.TabStop = True
        rbCewe.Text = "Wanita"
        rbCewe.TextAlign = ContentAlignment.BottomCenter
        rbCewe.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.BurlyWood
        PictureBox2.Image = My.Resources.Resources.weapons
        PictureBox2.Location = New Point(626, 100)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(235, 215)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.SandyBrown
        btnCetak.FlatAppearance.BorderColor = Color.Peru
        btnCetak.FlatAppearance.BorderSize = 2
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(304, 474)
        btnCetak.Margin = New Padding(3, 4, 3, 4)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(557, 28)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.Location = New Point(302, 120)
        Panel1.Margin = New Padding(1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(302, 18)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Peru
        Panel2.Location = New Point(409, 167)
        Panel2.Margin = New Padding(1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(195, 18)
        Panel2.TabIndex = 17
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Peru
        Panel3.Location = New Point(302, 167)
        Panel3.Margin = New Padding(1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(105, 18)
        Panel3.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Peru
        Panel4.Controls.Add(txtAlamat)
        Panel4.Location = New Point(302, 259)
        Panel4.Margin = New Padding(1)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(302, 56)
        Panel4.TabIndex = 19
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Peru
        Panel5.Location = New Point(66, 100)
        Panel5.Margin = New Padding(1)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(216, 368)
        Panel5.TabIndex = 17
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Peru
        Panel6.Location = New Point(624, 98)
        Panel6.Margin = New Padding(1)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(239, 219)
        Panel6.TabIndex = 18
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Adventurer_Form
        PictureBox1.Location = New Point(-7, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(958, 573)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tan
        ClientSize = New Size(943, 569)
        Controls.Add(btnCetak)
        Controls.Add(dtpLahir)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGambar)
        Controls.Add(picProfil)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel6)
        Controls.Add(PictureBox1)
        Font = New Font("Trebuchet MS", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Adventurer Form"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnGambar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbBertapa As CheckBox
    Friend WithEvents cbMenempa As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents cbMendaki As CheckBox
    Friend WithEvents cbBerburu As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbRenang As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents cbNulis As CheckBox
    Friend WithEvents cbLukis As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox

End Class
