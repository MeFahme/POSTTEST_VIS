Imports System.IO

Public Class Form1

    ' VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        HanyaHuruf(e)
    End Sub

    ' VALIDASI INPUT Angka
    Private Sub tbUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUmur.KeyPress
        HanyaAngka(e)
    End Sub

    ' VALIDASI LANGSUNG
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles tbNama.TextChanged
        ValidasiTextBox(ErrorProvider1, tbNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub mtbNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtbNoHp.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbNoHp, "Nomor HP belum lengkap")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles tbAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, tbAlamat, "Alamat tidak boleh kosong")
    End Sub

    ' TOMBOL CETAK
    Private Sub btnSimpanDanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim isTab1Valid As Boolean = ValidasiSemuaInput(ErrorProvider1, tbNama, tbUmur, tbIdAnggota, cboJenisKomunitas, rbCowo, rbCewe)
        Dim isTab2Valid As Boolean = ValidasiTabKontak(ErrorProvider1, mtbNoHp, tbEmail, tbAlamat)

        If isTab1Valid And isTab2Valid Then
            Dim hasilCetak As DialogResult = MessageBox.Show(
            "Apakah Anda ingin melihat/cetak kartu komunitas?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If hasilCetak = DialogResult.Yes Then
                Dim kartu As New Form2()

                kartu.lblNama.Text = tbNama.Text
                kartu.lblUmur.Text = tbUmur.Text & " Tahun"
                kartu.lblID.Text = "ID: " & tbIdAnggota.Text
                kartu.lblKomunitas.Text = "Divisi: " & cboJenisKomunitas.SelectedItem.ToString()
                kartu.lblNoTelp.Text = mtbNoHp.Text

                Dim listHobi As New List(Of String)
                If cbBertani.Checked Then listHobi.Add("Bertani")
                If cbBerkebun.Checked Then listHobi.Add("Berkebun")
                If cbFotografi.Checked Then listHobi.Add("Fotografi")
                If cbPlogging.Checked Then listHobi.Add("Plogging")
                If cbForaging.Checked Then listHobi.Add("Foraging")
                If cbMemasak.Checked Then listHobi.Add("Memasak")
                If cbHiking.Checked Then listHobi.Add("Hiking")
                If cbDiving.Checked Then listHobi.Add("Diving")
                If cbBeekeeping.Checked Then listHobi.Add("Beekeeping")

                kartu.lblHobi.Text = "Aktivitas: " & String.Join(", ", listHobi)

                If picProfil.Image IsNot Nothing Then
                    kartu.picFotoKartu.Image = picProfil.Image
                    kartu.picFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
                End If

                kartu.ShowDialog()
            End If
        Else
            MessageBox.Show("Mohon lengkapi semua data wajib yang bertanda merah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If Not isTab1Valid Then TabControl1.SelectedIndex = 0 Else TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles menuBukaData.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        IsiDataKeForm(data)

        MessageBox.Show("File berhasil dibuka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ' LOAD DATA KE FORM
    Private Sub IsiDataKeForm(data As Dictionary(Of String, String))
        tbNama.Text = AmbilNilai(data, "Nama")
        tbIdAnggota.Text = AmbilNilai(data, "ID")
        mtbNoHp.Text = AmbilNilai(data, "NoHP")
        tbUmur.Text = AmbilNilai(data, "Umur")
        tbAlamat.Text = AmbilNilai(data, "Alamat")
        Dim komu As String = AmbilNilai(data, "Komunitas")
        If cboJenisKomunitas.Items.Contains(komu) Then
            cboJenisKomunitas.SelectedItem = komu
        Else
            cboJenisKomunitas.Text = komu
        End If

        Dim gen As String = AmbilNilai(data, "Gender")
        If gen = "Laki-laki" Then
            rbCowo.Checked = True
        ElseIf gen = "Perempuan" Then
            rbCewe.Checked = True
        End If

        mtbNoHp.Text = AmbilNilai(data, "NoHP")
        tbEmail.Text = AmbilNilai(data, "Email")
        tbAlamat.Text = AmbilNilai(data, "Alamat")

        Dim hobiStr As String = AmbilNilai(data, "Hobi")
        cbBertani.Checked = hobiStr.Contains("Bertani")
        cbBerkebun.Checked = hobiStr.Contains("Berkebun")
        cbFotografi.Checked = hobiStr.Contains("Fotografi")
        cbPlogging.Checked = hobiStr.Contains("Plogging")
        cbForaging.Checked = hobiStr.Contains("Foraging")
        cbMemasak.Checked = hobiStr.Contains("Memasak")
        cbHiking.Checked = hobiStr.Contains("Hiking")
        cbDiving.Checked = hobiStr.Contains("Diving")
        cbBeekeeping.Checked = hobiStr.Contains("Beekeeping")


    End Sub

    Private Sub btnSelanjutnya_Click(sender As Object, e As EventArgs) Handles btnSelanjutnya.Click

        If ValidasiSemuaInput(ErrorProvider1, tbNama, tbUmur, tbIdAnggota, cboJenisKomunitas, rbCowo, rbCewe) Then

            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            End If
        Else
            MessageBox.Show("Mohon lengkapi semua data wajib di halaman ini.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ValidasiTabKontak(ErrorProvider1, mtbNoHp, tbEmail, tbAlamat) Then
            If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                TabControl1.SelectedIndex += 1
            End If
        Else
            MessageBox.Show("Mohon lengkapi data Kontak & Info terlebih dahulu.",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TabControl1.SelectedIndex > 0 Then
            TabControl1.SelectedIndex -= 1
        End If
    End Sub

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
        Dim NamaFile As String = tbNama.Text.Trim()
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
            Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
            Dim destinationPath As String = Path.Combine(folderPath, fileName)
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            File.Copy(openFileDialog.FileName, destinationPath, True)
            DataModule.Foto = destinationPath
            picProfil.Image = Image.FromFile(destinationPath)
            MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub menuSimpanData_Click(sender As Object, e As EventArgs) Handles menuSimpanData.Click

        Dim isTab1Valid As Boolean = ValidasiSemuaInput(ErrorProvider1, tbNama, tbUmur, tbIdAnggota, cboJenisKomunitas, rbCowo, rbCewe)
        Dim isTab2Valid As Boolean = ValidasiTabKontak(ErrorProvider1, mtbNoHp, tbEmail, tbAlamat)

        If isTab1Valid And isTab2Valid Then

            Dim listHobi As New List(Of String)
            If cbBertani.Checked Then listHobi.Add("Bertani")
            If cbBerkebun.Checked Then listHobi.Add("Berkebun")
            If cbFotografi.Checked Then listHobi.Add("Fotografi")
            If cbPlogging.Checked Then listHobi.Add("Plogging")
            If cbForaging.Checked Then listHobi.Add("Foraging")
            If cbMemasak.Checked Then listHobi.Add("Memasak")
            If cbHiking.Checked Then listHobi.Add("Hiking")
            If cbDiving.Checked Then listHobi.Add("Diving")
            If cbBeekeeping.Checked Then listHobi.Add("Beekeeping")

            Dim hobiString As String = String.Join(";", listHobi)

            Dim namaInput As String = tbNama.Text.Trim()
            Dim namaFileOtomatis As String = "Kartu_" & namaInput & ".txt"

            Dim isi As String = BuatIsiFile(
            tbNama.Text,
            tbUmur.Text,
            tbIdAnggota.Text,
            cboJenisKomunitas.SelectedItem.ToString(),
            If(rbCowo.Checked, "Laki-laki", "Perempuan"),
            mtbNoHp.Text,
            tbEmail.Text,
            tbAlamat.Text,
            hobiString
        )

            If SimpanDataKeFile(SaveFileDialog1, isi, namaFileOtomatis) Then
                MessageBox.Show("Data berhasil disimpan ke file.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Mohon lengkapi data sebelum menyimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub menuLihatKartu_Click(sender As Object, e As EventArgs) Handles menuLihatKartu.Click
        Dim isTab1Valid As Boolean = ValidasiSemuaInput(ErrorProvider1, tbNama, tbUmur, tbIdAnggota, cboJenisKomunitas, rbCowo, rbCewe)
        Dim isTab2Valid As Boolean = ValidasiTabKontak(ErrorProvider1, mtbNoHp, tbEmail, tbAlamat)

        If isTab1Valid And isTab2Valid Then
            Dim hasilCetak As DialogResult = MessageBox.Show(
            "Apakah Anda ingin melihat/cetak kartu komunitas?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If hasilCetak = DialogResult.Yes Then
                Dim kartu As New Form2()

                kartu.lblNama.Text = tbNama.Text
                kartu.lblUmur.Text = tbUmur.Text & " Tahun"
                kartu.lblID.Text = "ID: " & tbIdAnggota.Text
                kartu.lblKomunitas.Text = "Divisi: " & cboJenisKomunitas.SelectedItem.ToString()
                kartu.lblNoTelp.Text = mtbNoHp.Text

                Dim listHobi As New List(Of String)
                If cbBertani.Checked Then listHobi.Add("Bertani")
                If cbBerkebun.Checked Then listHobi.Add("Berkebun")
                If cbFotografi.Checked Then listHobi.Add("Fotografi")
                If cbPlogging.Checked Then listHobi.Add("Plogging")
                If cbForaging.Checked Then listHobi.Add("Foraging")
                If cbMemasak.Checked Then listHobi.Add("Memasak")
                If cbHiking.Checked Then listHobi.Add("Hiking")
                If cbDiving.Checked Then listHobi.Add("Diving")
                If cbBeekeeping.Checked Then listHobi.Add("Beekeeping")

                kartu.lblHobi.Text = "Aktivitas: " & String.Join(", ", listHobi)

                If picProfil.Image IsNot Nothing Then
                    kartu.picFotoKartu.Image = picProfil.Image
                    kartu.picFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
                End If

                kartu.ShowDialog()
            End If
        Else
            MessageBox.Show("Mohon lengkapi semua data wajib yang bertanda merah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If Not isTab1Valid Then TabControl1.SelectedIndex = 0 Else TabControl1.SelectedIndex = 1
        End If
    End Sub

    Private Sub dtpLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpLahir.ValueChanged
        Dim tanggalLahir As DateTime = dtpLahir.Value
        Dim hariIni As DateTime = DateTime.Today
        Dim umur As Integer = hariIni.Year - tanggalLahir.Year

        If tanggalLahir > hariIni.AddYears(-umur) Then umur -= 1

        tbUmur.Text = umur.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpLahir.MaxDate = DateTime.Today
    End Sub
End Class