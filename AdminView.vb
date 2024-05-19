﻿Public Class AdminView
    Dim RegistroOpen As New RegistrarUsuarios()
    Dim HorariosOpen As New frmHorarios()
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
End Class