Imports System.Data.SqlClient

Public Class CalifReprobatoria
    Private Sub CalifReprobatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub CargarDatosCalificacionesReprobatorias(idAlumno As Integer)
        Try
            conexion.Open()

            Dim command As New SqlCommand("ObtenerMaestroCalificacionReprobatoria", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@id_alumno", idAlumno)

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            dgv.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ObtenerSemestreConMasReprobadas()
        Try
            conexion.Open()

            Dim Query As String = "ObtenerSemestreConMasReprobadas"
            Dim cmd As New SqlCommand(Query, conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id_alumno", LogIn.id_persona)

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

    Private Sub btn_maestros_Click(sender As Object, e As EventArgs) Handles btn_maestros.Click
        If cmb_option.SelectedIndex = 0 Then
            CargarDatosCalificacionesReprobatorias(LogIn.id_persona)
        ElseIf cmb_option.SelectedIndex = 1 Then
            ObtenerSemestreConMasReprobadas()
        End If
    End Sub


End Class