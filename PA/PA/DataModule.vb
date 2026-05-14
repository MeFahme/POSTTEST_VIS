Imports MySqlConnector

Module DataModule
    Public Sub LoadDashboard(ByVal lblTrx As Label, ByVal lblMotor As Label, ByVal lblStok As Label)
        Try
            BukaKoneksi()
            Dim sqlTrx As String = "SELECT COUNT(*) FROM transaksi WHERE DATE(tgl_transaksi) = CURDATE()"
            Using cmd As New MySqlCommand(sqlTrx, conn)
                lblTrx.Text = cmd.ExecuteScalar().ToString()
            End Using

            Dim sqlMotor As String = "SELECT COUNT(*) FROM servis WHERE status <> 'Selesai'"
            Using cmd As New MySqlCommand(sqlMotor, conn)
                lblMotor.Text = cmd.ExecuteScalar().ToString()
            End Using

            Dim sqlStok As String = "SELECT COUNT(*) FROM sparepart WHERE stok < 5"
            Using cmd As New MySqlCommand(sqlStok, conn)
                lblStok.Text = cmd.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            MsgBox("Gagal memuat dashboard: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Public Sub LoadToDGV(query As String, dgv As DataGridView)
        Try
            BukaKoneksi()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("Gagal memuat tabel: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Public Function EksekusiSQL(query As String, params As MySqlParameter()) As Boolean
        Try
            BukaKoneksi()
            cmd = New MySqlCommand(query, conn)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Operasi Gagal: " & ex.Message)
            Return False
        Finally
            TutupKoneksi()
        End Try
    End Function

    Public Sub FilterDGV(query As String, dgv As DataGridView)
        Try
            BukaKoneksi()
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            adapter.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox("Gagal memfilter data: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub
End Module