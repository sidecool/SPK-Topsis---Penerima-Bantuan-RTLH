Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormLaporan
    Public JenisLaporan As String
    Private SQLText, SQLOrder, SQLClause, SQLLimit As String
    Private cek_awal As Boolean

    Private Sub FormLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsReport As New DataSet1        

        SQLText = "SELECT * FROM V_REPORT"
        SQLOrder = ""
        SQLClause = ""
        SQLLimit = ""

        If JenisLaporan <> "ranking" Then
            SQLOrder = "ORDER BY RANKING"
            If JenisLaporan = "distrik" Then
                cek_awal = True
                CbDistrik.SelectedIndex = 0
            End If
        End If

        Conn.Close()
        Da = New MySqlDataAdapter(SQLText & " " & SQLClause & " " & SQLOrder & " " & SQLLimit, Conn)
        Da.Fill(dsReport, "V_REPORT")    

        If JenisLaporan = "ranking" Then
            LblTop.Visible = True
            TBTop.Visible = True
            BtnGO.Visible = True
            RBOrder.Visible = True
            LblDistrik.Visible = False
            CbDistrik.Visible = False
            LblKelurahan.Visible = False
            TBKelurahan.Visible = False
            BtnGoLurah.Visible = False
            Dim RankObjReport As New Rep_Ranking
            RankObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = RankObjReport
        ElseIf JenisLaporan = "distrik" Then
            LblTop.Visible = False
            TBTop.Visible = False
            BtnGO.Visible = False
            RBOrder.Visible = False
            LblDistrik.Visible = True
            CbDistrik.Visible = True            
            Dim DisObjReport As New Rep_Distrik
            DisObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = DisObjReport
        ElseIf JenisLaporan = "kelurahan" Then
            LblTop.Visible = False
            TBTop.Visible = False
            BtnGO.Visible = False
            RBOrder.Visible = False
            LblDistrik.Visible = False
            CbDistrik.Visible = False
            Dim DesaObjReport As New Rep_Kelurahan
            DesaObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = DesaObjReport
        End If
        CrystalReportViewer1.Refresh()
        cek_awal = False
    End Sub

    Private Sub FormLaporan_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Close()
        Dispose()
    End Sub

    Private Sub RBOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBOrder.Click
        RBOrder.Checked = True
        BtnGO_Click(sender, e)
    End Sub

    Private Sub BtnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGO.Click            
        If sender Is RBOrder Then
            If RBOrder.Checked Then
                If TBTop.Text = "" Then
                    TBTop.Text = "0"
                ElseIf TBTop.Text <> "" And TBTop.Text <> "0" Then
                    SQLLimit = "LIMIT " & TBTop.Text
                End If
            Else
                SQLOrder = ""
                SQLLimit = ""
                TBTop.Text = ""
            End If
        ElseIf sender Is BtnGO Then
            If TBTop.Text = "" Then
                RBOrder.Checked = False
                SQLLimit = ""
            ElseIf TBTop.Text = "0" Then
                RBOrder.Checked = True
                SQLLimit = ""
            Else
                RBOrder.Checked = True
                SQLLimit = "LIMIT " & TBTop.Text
            End If
        End If

        If RBOrder.Checked = True Then
            SQLOrder = "ORDER BY RANKING"
        Else
            SQLOrder = ""
        End If

        If JenisLaporan <> "ranking" Then
            SQLOrder = "ORDER BY RANKING"
        End If

        Dim dsReport As New DataSet1
        Conn.Close()
        'MsgBox(SQLText & " " & SQLClause & " " & SQLOrder & " " & SQLLimit)
        Da = New MySqlDataAdapter(SQLText & " " & SQLClause & " " & SQLOrder & " " & SQLLimit, Conn)
        Da.Fill(dsReport, "V_REPORT")

        If JenisLaporan = "ranking" Then
            Dim RankObjReport As New Rep_Ranking
            RankObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = RankObjReport
        ElseIf JenisLaporan = "distrik" Then
            Dim DisObjReport As New Rep_Distrik
            DisObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = DisObjReport
        ElseIf JenisLaporan = "kelurahan" Then
            Dim DesaObjReport As New Rep_Kelurahan
            DesaObjReport.SetDataSource(dsReport)
            CrystalReportViewer1.ReportSource = DesaObjReport
        End If
        CrystalReportViewer1.Refresh()

        TBTop.Focus()
    End Sub

    Private Sub TBTop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBTop.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnGO_Click(BtnGO, e)
        End If
    End Sub

    Private Sub TBTop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTop.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnGoLurah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGoLurah.Click
        If CbDistrik.SelectedIndex = 0 Then
            SQLClause = "WHERE KELURAHAN LIKE '%" & TBKelurahan.Text & "%'"
        Else
            SQLClause = "WHERE DISTRIK LIKE '%" & CbDistrik.Text & "%' AND KELURAHAN LIKE '%" & TBKelurahan.Text & "%'"
        End If

        BtnGO_Click(sender, e)
        TBKelurahan.Focus()
    End Sub

    Private Sub TBKelurahan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBKelurahan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnGoLurah_Click(sender, e)
        End If
    End Sub

    Private Sub CbDistrik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDistrik.SelectedIndexChanged
        If cek_awal = False Then
            TBKelurahan.Clear()
            If CbDistrik.SelectedIndex = 0 Then
                SQLClause = ""
            Else
                SQLClause = "WHERE DISTRIK LIKE '%" & CbDistrik.Text & "%'"
            End If

            BtnGO_Click(sender, e)
            CbDistrik.Focus()
        End If
    End Sub
End Class