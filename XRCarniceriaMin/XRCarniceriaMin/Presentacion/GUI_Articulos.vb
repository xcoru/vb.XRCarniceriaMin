Public Class GUI_Articulos


    Private Sub CargarCampos()
        Try
            txtClaveProducto.Text = dgvTabla.SelectedCells.Item(0).Value
            txtDescripcion.Text = dgvTabla.SelectedCells.Item(1).Value
            txtTipo.Text = dgvTabla.SelectedCells.Item(2).Value
            txtPrecio.Text = dgvTabla.SelectedCells.Item(3).Value
            txtImagen.Text = dgvTabla.SelectedCells.Item(4).Value
            imgArticulo.BackgroundImage = Image.FromFile(txtImagen.Text)
        Catch ex As Exception
            _Error(ex)
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

    Private Sub dgvTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTabla.CellClick
        CargarCampos()
        'msg(dgvTabla.SelectedCells.Item(0).Value)
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim dbCatalogo As New D_Articulo

        If txtClaveProducto.TextLength > 0 Then
            dbCatalogo.Eliminar(txtClaveProducto.Text)
            CargarTabla()
        Else
            msg("Seleccione en la Tabla el registro a eliminar!", 2)
        End If



    End Sub
End Class