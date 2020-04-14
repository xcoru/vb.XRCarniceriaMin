﻿Public Class GUI_Ventas
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
                txtLogotipo.BackgroundImage = _negocio_logotipo
            Catch ex As Exception
                _Error(ex)
            End Try
        Catch ex As Exception
            _Error(ex)
        End Try

    End Sub

    Private Sub BtnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        GUI_Ventas_Cobrar.ShowDialog()
    End Sub

    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        GUI_Config.ShowDialog()
    End Sub

    Private Sub BtnCorte_Click(sender As Object, e As EventArgs) Handles btnCorte.Click
        GUI_Caja_Corte.ShowDialog()
    End Sub
End Class