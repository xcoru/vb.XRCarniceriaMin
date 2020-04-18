Public Class GUI_Ventas_Cobrar
    Private Sub GUI_Ventas_Cobrar_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTotal.Text = GUI_Ventas.txtTotal.Text
        txtEfectivo.Select()
    End Sub

    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress



    End Sub

    Private Sub txtEfectivo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEfectivo.KeyUp
        CalcularCambio()
    End Sub

    Private Sub CalcularCambio()
        Try
            If Val(txtEfectivo.Text) >= Val(txtTotal.Text) Then
                txtCambio.Text = Format(Val(txtEfectivo.Text) - Val(txtTotal.Text), "#,###,##0.00")
            Else
                txtCambio.Text = 0
            End If

        Catch ex As Exception
            X(ex)
        End Try
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub BtnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        cobrar()
    End Sub

    Private Sub cobrar()

        If Val(txtTotal.Text) > Val(txtEfectivo.Text) Then
            msg("¡Efectivo insuficiente!", 3)
            txtEfectivo.Select()
            Exit Sub
        Else
            txtCambio.Text = Format(Val(txtEfectivo.Text) - Val(txtTotal.Text), "#,###,##0.00")
        End If

    End Sub
End Class