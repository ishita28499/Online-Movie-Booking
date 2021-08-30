Imports System.Data.SqlClient
Public Class CancelBookingForm
    Dim ds As DataSet, sql As String
    Public uid As String
    Dim reader As SqlDataReader
    Public custid, bid, row As Integer

    Private Sub CancelBookingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDetails()
    End Sub

    Sub fillDetails()
        TextBox2.Visible = False
        txtPseats.Text = 0
        txtPprice.Text = 0
        txtPtprice.Text = 0
        txtGseats.Text = 0
        txtGPrice.Text = 0
        txtGTprice.Text = 0
        txtSSeats.Text = 0
        txtSprice.Text = 0
        txtStprice.Text = 0
        ds = New DataSet
        sql = "select * from moviebooking where uid = " & uid
        MessageBox.Show(sql)
        ds = GetDataSet("select * from moviebooking where uid = " & uid, "moviebooking")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "moviebooking"
        sql = "select SUM(qty), price, SUM(price)  from moviebooking where seattype like 'Platinum' and uid = " & uid & " group by price"

        TextBox2.Text = sql

        reader = GetReader(sql)
        If (reader.Read()) Then
            txtPseats.Text = reader.Item(0).ToString
            txtPprice.Text = reader.Item(1).ToString
            txtPtprice.Text = reader.Item(2).ToString
        End If

        sql = "select SUM(qty), price, SUM(price)  from moviebooking where seattype like 'Golden' and uid = " & uid & " group by price"

        reader = GetReader(sql)
        If (reader.Read()) Then
            txtGseats.Text = reader.Item(0).ToString
            txtGPrice.Text = reader.Item(1).ToString
            txtGTprice.Text = reader.Item(2).ToString
        End If

        sql = "select SUM(qty), price, SUM(price)  from moviebooking where seattype like 'Silver' and uid = " & uid & " group by price"

        reader = GetReader(sql)
        If (reader.Read()) Then
            txtSSeats.Text = reader.Item(0).ToString
            txtSprice.Text = reader.Item(1).ToString
            txtStprice.Text = reader.Item(2).ToString
        End If

        txtTSeats.Text = CInt(txtGseats.Text) + CInt(txtPseats.Text) + CInt(txtSSeats.Text)
        txtTotalPrice.Text = CInt(txtGTprice.Text) + CInt(txtPtprice.Text) + CInt(txtStprice.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(bid)) Then
            MessageBox.Show("Select Seat to Cancel")
        Else
            sql = "delete from moviebooking where bid = " & bid
            bid = vbNull
            row = UpdateSQL(sql)
            If (row > 0) Then
                MessageBox.Show("Select Seat Cancelled Success")
                fillDetails()
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        bid = DataGridView1.Item(0, e.RowIndex).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class