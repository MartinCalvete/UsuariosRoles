Public Class Login
    Private Sub BtnNoUser_Click(sender As Object, e As EventArgs) Handles BtnNoUser.Click
        Registro.ShowDialog()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        '0 = Admini
        '1 = Operador
        '2 = Comun

        If ExistenciaUsuario(TxtUsuarioL.Text, TxtContraseñaL.Text) = 0 Or ExistenciaUsuario(TxtUsuarioL.Text, TxtContraseñaL.Text) = 1 Then
            MenuPrincipal.ShowDialog()
            Me.Hide()

        ElseIf ExistenciaUsuario(TxtUsuarioL.Text, TxtContraseñaL.Text) = 2 Then
            MsgBox("Usuario comun")
            UsuariosComunes.ShowDialog()
        Else
            MsgBox("Contraseña o usuario incorrecto, vuelva a ingresar los datos", MsgBoxStyle.Critical)

        End If

        TxtUsuarioL.Text.DefaultIfEmpty
        TxtUsuarioL.Text.DefaultIfEmpty

    End Sub
End Class
