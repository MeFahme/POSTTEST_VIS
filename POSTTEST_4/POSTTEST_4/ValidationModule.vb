Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
    ep As ErrorProvider,
    tbNama As TextBox,
    tbUmur As TextBox,
    tbIdAnggota As TextBox,
    cboKomunitas As ComboBox,
    rbCowo As RadioButton,
    rbCewe As RadioButton
    ) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, tbNama, "Nama tidak boleh kosong")
        Dim umurValid As Boolean = ValidasiTextBox(ep, tbUmur, "Umur tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ep, tbIdAnggota, "ID Anggota tidak boleh kosong")

        Dim komunitasValid As Boolean = True
        If cboKomunitas.SelectedIndex = -1 Then
            ep.SetError(cboKomunitas, "Pilih jenis komunitas/divisi")
            komunitasValid = False
        Else
            ep.SetError(cboKomunitas, "")
        End If

        Dim genderValid As Boolean = rbCowo.Checked Or rbCewe.Checked
        If Not genderValid Then
            ep.SetError(rbCewe, "Pilih jenis kelamin")
        Else
            ep.SetError(rbCewe, "")
        End If

        Return namaValid And umurValid And idValid And komunitasValid And genderValid
    End Function

    Public Function ValidasiTabKontak(
    ep As ErrorProvider,
    mtbNoHP As MaskedTextBox,
    tbEmail As TextBox,
    tbAlamat As TextBox
    ) As Boolean

        Dim noHpValid As Boolean = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
        Dim emailValid As Boolean = ValidasiTextBox(ep, tbEmail, "Email tidak boleh kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(ep, tbAlamat, "Alamat tidak boleh kosong")

        Return noHpValid And emailValid And alamatValid
    End Function

End Module