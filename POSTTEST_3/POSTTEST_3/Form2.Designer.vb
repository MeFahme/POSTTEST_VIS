<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblTLahir = New Label()
        lblJK = New Label()
        lblHobi = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblAlamat = New Label()
        PictureBox6 = New PictureBox()
        Panel6 = New Panel()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        PictureBox7 = New PictureBox()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Trebuchet MS", 9F)
        lblNama.Location = New Point(390, 118)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 18)
        lblNama.TabIndex = 1
        lblNama.Text = "Lancelot"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Trebuchet MS", 9F)
        lblUmur.Location = New Point(390, 157)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(20, 18)
        lblUmur.TabIndex = 2
        lblUmur.Text = "30"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Trebuchet MS", 9F)
        lblNoTelp.Location = New Point(390, 194)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(86, 18)
        lblNoTelp.TabIndex = 3
        lblNoTelp.Text = "0813676644414"
        ' 
        ' lblTLahir
        ' 
        lblTLahir.AutoSize = True
        lblTLahir.Font = New Font("Trebuchet MS", 9F)
        lblTLahir.Location = New Point(390, 223)
        lblTLahir.Name = "lblTLahir"
        lblTLahir.Size = New Size(61, 18)
        lblTLahir.TabIndex = 4
        lblTLahir.Text = "13-Mar-99"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Trebuchet MS", 9F)
        lblJK.Location = New Point(390, 292)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(96, 18)
        lblJK.TabIndex = 5
        lblJK.Text = "Kerajaan Logres"
        ' 
        ' lblHobi
        ' 
        lblHobi.Font = New Font("Trebuchet MS", 9F)
        lblHobi.Location = New Point(390, 322)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(171, 57)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Berkuda, Berburu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(292, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 18)
        Label1.TabIndex = 7
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 9F)
        Label2.Location = New Point(292, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 18)
        Label2.TabIndex = 8
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 9F)
        Label3.Location = New Point(292, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 18)
        Label3.TabIndex = 9
        Label3.Text = "No Telpon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 9F)
        Label4.Location = New Point(291, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 18)
        Label4.TabIndex = 10
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 9F)
        Label5.Location = New Point(292, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 18)
        Label5.TabIndex = 11
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 9F)
        Label6.Location = New Point(292, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 18)
        Label6.TabIndex = 12
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 9F)
        Label7.Location = New Point(292, 320)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 18)
        Label7.TabIndex = 13
        Label7.Text = "Hobi"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Trebuchet MS", 9F)
        lblAlamat.Location = New Point(390, 256)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(28, 18)
        lblAlamat.TabIndex = 14
        lblAlamat.Text = "Pria"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.BurlyWood
        PictureBox6.Image = My.Resources.Resources.weapons
        PictureBox6.Location = New Point(567, 122)
        PictureBox6.Margin = New Padding(3, 4, 3, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(235, 215)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 28
        PictureBox6.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Peru
        Panel6.Location = New Point(565, 120)
        Panel6.Margin = New Padding(1)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(239, 219)
        Panel6.TabIndex = 29
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.BurlyWood
        PictureBox1.Image = My.Resources.Resources.knight
        PictureBox1.Location = New Point(58, 118)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 217)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Peru
        Panel5.Location = New Point(56, 116)
        Panel5.Margin = New Padding(1)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(216, 221)
        Panel5.TabIndex = 31
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Add_a_heading
        PictureBox7.Location = New Point(1, 1)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(860, 390)
        PictureBox7.TabIndex = 32
        PictureBox7.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(861, 388)
        Controls.Add(lblHobi)
        Controls.Add(PictureBox1)
        Controls.Add(Panel5)
        Controls.Add(PictureBox6)
        Controls.Add(Panel6)
        Controls.Add(lblAlamat)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblJK)
        Controls.Add(lblTLahir)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBox7)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Adventurer ID"
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblTLahir As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox7 As PictureBox
End Class
