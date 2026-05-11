<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKelolaSparepart
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
        Me.pnlKiri        = New System.Windows.Forms.Panel()
        Me.lblFormTitle   = New System.Windows.Forms.Label()
        Me.lblFormSub     = New System.Windows.Forms.Label()
        Me.lblNamaPart    = New System.Windows.Forms.Label()
        Me.txtNamaPart    = New System.Windows.Forms.TextBox()
        Me.lblKategori    = New System.Windows.Forms.Label()
        Me.txtKategori    = New System.Windows.Forms.TextBox()
        Me.lblMerk        = New System.Windows.Forms.Label()
        Me.cboMerk        = New System.Windows.Forms.ComboBox()
        Me.lblHarga       = New System.Windows.Forms.Label()
        Me.txtHarga       = New System.Windows.Forms.TextBox()
        Me.lblStok        = New System.Windows.Forms.Label()
        Me.txtStok        = New System.Windows.Forms.TextBox()
        Me.btnSimpan      = New System.Windows.Forms.Button()
        Me.btnHapus       = New System.Windows.Forms.Button()
        Me.btnBaru        = New System.Windows.Forms.Button()
        Me.pnlKanan       = New System.Windows.Forms.Panel()
        Me.pnlTopBar      = New System.Windows.Forms.Panel()
        Me.lblPageTitle   = New System.Windows.Forms.Label()
        Me.cboFilter      = New System.Windows.Forms.ComboBox()
        Me.txtCari        = New System.Windows.Forms.TextBox()
        Me.dgvSparepart   = New System.Windows.Forms.DataGridView()
        Me.pnlStatusBar   = New System.Windows.Forms.Panel()
        Me.lblStatusBar   = New System.Windows.Forms.Label()
        Me.pnlKiri.SuspendLayout()
        Me.pnlKanan.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.dgvSparepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()

        ' ============================================================
        '  FORM
        ' ============================================================
        Me.Name            = "frmKelolaSparepart"
        Me.Text            = "Kelola Sparepart"
        Me.ClientSize      = New System.Drawing.Size(1000, 620)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MinimumSize     = New System.Drawing.Size(800, 500)
        Me.BackColor       = System.Drawing.Color.FromArgb(15, 17, 23)

        ' ============================================================
        '  PANEL KIRI — Form Input
        ' ============================================================
        Me.pnlKiri.Name      = "pnlKiri"
        Me.pnlKiri.Dock      = System.Windows.Forms.DockStyle.Left
        Me.pnlKiri.Width     = 280
        Me.pnlKiri.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.pnlKiri.Padding   = New System.Windows.Forms.Padding(18)

        ' Judul form input
        Me.lblFormTitle.Name      = "lblFormTitle"
        Me.lblFormTitle.Text      = "Tambah Sparepart Baru"
        Me.lblFormTitle.Font      = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240)
        Me.lblFormTitle.AutoSize  = True
        Me.lblFormTitle.Location  = New System.Drawing.Point(18, 18)

        Me.lblFormSub.Name      = "lblFormSub"
        Me.lblFormSub.Text      = "Pilih baris tabel untuk edit / hapus"
        Me.lblFormSub.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblFormSub.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblFormSub.AutoSize  = True
        Me.lblFormSub.Location  = New System.Drawing.Point(18, 44)

        ' Nama Part
        Me.lblNamaPart.Name      = "lblNamaPart"
        Me.lblNamaPart.Text      = "NAMA PART"
        Me.lblNamaPart.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblNamaPart.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblNamaPart.AutoSize  = True
        Me.lblNamaPart.Location  = New System.Drawing.Point(18, 76)

        Me.txtNamaPart.Name        = "txtNamaPart"
        Me.txtNamaPart.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtNamaPart.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtNamaPart.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtNamaPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPart.Location    = New System.Drawing.Point(18, 96)
        Me.txtNamaPart.Size        = New System.Drawing.Size(240, 30)
        Me.txtNamaPart.MaxLength   = 150

        ' Kategori
        Me.lblKategori.Name      = "lblKategori"
        Me.lblKategori.Text      = "KATEGORI"
        Me.lblKategori.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblKategori.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblKategori.AutoSize  = True
        Me.lblKategori.Location  = New System.Drawing.Point(18, 140)

        Me.txtKategori.Name        = "txtKategori"
        Me.txtKategori.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtKategori.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtKategori.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKategori.Location    = New System.Drawing.Point(18, 160)
        Me.txtKategori.Size        = New System.Drawing.Size(240, 30)
        Me.txtKategori.MaxLength   = 50

        ' Merk Motor
        Me.lblMerk.Name      = "lblMerk"
        Me.lblMerk.Text      = "MERK MOTOR"
        Me.lblMerk.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblMerk.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblMerk.AutoSize  = True
        Me.lblMerk.Location  = New System.Drawing.Point(18, 204)

        Me.cboMerk.Name          = "cboMerk"
        Me.cboMerk.Font          = New System.Drawing.Font("Segoe UI", 10)
        Me.cboMerk.BackColor     = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.cboMerk.ForeColor     = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.cboMerk.FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        Me.cboMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMerk.Location      = New System.Drawing.Point(18, 224)
        Me.cboMerk.Size          = New System.Drawing.Size(240, 30)

        ' Harga Jual
        Me.lblHarga.Name      = "lblHarga"
        Me.lblHarga.Text      = "HARGA JUAL (Rp)"
        Me.lblHarga.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblHarga.AutoSize  = True
        Me.lblHarga.Location  = New System.Drawing.Point(18, 268)

        Me.txtHarga.Name        = "txtHarga"
        Me.txtHarga.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtHarga.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtHarga.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHarga.Location    = New System.Drawing.Point(18, 288)
        Me.txtHarga.Size        = New System.Drawing.Size(240, 30)

        ' Stok
        Me.lblStok.Name      = "lblStok"
        Me.lblStok.Text      = "STOK"
        Me.lblStok.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblStok.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblStok.AutoSize  = True
        Me.lblStok.Location  = New System.Drawing.Point(18, 332)

        Me.txtStok.Name        = "txtStok"
        Me.txtStok.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtStok.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtStok.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStok.Location    = New System.Drawing.Point(18, 352)
        Me.txtStok.Size        = New System.Drawing.Size(240, 30)
        Me.txtStok.MaxLength   = 6

        ' Tombol Simpan
        Me.btnSimpan.Name      = "btnSimpan"
        Me.btnSimpan.Text      = "💾  Simpan"
        Me.btnSimpan.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize         = 0
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 90, 0)
        Me.btnSimpan.Location  = New System.Drawing.Point(18, 402)
        Me.btnSimpan.Size      = New System.Drawing.Size(116, 36)
        Me.btnSimpan.Cursor    = System.Windows.Forms.Cursors.Hand

        ' Tombol Hapus
        Me.btnHapus.Name      = "btnHapus"
        Me.btnHapus.Text      = "🗑  Hapus"
        Me.btnHapus.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(42, 45, 62)
        Me.btnHapus.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 32, 32)
        Me.btnHapus.Location  = New System.Drawing.Point(142, 402)
        Me.btnHapus.Size      = New System.Drawing.Size(116, 36)
        Me.btnHapus.Cursor    = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Enabled   = False

        ' Tombol Baru
        Me.btnBaru.Name      = "btnBaru"
        Me.btnBaru.Text      = "＋  Baru / Reset Form"
        Me.btnBaru.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.btnBaru.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.btnBaru.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.btnBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaru.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(42, 45, 62)
        Me.btnBaru.Location  = New System.Drawing.Point(18, 450)
        Me.btnBaru.Size      = New System.Drawing.Size(240, 32)
        Me.btnBaru.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.pnlKiri.Controls.AddRange({
            Me.lblFormTitle, Me.lblFormSub,
            Me.lblNamaPart, Me.txtNamaPart,
            Me.lblKategori, Me.txtKategori,
            Me.lblMerk,     Me.cboMerk,
            Me.lblHarga,    Me.txtHarga,
            Me.lblStok,     Me.txtStok,
            Me.btnSimpan,   Me.btnHapus,
            Me.btnBaru
        })

        ' ============================================================
        '  PANEL KANAN — Tabel
        ' ============================================================
        Me.pnlKanan.Name      = "pnlKanan"
        Me.pnlKanan.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlKanan.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.pnlKanan.Padding   = New System.Windows.Forms.Padding(16, 14, 16, 0)

        ' Top bar
        Me.pnlTopBar.Name      = "pnlTopBar"
        Me.pnlTopBar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Height    = 46
        Me.pnlTopBar.BackColor = System.Drawing.Color.Transparent

        Me.lblPageTitle.Name      = "lblPageTitle"
        Me.lblPageTitle.Text      = "🔩  Inventori Sparepart"
        Me.lblPageTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240)
        Me.lblPageTitle.AutoSize  = True
        Me.lblPageTitle.Location  = New System.Drawing.Point(0, 10)

        Me.cboFilter.Name          = "cboFilter"
        Me.cboFilter.Font          = New System.Drawing.Font("Segoe UI", 9)
        Me.cboFilter.BackColor     = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.cboFilter.ForeColor     = System.Drawing.Color.FromArgb(154, 170, 170)
        Me.cboFilter.FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Location      = New System.Drawing.Point(440, 10)
        Me.cboFilter.Size          = New System.Drawing.Size(150, 28)
        Me.cboFilter.Anchor        = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        Me.txtCari.Name        = "txtCari"
        Me.txtCari.Font        = New System.Drawing.Font("Segoe UI", 9)
        Me.txtCari.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtCari.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Location    = New System.Drawing.Point(600, 10)
        Me.txtCari.Size        = New System.Drawing.Size(100, 28)
        Me.txtCari.Anchor      = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        Me.pnlTopBar.Controls.AddRange({Me.lblPageTitle, Me.cboFilter, Me.txtCari})

        ' DataGridView
        Me.dgvSparepart.Name             = "dgvSparepart"
        Me.dgvSparepart.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvSparepart.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvSparepart.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvSparepart.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvSparepart.RowHeadersVisible   = False
        Me.dgvSparepart.AllowUserToAddRows    = False
        Me.dgvSparepart.AllowUserToDeleteRows = False
        Me.dgvSparepart.ReadOnly              = True
        Me.dgvSparepart.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSparepart.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSparepart.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvSparepart.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvSparepart.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvSparepart.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvSparepart.EnableHeadersVisualStyles               = False
        Me.dgvSparepart.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvSparepart.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvSparepart.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(50, 40, 20)
        Me.dgvSparepart.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.dgvSparepart.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        Me.pnlKanan.Controls.AddRange({Me.pnlTopBar, Me.dgvSparepart})

        ' ============================================================
        '  STATUS BAR
        ' ============================================================
        Me.pnlStatusBar.Name      = "pnlStatusBar"
        Me.pnlStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Height    = 28
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(13, 15, 24)

        Me.lblStatusBar.Name      = "lblStatusBar"
        Me.lblStatusBar.Text      = "Total: 0 sparepart"
        Me.lblStatusBar.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblStatusBar.AutoSize  = True
        Me.lblStatusBar.Location  = New System.Drawing.Point(14, 7)

        Me.pnlStatusBar.Controls.Add(Me.lblStatusBar)

        ' ============================================================
        '  TAMBAHKAN KE FORM
        ' ============================================================
        Me.Controls.Add(Me.pnlKanan)
        Me.Controls.Add(Me.pnlKiri)
        Me.Controls.Add(Me.pnlStatusBar)

        Me.pnlKiri.ResumeLayout(False)
        Me.pnlKiri.PerformLayout()
        Me.pnlKanan.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        CType(Me.dgvSparepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlStatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ============================================================
    '  DEKLARASI CONTROL
    ' ============================================================
    Friend WithEvents pnlKiri      As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblFormSub   As System.Windows.Forms.Label
    Friend WithEvents lblNamaPart  As System.Windows.Forms.Label
    Friend WithEvents txtNamaPart  As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori  As System.Windows.Forms.Label
    Friend WithEvents txtKategori  As System.Windows.Forms.TextBox
    Friend WithEvents lblMerk      As System.Windows.Forms.Label
    Friend WithEvents cboMerk      As System.Windows.Forms.ComboBox
    Friend WithEvents lblHarga     As System.Windows.Forms.Label
    Friend WithEvents txtHarga     As System.Windows.Forms.TextBox
    Friend WithEvents lblStok      As System.Windows.Forms.Label
    Friend WithEvents txtStok      As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan    As System.Windows.Forms.Button
    Friend WithEvents btnHapus     As System.Windows.Forms.Button
    Friend WithEvents btnBaru      As System.Windows.Forms.Button

    Friend WithEvents pnlKanan     As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar    As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents cboFilter    As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari      As System.Windows.Forms.TextBox
    Friend WithEvents dgvSparepart As System.Windows.Forms.DataGridView

    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar As System.Windows.Forms.Label

End Class
