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
        HorariosOpen.Visible = False
        RegistroOpen.MdiParent = Me
        RegistroOpen.Show()
    End Sub

    Sub CrearHorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearHorariosToolStripMenuItem.Click
        RegistroOpen.Visible = False
        HorariosOpen.MdiParent = Me
        HorariosOpen.Show()
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