Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    Public Function cariJudul(ByVal judulCari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0) = judulCari Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub hapusBuku(ByVal index As Integer)
        If index >= 0 And index < jumlahBuku Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            daftarBuku(jumlahBuku, 0) = Nothing
            daftarBuku(jumlahBuku, 1) = Nothing
        End If
    End Sub
End Module