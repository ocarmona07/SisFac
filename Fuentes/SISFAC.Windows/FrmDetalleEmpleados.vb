Imports SISFAC.Negocio
Imports SISFAC.Entidades

''' <summary>
''' Clase del formulario de Detalles del Empleado
''' </summary>
''' <remarks></remarks>
Public Class FrmDetalleEmpleados

#Region "Atributos"

    ''' <summary>
    ''' Recibe el tipo de acción (1 = Ingresar, 2 = Actualizar)
    ''' </summary>
    ''' <remarks></remarks>
    Public TipoAccion As Integer

    ''' <summary>
    ''' Se recibe el Empleado seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    Public Empleado As Integer

#End Region

#Region "Load"

    ''' <summary>
    ''' Al iniciar se obtienen las regiones, ciudades y cargos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmCargosLoad() Handles Me.Load
        FrmMain.tsslProgreso.Text = String.Empty
        CargarRegiones()
        CargarCargos()
        If TipoAccion = 2 Then
            ObtenerEmpleado()
            txtRUT.Enabled = False
            txtRUTVer.Enabled = False
            Text = "Actualizar Empleado"
            btnGuardar.Text = "Actualizar"
        End If
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Método que obtiene los Cargos y los agrega al ListBox "lbCargos"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCargos()
        Dim negocio As New VariosBo
        cbxCargo.DataSource = negocio.ObtenerCargos()
        cbxCargo.ValueMember = "idCargo"
        cbxCargo.DisplayMember = "Cargo"
    End Sub

    ''' <summary>
    ''' Método que obtiene los Cargos y los agrega al ListBox "lbCargos"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarRegiones()
        Dim negocio As New VariosBo
        cbxRegion.DataSource = negocio.ObtenerRegiones()
        cbxRegion.ValueMember = "idRegion"
        cbxRegion.DisplayMember = "Region"
        cbxRegion.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Método que obtiene las Ciudades, según la Región seleccionada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCiudadesPorRegion()
        Dim negocio As New VariosBo
        Dim regiones As New Regiones
        regiones.idRegion = cbxRegion.SelectedIndex + 1
        cbxCiudad.DataSource = negocio.ObtenerCiudadesPorRegion(regiones)
        cbxCiudad.ValueMember = "idCiudad"
        cbxCiudad.DisplayMember = "Ciudad"
    End Sub

    ''' <summary>
    ''' Se guardan los datos del Empleado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarEmpleado()
        Dim negocio As New EmpleadosBo
        Dim nuevoEmpleado As New Empleados

        nuevoEmpleado.RUT = txtRUT.Text
        nuevoEmpleado.RUTVer = txtRUTVer.Text
        nuevoEmpleado.Nombres = txtNombres.Text
        nuevoEmpleado.ApPaterno = txtApPaterno.Text
        nuevoEmpleado.ApMaterno = txtApMaterno.Text
        nuevoEmpleado.FechaNac = dtpFechaNac.Value.ToShortDateString()
        nuevoEmpleado.Sexo = rbSexoM.Checked
        nuevoEmpleado.Email = txtEmail.Text
        nuevoEmpleado.Telefono = txtTelefono.Text
        nuevoEmpleado.Direccion = txtDireccion.Text
        nuevoEmpleado.idRegion = cbxRegion.SelectedValue
        nuevoEmpleado.idCiudad = cbxCiudad.SelectedValue
        nuevoEmpleado.idCargo = cbxCargo.SelectedValue
        nuevoEmpleado.Password = txtPassword.Text
        nuevoEmpleado.Estado = chkActivo.Checked

        If negocio.GuardarEmpleado(nuevoEmpleado) Then
            MsgBox("Se ha ingresado al empleado correctamente", MsgBoxStyle.Information, "Empleado ingresado")
        Else
            MsgBox("Error al ingresar el empleado", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Se obtiene el empleado para actualizar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ObtenerEmpleado()
        Dim negocio As New EmpleadosBo
        Dim datosEmpleado = negocio.ObtenerEmpleadoPorRut(Empleado)

        txtRUT.Text = datosEmpleado.RUT
        txtNombres.Text = datosEmpleado.Nombres
        txtApPaterno.Text = datosEmpleado.ApPaterno
        txtApMaterno.Text = datosEmpleado.ApMaterno
        dtpFechaNac.Value = datosEmpleado.FechaNac
        If datosEmpleado.Sexo Then
            rbSexoM.Checked = True
            rbSexoF.Checked = False
        Else
            rbSexoM.Checked = False
            rbSexoF.Checked = True
        End If
        txtEmail.Text = datosEmpleado.Email
        txtTelefono.Text = datosEmpleado.Telefono
        txtDireccion.Text = datosEmpleado.Direccion
        cbxRegion.SelectedValue = datosEmpleado.idRegion
        cbxCiudad.SelectedValue = datosEmpleado.idCiudad
        cbxCargo.SelectedValue = datosEmpleado.idCargo
        txtPassword.Text = datosEmpleado.Password
        chkActivo.Checked = datosEmpleado.Estado
    End Sub

    ''' <summary>
    ''' Se actualizan los datos del Empleado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActualizarEmpleado()
        Dim negocio As New EmpleadosBo
        Dim datosEmpleado As New Empleados

        datosEmpleado.RUT = txtRUT.Text
        datosEmpleado.RUTVer = txtRUTVer.Text
        datosEmpleado.Nombres = txtNombres.Text
        datosEmpleado.ApPaterno = txtApPaterno.Text
        datosEmpleado.ApMaterno = txtApMaterno.Text
        datosEmpleado.FechaNac = dtpFechaNac.Value.ToShortDateString()
        datosEmpleado.Sexo = rbSexoM.Checked
        datosEmpleado.Email = txtEmail.Text
        datosEmpleado.Telefono = txtTelefono.Text
        datosEmpleado.Direccion = txtDireccion.Text
        datosEmpleado.idRegion = cbxRegion.SelectedValue
        datosEmpleado.idCiudad = cbxCiudad.SelectedValue
        datosEmpleado.idCargo = cbxCargo.SelectedValue
        datosEmpleado.Password = txtPassword.Text
        datosEmpleado.Estado = chkActivo.Checked

        If negocio.ActualizarEmpleado(datosEmpleado) Then
            MsgBox("Se ha actualizado al empleado correctamente", MsgBoxStyle.Information, "Empleado actualizado")
        Else
            MsgBox("Error al actualizar el empleado", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Valida si todos los campos estan escritos correctamente
    ''' </summary>
    ''' <remarks></remarks>
    Public Function Validar() As Boolean
        If txtRUT.Text.Length < 6 And txtRUTVer.Text.Length < 6 Then
            MsgBox("RUT incorrecto o faltan datos", MsgBoxStyle.Exclamation, "Error en RUT")
            Return False
        End If
        If String.IsNullOrEmpty(txtNombres.Text.Trim()) Then
            MsgBox("Falta completar Nombres", MsgBoxStyle.Exclamation, "Error en Nombres")
            Return False
        End If
        If String.IsNullOrEmpty(txtApPaterno.Text.Trim()) Then
            MsgBox("Falta completar Apellido Paterno", MsgBoxStyle.Exclamation, "Error en Apellido Paterno")
            Return False
        End If
        If String.IsNullOrEmpty(txtApMaterno.Text.Trim()) Then
            MsgBox("Falta completar Apellido Materno", MsgBoxStyle.Exclamation, "Error en Apellido Materno")
            Return False
        End If
        If String.IsNullOrEmpty(txtPassword.Text.Trim()) Or txtPassword.Text.Length < 4 Then
            MsgBox("Falta completar contraseña", MsgBoxStyle.Exclamation, "Error en Contraseña")
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que cierra el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnCerrarClick() Handles btnCerrar.Click
        Dim salir = MsgBox("¿Desea cerrar la ventana?", MsgBoxStyle.OkCancel, "Cerrar " + Text)
        If salir = DialogResult.OK Then
            FrmMain.Enabled = True
            FrmEmpleados.dgvEmpleados.DataSource = Nothing
            FrmEmpleados.CargarEmpleados()
            Close()
        End If
    End Sub

    ''' <summary>
    ''' Evento que guarda un nuevo Empleado en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Guardar() Handles btnGuardar.Click
        If Validar() Then
            If TipoAccion = 1 Then
                Dim salir = MsgBox("¿Desea guardar el Empleado?", MsgBoxStyle.OkCancel, "Guardar Empleado")
                If salir = DialogResult.OK Then
                    GuardarEmpleado()
                    FrmMain.Enabled = True
                    FrmEmpleados.dgvEmpleados.DataSource = Nothing
                    FrmEmpleados.CargarEmpleados()
                    Close()
                End If
            ElseIf TipoAccion = 2 Then
                Dim salir = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.OkCancel, "Actualizar Empleado ")
                If salir = DialogResult.OK Then
                    ActualizarEmpleado()
                    FrmMain.Enabled = True
                    FrmEmpleados.dgvEmpleados.DataSource = Nothing
                    FrmEmpleados.CargarEmpleados()
                    Close()
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Carga las Ciudades según la región seleccionada.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RegionSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRegion.SelectedValueChanged
        CargarCiudadesPorRegion()
    End Sub

    ''' <summary>
    ''' Evento que sólo permite ingresar números en el RUT
    ''' </summary>
    ''' <param name="sender">N/A</param>
    ''' <param name="e">Tecla presionada</param>
    ''' <remarks></remarks>
    Private Sub RUTKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUT.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    ''' <summary>
    ''' Evento que sólo permite ingresar un número o la letra K para el dígito verificador del RUT
    ''' </summary>
    ''' <param name="sender">N/A</param>
    ''' <param name="e">Tecla presionada</param>
    ''' <remarks></remarks>
    Private Sub RUTVerKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUTVer.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    ''' <summary>
    ''' Evento que sólo permite ingresar números
    ''' </summary>
    ''' <param name="sender">N/A</param>
    ''' <param name="e">Tecla presionada</param>
    ''' <remarks></remarks>
    Private Sub TelefonoKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

#End Region

End Class