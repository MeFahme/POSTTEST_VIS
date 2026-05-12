<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarMotor
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
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tabMotor = New Guna.UI2.WinForms.Guna2TabControl()
        tabAktif = New TabPage()
        tabSelesai = New TabPage()
        Panel1 = New Panel()
        Panel2 = New Panel()
        dgvMotorAktif = New DataGridView()
        dgvMotorSelesai = New DataGridView()
        Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        lblStatusBar = New Label()
        tabMotor.SuspendLayout()
        tabAktif.SuspendLayout()
        tabSelesai.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvMotorAktif, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMotorSelesai, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabMotor
        ' 
        tabMotor.Controls.Add(tabAktif)
        tabMotor.Controls.Add(tabSelesai)
        tabMotor.ItemSize = New Size(180, 40)
        tabMotor.Location = New Point(0, 42)
        tabMotor.Name = "tabMotor"
        tabMotor.SelectedIndex = 0
        tabMotor.Size = New Size(700, 452)
        tabMotor.TabButtonHoverState.BorderColor = Color.Empty
        tabMotor.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tabMotor.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F)
        tabMotor.TabButtonHoverState.ForeColor = Color.White
        tabMotor.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tabMotor.TabButtonIdleState.BorderColor = Color.Empty
        tabMotor.TabButtonIdleState.FillColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabMotor.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F)
        tabMotor.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        tabMotor.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tabMotor.TabButtonSelectedState.BorderColor = Color.Empty
        tabMotor.TabButtonSelectedState.FillColor = Color.FromArgb(CByte(29), CByte(37), CByte(49))
        tabMotor.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F)
        tabMotor.TabButtonSelectedState.ForeColor = Color.White
        tabMotor.TabButtonSelectedState.InnerColor = Color.FromArgb(CByte(76), CByte(132), CByte(255))
        tabMotor.TabButtonSize = New Size(180, 40)
        tabMotor.TabIndex = 0
        tabMotor.TabMenuBackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        tabMotor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        ' 
        ' tabAktif
        ' 
        tabAktif.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        tabAktif.Controls.Add(dgvMotorAktif)
        tabAktif.Location = New Point(4, 44)
        tabAktif.Name = "tabAktif"
        tabAktif.Padding = New Padding(3)
        tabAktif.Size = New Size(692, 404)
        tabAktif.TabIndex = 0
        tabAktif.Text = "Motor Aktif"
        ' 
        ' tabSelesai
        ' 
        tabSelesai.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(23))
        tabSelesai.Controls.Add(dgvMotorSelesai)
        tabSelesai.Location = New Point(4, 44)
        tabSelesai.Name = "tabSelesai"
        tabSelesai.Padding = New Padding(3)
        tabSelesai.Size = New Size(692, 404)
        tabSelesai.TabIndex = 1
        tabSelesai.Text = "Selesai"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        Panel1.Controls.Add(Guna2Button5)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 42)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        Panel2.Controls.Add(lblStatusBar)
        Panel2.Location = New Point(0, 494)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 26)
        Panel2.TabIndex = 2
        ' 
        ' dgvMotorAktif
        ' 
        dgvMotorAktif.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvMotorAktif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvMotorAktif.DefaultCellStyle = DataGridViewCellStyle9
        dgvMotorAktif.Location = New Point(0, 6)
        dgvMotorAktif.Name = "dgvMotorAktif"
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        dgvMotorAktif.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        dgvMotorAktif.Size = New Size(692, 402)
        dgvMotorAktif.TabIndex = 31
        ' 
        ' dgvMotorSelesai
        ' 
        dgvMotorSelesai.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvMotorSelesai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Window
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle11.SelectionForeColor = Color.White
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        dgvMotorSelesai.DefaultCellStyle = DataGridViewCellStyle11
        dgvMotorSelesai.Location = New Point(0, 1)
        dgvMotorSelesai.Name = "dgvMotorSelesai"
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        dgvMotorSelesai.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        dgvMotorSelesai.Size = New Size(692, 402)
        dgvMotorSelesai.TabIndex = 32
        ' 
        ' Guna2Button5
        ' 
        Guna2Button5.BorderColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Guna2Button5.BorderRadius = 5
        Guna2Button5.CustomizableEdges = CustomizableEdges5
        Guna2Button5.DisabledState.BorderColor = Color.DarkGray
        Guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button5.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button5.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button5.FillColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Guna2Button5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button5.ForeColor = Color.White
        Guna2Button5.HoverState.FillColor = Color.FromArgb(CByte(40), CByte(30), CByte(10))
        Guna2Button5.Location = New Point(10, 7)
        Guna2Button5.Name = "Guna2Button5"
        Guna2Button5.PressedColor = Color.FromArgb(CByte(40), CByte(30), CByte(10))
        Guna2Button5.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button5.Size = New Size(100, 28)
        Guna2Button5.TabIndex = 24
        Guna2Button5.Text = "REFRESH"
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.AutoSize = True
        lblStatusBar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatusBar.ForeColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        lblStatusBar.Location = New Point(12, 6)
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Size = New Size(84, 15)
        lblStatusBar.TabIndex = 26
        lblStatusBar.Text = "Motor aktif: 0"
        ' 
        ' FormDaftarMotor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 520)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(tabMotor)
        Name = "FormDaftarMotor"
        Text = "FormDaftarMotor"
        tabMotor.ResumeLayout(False)
        tabAktif.ResumeLayout(False)
        tabSelesai.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvMotorAktif, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMotorSelesai, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabMotor As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents tabAktif As TabPage
    Friend WithEvents tabSelesai As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMotorAktif As DataGridView
    Friend WithEvents dgvMotorSelesai As DataGridView
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStatusBar As Label
End Class
