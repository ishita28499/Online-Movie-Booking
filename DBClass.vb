Imports System.Data.SqlClient
Public Class DBClass
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim ds As DataSet
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim connstr As String

    Public Function GetConn()
        connstr = "Data Source=INNOVATIONS\MSSQLSERVER1;Initial Catalog=MovieBooking;Integrated Security=True"
        'connstr = "Data Source=PROJECT1-PC;Initial Catalog=moviebooking;Integrated Security=True"
        con = New SqlConnection(connstr)
        con.Open()
        GetConn = con
    End Function

End Class
