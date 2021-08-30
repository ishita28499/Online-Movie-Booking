Public Class frmSplash

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Dim cur As Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            cur = New Form1
            'Me.Dispose()
            'Me.Visible = False
            Me.Hide()
            cur.Show()
            Timer1.Enabled = False
        Else
            ProgressBar1.Value = CInt(ProgressBar1.Value) + 1
        End If

    End Sub
End Class
