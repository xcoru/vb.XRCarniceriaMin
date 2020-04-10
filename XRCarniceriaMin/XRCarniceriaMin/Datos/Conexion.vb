Imports MySql.Data.MySqlClient
Public Class Conexion

    Dim conexion As New MySqlConnection

    Public Function conectar() As MySqlConnection
        Try
            conexion.ConnectionString = "server=" & _Server & ";user id=" & _User & ";password=" & _Password & ";database=" & _DBName
        Catch ex As Exception
            If _MostrarErrores Then
                MsgBox(ex.Message + ex.StackTrace)
            End If
            Return Nothing
        End Try

        Return conexion
    End Function


End Class
