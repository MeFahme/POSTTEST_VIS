Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngkaDanTitik(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As Control, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As Control, pesan As String) As Boolean
        If cmb.Text.Trim() = "" Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    Public Function ValidasiFormPart(ep As ErrorProvider,
                                     txtKode As Control,
                                     txtNama As Control,
                                     cmbKategori As Control,
                                     cmbMerk As Control,
                                     txtHarga As Control,
                                     txtStok As Control) As Boolean

        Dim kodeOK As Boolean = ValidasiTextBox(ep, txtKode, "Kode Part tidak boleh kosong")
        Dim namaOK As Boolean = ValidasiTextBox(ep, txtNama, "Nama Part tidak boleh kosong")
        Dim katOK As Boolean = ValidasiComboBox(ep, cmbKategori, "Kategori harus dipilih")
        Dim merkOK As Boolean = ValidasiComboBox(ep, cmbMerk, "Merk harus dipilih")
        Dim hargaOK As Boolean = ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")
        Dim stokOK As Boolean = ValidasiTextBox(ep, txtStok, "Stok tidak boleh kosong")

        Return kodeOK And namaOK And katOK And merkOK And hargaOK And stokOK
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module