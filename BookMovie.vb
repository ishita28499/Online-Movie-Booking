'Imports sql.Data.sqlClient
Imports System.Data.SqlClient
Public Class BookMovie
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim mov As Object, obj As New DBClass
    Dim row As Integer
    Public custid As Integer
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

        con = obj.GetConn
        'str = "update movies set no_tick='" + TextBox2.Text + "',s_type='" + ComboBox1.Text + "',s_no='" + TextBox3.Text + "',amnt='" + TextBox4.Text + "'"
        str = "Insert into BookMovie(MovieId, MovieName, CustId) values (" & txtMovieid.Text & ",'" & txtMoviename.Text & "'," & custid & ")"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Book Movie Successfully..")

        'con = obj.GetConn
        'str = "select * from movie"
        'com = New SqlCommand(str, con)
        'da = New SqlDataAdapter(com)
        'dt = New DataTable()
        'dv = New DataView()
        'da.Fill(dt)
        'DataGridView1.DataSource = New BindingSource(dt, mov)

        
        SeatBoking.uid = custid
        SeatBoking.mid = txtMovieid.Text
        SeatBoking.txtPprice.Text = txtPlatinumPrice.Text
        SeatBoking.txtGPrice.Text = txtGoldenPrice.Text
        SeatBoking.txtSprice.Text = txtSilverPrice.Text
        SeatBoking.moviename = txtMoviename.Text
        txtMoviename.Text = ""
        txtPlatinumPrice.Clear()
        txtSilverPrice.Clear()
        txtGoldenPrice.Clear()
        txtLanguage.Text = ""
        txtMovieid.Text = ""
        con.Close()
        Me.Hide()
        SeatBoking.ShowDialog()
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMovieid.TextChanged

    End Sub

    Private Sub BookMovie_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        
        con = obj.GetConn
        str = "select * from movie"
        com = New SqlCommand(str, con)
        da = New SqlDataAdapter(com)
        dt = New DataTable()
        dv = New DataView()
        da.Fill(dt)
        DataGridView1.DataSource = New BindingSource(dt, mov)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        row = e.RowIndex
        txtMovieid.Text = DataGridView1.Item(0, row).Value
        txtMoviename.Text = DataGridView1.Item(1, row).Value
        txtLanguage.Text = DataGridView1.Item(2, row).Value
        txtPlatinumPrice.Text = DataGridView1.Item(3, row).Value
        txtGoldenPrice.Text = DataGridView1.Item(4, row).Value
        txtSilverPrice.Text = DataGridView1.Item(5, row).Value

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        txtMoviename.Text = ""
        txtPlatinumPrice.Clear()
        txtSilverPrice.Clear()
        txtGoldenPrice.Clear()
        txtLanguage.Text = ""
        txtMovieid.Text = ""

    End Sub
End Class