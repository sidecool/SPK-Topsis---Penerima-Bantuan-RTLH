<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPekerjaanKepalaKeluargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataJumlahPenghasilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataJumlahTanggunganJiwaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKondisiAtapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKondisiDindingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKondisiLantaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCPBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataCalonPenerimaBantuanCPBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeleksiCalonPenerimaBantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.HistoriSeleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanRankingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPenerimaBantuanPerDistrikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPenerimaBantuanPerKelurahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.STLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.STLabel10 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LimeGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PenggunaToolStripMenuItem, Me.DataKriteriaToolStripMenuItem, Me.DataCPBToolStripMenuItem, Me.SeleksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(836, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.LogoutToolStripMenuItem1, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.FileToolStripMenuItem.Text = "Start"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.GantiPasswordToolStripMenuItem})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPekerjaanKepalaKeluargaToolStripMenuItem, Me.DataJumlahPenghasilanToolStripMenuItem, Me.DataJumlahTanggunganJiwaToolStripMenuItem, Me.DataKondisiAtapToolStripMenuItem, Me.DataKondisiDindingToolStripMenuItem, Me.DataKondisiLantaiToolStripMenuItem})
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.DataKriteriaToolStripMenuItem.Text = "Master Data Kriteria"
        '
        'DataPekerjaanKepalaKeluargaToolStripMenuItem
        '
        Me.DataPekerjaanKepalaKeluargaToolStripMenuItem.Name = "DataPekerjaanKepalaKeluargaToolStripMenuItem"
        Me.DataPekerjaanKepalaKeluargaToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataPekerjaanKepalaKeluargaToolStripMenuItem.Text = "Data Pekerjaan Kepala Keluarga"
        '
        'DataJumlahPenghasilanToolStripMenuItem
        '
        Me.DataJumlahPenghasilanToolStripMenuItem.Name = "DataJumlahPenghasilanToolStripMenuItem"
        Me.DataJumlahPenghasilanToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataJumlahPenghasilanToolStripMenuItem.Text = "Data Jumlah Penghasilan Perbualan"
        '
        'DataJumlahTanggunganJiwaToolStripMenuItem
        '
        Me.DataJumlahTanggunganJiwaToolStripMenuItem.Name = "DataJumlahTanggunganJiwaToolStripMenuItem"
        Me.DataJumlahTanggunganJiwaToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataJumlahTanggunganJiwaToolStripMenuItem.Text = "Data Jumlah Tanggungan Jiwa"
        '
        'DataKondisiAtapToolStripMenuItem
        '
        Me.DataKondisiAtapToolStripMenuItem.Name = "DataKondisiAtapToolStripMenuItem"
        Me.DataKondisiAtapToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataKondisiAtapToolStripMenuItem.Text = "Data Kondisi Atap"
        '
        'DataKondisiDindingToolStripMenuItem
        '
        Me.DataKondisiDindingToolStripMenuItem.Name = "DataKondisiDindingToolStripMenuItem"
        Me.DataKondisiDindingToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataKondisiDindingToolStripMenuItem.Text = "Data Kondisi Dinding"
        '
        'DataKondisiLantaiToolStripMenuItem
        '
        Me.DataKondisiLantaiToolStripMenuItem.Name = "DataKondisiLantaiToolStripMenuItem"
        Me.DataKondisiLantaiToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.DataKondisiLantaiToolStripMenuItem.Text = "Data Kondisi Lantai"
        '
        'DataCPBToolStripMenuItem
        '
        Me.DataCPBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataCalonPenerimaBantuanCPBToolStripMenuItem})
        Me.DataCPBToolStripMenuItem.Name = "DataCPBToolStripMenuItem"
        Me.DataCPBToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DataCPBToolStripMenuItem.Text = "Data CPB"
        '
        'DataCalonPenerimaBantuanCPBToolStripMenuItem
        '
        Me.DataCalonPenerimaBantuanCPBToolStripMenuItem.Name = "DataCalonPenerimaBantuanCPBToolStripMenuItem"
        Me.DataCalonPenerimaBantuanCPBToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.DataCalonPenerimaBantuanCPBToolStripMenuItem.Text = "Data Calon Penerima Bantuan (CPB)"
        '
        'SeleksiToolStripMenuItem
        '
        Me.SeleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleksiCalonPenerimaBantuanToolStripMenuItem, Me.ToolStripMenuItem1, Me.HistoriSeleksiToolStripMenuItem})
        Me.SeleksiToolStripMenuItem.Name = "SeleksiToolStripMenuItem"
        Me.SeleksiToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SeleksiToolStripMenuItem.Text = "Seleksi"
        '
        'SeleksiCalonPenerimaBantuanToolStripMenuItem
        '
        Me.SeleksiCalonPenerimaBantuanToolStripMenuItem.Name = "SeleksiCalonPenerimaBantuanToolStripMenuItem"
        Me.SeleksiCalonPenerimaBantuanToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.SeleksiCalonPenerimaBantuanToolStripMenuItem.Text = "Seleksi Calon Penerima Bantuan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(240, 6)
        '
        'HistoriSeleksiToolStripMenuItem
        '
        Me.HistoriSeleksiToolStripMenuItem.Name = "HistoriSeleksiToolStripMenuItem"
        Me.HistoriSeleksiToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.HistoriSeleksiToolStripMenuItem.Text = "Histori Seleksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanRankingToolStripMenuItem, Me.LaporanPenerimaBantuanPerDistrikToolStripMenuItem, Me.LaporanPenerimaBantuanPerKelurahanToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanRankingToolStripMenuItem
        '
        Me.LaporanRankingToolStripMenuItem.Name = "LaporanRankingToolStripMenuItem"
        Me.LaporanRankingToolStripMenuItem.Size = New System.Drawing.Size(293, 22)
        Me.LaporanRankingToolStripMenuItem.Text = "Laporan Ranking"
        '
        'LaporanPenerimaBantuanPerDistrikToolStripMenuItem
        '
        Me.LaporanPenerimaBantuanPerDistrikToolStripMenuItem.Name = "LaporanPenerimaBantuanPerDistrikToolStripMenuItem"
        Me.LaporanPenerimaBantuanPerDistrikToolStripMenuItem.Size = New System.Drawing.Size(293, 22)
        Me.LaporanPenerimaBantuanPerDistrikToolStripMenuItem.Text = "Laporan Penerima Bantuan Per Distrik"
        '
        'LaporanPenerimaBantuanPerKelurahanToolStripMenuItem
        '
        Me.LaporanPenerimaBantuanPerKelurahanToolStripMenuItem.Name = "LaporanPenerimaBantuanPerKelurahanToolStripMenuItem"
        Me.LaporanPenerimaBantuanPerKelurahanToolStripMenuItem.Size = New System.Drawing.Size(293, 22)
        Me.LaporanPenerimaBantuanPerKelurahanToolStripMenuItem.Text = "Laporan Penerima Bantuan Per Kelurahan"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(836, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SISTEM PENDUKUNG KEPUTUSAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(836, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KELAYAKAN PENERIMA BANTUAN REHABILITASI RUMAH TIDAK LAYAK HUNI (RTLH)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(836, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DI KABUPATEN MERAUKE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.AppPerumahan.My.Resources.Resources._46
        Me.PictureBox2.Location = New System.Drawing.Point(321, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 192)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Silver
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STLabel1, Me.STLabel2, Me.STLabel3, Me.STLabel4, Me.STLabel5, Me.STLabel6, Me.STLabel7, Me.STLabel8, Me.STLabel9, Me.STLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 380)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(836, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STLabel1
        '
        Me.STLabel1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.STLabel1.Name = "STLabel1"
        Me.STLabel1.Size = New System.Drawing.Size(40, 17)
        Me.STLabel1.Text = "Kode :"
        '
        'STLabel2
        '
        Me.STLabel2.Name = "STLabel2"
        Me.STLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel3
        '
        Me.STLabel3.Name = "STLabel3"
        Me.STLabel3.Size = New System.Drawing.Size(51, 17)
        Me.STLabel3.Text = " Nama : "
        '
        'STLabel4
        '
        Me.STLabel4.Name = "STLabel4"
        Me.STLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel5
        '
        Me.STLabel5.Name = "STLabel5"
        Me.STLabel5.Size = New System.Drawing.Size(43, 17)
        Me.STLabel5.Text = "Level : "
        '
        'STLabel6
        '
        Me.STLabel6.Name = "STLabel6"
        Me.STLabel6.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel7
        '
        Me.STLabel7.Name = "STLabel7"
        Me.STLabel7.Size = New System.Drawing.Size(37, 17)
        Me.STLabel7.Text = "Jam : "
        '
        'STLabel8
        '
        Me.STLabel8.Name = "STLabel8"
        Me.STLabel8.Size = New System.Drawing.Size(0, 17)
        '
        'STLabel9
        '
        Me.STLabel9.Name = "STLabel9"
        Me.STLabel9.Size = New System.Drawing.Size(57, 17)
        Me.STLabel9.Text = "Tanggal : "
        '
        'STLabel10
        '
        Me.STLabel10.Name = "STLabel10"
        Me.STLabel10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 402)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Form Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPekerjaanKepalaKeluargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataJumlahPenghasilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataJumlahTanggunganJiwaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKondisiAtapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKondisiDindingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKondisiLantaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents STLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SeleksiCalonPenerimaBantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCPBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataCalonPenerimaBantuanCPBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HistoriSeleksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanRankingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenerimaBantuanPerDistrikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenerimaBantuanPerKelurahanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
