Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim mov As Object, obj As New DBClass

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Register.ShowDialog()
    End Sub

    Dim uname, pwd As String, reader As SqlDataReader

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

        uname = textBox1.Text.Trim
        pwd = textBox2.Text.Trim
        con = obj.GetConn
        If (uname.Length > 0 And pwd.Length > 0) Then
            'If (uname.Equals("admin") And pwd.Equals("admin")) Then
            str = "Select * from AdminTable where adminname = '" & uname & "' and password = '" & pwd & "'"
            'con.Open()
            com = New SqlCommand(str, con)
            reader = com.ExecuteReader
            If (reader.Read()) Then
                MsgBox("Thank u admin You have logged Successfully..")
                Me.Hide()
                AdminForm.Show()
            Else
                Try
                    str = "select id from Customer where name='" + textBox1.Text + "' and pass='" + textBox2.Text + "'"
                    'MessageBox.Show(str)
                    'TextBox3.Text = str
                    reader.Close()
                    com = New SqlCommand(str, con)
                    reader = com.ExecuteReader
                    If (reader.Read()) Then
                        MsgBox("You have logged Successfully..")
                        Home.Label1.Text = reader.Item(0).ToString
                        Home.Show()
                        Hide()
                        textBox2.Text = ""
                        textBox1.Text = ""
                    Else
                        MsgBox("Invalid Username and Password.")
                    End If
                    con.Close()
                Catch ex As Exception
                    MsgBox("Exception : " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Pls fill all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obj = New DBClass
        'textBox1.Text = "Customer"
        'textBox2.Text = "Customer"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
