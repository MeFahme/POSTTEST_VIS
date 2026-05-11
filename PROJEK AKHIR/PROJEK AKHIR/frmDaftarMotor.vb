Imports MySqlConnector
Public Class frmDaftarMotor

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmDaftarMotor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Daftar Motor — Mekanik: " & frmLogin.SessionNama
        MuatMotorAktif()
    End Sub

    ' ================================================================
    '  MUAT DATA TAB AKTIF
    ' ================================================================
    Private Sub MuatMotorAktif()
        Dim dt As DataTable = GetServisByMekanik(frmLogin.SessionIdUser)
        If dt Is Nothing Then Exit Sub

        dgvMotorAktif.DataSource = dt
        AturKolom(dgvMotorAktif)
        WarnaiStatus(dgvMotorAktif)
        lblStatusBar.Text = "Motor aktif: " & dgvMotorAktif.Rows.Count &
                            "   |   Double-klik baris untuk buka detail servis"
    End Sub

    Private Sub MuatMotorSelesai()
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim sql As String =
                "SELECT no_servis, nama_pelanggan, no_polisi, merk_motor, status, tgl_selesai " &
                "FROM servis WHERE id_mekanik = @id AND status = 'selesai' " &
                "ORDER BY tgl_selesai DESC"

            ' PERBAIKAN: Hapus awalan 'MySql.Data.MySqlClient'
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@id", frmLogin.SessionIdUser)

                ' PERBAIKAN: Gunakan MySqlDataAdapter langsung
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvMotorSelesai.DataSource = dt
                AturKolom(dgvMotorSelesai)
                WarnaiStatus(dgvMotorSelesai)
            End Using
        Catch ex As Exception
            MsgBox("Error muat motor selesai: " & ex.Message)
        End Try
    End Sub

    Private Sub AturKolom(dgv As DataGridView)
        With dgv
            If .Columns.Contains("no_servis") Then .Columns("no_servis").HeaderText = "No. Servis"
            If .Columns.Contains("nama_pelanggan") Then .Columns("nama_pelanggan").HeaderText = "Pelanggan"
            If .Columns.Contains("no_polisi") Then .Columns("no_polisi").HeaderText = "No. Polisi"
            If .Columns.Contains("merk_motor") Then .Columns("merk_motor").HeaderText = "Motor"
            If .Columns.Contains("status") Then .Columns("status").HeaderText = "Status"
            If .Columns.Contains("tgl_masuk") Then .Columns("tgl_masuk").HeaderText = "Tgl Masuk"
            If .Columns.Contains("tgl_selesai") Then .Columns("tgl_selesai").HeaderText = "Tgl Selesai"
            If .Columns.Contains("keluhan") Then .Columns("keluhan").Visible = False
        End With
    End Sub

    Private Sub WarnaiStatus(dgv As DataGridView)
        For Each row As DataGridViewRow In dgv.Rows
            If row.IsNewRow Then Continue For
            Select Case row.Cells("status").Value?.ToString()
                Case "antri"
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(22, 24, 34)
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(119, 136, 153)
                Case "proses"
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(30, 24, 12)
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 140, 0)
                Case "menunggu_part"
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(30, 14, 14)
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(231, 76, 60)
                Case "selesai"
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(14, 28, 20)
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(46, 204, 113)
            End Select
        Next
    End Sub

    ' ================================================================
    '  TAB CONTROL
    ' ================================================================
    Private Sub tabMotor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMotor.SelectedIndexChanged
        Select Case tabMotor.SelectedIndex
            Case 0 : MuatMotorAktif()
            Case 1 : MuatMotorSelesai()
        End Select
    End Sub

    ' ================================================================
    '  DOUBLE KLIK BARIS — buka frmDetailServis
    ' ================================================================
    Private Sub dgvMotorAktif_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMotorAktif.CellDoubleClick
        BukaDetailServis(dgvMotorAktif, e.RowIndex)
    End Sub

    Private Sub dgvMotorSelesai_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMotorSelesai.CellDoubleClick
        BukaDetailServis(dgvMotorSelesai, e.RowIndex)
    End Sub

    Private Sub BukaDetailServis(dgv As DataGridView, rowIndex As Integer)
        If rowIndex < 0 Then Exit Sub

        Dim noServis As String = dgv.Rows(rowIndex).Cells("no_servis").Value?.ToString()
        If String.IsNullOrEmpty(noServis) Then Exit Sub

        Dim frm As New frmDetailServis(noServis)
        frm.ShowDialog(Me)

        ' Refresh setelah form detail ditutup
        If tabMotor.SelectedIndex = 0 Then
            MuatMotorAktif()
        Else
            MuatMotorSelesai()
        End If
    End Sub

    ' ================================================================
    '  TOMBOL REFRESH
    ' ================================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If tabMotor.SelectedIndex = 0 Then
            MuatMotorAktif()
        Else
            MuatMotorSelesai()
        End If
    End Sub

End Class
