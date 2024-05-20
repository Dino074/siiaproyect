Public Class AdminView
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        LogIn.Show()
        Me.Close()
    End Sub

    Sub RegistrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuariosToolStripMenuItem.Click
        frmHorarios.Close()
        RegistrarUsuarios.Activate()
        RegistrarUsuarios.MdiParent = Me
        RegistrarUsuarios.Show()
    End Sub

    Sub CrearHorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearHorariosToolStripMenuItem.Click
        RegistrarUsuarios.Close()
        frmHorarios.Activate()
        frmHorarios.MdiParent = Me
        frmHorarios.Show()
    End Sub
End Class