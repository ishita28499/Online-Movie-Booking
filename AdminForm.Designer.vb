<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BookMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderFoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookMovieToolStripMenuItem, Me.OrderFoodToolStripMenuItem, Me.SearchMovieToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1116, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BookMovieToolStripMenuItem
        '
        Me.BookMovieToolStripMenuItem.Name = "BookMovieToolStripMenuItem"
        Me.BookMovieToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.BookMovieToolStripMenuItem.Text = "Add Movie"
        '
        'OrderFoodToolStripMenuItem
        '
        Me.OrderFoodToolStripMenuItem.Name = "OrderFoodToolStripMenuItem"
        Me.OrderFoodToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.OrderFoodToolStripMenuItem.Text = "Add Food"
        '
        'SearchMovieToolStripMenuItem
        '
        Me.SearchMovieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoviesToolStripMenuItem, Me.BookingToolStripMenuItem})
        Me.SearchMovieToolStripMenuItem.Name = "SearchMovieToolStripMenuItem"
        Me.SearchMovieToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.SearchMovieToolStripMenuItem.Text = "Reports"
        '
        'MoviesToolStripMenuItem
        '
        Me.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem"
        Me.MoviesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MoviesToolStripMenuItem.Text = "Movies"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 20)
        Me.ToolStripMenuItem1.Text = "View FeedBacks"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MovieBooking.My.Resources.Resources._1491933_full_size_movie_theatre_wallpaper_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1116, 511)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BookMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderFoodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
