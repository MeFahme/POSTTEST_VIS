Imports System.Data

Public Class frmTransaksi

    ' ================================================================
    '  VARIABEL
    ' ================================================================
    Private dtCart As New DataTable()   ' tabel keranjang belanja
    Private noTransaksi As String = ""
    Private noServis As String = ""

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InisialisasiCart()
        IsiComboMerk()
        IsiComboMekanik()
        IsiComboStatusBayar()
        MuatSparepartByMerk()
        GenerateNomor()
        TampilkanInfoKasir()
        SetJenisTransaksi("part")
        pnlSummary.BringToFront()
        pnlCart.BringToFront()
    End Sub

    ' ================================================================
    '  INISIALISASI TABEL KERANJANG (dtCart)
    ' ================================================================
    Private Sub InisialisasiCart()
        dtCart.Columns.Add("id_part", GetType(Integer))
        dtCart.Columns.Add("nama_part", GetType(String))
        dtCart.Columns.Add("merk_motor", GetType(String))
        dtCart.Columns.Add("qty", GetType(Integer))
        dtCart.Columns.Add("harga_satuan", GetType(Decimal))
        dtCart.Columns.Add("subtotal", GetType(Decimal))

        dgvCart.DataSource = dtCart
        AturKolomCart()
    End Sub

    Private Sub AturKolomCart()
        With dgvCart
            If Not .Columns.Contains("id_part") Then Exit Sub
            .Columns("id_part").Visible = False
            .Columns("nama_part").HeaderText = "Nama Part"
            .Columns("merk_motor").HeaderText = "Merk Motor"
            .Columns("qty").HeaderText = "Qty"
            .Columns("harga_satuan").HeaderText = "Harga Satuan"
            .Columns("subtotal").HeaderText = "Subtotal"
            .Columns("harga_satuan").DefaultCellStyle.Format = "N0"
            .Columns("subtotal").DefaultCellStyle.Format = "N0"

            ' Tambah kolom tombol hapus jika belum ada
            If Not .Columns.Contains("colHapus") Then
                Dim btnCol As New DataGridViewButtonColumn()
                btnCol.Name = "colHapus"
                btnCol.HeaderText = ""
                btnCol.Text = "✕"
                btnCol.UseColumnTextForButtonValue = True
                btnCol.Width = 36
                btnCol.FlatStyle = FlatStyle.Flat
                .Columns.Add(btnCol)
            End If
        End With
    End Sub

    ' ================================================================
    '  GENERATE NOMOR OTOMATIS
    ' ================================================================
    Private Sub GenerateNomor()
        noTransaksi = GenerateNoTransaksi()
        lblNoTransaksi.Text = noTransaksi

        ' No servis hanya dibuat jika ada komponen servis
        noServis = GenerateNoServis()
        lblNoServis.Text = "SRV: " & noServis
    End Sub

    ' ================================================================
    '  ISI COMBO
    ' ================================================================
    Private Sub IsiComboMerk()
        cboMerk.Items.Clear()
        cboMerk.Items.Add("Honda Vario")
        cboMerk.Items.Add("Yamaha MX King")
        cboMerk.SelectedIndex = 0
    End Sub

    Private Sub IsiComboMekanik()
        Dim dt As DataTable = GetMekanik()
        If dt Is Nothing Then Exit Sub

        cboMekanik.DataSource = dt
        cboMekanik.DisplayMember = "nama"
        cboMekanik.ValueMember = "id_user"
    End Sub

    Private Sub IsiComboStatusBayar()
        cboStatusBayar.Items.Clear()
        cboStatusBayar.Items.Add("lunas")
        cboStatusBayar.Items.Add("belum")
        cboStatusBayar.SelectedIndex = 0
    End Sub

    Private Sub TampilkanInfoKasir()
        lblInfoKasir.Text = "Kasir: " & frmLogin.SessionNama & " · " & Format(Now, "HH:mm")
    End Sub

    ' ================================================================
    '  JENIS TRANSAKSI — tampilkan/sembunyikan panel servis
    ' ================================================================
    Private Sub btnJenisPart_Click(sender As Object, e As EventArgs) Handles btnJenisPart.Click
        SetJenisTransaksi("part")
    End Sub

    Private Sub btnJenisServisPart_Click(sender As Object, e As EventArgs) Handles btnJenisServisPart.Click
        SetJenisTransaksi("keduanya")
    End Sub

    Private Sub btnJenisServis_Click(sender As Object, e As EventArgs) Handles btnJenisServis.Click
        SetJenisTransaksi("servis")
    End Sub

    Private Sub SetJenisTransaksi(jenis As String)
        ' Reset warna semua tombol
        Dim clrNormal As Drawing.Color = Drawing.Color.FromArgb(26, 29, 42)
        Dim clrActive As Drawing.Color = Drawing.Color.FromArgb(50, 40, 20)
        Dim fgNormal As Drawing.Color = Drawing.Color.FromArgb(119, 136, 153)
        Dim fgActive As Drawing.Color = Drawing.Color.FromArgb(255, 140, 0)

        For Each btn As Button In {btnJenisPart, btnJenisServisPart, btnJenisServis}
            btn.BackColor = clrNormal
            btn.ForeColor = fgNormal
        Next

        ' Panel sparepart selalu tampil kecuali servis saja
        pnlCart.Visible = (jenis <> "servis")

        ' Panel servis tampil jika ada komponen servis
        pnlServis.Visible = (jenis = "keduanya" OrElse jenis = "servis")

        Select Case jenis
            Case "part"
                btnJenisPart.BackColor = clrActive
                btnJenisPart.ForeColor = fgActive
            Case "keduanya"
                btnJenisServisPart.BackColor = clrActive
                btnJenisServisPart.ForeColor = fgActive
            Case "servis"
                btnJenisServis.BackColor = clrActive
                btnJenisServis.ForeColor = fgActive
        End Select

        ' Simpan pilihan jenis ke tag form
        Me.Tag = jenis
        HitungTotal()
    End Sub

    ' ================================================================
    '  COMBO MERK BERUBAH — reload sparepart
    ' ================================================================
    Private Sub cboMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMerk.SelectedIndexChanged
        MuatSparepartByMerk()
    End Sub

    Private Sub MuatSparepartByMerk()
        If cboMerk.SelectedItem Is Nothing Then Exit Sub

        Dim dt As DataTable = GetSparepartByMerk(cboMerk.SelectedItem.ToString())
        If dt Is Nothing Then Exit Sub

        cboPart.DataSource = dt
        cboPart.DisplayMember = "nama_part"
        cboPart.ValueMember = "id_part"
    End Sub

    ' ================================================================
    '  TOMBOL TAMBAH PART KE CART
    ' ================================================================
    Private Sub btnTambahPart_Click(sender As Object, e As EventArgs) Handles btnTambahPart.Click
        If cboPart.SelectedValue Is Nothing Then
            MsgBox("Pilih sparepart terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim idPart As Integer = Convert.ToInt32(cboPart.SelectedValue)
        Dim namaPart As String = cboPart.Text
        Dim merk As String = cboMerk.SelectedItem.ToString()
        Dim qty As Integer = 0
        Dim stokAda As Integer = 0

        If Not Integer.TryParse(txtQty.Text, qty) OrElse qty < 1 Then
            MsgBox("Qty harus angka minimal 1.", MsgBoxStyle.Exclamation, "Peringatan")
            txtQty.Focus() : Exit Sub
        End If

        ' Cek stok dari DataTable cboPart
        Dim dtPart As DataTable = CType(cboPart.DataSource, DataTable)
        Dim rowPart As DataRow() = dtPart.Select("id_part = " & idPart)
        If rowPart.Length > 0 Then
            stokAda = Convert.ToInt32(rowPart(0)("stok"))
        End If

        If qty > stokAda Then
            MsgBox("Stok tidak mencukupi. Stok tersedia: " & stokAda,
                   MsgBoxStyle.Exclamation, "Stok Kurang")
            Exit Sub
        End If

        ' Cek apakah part sudah ada di cart — jika ada, tambah qty
        Dim rows As DataRow() = dtCart.Select("id_part = " & idPart)
        If rows.Length > 0 Then
            Dim existRow As DataRow = rows(0)
            Dim newQty As Integer = Convert.ToInt32(existRow("qty")) + qty
            If newQty > stokAda Then
                MsgBox("Total qty melebihi stok tersedia: " & stokAda,
                       MsgBoxStyle.Exclamation, "Stok Kurang")
                Exit Sub
            End If
            Dim harga As Decimal = Convert.ToDecimal(existRow("harga_satuan"))
            existRow("qty") = newQty
            existRow("subtotal") = harga * newQty
        Else
            ' Part baru — ambil harga dari DataTable
            Dim harga As Decimal = Convert.ToDecimal(rowPart(0)("harga_jual"))
            dtCart.Rows.Add(idPart, namaPart, merk, qty, harga, harga * qty)
        End If

        HitungTotal()
        txtQty.Text = "1"
    End Sub

    ' ================================================================
    '  KLIK TOMBOL HAPUS DI CART
    ' ================================================================
    Private Sub dgvCart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = dgvCart.Columns("colHapus").Index Then
            dtCart.Rows(e.RowIndex).Delete()
            HitungTotal()
        End If
    End Sub

    ' ================================================================
    '  HITUNG TOTAL
    ' ================================================================
    Private Sub HitungTotal()
        Dim totalPart As Decimal = 0
        For Each row As DataRow In dtCart.Rows
            If row.RowState <> DataRowState.Deleted Then
                totalPart += Convert.ToDecimal(row("subtotal"))
            End If
        Next

        Dim biayaJasa As Decimal = 0
        If pnlServis.Visible Then
            Dim jasa As String = txtBiayaJasa.Text.Replace(".", "").Replace(",", "")
            Decimal.TryParse(jasa, biayaJasa)
        End If

        Dim total As Decimal = totalPart + biayaJasa

        lblTotalPart.Text = "Rp " & Format(totalPart, "#,##0")
        lblBiayaJasa.Text = "Rp " & Format(biayaJasa, "#,##0")
        lblTotalBayar.Text = "Rp " & Format(total, "#,##0")
    End Sub

    Private Sub txtBiayaJasa_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaJasa.TextChanged
        HitungTotal()
    End Sub

    ' ================================================================
    '  TOMBOL PROSES PEMBAYARAN
    ' ================================================================
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If Not ValidasiForm() Then Exit Sub

        Dim jenis As String = Me.Tag.ToString()
        Dim nama As String = txtNamaPelanggan.Text.Trim()
        Dim noHp As String = txtNoHp.Text.Trim()
        Dim statusBayar As String = cboStatusBayar.SelectedItem.ToString()
        Dim biayaJasa As Decimal = 0

        If pnlServis.Visible Then
            Dim j As String = txtBiayaJasa.Text.Replace(".", "").Replace(",", "")
            Decimal.TryParse(j, biayaJasa)
        End If

        ' Hitung total
        Dim totalPart As Decimal = 0
        For Each row As DataRow In dtCart.Rows
            If row.RowState <> DataRowState.Deleted Then
                totalPart += Convert.ToDecimal(row("subtotal"))
            End If
        Next
        Dim totalBayar As Decimal = totalPart + biayaJasa

        ' Konfirmasi
        Dim konfirmasi As MsgBoxResult = MsgBox(
            "Konfirmasi Pembayaran" & vbNewLine &
            "Pelanggan : " & nama & vbNewLine &
            "Total Bayar: Rp " & Format(totalBayar, "#,##0") & vbNewLine &
            "Status     : " & statusBayar.ToUpper() & vbNewLine & vbNewLine &
            "Lanjutkan?",
            MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi")

        If konfirmasi <> MsgBoxResult.Yes Then Exit Sub

        ' Simpan ke database dalam satu blok logika
        Dim berhasil As Boolean = SimpanSemuaTransaksi(
            jenis, nama, noHp, statusBayar, biayaJasa, totalBayar)

        If berhasil Then
            MsgBox("Transaksi berhasil disimpan!" & vbNewLine &
                   "No. Transaksi: " & noTransaksi,
                   MsgBoxStyle.Information, "Berhasil")
            ResetForm()
        End If
    End Sub

    Private Function SimpanSemuaTransaksi(jenis As String, nama As String,
                                          noHp As String, statusBayar As String,
                                          biayaJasa As Decimal, total As Decimal) As Boolean
        ' 1. Simpan header transaksi (hanya jika ada part atau keduanya)
        If jenis = "part" OrElse jenis = "keduanya" Then
            If Not SimpanTransaksi(noTransaksi, jenis, nama, noHp,
                                   frmLogin.SessionIdUser, total, statusBayar) Then
                Return False
            End If

            ' 2. Simpan detail part
            For Each row As DataRow In dtCart.Rows
                If row.RowState = DataRowState.Deleted Then Continue For
                If Not SimpanDetailTransaksi(
                    noTransaksi,
                    Convert.ToInt32(row("id_part")),
                    Convert.ToInt32(row("qty")),
                    Convert.ToDecimal(row("harga_satuan")),
                    Convert.ToDecimal(row("subtotal"))) Then
                    Return False
                End If
            Next
        End If

        ' 3. Simpan servis (jika ada komponen servis)
        If jenis = "keduanya" OrElse jenis = "servis" Then
            Dim noTrxRef As String = If(jenis = "keduanya", noTransaksi, "")
            Dim idMekanik As Integer = Convert.ToInt32(cboMekanik.SelectedValue)

            If Not SimpanServis(noServis, noTrxRef, nama,
                                txtNoPolisi.Text.Trim(),
                                cboMerk.SelectedItem.ToString(),
                                txtKeluhan.Text.Trim(),
                                idMekanik, biayaJasa) Then
                Return False
            End If

            ' 4. Insert log servis awal (status antri)
            UpdateStatusServis(noServis, "antri",
                               "Motor baru didaftarkan oleh kasir",
                               frmLogin.SessionIdUser)
        End If

        Return True
    End Function

    ' ================================================================
    '  VALIDASI FORM
    ' ================================================================
    Private Function ValidasiForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNamaPelanggan.Text) Then
            MsgBox("Nama pelanggan tidak boleh kosong.", MsgBoxStyle.Exclamation, "Validasi")
            txtNamaPelanggan.Focus() : Return False
        End If

        Dim jenis As String = Me.Tag?.ToString()

        ' Jika ada komponen part, cart tidak boleh kosong
        If jenis = "part" OrElse jenis = "keduanya" Then
            If dtCart.Rows.Count = 0 Then
                MsgBox("Tambahkan minimal 1 sparepart ke daftar.",
                       MsgBoxStyle.Exclamation, "Validasi")
                Return False
            End If
        End If

        ' Jika ada komponen servis, no polisi wajib diisi
        If jenis = "keduanya" OrElse jenis = "servis" Then
            If String.IsNullOrWhiteSpace(txtNoPolisi.Text) Then
                MsgBox("No. polisi kendaraan tidak boleh kosong.",
                       MsgBoxStyle.Exclamation, "Validasi")
                txtNoPolisi.Focus() : Return False
            End If
            If cboMekanik.SelectedValue Is Nothing Then
                MsgBox("Pilih mekanik yang bertugas.",
                       MsgBoxStyle.Exclamation, "Validasi")
                cboMekanik.Focus() : Return False
            End If
        End If

        Return True
    End Function

    ' ================================================================
    '  FORMAT BIAYA JASA saat keluar dari field
    ' ================================================================
    Private Sub txtBiayaJasa_Leave(sender As Object, e As EventArgs) Handles txtBiayaJasa.Leave
        Dim val As Decimal
        Dim raw As String = txtBiayaJasa.Text.Replace(".", "").Replace(",", "")
        If Decimal.TryParse(raw, val) Then
            txtBiayaJasa.Text = Format(val, "#,##0")
        End If
        HitungTotal()
    End Sub

    ' ================================================================
    '  TOMBOL RESET
    ' ================================================================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MsgBox("Reset form? Semua data yang diisi akan hilang.",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                  "Konfirmasi") = MsgBoxResult.Yes Then
            ResetForm()
        End If
    End Sub

    Private Sub ResetForm()
        dtCart.Rows.Clear()
        txtNamaPelanggan.Text = ""
        txtNoHp.Text = ""
        txtNoPolisi.Text = ""
        txtKeluhan.Text = ""
        txtBiayaJasa.Text = "0"
        txtQty.Text = "1"
        cboMerk.SelectedIndex = 0
        cboStatusBayar.SelectedIndex = 0
        SetJenisTransaksi("part")
        GenerateNomor()
        HitungTotal()
        txtNamaPelanggan.Focus()
    End Sub

    Private Sub frmTransaksi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Memanggil fungsi refresh di form induk (frmMain)
        If TypeOf Me.MdiParent Is frmMain Then
            DirectCast(Me.MdiParent, frmMain).MuatDashboard()
        End If
    End Sub
End Class
