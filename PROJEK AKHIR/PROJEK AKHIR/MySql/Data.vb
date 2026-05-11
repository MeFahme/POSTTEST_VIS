Imports MySqlConnector

Namespace MySql
    Friend Class Data
        Friend Class MySqlClient
            <Serializable>
            Friend Class MySqlException
                Inherits Exception

                Public Sub New()
                End Sub

                Public Sub New(message As String)
                    MyBase.New(message)
                End Sub

                Public Sub New(message As String, innerException As Exception)
                    MyBase.New(message, innerException)
                End Sub

                Friend Function Number() As Integer
                    Throw New NotImplementedException()
                End Function
            End Class

            Friend Class MySqlCommand
                Private sql As String
                Private koneksiDB As MySqlConnection

                Public Sub New(sql As String, koneksiDB As MySqlConnection)
                    Me.sql = sql
                    Me.koneksiDB = koneksiDB
                End Sub
            End Class
        End Class
    End Class
End Namespace
