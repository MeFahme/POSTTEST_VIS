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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        menuInputData = New ToolStripMenuItem()
        menuLihatKartu = New ToolStripMenuItem()
        menuSimpanData = New ToolStripMenuItem()
        menuBukaData = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        tpProfil = New TabPage()
        btnGambar = New Button()
        Button6 = New Button()
        GroupBox2 = New GroupBox()
        cbBeekeeping = New CheckBox()
        cbDiving = New CheckBox()
        cbHiking = New CheckBox()
        cbMemasak = New CheckBox()
        cbForaging = New CheckBox()
        cbPlogging = New CheckBox()
        cbFotografi = New CheckBox()
        cbBerkebun = New CheckBox()
        cbBertani = New CheckBox()
        btnSimpan = New Button()
        picProfil = New PictureBox()
        tpKontakInfo = New TabPage()
        Button5 = New Button()
        mtbNoHp = New MaskedTextBox()
        Button3 = New Button()
        tbAlamat = New TextBox()
        tbEmail = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        tpDataUtama = New TabPage()
        Label10 = New Label()
        tbUmur = New TextBox()
        tbIdAnggota = New TextBox()
        tbNama = New TextBox()
        btnSelanjutnya = New Button()
        GroupBox1 = New GroupBox()
        rbCowo = New RadioButton()
        rbCewe = New RadioButton()
        cboJenisKomunitas = New ComboBox()
        dtpLahir = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        TabControl1 = New TabControl()
        PictureBox16 = New PictureBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        tpProfil.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        tpKontakInfo.SuspendLayout()
        tpDataUtama.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.SeaGreen
        MenuStrip1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInputData, menuLihatKartu, menuSimpanData, menuBukaData, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(584, 25)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuInputData
        ' 
        menuInputData.BackColor = Color.SeaGreen
        menuInputData.ForeColor = SystemColors.ButtonFace
        menuInputData.Name = "menuInputData"
        menuInputData.Size = New Size(86, 21)
        menuInputData.Text = "Input Data"
        ' 
        ' menuLihatKartu
        ' 
        menuLihatKartu.ForeColor = SystemColors.ButtonFace
        menuLihatKartu.Name = "menuLihatKartu"
        menuLihatKartu.Size = New Size(88, 21)
        menuLihatKartu.Text = "Lihat Kartu"
        ' 
        ' menuSimpanData
        ' 
        menuSimpanData.ForeColor = SystemColors.ButtonFace
        menuSimpanData.Name = "menuSimpanData"
        menuSimpanData.Size = New Size(99, 21)
        menuSimpanData.Text = "Simpan Data"
        ' 
        ' menuBukaData
        ' 
        menuBukaData.ForeColor = SystemColors.ButtonFace
        menuBukaData.Name = "menuBukaData"
        menuBukaData.Size = New Size(83, 21)
        menuBukaData.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.ForeColor = SystemColors.ButtonFace
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(59, 21)
        menuKeluar.Text = "Keluar"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' tpProfil
        ' 
        tpProfil.BackColor = Color.SeaGreen
        tpProfil.Controls.Add(btnGambar)
        tpProfil.Controls.Add(Button6)
        tpProfil.Controls.Add(GroupBox2)
        tpProfil.Controls.Add(btnSimpan)
        tpProfil.Controls.Add(picProfil)
        tpProfil.Location = New Point(4, 29)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(553, 195)
        tpProfil.TabIndex = 2
        tpProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnGambar
        ' 
        btnGambar.BackColor = Color.RoyalBlue
        btnGambar.FlatStyle = FlatStyle.Flat
        btnGambar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGambar.ForeColor = SystemColors.ButtonHighlight
        btnGambar.Location = New Point(12, 156)
        btnGambar.Name = "btnGambar"
        btnGambar.Size = New Size(112, 30)
        btnGambar.TabIndex = 19
        btnGambar.Text = "Browse"
        btnGambar.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Crimson
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(291, 156)
        Button6.Name = "Button6"
        Button6.Size = New Size(98, 30)
        Button6.TabIndex = 18
        Button6.Text = "Kembali"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbBeekeeping)
        GroupBox2.Controls.Add(cbDiving)
        GroupBox2.Controls.Add(cbHiking)
        GroupBox2.Controls.Add(cbMemasak)
        GroupBox2.Controls.Add(cbForaging)
        GroupBox2.Controls.Add(cbPlogging)
        GroupBox2.Controls.Add(cbFotografi)
        GroupBox2.Controls.Add(cbBerkebun)
        GroupBox2.Controls.Add(cbBertani)
        GroupBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(137, 19)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(395, 131)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobi"
        ' 
        ' cbBeekeeping
        ' 
        cbBeekeeping.AutoSize = True
        cbBeekeeping.Location = New Point(273, 91)
        cbBeekeeping.Name = "cbBeekeeping"
        cbBeekeeping.Size = New Size(98, 21)
        cbBeekeeping.TabIndex = 9
        cbBeekeeping.Text = "Beekeeping"
        cbBeekeeping.UseVisualStyleBackColor = True
        ' 
        ' cbDiving
        ' 
        cbDiving.AutoSize = True
        cbDiving.Location = New Point(273, 58)
        cbDiving.Name = "cbDiving"
        cbDiving.Size = New Size(68, 21)
        cbDiving.TabIndex = 8
        cbDiving.Text = "Diving"
        cbDiving.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(273, 26)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(68, 21)
        cbHiking.TabIndex = 7
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(126, 91)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(85, 21)
        cbMemasak.TabIndex = 6
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbForaging
        ' 
        cbForaging.AutoSize = True
        cbForaging.Location = New Point(126, 58)
        cbForaging.Name = "cbForaging"
        cbForaging.Size = New Size(82, 21)
        cbForaging.TabIndex = 5
        cbForaging.Text = "Foraging"
        cbForaging.UseVisualStyleBackColor = True
        ' 
        ' cbPlogging
        ' 
        cbPlogging.AutoSize = True
        cbPlogging.Location = New Point(126, 26)
        cbPlogging.Name = "cbPlogging"
        cbPlogging.Size = New Size(83, 21)
        cbPlogging.TabIndex = 4
        cbPlogging.Text = "Plogging"
        cbPlogging.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(6, 91)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(84, 21)
        cbFotografi.TabIndex = 2
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbBerkebun
        ' 
        cbBerkebun.AutoSize = True
        cbBerkebun.Location = New Point(6, 58)
        cbBerkebun.Name = "cbBerkebun"
        cbBerkebun.Size = New Size(85, 21)
        cbBerkebun.TabIndex = 1
        cbBerkebun.Text = "Berkebun"
        cbBerkebun.UseVisualStyleBackColor = True
        ' 
        ' cbBertani
        ' 
        cbBertani.AutoSize = True
        cbBertani.Location = New Point(6, 26)
        cbBertani.Name = "cbBertani"
        cbBertani.Size = New Size(71, 21)
        cbBertani.TabIndex = 0
        cbBertani.Text = "Bertani"
        cbBertani.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.RoyalBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(395, 156)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(137, 30)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Cetak"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' picProfil
        ' 
        picProfil.Image = My.Resources.Resources.knight
        picProfil.Location = New Point(12, 29)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(113, 121)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' tpKontakInfo
        ' 
        tpKontakInfo.BackColor = Color.SeaGreen
        tpKontakInfo.Controls.Add(Button5)
        tpKontakInfo.Controls.Add(mtbNoHp)
        tpKontakInfo.Controls.Add(Button3)
        tpKontakInfo.Controls.Add(tbAlamat)
        tpKontakInfo.Controls.Add(tbEmail)
        tpKontakInfo.Controls.Add(Label9)
        tpKontakInfo.Controls.Add(Label8)
        tpKontakInfo.Controls.Add(Label5)
        tpKontakInfo.Controls.Add(PictureBox5)
        tpKontakInfo.Controls.Add(PictureBox6)
        tpKontakInfo.Controls.Add(PictureBox7)
        tpKontakInfo.ForeColor = SystemColors.ActiveCaptionText
        tpKontakInfo.Location = New Point(4, 29)
        tpKontakInfo.Name = "tpKontakInfo"
        tpKontakInfo.Padding = New Padding(3)
        tpKontakInfo.Size = New Size(553, 195)
        tpKontakInfo.TabIndex = 1
        tpKontakInfo.Text = "Kontak & Info"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Crimson
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(329, 156)
        Button5.Name = "Button5"
        Button5.Size = New Size(98, 30)
        Button5.TabIndex = 17
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' mtbNoHp
        ' 
        mtbNoHp.Location = New Point(18, 46)
        mtbNoHp.Mask = "(+62) 000-0000-0000"
        mtbNoHp.Name = "mtbNoHp"
        mtbNoHp.Size = New Size(141, 25)
        mtbNoHp.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RoyalBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(433, 156)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 30)
        Button3.TabIndex = 15
        Button3.Text = "Selanjutnya"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Location = New Point(18, 118)
        tbAlamat.MaxLength = 100
        tbAlamat.Name = "tbAlamat"
        tbAlamat.Size = New Size(513, 25)
        tbAlamat.TabIndex = 12
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(179, 46)
        tbEmail.MaxLength = 100
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(352, 25)
        tbEmail.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(18, 91)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 17)
        Label9.TabIndex = 11
        Label9.Text = "Alamat Lengkap"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(179, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 17)
        Label8.TabIndex = 9
        Label8.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(16, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 17)
        Label5.TabIndex = 7
        Label5.Text = "Nomor Telepon"
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.BackColor = Color.SeaGreen
        tpDataUtama.Controls.Add(Label10)
        tpDataUtama.Controls.Add(tbUmur)
        tpDataUtama.Controls.Add(tbIdAnggota)
        tpDataUtama.Controls.Add(tbNama)
        tpDataUtama.Controls.Add(btnSelanjutnya)
        tpDataUtama.Controls.Add(GroupBox1)
        tpDataUtama.Controls.Add(cboJenisKomunitas)
        tpDataUtama.Controls.Add(dtpLahir)
        tpDataUtama.Controls.Add(Label7)
        tpDataUtama.Controls.Add(Label6)
        tpDataUtama.Controls.Add(Label4)
        tpDataUtama.Controls.Add(Label3)
        tpDataUtama.Controls.Add(PictureBox3)
        tpDataUtama.Controls.Add(PictureBox1)
        tpDataUtama.Controls.Add(PictureBox4)
        tpDataUtama.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tpDataUtama.ForeColor = SystemColors.ActiveCaptionText
        tpDataUtama.Location = New Point(4, 29)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(553, 195)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "Data Utama"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(214, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 17)
        Label10.TabIndex = 26
        Label10.Text = "Umur"
        ' 
        ' tbUmur
        ' 
        tbUmur.Location = New Point(214, 46)
        tbUmur.MaxLength = 3
        tbUmur.Name = "tbUmur"
        tbUmur.Size = New Size(83, 23)
        tbUmur.TabIndex = 25
        ' 
        ' tbIdAnggota
        ' 
        tbIdAnggota.Location = New Point(19, 115)
        tbIdAnggota.MaxLength = 5
        tbIdAnggota.Name = "tbIdAnggota"
        tbIdAnggota.Size = New Size(100, 23)
        tbIdAnggota.TabIndex = 8
        ' 
        ' tbNama
        ' 
        tbNama.Location = New Point(19, 46)
        tbNama.MaxLength = 50
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(170, 23)
        tbNama.TabIndex = 6
        ' 
        ' btnSelanjutnya
        ' 
        btnSelanjutnya.BackColor = Color.RoyalBlue
        btnSelanjutnya.FlatStyle = FlatStyle.Flat
        btnSelanjutnya.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelanjutnya.ForeColor = SystemColors.ButtonHighlight
        btnSelanjutnya.Location = New Point(441, 156)
        btnSelanjutnya.Name = "btnSelanjutnya"
        btnSelanjutnya.Size = New Size(98, 30)
        btnSelanjutnya.TabIndex = 16
        btnSelanjutnya.Text = "Selanjutnya"
        btnSelanjutnya.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbCowo)
        GroupBox1.Controls.Add(rbCewe)
        GroupBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(331, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(208, 55)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbCowo
        ' 
        rbCowo.AutoSize = True
        rbCowo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCowo.ForeColor = SystemColors.ButtonHighlight
        rbCowo.Location = New Point(6, 28)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(81, 21)
        rbCowo.TabIndex = 11
        rbCowo.TabStop = True
        rbCowo.Text = "Laki-Laki"
        rbCowo.UseVisualStyleBackColor = True
        ' 
        ' rbCewe
        ' 
        rbCewe.AutoSize = True
        rbCewe.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCewe.ForeColor = SystemColors.ButtonHighlight
        rbCewe.Location = New Point(91, 28)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(96, 21)
        rbCewe.TabIndex = 12
        rbCewe.TabStop = True
        rbCewe.Text = "Perempuan"
        rbCewe.UseVisualStyleBackColor = True
        ' 
        ' cboJenisKomunitas
        ' 
        cboJenisKomunitas.FormattingEnabled = True
        cboJenisKomunitas.Items.AddRange(New Object() {"Pecinta Tumbuhan", "Pecinta Lingkungan", "Pecinta Alam", "Pecinta Pohon", "Pecinta Laut", "Pecinta Pantai"})
        cboJenisKomunitas.Location = New Point(139, 115)
        cboJenisKomunitas.Name = "cboJenisKomunitas"
        cboJenisKomunitas.Size = New Size(170, 23)
        cboJenisKomunitas.TabIndex = 10
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpLahir.Location = New Point(322, 46)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(217, 23)
        dtpLahir.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(139, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 17)
        Label7.TabIndex = 4
        Label7.Text = "Divisi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(19, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 17)
        Label6.TabIndex = 3
        Label6.Text = "ID Anggota"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(318, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 1
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(19, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 17)
        Label3.TabIndex = 0
        Label3.Text = "Nama Lengkap"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.sawit1
        PictureBox3.Location = New Point(-4, 98)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(166, 113)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 31
        PictureBox3.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontakInfo)
        TabControl1.Controls.Add(tpProfil)
        TabControl1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 182)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(561, 228)
        TabControl1.TabIndex = 3
        ' 
        ' PictureBox16
        ' 
        PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), Image)
        PictureBox16.Location = New Point(0, 161)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(584, 261)
        PictureBox16.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox16.TabIndex = 21
        PictureBox16.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(584, 128)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(584, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.sawit1
        PictureBox1.Location = New Point(188, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(166, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.sawit1
        PictureBox4.Location = New Point(390, 98)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(166, 113)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 33
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.sawit1
        PictureBox5.Location = New Point(-4, 98)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(166, 113)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 34
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.sawit1
        PictureBox6.Location = New Point(188, 98)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(166, 113)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 35
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.sawit1
        PictureBox7.Location = New Point(390, 98)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(166, 113)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 36
        PictureBox7.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(584, 422)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox16)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        tpProfil.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        tpKontakInfo.ResumeLayout(False)
        tpKontakInfo.PerformLayout()
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInputData As ToolStripMenuItem
    Friend WithEvents menuLihatKartu As ToolStripMenuItem
    Friend WithEvents menuSimpanData As ToolStripMenuItem
    Friend WithEvents menuBukaData As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents tbUmur As TextBox
    Friend WithEvents tbIdAnggota As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents btnSelanjutnya As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents cboJenisKomunitas As ComboBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tpKontakInfo As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents mtbNoHp As MaskedTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents btnGambar As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbBeekeeping As CheckBox
    Friend WithEvents cbDiving As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbForaging As CheckBox
    Friend WithEvents cbPlogging As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents cbBertani As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox

End Class
