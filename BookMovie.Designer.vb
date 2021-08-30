<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookMovie
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtMoviename = New System.Windows.Forms.TextBox()
        Me.txtMovieid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtSilverPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGoldenPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPlatinumPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(454, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(455, 260)
        Me.DataGridView1.TabIndex = 49
        '
        'txtLanguage
        '
        Me.txtLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLanguage.Location = New System.Drawing.Point(224, 184)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(147, 22)
        Me.txtLanguage.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Language"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(280, 384)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 31)
        Me.button2.TabIndex = 45
        Me.button2.Text = "Reset"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(154, 384)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 31)
        Me.button1.TabIndex = 44
        Me.button1.Text = "Book"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtMoviename
        '
        Me.txtMoviename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoviename.Location = New System.Drawing.Point(224, 137)
        Me.txtMoviename.Name = "txtMoviename"
        Me.txtMoviename.Size = New System.Drawing.Size(147, 22)
        Me.txtMoviename.TabIndex = 41
        '
        'txtMovieid
        '
        Me.txtMovieid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieid.Location = New System.Drawing.Point(224, 90)
        Me.txtMovieid.Name = "txtMovieid"
        Me.txtMovieid.Size = New System.Drawing.Size(147, 22)
        Me.txtMovieid.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Movie Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Firebrick
        Me.label3.Location = New System.Drawing.Point(172, 23)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(191, 24)
        Me.label3.TabIndex = 36
        Me.label3.Text = "Book Movie Tickets"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(103, 93)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 16)
        Me.label1.TabIndex = 35
        Me.label1.Text = "Movie Id"
        '
        'txtSilverPrice
        '
        Me.txtSilverPrice.Enabled = False
        Me.txtSilverPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSilverPrice.Location = New System.Drawing.Point(224, 325)
        Me.txtSilverPrice.Name = "txtSilverPrice"
        Me.txtSilverPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtSilverPrice.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Silver Price"
        '
        'txtGoldenPrice
        '
        Me.txtGoldenPrice.Enabled = False
        Me.txtGoldenPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldenPrice.Location = New System.Drawing.Point(224, 278)
        Me.txtGoldenPrice.Name = "txtGoldenPrice"
        Me.txtGoldenPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtGoldenPrice.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Golden Price"
        '
        'txtPlatinumPrice
        '
        Me.txtPlatinumPrice.Enabled = False
        Me.txtPlatinumPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatinumPrice.Location = New System.Drawing.Point(224, 231)
        Me.txtPlatinumPrice.Name = "txtPlatinumPrice"
        Me.txtPlatinumPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtPlatinumPrice.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Platinum Price"
        '
        'BookMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources._547538
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 504)
        Me.Controls.Add(Me.txtSilverPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGoldenPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPlatinumPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtMoviename)
        Me.Controls.Add(Me.txtMovieid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Name = "BookMovie"
        Me.Text = "BookMovie"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents txtLanguage As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtMoviename As System.Windows.Forms.TextBox
    Private WithEvents txtMovieid As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtSilverPrice As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtGoldenPrice As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtPlatinumPrice As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
End Class
