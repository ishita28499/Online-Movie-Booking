Public Class AdminForgotPassword
    Dim uname, pwd, cpwd, sql As String, row As Integer
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        uname = txtUname.Text
        pwd = txtPwd.Text
        cpwd = txtCPwd.Text

        If (uname.Length > 0 And pwd.Length > 0 And cpwd.Length > 0) Then
            If (pwd.Equals(cpwd)) Then
                sql = "Update AdminTable set password = '" & pwd & "' where adminname = '" & uname & "'"
                row = UpdateSQL(sql)
                If (row > 0) Then
                    MessageBox.Show("Data Updated Success")
                    txtUname.Clear()
                    txtPwd.Clear()
                    txtCPwd.Clear()
                Else
                    MessageBox.Show("Sorry Something went wrong")
                End If
            Else
                MessageBox.Show("Pwd & Confirm pwd is not same")
            End If
        Else
            MessageBox.Show("Pls fill all details")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class