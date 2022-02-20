Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormLaporanHistori
    Public KODE As String

    Private Sub FormLaporanHistori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsReport As New DataSet1

        Conn.Close()
        Da = New MySqlDataAdapter("SELECT * FROM TBL_HISTORI WHERE KODE_HISTORI='" & KODE & "' ORDER BY RANKING", Conn)
        Da.Fill(dsReport, "TBL_HISTORI")

        Dim ObjReport As New Rep_Ranking_Histori

        ObjReport.SetDataSource(dsReport)
        CrystalReportViewer1.ReportSource = ObjReport
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub FormLaporanHistori_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Close()
        Dispose()
    End Sub
End Class