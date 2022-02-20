<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CbDistrik = New System.Windows.Forms.ComboBox
        Me.LblDistrik = New System.Windows.Forms.Label
        Me.LblKelurahan = New System.Windows.Forms.Label
        Me.BtnGoLurah = New System.Windows.Forms.Button
        Me.TBKelurahan = New System.Windows.Forms.TextBox
        Me.RBOrder = New System.Windows.Forms.RadioButton
        Me.LblTop = New System.Windows.Forms.Label
        Me.BtnGO = New System.Windows.Forms.Button
        Me.TBTop = New System.Windows.Forms.TextBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RBOrder)
        Me.Panel1.Controls.Add(Me.LblTop)
        Me.Panel1.Controls.Add(Me.BtnGO)
        Me.Panel1.Controls.Add(Me.TBTop)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 83)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CbDistrik)
        Me.Panel2.Controls.Add(Me.LblDistrik)
        Me.Panel2.Controls.Add(Me.LblKelurahan)
        Me.Panel2.Controls.Add(Me.BtnGoLurah)
        Me.Panel2.Controls.Add(Me.TBKelurahan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(474, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 83)
        Me.Panel2.TabIndex = 9
        '
        'CbDistrik
        '
        Me.CbDistrik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDistrik.FormattingEnabled = True
        Me.CbDistrik.Items.AddRange(New Object() {"--- Semua Distrik ---", "Distrik Merauke", "Distrik Semangga", "Distrik Tanah Miring", "Distrik Jagebob", "Distrik Kurik", "Distrik Animha", "Distrik Malind", "Distrik Okaba", "Distrik Ngguti", "Distrik Ilwayap", "Distrik Kimaam", "Distrik Tabonji", "Distrik Waan", "Distrik Tubang", "Distrik Kaptel", "Distrik Sota", "Distrik Naukenjerai", "Distrik Muting", "Distrik Ulilin", "Distrik Elikobel"})
        Me.CbDistrik.Location = New System.Drawing.Point(96, 16)
        Me.CbDistrik.Name = "CbDistrik"
        Me.CbDistrik.Size = New System.Drawing.Size(280, 21)
        Me.CbDistrik.TabIndex = 15
        '
        'LblDistrik
        '
        Me.LblDistrik.AutoSize = True
        Me.LblDistrik.Location = New System.Drawing.Point(35, 20)
        Me.LblDistrik.Name = "LblDistrik"
        Me.LblDistrik.Size = New System.Drawing.Size(36, 13)
        Me.LblDistrik.TabIndex = 14
        Me.LblDistrik.Text = "Distrik"
        '
        'LblKelurahan
        '
        Me.LblKelurahan.AutoSize = True
        Me.LblKelurahan.Location = New System.Drawing.Point(35, 45)
        Me.LblKelurahan.Name = "LblKelurahan"
        Me.LblKelurahan.Size = New System.Drawing.Size(55, 13)
        Me.LblKelurahan.TabIndex = 11
        Me.LblKelurahan.Text = "Kelurahan"
        '
        'BtnGoLurah
        '
        Me.BtnGoLurah.Location = New System.Drawing.Point(340, 40)
        Me.BtnGoLurah.Name = "BtnGoLurah"
        Me.BtnGoLurah.Size = New System.Drawing.Size(37, 23)
        Me.BtnGoLurah.TabIndex = 10
        Me.BtnGoLurah.Text = "Go"
        Me.BtnGoLurah.UseVisualStyleBackColor = True
        '
        'TBKelurahan
        '
        Me.TBKelurahan.Location = New System.Drawing.Point(96, 42)
        Me.TBKelurahan.Name = "TBKelurahan"
        Me.TBKelurahan.Size = New System.Drawing.Size(236, 20)
        Me.TBKelurahan.TabIndex = 9
        '
        'RBOrder
        '
        Me.RBOrder.AutoSize = True
        Me.RBOrder.Location = New System.Drawing.Point(15, 43)
        Me.RBOrder.Name = "RBOrder"
        Me.RBOrder.Size = New System.Drawing.Size(108, 17)
        Me.RBOrder.TabIndex = 5
        Me.RBOrder.TabStop = True
        Me.RBOrder.Text = "Order by Ranking"
        Me.RBOrder.UseVisualStyleBackColor = True
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Location = New System.Drawing.Point(12, 20)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(86, 13)
        Me.LblTop.TabIndex = 3
        Me.LblTop.Text = "Ranking Teratas"
        '
        'BtnGO
        '
        Me.BtnGO.Location = New System.Drawing.Point(172, 15)
        Me.BtnGO.Name = "BtnGO"
        Me.BtnGO.Size = New System.Drawing.Size(39, 23)
        Me.BtnGO.TabIndex = 2
        Me.BtnGO.Text = "Go"
        Me.BtnGO.UseVisualStyleBackColor = True
        '
        'TBTop
        '
        Me.TBTop.Location = New System.Drawing.Point(104, 17)
        Me.TBTop.Name = "TBTop"
        Me.TBTop.Size = New System.Drawing.Size(62, 20)
        Me.TBTop.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 83)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(860, 298)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 381)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormLaporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnGO As System.Windows.Forms.Button
    Friend WithEvents TBTop As System.Windows.Forms.TextBox
    Friend WithEvents LblTop As System.Windows.Forms.Label
    Friend WithEvents RBOrder As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblKelurahan As System.Windows.Forms.Label
    Friend WithEvents BtnGoLurah As System.Windows.Forms.Button
    Friend WithEvents TBKelurahan As System.Windows.Forms.TextBox
    Friend WithEvents LblDistrik As System.Windows.Forms.Label
    Friend WithEvents CbDistrik As System.Windows.Forms.ComboBox
End Class
