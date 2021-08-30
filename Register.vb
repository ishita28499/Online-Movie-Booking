Imports System.Data.SqlClient

Public Class Register
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim mov As Object, obj As New DBClass

    Dim uname, email, pwd, phnum As String
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

        uname = txtUname.Text
        pwd = txtPwd.Text
        email = txtEmail.Text
        phnum = txtPhNum.Text

        'MessageBox.Show(uname & " " & phnum & " " & email & " " & pwd)

        If (uname.Length > 0 And pwd.Length > 0 And email.Length > 0 And phnum.Length > 0) Then

            If (pwd.Length >= 5) Then

                If (IsValidEmailFormat(email)) Then

                    If (IsValidPhoneNumber(phnum)) Then



                        con = obj.GetConn
                        str = "insert into Customer(name,pass,email,mobile) values('" + txtUname.Text + "','" + txtPwd.Text + "','" + txtEmail.Text + "','" + txtPhNum.Text + "')"
                        com = New SqlCommand(str, con)
                        com.ExecuteNonQuery()
                        MsgBox("User Registered Successfully..")
                        txtPwd.Text = ""
                        txtEmail.Text = ""
                        txtPhNum.Text = ""
                        txtUname.Text = ""
                        con.Close()
                    Else
                        MessageBox.Show("Phnum shd be 10 nums & starts with 9/8/7/6")
                    End If
                Else
                    MessageBox.Show("Email is Invalid")
                End If

            Else
                MessageBox.Show("Pwd length shd br 5 chars")
            End If
        Else
            MessageBox.Show("Please fill all details")
        End If
    End Sub

    Private Sub Register_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        txtPwd.Text = ""
        txtEmail.Text = ""
        txtPhNum.Text = ""
        txtUname.Text = ""
    End Sub
End Class