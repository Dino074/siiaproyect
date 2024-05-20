Imports System.Data.SqlClient

Public Class Oportnidad


    Private Sub Reprobado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMaterias()
    End Sub

    Private Function ObtenerOportunidades() As Integer
        Dim numeroDeOportunidades As Integer = 0

        Try
            conexion.Open()

            Dim cmd As New SqlCommand("ObtenerOportunidadAprobarMateria", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id_alumno", LogIn.id_persona)
            cmd.Parameters.AddWithValue("@nombre_materia", cmb_materia.Text)

            numeroDeOportunidades = Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("Error al obtener el número de oportunidades: " & ex.Message)
        Finally
            ' Cierra la conexión.
            conexion.Close()
        End Try

        Return numeroDeOportunidades
    End Function

    Private Sub CargarMaterias()
        Try
            conexion.Open()

            Dim Query As String = "SELECT DISTINCT m.nombre_materia " &
                              "FROM materias m " &
                              "JOIN curso c ON m.id_materia = c.id_materia " &
                              "JOIN curso_alumno ca ON c.id_cursos = ca.id_curso " &
                              "WHERE ca.id_persona = @id_alumno"
            Dim cmd As New SqlCommand(Query, conexion)
            cmd.Parameters.AddWithValue("@id_alumno", LogIn.id_persona)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            cmb_materia.Items.Clear()

            While reader.Read()
                cmb_materia.Items.Add(reader("nombre_materia").ToString())
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar las materias: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub cmb_materia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_materia.SelectedIndexChanged
        oportunidad.Text = ObtenerOportunidades()
    End Sub
End Class