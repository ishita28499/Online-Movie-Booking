Imports System.Data.SqlClient

Public Class Movie
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim mov As Object, obj As New DBClass
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        'con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\MovieBookingSystemVB\MovieBookingSystemVB\movie.mdf;Integrated Security=True")
        'con.Open()
        con = obj.GetConn
        str = "insert into movies(city,locat,m_name,time) values('" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + ComboBox4.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        BookMovie.ShowDialog()
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"
        ComboBox3.Text = "--Select--"
        ComboBox4.Text = "--Select--"
        con.Close()
    End Sub

    Private Sub Movie_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class