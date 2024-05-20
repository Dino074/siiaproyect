<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kardex
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
        Me.dg_kardex = New System.Windows.Forms.DataGridView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.promedio = New System.Windows.Forms.Label()
        CType(Me.dg_kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_kardex
        '
        Me.dg_kardex.AllowUserToAddRows = False
        Me.dg_kardex.AllowUserToDeleteRows = False
        Me.dg_kardex.AllowUserToResizeRows = False
        Me.dg_kardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_kardex.Location = New System.Drawing.Point(23, 71)
        Me.dg_kardex.MultiSelect = False
        Me.dg_kardex.Name = "dg_kardex"
        Me.dg_kardex.ReadOnly = True
        Me.dg_kardex.RowHeadersVisible = False
        Me.dg_kardex.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dg_kardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_kardex.ShowEditingIcon = False
        Me.dg_kardex.Size = New System.Drawing.Size(387, 280)
        Me.dg_kardex.TabIndex = 15
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(51, 25)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(115, 20)
        Me.txt_id.TabIndex = 16
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(29, 28)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(16, 13)
        Me.lb_id.TabIndex = 17
        Me.lb_id.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Promedio:"
        '
        'promedio
        '
        Me.promedio.AutoSize = True
        Me.promedio.Location = New System.Drawing.Point(324, 32)
        Me.promedio.Name = "promedio"
        Me.promedio.Size = New System.Drawing.Size(22, 13)
        Me.promedio.TabIndex = 19
        Me.promedio.Text = "0.0"
        '
        'Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 375)
        Me.Controls.Add(Me.promedio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.dg_kardex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Kardex"
        Me.Text = "Kardex"
        CType(Me.dg_kardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_kardex As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lb_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents promedio As Label
End Class
