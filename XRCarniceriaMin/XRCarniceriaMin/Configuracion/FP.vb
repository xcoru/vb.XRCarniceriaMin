Module FP

    Public Sub CargarDB()

    End Sub

    ''' <summary>
    ''' Mostrar Mensaje en pantalla
    ''' </summary>
    ''' <param name="mensaje">cadena a mostrar</param>
    ''' <param name="Opcion">1 Info - 2 Exclama - 3 Critical - 4 Question</param>
    Public Sub msg(ByVal mensaje As String, ByVal Optional Opcion As Integer = 1)
        Dim op As Integer

        Select Case Opcion
            Case 1
                op = 64
            Case 2
                op = 48
            Case 3
                op = 16
            Case 4
                op = 32
            Case Else
                op = 64
        End Select

        MsgBox(mensaje, vbOKOnly + op, _negocio_nombre)

    End Sub
End Module
