Imports System.Data.SqlClient

Public Class Reprobados

    Private Sub CargarDatosAlumnosReprobados(numReprobadas As Integer)
        Try
            conexion.Open()

            Dim cmd As New SqlCommand("ObtenerAlumnoRepruebaNVeces", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@num_reprobadas", numReprobadas)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub txt_alum_TextChanged(sender As Object, e As EventArgs) Handles txt_alum.TextChanged
        CargarDatosAlumnosReprobados(txt_alum.Text)
    End Sub
End Class