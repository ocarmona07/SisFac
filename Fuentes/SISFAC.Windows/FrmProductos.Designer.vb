<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.lbProductos = New System.Windows.Forms.ListBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Location = New System.Drawing.Point(12, 9)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(62, 13)
        Me.lblCategorias.TabIndex = 0
        Me.lblCategorias.Text = "Categorías:"
        '
        'cbxCategorias
        '
        Me.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.IntegralHeight = False
        Me.cbxCategorias.Location = New System.Drawing.Point(15, 25)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(214, 21)
        Me.cbxCategorias.TabIndex = 1
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Location = New System.Drawing.Point(12, 49)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(58, 13)
        Me.lblProductos.TabIndex = 0
        Me.lblProductos.Text = "Productos:"
        '
        'lbProductos
        '
        Me.lbProductos.FormattingEnabled = True
        Me.lbProductos.Location = New System.Drawing.Point(15, 65)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Size = New System.Drawing.Size(214, 407)
        Me.lbProductos.TabIndex = 2
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(235, 65)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(150, 37)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar Producto"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(235, 108)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(150, 37)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar Producto"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(235, 151)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 37)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(235, 435)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(150, 37)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lbProductos)
        Me.Controls.Add(Me.cbxCategorias)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.lblCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCategorias As System.Windows.Forms.Label
    Friend WithEvents cbxCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductos As System.Windows.Forms.Label
    Friend WithEvents lbProductos As System.Windows.Forms.ListBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
