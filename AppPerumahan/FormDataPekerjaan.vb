Imports MySql.Data.MySqlClient

Public Class FormDataPekerjaan
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = "-- Pilih Pekerjaan --"
        TextBox1.Enabled = False
        ComboBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Conn.Close()
        Da = New MySqlDataAdapter("Select * from tbl_pekerjaan", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pekerjaan")
        DataGridView1.DataSource = Ds.Tables("tbl_pekerjaan")
        DataGridView1.ReadOnly = True

    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("Wiraswasta")
        ComboBox1.Items.Add("Buruh")
        ComboBox1.Items.Add("Sopir Taxi/Gojek")
        ComboBox1.Items.Add("Petani/Perkebun")
    End Sub

    Private Sub FormDataPekerjaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            Call NomorOtomatis()
            TextBox1.Enabled = False
            ComboBox1.Focus()
        Else
            If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim InputData As String = "insert into tbl_pekerjaan values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                Conn.Close()
                Cmd = New MySqlCommand(InputData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim UpdateData As String = "update tbl_pekerjaan set pekerjaan='" & ComboBox1.Text & "',bobot='" & TextBox2.Text & "',nilai='" & TextBox3.Text & "' where kode_pekerjaan='" & TextBox1.Text & "'"
                Conn.Close()
                Cmd = New MySqlCommand(UpdateData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Conn.Close()
            Cmd = New MySqlCommand("Select * from tbl_pekerjaan where kode_pekerjaan='" & TextBox1.Text & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Pekerjaan tidak ada")
            Else
                TextBox1.Text = Rd.Item("Kode_Pekerjaan")
                ComboBox1.Text = Rd.Item("pekerjaan")
                TextBox2.Text = Rd.Item("Bobot")
                TextBox3.Text = Rd.Item("Nilai")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim HapusData As String = "Delete from tbl_pekerjaan where kode_pekerjaan='" & TextBox1.Text & "'"
                Conn.Close()
                Cmd = New MySqlCommand(HapusData, Conn)
                Conn.Open()
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Sub NomorOtomatis()
        Conn.Close()
        Cmd = New MySqlCommand("Select * from tbl_pekerjaan where kode_pekerjaan in (select max(kode_pekerjaan) from tbl_pekerjaan)", Conn)
        Conn.Open()
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "01"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 2) + 1
            UrutanKode = Microsoft.VisualBasic.Right("00" & Hitung, 2)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            If DataGridView1.Item(0, e.RowIndex).Value <> "" Then
                If Button2.Text = "Edit" Then
                    Button2_Click(sender, e)
                End If

                TextBox1.Text = DataGridView1.Item(0, e.RowIndex).Value
                TextBox1.Focus()
            End If
        End If
    End Sub

End Class