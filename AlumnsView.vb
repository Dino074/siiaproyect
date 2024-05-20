Public Class AlumnsView
    Dim Oport As New Oportnidad(), Kardex As New Kardex(), CalifRep As New CalifReprobatoria()
    Dim Materias As New Materias()

    Private Sub RegistrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarUsuariosToolStripMenuItem.Click
        Kardex.MdiParent = Me
        Kardex.Show()
    End Sub

    Private Sub MateriasReprobadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasReprobadasToolStripMenuItem.Click
        Oport.MdiParent = Me
        Oport.Show()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MateriasToolStripMenuItem.Click
        Materias.MdiParent = Me
        Materias.Show()
    End Sub

    Private Sub ReprobadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprobadasToolStripMenuItem.Click
        CalifRep.MdiParent = Me
        CalifRep.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        LogIn.Show()
        Me.Close()
    End Sub


End Class