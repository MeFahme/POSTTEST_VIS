Imports MySqlConnector
Imports System.Data

Module DataModule

    ' ================================================================
    '  HELPER — Isi DataTable dari MySqlCommand
    '  Pengganti MySqlDataAdapter yang tidak ada di MySqlConnector
    ' ================================================================
    Private Function IsiDataTable(cmd As MySqlCommand) As DataTable
        Dim dt As New DataTable()
        Using reader As MySqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function

    ' ================================================================
    '  AUTO-GENERATE NOMOR TRANSAKSI & SERVIS
    ' ================================================================
    Public Function GenerateNoTransaksi() As String
        If Not CekKoneksi() Then Return ""
        Dim tgl    As String  = Format(Now, "yyyyMMdd")
        Dim prefix As String  = "TRX-" & tgl & "-"
        Dim urutan As Integer = 1
        Try
            Dim sql As String =
                "SELECT no_transaksi FROM transaksi " &
                "WHERE no_transaksi LIKE @prefix " &
                "ORDER BY no_transaksi DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@prefix", prefix & "%")
                Dim hasil As Object = cmd.ExecuteScalar()
                If hasil IsNot Nothing AndAlso hasil IsNot DBNull.Value Then
                    Dim noTerakhir As String = hasil.ToString()
                    urutan = Integer.Parse(noTerakhir.Substring(noTerakhir.Length - 3)) + 1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generate no transaksi: " & ex.Message)
            Return ""
        End Try
        Return prefix & urutan.ToString("D3")
    End Function

    Public Function GenerateNoServis() As String
        If Not CekKoneksi() Then Return ""
        Dim tgl    As String  = Format(Now, "yyyyMMdd")
        Dim prefix As String  = "SRV-" & tgl & "-"
        Dim urutan As Integer = 1
        Try
            Dim sql As String =
                "SELECT no_servis FROM servis " &
                "WHERE no_servis LIKE @prefix " &
                "ORDER BY no_servis DESC LIMIT 1"
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@prefix", prefix & "%")
                Dim hasil As Object = cmd.ExecuteScalar()
                If hasil IsNot Nothing AndAlso hasil IsNot DBNull.Value Then
                    Dim noTerakhir As String = hasil.ToString()
                    urutan = Integer.Parse(noTerakhir.Substring(noTerakhir.Length - 3)) + 1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generate no servis: " & ex.Message)
            Return ""
        End Try
        Return prefix & urutan.ToString("D3")
    End Function

    ' ================================================================
    '  USERS
    ' ================================================================
    Public Function Login(username As String, password As String) As DataRow
        If Not CekKoneksi() Then Return Nothing
        Try
            Dim sql As String =
                "SELECT id_user, nama, role FROM users " &
                "WHERE username = @usr AND password = @pwd LIMIT 1"
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@usr", username)
                cmd.Parameters.AddWithValue("@pwd", password)
                Dim dt As DataTable = IsiDataTable(cmd)
                If dt.Rows.Count > 0 Then Return dt.Rows(0)
                Return Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("Error login: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetAllUsers() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Dim sql As String =
                "SELECT id_user, nama, username, role FROM users ORDER BY nama"
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get users: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function TambahUser(nama As String, username As String,
                               password As String, role As String) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Dim sql As String =
                "INSERT INTO users (nama, username, password, role) " &
                "VALUES (@nama, @usr, @pwd, @role)"
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@usr",  username)
                cmd.Parameters.AddWithValue("@pwd",  password)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As MySqlException When ex.ErrorCode = MySqlErrorCode.DuplicateKeyEntry
            MessageBox.Show("Username sudah digunakan, coba username lain.")
            Return False
        Catch ex As Exception
            MessageBox.Show("Error tambah user: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function EditUser(idUser As Integer, nama As String,
                             username As String, password As String,
                             role As String) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Dim sql As String
            If String.IsNullOrWhiteSpace(password) Then
                sql = "UPDATE users SET nama=@nama, username=@usr, role=@role WHERE id_user=@id"
            Else
                sql = "UPDATE users SET nama=@nama, username=@usr, password=@pwd, role=@role WHERE id_user=@id"
            End If
            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@usr",  username)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@id",   idUser)
                If Not String.IsNullOrWhiteSpace(password) Then
                    cmd.Parameters.AddWithValue("@pwd", password)
                End If
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As MySqlException When ex.ErrorCode = MySqlErrorCode.DuplicateKeyEntry
            MessageBox.Show("Username sudah digunakan, coba username lain.")
            Return False
        Catch ex As Exception
            MessageBox.Show("Error edit user: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusUser(idUser As Integer) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "DELETE FROM users WHERE id_user = @id", KoneksiDB)
                cmd.Parameters.AddWithValue("@id", idUser)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error hapus user: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetMekanik() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT id_user, nama FROM users WHERE role = 'mekanik' ORDER BY nama",
                KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get mekanik: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' ================================================================
    '  SPAREPART
    ' ================================================================
    Public Function GetAllSparepart() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT id_part, nama_part, kategori, merk_motor, harga_jual, stok " &
                "FROM sparepart ORDER BY merk_motor, nama_part", KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get sparepart: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetSparepartByMerk(merk As String) As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT id_part, nama_part, harga_jual, stok " &
                "FROM sparepart WHERE merk_motor = @merk ORDER BY nama_part",
                KoneksiDB)
                cmd.Parameters.AddWithValue("@merk", merk)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get sparepart by merk: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function TambahSparepart(nama As String, kategori As String,
                                    merk As String, harga As Decimal,
                                    stok As Integer) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "INSERT INTO sparepart (nama_part, kategori, merk_motor, harga_jual, stok) " &
                "VALUES (@nama, @kat, @merk, @harga, @stok)", KoneksiDB)
                cmd.Parameters.AddWithValue("@nama",  nama)
                cmd.Parameters.AddWithValue("@kat",   kategori)
                cmd.Parameters.AddWithValue("@merk",  merk)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@stok",  stok)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error tambah sparepart: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function EditSparepart(idPart As Integer, nama As String,
                                  kategori As String, merk As String,
                                  harga As Decimal, stok As Integer) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "UPDATE sparepart SET nama_part=@nama, kategori=@kat, " &
                "merk_motor=@merk, harga_jual=@harga, stok=@stok " &
                "WHERE id_part=@id", KoneksiDB)
                cmd.Parameters.AddWithValue("@nama",  nama)
                cmd.Parameters.AddWithValue("@kat",   kategori)
                cmd.Parameters.AddWithValue("@merk",  merk)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.Parameters.AddWithValue("@stok",  stok)
                cmd.Parameters.AddWithValue("@id",    idPart)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error edit sparepart: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusSparepart(idPart As Integer) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "DELETE FROM sparepart WHERE id_part = @id", KoneksiDB)
                cmd.Parameters.AddWithValue("@id", idPart)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error hapus sparepart: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetStokSparepart() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT * FROM v_stok_sparepart", KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get stok: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' ================================================================
    '  TRANSAKSI
    ' ================================================================
    Public Function SimpanTransaksi(noTrx As String, jenis As String,
                                    namaPelanggan As String, noHp As String,
                                    idUser As Integer, total As Decimal,
                                    statusBayar As String) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "INSERT INTO transaksi " &
                "(no_transaksi, jenis, nama_pelanggan, no_hp, id_user, total_harga, status_bayar) " &
                "VALUES (@no, @jenis, @nama, @hp, @user, @total, @bayar)", KoneksiDB)
                cmd.Parameters.AddWithValue("@no",    noTrx)
                cmd.Parameters.AddWithValue("@jenis", jenis)
                cmd.Parameters.AddWithValue("@nama",  namaPelanggan)
                cmd.Parameters.AddWithValue("@hp",    noHp)
                cmd.Parameters.AddWithValue("@user",  idUser)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@bayar", statusBayar)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error simpan transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SimpanDetailTransaksi(noTrx As String, idPart As Integer,
                                          qty As Integer, hargaSatuan As Decimal,
                                          subtotal As Decimal) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "INSERT INTO detail_transaksi " &
                "(no_transaksi, id_part, qty, harga_satuan, subtotal) " &
                "VALUES (@no, @part, @qty, @harga, @sub)", KoneksiDB)
                cmd.Parameters.AddWithValue("@no",    noTrx)
                cmd.Parameters.AddWithValue("@part",  idPart)
                cmd.Parameters.AddWithValue("@qty",   qty)
                cmd.Parameters.AddWithValue("@harga", hargaSatuan)
                cmd.Parameters.AddWithValue("@sub",   subtotal)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error simpan detail transaksi: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetLaporanPenjualan() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT * FROM v_laporan_penjualan", KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get laporan: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' ================================================================
    '  SERVIS
    ' ================================================================
    Public Function SimpanServis(noServis As String, noTrx As String,
                                 namaPelanggan As String, noPolisi As String,
                                 merkMotor As String, keluhan As String,
                                 idMekanik As Integer, biayaJasa As Decimal) As Boolean
        If Not CekKoneksi() Then Return False
        Try
            Using cmd As New MySqlCommand(
                "INSERT INTO servis " &
                "(no_servis, no_transaksi, nama_pelanggan, no_polisi, " &
                " merk_motor, keluhan, id_mekanik, biaya_jasa) " &
                "VALUES (@srv, @trx, @nama, @pol, @merk, @keluhan, @mek, @biaya)",
                KoneksiDB)
                cmd.Parameters.AddWithValue("@srv",     noServis)
                cmd.Parameters.AddWithValue("@trx",     If(String.IsNullOrEmpty(noTrx), DBNull.Value, noTrx))
                cmd.Parameters.AddWithValue("@nama",    namaPelanggan)
                cmd.Parameters.AddWithValue("@pol",     noPolisi)
                cmd.Parameters.AddWithValue("@merk",    merkMotor)
                cmd.Parameters.AddWithValue("@keluhan", keluhan)
                cmd.Parameters.AddWithValue("@mek",     idMekanik)
                cmd.Parameters.AddWithValue("@biaya",   biayaJasa)
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error simpan servis: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateStatusServis(noServis As String, statusBaru As String,
                                       catatan As String, idMekanik As Integer) As Boolean
        If Not CekKoneksi() Then Return False
        Dim trx As MySqlTransaction = KoneksiDB.BeginTransaction()
        Try
            ' 1. Update status di tabel servis
            Dim sqlUpdate As String =
                "UPDATE servis SET status = @status " &
                If(statusBaru = "selesai", ", tgl_selesai = NOW() ", "") &
                "WHERE no_servis = @no"
            Using cmd As New MySqlCommand(sqlUpdate, KoneksiDB, trx)
                cmd.Parameters.AddWithValue("@status", statusBaru)
                cmd.Parameters.AddWithValue("@no",     noServis)
                cmd.ExecuteNonQuery()
            End Using

            ' 2. Insert log
            Using cmd As New MySqlCommand(
                "INSERT INTO log_servis (no_servis, status_baru, catatan, id_mekanik) " &
                "VALUES (@no, @status, @catatan, @mek)", KoneksiDB, trx)
                cmd.Parameters.AddWithValue("@no",      noServis)
                cmd.Parameters.AddWithValue("@status",  statusBaru)
                cmd.Parameters.AddWithValue("@catatan", catatan)
                cmd.Parameters.AddWithValue("@mek",     idMekanik)
                cmd.ExecuteNonQuery()
            End Using

            trx.Commit()
            Return True
        Catch ex As Exception
            trx.Rollback()
            MessageBox.Show("Error update status servis: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetStatusMotor() As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT * FROM v_status_motor", KoneksiDB)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get status motor: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetServisByMekanik(idMekanik As Integer) As DataTable
        If Not CekKoneksi() Then Return Nothing
        Try
            Using cmd As New MySqlCommand(
                "SELECT no_servis, nama_pelanggan, no_polisi, merk_motor, " &
                "       keluhan, status, tgl_masuk " &
                "FROM servis WHERE id_mekanik = @id AND status <> 'selesai' " &
                "ORDER BY tgl_masuk ASC", KoneksiDB)
                cmd.Parameters.AddWithValue("@id", idMekanik)
                Return IsiDataTable(cmd)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error get servis by mekanik: " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' ================================================================
    '  PAKAI SPAREPART OLEH MEKANIK
    ' ================================================================
    Public Function PakaiSparepartServis(noServis As String,
                                         idPart As Integer,
                                         qty As Integer) As Boolean
        If Not CekKoneksiDB() Then Return False
        Try
            ' Cek no_transaksi dari servis
            Dim noTrx As String = ""
            Using cmd As New MySqlCommand(
                "SELECT no_transaksi FROM servis WHERE no_servis = @no", KoneksiDB)
                cmd.Parameters.AddWithValue("@no", noServis)
                Dim hasil As Object = cmd.ExecuteScalar()
                If hasil IsNot Nothing AndAlso hasil IsNot DBNull.Value Then
                    noTrx = hasil.ToString()
                End If
            End Using

            ' Ambil harga part
            Dim harga As Decimal = 0
            Using cmd As New MySqlCommand(
                "SELECT harga_jual FROM sparepart WHERE id_part = @id", KoneksiDB)
                cmd.Parameters.AddWithValue("@id", idPart)
                Dim h As Object = cmd.ExecuteScalar()
                If h IsNot Nothing Then harga = Convert.ToDecimal(h)
            End Using

            If String.IsNullOrEmpty(noTrx) Then
                ' Kurangi stok langsung
                Using cmd As New MySqlCommand(
                    "UPDATE sparepart SET stok = stok - @qty " &
                    "WHERE id_part = @id AND stok >= @qty", KoneksiDB)
                    cmd.Parameters.AddWithValue("@qty", qty)
                    cmd.Parameters.AddWithValue("@id",  idPart)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("Stok tidak mencukupi.")
                        Return False
                    End If
                End Using
            Else
                ' Insert ke detail_transaksi — trigger kurangi stok
                If Not SimpanDetailTransaksi(noTrx, idPart, qty, harga, harga * qty) Then
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error pakai sparepart: " & ex.Message)
            Return False
        End Try
    End Function

    ' Alias agar tidak konflik nama
    Private Function CekKoneksiDB() As Boolean
        Return CekKoneksi()
    End Function

End Module
