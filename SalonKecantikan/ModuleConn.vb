Imports MySql.Data.MySqlClient
Module ModuleConn
    Public Conn As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader
    Public Cmd As MySqlCommand
    Public MyDB As String
    Sub OpenConn()
        MyDB = ("server=localhost; user id=root; password=;Database=salon_kecantikan")
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
