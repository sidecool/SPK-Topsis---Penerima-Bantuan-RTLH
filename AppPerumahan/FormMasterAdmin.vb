Imports MySql.Data.MySqlClient

Public Class FormMasterUser
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        CheckBoxSP.Checked = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Conn.Close()
        Da = New MySqlDataAdapter("Select kode_user,nama_user,level_user from tbl_user", Conn)
        Conn.Open()
        Ds = New DataSet
        Da.Fill(Ds, "tbl_user")
        DataGridView1.DataSource = Ds.Tables("tbl_user")
        DataGridView1.ReadOnly = True

    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("PIMPINAN")
        ComboBox1.Items.Add("USER")
    End Sub
    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim InputData As String = "insert into tbl_user values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim UpdateData As String = "update tbl_user set nama_user='" & TextBox2.Text & "',password_user='" & TextBox3.Text & "',level_user='" & ComboBox1.Text & "' where kode_user='" & TextBox1.Text & "'"
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
            Cmd = New MySqlCommand("Select * from tbl_user where kode_user='" & TextBox1.Text & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Admin tidak ada")
            Else
                TextBox1.Text = Rd.Item("kode_user")
                TextBox2.Text = Rd.Item("nama_user")
                TextBox3.Text = Rd.Item("password_user")
                ComboBox1.Text = Rd.Item("level_user")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi semua field")
            Else

                Dim HapusData As String = "Delete from tbl_user where kode_user='" & TextBox1.Text & "'"
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
        Cmd = New MySqlCommand("Select * from tbl_user where kode_user in (select max(kode_user) from tbl_user)", Conn)
        Conn.Open()

        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "ADM" + "01"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 2) + 1
            UrutanKode = "ADM" + Microsoft.VisualBasic.Right("00" & Hitung, 2)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub CheckBoxSP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSP.CheckedChanged
        If CheckBoxSP.Checked Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub
End Class