Public Class GUI_Config
    Private Sub BtnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
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
            txtLogotipo.text = openfiler.FileName
        End If
        Try
            imgLogoTipo.BackgroundImage = Image.FromFile(txtLogotipo.Text)
        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    Private Sub BtnImpresora_Click(sender As Object, e As EventArgs) Handles btnImpresora.Click
        Dim openfiler As New PrintDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            .AllowPrintToFile = False
            .AllowCurrentPage = False
            .AllowSelection = False
            .AllowSomePages = False
            .ShowHelp = False
            .ShowNetwork = True
            .UseEXDialog = False
        End With
        '
        'Evalua si el usuario hace click en el boton abrir
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Obteniendo la ruta completa del archivo xml
            txtImpresora.Text = openfiler.PrinterSettings.PrinterName
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objNegocio As New I_Negocio
        Dim objConfig As New I_Config
        Dim dbNegocio As New D_Negocio
        Dim dbConfig As New D_Config
        Dim response As Boolean = False

        Try
            With objNegocio
                .Id_negocio = 1
                .Nombre = txtNombre.Text
                .Descripcion = ""
                .Direccion = txtDireccion.Text
                .Telefono = txtTelefono.Text
                .Logotipo = txtLogotipo.Text
            End With
            objConfig.Id_config = 1
            objConfig.Impresora = txtImpresora.Text
        Catch ex As Exception
            X(ex)
        End Try

        Try
            If dbNegocio.Editar(objNegocio) Then
                response = True
            End If
            If dbConfig.Editar(objConfig) And response Then
                response = True
            Else
                response = False
            End If
        Catch ex As Exception
            X(ex)
        End Try

        If response Then
            msg("Información guardada correctamente!")
        Else
            msg("Error al guardar!", 3)
        End If

    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub GUI_Config_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtNombre.Text = _negocio_nombre
            txtDireccion.Text = _negocio_direccion
            txtTelefono.Text = _negocio_telefono
            txtLogotipo.Text = _negocio_logotipo
            imgLogoTipo.BackgroundImage = Image.FromFile(_negocio_logotipo)
            txtImpresora.Text = _config_impresora
        Catch ex As Exception
            X(ex)
        End Try

    End Sub
End Class