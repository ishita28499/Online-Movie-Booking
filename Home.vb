Public Class Home
    Private Sub BookMovieToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookMovieToolStripMenuItem.Click
        'Movie.ShowDialog()
        BookMovie.custid = Label1.Text
        BookMovie.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Payment.ShowDialog()
    End Sub

    Private Sub OrderFoodToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OrderFoodToolStripMenuItem.Click
        FoodOrder.userid = Label1.Text
        FoodOrder.ShowDialog()
    End Sub

    Private Sub SearchMovieToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchMovieToolStripMenuItem.Click
        'SearchBooking.ShowDialog()
        ViewBooking.uid = Label1.Text
        ViewBooking.showDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Form1.ShowDialog()
        Application.Exit()
    End Sub

    Private Sub Home_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New FeedBackForm(Label1.Text)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        CancelBookingForm.uid = Label1.Text
        CancelBookingForm.ShowDialog()
    End Sub
End Class