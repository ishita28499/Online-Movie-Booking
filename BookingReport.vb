Public Class BookingReport
    Dim ds As DataSet
    Private Sub BookingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet
        ds = GetDataSet("select * from moviebooking", "MovieBooking")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "moviebooking"
    End Sub
End Class