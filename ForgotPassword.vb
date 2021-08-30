Public Class ForgotPassword

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtPwd.Enabled = False
        'txtCPwd.Enabled = False
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Dim uname, pwd, cpwd, sql As String, row As Integer
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        uname = txtUname.Text
        pwd = txtPwd.Text
        cpwd = txtCPwd.Text

        If (uname.Length > 0 And pwd.Length > 0 And cpwd.Length > 0) Then
            If (pwd.Equals(cpwd)) Then
                sql = "Update Customer set pass = '" & pwd & "' where name = '" & uname & "'"
                row = UpdateSQL(sql)
                If (row > 0) Then
                    MessageBox.Show("Data Updated Success")
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
End Class