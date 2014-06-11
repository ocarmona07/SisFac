<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleProductos
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
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnGuardarCerrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cbxCategorias
        '
        Me.cbxCategorias.DropDownHeight = 70
        Me.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.IntegralHeight = False
        Me.cbxCategorias.ItemHeight = 13
        Me.cbxCategorias.Location = New System.Drawing.Point(12, 32)
        Me.cbxCategorias.MaxDropDownItems = 6
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(194, 21)
        Me.cbxCategorias.TabIndex = 1
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(12, 16)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(57, 13)
        Me.lblCategoria.TabIndex = 0
        Me.lblCategoria.Text = "Categoría:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(12, 62)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(110, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Nombre del Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(12, 78)
        Me.txtProducto.MaxLength = 25
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(194, 20)
        Me.txtProducto.TabIndex = 2
        '
        'cbxCantidad
        '
        Me.cbxCantidad.DropDownHeight = 70
        Me.cbxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.IntegralHeight = False
        Me.cbxCantidad.Location = New System.Drawing.Point(12, 123)
        Me.cbxCantidad.MaxDropDownItems = 6
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(75, 21)
        Me.cbxCantidad.TabIndex = 3
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(12, 107)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(12, 153)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 0
        Me.lblValor.Text = "Valor:"
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(12, 198)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(63, 13)
        Me.lblComentario.TabIndex = 0
        Me.lblComentario.Text = "Comentario:"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(12, 214)
        Me.txtComentario.MaxLength = 60
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(194, 20)
        Me.txtComentario.TabIndex = 5
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(12, 243)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 0
        Me.lblEstado.Text = "Estado:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 297)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(194, 30)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnGuardarCerrar
        '
        Me.btnGuardarCerrar.Location = New System.Drawing.Point(12, 333)
        Me.btnGuardarCerrar.Name = "btnGuardarCerrar"
        Me.btnGuardarCerrar.Size = New System.Drawing.Size(194, 30)
        Me.btnGuardarCerrar.TabIndex = 7
        Me.btnGuardarCerrar.Text = "Guardar y Cerrar"
        Me.btnGuardarCerrar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 369)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(194, 30)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(12, 169)
        Me.txtValor.MaxLength = 10
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(110, 20)
        Me.txtValor.TabIndex = 4
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(12, 259)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'FrmDetalleProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardarCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cbxCantidad)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblComentario)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.cbxCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDetalleProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblComentario As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
End Class
