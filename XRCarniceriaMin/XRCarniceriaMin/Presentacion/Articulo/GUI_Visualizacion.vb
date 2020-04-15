Public Class GUI_Visualizacion
    Private Sub Visualizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            BackgroundImage = Image.FromFile(GUI_Articulos.txtImagen.Text)
        Catch ex As Exception
            Close()
        End Try
    End Sub

End Class