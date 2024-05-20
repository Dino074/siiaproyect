Imports System.Data.SqlClient

Public Class MaestroTiempos

    Private Sub ObtenerMaestroSinClasesEsteSemestre(semestreActual As Integer)
        Try
            conexion.Open()

            Dim Query As String = "ObtenerMaestroSinClasesEsteSemestre"
            Dim cmd As New SqlCommand(Query, conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@semestre_actual", semestreActual)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgv.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub ObtenerMaestroConMasHorasClase()
        Try
            conexion.Open()

            Dim Query As String = "ObtenerMaestroConMasHorasClase"
            Dim cmd As New SqlCommand(Query, conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgv.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmb_option.SelectedIndex = 0 Then
            ObtenerMaestroConMasHorasClase()
        ElseIf cmb_option.SelectedIndex = 1 Then
            If txt_sem.Text <> "" Then
                ObtenerMaestroSinClasesEsteSemestre(txt_sem.Text)
            Else
                MessageBox.Show("Tienes que especificar el semestre")
            End If

        End If
    End Sub
End Class