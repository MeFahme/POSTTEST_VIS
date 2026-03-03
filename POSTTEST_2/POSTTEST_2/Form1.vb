Public Class Form1
    Private Sub tampilkanData()
        dgvBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulTambah.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            txtJudulTambah.Clear()
            txtGenre.Clear()
            txtJudulTambah.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulDihapus As String = txtJudulHapus.Text

        Dim index As Integer = cariJudul(judulDihapus)

        If index <> -1 Then
            hapusBuku(index)
            tampilkanData()
            txtJudulHapus.Clear()
            MessageBox.Show("Buku '" & judulDihapus & "' berhasil dihapus.", "Informasi")
            txtJudulHapus.Focus()
        Else
            MessageBox.Show("Buku dengan judul tersebut tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBuku.ColumnCount = 2
        dgvBuku.Columns(0).Name = "Judul Buku"
        dgvBuku.Columns(1).Name = "Genre"
    End Sub

End Class