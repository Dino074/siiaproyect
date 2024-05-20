Public Class TeachersView
    Dim Calif As New AddCalif(), Kardex As New Kardex(), Repro As New Reprobados()
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        LogIn.Show()
        Me.Close()
    End Sub

    Private Sub ReprobadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReprobadosToolStripMenuItem.Click
        Repro.MdiParent = Me
        Repro.Show()
    End Sub

    Private Sub CalificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalificarToolStripMenuItem.Click
        Calif.MdiParent = Me
        Calif.Show()
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
        Kardex.MdiParent = Me
        Kardex.Show()
    End Sub
End Class