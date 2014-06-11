<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbIdVenta = New System.Windows.Forms.RadioButton()
        Me.rbRUTEmpleado = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.rbRUTCliente = New System.Windows.Forms.RadioButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.RUTCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Entregado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnVerVenta = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(184, 30)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(233, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(272, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'rbIdVenta
        '
        Me.rbIdVenta.AutoSize = True
        Me.rbIdVenta.Checked = True
        Me.rbIdVenta.Location = New System.Drawing.Point(187, 53)
        Me.rbIdVenta.Name = "rbIdVenta"
        Me.rbIdVenta.Size = New System.Drawing.Size(87, 17)
        Me.rbIdVenta.TabIndex = 2
        Me.rbIdVenta.TabStop = True
        Me.rbIdVenta.Text = "Por N° Venta"
        Me.rbIdVenta.UseVisualStyleBackColor = True
        '
        'rbRUTEmpleado
        '
        Me.rbRUTEmpleado.AutoSize = True
        Me.rbRUTEmpleado.Location = New System.Drawing.Point(280, 53)
        Me.rbRUTEmpleado.Name = "rbRUTEmpleado"
        Me.rbRUTEmpleado.Size = New System.Drawing.Size(117, 17)
        Me.rbRUTEmpleado.TabIndex = 2
        Me.rbRUTEmpleado.Text = "Por RUT Empleado"
        Me.rbRUTEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(511, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 43)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'rbRUTCliente
        '
        Me.rbRUTCliente.AutoSize = True
        Me.rbRUTCliente.Location = New System.Drawing.Point(403, 53)
        Me.rbRUTCliente.Name = "rbRUTCliente"
        Me.rbRUTCliente.Size = New System.Drawing.Size(102, 17)
        Me.rbRUTCliente.TabIndex = 2
        Me.rbRUTCliente.Text = "Por RUT Cliente"
        Me.rbRUTCliente.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(666, 496)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(111, 29)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(12, 496)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(111, 29)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Nueva Venta"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(320, 496)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(111, 29)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar Venta"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToResizeColumns = False
        Me.dgvVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RUTCliente, Me.RutEmpleado, Me.idVenta, Me.RutCli, Me.RutEmp, Me.Fecha, Me.Pagado, Me.Entregado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = "0"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(12, 76)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.ShowEditingIcon = False
        Me.dgvVentas.Size = New System.Drawing.Size(765, 390)
        Me.dgvVentas.TabIndex = 6
        '
        'RUTCliente
        '
        Me.RUTCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RUTCliente.Frozen = True
        Me.RUTCliente.HeaderText = "Rut Cli Oculto"
        Me.RUTCliente.Name = "RUTCliente"
        Me.RUTCliente.ReadOnly = True
        Me.RUTCliente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RUTCliente.Visible = False
        Me.RUTCliente.Width = 83
        '
        'RutEmpleado
        '
        Me.RutEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RutEmpleado.HeaderText = "Rut Emp Oculto"
        Me.RutEmpleado.Name = "RutEmpleado"
        Me.RutEmpleado.ReadOnly = True
        Me.RutEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RutEmpleado.Visible = False
        '
        'idVenta
        '
        Me.idVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idVenta.Frozen = True
        Me.idVenta.HeaderText = "N° Venta"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'RutCli
        '
        Me.RutCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RutCli.Frozen = True
        Me.RutCli.HeaderText = "Rut Cliente"
        Me.RutCli.Name = "RutCli"
        Me.RutCli.ReadOnly = True
        Me.RutCli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RutCli.Width = 140
        '
        'RutEmp
        '
        Me.RutEmp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RutEmp.Frozen = True
        Me.RutEmp.HeaderText = "Rut Empleado"
        Me.RutEmp.Name = "RutEmp"
        Me.RutEmp.ReadOnly = True
        Me.RutEmp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RutEmp.Width = 140
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Fecha.Frozen = True
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 130
        '
        'Pagado
        '
        Me.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Pagado.FalseValue = "False"
        Me.Pagado.Frozen = True
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.IndeterminateValue = "False"
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Pagado.TrueValue = "True"
        '
        'Entregado
        '
        Me.Entregado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Entregado.FalseValue = "False"
        Me.Entregado.Frozen = True
        Me.Entregado.HeaderText = "Entregado"
        Me.Entregado.IndeterminateValue = "False"
        Me.Entregado.Name = "Entregado"
        Me.Entregado.ReadOnly = True
        Me.Entregado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Entregado.TrueValue = "True"
        '
        'btnVerVenta
        '
        Me.btnVerVenta.Location = New System.Drawing.Point(163, 496)
        Me.btnVerVenta.Name = "btnVerVenta"
        Me.btnVerVenta.Size = New System.Drawing.Size(111, 29)
        Me.btnVerVenta.TabIndex = 3
        Me.btnVerVenta.Text = "Ver Venta"
        Me.btnVerVenta.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVerVenta)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.rbRUTCliente)
        Me.Controls.Add(Me.rbRUTEmpleado)
        Me.Controls.Add(Me.rbIdVenta)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbIdVenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbRUTEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rbRUTCliente As System.Windows.Forms.RadioButton
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvVentas As System.Windows.Forms.DataGridView
    Friend WithEvents RUTCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutEmp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pagado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Entregado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnVerVenta As System.Windows.Forms.Button
End Class
