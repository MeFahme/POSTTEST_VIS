Imports MySqlConnector
Public Class frmDetailServis

    Private noServisAktif As String = ""

    ' ================================================================
    '  CONSTRUCTOR — menerima no_servis dari frmDaftarMotor
    ' ================================================================
    Public Sub New(noServis As String)
        InitializeComponent()
        noServisAktif = noServis
    End Sub

    ' ================================================================
    '  FORM LOAD
    ' ================================================================
    Private Sub frmDetailServis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Detail Servis — " & noServisAktif
        MuatDetailServis()
        MuatLogServis()
        MuatSparepartCombo()
    End Sub

    ' ================================================================
    '  MUAT DETAIL SERVIS
    ' ================================================================
    Private Sub MuatDetailServis()
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim sql As String =
                "SELECT s.*, u.nama AS nama_mekanik " &
                "FROM servis s JOIN users u ON s.id_mekanik = u.id_user " &
                "WHERE s.no_servis = @no"

            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@no", noServisAktif)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Data servis tidak ditemukan.", MsgBoxStyle.Exclamation)
                    Me.Close() : Exit Sub
                End If

                Dim row As DataRow = dt.Rows(0)
                lblNoServis.Text = row("no_servis").ToString()
                lblPelanggan.Text = row("nama_pelanggan").ToString()
                lblNoPolisi.Text = row("no_polisi").ToString()
                lblMerkMotor.Text = row("merk_motor").ToString()
                lblKeluhan.Text = row("keluhan").ToString()
                lblMekanik.Text = row("nama_mekanik").ToString()
                lblTglMasuk.Text = Format(Convert.ToDateTime(row("tgl_masuk")), "dd/MM/yyyy HH:mm")
                lblStatusAktif.Text = row("status").ToString().Replace("_", " ").ToUpper()

                ' Tandai tombol status sesuai status aktif
                TandaiStatusAktif(row("status").ToString())

                ' Jika sudah selesai, kunci tombol update
                Dim sudahSelesai As Boolean = (row("status").ToString() = "selesai")
                btnUpdate.Enabled = Not sudahSelesai
                btnPakaiPart.Enabled = Not sudahSelesai
                txtCatatan.ReadOnly = sudahSelesai

                If sudahSelesai AndAlso Not IsDBNull(row("tgl_selesai")) Then
                    lblTglSelesai.Text = Format(Convert.ToDateTime(row("tgl_selesai")), "dd/MM/yyyy HH:mm")
                    lblTglSelesai.Visible = True
                    lblTglSelesaiLbl.Visible = True
                End If

            End Using
        Catch ex As Exception
            MsgBox("Error muat detail servis: " & ex.Message)
        End Try
    End Sub

    ' ================================================================
    '  TANDAI STATUS AKTIF DI TOMBOL
    ' ================================================================
    Private Sub TandaiStatusAktif(status As String)
        Dim clrNormal As Drawing.Color = Drawing.Color.FromArgb(26, 29, 42)
        Dim clrActive As Drawing.Color = Drawing.Color.FromArgb(50, 40, 20)
        Dim fgNormal As Drawing.Color = Drawing.Color.FromArgb(119, 136, 153)
        Dim fgActive As Drawing.Color = Drawing.Color.FromArgb(255, 140, 0)

        For Each btn As Button In {btnAntri, btnProses, btnMenungguPart, btnSelesai}
            btn.BackColor = clrNormal
            btn.ForeColor = fgNormal
        Next

        Select Case status
            Case "antri" : btnAntri.BackColor = clrActive : btnAntri.ForeColor = fgActive
            Case "proses" : btnProses.BackColor = clrActive : btnProses.ForeColor = fgActive
            Case "menunggu_part" : btnMenungguPart.BackColor = clrActive : btnMenungguPart.ForeColor = fgActive
            Case "selesai"
                btnSelesai.BackColor = Drawing.Color.FromArgb(14, 28, 20)
                btnSelesai.ForeColor = Drawing.Color.FromArgb(46, 204, 113)
        End Select
    End Sub

    ' ================================================================
    '  MUAT LOG SERVIS
    ' ================================================================
    Private Sub MuatLogServis()
        If Not CekKoneksi() Then Exit Sub

        Try
            Dim sql As String =
                "SELECT l.status_baru, l.catatan, l.waktu, u.nama AS nama_mekanik " &
                "FROM log_servis l JOIN users u ON l.id_mekanik = u.id_user " &
                "WHERE l.no_servis = @no ORDER BY l.waktu DESC"

            Using cmd As New MySqlCommand(sql, KoneksiDB)
                cmd.Parameters.AddWithValue("@no", noServisAktif)
                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvLog.DataSource = dt
                With dgvLog
                    If .Columns.Contains("status_baru") Then .Columns("status_baru").HeaderText = "Status"
                    If .Columns.Contains("catatan") Then .Columns("catatan").HeaderText = "Catatan"
                    If .Columns.Contains("waktu") Then .Columns("waktu").HeaderText = "Waktu"
                    If .Columns.Contains("nama_mekanik") Then .Columns("nama_mekanik").HeaderText = "Mekanik"
                End With
            End Using
        Catch ex As Exception
            MsgBox("Error muat log: " & ex.Message)
        End Try
    End Sub

    ' ================================================================
    '  MUAT COMBO SPAREPART
    ' ================================================================
    Private Sub MuatSparepartCombo()
        Dim dt As DataTable = GetAllSparepart()
        If dt Is Nothing Then Exit Sub

        ' Filter hanya stok > 0
        Dim dv As New DataView(dt)
        dv.RowFilter = "stok > 0"

        cboPart.DataSource = dv
        cboPart.DisplayMember = "nama_part"
        cboPart.ValueMember = "id_part"
    End Sub

    ' ================================================================
    '  TOMBOL STATUS
    ' ================================================================
    Private Sub btnAntri_Click(s As Object, e As EventArgs) Handles btnAntri.Click
        TandaiStatusAktif("antri") : Me.Tag = "antri"
    End Sub
    Private Sub btnProses_Click(s As Object, e As EventArgs) Handles btnProses.Click
        TandaiStatusAktif("proses") : Me.Tag = "proses"
    End Sub
    Private Sub btnMenungguPart_Click(s As Object, e As EventArgs) Handles btnMenungguPart.Click
        TandaiStatusAktif("menunggu_part") : Me.Tag = "menunggu_part"
    End Sub
    Private Sub btnSelesai_Click(s As Object, e As EventArgs) Handles btnSelesai.Click
        TandaiStatusAktif("selesai") : Me.Tag = "selesai"
    End Sub

    ' ================================================================
    '  TOMBOL UPDATE STATUS
    ' ================================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim statusBaru As String = Me.Tag?.ToString()

        If String.IsNullOrEmpty(statusBaru) Then
            MsgBox("Pilih status terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtCatatan.Text) Then
            MsgBox("Isi catatan pekerjaan sebelum update.", MsgBoxStyle.Exclamation, "Peringatan")
            txtCatatan.Focus() : Exit Sub
        End If

        ' Konfirmasi jika status selesai
        If statusBaru = "selesai" Then
            Dim konfirmasi As MsgBoxResult =
                MsgBox("Tandai motor ini sebagai SELESAI?" & vbNewLine &
                       "Status tidak dapat diubah kembali setelah ini.",
                       MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Selesai")
            If konfirmasi <> MsgBoxResult.Yes Then Exit Sub
        End If

        If UpdateStatusServis(noServisAktif, statusBaru,
                              txtCatatan.Text.Trim(),
                              frmLogin.SessionIdUser) Then
            MsgBox("Status berhasil diupdate ke: " & statusBaru.Replace("_", " ").ToUpper(),
                   MsgBoxStyle.Information, "Berhasil")
            txtCatatan.Clear()
            MuatDetailServis()
            MuatLogServis()
        End If
    End Sub

    ' ================================================================
    '  TOMBOL PAKAI SPAREPART
    ' ================================================================
    Private Sub btnPakaiPart_Click(sender As Object, e As EventArgs) Handles btnPakaiPart.Click
        If cboPart.SelectedValue Is Nothing Then
            MsgBox("Pilih sparepart terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim idPart As Integer = Convert.ToInt32(cboPart.SelectedValue)
        Dim qty As Integer = 0

        If Not Integer.TryParse(txtQtyPart.Text, qty) OrElse qty < 1 Then
            MsgBox("Qty harus angka minimal 1.", MsgBoxStyle.Exclamation, "Peringatan")
            txtQtyPart.Focus() : Exit Sub
        End If

        ' Cek stok dari DataView
        Dim dv As DataView = CType(cboPart.DataSource, DataView)
        Dim rows() As DataRowView = dv.FindRows(idPart)
        Dim stokAda As Integer = 0

        If rows.Length > 0 Then
            stokAda = Convert.ToInt32(rows(0)("stok"))
        End If

        If qty > stokAda Then
            MsgBox("Stok tidak mencukupi. Stok tersedia: " & stokAda,
                   MsgBoxStyle.Exclamation, "Stok Kurang")
            Exit Sub
        End If

        ' Simpan pemakaian part — pakai tabel detail_transaksi
        ' dengan no_transaksi dari servis (jika ada), atau buat entri baru
        Dim konfirmasi As MsgBoxResult =
            MsgBox("Konfirmasi pakai " & qty & "x " & cboPart.Text & "?" & vbNewLine &
                   "Stok akan berkurang otomatis.",
                   MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi")

        If konfirmasi <> MsgBoxResult.Yes Then Exit Sub

        If PakaiSparepartServis(noServisAktif, idPart, qty) Then
            MsgBox("Pemakaian sparepart berhasil dicatat.", MsgBoxStyle.Information, "Berhasil")
            txtQtyPart.Text = "1"
            MuatSparepartCombo()  ' reload stok terbaru
        End If
    End Sub

End Class
