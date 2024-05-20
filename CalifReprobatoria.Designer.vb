<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalifReprobatoria
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btn_maestros = New System.Windows.Forms.Button()
        Me.cmb_option = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(34, 102)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowEditingIcon = False
        Me.dgv.Size = New System.Drawing.Size(387, 243)
        Me.dgv.TabIndex = 16
        '
        'btn_maestros
        '
        Me.btn_maestros.Location = New System.Drawing.Point(346, 43)
        Me.btn_maestros.Name = "btn_maestros"
        Me.btn_maestros.Size = New System.Drawing.Size(75, 23)
        Me.btn_maestros.TabIndex = 18
        Me.btn_maestros.Text = "Mostrar"
        Me.btn_maestros.UseVisualStyleBackColor = True
        '
        'cmb_option
        '
        Me.cmb_option.FormattingEnabled = True
        Me.cmb_option.Items.AddRange(New Object() {"Maestros que te han reprobado", "Semestre con mas reprobadas"})
        Me.cmb_option.Location = New System.Drawing.Point(34, 45)
        Me.cmb_option.Name = "cmb_option"
        Me.cmb_option.Size = New System.Drawing.Size(306, 21)
        Me.cmb_option.TabIndex = 19
        '
        'CalifReprobatoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 365)
        Me.Controls.Add(Me.cmb_option)
        Me.Controls.Add(Me.btn_maestros)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CalifReprobatoria"
        Me.Text = "CalifReprobatoria"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents btn_maestros As Button
    Friend WithEvents cmb_option As ComboBox
End Class
