<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnsView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasReprobadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprobadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarUsuariosToolStripMenuItem, Me.MateriasReprobadasToolStripMenuItem, Me.ReprobadasToolStripMenuItem, Me.MateriasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarUsuariosToolStripMenuItem
        '
        Me.RegistrarUsuariosToolStripMenuItem.Name = "RegistrarUsuariosToolStripMenuItem"
        Me.RegistrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.RegistrarUsuariosToolStripMenuItem.Text = "Kardex"
        '
        'MateriasReprobadasToolStripMenuItem
        '
        Me.MateriasReprobadasToolStripMenuItem.Name = "MateriasReprobadasToolStripMenuItem"
        Me.MateriasReprobadasToolStripMenuItem.Size = New System.Drawing.Size(129, 25)
        Me.MateriasReprobadasToolStripMenuItem.Text = "Oportunidades"
        '
        'ReprobadasToolStripMenuItem
        '
        Me.ReprobadasToolStripMenuItem.Name = "ReprobadasToolStripMenuItem"
        Me.ReprobadasToolStripMenuItem.Size = New System.Drawing.Size(107, 25)
        Me.ReprobadasToolStripMenuItem.Text = "Reprobadas"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'btnExit
        '
        Me.btnExit.Image = Global.siiaproyect.My.Resources.Resources._exit
        Me.btnExit.Location = New System.Drawing.Point(551, 311)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        '
        'AlumnsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AlumnsView"
        Me.Text = "AlumnsView"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasReprobadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReprobadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As ToolStripMenuItem
End Class
