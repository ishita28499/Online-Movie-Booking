<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForgotPassword
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtCPwd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(234, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 58)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtCPwd
        '
        Me.txtCPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPwd.Location = New System.Drawing.Point(224, 246)
        Me.txtCPwd.Name = "txtCPwd"
        Me.txtCPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPwd.Size = New System.Drawing.Size(139, 22)
        Me.txtCPwd.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Confirm Password"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Firebrick
        Me.label3.Location = New System.Drawing.Point(116, 65)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(233, 24)
        Me.label3.TabIndex = 37
        Me.label3.Text = "Admin Forgot Password"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(100, 315)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(98, 58)
        Me.button2.TabIndex = 36
        Me.button2.Text = "Change Password"
        Me.button2.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(224, 188)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(139, 22)
        Me.txtPwd.TabIndex = 35
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(224, 132)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(139, 22)
        Me.txtUname.TabIndex = 34
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(66, 191)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 16)
        Me.label2.TabIndex = 33
        Me.label2.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(66, 132)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 16)
        Me.label1.TabIndex = 32
        Me.label1.Text = "Username"
        '
        'AdminForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 482)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtCPwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "AdminForgotPassword"
        Me.Text = "AdminForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents txtCPwd As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents txtPwd As System.Windows.Forms.TextBox
    Private WithEvents txtUname As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
