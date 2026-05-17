Imports MySqlConnector
Public Class FormLogin
    Public Shared IDUserLogin As Integer
    Private Sub FormLogin_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ErrorProvider1.Clear()
        Dim adaError As Boolean = False
        If ValidationModule.CekKosong(txtUsername, ErrorProvider1, "Username tidak boleh kosong!") Or
       ValidationModule.CekKosong(txtPassword, ErrorProvider1, "Password tidak boleh kosong!") Then
            Exit Sub
        End If
        Try
            BukaKoneksi()
            Dim query As String = "SELECT * FROM users WHERE username = @user AND password = @pass"
            cmd = New MySqlCommand(query, conn)
            With cmd.Parameters
                .AddWithValue("@user", txtUsername.Text.Trim())
                .AddWithValue("@pass", txtPassword.Text.Trim())
            End With
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                IDUserLogin = dr("id_user")
                NamaUserLogin = dr("nama").ToString()
                RoleUserLogin = dr("role").ToString()
                dr.Close()
                ValidationModule.TampilkanInfo("Selamat Datang, " & NamaUserLogin)
                FormMain.Show()
                Me.Hide()
            Else
                dr.Close()
                ValidationModule.TampilkanError("Username atau Password salah!")
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        Catch ex As Exception
            ValidationModule.TampilkanError("Terjadi kesalahan login: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Visible = True Then
            If ValidationModule.KonfirmasiKeluar() = False Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
