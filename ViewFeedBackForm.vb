Public Class ViewFeedBackForm

    Dim ds As DataSet
    Private Sub ViewFeedBackForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ds = New DataSet
        ds = GetDataSet("select * from FeedBack", "FeedBack")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "FeedBack"

    End Sub
End Class