Public Class Form2
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
        Dim hasil = MessageBox.Show(
        "Apakah Anda yakin ingin keluar dari aplikasi?",
        "Konfirmasi Keluar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If hasil = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class