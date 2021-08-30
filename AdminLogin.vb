Imports System.Data.SqlClient
Public Class AdminLogin

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Dim uname, pwd, sql As String, row As Integer
    Dim obj As New DBClass
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim reader As SqlDataReader

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        uname = textBox1.Text.Trim
        pwd = textBox2.Text.Trim
        If (uname.Length > 0 And pwd.Length > 0) Then
            sql = "Select * from AdminTable where adminname = '" & uname & "' and password = '" & pwd & "'"
            con = obj.GetConn
            'con.Open()
            com = New SqlCommand(sql, con)
            reader = com.ExecuteReader
            If (reader.Read) Then
                MsgBox("Thank u admin You have logged Successfully..")
                Me.Hide()
                AdminForm.Show()
            Else
                MessageBox.Show("Sorry Invalid Admin/Pwd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
        MessageBox.Show("Pls fill all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Register.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AdminForgotPassword.ShowDialog()
    End Sub
End Class