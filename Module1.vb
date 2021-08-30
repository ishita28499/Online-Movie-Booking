Imports System.Data.SqlClient
Module Module1
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim ds As DataSet
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim connstr As String

    Public Function GetConnection() As SqlConnection
        'connstr = "Data Source=PROJECT1-PC;Initial Catalog=moviebooking;Integrated Security=True"
        'con = New SqlConnection(connstr)
        connstr = "Data Source=INNOVATIONS\MSSQLSERVER1;Initial Catalog=MovieBooking;Integrated Security=True"
        con = New SqlConnection(connstr)
        'con = GetConnection()
        Return con
    End Function

    Dim comm As SqlCommand
    Public Function GetReader(ByVal sql As String) As SqlDataReader
        con = GetConnection()
        con.Open()
        comm = New SqlCommand(sql, con)
        reader = comm.ExecuteReader
        Return reader
    End Function

    Public Function GetDataSet(ByVal sql As String, ByVal tablename As String) As DataSet
        con = GetConnection()
        adapter = New SqlDataAdapter(sql, con)
        ds = New DataSet
        adapter.Fill(ds, tablename)
        Return ds
    End Function

    Public Function UpdateSQL(ByVal sql As String) As Integer
        con = GetConnection()
        con.Open()
        comm = New SqlCommand(sql, con)
        Dim row As Integer
        row = comm.ExecuteNonQuery
        Return row
    End Function

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function CheckNum(ByVal KeyVar As String) As String
        'MsgBox(Asc(KeyVar))
        If Asc(KeyVar) = 8 Then
            CheckNum = KeyVar : Exit Function
        End If
        If Asc(KeyVar) < 46 Or Asc(KeyVar) > 57 Then
            CheckNum = Nothing
            MsgBox("Please Enter Numbers Only")
        Else
            CheckNum = KeyVar
        End If
        If Asc(KeyVar) = 47 Then CheckNum = Nothing

    End Function

    Dim first, second As Integer
    Function IsValidPhoneNumber(ByVal phnum As String) As Boolean
        If (phnum.Length = 10) Then
            first = CInt(phnum.Substring(0, 1))
            second = CInt(phnum.Substring(1, 2))
            If (first < 5) Then
                'MessageBox.Show("first digit shd be either 9 or 8")
                MessageBox.Show("first digit shd be greater than 5")
                IsValidPhoneNumber = False
            Else
                IsValidPhoneNumber = True
            End If
        Else
            MessageBox.Show("first digit shd be greater than 5")
            IsValidPhoneNumber = False
        End If
    End Function


End Module
