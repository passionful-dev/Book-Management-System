Imports System.Data.SqlClient
Module Module1
    'Public flag As Boolean

    'Assign variables for sql linkage 


    Public s As String
    Public u As String
    Public p As String
    Public d As String



    Public cn As New SqlConnection()
    Public adap As SqlDataAdapter
    Public ds As DataSet

    Public userName As String
    Public userpassword As String

    Public dr As DataRow

    'Assign bool type variable for checking refresh
    Public isRefresh As Boolean = False



    'Function for connection with Sql
    'Sub ConnectionWithDatabase()
    '    cn = New SqlConnection("Server=" & s & ";uid=" & u & ";pwd=" & p & ";database=" & d)
    'End Sub

    Sub ConnectionWithDatabase()
        cn = New SqlConnection("Server=HOME-EMJKYXXGTL;uid=sa;pwd=aptech;database=master")
    End Sub

End Module
