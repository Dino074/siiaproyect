Imports System.Data.SqlClient

Public Class Vuelta



    ' Método para cargar las oportunidades en el ComboBox
    Private Sub CargarOportunidades()
        ' Añadir las oportunidades que desees, por ejemplo, de 1 a 5
        For i As Integer = 1 To 5
            cmb_option.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub cmb_option_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_option.SelectedIndexChanged
        Dim oportunidadSeleccionada As Integer = Convert.ToInt32(cmb_option.SelectedItem.ToString())

        Try
            conexion.Open()

            Dim cmd As New SqlCommand("ObtenerAlumnoOportunidad", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@oportunidad", oportunidadSeleccionada)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al obtener las oportunidades: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub Vuelta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarOportunidades()
    End Sub
End Class