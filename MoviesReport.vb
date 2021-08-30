Public Class MoviesReport
    Dim ds As DataSet
    Private Sub MoviesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet
        ds = GetDataSet("select * from movie", "Movie")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "movie"
    End Sub
End Class