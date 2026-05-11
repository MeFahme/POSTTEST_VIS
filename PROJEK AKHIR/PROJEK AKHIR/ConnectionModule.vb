Imports MySqlConnector

Module ConnectionModule

    ' ================================================================
    '  KONFIGURASI KONEKSI DATABASE
    '  Sesuaikan Server, Database, UserID, Password dengan milikmu
    ' ================================================================
    Private Const SERVER   As String = "localhost"
    Private Const DATABASE As String = "db_sparepart_motor"
    Private Const USERID   As String = "root"
    Private Const PASSWORD As String = ""

    Private Const CONNECTION_STRING As String =
        "Server=" & SERVER & ";" &
        "Database=" & DATABASE & ";" &
        "User ID=" & USERID & ";" &
        "Password=" & PASSWORD & ";" &
        "CharSet=utf8mb4;"

    Public KoneksiDB As MySqlConnection

    ' ================================================================
    '  BukaKoneksi
    ' ================================================================
    Public Function BukaKoneksi() As Boolean
        Try
            If KoneksiDB Is Nothing Then
                KoneksiDB = New MySqlConnection(CONNECTION_STRING)
            End If
            If KoneksiDB.State = ConnectionState.Closed Then
                KoneksiDB.Open()
            End If
            Return True
        Catch ex As MySqlException
            MessageBox.Show(
                "Gagal terhubung ke database!" & vbNewLine &
                "Detail: " & ex.Message,
                "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ================================================================
    '  TutupKoneksi
    ' ================================================================
    Public Sub TutupKoneksi()
        Try
            If KoneksiDB IsNot Nothing AndAlso
               KoneksiDB.State = ConnectionState.Open Then
                KoneksiDB.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' ================================================================
    '  CekKoneksi
    ' ================================================================
    Public Function CekKoneksi() As Boolean
        Try
            If KoneksiDB Is Nothing OrElse
               KoneksiDB.State = ConnectionState.Closed Then
                Return BukaKoneksi()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
