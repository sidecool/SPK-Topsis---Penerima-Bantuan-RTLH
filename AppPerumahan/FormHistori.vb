Public Class FormHistori
    Dim SQL As String

    Private Sub FormHistori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conn.Close()
        SQL = "SELECT DISTINCT KODE_HISTORI, NM_HISTORI FROM TBL_HISTORI ORDER BY KODE_HISTORI"
        Conn.Open()
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter(SQL, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_HISTORI")
        DataGridView1.DataSource = Ds.Tables("TBL_HISTORI")

        Try
            DataGridView1.Columns(0).Width = 250
            DataGridView1.Columns(1).Width = 2500
            DataGridView1.Columns(0).HeaderText = "KODE"
            DataGridView1.Columns(1).HeaderText = "KETERANGAN"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FormLaporanHistori.KODE = "" Then
            MsgBox("Belum ada data yang dipilih")
        Else
            FormLaporanHistori.ShowDialog()
        End If
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Button1.Enabled = True
        If e.RowIndex > -1 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
                FormLaporanHistori.KODE = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            End If
        End If
    End Sub
End Class