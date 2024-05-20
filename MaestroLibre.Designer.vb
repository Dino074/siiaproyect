<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaestroLibre
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
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.cmb_hora = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_enter = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 104)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.ShowEditingIcon = False
        Me.dgv.Size = New System.Drawing.Size(489, 357)
        Me.dgv.TabIndex = 18
        '
        'cmb_dia
        '
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Location = New System.Drawing.Point(23, 60)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(159, 21)
        Me.cmb_dia.TabIndex = 19
        '
        'cmb_hora
        '
        Me.cmb_hora.FormattingEnabled = True
        Me.cmb_hora.Location = New System.Drawing.Point(214, 60)
        Me.cmb_hora.Name = "cmb_hora"
        Me.cmb_hora.Size = New System.Drawing.Size(121, 21)
        Me.cmb_hora.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Buscar maestros libres"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(428, 60)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(75, 23)
        Me.btn_enter.TabIndex = 24
        Me.btn_enter.Text = "Buscar"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'MaestroLibre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 490)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_hora)
        Me.Controls.Add(Me.cmb_dia)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MaestroLibre"
        Me.Text = "MaestroLibre"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmb_dia As ComboBox
    Friend WithEvents cmb_hora As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_enter As Button
End Class
