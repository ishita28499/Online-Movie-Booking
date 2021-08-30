<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovieForm
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtPlatinumPrice = New System.Windows.Forms.TextBox()
        Me.cbolanguage = New System.Windows.Forms.ComboBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtGoldenPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSilverPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(200, 314)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 31)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Delete"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(74, 314)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 31)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Book"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtPlatinumPrice
        '
        Me.txtPlatinumPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatinumPrice.Location = New System.Drawing.Point(135, 181)
        Me.txtPlatinumPrice.Name = "txtPlatinumPrice"
        Me.txtPlatinumPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtPlatinumPrice.TabIndex = 3
        '
        'cbolanguage
        '
        Me.cbolanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolanguage.FormattingEnabled = True
        Me.cbolanguage.Items.AddRange(New Object() {"-- Select --", "English", "Hindi", "Kannada", "Tamil", "Telugu"})
        Me.cbolanguage.Location = New System.Drawing.Point(135, 122)
        Me.cbolanguage.Name = "cbolanguage"
        Me.cbolanguage.Size = New System.Drawing.Size(147, 24)
        Me.cbolanguage.TabIndex = 2
        Me.cbolanguage.Text = "--Select--"
        '
        'txtMname
        '
        Me.txtMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(135, 55)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(147, 42)
        Me.txtMname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Platinum Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Language"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(26, 55)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 16)
        Me.label1.TabIndex = 48
        Me.label1.Text = "Movie Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(326, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(468, 199)
        Me.DataGridView1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(76, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 31)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(200, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 31)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtGoldenPrice
        '
        Me.txtGoldenPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldenPrice.Location = New System.Drawing.Point(135, 223)
        Me.txtGoldenPrice.Name = "txtGoldenPrice"
        Me.txtGoldenPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtGoldenPrice.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Golden Price"
        '
        'txtSilverPrice
        '
        Me.txtSilverPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSilverPrice.Location = New System.Drawing.Point(135, 267)
        Me.txtSilverPrice.Name = "txtSilverPrice"
        Me.txtSilverPrice.Size = New System.Drawing.Size(147, 22)
        Me.txtSilverPrice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Silver Price"
        '
        'AddMovieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources.movies_tiles
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(806, 498)
        Me.Controls.Add(Me.txtSilverPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGoldenPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtPlatinumPrice)
        Me.Controls.Add(Me.cbolanguage)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label1)
        Me.Name = "AddMovieForm"
        Me.Text = "AddMovieForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtPlatinumPrice As System.Windows.Forms.TextBox
    Friend WithEvents cbolanguage As System.Windows.Forms.ComboBox
    Private WithEvents txtMname As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents Button4 As System.Windows.Forms.Button
    Private WithEvents txtGoldenPrice As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtSilverPrice As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
End Class
