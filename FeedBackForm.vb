Imports System.Data.SqlClient
Public Class FeedBackForm
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim sql As String
    Dim userid, username, feedback As String

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        userid = txtUserId.Text
        username = txtUsername.Text
        feedback = txtComments.Text

        If (String.IsNullOrEmpty(userid)) Then
            MessageBox.Show("UserId is Empty")
        ElseIf (String.IsNullOrEmpty(username)) Then
            MessageBox.Show("UserName is Empty")
        ElseIf (String.IsNullOrEmpty(feedback)) Then
            MessageBox.Show("FeedBack is Empty")
        Else
            sql = "Insert into FeedBack(UserId, UserName, FeedBack) values(" & userid & ",'" & username & "','" & feedback & "')"
            con = GetConnection()
            con.Open()
            com = New SqlCommand(sql, con)
            com.ExecuteNonQuery()
            MessageBox.Show("FeedBack Updated Success")
            txtUsername.Clear()
            txtUserId.Clear()
            txtComments.Clear()
        End If
    End Sub

    Public Sub New(ByVal UserID As String)
        InitializeComponent()
        Me.userid = UserID
        txtUserId.Text = UserID
        '        MessageBox.Show("Recp ID : " & ReceipientID)
    End Sub


    Private Sub FeedBackForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class