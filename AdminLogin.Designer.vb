<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(215, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 31)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "User Login"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Firebrick
        Me.label3.Location = New System.Drawing.Point(175, 58)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(187, 24)
        Me.label3.TabIndex = 29
        Me.label3.Text = "Admin Login Portal"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(241, 240)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 31)
        Me.button2.TabIndex = 28
        Me.button2.Text = "Register"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(138, 240)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 31)
        Me.button1.TabIndex = 27
        Me.button1.Text = "Login"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(241, 197)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBox2.Size = New System.Drawing.Size(175, 22)
        Me.textBox2.TabIndex = 26
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(241, 133)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(175, 22)
        Me.textBox1.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(138, 200)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 16)
        Me.label2.TabIndex = 24
        Me.label2.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(135, 134)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 16)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Username"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(338, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 41)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Reset Password"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources.free_abstract_background_11_vector
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 381)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Button4 As System.Windows.Forms.Button
End Class
