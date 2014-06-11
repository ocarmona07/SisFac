Imports SISFAC.Negocio
Imports SISFAC.Entidades

''' <summary>
''' Clase del formulario de Detalles del Cliente
''' </summary>
''' <remarks></remarks>
Public Class FrmDetalleCliente

#Region "Atributos"

    ''' <summary>
    ''' Recibe el tipo de acción (1 = Ingresar, 2 = Actualizar)
    ''' </summary>
    ''' <remarks></remarks>
    Public TipoAccion As Integer

    ''' <summary>
    ''' Se recibe el Cliente seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    Public Cliente As Integer

#End Region

#Region "Load"

    ''' <summary>
    ''' Al iniciar se obtienen las regiones, ciudades y cargos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmCargosLoad() Handles Me.Load
        FrmMain.tsslProgreso.Text = String.Empty
        CargarRegiones()
        cbxEmpresa.SelectedIndex = 0
        If TipoAccion = 2 Then
            ObtenerCliente()
            txtRUT.Enabled = False
            txtRUTVer.Enabled = False
            Text = "Actualizar Cliente"
            btnGuardar.Text = "Actualizar"
        End If
    End Sub

#End Region

#Region "Métodos"

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
    ''' Se guardan los datos del Cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarCliente()
        Dim negocio As New ClientesBo
        Dim nuevoCliente As New Clientes

        nuevoCliente.RUT = txtRUT.Text
        nuevoCliente.RUTVer = txtRUTVer.Text
        nuevoCliente.Empresa = cbxEmpresa.SelectedIndex
        nuevoCliente.Nombres = txtNombres.Text
        nuevoCliente.ApPaterno = txtApPaterno.Text
        nuevoCliente.ApMaterno = txtApMaterno.Text
        nuevoCliente.FechaNac = dtpFechaNac.Value.ToShortDateString()
        nuevoCliente.Sexo = rbSexoM.Checked
        nuevoCliente.Email = txtEmail.Text
        nuevoCliente.Telefono = txtTelefono.Text
        nuevoCliente.Direccion = txtDireccion.Text
        nuevoCliente.idRegion = cbxRegion.SelectedValue
        nuevoCliente.idCiudad = cbxCiudad.SelectedValue
        nuevoCliente.Estado = chkActivo.Checked

        If negocio.GuardarCliente(nuevoCliente) Then
            MsgBox("Se ha ingresado al cliente correctamente", MsgBoxStyle.Information, "Cliente ingresado")
        Else
            MsgBox("Error al ingresar el cliente", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Se obtiene el cliente para actualizar
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ObtenerCliente()
        Dim negocio As New ClientesBo
        Dim datosCliente = negocio.ObtenerClientePorRut(Cliente)

        txtRUT.Text = datosCliente.RUT
        txtRUTVer.Text = datosCliente.RUTVer
        cbxEmpresa.SelectedIndex = datosCliente.Empresa
        txtNombres.Text = datosCliente.Nombres
        txtApPaterno.Text = datosCliente.ApPaterno
        txtApMaterno.Text = datosCliente.ApMaterno
        cbxEmpresa.SelectedIndex = Convert.ToInt32(datosCliente.Empresa)
        dtpFechaNac.Value = datosCliente.FechaNac
        If datosCliente.Sexo Then
            rbSexoM.Checked = True
            rbSexoF.Checked = False
        Else
            rbSexoM.Checked = False
            rbSexoF.Checked = True
        End If
        txtEmail.Text = datosCliente.Email
        txtTelefono.Text = datosCliente.Telefono
        txtDireccion.Text = datosCliente.Direccion
        cbxRegion.SelectedValue = datosCliente.idRegion
        cbxCiudad.SelectedValue = datosCliente.idCiudad
        chkActivo.Checked = datosCliente.Estado
    End Sub

    ''' <summary>
    ''' Se actualizan los datos del Cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActualizarCliente()
        Dim negocio As New ClientesBo
        Dim datosCliente As New Clientes

        datosCliente.RUT = txtRUT.Text
        datosCliente.RUTVer = txtRUTVer.Text
        datosCliente.Empresa = cbxEmpresa.SelectedIndex
        datosCliente.Nombres = txtNombres.Text
        datosCliente.ApPaterno = txtApPaterno.Text
        datosCliente.ApMaterno = txtApMaterno.Text
        datosCliente.FechaNac = dtpFechaNac.Value.ToShortDateString()
        datosCliente.Sexo = rbSexoM.Checked
        datosCliente.Email = txtEmail.Text
        datosCliente.Telefono = txtTelefono.Text
        datosCliente.Direccion = txtDireccion.Text
        datosCliente.idRegion = cbxRegion.SelectedValue
        datosCliente.idCiudad = cbxCiudad.SelectedValue
        datosCliente.Estado = chkActivo.Checked

        If negocio.ActualizarCliente(datosCliente) Then
            MsgBox("Se ha actualizado al cliente correctamente", MsgBoxStyle.Information, "Cliente actualizado")
        Else
            MsgBox("Error al actualizar el cliente", MsgBoxStyle.Exclamation, "Error!")
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
            FrmClientes.dgvClientes.DataSource = Nothing
            FrmClientes.CargarClientes()
            Close()
        End If
    End Sub

    ''' <summary>
    ''' Evento que guarda un nuevo Cliente en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Guardar() Handles btnGuardar.Click
        If Validar() Then
            If TipoAccion = 1 Then
                Dim salir = MsgBox("¿Desea guardar el Cliente?", MsgBoxStyle.OkCancel, "Guardar Cliente")
                If salir = DialogResult.OK Then
                    GuardarCliente()
                    FrmMain.Enabled = True
                    FrmClientes.dgvClientes.DataSource = Nothing
                    FrmClientes.CargarClientes()
                    Close()
                End If
            ElseIf TipoAccion = 2 Then
                Dim salir = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.OkCancel, "Actualizar Cliente ")
                If salir = DialogResult.OK Then
                    ActualizarCliente()
                    FrmMain.Enabled = True
                    FrmClientes.dgvClientes.DataSource = Nothing
                    FrmClientes.CargarClientes()
                    Close()
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Carga las Ciudades según la región seleccionada.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RegionSelectedValueChanged() Handles cbxRegion.SelectedValueChanged
        CargarCiudadesPorRegion()
    End Sub

    ''' <summary>
    ''' Carga las Ciudades según la región seleccionada.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EmpresaSelectedValueChanged() Handles cbxEmpresa.SelectedValueChanged
        If cbxEmpresa.SelectedIndex = 0 Then
            lblNombres.Text = "Nombres"
            lblApPaterno.Text = "Apellido Paterno:"
            lblApMaterno.Text = "Apellido Materno:"
        Else
            lblNombres.Text = "Razon social:"
            lblApPaterno.Text = "Representante:"
            lblApMaterno.Text = "Giro:"
        End If
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
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsLetter(e.KeyChar)
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