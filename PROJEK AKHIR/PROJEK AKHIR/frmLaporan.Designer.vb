<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLaporan
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
        Me.lblDari      = New System.Windows.Forms.Label()
        Me.dtpDari      = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai    = New System.Windows.Forms.Label()
        Me.dtpSampai    = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnHariIni   = New System.Windows.Forms.Button()
        Me.btnBulanIni  = New System.Windows.Forms.Button()
        Me.btnExport    = New System.Windows.Forms.Button()
        Me.tabLaporan   = New System.Windows.Forms.TabControl()
        Me.tabPenjualan = New System.Windows.Forms.TabPage()
        Me.tabStok      = New System.Windows.Forms.TabPage()
        Me.pnlKartu     = New System.Windows.Forms.Panel()
        Me.dgvLaporan   = New System.Windows.Forms.DataGridView()
        Me.pnlStatusBar = New System.Windows.Forms.Panel()
        Me.lblStatusBar = New System.Windows.Forms.Label()

        ' Kartu ringkasan
        Me.lblTotalTrxLbl   = New System.Windows.Forms.Label()
        Me.lblTotalTrx      = New System.Windows.Forms.Label()
        Me.lblTotalOmzetLbl = New System.Windows.Forms.Label()
        Me.lblTotalOmzet    = New System.Windows.Forms.Label()
        Me.lblTotalLunasLbl = New System.Windows.Forms.Label()
        Me.lblTotalLunas    = New System.Windows.Forms.Label()
        Me.lblTotalBelumLbl = New System.Windows.Forms.Label()
        Me.lblTotalBelum    = New System.Windows.Forms.Label()

        Me.pnlToolbar.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        Me.pnlKartu.SuspendLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()

        ' ============================================================
        '  FORM
        ' ============================================================
        Me.Name            = "frmLaporan"
        Me.Text            = "Laporan"
        Me.ClientSize      = New System.Drawing.Size(1000, 640)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MinimumSize     = New System.Drawing.Size(760, 500)
        Me.BackColor       = System.Drawing.Color.FromArgb(15, 17, 23)

        ' ============================================================
        '  TOOLBAR FILTER
        ' ============================================================
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 46
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(24, 27, 40)

        Me.lblDari.Name      = "lblDari"
        Me.lblDari.Text      = "Dari:"
        Me.lblDari.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDari.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDari.AutoSize  = True
        Me.lblDari.Location  = New System.Drawing.Point(12, 14)

        Me.dtpDari.Name      = "dtpDari"
        Me.dtpDari.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpDari.Format    = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Location  = New System.Drawing.Point(50, 10)
        Me.dtpDari.Size      = New System.Drawing.Size(120, 26)
        Me.dtpDari.CalendarMonthBackground = System.Drawing.Color.FromArgb(26, 29, 42)

        Me.lblSampai.Name      = "lblSampai"
        Me.lblSampai.Text      = "s/d"
        Me.lblSampai.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSampai.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblSampai.AutoSize  = True
        Me.lblSampai.Location  = New System.Drawing.Point(178, 14)

        Me.dtpSampai.Name      = "dtpSampai"
        Me.dtpSampai.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpSampai.Format    = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Location  = New System.Drawing.Point(204, 10)
        Me.dtpSampai.Size      = New System.Drawing.Size(120, 26)

        Me.btnTampilkan.Name      = "btnTampilkan"
        Me.btnTampilkan.Text      = "🔍  Tampilkan"
        Me.btnTampilkan.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.Location  = New System.Drawing.Point(334, 9)
        Me.btnTampilkan.Size      = New System.Drawing.Size(110, 28)
        Me.btnTampilkan.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.btnHariIni.Name      = "btnHariIni"
        Me.btnHariIni.Text      = "📅 Hari Ini"
        Me.btnHariIni.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.btnHariIni.BackColor = System.Drawing.Color.FromArgb(34, 37, 58)
        Me.btnHariIni.ForeColor = System.Drawing.Color.FromArgb(154, 170, 170)
        Me.btnHariIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHariIni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 50, 71)
        Me.btnHariIni.Location  = New System.Drawing.Point(454, 9)
        Me.btnHariIni.Size      = New System.Drawing.Size(90, 28)
        Me.btnHariIni.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.btnBulanIni.Name      = "btnBulanIni"
        Me.btnBulanIni.Text      = "📅 Bulan Ini"
        Me.btnBulanIni.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.btnBulanIni.BackColor = System.Drawing.Color.FromArgb(34, 37, 58)
        Me.btnBulanIni.ForeColor = System.Drawing.Color.FromArgb(154, 170, 170)
        Me.btnBulanIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBulanIni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 50, 71)
        Me.btnBulanIni.Location  = New System.Drawing.Point(552, 9)
        Me.btnBulanIni.Size      = New System.Drawing.Size(96, 28)
        Me.btnBulanIni.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.btnExport.Name      = "btnExport"
        Me.btnExport.Text      = "💾  Export CSV"
        Me.btnExport.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(34, 37, 58)
        Me.btnExport.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.btnExport.Location  = New System.Drawing.Point(858, 9)
        Me.btnExport.Size      = New System.Drawing.Size(110, 28)
        Me.btnExport.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnExport.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.pnlToolbar.Controls.AddRange({
            Me.lblDari, Me.dtpDari,
            Me.lblSampai, Me.dtpSampai,
            Me.btnTampilkan, Me.btnHariIni, Me.btnBulanIni,
            Me.btnExport
        })

        ' ============================================================
        '  TAB CONTROL
        ' ============================================================
        Me.tabLaporan.Name       = "tabLaporan"
        Me.tabLaporan.Dock       = System.Windows.Forms.DockStyle.Top
        Me.tabLaporan.Height     = 34
        Me.tabLaporan.Font       = New System.Drawing.Font("Segoe UI", 9)
        Me.tabLaporan.SizeMode   = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabLaporan.ItemSize   = New System.Drawing.Size(180, 28)
        Me.tabLaporan.Appearance = System.Windows.Forms.TabAppearance.Normal

        Me.tabPenjualan.Name    = "tabPenjualan"
        Me.tabPenjualan.Text    = "📊  Laporan Penjualan"
        Me.tabPenjualan.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)

        Me.tabStok.Name      = "tabStok"
        Me.tabStok.Text      = "📦  Laporan Stok"
        Me.tabStok.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)

        Me.tabLaporan.TabPages.AddRange({Me.tabPenjualan, Me.tabStok})

        ' ============================================================
        '  PANEL KARTU RINGKASAN
        ' ============================================================
        Me.pnlKartu.Name      = "pnlKartu"
        Me.pnlKartu.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlKartu.Height    = 80
        Me.pnlKartu.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.pnlKartu.Padding   = New System.Windows.Forms.Padding(12, 10, 12, 10)

        ' ============================================================
        '  DATAGRIDVIEW LAPORAN
        ' ============================================================
        Me.dgvLaporan.Name             = "dgvLaporan"
        Me.dgvLaporan.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaporan.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvLaporan.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvLaporan.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvLaporan.RowHeadersVisible    = False
        Me.dgvLaporan.AllowUserToAddRows    = False
        Me.dgvLaporan.AllowUserToDeleteRows = False
        Me.dgvLaporan.ReadOnly              = True
        Me.dgvLaporan.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaporan.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaporan.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvLaporan.EnableHeadersVisualStyles               = False
        Me.dgvLaporan.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvLaporan.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvLaporan.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(38, 41, 58)
        Me.dgvLaporan.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.White
        Me.dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        ' ============================================================
        '  STATUS BAR
        ' ============================================================
        Me.pnlStatusBar.Name      = "pnlStatusBar"
        Me.pnlStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Height    = 26
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(13, 15, 24)

        Me.lblStatusBar.Name      = "lblStatusBar"
        Me.lblStatusBar.Text      = "Menampilkan 0 data"
        Me.lblStatusBar.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblStatusBar.AutoSize  = True
        Me.lblStatusBar.Location  = New System.Drawing.Point(12, 6)

        Me.pnlStatusBar.Controls.Add(Me.lblStatusBar)

        ' ============================================================
        '  TAMBAHKAN KE FORM
        ' ============================================================
        Me.Controls.Add(Me.dgvLaporan)
        Me.Controls.Add(Me.pnlKartu)
        Me.Controls.Add(Me.tabLaporan)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlStatusBar)

        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.tabLaporan.ResumeLayout(False)
        Me.pnlKartu.ResumeLayout(False)
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlStatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ============================================================
    '  DEKLARASI CONTROL
    ' ============================================================
    Friend WithEvents pnlToolbar    As System.Windows.Forms.Panel
    Friend WithEvents lblDari       As System.Windows.Forms.Label
    Friend WithEvents dtpDari       As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampai     As System.Windows.Forms.Label
    Friend WithEvents dtpSampai     As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampilkan  As System.Windows.Forms.Button
    Friend WithEvents btnHariIni    As System.Windows.Forms.Button
    Friend WithEvents btnBulanIni   As System.Windows.Forms.Button
    Friend WithEvents btnExport     As System.Windows.Forms.Button
    Friend WithEvents tabLaporan    As System.Windows.Forms.TabControl
    Friend WithEvents tabPenjualan  As System.Windows.Forms.TabPage
    Friend WithEvents tabStok       As System.Windows.Forms.TabPage
    Friend WithEvents pnlKartu      As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTrxLbl   As System.Windows.Forms.Label
    Friend WithEvents lblTotalTrx      As System.Windows.Forms.Label
    Friend WithEvents lblTotalOmzetLbl As System.Windows.Forms.Label
    Friend WithEvents lblTotalOmzet    As System.Windows.Forms.Label
    Friend WithEvents lblTotalLunasLbl As System.Windows.Forms.Label
    Friend WithEvents lblTotalLunas    As System.Windows.Forms.Label
    Friend WithEvents lblTotalBelumLbl As System.Windows.Forms.Label
    Friend WithEvents lblTotalBelum    As System.Windows.Forms.Label
    Friend WithEvents dgvLaporan    As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStatusBar  As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar  As System.Windows.Forms.Label

End Class
