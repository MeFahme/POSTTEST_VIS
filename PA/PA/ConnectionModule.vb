Imports MySqlConnector

Module ConnectionModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public ds As DataSet

    Public NamaUserLogin As String = ""
    Public RoleUserLogin As String = ""
    Public IDUserLogin As Integer = 0

    Public connString As String = "server=localhost;user id=root;password=;database=db_sparepart_motor"

    Public Sub BukaKoneksi()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(connString)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal terhubung ke database: " & ex.Message)
        End Try
    End Sub

    Public Sub TutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module