Imports MySql.Data.MySqlClient
Module Module1
    Public conexion As New MySqlConnection(("server=localhost;uid=root;database=maxirest;password=;SslMode=none"))
    Public consulta As String 'Variables para las consultas SQL' 
    Public accion As String 'Para determinar que tipo de consulta (insert, update, delete)'
    Public idUser As String

End Module