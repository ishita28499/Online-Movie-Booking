Imports System.Data.SqlClient


Public Class Payment
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
        str = "insert into pay(id,m_name,no_tick,amnt,p_type) values('" + textBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Payment Done Successfully..")
        'Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\MovieBookingSystemVB\MovieBookingSystemVB\movie.mdf;Integrated Security=True")
        con = obj.GetConn
        str = "select * from pay"
        com = New SqlCommand(str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, mov)
        'End Using
        TextBox2.Text = ""
        ComboBox1.Text = "--Select--"
        textBox1.Text = ""
        con.Close()
    End Sub

    Private Sub Payment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MovieDataSet2.pay' table. You can move, or remove it, as needed.
        'Me.PayTableAdapter.Fill(Me.MovieDataSet2.pay)
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
        'con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\MovieBookingSystemVB\MovieBookingSystemVB\movie.mdf;Integrated Security=True")
        'con.Open()
        con = obj.GetConn
        Try
            str = "Select m_name,no_tick,amnt from movies where id='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                TextBox2.Text = dr.GetValue(0).ToString()
                TextBox3.Text = dr.GetValue(1).ToString()
                TextBox4.Text = dr.GetValue(2).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        textBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = "--Select--"
    End Sub
End Class