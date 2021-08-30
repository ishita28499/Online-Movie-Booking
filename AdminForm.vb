Public Class AdminForm

    Private Sub BookMovieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookMovieToolStripMenuItem.Click
        AddMovieForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OrderFoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderFoodToolStripMenuItem.Click
        AddFood.ShowDialog()
    End Sub

    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MoviesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoviesToolStripMenuItem.Click
        MoviesReport.ShowDialog()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        BookingReport.ShowDialog()
    End Sub
End Class