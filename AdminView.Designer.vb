<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminView))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearHorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiemposMaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.MaestroLibreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarUsuariosToolStripMenuItem, Me.CrearHorariosToolStripMenuItem, Me.TiemposMaestrosToolStripMenuItem, Me.MaestroLibreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarUsuariosToolStripMenuItem
        '
        Me.RegistrarUsuariosToolStripMenuItem.Name = "RegistrarUsuariosToolStripMenuItem"
        Me.RegistrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(155, 25)
        Me.RegistrarUsuariosToolStripMenuItem.Text = "Registrar Usuarios"
        '
        'CrearHorariosToolStripMenuItem
        '
        Me.CrearHorariosToolStripMenuItem.Name = "CrearHorariosToolStripMenuItem"
        Me.CrearHorariosToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.CrearHorariosToolStripMenuItem.Text = "Crear Horarios"
        '
        'TiemposMaestrosToolStripMenuItem
        '
        Me.TiemposMaestrosToolStripMenuItem.Name = "TiemposMaestrosToolStripMenuItem"
        Me.TiemposMaestrosToolStripMenuItem.Size = New System.Drawing.Size(153, 25)
        Me.TiemposMaestrosToolStripMenuItem.Text = "Tiempos maestros"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(449, 419)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 35)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExit.TabIndex = 0
        Me.btnExit.TabStop = False
        '
        'MaestroLibreToolStripMenuItem
        '
        Me.MaestroLibreToolStripMenuItem.Name = "MaestroLibreToolStripMenuItem"
        Me.MaestroLibreToolStripMenuItem.Size = New System.Drawing.Size(118, 25)
        Me.MaestroLibreToolStripMenuItem.Text = "Maestro libre"
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 464)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminView"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearHorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiemposMaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestroLibreToolStripMenuItem As ToolStripMenuItem
End Class
