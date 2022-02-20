<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKoneksi
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
        Me.btnTutup = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnCek = New System.Windows.Forms.Button
        Me.TBDatabase = New System.Windows.Forms.TextBox
        Me.TBPass = New System.Windows.Forms.TextBox
        Me.TBUser = New System.Windows.Forms.TextBox
        Me.TBPort = New System.Windows.Forms.TextBox
        Me.TBServer = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(253, 177)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 25
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nama Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "User Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Port Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Server Host"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(172, 177)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(27, 177)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(122, 23)
        Me.btnCek.TabIndex = 18
        Me.btnCek.Text = "Cek Koneksi"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'TBDatabase
        '
        Me.TBDatabase.Location = New System.Drawing.Point(125, 126)
        Me.TBDatabase.Name = "TBDatabase"
        Me.TBDatabase.Size = New System.Drawing.Size(203, 20)
        Me.TBDatabase.TabIndex = 17
        '
        'TBPass
        '
        Me.TBPass.Location = New System.Drawing.Point(125, 100)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Size = New System.Drawing.Size(203, 20)
        Me.TBPass.TabIndex = 16
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(125, 74)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(203, 20)
        Me.TBUser.TabIndex = 15
        '
        'TBPort
        '
        Me.TBPort.Location = New System.Drawing.Point(125, 48)
        Me.TBPort.Name = "TBPort"
        Me.TBPort.Size = New System.Drawing.Size(96, 20)
        Me.TBPort.TabIndex = 14
        '
        'TBServer
        '
        Me.TBServer.Location = New System.Drawing.Point(125, 22)
        Me.TBServer.Name = "TBServer"
        Me.TBServer.Size = New System.Drawing.Size(203, 20)
        Me.TBServer.TabIndex = 13
        '
        'FormKoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(352, 223)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.TBDatabase)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.TBPort)
        Me.Controls.Add(Me.TBServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormKoneksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKoneksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCek As System.Windows.Forms.Button
    Friend WithEvents TBDatabase As System.Windows.Forms.TextBox
    Friend WithEvents TBPass As System.Windows.Forms.TextBox
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBPort As System.Windows.Forms.TextBox
    Friend WithEvents TBServer As System.Windows.Forms.TextBox
End Class
