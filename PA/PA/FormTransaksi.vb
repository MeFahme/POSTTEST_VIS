Imports MySqlConnector
Public Class FormTransaksi
    Dim hargaSatuanDipilih As Decimal = 0
    Dim dtCart As New DataTable
    Dim err As New ErrorProvider
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        pnlServis.Visible = False
        PersiapkanCart()
        GenerateNoTransaksi()
        LoadDataComboBox()
        lblInfoKasir.Text = "Kasir: " & NamaUserLogin
    End Sub
    Sub PersiapkanCart()
        dtCart = New DataTable
        dtCart.Columns.Add("ID")
        dtCart.Columns.Add("Merk")
        dtCart.Columns.Add("Nama Sparepart")
        dtCart.Columns.Add("Harga", GetType(Decimal))
        dtCart.Columns.Add("Qty", GetType(Integer))
        dtCart.Columns.Add("Subtotal", GetType(Decimal))
        dgvCart.DataSource = dtCart
        dgvCart.Columns("ID").Visible = False
        dgvCart.Columns(3).DefaultCellStyle.Format = "N0"
        dgvCart.Columns(5).DefaultCellStyle.Format = "N0"
        dgvCart.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Sub LoadDataComboBox()
        DataModule.LoadToComboBox("SELECT id_part, nama_part FROM sparepart WHERE stok > 0", cboPart, "nama_part", "id_part")
        DataModule.LoadToComboBox("SELECT id_user, nama FROM users WHERE role = 'Mekanik'", cboMekanik, "nama", "id_user")
        DataModule.LoadToComboBox("SELECT DISTINCT merk_motor FROM sparepart", cboMerk, "merk_motor", "merk_motor")
        cboPart.SelectedIndex = -1
        cboMerk.SelectedIndex = -1
        cboMekanik.SelectedIndex = -1
        lblTotalPart.Text = "Rp 0"
    End Sub
    Sub GenerateNoTransaksi()
        Dim tgl As String = Now.ToString("yyyyMMdd")
        Try
            BukaKoneksi()
            ' Menggunakan RIGHT untuk mengambil 3 digit nomor urut terakhir dari transaksi hari ini
            Dim sql As String = "SELECT MAX(RIGHT(no_transaksi, 3)) FROM transaksi WHERE no_transaksi LIKE 'TRX-" & tgl & "-%'"
            Dim cmd As New MySqlCommand(sql, conn)
            Dim objMax = cmd.ExecuteScalar()

            Dim urutan As Integer = 1
            If objMax IsNot DBNull.Value AndAlso objMax IsNot Nothing Then
                urutan = Convert.ToInt32(objMax) + 1
            End If

            ' Format disesuaikan dengan aturan: TRX-YYYYMMDD-XXX
            lblNoTransaksi.Text = "TRX-" & tgl & "-" & urutan.ToString("D3")
            lblNoServis.Text = "SRV-" & tgl & "-" & urutan.ToString("D3")

        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal Generate No Transaksi: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub
    Private Sub cboPart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPart.SelectedIndexChanged
        If cboPart.SelectedIndex <> -1 AndAlso cboPart.SelectedValue IsNot Nothing Then
            Try
                BukaKoneksi()
                Dim cmd As New MySqlCommand("SELECT harga_jual FROM sparepart WHERE id_part = @id", conn)
                cmd.Parameters.AddWithValue("@id", cboPart.SelectedValue)
                Dim harga = cmd.ExecuteScalar()

                If harga IsNot Nothing Then
                    hargaSatuanDipilih = CDec(harga)
                End If
            Catch
            Finally
                TutupKoneksi()
            End Try
        Else
            hargaSatuanDipilih = 0
        End If
    End Sub
    Private Sub btnTambahPart_Click(sender As Object, e As EventArgs) Handles btnTambahPart.Click
        If ValidationModule.CekKosong(cboPart, err, "Pilih sparepart!") Then Exit Sub
        If ValidationModule.CekKosong(txtQty, err, "Isi Qty!") Then Exit Sub
        Dim id As String = cboPart.SelectedValue.ToString()
        Dim merk As String = cboMerk.Text
        Dim nama As String = cboPart.Text
        Dim qty As Integer = CInt(txtQty.Text)
        Dim subtotal As Decimal = hargaSatuanDipilih * qty

        Dim existingRow As DataRow() = dtCart.Select("ID = '" & id & "'")
        If existingRow.Length > 0 Then
            existingRow(0)("Qty") += qty
            existingRow(0)("Subtotal") = existingRow(0)("Qty") * hargaSatuanDipilih
        Else
            dtCart.Rows.Add(id, merk, nama, hargaSatuanDipilih, qty, subtotal)
        End If
        HitungTotal()
        txtQty.Clear()
        cboPart.SelectedIndex = -1
        hargaSatuanDipilih = 0
    End Sub
    Sub HitungTotal()
        Dim totalPart As Decimal = 0
        Dim totalBayar As Decimal = 0
        For Each row As DataRow In dtCart.Rows
            totalPart += row("Subtotal")
        Next
        lblTotalPart.Text = totalPart.ToString("N0")
        Dim biayaJasa As Decimal = 0
        If Decimal.TryParse(txtBiayaJasa.Text, biayaJasa) Then
            totalBayar = totalPart + biayaJasa
        Else
            totalBayar = totalPart
        End If
        lblTotalBayar.Text = totalBayar.ToString("N0")
    End Sub
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        err.Clear()
        Dim adaKosong As Boolean = False

        ' 1. Validasi Input Dasar Utama
        If ValidationModule.CekKosong(txtNamaPelanggan, err, "Nama pelanggan harus diisi!") Then adaKosong = True
        If ValidationModule.CekKosong(txtNoHp, err, "No HP harus diisi!") Then adaKosong = True
        If ValidationModule.CekKosong(cboMerk, err, "Pilih merk motor!") Then adaKosong = True

        ' Tentukan jenis transaksi berdasarkan visibilitas pnlServis dan isi keranjang belanja
        Dim jenisTransaksi As String = "part"

        ' 2. Validasi Khusus Jika Melibatkan Fitur Servis (pnlServis Aktif)
        If pnlServis.Visible Then
            If ValidationModule.CekKosong(cboStatusBayar, err, "Pilih status pembayaran!") Then adaKosong = True
            If ValidationModule.CekKosong(txtNoPolisi, err, "No Polisi harus diisi!") Then adaKosong = True
            If ValidationModule.CekKosong(cboMekanik, err, "Pilih mekanik!") Then adaKosong = True
            If ValidationModule.CekKosong(txtKeluhan, err, "Isi keluhan pelanggan!") Then adaKosong = True
            If ValidationModule.CekKosong(txtBiayaJasa, err, "Biaya jasa wajib diisi!") Then adaKosong = True

            ' --- DIUBAH: "keduanya" diganti menjadi "part+service" ---
            If dtCart.Rows.Count > 0 Then
                jenisTransaksi = "part+service"
            Else
                jenisTransaksi = "servis"
            End If
        End If

        ' Jika ada data wajib yang belum diisi, hentikan proses eksekusi
        If adaKosong Then Exit Sub

        ' 3. Validasi Keranjang Belanja khusus untuk transaksi Penjualan Part murni
        If jenisTransaksi = "part" AndAlso dtCart.Rows.Count = 0 Then
            ValidationModule.TampilkanError("Keranjang belanja sparepart masih kosong!")
            Exit Sub
        End If

        Try
            ' 4. Simpan Data ke Header Tabel Transaksi
            Dim sqlTrx As String = "INSERT INTO transaksi (no_transaksi, jenis, nama_pelanggan, no_hp, id_user, total_harga, status_bayar) " &
                                   "VALUES (@no, @jenis, @plg, @hp, @user, @total, @status)"

            Dim params() As MySqlParameter = {
                New MySqlParameter("@no", lblNoTransaksi.Text),
                New MySqlParameter("@jenis", jenisTransaksi),
                New MySqlParameter("@plg", txtNamaPelanggan.Text),
                New MySqlParameter("@hp", txtNoHp.Text),
                New MySqlParameter("@user", FormLogin.IDUserLogin),
                New MySqlParameter("@total", CDec(lblTotalBayar.Text.Replace(".", ""))),
                New MySqlParameter("@status", cboStatusBayar.Text.ToLower())
            }

            If DataModule.EksekusiSQL(sqlTrx, params) Then

                ' 5. Simpan ke detail_transaksi jika di dalam keranjang belanja terdapat sparepart
                If dtCart.Rows.Count > 0 Then
                    For Each row As DataRow In dtCart.Rows
                        Dim sqlDet As String = "INSERT INTO detail_transaksi (no_transaksi, id_part, qty, harga_satuan, subtotal) " &
                                               "VALUES (@no, @id, @qty, @harga, @sub)"
                        Dim pDet() As MySqlParameter = {
                            New MySqlParameter("@no", lblNoTransaksi.Text),
                            New MySqlParameter("@id", row("ID")),
                            New MySqlParameter("@qty", row("Qty")),
                            New MySqlParameter("@harga", row("Harga")),
                            New MySqlParameter("@sub", row("Subtotal"))
                        }
                        DataModule.EksekusiSQL(sqlDet, pDet)
                    Next
                End If

                ' 6. Simpan data ke tabel servis jika jenis transaksi melibatkan pengerjaan servis
                ' --- DIUBAH: Kondisi mencocokkan "part+service" ---
                If jenisTransaksi = "servis" OrElse jenisTransaksi = "part+service" Then
                    Dim sqlServis As String = "INSERT INTO servis (no_servis, no_transaksi, nama_pelanggan, no_polisi, merk_motor, keluhan, id_mekanik, status, biaya_jasa) " &
                                              "VALUES (@no_srv, @no_trx, @plg, @nopol, @merk, @keluhan, @mekanik, 'antri', @jasa)"
                    Dim pServis() As MySqlParameter = {
                        New MySqlParameter("@no_srv", lblNoServis.Text),
                        New MySqlParameter("@no_trx", lblNoTransaksi.Text),
                        New MySqlParameter("@plg", txtNamaPelanggan.Text),
                        New MySqlParameter("@nopol", txtNoPolisi.Text),
                        New MySqlParameter("@merk", cboMerk.Text),
                        New MySqlParameter("@keluhan", txtKeluhan.Text),
                        New MySqlParameter("@mekanik", cboMekanik.SelectedValue),
                        New MySqlParameter("@jasa", CDec(txtBiayaJasa.Text.Replace(".", "")))
                    }
                    DataModule.EksekusiSQL(sqlServis, pServis)
                End If

                ValidationModule.TampilkanInfo("Transaksi Berhasil Disimpan!")
                ClearForm()
            End If

        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal menyimpan transaksi: " & ex.Message)
        End Try
    End Sub
    Private Sub cboMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMerk.SelectedIndexChanged
        If cboMerk.SelectedIndex <> -1 AndAlso cboMerk.Text <> "" Then
            err.SetError(cboMerk, "")
            cboPart.DataSource = Nothing
            hargaSatuanDipilih = 0
            Dim sql As String = "SELECT id_part, nama_part FROM sparepart WHERE stok > 0 AND merk_motor = '" & cboMerk.Text & "'"
            DataModule.LoadToComboBox(sql, cboPart, "nama_part", "id_part")
        Else
            cboPart.DataSource = Nothing
            hargaSatuanDipilih = 0
        End If
    End Sub
    Sub AturTampilanPanel(jenis As String)
        Select Case jenis.ToLower()
            Case "part"
                pnlServis.Visible = False
                lblBiayaJasa.Text = "0"
                txtBiayaJasa.Text = "0"
                cboStatusBayar.Text = "Lunas"
                err.SetError(cboStatusBayar, "")

            Case "servis"
                pnlServis.Visible = True
                cboStatusBayar.SelectedIndex = -1

            ' --- DIUBAH: Mencocokkan inputan kata "part+service" ---
            Case "part+service"
                pnlServis.Visible = True
                cboStatusBayar.SelectedIndex = -1
        End Select
        HitungTotal()
    End Sub
    Sub ClearForm()
        txtNamaPelanggan.Clear()
        txtNoHp.Clear()
        txtNoPolisi.Clear()
        txtKeluhan.Clear()
        txtBiayaJasa.Clear()
        txtQty.Clear()
        cboMerk.SelectedIndex = -1
        cboPart.SelectedIndex = -1
        cboPart.DataSource = Nothing
        cboMekanik.SelectedIndex = -1
        cboStatusBayar.SelectedIndex = -1
        dtCart.Clear()
        lblTotalPart.Text = "Rp 0"
        lblBiayaJasa.Text = "0"
        lblTotalBayar.Text = "0"
        hargaSatuanDipilih = 0
        err.Clear()
        pnlServis.Visible = False
        txtNamaPelanggan.Focus()
        GenerateNoTransaksi()
    End Sub
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub
    Private Sub txtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHp.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub
    Private Sub txtBiayaJasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBiayaJasa.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub
    Private Sub txtBiayaJasa_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaJasa.TextChanged
        Dim biaya As Decimal = 0
        If Decimal.TryParse(txtBiayaJasa.Text, biaya) Then
            lblBiayaJasa.Text = biaya.ToString("N0")
        Else
            lblBiayaJasa.Text = "0"
        End If
        HitungTotal()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If dtCart.Rows.Count > 0 Then
            Dim tanya = MessageBox.Show("Bersihkan semua inputan dan keranjang?", "Konfirmasi",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If tanya = DialogResult.No Then Exit Sub
        End If
        ClearForm()
    End Sub
    Private Sub cboPart_DropDown(sender As Object, e As EventArgs) Handles cboPart.DropDown
        If cboMerk.SelectedIndex = -1 OrElse String.IsNullOrEmpty(cboMerk.Text) Then
            ValidationModule.TampilkanError("Silakan pilih Merk Motor terlebih dahulu!")
            err.SetError(cboMerk, "Pilih merk motor terlebih dahulu!")
            cboPart.DroppedDown = False
            cboMerk.Focus()
        Else
            err.SetError(cboMerk, "")
        End If
    End Sub
    Private Sub btnPart_Click(sender As Object, e As EventArgs) Handles btnJenisPart.Click
        AturTampilanPanel("part")
    End Sub
    Private Sub btnServis_Click(sender As Object, e As EventArgs) Handles btnJenisServis.Click
        AturTampilanPanel("servis")
    End Sub
    Private Sub btnKeduanya_Click(sender As Object, e As EventArgs) Handles btnJenisServisPart.Click
        ' --- DIUBAH: Parameter diubah dari "keduanya" menjadi "part+service" ---
        AturTampilanPanel("part+service")
    End Sub
End Class