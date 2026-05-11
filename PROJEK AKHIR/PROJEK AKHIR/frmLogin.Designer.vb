<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlKiri = New Panel()
        lblAppName = New Label()
        lblSubtitle = New Label()
        lblDesc = New Label()
        pnlKanan = New Panel()
        lblTitle = New Label()
        lblSub = New Label()
        lblUserName = New Label()
        txtUsername = New TextBox()
        lblPass = New Label()
        txtPassword = New TextBox()
        btnMasuk = New Button()
        btnKeluar = New Button()
        lblForgot = New Label()
        pnlStatus = New Panel()
        lblStatus = New Label()
        pnlKiri.SuspendLayout()
        pnlKanan.SuspendLayout()
        pnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKiri
        ' 
        pnlKiri.BackColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        pnlKiri.Controls.Add(lblAppName)
        pnlKiri.Controls.Add(lblSubtitle)
        pnlKiri.Controls.Add(lblDesc)
        pnlKiri.Location = New Point(0, 0)
        pnlKiri.Name = "pnlKiri"
        pnlKiri.Size = New Size(300, 470)
        pnlKiri.TabIndex = 0
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblAppName.ForeColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        lblAppName.Location = New Point(50, 160)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(197, 37)
        lblAppName.TabIndex = 0
        lblAppName.Text = "MOTORPARTS"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(102), CByte(119), CByte(136))
        lblSubtitle.Location = New Point(70, 200)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(119, 15)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Management System"
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Segoe UI", 9F)
        lblDesc.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblDesc.Location = New Point(60, 250)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(158, 45)
        lblDesc.TabIndex = 2
        lblDesc.Text = "Sistem manajemen inventori" & vbCrLf & "sparepart dan servis motor" & vbCrLf & "terintegrasi"
        ' 
        ' pnlKanan
        ' 
        pnlKanan.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        pnlKanan.Controls.Add(lblTitle)
        pnlKanan.Controls.Add(lblSub)
        pnlKanan.Controls.Add(lblUserName)
        pnlKanan.Controls.Add(txtUsername)
        pnlKanan.Controls.Add(lblPass)
        pnlKanan.Controls.Add(txtPassword)
        pnlKanan.Controls.Add(btnMasuk)
        pnlKanan.Controls.Add(btnKeluar)
        pnlKanan.Controls.Add(lblForgot)
        pnlKanan.Location = New Point(300, 0)
        pnlKanan.Name = "pnlKanan"
        pnlKanan.Size = New Size(520, 470)
        pnlKanan.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(232), CByte(232), CByte(240))
        lblTitle.Location = New Point(60, 80)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(194, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Selamat Datang"
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.Font = New Font("Segoe UI", 9F)
        lblSub.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblSub.Location = New Point(62, 120)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(224, 15)
        lblSub.TabIndex = 1
        lblSub.Text = "Masuk dengan akun yang telah diberikan"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblUserName.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblUserName.Location = New Point(62, 162)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(68, 13)
        lblUserName.TabIndex = 2
        lblUserName.Text = "USERNAME"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtUsername.Location = New Point(62, 184)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(380, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblPass.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblPass.Location = New Point(62, 240)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(67, 13)
        lblPass.TabIndex = 4
        lblPass.Text = "PASSWORD"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(26), CByte(29), CByte(42))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(216))
        txtPassword.Location = New Point(62, 262)
        txtPassword.MaxLength = 50
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(380, 27)
        txtPassword.TabIndex = 5
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.FromArgb(CByte(255), CByte(140), CByte(0))
        btnMasuk.Cursor = Cursors.Hand
        btnMasuk.FlatAppearance.BorderSize = 0
        btnMasuk.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(70), CByte(0))
        btnMasuk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(90), CByte(0))
        btnMasuk.FlatStyle = FlatStyle.Flat
        btnMasuk.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnMasuk.ForeColor = Color.White
        btnMasuk.Location = New Point(62, 326)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(380, 44)
        btnMasuk.TabIndex = 6
        btnMasuk.Text = "MASUK"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        btnKeluar.Cursor = Cursors.Hand
        btnKeluar.FlatAppearance.BorderSize = 0
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Segoe UI", 9F)
        btnKeluar.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        btnKeluar.Location = New Point(180, 382)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(144, 30)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' lblForgot
        ' 
        lblForgot.AutoSize = True
        lblForgot.Font = New Font("Segoe UI", 8F)
        lblForgot.ForeColor = Color.FromArgb(CByte(51), CByte(68), CByte(85))
        lblForgot.Location = New Point(152, 424)
        lblForgot.Name = "lblForgot"
        lblForgot.Size = New Size(212, 13)
        lblForgot.TabIndex = 8
        lblForgot.Text = "Lupa password? Hubungi Administrator"
        ' 
        ' pnlStatus
        ' 
        pnlStatus.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        pnlStatus.Controls.Add(lblStatus)
        pnlStatus.Location = New Point(0, 470)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Size = New Size(820, 30)
        pnlStatus.TabIndex = 2
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 8F)
        lblStatus.ForeColor = Color.FromArgb(CByte(119), CByte(136), CByte(153))
        lblStatus.Location = New Point(14, 8)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(182, 13)
        lblStatus.TabIndex = 0
        lblStatus.Text = "● Menghubungkan ke database..."
        ' 
        ' frmLogin
        ' 
        BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        ClientSize = New Size(820, 500)
        Controls.Add(pnlKiri)
        Controls.Add(pnlKanan)
        Controls.Add(pnlStatus)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen & Inventori Sparepart Motor"
        pnlKiri.ResumeLayout(False)
        pnlKiri.PerformLayout()
        pnlKanan.ResumeLayout(False)
        pnlKanan.PerformLayout()
        pnlStatus.ResumeLayout(False)
        pnlStatus.PerformLayout()
        ResumeLayout(False)

    End Sub

    ' ============================================================
    '  DEKLARASI SEMUA CONTROL
    ' ============================================================
    Friend WithEvents pnlKiri     As System.Windows.Forms.Panel
    Friend WithEvents lblAppName  As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblDesc     As System.Windows.Forms.Label

    Friend WithEvents pnlKanan    As System.Windows.Forms.Panel
    Friend WithEvents lblTitle    As System.Windows.Forms.Label
    Friend WithEvents lblSub      As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPass     As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnMasuk    As System.Windows.Forms.Button
    Friend WithEvents btnKeluar   As System.Windows.Forms.Button
    Friend WithEvents lblForgot   As System.Windows.Forms.Label

    Friend WithEvents pnlStatus   As System.Windows.Forms.Panel
    Friend WithEvents lblStatus   As System.Windows.Forms.Label

End Class
