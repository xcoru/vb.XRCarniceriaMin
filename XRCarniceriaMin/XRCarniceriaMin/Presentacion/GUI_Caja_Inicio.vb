Public Class GUI_Caja_Inicio
    Private Sub GUI_Caja_Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtInicioCaja.Select()
    End Sub

    Private Sub txtInicioCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInicioCaja.KeyPress
        If e.KeyChar = ChrW(13) Then
            Call BtnGuardar_Click(sender, e)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not txtInicioCaja Is Nothing Then
            If IsNumeric(txtInicioCaja.Text) Then
                _InicioCaja = txtInicioCaja.Text
            Else
                _InicioCaja = 0
            End If
        Else
            _InicioCaja = 0
        End If

        GUI_Ventas.Show()
        Close()
    End Sub
End Class