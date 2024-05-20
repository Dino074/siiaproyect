<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeachersView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeachersView))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprobadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.AlumnoVueltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalificarToolStripMenuItem, Me.KardexToolStripMenuItem, Me.ReprobadosToolStripMenuItem, Me.AlumnoVueltaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalificarToolStripMenuItem
        '
        Me.CalificarToolStripMenuItem.Name = "CalificarToolStripMenuItem"
        Me.CalificarToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.CalificarToolStripMenuItem.Text = "Calificar"
        '
        'KardexToolStripMenuItem
        '
        Me.KardexToolStripMenuItem.Name = "KardexToolStripMenuItem"
        Me.KardexToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.KardexToolStripMenuItem.Text = "Kardex"
        '
        'ReprobadosToolStripMenuItem
        '
        Me.ReprobadosToolStripMenuItem.Name = "ReprobadosToolStripMenuItem"
        Me.ReprobadosToolStripMenuItem.Size = New System.Drawing.Size(107, 25)
        Me.ReprobadosToolStripMenuItem.Text = "Reprobados"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(521, 297)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 36)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExit.TabIndex = 1
        Me.btnExit.TabStop = False
        '
        'AlumnoVueltaToolStripMenuItem
        '
        Me.AlumnoVueltaToolStripMenuItem.Name = "AlumnoVueltaToolStripMenuItem"
        Me.AlumnoVueltaToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.AlumnoVueltaToolStripMenuItem.Text = "Alumno vuelta"
        '
        'TeachersView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(472, 342)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TeachersView"
        Me.Text = "Teachers View"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KardexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReprobadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnoVueltaToolStripMenuItem As ToolStripMenuItem
End Class
