<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtCPwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Firebrick
        Me.label3.Location = New System.Drawing.Point(163, 49)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(216, 24)
        Me.label3.TabIndex = 28
        Me.label3.Text = "User Forgot Password"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(116, 295)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(98, 58)
        Me.button2.TabIndex = 27
        Me.button2.Text = "Change Password"
        Me.button2.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(240, 168)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(139, 22)
        Me.txtPwd.TabIndex = 25
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(240, 112)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(139, 22)
        Me.txtUname.TabIndex = 24
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(82, 171)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 16)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(82, 112)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 16)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Username"
        '
        'txtCPwd
        '
        Me.txtCPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPwd.Location = New System.Drawing.Point(240, 226)
        Me.txtCPwd.Name = "txtCPwd"
        Me.txtCPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPwd.Size = New System.Drawing.Size(139, 22)
        Me.txtCPwd.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Confirm Password"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(250, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 58)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources.cybersecurity_istockphoto_kqv__621x414_LiveMint
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(569, 464)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtCPwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents txtPwd As System.Windows.Forms.TextBox
    Private WithEvents txtUname As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtCPwd As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Button3 As System.Windows.Forms.Button
End Class
