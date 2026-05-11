<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKelolaUser
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
        Me.pnlKiri      = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblFormSub   = New System.Windows.Forms.Label()
        Me.lblNama      = New System.Windows.Forms.Label()
        Me.txtNama      = New System.Windows.Forms.TextBox()
        Me.lblUsername  = New System.Windows.Forms.Label()
        Me.txtUsername  = New System.Windows.Forms.TextBox()
        Me.lblPassword  = New System.Windows.Forms.Label()
        Me.txtPassword  = New System.Windows.Forms.TextBox()
        Me.lblPwdNote   = New System.Windows.Forms.Label()
        Me.lblRole      = New System.Windows.Forms.Label()
        Me.cboRole      = New System.Windows.Forms.ComboBox()
        Me.btnSimpan    = New System.Windows.Forms.Button()
        Me.btnHapus     = New System.Windows.Forms.Button()
        Me.btnBaru      = New System.Windows.Forms.Button()
        Me.pnlKanan     = New System.Windows.Forms.Panel()
        Me.pnlTopBar    = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.cboFilter    = New System.Windows.Forms.ComboBox()
        Me.txtCari      = New System.Windows.Forms.TextBox()
        Me.dgvUser      = New System.Windows.Forms.DataGridView()
        Me.pnlStatusBar = New System.Windows.Forms.Panel()
        Me.lblStatusBar = New System.Windows.Forms.Label()
        Me.pnlKiri.SuspendLayout()
        Me.pnlKanan.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()

        ' ============================================================
        '  FORM
        ' ============================================================
        Me.Name            = "frmKelolaUser"
        Me.Text            = "Kelola User"
        Me.ClientSize      = New System.Drawing.Size(960, 580)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MinimumSize     = New System.Drawing.Size(780, 460)
        Me.BackColor       = System.Drawing.Color.FromArgb(15, 17, 23)

        ' ============================================================
        '  PANEL KIRI — Form Input
        ' ============================================================
        Me.pnlKiri.Name      = "pnlKiri"
        Me.pnlKiri.Dock      = System.Windows.Forms.DockStyle.Left
        Me.pnlKiri.Width     = 270
        Me.pnlKiri.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)

        Me.lblFormTitle.Name      = "lblFormTitle"
        Me.lblFormTitle.Text      = "Tambah User Baru"
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

        ' Nama
        Me.lblNama.Name      = "lblNama"
        Me.lblNama.Text      = "NAMA LENGKAP"
        Me.lblNama.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblNama.AutoSize  = True
        Me.lblNama.Location  = New System.Drawing.Point(18, 76)

        Me.txtNama.Name        = "txtNama"
        Me.txtNama.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtNama.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtNama.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Location    = New System.Drawing.Point(18, 96)
        Me.txtNama.Size        = New System.Drawing.Size(230, 30)
        Me.txtNama.MaxLength   = 100

        ' Username
        Me.lblUsername.Name      = "lblUsername"
        Me.lblUsername.Text      = "USERNAME"
        Me.lblUsername.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblUsername.AutoSize  = True
        Me.lblUsername.Location  = New System.Drawing.Point(18, 140)

        Me.txtUsername.Name        = "txtUsername"
        Me.txtUsername.Font        = New System.Drawing.Font("Segoe UI", 10)
        Me.txtUsername.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtUsername.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location    = New System.Drawing.Point(18, 160)
        Me.txtUsername.Size        = New System.Drawing.Size(230, 30)
        Me.txtUsername.MaxLength   = 50

        ' Password
        Me.lblPassword.Name      = "lblPassword"
        Me.lblPassword.Text      = "PASSWORD"
        Me.lblPassword.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblPassword.AutoSize  = True
        Me.lblPassword.Location  = New System.Drawing.Point(18, 204)

        Me.txtPassword.Name         = "txtPassword"
        Me.txtPassword.Font         = New System.Drawing.Font("Segoe UI", 10)
        Me.txtPassword.BackColor    = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtPassword.ForeColor    = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.PasswordChar = "●"c
        Me.txtPassword.Location     = New System.Drawing.Point(18, 224)
        Me.txtPassword.Size         = New System.Drawing.Size(230, 30)
        Me.txtPassword.MaxLength    = 50

        Me.lblPwdNote.Name      = "lblPwdNote"
        Me.lblPwdNote.Text      = "* Kosongkan jika tidak ingin mengubah password"
        Me.lblPwdNote.Font      = New System.Drawing.Font("Segoe UI", 7.5)
        Me.lblPwdNote.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblPwdNote.AutoSize  = True
        Me.lblPwdNote.Location  = New System.Drawing.Point(18, 258)

        ' Role
        Me.lblRole.Name      = "lblRole"
        Me.lblRole.Text      = "ROLE"
        Me.lblRole.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(119, 136, 153)
        Me.lblRole.AutoSize  = True
        Me.lblRole.Location  = New System.Drawing.Point(18, 280)

        Me.cboRole.Name          = "cboRole"
        Me.cboRole.Font          = New System.Drawing.Font("Segoe UI", 10)
        Me.cboRole.BackColor     = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.cboRole.ForeColor     = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.cboRole.FlatStyle     = System.Windows.Forms.FlatStyle.Flat
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Location      = New System.Drawing.Point(18, 300)
        Me.cboRole.Size          = New System.Drawing.Size(230, 30)

        ' Tombol Simpan
        Me.btnSimpan.Name      = "btnSimpan"
        Me.btnSimpan.Text      = "💾  Simpan"
        Me.btnSimpan.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize         = 0
        Me.btnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 90, 0)
        Me.btnSimpan.Location  = New System.Drawing.Point(18, 354)
        Me.btnSimpan.Size      = New System.Drawing.Size(110, 36)
        Me.btnSimpan.Cursor    = System.Windows.Forms.Cursors.Hand

        ' Tombol Hapus
        Me.btnHapus.Name      = "btnHapus"
        Me.btnHapus.Text      = "🗑  Hapus"
        Me.btnHapus.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(42, 45, 62)
        Me.btnHapus.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(58, 32, 32)
        Me.btnHapus.Location  = New System.Drawing.Point(136, 354)
        Me.btnHapus.Size      = New System.Drawing.Size(112, 36)
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
        Me.btnBaru.Location  = New System.Drawing.Point(18, 402)
        Me.btnBaru.Size      = New System.Drawing.Size(230, 32)
        Me.btnBaru.Cursor    = System.Windows.Forms.Cursors.Hand

        Me.pnlKiri.Controls.AddRange({
            Me.lblFormTitle, Me.lblFormSub,
            Me.lblNama,      Me.txtNama,
            Me.lblUsername,  Me.txtUsername,
            Me.lblPassword,  Me.txtPassword, Me.lblPwdNote,
            Me.lblRole,      Me.cboRole,
            Me.btnSimpan,    Me.btnHapus,    Me.btnBaru
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
        Me.lblPageTitle.Text      = "👥  Kelola User"
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
        Me.cboFilter.Location      = New System.Drawing.Point(380, 10)
        Me.cboFilter.Size          = New System.Drawing.Size(140, 28)
        Me.cboFilter.Anchor        = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        Me.txtCari.Name        = "txtCari"
        Me.txtCari.Font        = New System.Drawing.Font("Segoe UI", 9)
        Me.txtCari.BackColor   = System.Drawing.Color.FromArgb(26, 29, 42)
        Me.txtCari.ForeColor   = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Location    = New System.Drawing.Point(530, 10)
        Me.txtCari.Size        = New System.Drawing.Size(150, 28)
        Me.txtCari.Anchor      = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right

        Me.pnlTopBar.Controls.AddRange({Me.lblPageTitle, Me.cboFilter, Me.txtCari})

        ' DataGridView
        Me.dgvUser.Name             = "dgvUser"
        Me.dgvUser.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvUser.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvUser.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvUser.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvUser.RowHeadersVisible    = False
        Me.dgvUser.AllowUserToAddRows    = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.ReadOnly              = True
        Me.dgvUser.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvUser.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvUser.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvUser.EnableHeadersVisualStyles               = False
        Me.dgvUser.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvUser.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvUser.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(38, 41, 58)
        Me.dgvUser.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.White
        Me.dgvUser.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        Me.pnlKanan.Controls.AddRange({Me.pnlTopBar, Me.dgvUser})

        ' ============================================================
        '  STATUS BAR
        ' ============================================================
        Me.pnlStatusBar.Name      = "pnlStatusBar"
        Me.pnlStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Height    = 28
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(13, 15, 24)

        Me.lblStatusBar.Name      = "lblStatusBar"
        Me.lblStatusBar.Text      = "Total: 0 user"
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
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNama      As System.Windows.Forms.Label
    Friend WithEvents txtNama      As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername  As System.Windows.Forms.Label
    Friend WithEvents txtUsername  As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword  As System.Windows.Forms.Label
    Friend WithEvents txtPassword  As System.Windows.Forms.TextBox
    Friend WithEvents lblPwdNote   As System.Windows.Forms.Label
    Friend WithEvents lblRole      As System.Windows.Forms.Label
    Friend WithEvents cboRole      As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpan    As System.Windows.Forms.Button
    Friend WithEvents btnHapus     As System.Windows.Forms.Button
    Friend WithEvents btnBaru      As System.Windows.Forms.Button

    Friend WithEvents pnlKanan     As System.Windows.Forms.Panel
    Friend WithEvents pnlTopBar    As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents cboFilter    As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari      As System.Windows.Forms.TextBox
    Friend WithEvents dgvUser      As System.Windows.Forms.DataGridView

    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar As System.Windows.Forms.Label

End Class
