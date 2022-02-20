Imports MySql.Data.MySqlClient

Public Class FormDataCPB    
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedIndex = -1
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Conn.Close()
        Da = New MySqlDataAdapter("Select * from tbl_cpb where status='A'", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds, "tbl_cpb")
        DataGridView1.DataSource = Ds.Tables("tbl_cpb")
        DataGridView1.ReadOnly = True

    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub FormDataCPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.SelectedIndex = -1 Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim InputData As String = "insert into tbl_CPB values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','A')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.SelectedIndex = -1 Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim UpdateData As String = "update tbl_CPB set no_KK='" & TextBox2.Text & "',nama_kepala_keluarga='" & TextBox3.Text & "',alamat='" & TextBox4.Text & "',RT='" & TextBox5.Text & "',kelurahan='" & TextBox6.Text & "',distrik='" & ComboBox1.Text & "' where kode_CPB='" & TextBox1.Text & "'"
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
            Cmd = New MySqlCommand("Select * from tbl_CPB where kode_CPB='" & TextBox1.Text & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode CPB tidak ada")
            Else
                TextBox1.Text = Rd.Item("Kode_CPB")
                TextBox2.Text = Rd.Item("No_KK")
                TextBox3.Text = Rd.Item("Nama_Kepala_Keluarga")
                TextBox4.Text = Rd.Item("Alamat")
                TextBox5.Text = Rd.Item("RT")
                TextBox6.Text = Rd.Item("kelurahan")
                ComboBox1.SelectedIndex = ComboBox1.FindString(Rd.Item("Distrik"))
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.SelectedIndex = -1 Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim HapusData As String = "Delete from tbl_CPB where kode_CPB='" & TextBox1.Text & "'"
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
        Cmd = New MySqlCommand("Select * from tbl_cpb where kode_CPB in (select max(kode_CPB) from tbl_cpb)", Conn)
        Conn.Open()
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "C" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "C" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
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