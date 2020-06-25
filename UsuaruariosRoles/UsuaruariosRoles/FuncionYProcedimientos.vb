Imports MySql.Data.MySqlClient
Module FuncionYProcedimientos

    Dim Conexion As New MySqlConnection
    Dim DataAdapter As MySqlDataAdapter
    Dim DS As New DataSet
    Dim Sql As String
    Dim F As Boolean = False
    Dim cmd As New MySqlCommand

    Function ExistenciaUsuario(ByVal Usuario As String, ByVal Contraseña As String) As Integer
        Dim F As Integer
        Try
            Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
            Sql = "SELECT * FROM  usuarios WHERE Nombre='" & Usuario & "' AND Contraseña='" & Contraseña & "' AND Activo = 1"

            Conexion.Open()
            DataAdapter = New MySqlDataAdapter(Sql, Conexion)
            DS.Clear()
            DataAdapter.Fill(DS, "usuarios")

            MenuPrincipal.LblSaludo.Text = Usuario

            If (DS.Tables("usuarios").Rows.Count() = 1) Then

                Dim num As Integer

                num = DS.Tables("usuarios").Rows(0).Item("IDRol")

                If num = 1 Then

                    F = 0

                ElseIf num = 2 Then

                    MenuPrincipal.gbA.Enabled = False
                    F = 1


                ElseIf num = 3 Then

                    F = 2

                End If

            Else

                F = 3

            End If
            Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return F
    End Function


    Function ExistenciaUsuario2(ByVal Usuario As String) As Boolean

        Dim Conexion As New MySqlConnection
        Dim DataAdapter As MySqlDataAdapter = New MySqlDataAdapter
        Dim DS As New DataSet
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim F As Boolean = False


        Try

            Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
            Conexion.Open()
            cmd.Connection = Conexion

            cmd.CommandText = "SELECT IDUsuario, Nombre, Contraseña, Activo FROM  usuarios WHERE Nombre=@Nombre"
            cmd.Parameters.AddWithValue("@Nombre", Usuario)
            DataAdapter.SelectCommand = cmd

            DS.Reset()
            DataAdapter.Fill(DS, "Tabla")

            If (DS.Tables("Tabla").Rows.Count() = 1) Then
                F = True
            Else
                F = False
            End If
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return F
    End Function


    Function RegistroA(ByVal Usuario As String, ByVal Contraseña As String) As Boolean
        Dim V As Boolean
        Dim SI As Byte
        SI = MsgBox("¿Esta seguro que desea Registrarse? ", MsgBoxStyle.Information + vbYesNo)

        If SI = vbYes Then
            Try
                Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
                Conexion.Open()
                cmd.Connection = Conexion
                cmd.CommandText = "INSERT INTO usuarios(Nombre, Contraseña, IDRol, Activo) VALUES (@Nombre, @Contraseña, @IDRol, @Activo)"
                cmd.Prepare()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Nombre", Usuario)
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña)
                cmd.Parameters.AddWithValue("@IDRol", 3)
                cmd.Parameters.AddWithValue("@Activo", 0)
                cmd.ExecuteNonQuery()
                Conexion.Close()
            Catch ex As Exception
                MsgBox("Ha ocurrido un error", MsgBoxStyle.Critical)
            End Try
        End If
        Return V = True
    End Function


    Public Sub actualizador2()
        Dim Conexion As New MySqlConnection
        Dim DA As MySqlDataAdapter
        Dim DS As New DataSet
        Dim S_sql As String

        Try
            Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
            S_sql = "SELECT  IDUsuario, Nombre, Contraseña, Activo FROM usuarios ORDER BY Nombre ASC"
            Conexion.Open()
            DA = New MySqlDataAdapter(S_sql, Conexion)
            DA.Fill(DS, "Tabla")
            MenuPrincipal.DgvTabla.DataSource = DS
            MenuPrincipal.DgvTabla.DataMember = "Tabla"
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Function TrueFalse(ByVal a As Boolean, ByVal Nombre As String) As Boolean
        Dim R As Boolean
        Dim Numero As Integer = 0

        If R = False Then

            Numero = 1
            R = False
        Else
            Numero = 0
            R = True
        End If

        Try
            Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
            Conexion.Open()
            cmd.Connection = Conexion
            cmd.CommandText = "UPDATE Usuarios SET Activo=@Activo WHERE Nombre=@Nombre"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Activo", Numero)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.ExecuteNonQuery()

            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return R
    End Function

    Function CambiarContraseña(ByVal Nombre As String, ByVal Contraseña As String) As Boolean

        Dim T As Boolean

        Try

            Conexion.ConnectionString = "server=localhost; database=usuariosroles;Uid=root;Pwd=;"
            Conexion.Open()
            cmd.Connection = Conexion
            cmd.CommandText = "UPDATE Usuarios SET Contraseña=@Contraseña WHERE Nombre=@Nombre"
            cmd.Prepare()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.ExecuteNonQuery()

            Conexion.Close()
            T = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            T = False
        End Try

        Return T
    End Function

End Module
