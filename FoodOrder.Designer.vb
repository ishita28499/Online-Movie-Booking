<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodOrder
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtReqQty = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFoodType = New System.Windows.Forms.TextBox()
        Me.txtFoodId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAvailQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(72, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(514, 116)
        Me.DataGridView1.TabIndex = 9
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(318, 276)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 31)
        Me.button2.TabIndex = 8
        Me.button2.Text = "Close"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(203, 276)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(71, 31)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Order"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtReqQty
        '
        Me.txtReqQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqQty.Location = New System.Drawing.Point(425, 117)
        Me.txtReqQty.Name = "txtReqQty"
        Me.txtReqQty.Size = New System.Drawing.Size(139, 22)
        Me.txtReqQty.TabIndex = 3
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(123, 165)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(139, 22)
        Me.txtFname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Req Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Firebrick
        Me.label3.Location = New System.Drawing.Point(270, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(119, 24)
        Me.label3.TabIndex = 36
        Me.label3.Text = "Order Food"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(25, 120)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 16)
        Me.label1.TabIndex = 35
        Me.label1.Text = "Food Type"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(425, 163)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(139, 22)
        Me.txtPrice.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(302, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Price"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(425, 217)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(139, 22)
        Me.txtTotalPrice.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(300, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Total Price"
        '
        'txtFoodType
        '
        Me.txtFoodType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodType.Location = New System.Drawing.Point(123, 117)
        Me.txtFoodType.Name = "txtFoodType"
        Me.txtFoodType.Size = New System.Drawing.Size(139, 22)
        Me.txtFoodType.TabIndex = 1
        '
        'txtFoodId
        '
        Me.txtFoodId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodId.Location = New System.Drawing.Point(123, 71)
        Me.txtFoodId.Name = "txtFoodId"
        Me.txtFoodId.Size = New System.Drawing.Size(139, 22)
        Me.txtFoodId.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Food Id"
        '
        'txtAvailQty
        '
        Me.txtAvailQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailQty.Location = New System.Drawing.Point(425, 70)
        Me.txtAvailQty.Name = "txtAvailQty"
        Me.txtAvailQty.Size = New System.Drawing.Size(139, 22)
        Me.txtAvailQty.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Avail Quantity"
        '
        'FoodOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources._496007
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 472)
        Me.Controls.Add(Me.txtAvailQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFoodId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFoodType)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtReqQty)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Name = "FoodOrder"
        Me.Text = "FoodOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtReqQty As System.Windows.Forms.TextBox
    Private WithEvents txtFname As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtPrice As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtFoodType As System.Windows.Forms.TextBox
    Private WithEvents txtFoodId As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtAvailQty As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
