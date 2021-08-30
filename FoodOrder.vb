Imports System.Data.SqlClient
Public Class FoodOrder
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView, ds As DataSet
    Dim mov As Object, obj As New DBClass
    Dim foodid As String
    Public userid As String
    Private Sub FoodOrder_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'con = obj.GetConn
        'str = "select * from food"
        'com = New SqlCommand(str, con)
        'da = New SqlDataAdapter(com)
        'dt = New DataTable()
        'dv = New DataView()
        'da.Fill(dt)
        'DataGridView1.DataSource = New BindingSource(dt, mov)
        'End Using
        txtReqQty.Text = 0
        FillDetails()
    End Sub

    Sub FillDetails()
        ds = New DataSet
        ds = GetDataSet("Select * from food where qty > 0", "Food")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Food"
    End Sub


    Dim ftype, fname, qty, price, total As String
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

        ftype = txtFoodType.Text
        fname = txtFname.Text
        qty = txtReqQty.Text
        price = txtPrice.Text
        total = txtTotalPrice.Text

        If (ftype.Length > 0 And fname.Length > 0 And qty.Length > 0 And price.Length > 0 And total.Length > 0) Then

            con = obj.GetConn
            str = "insert into orderfood(uid, foodtype,f_name, price, qty, totalamt) values(" & userid & ",'" & txtFoodType.Text & "','" & txtFname.Text & "'," & txtPrice.Text & "," & txtReqQty.Text & "," & txtTotalPrice.Text & ")"
            'TextBox1.Text = str
            com = New SqlCommand(str, con)
            'com.ExecuteNonQuery()
            MsgBox("Food Ordered Successfully..")
            txtFname.Clear()
            txtFoodType.Clear()
            txtPrice.Clear()
            txtTotalPrice.Clear()
            con.Close()
            str = "update food set qty = qty - " & qty & " where foodid = " & foodid
            'MessageBox.Show(str)
            UpdateSQL(str)
            txtReqQty.Text = 0
            FillDetails()
        Else
            MessageBox.Show("Sorry Food Order not Success")
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        'txtQty.Text = ""
        'cboFoodType.Text = "--Select--"
        'txtFname.Text = ""
        Me.Close()
    End Sub
    Dim availqty As Integer
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        foodid = DataGridView1.Item(0, e.RowIndex).Value
        txtFoodId.Text = foodid
        txtFname.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtAvailQty.Text = CInt(DataGridView1.Item(3, e.RowIndex).Value)
        txtReqQty.Text = 0
        availqty = CInt(DataGridView1.Item(3, e.RowIndex).Value)
        txtFoodType.Text = DataGridView1.Item(2, e.RowIndex).Value
        'availqty = CInt(DataGridView1.Item(3, e.RowIndex).Value)
        txtPrice.Text = DataGridView1.Item(4, e.RowIndex).Value
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReqQty.TextChanged
        If (txtReqQty.Text.Length > 0) Then
            qty = CInt(txtReqQty.Text)
            If (qty > 0) Then
                If (qty < availqty) Then
                    txtTotalPrice.Text = qty * CDbl(txtPrice.Text)
                Else
                    txtTotalPrice.Text = 0
                    txtReqQty.Text = 0
                    MessageBox.Show("Sorry u cannot order more than available qty")
                End If
            Else
                txtTotalPrice.Text = 0
            End If
        End If
    End Sub
End Class