Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexion

    Dim conexion As New MySqlConnection

    Public Function conectar() As MySqlConnection
        conexion.ConnectionString = "server=127.0.0.1;user id=root;password=;database=xrcarniceriamin"
        Return conexion
    End Function


End Class
