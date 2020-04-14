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
    End Sub

    Private Sub BtnImpresora_Click(sender As Object, e As EventArgs) Handles btnImpresora.Click
        txtImpresora.Text = diaImpresora.ShowDialog
    End Sub
End Class