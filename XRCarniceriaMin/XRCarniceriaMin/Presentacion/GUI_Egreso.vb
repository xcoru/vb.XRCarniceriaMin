Public Class GUI_Egreso
    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub Guardar()
        Dim dbEgreso As New D_Egreso
        Dim iEgreso As New I_Egreso

        If txtMonto.TextLength < 1 Then
            msg("Especifique el monto!", 2)
            txtMonto.Select()
            Exit Sub
        End If

        If txtConcepto.TextLength < 1 Then
            msg("Especifique el concepto!", 2)
            txtConcepto.Select()
            Exit Sub
        End If

        With iEgreso
            .Id_usuario = _usuario_id_usuario
            .Monto = Val(txtMonto.Text)
            .Concepto = txtConcepto.Text
            .Hora = Now.ToShortTimeString
            .Fecha = Now.ToShortDateString
        End With

        If dbEgreso.Insertar(iEgreso) Then
            msg("Registro guardado!")
            txtMonto.Text = ""
            txtConcepto.Text = ""
            txtMonto.Select()
        Else
            msg("Error al guardar", 3)
        End If

    End Sub

    Private Sub GUI_Egreso_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtMonto.Select()
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar = ChrW(13) Then
            If txtMonto.TextLength > 0 Then
                txtConcepto.Select()
            End If
        ElseIf Not IsNumeric(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = ChrW(8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        If e.KeyChar = ChrW(13) Then
            Guardar()
        End If
    End Sub
End Class