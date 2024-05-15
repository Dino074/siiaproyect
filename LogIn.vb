Imports System.Data.SqlClient
Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub initBtn_Click(sender As Object, e As EventArgs) Handles initBtn.Click
        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Por favor llene los campos necesarios", Title:="Error")
        Else
            Dim usr As String
            Dim pass As String
            Dim rol As Integer
            usr = txtUsuario.Text
            pass = txtPassword.Text
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Query = "SELECT nombres FROM persona WHERE contrasenia = '" + pass + "' AND correo = '" + usr + "'"
                cmd = New SqlCommand(Query, conexion)
                cmd.ExecuteNonQuery()
                sqlread = cmd.ExecuteReader
                If sqlread.Read Then
                    sqlread.Close()
                    cmd.Dispose()
                    Query = "SELECT rol FROM persona WHERE contrasenia = '" + pass + "' AND correo = '" + usr + "'"
                    cmd = New SqlCommand(Query, conexion)
                    cmd.ExecuteNonQuery()
                    sqlread = cmd.ExecuteReader
                    While sqlread.Read
                        rol = sqlread("rol")
                    End While
                    sqlread.Close()
                    cmd.Dispose()
                    conexion.Close()
                Else
                    sqlread.Close()
                    cmd.Dispose()
                    conexion.Close()
                    MsgBox("Usuario o contraña no valido", Title:="Error")
                End If

            End If
            If rol = 1 Then
                AdminView.Show()
                Me.Hide()
            ElseIf rol = 2 Then
                TeachersView.Show()
                Me.Hide()
            ElseIf rol = 3 Then
                AlumnsView.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class
