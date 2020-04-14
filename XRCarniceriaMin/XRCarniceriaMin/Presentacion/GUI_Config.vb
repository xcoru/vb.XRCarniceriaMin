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
            _Error(ex)
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
End Class