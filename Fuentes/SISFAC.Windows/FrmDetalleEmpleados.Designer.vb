<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleEmpleados
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbxCargo = New System.Windows.Forms.ComboBox()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.txtRUT = New System.Windows.Forms.TextBox()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.txtRUTVer = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.lblApPaterno = New System.Windows.Forms.Label()
        Me.lblApMaterno = New System.Windows.Forms.Label()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.rbSexoM = New System.Windows.Forms.RadioButton()
        Me.rbSexoF = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cbxRegion = New System.Windows.Forms.ComboBox()
        Me.cbxCiudad = New System.Windows.Forms.ComboBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(206, 406)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(135, 35)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 406)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 35)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cbxCargo
        '
        Me.cbxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCargo.FormattingEnabled = True
        Me.cbxCargo.Location = New System.Drawing.Point(114, 282)
        Me.cbxCargo.Name = "cbxCargo"
        Me.cbxCargo.Size = New System.Drawing.Size(227, 21)
        Me.cbxCargo.TabIndex = 12
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Location = New System.Drawing.Point(12, 22)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(33, 13)
        Me.lblRUT.TabIndex = 9
        Me.lblRUT.Text = "RUT:"
        '
        'txtRUT
        '
        Me.txtRUT.Location = New System.Drawing.Point(114, 19)
        Me.txtRUT.MaxLength = 8
        Me.txtRUT.Name = "txtRUT"
        Me.txtRUT.Size = New System.Drawing.Size(108, 20)
        Me.txtRUT.TabIndex = 0
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Location = New System.Drawing.Point(228, 22)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion.TabIndex = 11
        Me.lblGuion.Text = "-"
        '
        'txtRUTVer
        '
        Me.txtRUTVer.Location = New System.Drawing.Point(244, 19)
        Me.txtRUTVer.MaxLength = 1
        Me.txtRUTVer.Name = "txtRUTVer"
        Me.txtRUTVer.Size = New System.Drawing.Size(22, 20)
        Me.txtRUTVer.TabIndex = 1
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(114, 45)
        Me.txtNombres.MaxLength = 20
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(227, 20)
        Me.txtNombres.TabIndex = 2
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(12, 48)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(52, 13)
        Me.lblNombres.TabIndex = 9
        Me.lblNombres.Text = "Nombres:"
        '
        'txtApPaterno
        '
        Me.txtApPaterno.Location = New System.Drawing.Point(114, 71)
        Me.txtApPaterno.MaxLength = 15
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(227, 20)
        Me.txtApPaterno.TabIndex = 3
        '
        'lblApPaterno
        '
        Me.lblApPaterno.AutoSize = True
        Me.lblApPaterno.Location = New System.Drawing.Point(12, 74)
        Me.lblApPaterno.Name = "lblApPaterno"
        Me.lblApPaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblApPaterno.TabIndex = 9
        Me.lblApPaterno.Text = "Apellido Paterno:"
        '
        'lblApMaterno
        '
        Me.lblApMaterno.AutoSize = True
        Me.lblApMaterno.Location = New System.Drawing.Point(12, 100)
        Me.lblApMaterno.Name = "lblApMaterno"
        Me.lblApMaterno.Size = New System.Drawing.Size(89, 13)
        Me.lblApMaterno.TabIndex = 9
        Me.lblApMaterno.Text = "Apellido Materno:"
        '
        'txtApMaterno
        '
        Me.txtApMaterno.Location = New System.Drawing.Point(114, 97)
        Me.txtApMaterno.MaxLength = 15
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(227, 20)
        Me.txtApMaterno.TabIndex = 4
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(12, 127)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(96, 13)
        Me.lblFechaNac.TabIndex = 9
        Me.lblFechaNac.Text = "Fecha Nacimiento:"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(114, 123)
        Me.dtpFechaNac.MaxDate = New Date(2012, 12, 25, 0, 0, 0, 0)
        Me.dtpFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaNac.TabIndex = 5
        Me.dtpFechaNac.Value = New Date(2012, 12, 25, 0, 0, 0, 0)
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(230, 127)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 9
        Me.lblSexo.Text = "Sexo:"
        '
        'rbSexoM
        '
        Me.rbSexoM.AutoSize = True
        Me.rbSexoM.Checked = True
        Me.rbSexoM.Location = New System.Drawing.Point(270, 125)
        Me.rbSexoM.Name = "rbSexoM"
        Me.rbSexoM.Size = New System.Drawing.Size(34, 17)
        Me.rbSexoM.TabIndex = 6
        Me.rbSexoM.TabStop = True
        Me.rbSexoM.Text = "M"
        Me.rbSexoM.UseVisualStyleBackColor = True
        '
        'rbSexoF
        '
        Me.rbSexoF.AutoSize = True
        Me.rbSexoF.Location = New System.Drawing.Point(310, 125)
        Me.rbSexoF.Name = "rbSexoF"
        Me.rbSexoF.Size = New System.Drawing.Size(31, 17)
        Me.rbSexoF.TabIndex = 6
        Me.rbSexoF.Text = "F"
        Me.rbSexoF.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 150)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 153)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(114, 176)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(227, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 179)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(12, 205)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(114, 202)
        Me.txtDireccion.MaxLength = 30
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(227, 20)
        Me.txtDireccion.TabIndex = 9
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(12, 231)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(44, 13)
        Me.lblRegion.TabIndex = 9
        Me.lblRegion.Text = "Región:"
        '
        'cbxRegion
        '
        Me.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegion.FormattingEnabled = True
        Me.cbxRegion.Location = New System.Drawing.Point(114, 228)
        Me.cbxRegion.Name = "cbxRegion"
        Me.cbxRegion.Size = New System.Drawing.Size(227, 21)
        Me.cbxRegion.TabIndex = 10
        '
        'cbxCiudad
        '
        Me.cbxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCiudad.FormattingEnabled = True
        Me.cbxCiudad.Location = New System.Drawing.Point(114, 255)
        Me.cbxCiudad.Name = "cbxCiudad"
        Me.cbxCiudad.Size = New System.Drawing.Size(227, 21)
        Me.cbxCiudad.TabIndex = 11
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(12, 258)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(43, 13)
        Me.lblCiudad.TabIndex = 9
        Me.lblCiudad.Text = "Ciudad:"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(12, 285)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 9
        Me.lblCargo.Text = "Cargo:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(114, 312)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(227, 20)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 312)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 13)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Contraseña:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(12, 340)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 9
        Me.lblEstado.Text = "Estado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(114, 339)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'FrmDetalleEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.rbSexoF)
        Me.Controls.Add(Me.rbSexoM)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.lblGuion)
        Me.Controls.Add(Me.txtRUTVer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtApMaterno)
        Me.Controls.Add(Me.txtApPaterno)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtRUT)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblApMaterno)
        Me.Controls.Add(Me.lblApPaterno)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblRUT)
        Me.Controls.Add(Me.cbxCiudad)
        Me.Controls.Add(Me.cbxRegion)
        Me.Controls.Add(Me.cbxCargo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDetalleEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cbxCargo As System.Windows.Forms.ComboBox
    Friend WithEvents lblRUT As System.Windows.Forms.Label
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtRUTVer As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents txtApPaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblApPaterno As System.Windows.Forms.Label
    Friend WithEvents lblApMaterno As System.Windows.Forms.Label
    Friend WithEvents txtApMaterno As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents rbSexoM As System.Windows.Forms.RadioButton
    Friend WithEvents rbSexoF As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents cbxRegion As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents lblCiudad As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
End Class
