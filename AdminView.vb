Public Class AdminView
    Dim RegistroOpen As New RegistrarUsuarios()
    Dim HorariosOpen As New frmHorarios()
    Dim MaestroTiempos As New MaestroTiempos
    Dim MaestroLibre As New MaestroLibre
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

    Private Sub TiemposMaestrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiemposMaestrosToolStripMenuItem.Click
        MaestroTiempos.MdiParent = Me
        MaestroTiempos.Show()
    End Sub

    Private Sub MaestroLibreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaestroLibreToolStripMenuItem.Click
        MaestroLibre.MdiParent = Me
        MaestroLibre.Show()
    End Sub
End Class