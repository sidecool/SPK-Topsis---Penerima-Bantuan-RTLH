Public Class FormKoneksi
    Dim Is_Connected As Boolean = False

    Private Sub btnCek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek.Click
        If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
            MsgBox("Database terhubung", MsgBoxStyle.Information, "Informasi")
        Else
            MsgBox("Database tidak terhubung", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub TBServer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBServer.KeyDown, TBUser.KeyDown, TBPort.KeyDown, TBPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            ProcessTabKey(True)
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"

        WriteIni(FilePath, "ConfigDB", "Server", TBServer.Text)
        WriteIni(FilePath, "ConfigDB", "Port", TBPort.Text)
        WriteIni(FilePath, "ConfigDB", "User", TBUser.Text)
        WriteIni(FilePath, "ConfigDB", "Password", TBPass.Text)
        WriteIni(FilePath, "ConfigDB", "DBName", TBDatabase.Text)
        MsgBox("Konfigurasi berhasil disimpan", MsgBoxStyle.Information, "Informasi")
        If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
            Is_Connected = True
            Me.Close()
        Else
            MsgBox("Database belum terhubung", MsgBoxStyle.Information, "Informasi")
            Is_Connected = False
        End If
    End Sub

    Private Sub FormKoneksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'menyiapkan string untuk menampung lokasi file .ini 
        Dim FilePath As String = Application.StartupPath & "\setting.ini"

        TBServer.Text = ReadIni(FilePath, "ConfigDB", "Server", "")
        TBPort.Text = ReadIni(FilePath, "ConfigDB", "Port", "")
        TBUser.Text = ReadIni(FilePath, "ConfigDB", "User", "")
        TBPass.Text = ReadIni(FilePath, "ConfigDB", "Password", "")
        TBDatabase.Text = ReadIni(FilePath, "ConfigDB", "DBName", "")

        If cek_koneksi(TBServer.Text, TBPort.Text, TBUser.Text, TBPass.Text, TBDatabase.Text) = True Then
            Is_Connected = True
            Me.Close()
        End If
    End Sub

    Private Sub FormKoneksi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Is_Connected = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub
End Class