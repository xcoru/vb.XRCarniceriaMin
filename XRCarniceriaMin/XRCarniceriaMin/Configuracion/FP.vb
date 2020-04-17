Module FP

    Public Sub CargarDB()
        Dim dbNegocio As New D_Negocio
        Dim dbConfig As New D_Config
        Dim resNegocio As DataSet
        Dim resConfig As DataSet

        Try
            resNegocio = dbNegocio.Consulta(1)
            _negocio_nombre = resNegocio.Tables(0).Rows(0)(1).ToString
            _negocio_descripcion = resNegocio.Tables(0).Rows(0)(2).ToString
            _negocio_direccion = resNegocio.Tables(0).Rows(0)(3).ToString
            _negocio_telefono = resNegocio.Tables(0).Rows(0)(4).ToString
            _negocio_logotipo = resNegocio.Tables(0).Rows(0)(5).ToString

        Catch ex As Exception
            X(ex)
        End Try

        Try
            resConfig = dbConfig.Consulta(1)
            _config_impresora = resConfig.Tables(0).Rows(0)(1).ToString
        Catch ex As Exception
            X(ex)
        End Try

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
    Public Sub X(ByVal Optional ex As Exception = Nothing)
        If _MostrarErrores Then
            msg(ex.Message + " TTT " + ex.StackTrace, 3)
        End If
    End Sub


End Module
