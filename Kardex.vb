Imports System.Data.SqlClient

Public Class Kardex
    Private Sub Kardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        If LogIn.id_rol = 2 Then
            txt_id.Visible = True
            lb_id.Visible = True
            promedio.Text = ObtenerPromedioAlumno(txt_id.Text)
        Else
            txt_id.Visible = False
            lb_id.Visible = False
            promedio.Text = ObtenerPromedioAlumno(LogIn.id_persona)
        End If
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        LoadData()
        If txt_id.Text <> "" Then
            promedio.Text = ObtenerPromedioAlumno(txt_id.Text)
        End If
    End Sub

    Private Function ObtenerPromedioAlumno(idAlumno As Integer) As Decimal
        Dim promedio As Decimal = 0

        Try
            conexion.Open()
            Dim command As New SqlCommand("ObtenerPromedioAlumno", conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@id_alumno", idAlumno)

            promedio = Convert.ToDecimal(command.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error al obtener el promedio del alumno: " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return promedio
    End Function
    Public Sub LoadData()
        Try
            conexion.Open()

            Dim cmd As New SqlCommand("ObtenerKardexAlumno", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            If txt_id.Text <> "" Then
                cmd.Parameters.AddWithValue("@id_alumno", txt_id.Text)
            ElseIf LogIn.id_rol = 3 Then
                cmd.Parameters.AddWithValue("@id_alumno", LogIn.id_persona)
            Else
                cmd.Parameters.AddWithValue("@id_alumno", DBNull.Value)
            End If

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            dg_kardex.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar el Kardex del alumno: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub



End Class