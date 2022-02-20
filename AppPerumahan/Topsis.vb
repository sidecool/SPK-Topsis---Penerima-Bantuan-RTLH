Imports MySql.Data.MySqlClient

Module Topsis
    Dim UrutanKode As String
    Dim Hitung As Long

    Dim jmlRow As Integer
    Dim jmlCol As Integer = 7

    Dim m_analisa(,) As String
    Dim m_pangkat(,), m_normal(,), m_bobot(,), m_solusi(,), m_jarak_p(,), m_jarak_n(,), m_hasil(,) As Double
    Dim tot_pangkat(), max_bobot(), min_bobot() As Double 'panjang berdasarkan kolom
    Dim tot_jarak_p(), tot_jarak_n(), preferensi() As Double 'panjang berdasarkan baris
    Dim ranking() As Integer 'panjang berdasarkan baris

    'inisialisasi nilai bobot
    Dim n_bobot() As Double

    Private Sub TruncateAll()
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
    End Sub


    Private Sub getNumRow()
        Conn.Close()
        Cmd = New MySqlCommand("SELECT COUNT(KODE) AS NUMROW FROM V_ANALISA", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            jmlRow = Rd.Item("NUMROW")
        End If
    End Sub

    Private Sub proses_analisa()
        Dim b, k As Integer
        ReDim m_analisa(jmlRow, jmlCol)

        'memasukkan data kedalam array m_analisa
        Conn.Close()
        Da = New MySqlDataAdapter("SELECT kode_CPB,C1,C2,C3,C4,C5,C6 FROM V_ANALISA", Conn)
        Conn.Open()
        Dt = New DataTable
        Da.Fill(Dt)
        b = 0
        For Each row In Dt.Rows
            k = 0
            For Each col In Dt.Columns
                m_analisa(b, k) = row(k)
                k += 1
            Next
            b += 1
        Next
        Dt.Rows.Clear()
    End Sub

    Private Sub proses_pangkat()
        Dim b, k As Integer
        Dim total As Double
        'inisialisasi ulang matriks m_pangkat dan tot_pangkat
        ReDim m_pangkat(jmlRow, jmlCol)
        ReDim tot_pangkat(jmlCol)

        For b = 0 To jmlRow - 1
            For k = 1 To jmlCol - 1
                'mengisi matriks normalisasi m_pangkat dengan menghitung isi matriks m_analisa dipangkat 2
                m_pangkat(b, k) = CDbl(m_analisa(b, k)) ^ 2
                'menghitung total per-kolom
                tot_pangkat(k) += m_pangkat(b, k)
            Next

            'Proses memasukkan data array kedalam database            
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_normalisasi)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "N" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "N" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                total = m_pangkat(b, 1) + m_pangkat(b, 2) + m_pangkat(b, 3) + m_pangkat(b, 4) + m_pangkat(b, 5) + m_pangkat(b, 6)

                Dim InputData As String = "INSERT INTO tp_normalisasi VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_pangkat(b, 1) & "'," _
                                        & " '" & m_pangkat(b, 2) & "'," _
                                        & " '" & m_pangkat(b, 3) & "'," _
                                        & " '" & m_pangkat(b, 4) & "'," _
                                        & " '" & m_pangkat(b, 5) & "'," _
                                        & " '" & m_pangkat(b, 6) & "'," _
                                        & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                        & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                        & " '" & CStr(total) & "')"                
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next
    End Sub

    Private Sub proses_normalisasi()
        Dim b, k As Integer
        Dim total As Double
        'inisialisasi ulang matriks m_normal
        ReDim m_normal(jmlRow, jmlCol)

        For b = 0 To jmlRow - 1
            For k = 1 To jmlCol - 1
                'mengisi matriks normalisasi m_normal dengan menghitung isi matriks m_analisa dibagi akar total per-kolom
                m_normal(b, k - 1) = CDbl(m_analisa(b, k)) / Math.Sqrt(tot_pangkat(k))
            Next

            'Proses memasukkan data array kedalam database            
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi_akar WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi_akar WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_normalisasi_akar)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "N" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "N" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                total = m_normal(b, 0) + m_normal(b, 1) + m_normal(b, 2) + m_normal(b, 3) + m_normal(b, 4) + m_normal(b, 5)

                Dim InputData As String = "INSERT INTO tp_normalisasi_akar VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_normal(b, 0) & "'," _
                                        & " '" & m_normal(b, 1) & "'," _
                                        & " '" & m_normal(b, 2) & "'," _
                                        & " '" & m_normal(b, 3) & "'," _
                                        & " '" & m_normal(b, 4) & "'," _
                                        & " '" & m_normal(b, 5) & "'," _
                                        & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                        & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                        & " '" & CStr(total) & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next
    End Sub

    Private Sub getBobot()
        ReDim n_bobot(jmlCol - 1)

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_pekerjaan", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(0) = Rd.Item("bobot")
        End If

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_penghasilan", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(1) = Rd.Item("bobot")
        End If

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_atap", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(2) = Rd.Item("bobot")
        End If

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_dinding", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(3) = Rd.Item("bobot")
        End If

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_lantai", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(4) = Rd.Item("bobot")
        End If

        Conn.Close()
        Cmd = New MySqlCommand("SELECT DISTINCT bobot FROM tbl_tanggungan_jiwa", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            n_bobot(5) = Rd.Item("bobot")
        End If
    End Sub

    Private Sub proses_bobot()
        Dim b, k As Integer
        Dim total As Double
        Dim tempMax, tempMin As Double
        'inisialisasi ulang matriks m_bobot, n_bobot, max_bobot, min_bobot
        ReDim m_bobot(jmlRow, jmlCol)
        ReDim max_bobot(jmlCol)
        ReDim min_bobot(jmlCol)

        'mengisi baris alternatif dan kolom kriteria
        For b = 0 To jmlRow - 1
            For k = 0 To jmlCol - 1
                'mengisi matriks normalisasi terbobot m_bobot dengan menghitung matriks m_normal dikali n_bobot per-kolom
                m_bobot(b, k) = m_normal(b, k) * n_bobot(k)
            Next

            'Proses memasukkan data array kedalam database
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi_bobot WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_normalisasi_bobot WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_normalisasi_bobot)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "N" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "N" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                total = m_bobot(b, 0) + m_bobot(b, 1) + m_bobot(b, 2) + m_bobot(b, 3) + m_bobot(b, 4) + m_bobot(b, 5)

                Dim InputData As String = "INSERT INTO tp_normalisasi_bobot VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_bobot(b, 0) & "'," _
                                        & " '" & m_bobot(b, 1) & "'," _
                                        & " '" & m_bobot(b, 2) & "'," _
                                        & " '" & m_bobot(b, 3) & "'," _
                                        & " '" & m_bobot(b, 4) & "'," _
                                        & " '" & m_bobot(b, 5) & "'," _
                                        & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                        & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                        & " '" & CStr(total) & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next

        'mencari nilai maksimal dan minimal setiap kolom kriteria
        For k = 0 To jmlCol - 1
            tempMax = m_bobot(0, k)
            tempMin = m_bobot(0, k)
            For b = 0 To jmlRow - 1
                If m_bobot(b, k) > tempMax Then
                    tempMax = m_bobot(b, k)
                End If

                If m_bobot(b, k) < tempMin Then
                    tempMin = m_bobot(b, k)
                End If
            Next
            max_bobot(k) = tempMax
            min_bobot(k) = tempMin
        Next

        'Proses memasukkan data array kedalam database
        Dim InputDataMax As String = "INSERT INTO tp_normalisasi_maxmin VALUES " _
                                    & "('" & max_bobot(0) & "'," _
                                    & " '" & max_bobot(1) & "'," _
                                    & " '" & max_bobot(2) & "'," _
                                    & " '" & max_bobot(3) & "'," _
                                    & " '" & max_bobot(4) & "'," _
                                    & " '" & max_bobot(5) & "'," _
                                    & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                    & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                    & " 'MAX')"
        Conn.Close()
        Cmd = New MySqlCommand(InputDataMax, Conn)
        Conn.Open()
        Cmd.ExecuteNonQuery()

        Dim InputDataMin As String = "INSERT INTO tp_normalisasi_maxmin VALUES " _
                                    & "('" & min_bobot(0) & "'," _
                                    & " '" & min_bobot(1) & "'," _
                                    & " '" & min_bobot(2) & "'," _
                                    & " '" & min_bobot(3) & "'," _
                                    & " '" & min_bobot(4) & "'," _
                                    & " '" & min_bobot(5) & "'," _
                                    & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                    & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                    & " 'MIN')"
        Conn.Close()
        Cmd = New MySqlCommand(InputDataMin, Conn)
        Conn.Open()
        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub proses_solusi()
        Dim k As Integer
        'inisialisasi matriks m_atribut
        Dim m_atribut(jmlCol) As String
        'inisialisasi ulang matriks m_solusi
        ReDim m_solusi(2, jmlCol)

        'mengisi matriks m_atribut pada baris pertama ambil dari database
        For k = 0 To jmlCol - 1
            'm_atribut(0, k) = 'mengambil nilai dari database
        Next

        m_atribut(0) = "Benefit"
        m_atribut(1) = "Cost"
        m_atribut(2) = "Benefit"
        m_atribut(3) = "Benefit"
        m_atribut(4) = "Benefit"
        m_atribut(5) = "Benefit"

        For k = 0 To jmlCol - 1
            If m_atribut(k) = "Benefit" Then
                m_solusi(0, k) = max_bobot(k)
            Else
                m_solusi(0, k) = min_bobot(k)
            End If

            If m_atribut(k) = "Cost" Then
                m_solusi(1, k) = max_bobot(k)
            Else
                m_solusi(1, k) = min_bobot(k)
            End If
        Next
    End Sub

    Private Sub proses_jarak_ideal()
        Dim b, k As Integer
        'inisialisasi ulang matriks m_jarak_p, m_jarak_n
        ReDim m_jarak_p(jmlRow, jmlCol)
        ReDim m_jarak_n(jmlRow, jmlCol)
        'inisialisasi ulang matriks tot_jarak_p, tot_jarak_n
        ReDim tot_jarak_p(jmlRow)
        ReDim tot_jarak_n(jmlRow)

        'Jarak ideal Positif
        For b = 0 To jmlRow - 1
            For k = 0 To jmlCol - 1
                m_jarak_p(b, k) = (m_bobot(b, k) - m_solusi(0, k)) ^ 2
                tot_jarak_p(b) += m_jarak_p(b, k)
            Next
            tot_jarak_p(b) = Math.Sqrt(tot_jarak_p(b))

            'Proses memasukkan data array kedalam database            
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_solusi_jarak_positif WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_solusi_jarak_positif WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_solusi_jarak_positif)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "S" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "S" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                Dim InputDataP As String = "INSERT INTO tp_solusi_jarak_positif VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_jarak_p(b, 0) & "'," _
                                        & " '" & m_jarak_p(b, 1) & "'," _
                                        & " '" & m_jarak_p(b, 2) & "'," _
                                        & " '" & m_jarak_p(b, 3) & "'," _
                                        & " '" & m_jarak_p(b, 4) & "'," _
                                        & " '" & m_jarak_p(b, 5) & "'," _
                                        & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                        & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                        & " '" & tot_jarak_p(b) & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputDataP, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next

        'Jarak ideal Negatif
        For b = 0 To jmlRow - 1
            For k = 0 To jmlCol - 1
                m_jarak_n(b, k) = (m_bobot(b, k) - m_solusi(1, k)) ^ 2
                tot_jarak_n(b) += m_jarak_n(b, k)
            Next
            tot_jarak_n(b) = Math.Sqrt(tot_jarak_n(b))

            'Proses memasukkan data array kedalam database            
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_solusi_jarak_negatif WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_solusi_jarak_negatif WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_solusi_jarak_negatif)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "S" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "S" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                Dim InputDataN As String = "INSERT INTO tp_solusi_jarak_negatif VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_jarak_n(b, 0) & "'," _
                                        & " '" & m_jarak_n(b, 1) & "'," _
                                        & " '" & m_jarak_n(b, 2) & "'," _
                                        & " '" & m_jarak_n(b, 3) & "'," _
                                        & " '" & m_jarak_n(b, 4) & "'," _
                                        & " '" & m_jarak_n(b, 5) & "'," _
                                        & " '" & Format(Today, "yyyy-MM-dd") & "'," _
                                        & " '" & FormMenuUtama.STLabel4.Text & "'," _
                                        & " '" & tot_jarak_n(b) & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputDataN, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next
    End Sub

    Private Sub proses_hasil()
        Dim b, r As Integer
        'inisialisasi ulang matriks preferensi, m_hasil, rangking
        ReDim preferensi(jmlRow)
        ReDim m_hasil(jmlRow, 2)
        ReDim ranking(jmlRow)

        For b = 0 To jmlRow - 1
            preferensi(b) = tot_jarak_n(b) / (tot_jarak_p(b) + tot_jarak_n(b))
            m_hasil(b, 0) = preferensi(b)
            'm_hasil(b, 1) = b + 1
        Next

        'Array.Sort(preferensi)
        'Array.Reverse(preferensi)

        'For Each x As Double In preferensi
        'If x <> 0 Then
        'r = r + 1
        'For b = 0 To jmlRow - 1
        'If m_hasil(b, 0) = x Then
        'ranking(r - 1) = m_hasil(b, 1)
        'End If
        'Next
        'End If
        'Next

        For b = 0 To jmlRow - 1
            'Proses memasukkan data array kedalam database            
            Conn.Close()
            Cmd = New MySqlCommand("SELECT * FROM tp_ranking WHERE kode_CPB='" & m_analisa(b, 0) & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Not Rd.HasRows Then
                Conn.Close()
                Cmd = New MySqlCommand("SELECT * FROM tp_ranking WHERE kode IN " _
                                    & "(SELECT MAX(kode) FROM tp_ranking)", Conn)
                Conn.Open()
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Not Rd.HasRows Then
                    UrutanKode = "R" + "0001"
                Else
                    Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 4) + 1
                    UrutanKode = "R" + Microsoft.VisualBasic.Right("0000" & Hitung, 4)
                End If

                Dim InputData As String = "INSERT INTO tp_ranking VALUES " _
                                        & "('" & UrutanKode & "'," _
                                        & " '" & m_analisa(b, 0) & "'," _
                                        & " '" & m_hasil(b, 0) & "'," _
                                        & " '" & ranking(b) & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
            End If
        Next

        Conn.Close()
        Cmd = New MySqlCommand("SELECT * FROM tp_ranking ORDER BY preverensi DESC", Conn)
        Conn.Open()
        Rd = Cmd.ExecuteReader

        If Rd.HasRows Then
            Do While (Rd.Read())
                r += 1
                Dim UpdateData As String = "UPDATE tp_ranking SET ranking='" & r & "' WHERE KODE='" & Rd!KODE & "'"

                ConnUpdate.Close()
                Dim CmdUpdate = New MySqlCommand(UpdateData, ConnUpdate)
                ConnUpdate.Open()
                CmdUpdate.ExecuteNonQuery()
            Loop            
        End If

    End Sub

    Public Sub hitung_topsis()        
        For I As Integer = 0 To 100
            Application.DoEvents()
            FormPerangkingan.ProgressBar1.Value = I
            FormPerangkingan.LabelProses.Text = "Proses Perankingan ... " & I & "%"
            System.Threading.Thread.Sleep(100)
            If I = 10 Then
                Call TruncateAll()
                Call getNumRow()
                Call proses_analisa()
            ElseIf I = 25 Then
                Call proses_pangkat()
                Call proses_normalisasi()
            ElseIf I = 60 Then
                Call getBobot()
                Call proses_bobot()
            ElseIf I = 90 Then
                Call proses_solusi()
                Call proses_jarak_ideal()
                Call proses_hasil()
            End If
        Next
    End Sub
End Module
