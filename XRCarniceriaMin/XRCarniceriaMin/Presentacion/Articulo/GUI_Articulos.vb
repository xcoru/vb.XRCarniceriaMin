Public Class GUI_Articulos

    Private Sub BorrarCampos()
        Try
            txtClaveProducto.Text = ""
            txtDescripcion.Text = ""
            txtImagen.Text = ""
            imgArticulo.BackgroundImage = Nothing
            txtPrecio.Text = ""
            txtTipo.SelectedIndex = -1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarCampos()
        BorrarCampos()
        Try
            txtClaveProducto.Text = dgvTabla.SelectedCells.Item(0).Value
            txtDescripcion.Text = dgvTabla.SelectedCells.Item(1).Value

            If dgvTabla.SelectedCells.Item(2).Value = "Kg." Then
                txtTipo.SelectedIndex = 0
            Else
                txtTipo.SelectedIndex = 1
            End If
            txtPrecio.Text = dgvTabla.SelectedCells.Item(3).Value
            txtImagen.Text = dgvTabla.SelectedCells.Item(4).Value
            imgArticulo.BackgroundImage = Image.FromFile(txtImagen.Text)
        Catch ex As Exception
            '_Error(ex)
        End Try

    End Sub
    Private Sub CargarTabla()
        Dim dbCatalogo As New D_Articulo
        dgvTabla.DataSource = Nothing
        dgvTabla.DataSource = dbCatalogo.Listado.Tables(0)
    End Sub

    Private Sub BtnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            '.InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            txtImagen.Text = openfiler.FileName
        End If
        Try
            imgArticulo.BackgroundImage = Image.FromFile(txtImagen.Text)
        Catch ex As Exception
            _Error(ex)
        End Try
    End Sub

    Private Sub GUI_Articulos_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarTabla()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim dbCatalogo As New D_Articulo
        Dim op As Integer

        If txtClaveProducto.TextLength > 0 Then
            op = MsgBox("Esta seguro de eliminar el articulo: '" + txtDescripcion.Text + "' ?", vbYesNo + vbExclamation, _negocio_nombre)
            If op = vbYes Then
                dbCatalogo.Eliminar(txtClaveProducto.Text)
                CargarTabla()
            Else
                msg("Operación cancelada!", 2)
            End If
        Else
            msg("Seleccione en la Tabla el registro a eliminar!", 2)
        End If



    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dbArticulo As New D_Articulo
        Dim objArticulo As New I_Articulo
        Dim existe As Boolean = False
        Dim op As Integer

        With objArticulo
            .Id_articulo = txtClaveProducto.Text
            .Descripcion = txtDescripcion.Text
            .Tipo = txtTipo.Text
            .Precio = txtPrecio.Text
            .Imagen = txtImagen.Text
            .Estado = 1
        End With

        If dbArticulo.Existe(txtClaveProducto.Text) Then
            existe = True
        End If

        If existe Then
            op = MsgBox("Esta seguro de editar registro existente?", vbYesNo + vbExclamation, _negocio_nombre)
            If op = vbYes Then
                If dbArticulo.Editar(objArticulo) Then
                    msg("Registro Editado!")
                    CargarTabla()
                Else
                    msg("Error al editar!", 3)
                End If
            Else
                msg("Operación cancelada!", 2)
            End If

        Else
            If dbArticulo.Insertar(objArticulo) Then
                msg("Registro guardado!")
                CargarTabla()
            Else
                msg("Error al guardar!", 3)
            End If
        End If

    End Sub

    Private Sub dgvTabla_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTabla.SelectionChanged
        CargarCampos()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        BorrarCampos()
        txtClaveProducto.Select()
    End Sub

    Private Sub ImgArticulo_Click(sender As Object, e As EventArgs) Handles imgArticulo.Click
        If txtImagen.TextLength > 0 Then
            GUI_Visualizacion.ShowDialog()
        End If
    End Sub
End Class