Imports System.Data.SqlClient

Public Class MaestroLibre

    Private Sub CargarDias()
        Try
            conexion.Open()
            Dim Query As String = "SELECT descripcion FROM dias"
            Dim cmd As New SqlCommand(Query, conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            cmb_dia.Items.Clear()

            While reader.Read()
                cmb_dia.Items.Add(reader("descripcion").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los días: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarHoras()
        Try
            conexion.Open()
            Dim Query As String = "SELECT start_at, end_at FROM horas"
            Dim cmd As New SqlCommand(Query, conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            cmb_hora.Items.Clear()

            While reader.Read()
                Dim horaInicio As String = reader("start_at").ToString()
                Dim horaFin As String = reader("end_at").ToString()
                cmb_hora.Items.Add(horaInicio & " - " & horaFin)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar las horas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub MaestroLibre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDias()
        CargarHoras()
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        Dim diaSeleccionado As String = cmb_dia.SelectedItem.ToString()
        Dim horaSeleccionada As String = cmb_hora.SelectedItem.ToString().Split(" - ")(0)

        Try
            conexion.Open()

            Dim cmd As New SqlCommand("ObtenerMaestroLibreAHora", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@hora", TimeSpan.Parse(horaSeleccionada))
            cmd.Parameters.AddWithValue("@dia", diaSeleccionado)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgv.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error al obtener los maestros libres: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class