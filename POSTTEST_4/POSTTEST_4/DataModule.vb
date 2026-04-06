Imports System.IO
Imports System.Text
Module DataModule
    Public foto As String
    Public Function BuatRingkasan(
        nama As String,
        umur As String,
        tanggalLahir As String,
        idAnggota As String,
        jenisKomunitas As String,
        jenisKelamin As String,
        noHp As String,
        email As String,
        alamat As String,
        hobi As String
    ) As String

        Return "Nama            : " & nama & Environment.NewLine &
               "Umur            : " & umur & Environment.NewLine &
               "Tanggal Lahir   : " & tanggalLahir & Environment.NewLine &
               "ID Anggota      : " & idAnggota & Environment.NewLine &
               "Jenis Komunitas : " & jenisKomunitas & Environment.NewLine &
               "Jenis Kelamin   : " & jenisKelamin & Environment.NewLine &
               "Nomor HP        : " & noHp & Environment.NewLine &
               "Email           : " & email & Environment.NewLine &
               "Alamat          : " & alamat & Environment.NewLine &
               "Hobi            : " & hobi
    End Function

    Public Function BuatIsiFile(
    nama As String, umur As String, id As String, komunitas As String, gender As String,
    noHp As String, email As String, alamat As String, hobi As String
) As String
        Dim sb As New StringBuilder()
        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("Umur=" & umur.Trim())
        sb.AppendLine("ID=" & id.Trim())
        sb.AppendLine("Komunitas=" & komunitas)
        sb.AppendLine("Gender=" & gender)
        sb.AppendLine("NoHP=" & noHp)
        sb.AppendLine("Email=" & email.Trim())
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Hobi=" & hobi)
        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"
        sfd.FileName = namaFileDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data Anggota"

        If ofd.ShowDialog() <> DialogResult.OK Then Return Nothing

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

        Try
            Dim barisFile() As String = File.ReadAllLines(ofd.FileName)

            For Each baris As String In barisFile
                If String.IsNullOrWhiteSpace(baris) Then Continue For

                Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

                If bagian.Length = 2 Then
                    hasil(bagian(0).Trim()) = bagian(1).Trim()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Gagal membaca file: " & ex.Message)
            Return Nothing
        End Try

        Return hasil
    End Function


    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function

End Module