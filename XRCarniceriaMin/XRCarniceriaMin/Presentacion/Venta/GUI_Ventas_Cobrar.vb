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

        Dim dbVenta As New D_Ventas
        Dim iventa As New I_Ventas
        Dim linea As DataGridViewRow
        Dim Folio As Integer
        Dim Hora As String = Now.ToShortTimeString
        Dim Fecha As String = Format(Now.Date, "yyyy/MM/dd")
        Dim res As Boolean = True

        Folio = dbVenta.getFolio
        If Folio < 1000 Then
            Folio = 1000
        End If

        For Each linea In GUI_Ventas.dgvTabla.Rows
            Try
                With iventa
                    .Folio = Folio
                    .Id_usuario = _usuario_id_usuario
                    .Id_articulo = linea.Cells(1).Value
                    .Precio = linea.Cells(3).Value
                    .Cantidad = linea.Cells(4).Value
                    .Subtotal = linea.Cells(6).Value
                    .Hora = Hora
                    .Fecha = Fecha
                End With
                If Not dbVenta.Insertar(iventa) Then
                    res = False
                    Exit For
                End If

            Catch ex As Exception
                res = False
                X(ex)
            End Try
        Next

        If res Then
            msg("Venta Registrada!")
            txtCambio.Text = 0
            txtEfectivo.Text = ""
            txtTotal.Text = 0
            GUI_Ventas.BorrarVenta()
            close
        Else
            msg("Error al guardar!", 3)
        End If

    End Sub
End Class