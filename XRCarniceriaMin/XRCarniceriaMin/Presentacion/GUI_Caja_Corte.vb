Public Class GUI_Caja_Corte
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim op As Integer
        op = MsgBox("¿Esta seguro de salir?", vbExclamation + vbYesNo, _negocio_nombre)
        If op = vbYes Then
            End
        End If
    End Sub

    Private Sub GUI_Caja_Corte_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dbVentas As New D_Ventas

        txtInicioCaja.Text = FNumero(_InicioCaja)
    End Sub
End Class