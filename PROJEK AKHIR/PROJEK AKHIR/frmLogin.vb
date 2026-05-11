Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' ================================================================
    '  VARIABEL SESSION — diisi saat login berhasil
    '  Akses dari form lain: frmLogin.SessionNama, dst.
    ' ================================================================
    Public Shared SessionIdUser As Integer = 0
    Public Shared SessionNama   As String  = ""
    Public Shared SessionRole   As String  = ""

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BukaKoneksi() Then
            lblStatus.Text      = "● Terhubung ke database"
            lblStatus.ForeColor = Color.FromArgb(46, 204, 113)
        Else
            lblStatus.Text      = "● Gagal terhubung ke database"
            lblStatus.ForeColor = Color.FromArgb(231, 76, 60)
        End If
        txtUsername.Select()
    End Sub

    ' ================================================================
    '  PROSES LOGIN
    ' ================================================================
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        ProsesLogin()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then ProsesLogin()
    End Sub

    Private Sub ProsesLogin()
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Username tidak boleh kosong.", MsgBoxStyle.Exclamation, "Peringatan")
            txtUsername.Focus() : Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Password tidak boleh kosong.", MsgBoxStyle.Exclamation, "Peringatan")
            txtPassword.Focus() : Exit Sub
        End If

        Dim user As DataRow = Login(txtUsername.Text.Trim(), txtPassword.Text.Trim())

        If user IsNot Nothing Then
            SessionIdUser = Convert.ToInt32(user("id_user"))
            SessionNama   = user("nama").ToString()
            SessionRole   = user("role").ToString()

            Me.DialogResult = DialogResult.OK
            Me.Close()
            Me.Hide()
        Else
            MsgBox("Username atau password salah.", MsgBoxStyle.Critical, "Login Gagal")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    ' ================================================================
    '  TOMBOL KELUAR
    ' ================================================================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then
            TutupKoneksi()
            Application.Exit()
        End If
    End Sub

    ' ================================================================
    '  FORM CLOSING
    ' ================================================================
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso SessionRole = "" Then
            TutupKoneksi()
            Application.Exit()
        End If
    End Sub

End Class
