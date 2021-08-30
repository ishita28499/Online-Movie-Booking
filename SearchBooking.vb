Imports System.Data.SqlClient
'Imports System.Data.SqlClient

Public Class SearchBooking
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim mov As Object, obj As New DBClass
    Private Sub SearchBooking_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MovieDataSet3.movies' table. You can move, or remove it, as needed.
        'Me.MoviesTableAdapter.Fill(Me.MovieDataSet3.movies)
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        con = obj.GetConn
        str = "select from pay where id='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, mov)
        'End Using
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class