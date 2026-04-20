Imports MySqlConnector

Module DataModule
    Public Function GetAllPart() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.KodePart, p.NamaPart, k.NamaKategori, m.NamaMerk, " &
                "       p.Harga, p.Stok " &
                "FROM   tbpart p " &
                "JOIN   tbkategori k ON p.KodeKategori = k.KodeKategori " &
                "JOIN   tbmerk     m ON p.KodeMerk     = m.KodeMerk " &
                "ORDER  BY p.KodePart ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function FilterPart(kodeKategori As String, kodeMerk As String, keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim kondisi As New List(Of String)
            kondisi.Add("1=1")
            If kodeKategori <> "" Then kondisi.Add("p.KodeKategori = @kat")
            If kodeMerk <> "" Then kondisi.Add("p.KodeMerk = @merk")
            If keyword.Trim() <> "" Then
                kondisi.Add("(p.KodePart LIKE @kw OR p.NamaPart LIKE @kw)")
            End If
            Dim query As String =
                "SELECT p.KodePart, p.NamaPart, k.NamaKategori, m.NamaMerk, " &
                "       p.Harga, p.Stok " &
                "FROM   tbpart p " &
                "JOIN   tbkategori k ON p.KodeKategori = k.KodeKategori " &
                "JOIN   tbmerk     m ON p.KodeMerk     = m.KodeMerk " &
                "WHERE  " & String.Join(" AND ", kondisi) &
                " ORDER BY p.KodePart ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    If kodeKategori <> "" Then da.SelectCommand.Parameters.AddWithValue("@kat", kodeKategori)
                    If kodeMerk <> "" Then da.SelectCommand.Parameters.AddWithValue("@merk", kodeMerk)
                    If keyword.Trim() <> "" Then da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memfilter data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPartByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT KodePart, NamaPart, KodeKategori, KodeMerk, Harga, Stok " &
                "FROM   tbpart WHERE KodePart = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data part: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePartSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpart WHERE KodePart = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa kode: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanPart(kode As String, nama As String,
                               kodeKat As String, kodeMerk As String,
                               harga As Decimal, stok As Integer) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpart (KodePart, NamaPart, KodeKategori, KodeMerk, Harga, Stok) " &
                "VALUES (@kode, @nama, @kat, @merk, @harga, @stok)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kodeKat)
                    cmd.Parameters.AddWithValue("@merk", kodeMerk)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPart(kode As String, nama As String,
                             kodeKat As String, kodeMerk As String,
                             harga As Decimal, stok As Integer) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpart " &
                "SET NamaPart=@nama, KodeKategori=@kat, KodeMerk=@merk, " &
                "    Harga=@harga, Stok=@stok " &
                "WHERE KodePart = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kodeKat)
                    cmd.Parameters.AddWithValue("@merk", kodeMerk)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPart(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpart WHERE KodePart = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllKategori() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT KodeKategori, NamaKategori FROM tbkategori ORDER BY NamaKategori ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil kategori: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetAllMerk() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT KodeMerk, NamaMerk FROM tbmerk ORDER BY NamaMerk ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil merk: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GenerateNomorNota() As String
        Try
            Dim prefix As String = "NOT-" & DateTime.Now.ToString("yyyyMMdd") & "-"
            Dim query As String = "SELECT COUNT(*) FROM tbpenjualan WHERE NomorNota LIKE @prefix"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@prefix", prefix & "%")
                    Dim urut As Integer = Convert.ToInt32(cmd.ExecuteScalar()) + 1
                    Return prefix & urut.ToString("000")
                End Using
            End Using
        Catch
            Return "NOT-" & DateTime.Now.ToString("yyyyMMddHHmmss")
        End Try
    End Function

    Public Function GetAllPenjualan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT NomorNota, TanggalJual, NamaPembeli, " &
                "       TotalItem, TotalHarga, Keterangan " &
                "FROM   tbpenjualan " &
                "ORDER  BY TanggalJual DESC, NomorNota DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan penjualan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function FilterPenjualan(keyword As String,
                                    tglMulai As String,
                                    tglAkhir As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim kondisi As New List(Of String)
            kondisi.Add("1=1")
            If keyword.Trim() <> "" Then kondisi.Add("(NomorNota LIKE @kw OR NamaPembeli LIKE @kw)")
            If tglMulai <> "" Then kondisi.Add("TanggalJual >= @tglMulai")
            If tglAkhir <> "" Then kondisi.Add("TanggalJual <= @tglAkhir")

            Dim query As String =
                "SELECT NomorNota, TanggalJual, NamaPembeli, " &
                "       TotalItem, TotalHarga, Keterangan " &
                "FROM   tbpenjualan " &
                "WHERE  " & String.Join(" AND ", kondisi) &
                " ORDER BY TanggalJual DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    If keyword.Trim() <> "" Then da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                    If tglMulai <> "" Then da.SelectCommand.Parameters.AddWithValue("@tglMulai", tglMulai)
                    If tglAkhir <> "" Then da.SelectCommand.Parameters.AddWithValue("@tglAkhir", tglAkhir)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memfilter penjualan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetDetailPenjualan(nomorNota As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT d.KodePart, p.NamaPart, d.Jumlah, " &
                "       d.HargaSatuan, d.Subtotal " &
                "FROM   tbdetailpenjualan d " &
                "JOIN   tbpart p ON d.KodePart = p.KodePart " &
                "WHERE  d.NomorNota = @nota " &
                "ORDER  BY d.IdDetail ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@nota", nomorNota)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil detail: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPenjualan(nomorNota As String,
                                    tanggal As String,
                                    namaPembeli As String,
                                    totalItem As Integer,
                                    totalHarga As Decimal,
                                    keterangan As String,
                                    dtKeranjang As DataTable,
                                    kodePelanggan As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim trx As MySqlTransaction = conn.BeginTransaction()
            Try
                Dim qHeader As String =
                    "INSERT INTO tbpenjualan " &
                    "(NomorNota, TanggalJual, NamaPembeli, KodePelanggan, " &
                    " TotalItem, TotalHarga, Keterangan) " &
                    "VALUES (@nota, @tgl, @nama, @kpl, @totItem, @totHarga, @ket)"
                Using cmd As New MySqlCommand(qHeader, conn, trx)
                    cmd.Parameters.AddWithValue("@nota", nomorNota)
                    cmd.Parameters.AddWithValue("@tgl", tanggal)
                    cmd.Parameters.AddWithValue("@nama", namaPembeli)
                    cmd.Parameters.AddWithValue("@totItem", totalItem)
                    cmd.Parameters.AddWithValue("@totHarga", totalHarga)
                    cmd.Parameters.AddWithValue("@ket", keterangan)
                    cmd.Parameters.AddWithValue("@kpl", If(kodePelanggan = "", DBNull.Value, kodePelanggan))
                    cmd.ExecuteNonQuery()
                End Using

                For Each row As DataRow In dtKeranjang.Rows
                    Dim kodePart As String = row("KodePart").ToString()
                    Dim jumlah As Integer = Convert.ToInt32(row("Jumlah"))
                    Dim hargaSat As Decimal = Convert.ToDecimal(row("HargaSatuan"))
                    Dim subtotal As Decimal = Convert.ToDecimal(row("Subtotal"))

                    Using cmd As New MySqlCommand(
                        "INSERT INTO tbdetailpenjualan (NomorNota, KodePart, Jumlah, HargaSatuan, Subtotal) " &
                        "VALUES (@nota, @kode, @jml, @hsat, @sub)", conn, trx)
                        cmd.Parameters.AddWithValue("@nota", nomorNota)
                        cmd.Parameters.AddWithValue("@kode", kodePart)
                        cmd.Parameters.AddWithValue("@jml", jumlah)
                        cmd.Parameters.AddWithValue("@hsat", hargaSat)
                        cmd.Parameters.AddWithValue("@sub", subtotal)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmd As New MySqlCommand(
                        "UPDATE tbpart SET Stok = Stok - @jml WHERE KodePart = @kode", conn, trx)
                        cmd.Parameters.AddWithValue("@jml", jumlah)
                        cmd.Parameters.AddWithValue("@kode", kodePart)
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                trx.Commit()
                Return True
            Catch ex As Exception
                trx.Rollback()
                MessageBox.Show("Transaksi gagal, data dibatalkan: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function HapusPenjualan(nomorNota As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim trx As MySqlTransaction = conn.BeginTransaction()
            Try
                Using cmd As New MySqlCommand(
                    "UPDATE tbpart p " &
                    "JOIN tbdetailpenjualan d ON p.KodePart = d.KodePart " &
                    "SET p.Stok = p.Stok + d.Jumlah " &
                    "WHERE d.NomorNota = @nota", conn, trx)
                    cmd.Parameters.AddWithValue("@nota", nomorNota)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New MySqlCommand(
                    "DELETE FROM tbdetailpenjualan WHERE NomorNota = @nota", conn, trx)
                    cmd.Parameters.AddWithValue("@nota", nomorNota)
                    cmd.ExecuteNonQuery()
                End Using
                Using cmd As New MySqlCommand(
                    "DELETE FROM tbpenjualan WHERE NomorNota = @nota", conn, trx)
                    cmd.Parameters.AddWithValue("@nota", nomorNota)
                    cmd.ExecuteNonQuery()
                End Using

                trx.Commit()
                Return True
            Catch ex As Exception
                trx.Rollback()
                MessageBox.Show("Gagal menghapus penjualan: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Public Function CekStokCukup(kodePart As String, jumlahDiminta As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT Stok FROM tbpart WHERE KodePart = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kodePart)
                    Dim stok As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return stok >= jumlahDiminta
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function GenerateKodePelanggan() As String
        Try
            Dim query As String =
                "SELECT KodePelanggan FROM tbpelanggan " &
                "ORDER BY KodePelanggan DESC LIMIT 1"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim hasil As Object = cmd.ExecuteScalar()
                    If hasil Is Nothing OrElse hasil Is DBNull.Value Then
                        Return "PLG001"
                    End If
                    Dim lastKode As String = hasil.ToString()           ' misal PLG005
                    Dim angka As Integer = Integer.Parse(lastKode.Substring(3)) + 1
                    Return "PLG" & angka.ToString("D3")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal generate kode: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "PLG001"
        End Try
    End Function

    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT KodePelanggan, NamaPelanggan, NoHP, Alamat, Email " &
                "FROM   tbpelanggan ORDER BY KodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function FilterPelanggan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT KodePelanggan, NamaPelanggan, NoHP, Alamat, Email " &
                "FROM   tbpelanggan " &
                "WHERE  KodePelanggan LIKE @kw OR NamaPelanggan LIKE @kw OR NoHP LIKE @kw " &
                "ORDER  BY KodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memfilter pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePelangganSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tbpelanggan WHERE KodePelanggan = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa kode: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function
    Public Function SimpanPelanggan(kode As String, nama As String,
                                    noHP As String, alamat As String,
                                    email As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpelanggan (KodePelanggan, NamaPelanggan, NoHP, Alamat, Email) " &
                "VALUES (@kode, @nama, @hp, @alamat, @email)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", noHP)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPelanggan(kode As String, nama As String,
                                  noHP As String, alamat As String,
                                  email As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpelanggan " &
                "SET NamaPelanggan=@nama, NoHP=@hp, Alamat=@alamat, Email=@email " &
                "WHERE KodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@hp", noHP)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@email", email)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPelanggan(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                ' Cek apakah pelanggan sudah pernah bertransaksi
                Using cmdCek As New MySqlCommand(
                    "SELECT COUNT(*) FROM tbpenjualan WHERE KodePelanggan = @kode", conn)
                    cmdCek.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())
                    If jumlah > 0 Then
                        MessageBox.Show("Pelanggan tidak dapat dihapus karena masih memiliki " &
                                        jumlah & " data transaksi penjualan!",
                                        "Tidak Bisa Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End Using

                Using cmd As New MySqlCommand(
                    "DELETE FROM tbpelanggan WHERE KodePelanggan = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetRiwayatPelanggan(kodePelanggan As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT NomorNota, TanggalJual, NamaPembeli, " &
                "       TotalItem, TotalHarga, Keterangan " &
                "FROM   tbpenjualan " &
                "WHERE  KodePelanggan = @kode " &
                "ORDER  BY TanggalJual DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kodePelanggan)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil riwayat: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module
