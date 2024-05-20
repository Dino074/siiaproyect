Imports System.Data.SqlClient
Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub
    Public Shared id_persona As Integer = -1, id_rol As Integer = -1
    Private Sub initBtn_Click(sender As Object, e As EventArgs) Handles initBtn.Click
        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Por favor llene los campos necesarios", Title:="Error")
        Else
            Dim usr As String = txtUsuario.Text
            Dim pass As String = txtPassword.Text

            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Query = "SELECT id_persona FROM persona WHERE contrasenia = '" + pass + "' AND correo = '" + usr + "'"
                cmd = New SqlCommand(Query, conexion)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    id_persona = Convert.ToInt32(result)
                Else
                    MsgBox("Usuario o contraseña no válido", Title:="Error")
                End If
                conexion.Close()
            End If

            If id_persona <> -1 Then ' Verificamos si se encontró un usuario válido
                Dim rol As Integer = ObtenerRol(id_persona) ' Llamamos a una función para obtener el rol del usuario
                If rol <> -1 Then ' Verificamos si se obtuvo correctamente el rol
                    AbrirVentanaSegunRol(rol) ' Abrimos la ventana correspondiente según el rol
                Else
                    MsgBox("No se pudo obtener el rol del usuario", Title:="Error")
                End If
            End If
        End If
    End Sub

    Private Function ObtenerRol(id_persona As Integer) As Integer
        Dim rol As Integer = -1
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT rol FROM persona WHERE id_persona = " & id_persona
            cmd = New SqlCommand(Query, conexion)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                rol = Convert.ToInt32(result)
            End If
            id_rol = rol
            conexion.Close()
        End If
        Return rol
    End Function

    Private Sub AbrirVentanaSegunRol(rol As Integer)
        Select Case rol
            Case 1
                AdminView.Show()
            Case 2
                TeachersView.Show()
            Case 3
                AlumnsView.Show()
            Case Else
                MsgBox("Rol no válido", Title:="Error")
        End Select
        Me.Hide()
    End Sub

End Class
