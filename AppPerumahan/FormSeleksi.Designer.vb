<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeleksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSeleksi))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBLTanggal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CbKerja = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CbGaji = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CbTanggungan = New System.Windows.Forms.ComboBox
        Me.CbAtap = New System.Windows.Forms.ComboBox
        Me.CbDinding = New System.Windows.Forms.ComboBox
        Me.CbLantai = New System.Windows.Forms.ComboBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnCreate = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.LBLAdmin = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CbCPB = New System.Windows.Forms.ComboBox
        Me.BtnProses = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Nama Calon Penerima Bantuan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 21)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tanggal Seleksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 21)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Kode Seleksi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.ForeColor = System.Drawing.Color.Black
        Me.LBLTanggal.Location = New System.Drawing.Point(250, 49)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(244, 22)
        Me.LBLTanggal.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 21)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Pekerjaan Kepala Keluarga"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 21)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Jumlah Penghasilan Perbulan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbKerja
        '
        Me.CbKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbKerja.FormattingEnabled = True
        Me.CbKerja.Location = New System.Drawing.Point(250, 130)
        Me.CbKerja.Name = "CbKerja"
        Me.CbKerja.Size = New System.Drawing.Size(300, 21)
        Me.CbKerja.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 21)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Jumlah Tanggungan Jiwa"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbGaji
        '
        Me.CbGaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbGaji.FormattingEnabled = True
        Me.CbGaji.Location = New System.Drawing.Point(250, 153)
        Me.CbGaji.Name = "CbGaji"
        Me.CbGaji.Size = New System.Drawing.Size(300, 21)
        Me.CbGaji.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 21)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Kondisi Atap"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(236, 21)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Kondisi Dinding"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 21)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Kondisi Lantai"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbTanggungan
        '
        Me.CbTanggungan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTanggungan.FormattingEnabled = True
        Me.CbTanggungan.Location = New System.Drawing.Point(250, 245)
        Me.CbTanggungan.Name = "CbTanggungan"
        Me.CbTanggungan.Size = New System.Drawing.Size(300, 21)
        Me.CbTanggungan.TabIndex = 7
        '
        'CbAtap
        '
        Me.CbAtap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAtap.DropDownWidth = 800
        Me.CbAtap.FormattingEnabled = True
        Me.CbAtap.Location = New System.Drawing.Point(250, 176)
        Me.CbAtap.Name = "CbAtap"
        Me.CbAtap.Size = New System.Drawing.Size(300, 21)
        Me.CbAtap.TabIndex = 4
        '
        'CbDinding
        '
        Me.CbDinding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDinding.DropDownWidth = 800
        Me.CbDinding.FormattingEnabled = True
        Me.CbDinding.Location = New System.Drawing.Point(250, 199)
        Me.CbDinding.Name = "CbDinding"
        Me.CbDinding.Size = New System.Drawing.Size(300, 21)
        Me.CbDinding.TabIndex = 5
        '
        'CbLantai
        '
        Me.CbLantai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLantai.DropDownWidth = 800
        Me.CbLantai.FormattingEnabled = True
        Me.CbLantai.Location = New System.Drawing.Point(250, 222)
        Me.CbLantai.Name = "CbLantai"
        Me.CbLantai.Size = New System.Drawing.Size(300, 21)
        Me.CbLantai.TabIndex = 6
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Brown
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(263, 305)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(92, 34)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Hapus"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Brown
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(166, 305)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(91, 34)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Edit"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.Brown
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.Color.White
        Me.BtnCreate.Image = CType(resources.GetObject("BtnCreate.Image"), System.Drawing.Image)
        Me.BtnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCreate.Location = New System.Drawing.Point(71, 305)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(89, 34)
        Me.BtnCreate.TabIndex = 8
        Me.BtnCreate.Text = "Input"
        Me.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(236, 21)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Pengguna"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.ForeColor = System.Drawing.Color.Black
        Me.LBLAdmin.Location = New System.Drawing.Point(250, 74)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(244, 22)
        Me.LBLAdmin.TabIndex = 52
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Brown
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(361, 305)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 34)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "Tutup"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(250, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 73
        '
        'CbCPB
        '
        Me.CbCPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCPB.FormattingEnabled = True
        Me.CbCPB.Location = New System.Drawing.Point(250, 99)
        Me.CbCPB.Name = "CbCPB"
        Me.CbCPB.Size = New System.Drawing.Size(300, 21)
        Me.CbCPB.TabIndex = 1
        '
        'BtnProses
        '
        Me.BtnProses.BackColor = System.Drawing.Color.Brown
        Me.BtnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProses.ForeColor = System.Drawing.Color.White
        Me.BtnProses.Image = CType(resources.GetObject("BtnProses.Image"), System.Drawing.Image)
        Me.BtnProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProses.Location = New System.Drawing.Point(459, 305)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(92, 34)
        Me.BtnProses.TabIndex = 76
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProses.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(571, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(469, 320)
        Me.DataGridView1.TabIndex = 77
        '
        'FormSeleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1052, 360)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CbCPB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.CbLantai)
        Me.Controls.Add(Me.CbDinding)
        Me.Controls.Add(Me.CbAtap)
        Me.Controls.Add(Me.CbTanggungan)
        Me.Controls.Add(Me.CbGaji)
        Me.Controls.Add(Me.CbKerja)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormSeleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSeleksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbKerja As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CbGaji As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CbTanggungan As System.Windows.Forms.ComboBox
    Friend WithEvents CbAtap As System.Windows.Forms.ComboBox
    Friend WithEvents CbDinding As System.Windows.Forms.ComboBox
    Friend WithEvents CbLantai As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CbCPB As System.Windows.Forms.ComboBox
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
