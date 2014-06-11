<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Me.rbRUT = New System.Windows.Forms.RadioButton()
        Me.rbApellido = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Estato = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ApMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullRut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(107, 30)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(156, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'rbRUT
        '
        Me.rbRUT.AutoSize = True
        Me.rbRUT.Checked = True
        Me.rbRUT.Location = New System.Drawing.Point(473, 53)
        Me.rbRUT.Name = "rbRUT"
        Me.rbRUT.Size = New System.Drawing.Size(67, 17)
        Me.rbRUT.TabIndex = 2
        Me.rbRUT.TabStop = True
        Me.rbRUT.Text = "Por RUT"
        Me.rbRUT.UseVisualStyleBackColor = True
        '
        'rbApellido
        '
        Me.rbApellido.AutoSize = True
        Me.rbApellido.Location = New System.Drawing.Point(386, 53)
        Me.rbApellido.Name = "rbApellido"
        Me.rbApellido.Size = New System.Drawing.Size(81, 17)
        Me.rbApellido.TabIndex = 2
        Me.rbApellido.Text = "Por Apellido"
        Me.rbApellido.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(546, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(111, 43)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(299, 53)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(81, 17)
        Me.rbNombre.TabIndex = 2
        Me.rbNombre.Text = "Por Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
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
        Me.btnIngresar.Text = "Ingresar Empleado"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(156, 496)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(111, 29)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar Empleado"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(299, 496)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(111, 29)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar Empleado"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Estato
        '
        Me.Estato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Estato.FalseValue = "False"
        Me.Estato.HeaderText = "Estado"
        Me.Estato.IndeterminateValue = "False"
        Me.Estato.Name = "Estato"
        Me.Estato.ReadOnly = True
        Me.Estato.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Estato.TrueValue = "True"
        Me.Estato.Width = 90
        '
        'ApMaterno
        '
        Me.ApMaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ApMaterno.HeaderText = "Apellido Materno"
        Me.ApMaterno.Name = "ApMaterno"
        Me.ApMaterno.ReadOnly = True
        Me.ApMaterno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApMaterno.Width = 160
        '
        'ApPaterno
        '
        Me.ApPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ApPaterno.HeaderText = "Apellido Paterno"
        Me.ApPaterno.Name = "ApPaterno"
        Me.ApPaterno.ReadOnly = True
        Me.ApPaterno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApPaterno.Width = 160
        '
        'Nombres
        '
        Me.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        Me.Nombres.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Nombres.Width = 190
        '
        'FullRut
        '
        Me.FullRut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FullRut.Frozen = True
        Me.FullRut.HeaderText = "Rut"
        Me.FullRut.Name = "FullRut"
        Me.FullRut.ReadOnly = True
        Me.FullRut.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FullRut.Width = 130
        '
        'RUT
        '
        Me.RUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RUT.Frozen = True
        Me.RUT.HeaderText = "Rut Oculto"
        Me.RUT.Name = "RUT"
        Me.RUT.ReadOnly = True
        Me.RUT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RUT.Visible = False
        Me.RUT.Width = 83
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToResizeColumns = False
        Me.dgvEmpleados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RUT, Me.FullRut, Me.Nombres, Me.ApPaterno, Me.ApMaterno, Me.Estato})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = "0"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 76)
        Me.dgvEmpleados.MultiSelect = False
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.ShowEditingIcon = False
        Me.dgvEmpleados.Size = New System.Drawing.Size(765, 390)
        Me.dgvEmpleados.TabIndex = 5
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbApellido)
        Me.Controls.Add(Me.rbRUT)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbRUT As System.Windows.Forms.RadioButton
    Friend WithEvents rbApellido As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Estato As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ApMaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApPaterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullRut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
End Class
