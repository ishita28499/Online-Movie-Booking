Public Class AddFood

    Dim fname, qty, price, foodtype, sql, foodid As String
    Dim row As Integer, ds As DataSet
    Private Sub AddFood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFood.SelectedIndex = 0
        FillDetails()
    End Sub

    Sub FillDetails()
        ds = New DataSet
        ds = GetDataSet("select * from food", "food")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Food"
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If (cboFood.SelectedIndex > 0) Then
            foodtype = cboFood.SelectedItem.ToString
            fname = txtName.Text
            qty = txtQuantity.Text
            price = txtPrice.Text
            If (fname.Length > 0 And qty.Length > 0 And price.Length > 0) Then
                sql = "Insert into food (fname, ftype, qty, price) values('" & fname & "','" & foodtype & "'," & qty & "," & price & ")"
                row = UpdateSQL(sql)
                If (row > 0) Then
                    MessageBox.Show("Food Inserted Success")
                    FillDetails()
                    txtName.Clear()
                    txtPrice.Clear()
                    txtQuantity.Clear()
                    cboFood.SelectedIndex = 0
                Else
                    MessageBox.Show("Sorry Something went wrong")
                End If
            Else
                MessageBox.Show("Pls Fill all details")
            End If
        Else
            MessageBox.Show("Pls Select Food Type")
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        txtName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
    End Sub

    Private Sub label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As Integer
        row = e.RowIndex
        foodid = DataGridView1.Item(0, row).Value
        foodtype = DataGridView1.Item(2, row).Value
        fname = DataGridView1.Item(1, row).Value
        qty = DataGridView1.Item(3, row).Value
        price = DataGridView1.Item(4, row).Value
        txtName.Text = fname
        txtPrice.Text = price
        txtQuantity.Text = qty
        cboFood.SelectedItem = foodtype
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (String.IsNullOrEmpty(foodid)) Then
            sql = "Delete from food where foodid = " & foodid
            row = UpdateSQL(sql)
            If (row > 0) Then
                MessageBox.Show("Data Deleted Success")
                FillDetails()
            End If
        Else
            MessageBox.Show("Please select a food to delete")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (String.IsNullOrEmpty(foodid)) Then
            sql = "Update  food set fname = '" & txtName.Text & "', Ftype = '" & cboFood.SelectedItem & "', Qty = " & txtQuantity.Text & ", Price = " & txtPrice.Text & " where foodid = " & foodid
            row = UpdateSQL(sql)
            If (row > 0) Then
                MessageBox.Show("Data Updated Success")
                FillDetails()
            End If
        Else
            MessageBox.Show("Please select a food to update")
        End If
    End Sub
End Class