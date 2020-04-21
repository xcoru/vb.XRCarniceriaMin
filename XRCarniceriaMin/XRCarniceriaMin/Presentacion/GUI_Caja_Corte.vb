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
        txtTitulo.Text = "Corte de Caja  <|>  " + Now.ToLongDateString
        txtInicioCaja.Text = FNumero(_InicioCaja)
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim dbEgresos As New D_Egreso
        Dim dbVentas As New D_Ventas
        Dim resEgresos As DataSet
        Dim resVentas As DataSet
        Dim TotalVentas As Decimal = 0
        Dim LineaVentas As DataGridViewRow
        Dim TotalEgresos As Decimal = 0
        Dim LineaEgreso As DataGridViewRow

        Try

            resEgresos = dbEgresos.Consulta(Now.ToShortDateString)
            dgvEgresos.DataSource = resEgresos.Tables(0)
            dgvEgresos.Columns(0).Visible = False
            dgvEgresos.Columns(1).Visible = False
            dgvEgresos.Columns(5).Visible = False

            For Each LineaEgreso In dgvEgresos.Rows
                TotalEgresos += LineaEgreso.Cells(3).Value
            Next

            txtEgresoCaja.Text = Format(TotalEgresos, "#,###,##0.00")
        Catch ex As Exception
            X(ex)
        End Try

        Try

            resVentas = dbVentas.CorteCaja(Now.ToShortDateString)
            dgvVentas.DataSource = resVentas.Tables(0)

            For Each LineaVentas In dgvVentas.Rows
                TotalVentas += LineaVentas.Cells(6).Value
            Next

            txtVentasdia.Text = Format(TotalVentas, "#,###,##0.00")
        Catch ex As Exception
            X(ex)
        End Try

        Try
            txtTotalCaja.Text = Format((_InicioCaja + TotalVentas) - TotalEgresos, "#,###,##0.00")
        Catch ex As Exception
            X(ex)
        End Try

    End Sub
End Class