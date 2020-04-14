Public Class GUI_Login
    Private DB As D_Usuario

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim Consulta As DataSet
        If txtUsuario.TextLength > 1 Then
            If txtPassword.TextLength > 1 Then
                Consulta = DB.Login(txtUsuario.Text, txtPassword.Text)
                If Consulta.Tables(0).Rows.Count > 0 Then
                    _usuario_id_usuario = Consulta.Tables(0).Rows(0)(0).ToString
                    _usuario_nombre = Consulta.Tables(0).Rows(0)(1).ToString
                    CargarDB() 'Función publica
                    GUI_Caja_Inicio.Show()
                    Close()
                Else
                    msg("Datos incorrectos!", 3)
                    txtUsuario.Text = ""
                    txtPassword.Text = ""
                    txtUsuario.Select()
                End If
            Else
                msg("Ingrese una contraseña válida!", 3)
                txtPassword.Select()
            End If
        Else
            msg("Ingrese un usuario válido!", 3)
            txtUsuario.Select()
        End If
    End Sub

    Private Sub GUI_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        DB = New D_Usuario
        txtUsuario.Select()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(13) Then
            txtPassword.Select()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(13) Then
            Call BtnEntrar_Click(sender, e)
        End If
    End Sub
End Class
