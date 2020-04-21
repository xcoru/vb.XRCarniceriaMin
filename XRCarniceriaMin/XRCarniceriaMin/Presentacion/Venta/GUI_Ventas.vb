Public Class GUI_Ventas
    Dim LineaIndice As Integer

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim op As Integer
        op = MsgBox("¿Esta seguro de salir?", vbExclamation + vbYesNo, _negocio_nombre)
        If op = vbYes Then
            End
        End If
    End Sub

    Private Sub TimFecha_Tick(sender As Object, e As EventArgs) Handles timFecha.Tick
        txtHora.Text = Now.ToLongTimeString
        txtFecha.Text = Now.ToShortDateString
    End Sub

    Private Sub GUI_Ventas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCampos()
    End Sub

    Private Sub CargarCampos()
        Try
            txtUsuario.Text = _usuario_nombre
            txtEmpresa.Text = _negocio_nombre
            txtDireccion.Text = _negocio_direccion
            txtTelefono.Text = _negocio_telefono
            Try
                txtLogotipo.BackgroundImage = Image.FromFile(_negocio_logotipo)
            Catch ex As Exception
                X(ex)
            End Try
        Catch ex As Exception
            X(ex)
        End Try

    End Sub

    Private Sub BtnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        If Val(txtTotal.Text > 0) Then
            GUI_Ventas_Cobrar.ShowDialog()
        End If
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        GUI_Config.ShowDialog()
    End Sub

    Private Sub BtnCorte_Click(sender As Object, e As EventArgs) Handles btnCorte.Click
        GUI_Caja_Corte.ShowDialog()
    End Sub

    Private Sub BtnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        GUI_Articulos.ShowDialog()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        GUI_Ventas_Agregar.ShowDialog()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim op As Integer
        op = MsgBox("¿Esta seguro de cancelar la venta actual?", vbExclamation + vbYesNo, _negocio_nombre)
        If op = vbYes Then
            BorrarVenta()
        End If
    End Sub

    Public Sub BorrarVenta()
        dgvTabla.Rows.Clear()
        GUI_Ventas_Agregar.dgvDetalles.Rows.Clear()
        GUI_Ventas_Agregar.txtDescripcion.Text = ""
        GUI_Ventas_Agregar.txtPrecio.Text = ""
        GUI_Ventas_Agregar.txtCantidad.Text = ""
        txtTotal.Text = "0.00"
    End Sub

    Private Sub BtnEgreso_Click(sender As Object, e As EventArgs) Handles btnEgreso.Click
        GUI_Egreso.ShowDialog()
    End Sub
End Class