Public Class FormMenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem1.Visible = True        
        LogoutToolStripMenuItem1.Visible = False
        PenggunaToolStripMenuItem.Visible = False
        DataKriteriaToolStripMenuItem.Visible = False
        DataCPBToolStripMenuItem.Visible = False
        SeleksiToolStripMenuItem.Visible = False        
        LaporanToolStripMenuItem.Visible = False
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""

        Call Tengah()
    End Sub

    Sub Tengah()
        Label1.Left = (Label1.Parent.Width \ 2) - (Label1.Width \ 2)
        Label2.Left = (Label2.Parent.Width \ 2) - (Label2.Width \ 2)
        Label3.Left = (Label3.Parent.Width \ 2) - (Label3.Width \ 2)
        PictureBox2.Left = (PictureBox2.Parent.Width \ 2) - (PictureBox2.Width \ 2)
    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        My.Application.ChangeCulture("en-US")

        Call Terkunci()
        STLabel10.Text = Today
        FormKoneksi.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Call Terkunci()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        FormMasterUser.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay
    End Sub

    Private Sub DataPekerjaanKepalaKeluargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPekerjaanKepalaKeluargaToolStripMenuItem.Click
        FormDataPekerjaan.ShowDialog()
    End Sub

    Private Sub DataJumlahPenghasilanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJumlahPenghasilanToolStripMenuItem.Click
        FormDataPenghasilan.ShowDialog()
    End Sub

    Private Sub DataJumlahTanggunganJiwaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJumlahTanggunganJiwaToolStripMenuItem.Click
        FormDatatanggungan.ShowDialog()
    End Sub

    Private Sub DataKondisiAtapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKondisiAtapToolStripMenuItem.Click
        FormDataAtap.ShowDialog()
    End Sub

    Private Sub DataKondisiDindingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKondisiDindingToolStripMenuItem.Click
        FormDataDinding.ShowDialog()
    End Sub

    Private Sub DataKondisiLantaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKondisiLantaiToolStripMenuItem.Click
        FormDataLantai.ShowDialog()
    End Sub

    Private Sub SeleksiCalonPenerimaBantuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleksiCalonPenerimaBantuanToolStripMenuItem.Click
        FormSeleksi.ShowDialog()
    End Sub

    Private Sub DataCalonPenerimaBantuanCPBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataCalonPenerimaBantuanCPBToolStripMenuItem.Click
        FormDataCPB.ShowDialog()
    End Sub

    Private Sub FormMenuUtama_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.Visible = True Then
            Call Tengah()
        End If
    End Sub

    Private Sub HistoriSeleksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoriSeleksiToolStripMenuItem.Click
        FormHistori.ShowDialog()
    End Sub

    Private Sub LaporanRankingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanRankingToolStripMenuItem.Click
        FormLaporan.JenisLaporan = "ranking"
        FormLaporan.ShowDialog()
    End Sub

    Private Sub LaporanPenerimaBantuanPerDistrikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenerimaBantuanPerDistrikToolStripMenuItem.Click
        FormLaporan.JenisLaporan = "distrik"
        FormLaporan.ShowDialog()
    End Sub

    Private Sub LaporanPenerimaBantuanPerKelurahanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenerimaBantuanPerKelurahanToolStripMenuItem.Click
        FormLaporan.JenisLaporan = "kelurahan"
        FormLaporan.ShowDialog()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        FormGantiPassword.ShowDialog()
    End Sub
End Class
