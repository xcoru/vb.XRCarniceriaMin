Public Class GUI_Ventas_Agregar
    Private Sub GUI_Ventas_Agregar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tabla.Controls.Clear()
        CargarArticulos()

    End Sub

    Private Sub CargarArticulos()
        Dim _ar As DataSet
        Dim dbArticulo As New D_Articulo
        Dim _row As DataRow
        Dim genArticulo As New ObjArticulo


        _ar = dbArticulo.Listado

        For Each _row In _ar.Tables(0).Rows
            Dim _i_articulo As New I_Articulo
            With _i_articulo
                .Id_articulo = _row(0)
                .Descripcion = _row(1)
                .Imagen = _row(4)
            End With
            Tabla.Controls.Add(genArticulo.Crear(_i_articulo))
        Next

    End Sub

End Class