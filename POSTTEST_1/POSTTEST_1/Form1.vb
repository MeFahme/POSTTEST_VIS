Public Class Form1

    Dim ips As Double
    Dim totalIp As Double
    Dim ipk As Double
    Dim semesterInput As Integer = 0
    Dim hasil As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSemester.Text = "1"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Double.TryParse(txtIps.Text, ips) Then

            If ips >= 0 And ips <= 4.0 Then

                If semesterInput < 14 Then

                    totalIp += ips
                    semesterInput += 1
                    ipk = totalIp / semesterInput

                    If ipk >= 2.0 And ipk <= 2.75 Then
                        hasil = "Cukup"
                    ElseIf ipk > 2.75 And ipk <= 3.0 Then
                        hasil = "Memuaskan"
                    ElseIf ipk > 3.0 Then
                        hasil = "Sangat Memuaskan"
                    Else
                        hasil = "Mengecewakan"
                    End If

                    txtIpk.Text = ipk.ToString("F2")
                    lblHasil.Text = hasil
                    lblSemester.Text = (semesterInput + 1).ToString()

                    txtIps.Clear()
                    txtIps.Focus()

                Else
                    MessageBox.Show("Batas maksimal input adalah 14 semester!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtIps.Clear()
                End If

            Else
                MessageBox.Show("Masukkan IPS antara 0 - 4.00", "Rentang Nilai Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIps.Clear()
                txtIps.Focus()
            End If

        Else
            MessageBox.Show("Input harus angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIps.Clear()
            txtIps.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblSemester.Text = "1"
        totalIp = 0
        semesterInput = 0
        txtIpk.Text = "0"
        lblHasil.Text = "Keterangan"
        txtIps.Clear()
    End Sub

End Class