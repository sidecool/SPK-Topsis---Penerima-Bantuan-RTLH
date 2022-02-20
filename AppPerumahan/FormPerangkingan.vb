Imports MySql.Data.MySqlClient

Public Class FormPerangkingan
    Dim SQL As String

    Private Sub TampilDataGrid(ByVal status As Boolean)
        DataGridView1.Visible = status
        DataGridView2.Visible = status
        DataGridView3.Visible = status
        DataGridView4.Visible = status
        DataGridView5.Visible = status
        Label1.Visible = status
        Label2.Visible = status
        Label3.Visible = status
        Label4.Visible = status
        Label7.Visible = status

        If status = True Then
            DataGridView1.Width = DataGridView1.Parent.Width - ((DataGridView1.Left * 2) + 3)
            DataGridView2.Width = DataGridView1.Width
            DataGridView3.Width = DataGridView1.Width
            DataGridView4.Width = DataGridView1.Width
            DataGridView5.Width = DataGridView1.Width

            ProgressBar1.Visible = False
            LabelProses.Visible = False
        End If
    End Sub

    Private Sub FormPerangkingan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Left = (ProgressBar1.Parent.Width \ 2) - (ProgressBar1.Width \ 2)
        ProgressBar1.Top = (ProgressBar1.Parent.Height \ 2) - (ProgressBar1.Height \ 2)

        LabelProses.Left = ProgressBar1.Left
        LabelProses.Top = ProgressBar1.Top - 16

        Call TampilDataGrid(False)
        Call TampilHasil()
    End Sub

    Private Sub TampilHasil()
        'view tabel analisa
        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM V_ANALISA ORDER BY KODE", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True

        Call hitung_topsis()
        Call TampilDataGrid(True)

        'view tabel normalisasi
        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM V_NORMALISASI", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView2.DataSource = Ds.Tables(0)
        DataGridView2.ReadOnly = True

        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM V_NORMALISASI_AKAR", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView3.DataSource = Ds.Tables(0)
        DataGridView3.ReadOnly = True

        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM V_NORMALISASI_BOBOT", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView4.DataSource = Ds.Tables(0)
        DataGridView4.ReadOnly = True

        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM V_HASIL_RANKING ORDER BY RANKING", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView5.DataSource = Ds.Tables(0)
        DataGridView5.ReadOnly = True
    End Sub

    Function KodeBaru() As String
        Conn.Close()
        SQL = "SELECT KODE_HISTORI FROM TBL_HISTORI " _
            & "WHERE KODE_HISTORI IN (SELECT MAX(KODE_HISTORI) FROM TBL_HISTORI)"
        Conn.Open()
        Cmd = New MySql.Data.MySqlClient.MySqlCommand(SQL, Conn)
        Dim urut As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urut = "H" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urut = "H" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If

        Return urut
    End Function

    Private Sub FormPerangkingan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Kode, Keterangan, Tanggal As String
        Dim Cmd2 As MySql.Data.MySqlClient.MySqlCommand

        If MessageBox.Show("Apakah Anda ingin menyimpan sebagai histori ?", "Konfirmasi", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'e.Cancel = False

            Kode = Format(Today, "yyyyMMdd") & "-" & KodeBaru()
            Tanggal = Format(Today, "dd-MM-yyyy")
            Keterangan = InputBox("Keterangan histori proses : ", "", "")            

            If Keterangan <> "" Then
                Conn.Close()
                SQL = "SELECT DISTINCT KODE_HISTORI FROM TBL_HISTORI WHERE KODE_HISTORI = '" & Kode & "'"
                Conn.Open()
                Cmd = New MySql.Data.MySqlClient.MySqlCommand(SQL, Conn)
                Rd = Cmd.ExecuteReader

                If Rd.HasRows Then
                    MsgBox("Maaf, Data pada hari ini sudah disimpan kedalam histori.")                    
                Else
                    Conn.Close()
                    SQL = "SELECT KODE, RANKING, KODE_CPB, NAMA_CPB, ALAMAT_LENGKAP, " _
                        & "C1_PEKERJAAN, C2_PENGHASILAN, C3_TANGGUNGAN, " _
                        & "C4_ATAP, C5_DINDING, C6_LANTAI, NILAI FROM V_REPORT"
                    Conn.Open()
                    Cmd = New MySql.Data.MySqlClient.MySqlCommand(SQL, Conn)
                    Rd = Cmd.ExecuteReader

                    If Rd.HasRows Then
                        While Rd.Read()
                            ConnUpdate.Close()
                            SQL = "INSERT INTO TBL_HISTORI VALUES ('" & Kode & "'," _
                                                               & " '" & Keterangan & "'," _
                                                               & " '" & Tanggal & "'," _
                                                               & " '" & Rd!KODE & "'," _
                                                               & " '" & Rd!RANKING & "'," _
                                                               & " '" & Rd!KODE_CPB & "'," _
                                                               & " '" & Rd!NAMA_CPB & "'," _
                                                               & " '" & Rd!ALAMAT_LENGKAP & "'," _
                                                               & " '" & Rd!C1_PEKERJAAN & "'," _
                                                               & " '" & Rd!C2_PENGHASILAN & "'," _
                                                               & " '" & Rd!C3_TANGGUNGAN & "'," _
                                                               & " '" & Rd!C4_ATAP & "'," _
                                                               & " '" & Rd!C5_DINDING & "'," _
                                                               & " '" & Rd!C6_LANTAI & "'," _
                                                               & " '" & Rd!NILAI & "')"
                            ConnUpdate.Open()
                            Cmd2 = New MySql.Data.MySqlClient.MySqlCommand(SQL, ConnUpdate)
                            Cmd2.ExecuteNonQuery()
                        End While
                    End If
                End If
            Else
                'e.Cancel = True
            End If
        Else
            'e.Cancel = True
        End If
    End Sub
End Class