<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCalif
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
        Me.btn_promediar = New System.Windows.Forms.Button()
        Me.dg_alumnos = New System.Windows.Forms.DataGridView()
        Me.txt_materia = New System.Windows.Forms.TextBox()
        Me.txt_alumno = New System.Windows.Forms.TextBox()
        Me.txt_semestre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_calif = New System.Windows.Forms.TextBox()
        CType(Me.dg_alumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_promediar
        '
        Me.btn_promediar.Location = New System.Drawing.Point(361, 332)
        Me.btn_promediar.Name = "btn_promediar"
        Me.btn_promediar.Size = New System.Drawing.Size(102, 22)
        Me.btn_promediar.TabIndex = 13
        Me.btn_promediar.Text = "Promediar"
        Me.btn_promediar.UseVisualStyleBackColor = True
        '
        'dg_alumnos
        '
        Me.dg_alumnos.AllowUserToAddRows = False
        Me.dg_alumnos.AllowUserToDeleteRows = False
        Me.dg_alumnos.AllowUserToResizeRows = False
        Me.dg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_alumnos.Location = New System.Drawing.Point(16, 111)
        Me.dg_alumnos.MultiSelect = False
        Me.dg_alumnos.Name = "dg_alumnos"
        Me.dg_alumnos.ReadOnly = True
        Me.dg_alumnos.RowHeadersVisible = False
        Me.dg_alumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dg_alumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_alumnos.ShowEditingIcon = False
        Me.dg_alumnos.Size = New System.Drawing.Size(447, 204)
        Me.dg_alumnos.TabIndex = 14
        '
        'txt_materia
        '
        Me.txt_materia.Location = New System.Drawing.Point(84, 22)
        Me.txt_materia.Name = "txt_materia"
        Me.txt_materia.Size = New System.Drawing.Size(194, 20)
        Me.txt_materia.TabIndex = 15
        '
        'txt_alumno
        '
        Me.txt_alumno.Location = New System.Drawing.Point(84, 63)
        Me.txt_alumno.Name = "txt_alumno"
        Me.txt_alumno.Size = New System.Drawing.Size(379, 20)
        Me.txt_alumno.TabIndex = 16
        '
        'txt_semestre
        '
        Me.txt_semestre.Location = New System.Drawing.Point(361, 22)
        Me.txt_semestre.Name = "txt_semestre"
        Me.txt_semestre.Size = New System.Drawing.Size(102, 20)
        Me.txt_semestre.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Materia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Alumno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Semestre"
        '
        'txt_calif
        '
        Me.txt_calif.Location = New System.Drawing.Point(260, 334)
        Me.txt_calif.Name = "txt_calif"
        Me.txt_calif.Size = New System.Drawing.Size(95, 20)
        Me.txt_calif.TabIndex = 21
        '
        'AddCalif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 381)
        Me.Controls.Add(Me.txt_calif)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_semestre)
        Me.Controls.Add(Me.txt_alumno)
        Me.Controls.Add(Me.txt_materia)
        Me.Controls.Add(Me.dg_alumnos)
        Me.Controls.Add(Me.btn_promediar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCalif"
        Me.Text = "AddCalif"
        CType(Me.dg_alumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_promediar As Button
    Friend WithEvents dg_alumnos As DataGridView
    Friend WithEvents txt_materia As TextBox
    Friend WithEvents txt_alumno As TextBox
    Friend WithEvents txt_semestre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_calif As TextBox
End Class
