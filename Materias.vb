Imports System.Data.SqlClient

Public Class Materias

    Private Sub MostrarMateriasMaestro()
        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Dim query As String = "ObtenerMateriasImparteMaestro"
                cmd = New SqlCommand(query, conexion)
                cmd.CommandType = CommandType.StoredProcedure
                If txt_prof.Text <> "" Then
                    cmd.Parameters.AddWithValue("@nombre_maestro", txt_prof.Text)
                Else
                    cmd.Parameters.AddWithValue("@nombre_maestro", DBNull.Value)
                End If

                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                dgv.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener las materias del maestro: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Materias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMateriasMaestro()
    End Sub

    Private Sub txt_prof_TextChanged(sender As Object, e As EventArgs) Handles txt_prof.TextChanged
        MostrarMateriasMaestro()
    End Sub
End Class