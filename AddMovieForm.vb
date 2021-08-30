Public Class AddMovieForm

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Dim ds As DataSet
    Sub FillDetails()
        ds = New DataSet
        ds = GetDataSet("Select * from Movie", "Movie")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Movie"
    End Sub

    Private Sub AddMovieForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillDetails()
    End Sub
    Dim mname, nooftickets, language, seats, Pprice, Gprice, Sprice, sql As String, row As Integer

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        mname = txtMname.Text.Trim
        'nooftickets = txtnooftickets.Text.Trim
        seats = txtPlatinumPrice.Text.Trim
        Pprice = txtPlatinumPrice.Text
        Gprice = txtGoldenPrice.Text
        Sprice = txtSilverPrice.Text
        If (mname.Length > 0 And seats.Length > 0 And Pprice.Length > 0 And Gprice.Length > 0 And Sprice.Length > 0) Then
            If (cbolanguage.SelectedIndex > 0) Then
                language = cbolanguage.SelectedItem.ToString
                sql = "INSERT INTO Movie (MovieName  , Language , Pprice, Gprice, Sprice) values('" & mname & "','" & language & "'," & Pprice & "," & Gprice & "," & Sprice & ")"
                row = UpdateSQL(sql)
                If (row > 0) Then
                    MessageBox.Show("Movie Updated Success")
                    txtMname.Clear()
                    txtPlatinumPrice.Clear()
                    cbolanguage.SelectedIndex = 0
                    FillDetails()
                Else
                    MessageBox.Show("Sorry Something went wrong")
                End If
            Else
                MessageBox.Show("Pls Select Language")
            End If
        Else
            MessageBox.Show("Pls Fill all details")
        End If
    End Sub
    Dim id As String
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row, index As Integer
        row = e.RowIndex
        id = DataGridView1.Item(0, row).Value
        txtMname.Text = DataGridView1.Item(1, row).Value
        language = DataGridView1.Item(2, row).Value
        txtPlatinumPrice.Text = DataGridView1.Item(3, row).Value
        txtGoldenPrice.Text = DataGridView1.Item(4, row).Value
        txtSilverPrice.Text = DataGridView1.Item(5, row).Value
        For index = 0 To cbolanguage.Items.Count - 1
            If (language.Equals(cbolanguage.Items(index))) Then
                cbolanguage.SelectedIndex = index
                Exit For
            End If
        Next
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        If (id.Trim.Length > 0) Then
            sql = "delete from movie where movieid = " & id
            row = UpdateSQL(sql)
            If (row > 0) Then
                MessageBox.Show("Movie Deleted Success")
                txtMname.Clear()
                txtPlatinumPrice.Clear()
                cbolanguage.SelectedIndex = 0
                txtGoldenPrice.Clear()
                txtSilverPrice.Clear()
                FillDetails()
            Else
                MessageBox.Show("Sorry something went wrong")
            End If
        Else
            MessageBox.Show("Pls select movie to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mname = txtMname.Text.Trim
        'nooftickets = txtnooftickets.Text.Trim
        language = cbolanguage.SelectedItem.ToString
        Pprice = txtPlatinumPrice.Text.Trim
        Gprice = txtGoldenPrice.Text
        Sprice = txtSilverPrice.Text

        If (id.Trim.Length > 0 And mname.Length > 0 And language.Length > 0 And Pprice.Length > 0 And Sprice.Length > 0 And Gprice.Length > 0) Then
            sql = "update movie set moviename = '" & mname & "', language = '" & language & "', pprice = " & Pprice & ", gprice =  " & Gprice & ", sprice = " & Sprice & " where movieid = " & id
            row = UpdateSQL(sql)
            If (row > 0) Then
                MessageBox.Show("Movie Updated Success")
                txtMname.Clear()
                txtPlatinumPrice.Clear()
                cbolanguage.SelectedIndex = 0
                txtGoldenPrice.Clear()
                txtPlatinumPrice.Clear()
                txtSilverPrice.Clear()
                FillDetails()
            Else
                MessageBox.Show("Sorry something went wrong")
            End If
        Else
            MessageBox.Show("Pls select movie to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class