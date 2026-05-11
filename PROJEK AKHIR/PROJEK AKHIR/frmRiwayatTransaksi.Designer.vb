<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRiwayatTransaksi
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
        Me.pnlToolbar      = New System.Windows.Forms.Panel()
        Me.lblDari         = New System.Windows.Forms.Label()
        Me.dtpDari         = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai       = New System.Windows.Forms.Label()
        Me.dtpSampai       = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan    = New System.Windows.Forms.Button()
        Me.btnHariIni      = New System.Windows.Forms.Button()
        Me.lblHint         = New System.Windows.Forms.Label()
        Me.pnlBody         = New System.Windows.Forms.Panel()
        Me.dgvRiwayat      = New System.Windows.Forms.DataGridView()
        Me.pnlDetail       = New System.Windows.Forms.Panel()
        Me.lblDetTitle     = New System.Windows.Forms.Label()
        Me.lblDetNoTrxLbl  = New System.Windows.Forms.Label()
        Me.lblDetNoTrx     = New System.Windows.Forms.Label()
        Me.lblDetPelLbl    = New System.Windows.Forms.Label()
        Me.lblDetPelanggan = New System.Windows.Forms.Label()
        Me.lblDetHpLbl     = New System.Windows.Forms.Label()
        Me.lblDetNoHp      = New System.Windows.Forms.Label()
        Me.lblDetJenisLbl  = New System.Windows.Forms.Label()
        Me.lblDetJenis     = New System.Windows.Forms.Label()
        Me.lblDetWaktuLbl  = New System.Windows.Forms.Label()
        Me.lblDetWaktu     = New System.Windows.Forms.Label()
        Me.lblDetStatusLbl = New System.Windows.Forms.Label()
        Me.lblDetStatus    = New System.Windows.Forms.Label()
        Me.lblDetPartLbl   = New System.Windows.Forms.Label()
        Me.dgvDetail       = New System.Windows.Forms.DataGridView()
        Me.pnlServisInfo   = New System.Windows.Forms.Panel()
        Me.lblDetServisLbl = New System.Windows.Forms.Label()
        Me.lblDetServis    = New System.Windows.Forms.Label()
        Me.lblDetBiayaLbl  = New System.Windows.Forms.Label()
        Me.lblDetBiayaJasa = New System.Windows.Forms.Label()
        Me.lblDetMotorLbl  = New System.Windows.Forms.Label()
        Me.lblDetStatusMotor = New System.Windows.Forms.Label()
        Me.lblDetTotalLbl  = New System.Windows.Forms.Label()
        Me.lblDetTotal     = New System.Windows.Forms.Label()
        Me.pnlStatusBar    = New System.Windows.Forms.Panel()
        Me.lblStatusBar    = New System.Windows.Forms.Label()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetail.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlServisInfo.SuspendLayout()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()

        ' ============================================================
        '  FORM
        ' ============================================================
        Me.Name            = "frmRiwayatTransaksi"
        Me.Text            = "Riwayat Transaksi"
        Me.ClientSize      = New System.Drawing.Size(1020, 620)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MinimumSize     = New System.Drawing.Size(800, 500)
        Me.BackColor       = System.Drawing.Color.FromArgb(15, 17, 23)

        ' ============================================================
        '  TOOLBAR
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

        Me.dtpDari.Name     = "dtpDari"
        Me.dtpDari.Font     = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpDari.Format   = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Location = New System.Drawing.Point(50, 10)
        Me.dtpDari.Size     = New System.Drawing.Size(120, 26)

        Me.lblSampai.Name      = "lblSampai"
        Me.lblSampai.Text      = "s/d"
        Me.lblSampai.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSampai.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblSampai.AutoSize  = True
        Me.lblSampai.Location  = New System.Drawing.Point(178, 14)

        Me.dtpSampai.Name     = "dtpSampai"
        Me.dtpSampai.Font     = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpSampai.Format   = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Location = New System.Drawing.Point(204, 10)
        Me.dtpSampai.Size     = New System.Drawing.Size(120, 26)

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

        Me.lblHint.Name      = "lblHint"
        Me.lblHint.Text      = "Klik baris untuk lihat detail transaksi"
        Me.lblHint.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(51, 68, 85)
        Me.lblHint.AutoSize  = True
        Me.lblHint.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.lblHint.Location  = New System.Drawing.Point(780, 15)

        Me.pnlToolbar.Controls.AddRange({
            Me.lblDari, Me.dtpDari,
            Me.lblSampai, Me.dtpSampai,
            Me.btnTampilkan, Me.btnHariIni,
            Me.lblHint
        })

        ' ============================================================
        '  PANEL BODY (tabel kiri + detail kanan)
        ' ============================================================
        Me.pnlBody.Name      = "pnlBody"
        Me.pnlBody.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(15, 17, 23)

        ' DataGridView riwayat
        Me.dgvRiwayat.Name             = "dgvRiwayat"
        Me.dgvRiwayat.Dock             = System.Windows.Forms.DockStyle.Fill
        Me.dgvRiwayat.BackgroundColor  = System.Drawing.Color.FromArgb(15, 17, 23)
        Me.dgvRiwayat.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvRiwayat.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvRiwayat.RowHeadersVisible    = False
        Me.dgvRiwayat.AllowUserToAddRows    = False
        Me.dgvRiwayat.AllowUserToDeleteRows = False
        Me.dgvRiwayat.ReadOnly              = True
        Me.dgvRiwayat.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRiwayat.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRiwayat.Font                  = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvRiwayat.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvRiwayat.EnableHeadersVisualStyles               = False
        Me.dgvRiwayat.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvRiwayat.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)
        Me.dgvRiwayat.DefaultCellStyle.SelectionBackColor     = System.Drawing.Color.FromArgb(50, 40, 20)
        Me.dgvRiwayat.DefaultCellStyle.SelectionForeColor     = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.dgvRiwayat.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 24, 34)

        ' ============================================================
        '  PANEL DETAIL KANAN
        ' ============================================================
        Me.pnlDetail.Name      = "pnlDetail"
        Me.pnlDetail.Dock      = System.Windows.Forms.DockStyle.Right
        Me.pnlDetail.Width     = 300
        Me.pnlDetail.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.pnlDetail.Padding   = New System.Windows.Forms.Padding(14, 14, 14, 10)
        Me.pnlDetail.AutoScroll = True

        Dim MakeLbl = Function(lbl As Label, txt As String, y As Integer,
                               isCap As Boolean) As Label
            lbl.Text      = txt
            lbl.AutoSize  = True
            lbl.Location  = New System.Drawing.Point(14, y)
            If isCap Then
                lbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
                lbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
            Else
                lbl.Font      = New System.Drawing.Font("Segoe UI", 10)
                lbl.ForeColor = System.Drawing.Color.FromArgb(200, 200, 216)
            End If
            Return lbl
        End Function

        Me.lblDetTitle.Name      = "lblDetTitle"
        Me.lblDetTitle.Text      = "Detail Transaksi"
        Me.lblDetTitle.Font      = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.lblDetTitle.ForeColor = System.Drawing.Color.FromArgb(232, 232, 240)
        Me.lblDetTitle.AutoSize  = True
        Me.lblDetTitle.Location  = New System.Drawing.Point(14, 14)

        Me.lblDetNoTrxLbl  = MakeLbl(New System.Windows.Forms.Label(), "NO. TRANSAKSI", 44, True)
        Me.lblDetNoTrx     = MakeLbl(New System.Windows.Forms.Label(), "-", 60, False)
        Me.lblDetNoTrx.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.lblDetNoTrx.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0)

        Me.lblDetPelLbl    = MakeLbl(New System.Windows.Forms.Label(), "PELANGGAN", 90, True)
        Me.lblDetPelanggan = MakeLbl(New System.Windows.Forms.Label(), "-", 106, False)

        Me.lblDetHpLbl  = MakeLbl(New System.Windows.Forms.Label(), "NO. HP", 132, True)
        Me.lblDetNoHp   = MakeLbl(New System.Windows.Forms.Label(), "-", 148, False)

        Me.lblDetJenisLbl = MakeLbl(New System.Windows.Forms.Label(), "JENIS", 174, True)
        Me.lblDetJenis    = MakeLbl(New System.Windows.Forms.Label(), "-", 190, False)

        Me.lblDetWaktuLbl = MakeLbl(New System.Windows.Forms.Label(), "WAKTU", 216, True)
        Me.lblDetWaktu    = MakeLbl(New System.Windows.Forms.Label(), "-", 232, False)

        Me.lblDetStatusLbl = MakeLbl(New System.Windows.Forms.Label(), "STATUS BAYAR", 258, True)
        Me.lblDetStatus    = MakeLbl(New System.Windows.Forms.Label(), "-", 274, False)
        Me.lblDetStatus.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)

        ' Divider 1
        Dim div1 As New Panel()
        div1.Size      = New System.Drawing.Size(270, 1)
        div1.Location  = New System.Drawing.Point(14, 302)
        div1.BackColor = System.Drawing.Color.FromArgb(30, 33, 48)

        Me.lblDetPartLbl.Name      = "lblDetPartLbl"
        Me.lblDetPartLbl.Text      = "DAFTAR PART"
        Me.lblDetPartLbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblDetPartLbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDetPartLbl.AutoSize  = True
        Me.lblDetPartLbl.Location  = New System.Drawing.Point(14, 312)

        Me.dgvDetail.Name             = "dgvDetail"
        Me.dgvDetail.Location         = New System.Drawing.Point(14, 330)
        Me.dgvDetail.Size             = New System.Drawing.Size(268, 130)
        Me.dgvDetail.Anchor           = System.Windows.Forms.AnchorStyles.Top Or
                                        System.Windows.Forms.AnchorStyles.Left Or
                                        System.Windows.Forms.AnchorStyles.Right
        Me.dgvDetail.BackgroundColor  = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvDetail.BorderStyle      = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.GridColor        = System.Drawing.Color.FromArgb(30, 33, 48)
        Me.dgvDetail.RowHeadersVisible    = False
        Me.dgvDetail.AllowUserToAddRows    = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.ReadOnly              = True
        Me.dgvDetail.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetail.Font                  = New System.Drawing.Font("Segoe UI", 8)
        Me.dgvDetail.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvDetail.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.dgvDetail.ColumnHeadersDefaultCellStyle.Font      = New System.Drawing.Font("Segoe UI", 7, System.Drawing.FontStyle.Bold)
        Me.dgvDetail.EnableHeadersVisualStyles               = False
        Me.dgvDetail.DefaultCellStyle.BackColor              = System.Drawing.Color.FromArgb(19, 21, 31)
        Me.dgvDetail.DefaultCellStyle.ForeColor              = System.Drawing.Color.FromArgb(138, 153, 153)

        ' Panel Info Servis (kondisional)
        Me.pnlServisInfo.Name      = "pnlServisInfo"
        Me.pnlServisInfo.Location  = New System.Drawing.Point(14, 470)
        Me.pnlServisInfo.Size      = New System.Drawing.Size(268, 100)
        Me.pnlServisInfo.BackColor = System.Drawing.Color.Transparent
        Me.pnlServisInfo.Visible   = False

        Dim div2 As New Panel()
        div2.Size      = New System.Drawing.Size(268, 1)
        div2.Location  = New System.Drawing.Point(0, 0)
        div2.BackColor = System.Drawing.Color.FromArgb(30, 33, 48)

        Me.lblDetServisLbl.Name      = "lblDetServisLbl"
        Me.lblDetServisLbl.Text      = "MOTOR"
        Me.lblDetServisLbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblDetServisLbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDetServisLbl.AutoSize  = True
        Me.lblDetServisLbl.Location  = New System.Drawing.Point(0, 10)

        Me.lblDetServis.Name      = "lblDetServis"
        Me.lblDetServis.Text      = "-"
        Me.lblDetServis.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDetServis.ForeColor = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.lblDetServis.AutoSize  = True
        Me.lblDetServis.Location  = New System.Drawing.Point(0, 26)

        Me.lblDetBiayaLbl.Name      = "lblDetBiayaLbl"
        Me.lblDetBiayaLbl.Text      = "BIAYA JASA"
        Me.lblDetBiayaLbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblDetBiayaLbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDetBiayaLbl.AutoSize  = True
        Me.lblDetBiayaLbl.Location  = New System.Drawing.Point(0, 48)

        Me.lblDetBiayaJasa.Name      = "lblDetBiayaJasa"
        Me.lblDetBiayaJasa.Text      = "-"
        Me.lblDetBiayaJasa.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDetBiayaJasa.ForeColor = System.Drawing.Color.FromArgb(200, 200, 216)
        Me.lblDetBiayaJasa.AutoSize  = True
        Me.lblDetBiayaJasa.Location  = New System.Drawing.Point(140, 48)

        Me.lblDetMotorLbl.Name      = "lblDetMotorLbl"
        Me.lblDetMotorLbl.Text      = "STATUS SERVIS"
        Me.lblDetMotorLbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblDetMotorLbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDetMotorLbl.AutoSize  = True
        Me.lblDetMotorLbl.Location  = New System.Drawing.Point(0, 70)

        Me.lblDetStatusMotor.Name      = "lblDetStatusMotor"
        Me.lblDetStatusMotor.Text      = "-"
        Me.lblDetStatusMotor.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblDetStatusMotor.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.lblDetStatusMotor.AutoSize  = True
        Me.lblDetStatusMotor.Location  = New System.Drawing.Point(140, 70)

        Me.pnlServisInfo.Controls.AddRange({
            div2,
            Me.lblDetServisLbl, Me.lblDetServis,
            Me.lblDetBiayaLbl,  Me.lblDetBiayaJasa,
            Me.lblDetMotorLbl,  Me.lblDetStatusMotor
        })

        ' Total bayar
        Me.lblDetTotalLbl.Name      = "lblDetTotalLbl"
        Me.lblDetTotalLbl.Text      = "TOTAL BAYAR"
        Me.lblDetTotalLbl.Font      = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblDetTotalLbl.ForeColor = System.Drawing.Color.FromArgb(85, 102, 119)
        Me.lblDetTotalLbl.AutoSize  = True
        Me.lblDetTotalLbl.Location  = New System.Drawing.Point(14, 580)

        Me.lblDetTotal.Name      = "lblDetTotal"
        Me.lblDetTotal.Text      = "-"
        Me.lblDetTotal.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        Me.lblDetTotal.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0)
        Me.lblDetTotal.AutoSize  = True
        Me.lblDetTotal.Location  = New System.Drawing.Point(14, 596)

        Me.pnlDetail.Controls.AddRange({
            Me.lblDetTitle,
            Me.lblDetNoTrxLbl,  Me.lblDetNoTrx,
            Me.lblDetPelLbl,    Me.lblDetPelanggan,
            Me.lblDetHpLbl,     Me.lblDetNoHp,
            Me.lblDetJenisLbl,  Me.lblDetJenis,
            Me.lblDetWaktuLbl,  Me.lblDetWaktu,
            Me.lblDetStatusLbl, Me.lblDetStatus,
            div1,
            Me.lblDetPartLbl,   Me.dgvDetail,
            Me.pnlServisInfo,
            Me.lblDetTotalLbl,  Me.lblDetTotal
        })

        Me.pnlBody.Controls.Add(Me.dgvRiwayat)
        Me.pnlBody.Controls.Add(Me.pnlDetail)

        ' ============================================================
        '  STATUS BAR
        ' ============================================================
        Me.pnlStatusBar.Name      = "pnlStatusBar"
        Me.pnlStatusBar.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Height    = 26
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(13, 15, 24)

        Me.lblStatusBar.Name      = "lblStatusBar"
        Me.lblStatusBar.Text      = "0 transaksi"
        Me.lblStatusBar.Font      = New System.Drawing.Font("Segoe UI", 8)
        Me.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(68, 85, 102)
        Me.lblStatusBar.AutoSize  = True
        Me.lblStatusBar.Location  = New System.Drawing.Point(12, 6)

        Me.pnlStatusBar.Controls.Add(Me.lblStatusBar)

        ' ============================================================
        '  TAMBAHKAN KE FORM
        ' ============================================================
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlStatusBar)

        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlServisInfo.ResumeLayout(False)
        Me.pnlServisInfo.PerformLayout()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlStatusBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlToolbar       As System.Windows.Forms.Panel
    Friend WithEvents lblDari          As System.Windows.Forms.Label
    Friend WithEvents dtpDari          As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampai        As System.Windows.Forms.Label
    Friend WithEvents dtpSampai        As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampilkan     As System.Windows.Forms.Button
    Friend WithEvents btnHariIni       As System.Windows.Forms.Button
    Friend WithEvents lblHint          As System.Windows.Forms.Label
    Friend WithEvents pnlBody          As System.Windows.Forms.Panel
    Friend WithEvents dgvRiwayat       As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDetail        As System.Windows.Forms.Panel
    Friend WithEvents lblDetTitle      As System.Windows.Forms.Label
    Friend WithEvents lblDetNoTrxLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetNoTrx      As System.Windows.Forms.Label
    Friend WithEvents lblDetPelLbl     As System.Windows.Forms.Label
    Friend WithEvents lblDetPelanggan  As System.Windows.Forms.Label
    Friend WithEvents lblDetHpLbl      As System.Windows.Forms.Label
    Friend WithEvents lblDetNoHp       As System.Windows.Forms.Label
    Friend WithEvents lblDetJenisLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetJenis      As System.Windows.Forms.Label
    Friend WithEvents lblDetWaktuLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetWaktu      As System.Windows.Forms.Label
    Friend WithEvents lblDetStatusLbl  As System.Windows.Forms.Label
    Friend WithEvents lblDetStatus     As System.Windows.Forms.Label
    Friend WithEvents lblDetPartLbl    As System.Windows.Forms.Label
    Friend WithEvents dgvDetail        As System.Windows.Forms.DataGridView
    Friend WithEvents pnlServisInfo    As System.Windows.Forms.Panel
    Friend WithEvents lblDetServisLbl  As System.Windows.Forms.Label
    Friend WithEvents lblDetServis     As System.Windows.Forms.Label
    Friend WithEvents lblDetBiayaLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetBiayaJasa  As System.Windows.Forms.Label
    Friend WithEvents lblDetMotorLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetStatusMotor As System.Windows.Forms.Label
    Friend WithEvents lblDetTotalLbl   As System.Windows.Forms.Label
    Friend WithEvents lblDetTotal      As System.Windows.Forms.Label
    Friend WithEvents pnlStatusBar     As System.Windows.Forms.Panel
    Friend WithEvents lblStatusBar     As System.Windows.Forms.Label

End Class
