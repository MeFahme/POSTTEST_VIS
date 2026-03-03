<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        gbTambah = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        gbHapus = New GroupBox()
        Label3 = New Label()
        btnHapus = New Button()
        txtJudulHapus = New TextBox()
        Label4 = New Label()
        gbTambah.SuspendLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        gbHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbTambah
        ' 
        gbTambah.BackColor = Color.White
        gbTambah.Controls.Add(btnTambah)
        gbTambah.Controls.Add(txtGenre)
        gbTambah.Controls.Add(txtJudulTambah)
        gbTambah.Controls.Add(Label2)
        gbTambah.Controls.Add(Label1)
        gbTambah.FlatStyle = FlatStyle.Flat
        gbTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbTambah.Location = New Point(12, 12)
        gbTambah.Name = "gbTambah"
        gbTambah.Size = New Size(245, 199)
        gbTambah.TabIndex = 0
        gbTambah.TabStop = False
        gbTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.RoyalBlue
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(6, 154)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(233, 23)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtGenre
        ' 
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Location = New Point(6, 119)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(233, 23)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BorderStyle = BorderStyle.FixedSingle
        txtJudulTambah.Location = New Point(6, 64)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(233, 23)
        txtJudulTambah.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 1
        Label2.Text = "Genre Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AllowUserToDeleteRows = False
        dgvBuku.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvBuku.BackgroundColor = Color.White
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBuku.DefaultCellStyle = DataGridViewCellStyle1
        dgvBuku.GridColor = Color.Black
        dgvBuku.Location = New Point(12, 230)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.Size = New Size(505, 151)
        dgvBuku.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.FillWeight = 150.0F
        Column1.HeaderText = "Judul Buku"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.FillWeight = 150.0F
        Column2.HeaderText = "Genre"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' gbHapus
        ' 
        gbHapus.BackColor = Color.White
        gbHapus.BackgroundImageLayout = ImageLayout.None
        gbHapus.Controls.Add(Label3)
        gbHapus.Controls.Add(btnHapus)
        gbHapus.Controls.Add(txtJudulHapus)
        gbHapus.Controls.Add(Label4)
        gbHapus.FlatStyle = FlatStyle.Flat
        gbHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHapus.ForeColor = Color.Black
        gbHapus.Location = New Point(272, 12)
        gbHapus.Name = "gbHapus"
        gbHapus.Size = New Size(245, 199)
        gbHapus.TabIndex = 4
        gbHapus.TabStop = False
        gbHapus.Text = "Hapus Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 15)
        Label3.TabIndex = 6
        Label3.Text = "Pastikan Judul Buku Sesuai Dengan Daftar"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(6, 154)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(233, 23)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BorderStyle = BorderStyle.FixedSingle
        txtJudulHapus.Location = New Point(6, 64)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(233, 23)
        txtJudulHapus.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 0
        Label4.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(527, 398)
        Controls.Add(gbHapus)
        Controls.Add(dgvBuku)
        Controls.Add(gbTambah)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Buku"
        gbTambah.ResumeLayout(False)
        gbTambah.PerformLayout()
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        gbHapus.ResumeLayout(False)
        gbHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbTambah As GroupBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents gbHapus As GroupBox
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
