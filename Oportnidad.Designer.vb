<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oportnidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_materia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.oportunidad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Materias"
        '
        'cmb_materia
        '
        Me.cmb_materia.FormattingEnabled = True
        Me.cmb_materia.Location = New System.Drawing.Point(101, 29)
        Me.cmb_materia.Name = "cmb_materia"
        Me.cmb_materia.Size = New System.Drawing.Size(136, 21)
        Me.cmb_materia.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Aprobo en la oportunidad"
        '
        'oportunidad
        '
        Me.oportunidad.AutoSize = True
        Me.oportunidad.Location = New System.Drawing.Point(214, 82)
        Me.oportunidad.Name = "oportunidad"
        Me.oportunidad.Size = New System.Drawing.Size(16, 13)
        Me.oportunidad.TabIndex = 22
        Me.oportunidad.Text = "---"
        '
        'Oportnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 139)
        Me.Controls.Add(Me.oportunidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_materia)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Oportnidad"
        Me.Text = "Oportunidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_materia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents oportunidad As Label
End Class
