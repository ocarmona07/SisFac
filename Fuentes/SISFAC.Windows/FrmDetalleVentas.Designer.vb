<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblRUTCli = New System.Windows.Forms.Label()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.lblRUTEmp = New System.Windows.Forms.Label()
        Me.cbxRUTEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.cbxRUTCliente = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.cbxCategorias = New System.Windows.Forms.ComboBox()
        Me.cbxProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.lblEntregado = New System.Windows.Forms.Label()
        Me.lblPagado = New System.Windows.Forms.Label()
        Me.lblApPaternoEmp = New System.Windows.Forms.Label()
        Me.lblApPaternoCli = New System.Windows.Forms.Label()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 446)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(135, 35)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(482, 449)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 35)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Confirmar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblRUTCli
        '
        Me.lblRUTCli.AutoSize = True
        Me.lblRUTCli.Location = New System.Drawing.Point(12, 47)
        Me.lblRUTCli.Name = "lblRUTCli"
        Me.lblRUTCli.Size = New System.Drawing.Size(68, 13)
        Me.lblRUTCli.TabIndex = 9
        Me.lblRUTCli.Text = "RUT Cliente:"
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(496, 17)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipoDocumento.TabIndex = 0
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(386, 20)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(104, 13)
        Me.lblTipoDocumento.TabIndex = 9
        Me.lblTipoDocumento.Text = "Tipo de Documento:"
        '
        'lblRUTEmp
        '
        Me.lblRUTEmp.AutoSize = True
        Me.lblRUTEmp.Location = New System.Drawing.Point(12, 20)
        Me.lblRUTEmp.Name = "lblRUTEmp"
        Me.lblRUTEmp.Size = New System.Drawing.Size(83, 13)
        Me.lblRUTEmp.TabIndex = 9
        Me.lblRUTEmp.Text = "RUT Empleado:"
        '
        'cbxRUTEmpleado
        '
        Me.cbxRUTEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRUTEmpleado.FormattingEnabled = True
        Me.cbxRUTEmpleado.Location = New System.Drawing.Point(101, 17)
        Me.cbxRUTEmpleado.Name = "cbxRUTEmpleado"
        Me.cbxRUTEmpleado.Size = New System.Drawing.Size(132, 21)
        Me.cbxRUTEmpleado.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(450, 47)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(496, 44)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.Producto, Me.Cantidad, Me.Valor, Me.Quitar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.Location = New System.Drawing.Point(12, 141)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.ShowCellErrors = False
        Me.dgvProductos.ShowCellToolTips = False
        Me.dgvProductos.ShowEditingIcon = False
        Me.dgvProductos.ShowRowErrors = False
        Me.dgvProductos.Size = New System.Drawing.Size(605, 265)
        Me.dgvProductos.TabIndex = 15
        '
        'cbxRUTCliente
        '
        Me.cbxRUTCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRUTCliente.FormattingEnabled = True
        Me.cbxRUTCliente.Location = New System.Drawing.Point(101, 44)
        Me.cbxRUTCliente.Name = "cbxRUTCliente"
        Me.cbxRUTCliente.Size = New System.Drawing.Size(132, 21)
        Me.cbxRUTCliente.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(532, 84)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(85, 51)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Location = New System.Drawing.Point(12, 87)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(62, 13)
        Me.lblCategorias.TabIndex = 9
        Me.lblCategorias.Text = "Categorías:"
        '
        'cbxCategorias
        '
        Me.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategorias.FormattingEnabled = True
        Me.cbxCategorias.Location = New System.Drawing.Point(80, 84)
        Me.cbxCategorias.Name = "cbxCategorias"
        Me.cbxCategorias.Size = New System.Drawing.Size(188, 21)
        Me.cbxCategorias.TabIndex = 3
        '
        'cbxProductos
        '
        Me.cbxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProductos.FormattingEnabled = True
        Me.cbxProductos.Location = New System.Drawing.Point(343, 84)
        Me.cbxProductos.Name = "cbxProductos"
        Me.cbxProductos.Size = New System.Drawing.Size(183, 21)
        Me.cbxProductos.TabIndex = 4
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(274, 87)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(58, 13)
        Me.lblProducto.TabIndex = 9
        Me.lblProducto.Text = "Productos:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(12, 114)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(128, 114)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 9
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(168, 111)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 7
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(274, 114)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(63, 13)
        Me.lblComentario.TabIndex = 9
        Me.lblComentario.Text = "Comentario:"
        '
        'txtComentario
        '
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Enabled = False
        Me.txtComentario.Location = New System.Drawing.Point(343, 111)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(183, 20)
        Me.txtComentario.TabIndex = 8
        '
        'cbxCantidad
        '
        Me.cbxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Location = New System.Drawing.Point(80, 111)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(42, 21)
        Me.cbxCantidad.TabIndex = 5
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(9, 415)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 9
        Me.lblDescuento.Text = "Descuento:"
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(77, 412)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 9
        Me.txtDescuento.Text = "0"
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(456, 415)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(496, 412)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDescuento
        '
        Me.btnDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.btnDescuento.Location = New System.Drawing.Point(183, 412)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(85, 20)
        Me.btnDescuento.TabIndex = 10
        Me.btnDescuento.Text = "Ingresar"
        Me.btnDescuento.UseVisualStyleBackColor = True
        '
        'lblEntregado
        '
        Me.lblEntregado.AutoSize = True
        Me.lblEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblEntregado.Location = New System.Drawing.Point(321, 463)
        Me.lblEntregado.Name = "lblEntregado"
        Me.lblEntregado.Size = New System.Drawing.Size(0, 18)
        Me.lblEntregado.TabIndex = 9
        '
        'lblPagado
        '
        Me.lblPagado.AutoSize = True
        Me.lblPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPagado.Location = New System.Drawing.Point(321, 435)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(0, 18)
        Me.lblPagado.TabIndex = 9
        '
        'lblApPaternoEmp
        '
        Me.lblApPaternoEmp.AutoSize = True
        Me.lblApPaternoEmp.Location = New System.Drawing.Point(239, 20)
        Me.lblApPaternoEmp.Name = "lblApPaternoEmp"
        Me.lblApPaternoEmp.Size = New System.Drawing.Size(0, 13)
        Me.lblApPaternoEmp.TabIndex = 16
        '
        'lblApPaternoCli
        '
        Me.lblApPaternoCli.AutoSize = True
        Me.lblApPaternoCli.Location = New System.Drawing.Point(239, 47)
        Me.lblApPaternoCli.Name = "lblApPaternoCli"
        Me.lblApPaternoCli.Size = New System.Drawing.Size(0, 13)
        Me.lblApPaternoCli.TabIndex = 16
        '
        'idProducto
        '
        Me.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idProducto.Frozen = True
        Me.idProducto.HeaderText = "N° Producto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.idProducto.Width = 120
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Producto.Frozen = True
        Me.Producto.HeaderText = "Nombre"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Producto.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Valor
        '
        Me.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Valor.Frozen = True
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Quitar
        '
        Me.Quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Quitar.Frozen = True
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        Me.Quitar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quitar.Text = "Quitar"
        Me.Quitar.ToolTipText = "Se quita el producto de la lista"
        Me.Quitar.UseColumnTextForButtonValue = True
        '
        'FrmDetalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblApPaternoCli)
        Me.Controls.Add(Me.lblApPaternoEmp)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblTipoDocumento)
        Me.Controls.Add(Me.lblRUTEmp)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblComentario)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPagado)
        Me.Controls.Add(Me.lblEntregado)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.cbxProductos)
        Me.Controls.Add(Me.lblRUTCli)
        Me.Controls.Add(Me.cbxCantidad)
        Me.Controls.Add(Me.cbxCategorias)
        Me.Controls.Add(Me.cbxRUTCliente)
        Me.Controls.Add(Me.cbxRUTEmpleado)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnDescuento)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDetalleVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblRUTCli As System.Windows.Forms.Label
    Friend WithEvents cbxTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lblRUTEmp As System.Windows.Forms.Label
    Friend WithEvents cbxRUTEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxRUTCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblCategorias As System.Windows.Forms.Label
    Friend WithEvents cbxCategorias As System.Windows.Forms.ComboBox
    Friend WithEvents cbxProductos As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblComentario As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnDescuento As System.Windows.Forms.Button
    Friend WithEvents lblEntregado As System.Windows.Forms.Label
    Friend WithEvents lblPagado As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents lblApPaternoEmp As System.Windows.Forms.Label
    Friend WithEvents lblApPaternoCli As System.Windows.Forms.Label
    Friend WithEvents idProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quitar As System.Windows.Forms.DataGridViewButtonColumn
End Class
