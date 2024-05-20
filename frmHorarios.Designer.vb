<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCarreras = New System.Windows.Forms.ComboBox()
        Me.cmbDias = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Duracion = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.cmbMaterias = New System.Windows.Forms.ComboBox()
        Me.txtMaestro = New System.Windows.Forms.TextBox()
        Me.cmbHora = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEndAt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carrera:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Materia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Maestro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dia:"
        '
        'cmbCarreras
        '
        Me.cmbCarreras.FormattingEnabled = True
        Me.cmbCarreras.Location = New System.Drawing.Point(121, 33)
        Me.cmbCarreras.Name = "cmbCarreras"
        Me.cmbCarreras.Size = New System.Drawing.Size(381, 36)
        Me.cmbCarreras.TabIndex = 5
        '
        'cmbDias
        '
        Me.cmbDias.FormattingEnabled = True
        Me.cmbDias.Location = New System.Drawing.Point(93, 138)
        Me.cmbDias.Name = "cmbDias"
        Me.cmbDias.Size = New System.Drawing.Size(409, 36)
        Me.cmbDias.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(265, 301)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(126, 37)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hora inicio:"
        '
        'Duracion
        '
        Me.Duracion.AutoSize = True
        Me.Duracion.Location = New System.Drawing.Point(508, 71)
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Size = New System.Drawing.Size(101, 28)
        Me.Duracion.TabIndex = 12
        Me.Duracion.Text = "Duracion:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(587, 71)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(23, 28)
        Me.lblDuracion.TabIndex = 13
        Me.lblDuracion.Text = "0"
        '
        'cmbMaterias
        '
        Me.cmbMaterias.FormattingEnabled = True
        Me.cmbMaterias.Location = New System.Drawing.Point(122, 68)
        Me.cmbMaterias.Name = "cmbMaterias"
        Me.cmbMaterias.Size = New System.Drawing.Size(380, 36)
        Me.cmbMaterias.TabIndex = 6
        '
        'txtMaestro
        '
        Me.txtMaestro.Enabled = False
        Me.txtMaestro.Location = New System.Drawing.Point(122, 103)
        Me.txtMaestro.Name = "txtMaestro"
        Me.txtMaestro.Size = New System.Drawing.Size(380, 34)
        Me.txtMaestro.TabIndex = 14
        '
        'cmbHora
        '
        Me.cmbHora.FormattingEnabled = True
        Me.cmbHora.Location = New System.Drawing.Point(161, 173)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(341, 36)
        Me.cmbHora.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Hora fin:"
        '
        'txtEndAt
        '
        Me.txtEndAt.Enabled = False
        Me.txtEndAt.Location = New System.Drawing.Point(145, 207)
        Me.txtEndAt.Name = "txtEndAt"
        Me.txtEndAt.Size = New System.Drawing.Size(357, 34)
        Me.txtEndAt.TabIndex = 16
        '
        'frmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 350)
        Me.Controls.Add(Me.txtEndAt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMaestro)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.Duracion)
        Me.Controls.Add(Me.cmbHora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbDias)
        Me.Controls.Add(Me.cmbMaterias)
        Me.Controls.Add(Me.cmbCarreras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmHorarios"
        Me.Text = "frmHorarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCarreras As ComboBox
    Friend WithEvents cmbDias As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Duracion As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents cmbMaterias As ComboBox
    Friend WithEvents txtMaestro As TextBox
    Friend WithEvents cmbHora As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEndAt As TextBox
End Class
