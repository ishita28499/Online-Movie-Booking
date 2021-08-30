'Imports Sql.Data.sqlClient
Imports System.Data.SqlClient
Public Class SeatBoking
    Public uid, mid As Integer, moviename As String
    Dim i As Integer
    Dim ored, ogreen, oblue, fred, fgreen, fblue As Integer
    Dim uname, seattype, seatnum As String
    Dim obj As New DBClass
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim reader As SqlDataReader
    Dim sql As String
    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click

        'For i = 0 To Me.GroupBox1.Controls.Count - 1
        'MessageBox.Show(Me.GroupBox1.Controls.Item(i).Name)
        'Next
        If (txtPseats.Text.Equals("0") And txtGseats.Text.Equals("0") And txtSSeats.Text.Equals("0")) Then
            MessageBox.Show("Please Select the Seats to Book")
        Else
            MessageBox.Show("Seats Booked Successfully")
            txtPseats.Text = 0
            txtGseats.Text = 0
            txtSSeats.Text = 0
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        seattype = "Platinum"

        seatnum = 1
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button1.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button1.Enabled = False
    End Sub

    Sub BookTickets(ByVal uid As String, ByVal uname As String, ByVal moviename As String, ByVal seattype As String, ByVal seatnum As String)

        Dim numofseats As Integer, price As Double
        If (seattype.Equals("Platinum")) Then
            numofseats = CInt(txtPseats.Text)
            price = CDbl(txtPprice.Text)
            numofseats = numofseats + 1
            txtPseats.Text = numofseats
            txtPtprice.Text = numofseats * price
        ElseIf (seattype.Equals("Golden")) Then
            numofseats = CInt(txtGseats.Text)
            price = CDbl(txtGPrice.Text)
            numofseats = numofseats + 1
            txtGseats.Text = numofseats
            txtGTprice.Text = numofseats * price
        ElseIf (seattype.Equals("Silver")) Then
            numofseats = CInt(txtSSeats.Text)
            price = CDbl(txtSprice.Text)
            numofseats = numofseats + 1
            txtSSeats.Text = numofseats
            txtStprice.Text = numofseats * price
        End If


        sql = "INSERT INTO moviebooking  (uid,uname,moviename,seattype,seatnum, Qty, Price) values(@uid, @uname, @mname, @type, @num, @qty, @price)"
        con = obj.GetConn
        com = New SqlCommand(sql, con)
        com.Parameters.AddWithValue("@uid", uid)
        com.Parameters.AddWithValue("@uname", uname)
        com.Parameters.AddWithValue("@mname", moviename)
        com.Parameters.AddWithValue("@type", seattype)
        com.Parameters.AddWithValue("@num", seatnum)
        com.Parameters.AddWithValue("@qty", 1)
        com.Parameters.AddWithValue("@price", price)
        com.ExecuteNonQuery()
        'MessageBox.Show("Seat Booked SuccessFully")
        com.Dispose()
        con.Close()

        txtTotalPrice.Text = CDbl(txtPtprice.Text) + CDbl(txtGTprice.Text) + CDbl(txtStprice.Text)
    End Sub

    Private Sub SeatBoking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        txtGseats.Text = 0
        txtGTprice.Text = 0
        txtPseats.Text = 0
        txtPtprice.Text = 0
        txtSSeats.Text = 0
        txtStprice.Text = 0

        uid = 1
        reader = GetReader("Select * from Customer where id = " & uid)
        If (reader.Read()) Then
            uname = reader.Item(1).ToString
            'moviename = "abcd"
            con = obj.GetConn
            ored = 255
            ogreen = 0
            oblue = 0
            fred = 0
            fgreen = 255
            fblue = 0

            con = obj.GetConn

            sql = "select * from moviebooking where moviename like '" & moviename & "'" 'where seattype like 'Platinum'"
            com = New SqlCommand(sql, con)
            reader = com.ExecuteReader
            Dim buttonname As String, flag As Boolean, seatnumber As Integer
            Dim number As String, index As Integer

            'For i = 0 To GroupBox1.Controls.Count - 1
            '    buttonname = GroupBox1.Controls.Item(i).Name
            '    index = buttonname.IndexOf("n")
            '    number = buttonname.Substring(index + 1)
            '    MessageBox.Show(number)
            'Next

            'For i = 0 To GroupBox2.Controls.Count - 1
            '    buttonname = GroupBox2.Controls.Item(i).Name
            '    index = buttonname.IndexOf("n")
            '    number = buttonname.Substring(index + 1)
            '    MessageBox.Show(number)
            'Next

            While (reader.Read)
                seatnumber = CInt(reader.Item(5).ToString)
                flag = False
                'MessageBox.Show(seatnumber)
                If (seatnumber >= 1 And seatnumber <= 20) Then
                    For i = 0 To GroupBox1.Controls.Count - 1
                        buttonname = GroupBox1.Controls.Item(i).Name
                        index = buttonname.IndexOf("n")
                        number = CInt(buttonname.Substring(index + 1))
                        'MessageBox.Show(number)
                        If (number = seatnumber) Then
                            GroupBox1.Controls.Item(i).Enabled = False
                            GroupBox1.Controls.Item(i).BackColor = Color.FromArgb(ored, ogreen, oblue)
                            Exit For
                        End If
                    Next
                End If

                If (seatnumber >= 21 And seatnumber <= 40) Then
                    For i = 0 To GroupBox2.Controls.Count - 1
                        buttonname = GroupBox2.Controls.Item(i).Name
                        index = buttonname.IndexOf("n")
                        number = CInt(buttonname.Substring(index + 1))
                        'MessageBox.Show(number)
                        If (number = seatnumber) Then
                            GroupBox2.Controls.Item(i).Enabled = False
                            GroupBox2.Controls.Item(i).BackColor = Color.FromArgb(ored, ogreen, oblue)
                            Exit For
                        End If
                    Next
                End If

                If (seatnumber >= 41 And seatnumber <= 60) Then
                    For i = 0 To GroupBox3.Controls.Count - 1
                        buttonname = GroupBox3.Controls.Item(i).Name
                        index = buttonname.IndexOf("n")
                        number = CInt(buttonname.Substring(index + 1))
                        'MessageBox.Show(number)
                        If (number = seatnumber) Then
                            GroupBox3.Controls.Item(i).Enabled = False
                            GroupBox3.Controls.Item(i).BackColor = Color.FromArgb(ored, ogreen, oblue)
                            Exit For
                        End If
                    Next
                End If
            End While
            con.Close()
        Else
            MessageBox.Show("Sorry Some Error Occurs")
            Button61.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        seattype = "Platinum"
        seatnum = 2
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button2.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        seattype = "Platinum"
        seatnum = 3
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button3.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        seattype = "Platinum"
        seatnum = 4
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button4.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        seattype = "Platinum"
        seatnum = 5
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button5.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        seattype = "Platinum"
        seatnum = 6
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button6.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        seattype = "Platinum"
        seatnum = 7
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button7.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        seattype = "Platinum"
        seatnum = 8
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button8.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        seattype = "Platinum"
        seatnum = 9
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button9.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button9.Enabled = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        seattype = "Platinum"
        seatnum = 10
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button10.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button10.Enabled = False
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        seattype = "Platinum"
        seatnum = 20

        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button20.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button20.Enabled = False
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        seattype = "Platinum"
        seatnum = 19
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button19.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button19.Enabled = False
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        seattype = "Platinum"
        seatnum = 18
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button18.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button18.Enabled = False
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        seattype = "Platinum"
        seatnum = 17
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button17.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button17.Enabled = False
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        seattype = "Platinum"
        seatnum = 16
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button16.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button16.Enabled = False
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        seattype = "Platinum"
        seatnum = 15
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button15.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button15.Enabled = False
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        seattype = "Platinum"
        seatnum = 14
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button14.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button14.Enabled = False
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        seattype = "Platinum"
        seatnum = 13
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button13.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button13.Enabled = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        seattype = "Platinum"
        seatnum = 12
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button12.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button12.Enabled = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        seattype = "Platinum"
        seatnum = 11
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button11.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button11.Enabled = False
    End Sub

    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        'Me.Close()
        Me.Visible = False
        Home.Visible = True
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        seattype = "Golden"
        seatnum = 21
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button21.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button21.Enabled = False
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        seattype = "Golden"
        seatnum = 22
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button22.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button22.Enabled = False
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        seattype = "Golden"
        seatnum = 23
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button23.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button23.Enabled = False
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        seattype = "Golden"
        seatnum = 24
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button24.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button24.Enabled = False
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        seattype = "Golden"
        seatnum = 25
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button25.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button25.Enabled = False
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        seattype = "Golden"
        seatnum = 26
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button26.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button26.Enabled = False
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        seattype = "Golden"
        seatnum = 27
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button27.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button27.Enabled = False
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        seattype = "Golden"
        seatnum = 28
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button28.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button28.Enabled = False
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        seattype = "Golden"
        seatnum = 29
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button29.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button29.Enabled = False
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        seattype = "Golden"
        seatnum = 30
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button30.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button30.Enabled = False
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        seattype = "Golden"
        seatnum = 31
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button31.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button31.Enabled = False
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        seattype = "Golden"
        seatnum = 32
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button32.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button32.Enabled = False
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        seattype = "Golden"
        seatnum = 33
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button33.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button33.Enabled = False
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        seattype = "Golden"
        seatnum = 34
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button34.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button34.Enabled = False
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        seattype = "Golden"
        seatnum = 35
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button35.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button35.Enabled = False
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        seattype = "Golden"
        seatnum = 36
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button36.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button36.Enabled = False
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        seattype = "Golden"
        seatnum = 37
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button37.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button37.Enabled = False
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        seattype = "Golden"
        seatnum = 38
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button38.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button38.Enabled = False
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        seattype = "Golden"
        seatnum = 39
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button39.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button39.Enabled = False
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        seattype = "Platinum"
        seatnum = 40
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button40.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button40.Enabled = False
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        seattype = "Silver"
        seatnum = 41
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button41.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button41.Enabled = False
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        seattype = "Silver"
        seatnum = 42
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button42.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button42.Enabled = False
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        seattype = "Silver"
        seatnum = 43
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button43.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button43.Enabled = False
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        seattype = "Silver"
        seatnum = 44
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button44.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button44.Enabled = False
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        seattype = "Silver"
        seatnum = 45
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button45.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button45.Enabled = False
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        seattype = "Silver"
        seatnum = 46
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button46.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button46.Enabled = False
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        seattype = "Silver"
        seatnum = 47
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button47.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button47.Enabled = False
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        seattype = "Silver"
        seatnum = 48
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button48.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button48.Enabled = False
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        seattype = "Silver"
        seatnum = 49
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button49.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button49.Enabled = False
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        seattype = "Silver"
        seatnum = 50
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button50.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button50.Enabled = False
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        seattype = "Silver"
        seatnum = 51
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button51.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button51.Enabled = False
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        seattype = "Silver"
        seatnum = 52
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button52.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button52.Enabled = False
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        seattype = "Silver"
        seatnum = 53
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button53.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button53.Enabled = False
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        seattype = "Silver"
        seatnum = 54
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button54.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button54.Enabled = False
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        seattype = "Silver"
        seatnum = 55
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button55.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button55.Enabled = False
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        seattype = "Silver"
        seatnum = 56
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button56.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button56.Enabled = False
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        seattype = "Silver"
        seatnum = 57
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button57.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button57.Enabled = False
    End Sub

    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        seattype = "Silver"
        seatnum = 58
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button58.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button58.Enabled = False
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        seattype = "Silver"
        seatnum = 59
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button59.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button59.Enabled = False
    End Sub

    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        seattype = "Silver"
        seatnum = 60
        BookTickets(uid, uname, moviename, seattype, seatnum)
        Button60.BackColor = Color.FromArgb(ored, ogreen, oblue)
        Button60.Enabled = False
    End Sub
End Class
