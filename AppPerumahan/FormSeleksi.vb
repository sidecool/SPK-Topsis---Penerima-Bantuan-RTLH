Imports MySql.Data.MySqlClient

Public Class FormSeleksi
    Sub KondisiAwal()
        TextBox1.Text = ""
        LBLTanggal.Text = ""
        LBLAdmin.Text = ""

        CbKerja.SelectedValue = ""
        CbGaji.SelectedValue = ""
        CbTanggungan.SelectedValue = ""
        CbAtap.SelectedValue = ""
        CbDinding.SelectedValue = ""
        CbLantai.SelectedValue = ""
        CbCPB.SelectedValue = ""
        TextBox1.Enabled = False
        CbKerja.Enabled = False
        CbGaji.Enabled = False
        CbTanggungan.Enabled = False
        CbAtap.Enabled = False
        CbDinding.Enabled = False
        CbLantai.Enabled = False
        CbCPB.Enabled = False
        BtnCreate.Enabled = True
        BtnUpdate.Enabled = True
        BtnDelete.Enabled = True
        BtnCreate.Text = "Input"
        BtnUpdate.Text = "Edit"
        BtnDelete.Text = "Hapus"
        BtnClose.Text = "Tutup"
        Conn.Close()
        Da = New MySqlDataAdapter("Select KODE, NAMA, C1, C2, C3, C4, C5, C6 from v_analisa ORDER BY KODE", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds, "v_analisa")
        DataGridView1.DataSource = Ds.Tables("v_analisa")
        DataGridView1.ReadOnly = True

        Call NomorOtomatis()
        munculcpb()
    End Sub

    Sub SiapIsi()
        TextBox1.Enabled = True
        CbKerja.Enabled = True
        CbGaji.Enabled = True
        CbTanggungan.Enabled = True
        CbAtap.Enabled = True
        CbDinding.Enabled = True
        CbLantai.Enabled = True
        CbCPB.Enabled = True
        LBLTanggal.Text = Format(Today, "yyyy-MM-dd")
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
    End Sub
    Sub munculpekerjaan()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_pekerjaan, pekerjaan from tbl_pekerjaan", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Pekerjaan --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbKerja.DataSource = New BindingSource(ComboSource, Nothing)
        CbKerja.DisplayMember = "Value"
        CbKerja.ValueMember = "Key"
    End Sub
    Sub munculpenghasilan()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_penghasilan, jumlah_penghasilan from tbl_penghasilan", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Penghasilan --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbGaji.DataSource = New BindingSource(ComboSource, Nothing)
        CbGaji.DisplayMember = "Value"
        CbGaji.ValueMember = "Key"
    End Sub
    Sub muncultanggungan()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_tanggungan, jumlah_tanggungan from tbl_tanggungan_jiwa", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Tanggungan Jiwa --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbTanggungan.DataSource = New BindingSource(ComboSource, Nothing)
        CbTanggungan.DisplayMember = "Value"
        CbTanggungan.ValueMember = "Key"
    End Sub
    Sub munculatap()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_atap, kondisi_atap from tbl_atap", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Kondisi Atap --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbAtap.DataSource = New BindingSource(ComboSource, Nothing)
        CbAtap.DisplayMember = "Value"
        CbAtap.ValueMember = "Key"
    End Sub
    Sub munculdinding()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_dinding, kondisi_dinding from tbl_dinding", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Kondisi Dinding --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbDinding.DataSource = New BindingSource(ComboSource, Nothing)
        CbDinding.DisplayMember = "Value"
        CbDinding.ValueMember = "Key"
    End Sub
    Sub muncullantai()
        Conn.Close()
        Cmd = New MySqlCommand("select kode_lantai, kondisi_lantai from tbl_lantai", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Kondisi Lantai --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbLantai.DataSource = New BindingSource(ComboSource, Nothing)
        CbLantai.DisplayMember = "Value"
        CbLantai.ValueMember = "Key"
    End Sub
    Sub munculcpb()
        Conn.Close()
        Cmd = New MySqlCommand("SELECT KODE_CPB, NAMA_KEPALA_KELUARGA FROM TBL_CPB " _
                             & "WHERE STATUS='A'", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Dim ComboSource As New Dictionary(Of String, String)()
        ComboSource.Add("", " --- Pilih Calon Penerima Bantuan --- ")
        Do While Rd.Read
            ComboSource.Add(Rd.Item(0), Rd.Item(1))
        Loop
        CbCPB.DataSource = New BindingSource(ComboSource, Nothing)
        CbCPB.DisplayMember = "Value"
        CbCPB.ValueMember = "Key"
    End Sub

    Sub TanyaSeleksiBaru()
        If MessageBox.Show("Apakah Anda akan memproses seleksi baru ?", "Konfirmasi", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("Apakah Anda benar-benar yakin akan memproses seleksi baru ?" & vbLf _
                             & "[Yes] : Menghapus data seleksi sebelumnya." & vbLf _
                             & "[No] : Tetap menggunakan data seleksi lama.", "Konfirmasi", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                MsgBox("Proses ini akan menghapus data seleksi lama. Anda dapat melihat data seleksi lama yang tersimpan dalam histori.")

                Conn.Close()
                Cmd = New MySqlCommand("update tbl_cpb set status='H' where kode_CPB in (select kode_cpb from tbl_analisa)", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tbl_analisa ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_solusi_jarak_positif ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_solusi_jarak_negatif ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_normalisasi_maxmin ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_normalisasi_bobot ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_normalisasi_akar ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_normalisasi ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Conn.Close()
                Cmd = New MySqlCommand("TRUNCATE TABLE tp_ranking ", Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                NomorOtomatis()
            End If
        End If
    End Sub

    Private Sub FormSeleksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call munculpekerjaan()
        Call munculpenghasilan()
        Call muncultanggungan()
        Call munculatap()
        Call munculdinding()
        Call muncullantai()
        Call munculcpb()

        TanyaSeleksiBaru()
    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click
        Call NomorOtomatis()
        If BtnCreate.Text = "Input" Then
            BtnCreate.Text = "Simpan"
            BtnUpdate.Enabled = False
            BtnDelete.Enabled = False
            BtnClose.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
            TextBox1.Enabled = False
            CbCPB.Focus()
        Else
            If TextBox1.Text = "" Or _
               DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbKerja.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbGaji.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbTanggungan.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbAtap.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbDinding.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbLantai.SelectedItem, KeyValuePair(Of String, String)).Key = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim InputData As String = "insert into tbl_analisa values('" & TextBox1.Text & "'," _
                                        & "'" & DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbKerja.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbGaji.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbTanggungan.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbAtap.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbDinding.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & DirectCast(CbLantai.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                        & "'" & LBLTanggal.Text & "'," _
                                        & "'" & LBLAdmin.Text & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Dim UpdateCPB As String = "update tbl_cpb set status='S' " _
                                        & "where kode_cpb='" & DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key & "'"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateCPB, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")

                Call KondisiAwal()
            End If
        End If

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        If BtnUpdate.Text = "Edit" Then
            BtnUpdate.Text = "Simpan"
            BtnCreate.Enabled = False
            BtnDelete.Enabled = False
            BtnClose.Text = "Batal"
            Call SiapIsi()
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or _
               DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbKerja.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbGaji.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbTanggungan.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbAtap.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbDinding.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbLantai.SelectedItem, KeyValuePair(Of String, String)).Key = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim UpdateData As String = "update tbl_analisa set " _
                                         & "kode_cpb='" & DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_pekerjaan='" & DirectCast(CbKerja.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_penghasilan='" & DirectCast(CbGaji.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_tanggungan='" & DirectCast(CbTanggungan.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_atap='" & DirectCast(CbAtap.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_dinding='" & DirectCast(CbDinding.SelectedItem, KeyValuePair(Of String, String)).Key & "'," _
                                         & "kode_lantai='" & DirectCast(CbLantai.SelectedItem, KeyValuePair(Of String, String)).Key & "' " _
                                         & "where kode_analisa='" & TextBox1.Text & "'"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Dim UpdateCPB As String = "update tbl_cpb set status='S' " _
                                        & "where kode_cpb='" & DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key & "'"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateCPB, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Sub LoadData()
        Dim UpdateCPB_S As String = "update tbl_cpb set status='S' " _
                                & "where kode_cpb in (select kode_cpb from tbl_analisa)"
        Conn.Close()
        Cmd = New MySqlCommand(UpdateCPB_S, Conn)
        Conn.Open()
        Cmd.ExecuteNonQuery()

        ConnUpdate.Close()
        Cmd = New MySqlCommand("SELECT * FROM TBL_ANALISA WHERE KODE_ANALISA = '" & TextBox1.Text & "'", ConnUpdate)
        ConnUpdate.Open()
        Dim NewRd = Cmd.ExecuteReader
        NewRd.Read()
        If Not NewRd.HasRows Then
            MsgBox("Kode seleksi tidak ada")
        Else
            Dim UpdateCPB As String = "update tbl_cpb set status='A' " _
                                    & "where kode_cpb='" & NewRd.Item("KODE_CPB") & "'"
            Conn.Close()
            Cmd = New MySqlCommand(UpdateCPB, Conn)
            Conn.Open()
            Cmd.ExecuteNonQuery()

            munculcpb()

            TextBox1.Text = NewRd.Item("kode_analisa")
            LBLTanggal.Text = Format(NewRd.Item("tanggal"), "yyyy-MM-dd")
            LBLAdmin.Text = NewRd.Item("admin")
            CbCPB.SelectedValue = NewRd.Item("KODE_CPB")
            CbKerja.SelectedValue = NewRd.Item("kode_pekerjaan")
            CbGaji.SelectedValue = NewRd.Item("kode_penghasilan")
            CbTanggungan.SelectedValue = NewRd.Item("kode_tanggungan")
            CbAtap.SelectedValue = NewRd.Item("kode_atap")
            CbDinding.SelectedValue = NewRd.Item("kode_dinding")
            CbLantai.SelectedValue = NewRd.Item("kode_lantai")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            LoadData()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BtnClose.Text = "Tutup" Then
            Me.Close()
        Else
            If BtnUpdate.Text = "Simpan" Then
                Dim UpdateCPB As String = "update tbl_cpb set status='S' " _
                                        & "where kode_cpb in (select kode_cpb from tbl_analisa)"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateCPB, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
            Call KondisiAwal()
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If BtnDelete.Text = "Hapus" Then
            BtnDelete.Text = "Delete"
            BtnUpdate.Text = "Edit"
            BtnCreate.Enabled = False
            BtnUpdate.Enabled = False            
            BtnClose.Text = "Batal"
            Call SiapIsi()
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or _
               DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbKerja.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbGaji.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbTanggungan.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbAtap.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbDinding.SelectedItem, KeyValuePair(Of String, String)).Key = "" Or _
               DirectCast(CbLantai.SelectedItem, KeyValuePair(Of String, String)).Key = "" Then
                MsgBox("Silahkan isi semua field")
            Else
                Dim HapusData As String = "Delete from tbl_analisa where kode_analisa='" & TextBox1.Text & "'"
                Conn.Close()
                Cmd = New MySqlCommand(HapusData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()

                Dim UpdateCPB As String = "update tbl_cpb set status='A' " _
                                        & "where kode_cpb='" & DirectCast(CbCPB.SelectedItem, KeyValuePair(Of String, String)).Key & "'"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateCPB, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Sub NomorOtomatis()
        Conn.Close()
        Cmd = New MySqlCommand("Select * from tbl_analisa where kode_analisa in (select max(kode_analisa) from tbl_analisa)", Conn)
        Conn.Open()
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "K" + "0001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
            UrutanKode = "K" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Call FormPerangkingan.Show()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If BtnUpdate.Text = "Edit" Then
            BtnUpdate.Text = "Simpan"
            BtnCreate.Enabled = False
            If BtnDelete.Text = "Hapus" Then
                BtnDelete.Enabled = False
            Else
                BtnDelete.Enabled = True
                BtnUpdate.Text = "Edit"
            End If

            BtnClose.Text = "Batal"
            Call SiapIsi()            
        End If

        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        LoadData()
        TextBox1.Focus()
    End Sub
End Class