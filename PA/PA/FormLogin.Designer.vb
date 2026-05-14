<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(321, 386)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.motorcycle
        PictureBox1.Location = New Point(56, 129)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 193)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(93, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 1
        Label2.Text = "Management System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(56, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 37)
        Label1.TabIndex = 0
        Label1.Text = "MOTORPARTS"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(321, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(520, 386)
        Panel2.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 5
        btnLogin.CustomizableEdges = CustomizableEdges1
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(50, 270)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnLogin.Size = New Size(420, 40)
        btnLogin.TabIndex = 2
        btnLogin.Text = "MASUK"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderColor = Color.DimGray
        txtPassword.BorderRadius = 5
        txtPassword.CustomizableEdges = CustomizableEdges3
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.LightSlateGray
        txtPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Location = New Point(50, 218)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = ""
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPassword.Size = New Size(420, 29)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderColor = Color.DimGray
        txtUsername.BorderRadius = 5
        txtUsername.CustomizableEdges = CustomizableEdges5
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FillColor = Color.FromArgb(CByte(27), CByte(34), CByte(54))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.LightSlateGray
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(50, 148)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = ""
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtUsername.Size = New Size(420, 29)
        txtUsername.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonShadow
        Label6.Location = New Point(48, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 2
        Label6.Text = "PASSWORD"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonShadow
        Label5.Location = New Point(50, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 1
        Label5.Text = "USERNAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(50, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 32)
        Label4.TabIndex = 0
        Label4.Text = "Selamat Datang"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(839, 383)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
