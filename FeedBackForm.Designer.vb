<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedBackForm
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
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtComments
        '
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(437, 165)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(228, 122)
        Me.txtComments.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(335, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "FeedBack"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(498, 306)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 31)
        Me.button2.TabIndex = 75
        Me.button2.Text = "Cancel"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(372, 306)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 31)
        Me.button1.TabIndex = 74
        Me.button1.Text = "Apply"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(437, 118)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(147, 22)
        Me.txtUsername.TabIndex = 73
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(437, 71)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(147, 22)
        Me.txtUserId.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "User Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Enabled = False
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(335, 74)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 16)
        Me.label1.TabIndex = 70
        Me.label1.Text = "User Id"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(400, 25)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(202, 24)
        Me.label3.TabIndex = 78
        Me.label3.Text = "Add Feedback Form"
        '
        'FeedBackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 467)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FeedBackForm"
        Me.Text = "FeedBackForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtComments As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtUsername As System.Windows.Forms.TextBox
    Private WithEvents txtUserId As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
End Class
