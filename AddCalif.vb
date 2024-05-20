Imports System.Data.SqlClient

Public Class AddCalif
    Private idMateria As Integer
    Private idAlumno As Integer  ' Declaración de la variable de clase


    Private Sub AddCalif_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Obtener el id del maestro desde el formulario de inicio de sesión
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Dim dataTable As New DataTable()

        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                ' Nombre del procedimiento almacenado
                Dim nombreProcedimiento As String = "BuscarAlumnosPorFiltros"
                Dim cmd As New SqlCommand(nombreProcedimiento, conexion)
                cmd.CommandType = CommandType.StoredProcedure

                ' Parámetros
                cmd.Parameters.AddWithValue("@id_maestro", LogIn.id_persona)
                If txt_alumno.Text <> "" Then
                    cmd.Parameters.AddWithValue("@nombre_alumno", txt_alumno.Text)
                Else
                    cmd.Parameters.AddWithValue("@nombre_alumno", DBNull.Value)
                End If
                If txt_materia.Text <> "" Then
                    cmd.Parameters.AddWithValue("@nombre_materia", txt_materia.Text)
                Else
                    cmd.Parameters.AddWithValue("@nombre_materia", DBNull.Value)
                End If
                If txt_semestre.Text <> "" Then
                    cmd.Parameters.AddWithValue("@semestre", txt_semestre.Text)
                Else
                    cmd.Parameters.AddWithValue("@semestre", DBNull.Value)
                End If

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener la información: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        ' Asignar el DataTable al DataGridView
        dg_alumnos.DataSource = dataTable
    End Sub

    Private Sub txt_materia_TextChanged(sender As Object, e As EventArgs) Handles txt_materia.TextChanged
        LoadGrid()
    End Sub

    Private Sub txt_semestre_TextChanged(sender As Object, e As EventArgs) Handles txt_semestre.TextChanged
        LoadGrid()
    End Sub

    Private Sub txt_alumno_TextChanged(sender As Object, e As EventArgs) Handles txt_alumno.TextChanged
        LoadGrid()
    End Sub

    Private Sub btn_promediar_Click(sender As Object, e As EventArgs) Handles btn_promediar.Click
        If dg_alumnos.SelectedRows.Count > 0 Then
            CapturarCalificacion(idAlumno, idMateria, Convert.ToInt32(txt_calif.Text), DateTime.Now.ToString("yyyy-MM-dd"), LogIn.id_persona)
        Else
            MsgBox("Tienes que seleccionar al correspondiente alumno y materia")
        End If
    End Sub

    Private Sub dg_alumnos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_alumnos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene los valores de las celdas de la fila seleccionada
            idAlumno = Convert.ToInt32(dg_alumnos.Rows(e.RowIndex).Cells("Id Alumno").Value)
            idMateria = Convert.ToInt32(dg_alumnos.Rows(e.RowIndex).Cells("Id Materia").Value)
        End If
    End Sub

    Private Sub CapturarCalificacion(idAlumno As Integer, idMateria As Integer, calif As Decimal, fecha As Date, idMaestro As Integer)
        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Dim query As String = "EXEC CapturarCalificacion @id_alumno, @id_materia, @calif, @fecha, @id_maestro"
                cmd = New SqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id_alumno", idAlumno)
                cmd.Parameters.AddWithValue("@id_materia", idMateria)
                cmd.Parameters.AddWithValue("@calif", calif)
                cmd.Parameters.AddWithValue("@fecha", fecha)
                cmd.Parameters.AddWithValue("@id_maestro", idMaestro)
                cmd.ExecuteNonQuery()
                MsgBox("Calificación capturada correctamente.")
            End If
        Catch ex As Exception
            MsgBox("Error al capturar la calificación: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class