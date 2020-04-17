Module Eventos

#Region "Eventos"
    Public Sub evArticulo_Hover(sender As Object, e As EventArgs)
        On Error Resume Next
        CType(sender, Panel).BorderStyle = BorderStyle.FixedSingle
    End Sub

    Public Sub evArticulo_Leave(sender As Object, e As EventArgs)
        On Error Resume Next
        CType(sender, Panel).BorderStyle = BorderStyle.None
    End Sub

    Public Sub evArticulo_Click(sender As Object, e As EventArgs)
        Dim dbArticulo As New D_Articulo
        Dim _i_articulo As New DataSet
        Dim idArticulo As String = ""

        Try
            idArticulo = CType(sender, Panel).Name
        Catch ex As Exception
            X(ex)
        End Try

        Try
            If idArticulo.Length > 0 Then
                _i_articulo = dbArticulo.Consulta(idArticulo)

                If _i_articulo.Tables(0).Rows.Count > 0 Then
                    With objSeleccionado
                        .Id_articulo = _i_articulo.Tables(0).Rows(0)(0)
                        .Descripcion = _i_articulo.Tables(0).Rows(0)(1)
                        .Tipo = _i_articulo.Tables(0).Rows(0)(2)
                        .Precio = _i_articulo.Tables(0).Rows(0)(3)
                        .Imagen = _i_articulo.Tables(0).Rows(0)(4)
                        .Estado = _i_articulo.Tables(0).Rows(0)(5)
                    End With


                    'GUI_VENTAS_AGREGAR -----------------------------------------
                    With GUI_Ventas_Agregar
                        .txtDescripcion.Text = objSeleccionado.Descripcion
                        .txtPrecio.Text = objSeleccionado.Precio
                        .CalcularMonto()
                        .txtCantidad.Select()
                    End With

                End If
            End If
        Catch ex As Exception
            X(ex)
        End Try


    End Sub

#End Region

End Module
