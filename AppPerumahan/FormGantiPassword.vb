Imports MySql.Data.MySqlClient

Public Class FormGantiPassword

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxPassLama.UseSystemPasswordChar = False
            TextBoxPassBaru.UseSystemPasswordChar = False
            TextBoxPassKonf.UseSystemPasswordChar = False
        Else
            TextBoxPassLama.UseSystemPasswordChar = True
            TextBoxPassBaru.UseSystemPasswordChar = True
            TextBoxPassKonf.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBoxPassLama.Text <> "" And TextBoxPassBaru.Text <> "" And TextBoxPassKonf.Text <> "" Then
            If TextBoxPassKonf.Text <> TextBoxPassBaru.Text Then
                MsgBox("Konfirmasi Password Baru tidak sama dengan Password Baru, silahkan periksa kembali.")
                TextBoxPassKonf.Focus()
                Exit Sub
            End If

            Conn.Close()
            Cmd = New MySqlCommand("Select password_user from tbl_user where kode_user='" & FormMenuUtama.STLabel2.Text & "'", Conn)
            Conn.Open()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                If TextBoxPassLama.Text = Rd!password_user Then
                    ConnUpdate.Close()
                    Cmd = New MySqlCommand("update tbl_user set password_user='" & TextBoxPassKonf.Text & "' where kode_user='" & FormMenuUtama.STLabel2.Text & "'", ConnUpdate)
                    ConnUpdate.Open()
                    Try
                        Cmd.ExecuteNonQuery()
                        MsgBox("Password berhasil diganti.")
                    Catch
                        MsgBox("Password gagal diganti.")
                    End Try
                End If
            Else
                MsgBox("Password lama salah, silahkan pastikan password sesuai.")
            End If
        Else
            MsgBox("Form harus diisi semua, silahkan lengkapi isian form")
            Exit Sub
        End If
    End Sub
End Class