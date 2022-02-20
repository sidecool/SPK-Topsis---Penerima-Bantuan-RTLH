Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem1.Visible = False
        FormMenuUtama.UserToolStripMenuItem.Visible = True
        FormMenuUtama.LogoutToolStripMenuItem1.Visible = True
        FormMenuUtama.PenggunaToolStripMenuItem.Visible = True
        FormMenuUtama.DataKriteriaToolStripMenuItem.Visible = True
        FormMenuUtama.DataCPBToolStripMenuItem.Visible = True
        FormMenuUtama.SeleksiToolStripMenuItem.Visible = True        
        FormMenuUtama.LaporanToolStripMenuItem.Visible = True
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username dan Password Tidak Boleh Kosong")
        Else
            Conn.Close()
            Cmd = New MySqlCommand("Select * from tbl_user where nama_user='" & TextBox1.Text & "' and password_user='" & TextBox2.Text & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
                Me.Close()
                FormMenuUtama.STLabel2.Text = Rd!kode_user
                FormMenuUtama.STLabel4.Text = Rd!nama_user
                FormMenuUtama.STLabel6.Text = Rd!level_user

                FormMenuUtama.GantiPasswordToolStripMenuItem.Visible = False

                If FormMenuUtama.STLabel6.Text = "PIMPINAN" Then
                    FormMenuUtama.LoginToolStripMenuItem1.Visible = False
                    FormMenuUtama.LogoutToolStripMenuItem1.Visible = True
                    FormMenuUtama.UserToolStripMenuItem.Visible = False
                    FormMenuUtama.SeleksiToolStripMenuItem.Visible = True
                    FormMenuUtama.SeleksiCalonPenerimaBantuanToolStripMenuItem.Visible = False
                    FormMenuUtama.LaporanToolStripMenuItem.Visible = True
                ElseIf FormMenuUtama.STLabel6.Text = "USER" Then
                    FormMenuUtama.LoginToolStripMenuItem1.Visible = False
                    FormMenuUtama.LogoutToolStripMenuItem1.Visible = True
                    FormMenuUtama.UserToolStripMenuItem.Visible = False
                    FormMenuUtama.DataCPBToolStripMenuItem.Visible = True
                    FormMenuUtama.SeleksiToolStripMenuItem.Visible = True
                    FormMenuUtama.SeleksiCalonPenerimaBantuanToolStripMenuItem.Visible = True
                    FormMenuUtama.LaporanToolStripMenuItem.Visible = True
                Else
                    Call Terbuka()
                    FormMenuUtama.UserToolStripMenuItem.Visible = True
                    FormMenuUtama.SeleksiCalonPenerimaBantuanToolStripMenuItem.Visible = True
                End If
            Else
                MsgBox("Username atau Password Salah")
            End If
        End If
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        TextBox1.Focus()
    End Sub

    Private Sub CheckBoxSP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSP.CheckedChanged
        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ButtonLogin_Click(sender, e)
        End If
    End Sub
End Class