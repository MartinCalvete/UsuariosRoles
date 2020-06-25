Imports MySql.Data.MySqlClient
Public Class MenuPrincipal

    Dim Conexion As New MySqlConnection
    Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
    Dim DS As New DataSet
    Dim cmd As MySqlCommand = New MySqlCommand


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizador2()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click

        Dim M As Boolean
        Dim Nombre As String

        If (DgvTabla.SelectedRows.Count > 0) Then

            M = DgvTabla.Item("Activo", DgvTabla.SelectedRows(0).Index).Value
            Nombre = DgvTabla.Item("Nombre", DgvTabla.SelectedRows(0).Index).Value

            If M = False Then
                TrueFalse(M, Nombre)
            End If
            actualizador2()
        End If

    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click

        Dim M As Boolean
        Dim Nombre As String

        If (DgvTabla.SelectedRows.Count > 0) Then
            M = DgvTabla.Item("Activo", DgvTabla.SelectedRows(0).Index).Value
            Nombre = DgvTabla.Item("Nombre", DgvTabla.SelectedRows(0).Index).Value
            If M = True Then
                TrueFalse(M, Nombre)
                actualizador2()
            End If
        End If
    End Sub


    Private Sub BtnCamCont_Click(sender As Object, e As EventArgs) Handles BtnCamCont.Click

        Dim Contraseña, Contraseña2, Nombre As String
        Contraseña = DgvTabla.Item("Contraseña", DgvTabla.SelectedRows(0).Index).Value
        Contraseña2 = InputBox("Ingrese la contraseña que desee", "Ingrese una nueva contraseña", Contraseña, 100, 0)
        Nombre = DgvTabla.Item("Nombre", DgvTabla.SelectedRows(0).Index).Value

        If CambiarContraseña(Nombre, Contraseña2) Then
            MsgBox("La contraseña ha sido modificada con exito", MsgBoxStyle.Information)
        Else
            MsgBox("Ha ocurrido un error, la contraseña no pudo ser modificada", MsgBoxStyle.Critical)
        End If
        actualizador2()
    End Sub

End Class