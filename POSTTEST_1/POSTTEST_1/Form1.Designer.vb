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
        Label1 = New Label()
        Label2 = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        txtIps = New TextBox()
        txtIpk = New TextBox()
        lblHasil = New Label()
        lblSemester = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(136, 84)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(61, 23)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(217, 84)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(61, 23)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIps
        ' 
        txtIps.Location = New Point(136, 45)
        txtIps.Name = "txtIps"
        txtIps.Size = New Size(142, 23)
        txtIps.TabIndex = 4
        ' 
        ' txtIpk
        ' 
        txtIpk.Enabled = False
        txtIpk.Location = New Point(136, 125)
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(142, 23)
        txtIpk.TabIndex = 5
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(171, 163)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(67, 15)
        lblHasil.TabIndex = 6
        lblHasil.Text = "Keterangan"
        ' 
        ' lblSemester
        ' 
        lblSemester.AutoSize = True
        lblSemester.Location = New Point(89, 48)
        lblSemester.Name = "lblSemester"
        lblSemester.Size = New Size(0, 15)
        lblSemester.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(354, 231)
        Controls.Add(lblSemester)
        Controls.Add(lblHasil)
        Controls.Add(txtIpk)
        Controls.Add(txtIps)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIps As TextBox
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents lblSemester As Label

End Class
