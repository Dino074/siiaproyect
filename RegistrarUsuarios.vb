Imports System.Data.SqlClient
Imports System.Windows

Public Class RegistrarUsuarios
    Private Sub RegistrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        If conexion.State = ConnectionState.Open Then
            Query = "SELECT carrera FROM carrera"
            cmd = New SqlCommand(Query, conexion)
            cmd.ExecuteNonQuery()
            sqlread = cmd.ExecuteReader
            While sqlread.Read
                cmbCarrera.Items.Add(sqlread("carrera"))
            End While
            sqlread.Close()
            cmd.Dispose()
            conexion.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim rol As Integer
        Dim carreraId, idAlumno As Integer
        If txtNombres.Text <> "" And txtApp.Text <> "" And txtApm.Text <> "" And txtContrasenia.Text <> "" And
            txtCorreo.Text <> "" And cmbRol.Text <> "" Then
            If cmbRol.Text = "Coordinador" Then
                rol = 1
            ElseIf cmbRol.Text = "Maestro" Then
                rol = 2
            ElseIf cmbRol.Text = "Alumno" Then
                rol = 3
            End If
            If rol = 3 And cmbCarrera.Text = "" Then
                MsgBox("Ingrese los valores solicitados!!", Title:="ERROR")
            Else
                conexion.Open()
                If conexion.State = ConnectionState.Open Then
                    cmd = conexion.CreateCommand
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "RegistroPersona"
                    cmd.Parameters.Add("@ap_paterno", SqlDbType.VarChar).Value = txtApp.Text
                    cmd.Parameters.Add("@ap_materno", SqlDbType.VarChar).Value = txtApm.Text
                    cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = txtNombres.Text
                    cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtCorreo.Text
                    cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = txtContrasenia.Text
                    cmd.Parameters.Add("@rol", SqlDbType.SmallInt).Value = rol
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro exitoso!", Title:="AVISO")
                    cmd.Dispose()
                    If rol = 3 Then
                        Query = "SELECT id_persona FROM persona WHERE correo = '" + txtCorreo.Text + "'"
                        cmd = New SqlCommand(Query, conexion)
                        cmd.ExecuteNonQuery()
                        sqlread = cmd.ExecuteReader
                        While sqlread.Read
                            idAlumno = sqlread("id_persona")
                        End While
                        sqlread.Close()
                        cmd.Dispose()
                        Query = "SELECT id_carrera FROM carrera WHERE carrera = '" + cmbCarrera.Text + "'"
                        cmd = New SqlCommand(Query, conexion)
                        cmd.ExecuteNonQuery()
                        sqlread = cmd.ExecuteReader
                        While sqlread.Read
                            carreraId = sqlread("id_carrera")
                        End While
                        sqlread.Close()
                        cmd.Dispose()
                        cmd = conexion.CreateCommand
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "RegistroCerrera_Persona"
                        cmd.Parameters.Add("@id_persona", SqlDbType.Int).Value = idAlumno
                        cmd.Parameters.Add("@id_carrera", SqlDbType.Int).Value = carreraId
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If
                    conexion.Close()
                Else
                    MsgBox("Conexion fallida!!", Title:="ERROR")
                End If
            End If
        Else
            MsgBox("Ingrese los valores solicitados!!", Title:="ERROR")
        End If
    End Sub
    Private Sub cmbRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRol.SelectedIndexChanged
        If cmbRol.Text = "Alumno" Then
            lblCarrera.Visible = True
            cmbCarrera.Visible = True
        Else
            lblCarrera.Visible = False
            cmbCarrera.Visible = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombres.Text = ""
        txtApp.Text = ""
        txtApm.Text = ""
        txtContrasenia.Text = ""
        txtCorreo.Text = ""
        cmbRol.Text = ""
    End Sub
End Class