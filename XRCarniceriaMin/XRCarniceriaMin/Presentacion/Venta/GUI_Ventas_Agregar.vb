Imports System.ComponentModel

Public Class GUI_Ventas_Agregar
    Dim Peso As Decimal

    Private Sub GUI_Ventas_Agregar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Tabla.Controls.Clear()
        CargarArticulos()

    End Sub

    Private Sub CargarArticulos()
        Dim _ar As DataSet
        Dim dbArticulo As New D_Articulo
        Dim _row As DataRow
        Dim genArticulo As New ObjArticulo


        _ar = dbArticulo.Listado

        For Each _row In _ar.Tables(0).Rows
            Dim _i_articulo As New I_Articulo
            With _i_articulo
                .Id_articulo = _row(0)
                .Descripcion = _row(1)
                .Imagen = _row(4)
            End With
            Tabla.Controls.Add(genArticulo.Crear(_i_articulo))
        Next

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim indice As Integer

        If txtDescripcion.Text.Length > 0 And txtCantidad.TextLength > 0 And IsNumeric(txtCantidad.Text) Then

            dgvDetalles.Rows.Add(1)
            indice = dgvDetalles.Rows.Count - 1

            With objSeleccionado
                dgvDetalles.Item(0, indice).Value = .Id_articulo
                dgvDetalles.Item(1, indice).Value = .Precio
                If Val(txtCantidad.Text) > 999 Then
                    dgvDetalles.Item(2, indice).Value = Format(Peso, "##0.###")
                Else
                    dgvDetalles.Item(2, indice).Value = Format(Peso, "##0.###")
                End If

                dgvDetalles.Item(3, indice).Value = .Tipo
                dgvDetalles.Item(4, indice).Value = .Descripcion
            End With

            txtCantidad.Text = ""
            'txtMonto.Text = ""
        End If
        txtCantidad.Select()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        CalcularMonto()
    End Sub

    Public Sub CalcularMonto()
        If IsNumeric(txtCantidad.Text) And txtCantidad.TextLength > 0 Then
            If Val(txtCantidad.Text) > 999 Then
                Peso = Val(txtCantidad.Text / 1000)
            Else
                Peso = Val(txtCantidad.Text)
            End If

            txtMonto.Text = Peso * Val(txtPrecio.Text)
        ElseIf Not txtCantidad.Text = "." Then
            Peso = 0
            txtCantidad.Text = ""
            txtMonto.Text = 0
        End If

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(13) Then
            Call BtnAgregar_Click(sender, e)
        ElseIf e.KeyChar = "x" Or e.KeyChar = "X" Then
            Close()
        End If
    End Sub

    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Close()
    End Sub

    Public Sub CargarTablaPrincipal()
        Dim Linea As DataGridViewRow
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal
        Dim Indice As Integer = 0

        Try
            GUI_Ventas.dgvTabla.Rows.Clear()
            GUI_Ventas.txtTotal.Text = "0.00"

            For Each Linea In dgvDetalles.Rows
                Indice += 1
                SubTotal = 0
                With GUI_Ventas.dgvTabla.Rows
                    .Add(1)
                    .Item(Indice - 1).Cells(0).Value = Indice
                    .Item(Indice - 1).Cells(1).Value = Linea.Cells(0).Value
                    .Item(Indice - 1).Cells(2).Value = Linea.Cells(4).Value
                    .Item(Indice - 1).Cells(3).Value = Linea.Cells(1).Value
                    .Item(Indice - 1).Cells(5).Value = Linea.Cells(3).Value
                    .Item(Indice - 1).Cells(4).Value = Linea.Cells(2).Value
                    SubTotal = Val(Linea.Cells(1).Value) * Val(Linea.Cells(2).Value)
                    .Item(Indice - 1).Cells(6).Value = Format(SubTotal, "#,###,##0.00")
                End With
                Total += SubTotal
            Next

            GUI_Ventas.txtTotal.Text = Format(Total, "#,###,##0.00")
        Catch ex As Exception
            X(ex)
        End Try

    End Sub

    Private Sub GUI_Ventas_Agregar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CargarTablaPrincipal()
    End Sub

    Private Sub txtCantidad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyUp
        CalcularMonto()
    End Sub

    Private Sub dgvDetalles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvDetalles.KeyPress
        If e.KeyChar = "x" Or e.KeyChar = "X" Then
            Close()
        End If
    End Sub
End Class