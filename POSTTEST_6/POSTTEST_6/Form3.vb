Public Class Form3
    Private _mode As String = "Lihat"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPelanggan()
        SetModeForm("Lihat")
    End Sub

    Private Sub TampilPelanggan()
        dgvPelanggan.DataSource = GetAllPelanggan()
        lblJumlahData.Text = "Total Pelanggan: " & dgvPelanggan.RowCount
        AturKolomGrid()
    End Sub

    Private Sub AturKolomGrid()
        If dgvPelanggan.Columns.Count = 0 Then Exit Sub
    End Sub

    Private Sub SetModeForm(mode As String)
        _mode = mode
        Select Case mode
            Case "Lihat"
                txtKodePelanggan.Enabled = False
                txtNamaPelanggan.Enabled = False
                txtNoHP.Enabled = False
                txtAlamat.Enabled = False
                txtEmail.Enabled = False

                btnSimpan.Enabled = False
                btnBatal.Enabled = False
                btnTambah.Enabled = True
                btnUbah.Enabled = True
                btnHapus.Enabled = True

            Case "Tambah"
                BersihkanForm()
                txtKodePelanggan.Text = GenerateKodePelanggan()
                txtKodePelanggan.Enabled = False
                txtNamaPelanggan.Enabled = True
                txtNoHP.Enabled = True
                txtAlamat.Enabled = True
                txtEmail.Enabled = True

                btnSimpan.Enabled = True
                btnBatal.Enabled = True
                btnTambah.Enabled = False
                btnUbah.Enabled = False
                btnHapus.Enabled = False
                txtNamaPelanggan.Focus()

            Case "Ubah"
                txtKodePelanggan.Enabled = False
                txtNamaPelanggan.Enabled = True
                txtNoHP.Enabled = True
                txtAlamat.Enabled = True
                txtEmail.Enabled = True

                btnSimpan.Enabled = True
                btnBatal.Enabled = True
                btnTambah.Enabled = False
                btnUbah.Enabled = False
                btnHapus.Enabled = False
                txtNamaPelanggan.Focus()
        End Select

        ErrorProvider1.Clear()
    End Sub

    Private Sub BersihkanForm()
        txtKodePelanggan.Clear()
        txtNamaPelanggan.Clear()
        txtNoHP.Clear()
        txtAlamat.Clear()
        txtEmail.Clear()
        dgvRiwayat.DataSource = Nothing
        lblRiwayat.Text = "Riwayat Transaksi: -"
    End Sub

    Private Sub dgvPelanggan_CellClick(sender As Object,
                                       e As DataGridViewCellEventArgs) _
                                       Handles dgvPelanggan.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvPelanggan.Rows(e.RowIndex)

        txtKodePelanggan.Text = row.Cells("KodePelanggan").Value.ToString()
        txtNamaPelanggan.Text = row.Cells("NamaPelanggan").Value.ToString()
        txtNoHP.Text = row.Cells("NoHP").Value.ToString()
        txtAlamat.Text = If(row.Cells("Alamat").Value IsNot DBNull.Value,
                                   row.Cells("Alamat").Value.ToString(), "")
        txtEmail.Text = If(row.Cells("Email").Value IsNot DBNull.Value,
                                   row.Cells("Email").Value.ToString(), "")
        TampilRiwayat(txtKodePelanggan.Text)
    End Sub

    Private Sub TampilRiwayat(kodePelanggan As String)
        Dim dt As DataTable = GetRiwayatPelanggan(kodePelanggan)
        dgvRiwayat.DataSource = dt

        If dgvRiwayat.Columns.Contains("TotalHarga") Then
            dgvRiwayat.Columns("TotalHarga").DefaultCellStyle.Format = "N0"
            dgvRiwayat.Columns("TotalHarga").DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight
        End If

        lblRiwayat.Text = "Riwayat Transaksi: " & dt.Rows.Count & " nota"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        SetModeForm("Tambah")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodePelanggan.Text.Trim() = "" Then
            MessageBox.Show("Pilih pelanggan terlebih dahulu dari tabel!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        SetModeForm("Ubah")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiFormPelanggan() Then Exit Sub

        Dim kode As String = txtKodePelanggan.Text.Trim()
        Dim nama As String = txtNamaPelanggan.Text.Trim()
        Dim hp As String = txtNoHP.Text.Trim()
        Dim adr As String = txtAlamat.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()

        If _mode = "Tambah" Then
            If KodePelangganSudahAda(kode) Then
                MessageBox.Show("Kode pelanggan sudah digunakan!",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If SimpanPelanggan(kode, nama, hp, adr, email) Then
                MessageBox.Show("Data pelanggan berhasil disimpan!",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPelanggan()
                SetModeForm("Lihat")
            End If

        ElseIf _mode = "Ubah" Then
            If UbahPelanggan(kode, nama, hp, adr, email) Then
                MessageBox.Show("Data pelanggan berhasil diubah!",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPelanggan()
                SetModeForm("Lihat")
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePelanggan.Text.Trim() = "" Then
            MessageBox.Show("Pilih pelanggan terlebih dahulu dari tabel!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Hapus pelanggan " & txtNamaPelanggan.Text & "?",
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            If HapusPelanggan(txtKodePelanggan.Text.Trim()) Then
                MessageBox.Show("Pelanggan berhasil dihapus!",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BersihkanForm()
                TampilPelanggan()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        SetModeForm("Lihat")
        BersihkanForm()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilPelanggan()
        Else
            dgvPelanggan.DataSource = FilterPelanggan(txtSearch.Text.Trim())
            lblJumlahData.Text = "Total Pelanggan: " & dgvPelanggan.RowCount
            AturKolomGrid()
        End If
    End Sub

    Private Sub btnResetSearch_Click(sender As Object, e As EventArgs) Handles btnResetSearch.Click
        txtSearch.Clear()
        TampilPelanggan()
    End Sub

    Private Function ValidasiFormPelanggan() As Boolean
        Dim namaOK As Boolean = ValidasiTextBox(ErrorProvider1, txtNamaPelanggan,
                                                "Nama Pelanggan tidak boleh kosong")
        Dim hpOK As Boolean = ValidasiTextBox(ErrorProvider1, txtNoHP,
                                                "No. HP tidak boleh kosong")
        Return namaOK And hpOK
    End Function

    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Hide
        Form1.Show
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim konfirmasi As DialogResult =
                MessageBox.Show("Keluar dari aplikasi?",
                                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.No Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
