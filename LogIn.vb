Public Class LogIn
    Private Sub ProbarConexion_Click(sender As Object, e As EventArgs) Handles ProbarConexion.Click
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            MsgBox("Conexion!")
            conexion.Close()
        End If
    End Sub
End Class
