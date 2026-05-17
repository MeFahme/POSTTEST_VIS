Imports MySqlConnector

Public Class FormDetailServis
    ' Properti publik untuk menampung Nomor Servis yang dikirim dari Form Daftar Motor
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property NoServisDipilih As String = ""
    Private noTransaksiTerkait As String = ""

    Private Sub FormDetailServis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")

        If String.IsNullOrEmpty(NoServisDipilih) Then
            ValidationModule.TampilkanError("Tidak ada nomor servis yang dipilih!")
            Me.Close()
            Exit Sub
        End If

        LoadDataMasterSparepart()
        TampilkanDetailServis()
    End Sub

    ''' <summary>
    ''' Memuat item sparepart yang tersedia ke combobox tambahan sparepart
    ''' </summary>
    Private Sub LoadDataMasterSparepart()
        Dim sql As String = "SELECT id_part, nama_part FROM sparepart WHERE stok > 0"
        DataModule.LoadToComboBox(sql, cboPart, "nama_part", "id_part")
        cboPart.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Menarik data lengkap servis dari database berdasarkan NoServisDipilih
    ''' </summary>
    Private Sub TampilkanDetailServis()
        Try
            BukaKoneksi()
            Dim sql As String = "SELECT s.*, u.nama As nama_mekanik " &
                                "FROM servis s " &
                                "LEFT JOIN users u ON s.id_mekanik = u.id_user " &
                                "WHERE s.no_servis = @no_srv"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@no_srv", NoServisDipilih)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lblNoServis.Text = reader("no_servis").ToString()
                        lblPelanggan.Text = reader("nama_pelanggan").ToString()
                        lblNoPolisi.Text = reader("no_polisi").ToString()
                        lblMerkMotor.Text = reader("merk_motor").ToString()
                        lblKeluhan.Text = reader("keluhan").ToString()
                        lblMekanik.Text = If(IsDBNull(reader("nama_mekanik")), "Belum Ditentukan", reader("nama_mekanik").ToString())

                        ' Tanggal Masuk & Selesai
                        lblTglMasuk.Text = Convert.ToDateTime(reader("tgl_masuk")).ToString("dd/MM/yyyy HH:mm")
                        lblTglSelesai.Text = If(IsDBNull(reader("tgl_selesai")), "-", Convert.ToDateTime(reader("tgl_selesai")).ToString("dd/MM/yyyy HH:mm"))

                        ' Status Aktif Mekanik
                        Dim status As String = reader("status").ToString()
                        lblStatusAktif.Text = status.ToUpper()

                        ' Catatan Terakhir
                        txtCatatan.Text = If(IsDBNull(reader("catatan_terakhir")), "", reader("catatan_terakhir").ToString())

                        ' Simpan no_transaksi untuk keperluan penambahan sparepart log
                        noTransaksiTerkait = reader("no_transaksi").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal memuat detail servis: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ''' <summary>
    ''' Prosedur global untuk memperbarui status pengerjaan servis mekanik
    ''' </summary>
    Private Sub UpdateStatusServis(statusBaru As String)
        Dim sql As String = ""
        ' Jika status berubah menjadi selesai atau diambil, catat tgl_selesai otomatis
        If statusBaru = "selesai" OrElse statusBaru = "diambil" Then
            sql = "UPDATE servis SET status = @status, catatan_terakhir = @catatan, tgl_selesai = NOW() WHERE no_servis = @no_srv"
        Else
            sql = "UPDATE servis SET status = @status, catatan_terakhir = @catatan WHERE no_servis = @no_srv"
        End If

        Dim params() As MySqlParameter = {
            New MySqlParameter("@status", statusBaru),
            New MySqlParameter("@catatan", txtCatatan.Text.Trim()),
            New MySqlParameter("@no_srv", NoServisDipilih)
        }

        If DataModule.EksekusiSQL(sql, params) Then
            ValidationModule.TampilkanInfo("Status berhasil diubah menjadi: " & statusBaru.ToUpper())
            TampilkanDetailServis() ' Refresh UI

            ' Otomatis refresh data FormDaftarMotor jika sedang terbuka
            If Application.OpenForms("FormDaftarMotor") IsNot Nothing Then
                CType(Application.OpenForms("FormDaftarMotor"), FormDaftarMotor).RefreshData()
            End If
        End If
    End Sub

    ' Button PROSES (Guna2Button1)
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        UpdateStatusServis("proses")
    End Sub

    ' Button PENDING / MENUNGGU PART (Guna2Button4)
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        UpdateStatusServis("menunggu_part")
    End Sub

    ' Button SELESAI (Guna2Button3)
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If String.IsNullOrEmpty(txtCatatan.Text.Trim()) Then
            ValidationModule.TampilkanError("Harap isi Catatan Tindakan mekanik terlebih dahulu sebelum menyelesaikan!")
            txtCatatan.Focus()
            Exit Sub
        End If
        UpdateStatusServis("selesai")
    End Sub

    ' Button AMBIL MOTOR (Guna2Button2)
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Update status akhir bahwa motor telah diambil pelanggan dan lunas otomatis jika diperlukan
        UpdateStatusServis("diambil")

        ' Update status bayar di transaksi induk menjadi lunas saat serah terima unit
        Dim sqlTrx As String = "UPDATE transaksi SET status_bayar = 'lunas' WHERE no_transaksi = @no_trx"
        Dim p() As MySqlParameter = {New MySqlParameter("@no_trx", noTransaksiTerkait)}
        DataModule.EksekusiSQL(sqlTrx, p)
    End Sub

    ' Button TAMBAH SPAREPART (Guna2Button5)
    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If cboPart.SelectedIndex = -1 OrElse cboPart.SelectedValue IsNot Nothing Then
            ValidationModule.TampilkanError("Silakan pilih sparepart tambahan!")
            Exit Sub
        End If

        Try
            BukaKoneksi()
            ' 1. Ambil data harga jual sparepart terkait
            Dim hargaJual As Decimal = 0
            Dim namaPart As String = cboPart.Text
            Dim cmdHarga As New MySqlCommand("SELECT harga_jual FROM sparepart WHERE id_part = @id", conn)
            cmdHarga.Parameters.AddWithValue("@id", cboPart.SelectedValue)
            Dim res = cmdHarga.ExecuteScalar()
            If res IsNot Nothing Then hargaJual = Convert.ToDecimal(res)

            ' 2. Masukkan ke detail_transaksi (Qty default = 1)
            Dim sqlInsertDetail As String = "INSERT INTO detail_transaksi (no_transaksi, id_part, qty, harga_satuan, subtotal) " &
                                           "VALUES (@no_trx, @id_part, 1, @harga, @harga)"
            Dim pDetail() As MySqlParameter = {
                New MySqlParameter("@no_trx", noTransaksiTerkait),
                New MySqlParameter("@id_part", cboPart.SelectedValue),
                New MySqlParameter("@harga", hargaJual)
            }

            ' Tutup koneksi pembacaan sementara untuk eksekusi modul luar
            TutupKoneksi()

            If DataModule.EksekusiSQL(sqlInsertDetail, pDetail) Then
                ' 3. Update total_harga nota transaksi utama di database (menambahkan harga part baru)
                Dim sqlUpdateTotal As String = "UPDATE transaksi SET total_harga = total_harga + @harga_baru WHERE no_transaksi = @no_trx"
                Dim pTotal() As MySqlParameter = {
                    New MySqlParameter("@harga_baru", hargaJual),
                    New MySqlParameter("@no_trx", noTransaksiTerkait)
                }
                DataModule.EksekusiSQL(sqlUpdateTotal, pTotal)

                ' --- UPDATE JENIS TRANSAKSI ---
                ' Jika sebelumnya jenisnya hanya 'servis', ubah menjadi 'part+service' karena ada tambahan part
                Dim sqlUpdateJenis As String = "UPDATE transaksi SET jenis = 'part+service' WHERE no_transaksi = @no_trx AND jenis = 'servis'"
                Dim pJenis() As MySqlParameter = {New MySqlParameter("@no_trx", noTransaksiTerkait)}
                DataModule.EksekusiSQL(sqlUpdateJenis, pJenis)

                ValidationModule.TampilkanInfo("Berhasil menambahkan sparepart: " & namaPart & " ke dalam nota bon servis ini!")
                cboPart.SelectedIndex = -1

                ' Trigger MySQL (trg_kurangi_stok) otomatis akan memotong stok fisik sparepart Anda!
            End If

        Catch ex As Exception
            ValidationModule.TampilkanError("Gagal menambahkan sparepart: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub
End Class