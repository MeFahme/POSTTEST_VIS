Module ValidationModule

    Public Sub TampilkanError(pesan As String)
        MessageBox.Show(pesan, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub TampilkanInfo(pesan As String)
        MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function IsEmpty(ParamArray controls As Control()) As Boolean
        For Each ctrl In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                TampilkanError("Harap isi semua kolom yang tersedia!")
                ctrl.Focus()
                Return True
            End If
        Next
        Return False
    End Function

    Public Function KonfirmasiKeluar() As Boolean
        Dim dialog As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Function CekKosong(ctrl As Control, err As ErrorProvider, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(ctrl.Text) Then
            err.SetError(ctrl, pesan)
            ctrl.Focus()
            Return True
        Else
            err.SetError(ctrl, "")
            Return False '
        End If
    End Function

End Module