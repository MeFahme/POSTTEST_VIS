<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDaftarMotor
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
        Me.pnlToolbar   = New System.Windows.Forms.Panel()
        Me.btnRefresh   = New System.Windows.Forms.Button()
        Me.lblHint      = New System.Windows.Forms.Label()
        Me.tabMotor     = New System.Windows.Forms.TabControl()
        Me.tabAktif     = New System.Windows.Forms.TabPage()
        Me.dgvMotorAktif = New System.Windows.Forms.DataGridView()
        Me.tabSelesai   = New System.Windows.Forms.TabPage()
        Me.dgvMotorSelesai = New System.Windows.Forms.DataGridView()
        Me.pnlStatusBar = New System.Windows.Forms.Panel()
        Me.lblStatusBar = New System.Windows.Forms.Label()
        Me.pnlToolbar.SuspendLayout()
        Me.tabMotor.SuspendLayout()
        Me.tabAktif.SuspendLayout()
        CType(Me.dgvMotorAktif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSelesai.SuspendLayout()
        CType(Me.dgvMotorSelesai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()

        ' ============================================================
        '  FORM
        ' ============================================================
        Me.Name            = "frmDaftarMotor"
        Me.Text            = "Daftar Motor"
        Me.ClientSize      = New System.Drawing.Size(700, 520)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MinimumSize     = New System.Drawing.Size(500, 400)
        Me.BackColor       = System.Drawing.Color.FromArgb(15, 17, 23)

        ' ============================================================
        '  TOOLBAR
        ' ============================================================
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 42
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(24, 27, 40)

        Me.btnRefresh.Name      = "btnRefresh"
        Me.btnRefresh.Text      = "↻  Refresh"
        Me.btnRefresh.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Location  = New System.Drawing.Point(10, 7)
        Me.btnRefresh.Size      = New System.Drawing.Size(100, 28)
        Me.btnRefresh.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.lblHint.Name      = "lblHint"
        Me.lblHint.Text      = "Double-klik baris untuk buka detail servis"
        Me.lblHint.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(51, 68, 85)
        Me.lblHint.AutoSize  = True
        Me.lblHint.Location  = New System.Drawing.Point(124, 14)

        Me.pnlToolbar.Controls.AddRange({Me.btnRefresh, Me.lblHint})

        ' ============================================================
        '  TAB CONTROL
        ' ============================================================
        Me.tabMotor.Name      = "tabMotor"
        Me.tabMotor.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.tabMotor.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.tabMotor.Appearance = System.Windows.Forms.TabAppearance.Normal

        ' Tab Aktif
        Me.tabAktif.Name    = "tabAktif"
        Me.tabAktif.Text    = "🏍  Motor Aktif"
        Me.tabAktif.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.tabAktif.Padding = New System.Windows.Forms.Padding(0)

        Me.dgvMotorAktif.Name             = "dgvMotorAktif"
        Me.dgvMotorAktif.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvMotorAktif.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvMotorAktif.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvMotorAktif.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvMotorAktif.RowHeadersVisible    = False
        Me.dgvMotorAktif.AllowUserToAddRows    = False
        Me.dgvMotorAktif.AllowUserToDeleteRows = False
        Me.dgvMotorAktif.ReadOnly              = True
        Me.dgvMotorAktif.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMotorAktif.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMotorAktif.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvMotorAktif.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvMotorAktif.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvMotorAktif.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvMotorAktif.EnableHeadersVisualStyles               = False
        Me.dgvMotorAktif.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvMotorAktif.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvMotorAktif.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(50, 40, 20)
        Me.dgvMotorAktif.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.dgvMotorAktif.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        Me.tabAktif.Controls.Add(Me.dgvMotorAktif)

        ' Tab Selesai
        Me.tabSelesai.Name      = "tabSelesai"
        Me.tabSelesai.Text      = "✅  Selesai"
        Me.tabSelesai.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)

        Me.dgvMotorSelesai.Name             = "dgvMotorSelesai"
        Me.dgvMotorSelesai.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvMotorSelesai.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvMotorSelesai.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvMotorSelesai.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvMotorSelesai.RowHeadersVisible    = False
        Me.dgvMotorSelesai.AllowUserToAddRows    = False
        Me.dgvMotorSelesai.AllowUserToDeleteRows = False
        Me.dgvMotorSelesai.ReadOnly              = True
        Me.dgvMotorSelesai.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMotorSelesai.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMotorSelesai.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvMotorSelesai.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvMotorSelesai.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvMotorSelesai.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvMotorSelesai.EnableHeadersVisualStyles               = False
        Me.dgvMotorSelesai.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvMotorSelesai.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvMotorSelesai.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(20, 40, 30)
        Me.dgvMotorSelesai.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.dgvMotorSelesai.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        Me.tabSelesai.Controls.Add(Me.dgvMotorSelesai)

        Me.tabMotor.TabPages.AddRange({Me.tabAktif, Me.tabSelesai})

        ' ============================================================
        '  STATUS BAR
        ' ============================================================
        Me.pnlStatusBar.Name      = "pnlStatusBar"
        Me.pnlStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Height    = 26
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(13, 15, 24)

        Me.lblStatusBar.Name      = "lblStatusBar"
        Me.lblStatusBar.Text      = "Motor aktif: 0"
        Me.lblStatusBar.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblStatusBar.AutoSize  = True
        Me.lblStatusBar.Location  = New System.Drawing.Point(12, 6)

        Me.pnlStatusBar.Controls.Add(Me.lblStatusBar)

        ' ============================================================
        '  TAMBAHKAN KE FORM
        ' ============================================================
        Me.Controls.Add(Me.tabMotor)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlStatusBar)

        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.tabMotor.ResumeLayout(False)
        Me.tabAktif.ResumeLayout(False)
        CType(Me.dgvMotorAktif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSelesai.ResumeLayout(False)
        CType(Me.dgvMotorSelesai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlStatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar      As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh      As System.Windows.Forms.Button
    Friend WithEvents lblHint         As System.Windows.Forms.Label
    Friend WithEvents tabMotor        As System.Windows.Forms.TabControl
    Friend WithEvents tabAktif        As System.Windows.Forms.TabPage
    Friend WithEvents dgvMotorAktif   As System.Windows.Forms.DataGridView
    Friend WithEvents tabSelesai      As System.Windows.Forms.TabPage
    Friend WithEvents dgvMotorSelesai As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStatusBar    As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar    As System.Windows.Forms.Label

End Class
