Imports System.Data.SqlClient

Public Class frmHorarios
    Dim idmateria, carreraId, idhora, idcurso, idia, duracionHrs, restarhrs As Integer
    Private Sub cmbCarreras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarreras.SelectedIndexChanged
        cmbMaterias.Items.Clear()
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT id_carrera FROM carrera WHERE carrera = '" + cmbCarreras.Text + "'"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                carreraId = sqlread("id_carrera")
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "SELECT nombre_materia FROM materias WHERE id_carr = " + carreraId.ToString + ""
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                cmbMaterias.Items.Add(sqlread("nombre_materia"))
            End While
            sqlread.Close()
            cmd.Dispose()
            conexion.Close()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            If duracionHrs = 0 Then
                MsgBox("No quedan mas horas disponibles para esta materia", Title:="aviso")
            Else
                Query = "select id_hora from horas where start_at = '" + cmbHora.Text + "'"
                cmd = New SqlCommand(Query, conexion)
                cmd.ExecuteNonQuery()
                sqlread = cmd.ExecuteReader
                While sqlread.Read
                    idhora = sqlread("id_hora")
                End While
                sqlread.Close()
                cmd.Dispose()
                Query = "select id_dia from dias where descripcion = '" + cmbDias.Text + "'"
                cmd = New SqlCommand(Query, conexion)
                cmd.ExecuteNonQuery()
                sqlread = cmd.ExecuteReader
                While sqlread.Read
                    idia = sqlread("id_dia")
                End While
                sqlread.Close()
                cmd.Dispose()
                Query = "select id_hora from sesiones where id_hora= " + idhora.ToString + " and id_curso = " + idcurso.ToString + " and id_dia = " + idia.ToString + ""
                cmd = New SqlCommand(Query, conexion)
                cmd.ExecuteNonQuery()
                sqlread = cmd.ExecuteReader
                If sqlread.Read Then
                    cmd.Dispose()
                    sqlread.Close()
                    MsgBox("Hora ya ocupada!", Title:="AVISO")
                Else
                    cmd.Dispose()
                    sqlread.Close()
                    cmd = conexion.CreateCommand
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "GuardarSesiones"
                    cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = idcurso
                    cmd.Parameters.Add("@id_dia", SqlDbType.SmallInt).Value = idia
                    cmd.Parameters.Add("@id_hora", SqlDbType.SmallInt).Value = idhora
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro exitoso!", Title:="AVISO")
                    cmd.Dispose()
                    duracionHrs -= 1
                    lblDuracion.Text = duracionHrs.ToString
                End If
            End If
        End If
        restarhrs = 0
        conexion.Close()
    End Sub

    Private Sub cmbHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHora.SelectedIndexChanged
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT end_at FROM horas where start_at = '" + cmbHora.Text + "'"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                txtEndAt.Text = sqlread("end_at").ToString
            End While
            sqlread.Close()
            cmd.Dispose()
            conexion.Close()
        End If
    End Sub

    Private Sub frmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT carrera FROM carrera"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                cmbCarreras.Items.Add(sqlread("carrera"))
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "SELECT descripcion FROM  dias"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                cmbDias.Items.Add(sqlread("descripcion"))
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "SELECT start_at, end_at FROM horas"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                cmbHora.Items.Add(sqlread("start_at"))
            End While
            sqlread.Close()
            cmd.Dispose()
            conexion.Close()
        End If
    End Sub

    Private Sub cmbMaterias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaterias.SelectedIndexChanged
        Dim nombre, app, apm As String
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT id_carrera FROM carrera WHERE carrera = '" + cmbCarreras.Text + "'"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                carreraId = sqlread("id_carrera")
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "SELECT id_materia, horas_sem FROM materias WHERE nombre_materia = '" + cmbMaterias.Text + "' and id_carr = " + carreraId.ToString + ""
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                idmateria = sqlread("id_materia")
                duracionHrs = sqlread("horas_sem")
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "select n.nombres, n.ap_paterno, n.ap_materno from persona as n, curso as c where n.id_persona = c.id_maestro and c.id_materia = " + idmateria.ToString + ""
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                nombre = sqlread("nombres")
                app = sqlread("ap_paterno")
                apm = sqlread("ap_materno")
            End While
            sqlread.Close()
            cmd.Dispose()
            txtMaestro.Text = nombre + " " + app + " " + apm
            Query = "select id_cursos from curso where id_materia = " + idmateria.ToString + ""
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                idcurso = sqlread("id_cursos")
            End While
            sqlread.Close()
            cmd.Dispose()
            Query = "select id_curso from sesiones where id_curso = " + idcurso.ToString + ""
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                restarhrs += 1
            End While
            sqlread.Close()
            cmd.Dispose()
            duracionHrs -= restarhrs
            lblDuracion.Text = duracionHrs.ToString
            conexion.Close()
        End If
    End Sub
End Class