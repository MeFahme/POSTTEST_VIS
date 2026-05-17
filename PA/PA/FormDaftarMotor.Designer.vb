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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tabMotor = New Guna.UI2.WinForms.Guna2TabControl()
        tabAktif = New TabPage()
        dgvMotorAktif = New DataGridView()
        tabSelesai = New TabPage()
        dgvMotorSelesai = New DataGridView()
        Panel1 = New Panel()
        Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        lblStatusBar = New Label()
        Panel3 = New Panel()
        tabMotor.SuspendLayout()
        tabAktif.SuspendLayout()
        CType(dgvMotorAktif, ComponentModel.ISupportInitialize).BeginInit()
        tabSelesai.SuspendLayout()
        CType(dgvMotorSelesai, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabMotor
        ' 
        tabMotor.Controls.Add(tabAktif)
        tabMotor.Controls.Add(tabSelesai)
        tabMotor.Dock = DockStyle.Fill
        tabMotor.ItemSize = New Size(180, 40)
        tabMotor.Location = New Point(0, 0)
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
        ' dgvMotorAktif
        ' 
        dgvMotorAktif.AllowUserToAddRows = False
        dgvMotorAktif.AllowUserToDeleteRows = False
        dgvMotorAktif.AllowUserToResizeColumns = False
        dgvMotorAktif.AllowUserToResizeRows = False
        dgvMotorAktif.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvMotorAktif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvMotorAktif.DefaultCellStyle = DataGridViewCellStyle1
        dgvMotorAktif.Dock = DockStyle.Fill
        dgvMotorAktif.Location = New Point(3, 3)
        dgvMotorAktif.Name = "dgvMotorAktif"
        dgvMotorAktif.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvMotorAktif.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvMotorAktif.RowHeadersVisible = False
        dgvMotorAktif.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMotorAktif.Size = New Size(686, 398)
        dgvMotorAktif.TabIndex = 31
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
        ' dgvMotorSelesai
        ' 
        dgvMotorSelesai.AllowUserToAddRows = False
        dgvMotorSelesai.AllowUserToDeleteRows = False
        dgvMotorSelesai.AllowUserToResizeColumns = False
        dgvMotorSelesai.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        dgvMotorSelesai.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvMotorSelesai.BackgroundColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        dgvMotorSelesai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(38), CByte(41), CByte(58))
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvMotorSelesai.DefaultCellStyle = DataGridViewCellStyle4
        dgvMotorSelesai.Dock = DockStyle.Fill
        dgvMotorSelesai.Location = New Point(3, 3)
        dgvMotorSelesai.Name = "dgvMotorSelesai"
        dgvMotorSelesai.ReadOnly = True
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(31))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(138), CByte(153), CByte(153))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvMotorSelesai.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvMotorSelesai.RowHeadersVisible = False
        dgvMotorSelesai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMotorSelesai.Size = New Size(686, 398)
        dgvMotorSelesai.TabIndex = 32
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        Panel1.Controls.Add(Guna2Button5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 42)
        Panel1.TabIndex = 1
        ' 
        ' Guna2Button5
        ' 
        Guna2Button5.BorderColor = Color.FromArgb(CByte(85), CByte(102), CByte(119))
        Guna2Button5.BorderRadius = 5
        Guna2Button5.CustomizableEdges = CustomizableEdges1
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
        Guna2Button5.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button5.Size = New Size(100, 28)
        Guna2Button5.TabIndex = 24
        Guna2Button5.Text = "REFRESH"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(13), CByte(15), CByte(24))
        Panel2.Controls.Add(lblStatusBar)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 494)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 26)
        Panel2.TabIndex = 2
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(24), CByte(27), CByte(40))
        Panel3.Controls.Add(tabMotor)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 42)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(700, 452)
        Panel3.TabIndex = 25
        ' 
        ' FormDaftarMotor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 520)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormDaftarMotor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormDaftarMotor"
        tabMotor.ResumeLayout(False)
        tabAktif.ResumeLayout(False)
        CType(dgvMotorAktif, ComponentModel.ISupportInitialize).EndInit()
        tabSelesai.ResumeLayout(False)
        CType(dgvMotorSelesai, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
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
    Friend WithEvents Panel3 As Panel
End Class
