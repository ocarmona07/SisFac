Imports SISFAC.Negocio
Imports SISFAC.Entidades

''' <summary>
''' Clase del formulario de Detalles de la Venta
''' </summary>
''' <remarks></remarks>
Public Class FrmDetalleVentas

#Region "Atributos"

    ''' <summary>
    ''' Recibe el tipo de acción (1 = Ingresar, 2 = Ver, 3 = Pagar, 4 = Entregar)
    ''' </summary>
    ''' <remarks></remarks>
    Public TipoAccion As Integer

    ''' <summary>
    ''' Se recibe la Venta seleccionada
    ''' </summary>
    ''' <remarks></remarks>
    Public Venta As Integer

    ''' <summary>
    ''' Se almacena la lista de productos
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaProductos As List(Of Productos)

    ''' <summary>
    ''' Se almacena la lista de empleados
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaEmpleados As List(Of Empleados)

    ''' <summary>
    ''' Se almacena la lista de clientes
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaClientes As List(Of Clientes)

    ''' <summary>
    ''' Se almacena el valor total de los productos
    ''' </summary>
    ''' <remarks></remarks>
    Public ValorTotal As Integer = 0

#End Region

#Region "Load"

    ''' <summary>
    ''' Al iniciar se obtienen las regiones, ciudades y cargos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DetalleVentasLoad() Handles Me.Load
        cbxTipoDocumento.SelectedIndex = 0
        btnGuardar.Enabled = True
        CargarEmpleados()
        CargarClientes()
        CargarCategorias()
        If TipoAccion = 2 Then
            ObtenerVenta()
        ElseIf TipoAccion = 3 Or TipoAccion = 4 Then
            ObtenerVenta()
            AccionVenta()
        End If
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Método que obtiene los Empleados y los agrega al ComboBox "cbxRUTEmpleado"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEmpleados()
        Dim negocio As New EmpleadosBo
        ListaEmpleados = negocio.ObtenerEmpleadosVendedores()
        cbxRUTEmpleado.DataSource = ListaEmpleados
        cbxRUTEmpleado.ValueMember = "RUT"
        cbxRUTEmpleado.DisplayMember = "RUT"
    End Sub

    ''' <summary>
    ''' Método que obtiene los Clientes y los agrega al ComboBox "cbxRUTCliente"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarClientes()
        Dim negocio As New ClientesBo
        ListaClientes = negocio.ObtenerClientesActivos()
        cbxRUTCliente.DataSource = ListaClientes
        cbxRUTCliente.ValueMember = "RUT"
        cbxRUTCliente.DisplayMember = "RUT"
    End Sub


    ''' <summary>
    ''' Se cargan las Categorías en el ComboBox "cbxCategorias"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarCategorias()
        Dim negocio As New CategoriasBo
        cbxCategorias.DataSource = negocio.ObtenerCategorias()
        cbxCategorias.ValueMember = "idCategoria"
        cbxCategorias.DisplayMember = "Categoria"
    End Sub

    ''' <summary>
    ''' Se cargan los Productos en el ComboBox "cbxProductos"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarProductos()
        Dim negocio As New ProductosBo
        ListaProductos = negocio.ObtenerPorIdCategoria(cbxCategorias.SelectedItem)
        cbxProductos.DataSource = ListaProductos
        cbxProductos.ValueMember = "idProducto"
        cbxProductos.DisplayMember = "Producto"
    End Sub

    ''' <summary>
    ''' Se cargan los Productos en los campos "cbxCantidad", "txtValor", "txtComentario"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarDatosProductos()
        Dim cantidadCombo As Integer = ListaProductos(cbxProductos.SelectedIndex).Cantidad
        cbxCantidad.Items.Clear()
        If cantidadCombo < 20 Then
            For i = 0 To cantidadCombo
                cbxCantidad.Items.Add(i)
            Next
        ElseIf cantidadCombo >= 20 Then
            For i = 0 To 19
                cbxCantidad.Items.Add(i)
            Next
        End If
        If cantidadCombo > 0 Then
            cbxCantidad.SelectedIndex = 1
        ElseIf cantidadCombo = 0 Then
            cbxCantidad.SelectedIndex = 0
        End If
        txtValor.Text = ListaProductos(cbxProductos.SelectedIndex).Valor
        txtComentario.Text = ListaProductos(cbxProductos.SelectedIndex).Comentario
    End Sub

    ''' <summary>
    ''' Se guardan los datos del Venta
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarVenta()
        Dim negocio As New VentasBo
        Dim nuevaVenta As New Ventas

        nuevaVenta.TipoVenta = cbxTipoDocumento.SelectedIndex
        nuevaVenta.RUTEmpleado = cbxRUTEmpleado.Text
        nuevaVenta.RUTCliente = cbxRUTCliente.Text
        nuevaVenta.Fecha = dtpFecha.Value.ToShortDateString()
        nuevaVenta.Descuento = txtDescuento.Text
        nuevaVenta.Pagado = False
        nuevaVenta.Entregado = False

        If negocio.GuardarVenta(nuevaVenta) > 0 Then
            For Each agregarProducto As DataGridViewRow In dgvProductos.Rows
                Dim negocioCon As New VentasBo
                Dim nuevoDetalle As New DetallesVenta
                nuevoDetalle.idVenta = nuevaVenta.idVenta
                nuevoDetalle.idProducto = agregarProducto.Cells(0).Value
                nuevoDetalle.Cantidad = agregarProducto.Cells(2).Value
                nuevoDetalle.Valor = agregarProducto.Cells(3).Value
                negocioCon.GuardarDetalleVenta(nuevoDetalle)
            Next
            MsgBox("Venta realizada correctamente!", MsgBoxStyle.Information, "Venta")
        Else
            MsgBox("Error al validar la venta", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Se obtiene la venta para previsualizarla
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ObtenerVenta()
        Dim negocio As New VentasBo
        Dim datosVenta = negocio.ObtenerVentaPorId(Venta).FirstOrDefault()
        If datosVenta Is Nothing Then
            MsgBox("No se encontraron registros!", MsgBoxStyle.Information, "Sin registros")
            BloquearAccesos()
            TipoAccion = 0
        Else
            BloquearAccesos()
            cbxTipoDocumento.SelectedIndex = datosVenta.TipoVenta
            cbxRUTEmpleado.Text = datosVenta.RUTEmpleado
            cbxRUTCliente.Text = datosVenta.RUTCliente
            dtpFecha.Value = datosVenta.Fecha
            txtDescuento.Text = datosVenta.Descuento
            If datosVenta.Pagado Then
                lblPagado.Text = "PAGADO"
            ElseIf datosVenta.Pagado Is Nothing Then
                lblPagado.Text = "NULO"
            End If
            If datosVenta.Entregado Then
                lblEntregado.Text = "ENTREGADO"
            ElseIf datosVenta.Entregado Is Nothing Then
                lblEntregado.Text = "NULO"
            End If
            Dim negocioDetalle As New VentasBo
            Dim detalleVenta = negocioDetalle.ObtenerDetalleVentas(Venta)
            dgvProductos.Rows.Clear()
            dgvProductos.Columns(4).Visible = False
            For Each detallesVenta As DetallesVenta In detalleVenta
                dgvProductos.Rows.Add(detallesVenta.idProducto, detallesVenta.Productos.Producto, detallesVenta.Cantidad, _
                                                  detallesVenta.Valor)
                ValorTotal += detallesVenta.Valor * detallesVenta.Cantidad
            Next
            ValorTotal -= datosVenta.Descuento
            txtTotal.Text = ValorTotal
        End If
    End Sub

    Public Sub BloquearAccesos()
        btnGuardar.Enabled = False
        btnAgregar.Enabled = False
        cbxRUTCliente.Enabled = False
        cbxRUTEmpleado.Enabled = False
        cbxTipoDocumento.Enabled = False
        cbxCategorias.Enabled = False
        cbxProductos.Enabled = False
        cbxCantidad.Enabled = False
        btnDescuento.Enabled = False
    End Sub

    Public Sub AccionVenta()
        If TipoAccion = 3 Then
            If lblPagado.Text <> "NULO" Then
                Dim pagado As String = MsgBox("¿Confirma el pago de la venta?", MsgBoxStyle.OkCancel, "Confirmar Pago")
                If pagado = DialogResult.OK Then
                    Dim negocioPago As New VentasBo
                    If negocioPago.ActualizarPago(Venta) Then
                        MsgBox("Pago confirmado OK!", MsgBoxStyle.Information, "Confirmación Pago")
                    ElseIf pagado = DialogResult.Cancel Then
                        MsgBox("No se pudo confirmar el pago.", MsgBoxStyle.Exclamation, "Confirmación Pago")
                    End If
                End If
            End If
        ElseIf TipoAccion = 4 Then
            If lblPagado.Text = "PAGADO" Then
                Dim entregado As String = MsgBox("¿Confirma la entrega de la venta?", MsgBoxStyle.OkCancel, "Confirmar Entrega")
                If entregado = DialogResult.OK Then
                    Dim negocioEntrega As New VentasBo
                    If negocioEntrega.ActualizarEntrega(Venta) Then
                        MsgBox("Entrega confirmada OK!", MsgBoxStyle.Information, "Confirmación Entrega")
                    Else
                        MsgBox("No se pudo confirmar la entrega.", MsgBoxStyle.Exclamation, "Confirmación Entrega")
                    End If
                End If
            Else
                MsgBox("No existe el pago.", MsgBoxStyle.Exclamation, "Confirmación Entrega")
                BloquearAccesos()
            End If
        End If
        FrmMain.Enabled = True
        FrmVentas.dgvVentas.DataSource = Nothing
        FrmVentas.CargarVentas()
    End Sub

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
            FrmVentas.dgvVentas.DataSource = Nothing
            FrmVentas.CargarVentas()
            Close()
        End If
    End Sub

    ''' <summary>
    ''' Evento que guarda un nuevo Venta en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Guardar() Handles btnGuardar.Click
        If txtTotal.Text > 0 Then
            If TipoAccion = 1 Then
                Dim salir = MsgBox("¿Desea generar la Venta?", MsgBoxStyle.OkCancel, "Generar Venta")
                If salir = DialogResult.OK Then
                    GuardarVenta()
                    FrmMain.Enabled = True
                    FrmVentas.dgvVentas.DataSource = Nothing
                    FrmVentas.CargarVentas()
                    Close()
                End If
            End If
        Else
            MsgBox("No se han agregado productos!", MsgBoxStyle.Exclamation, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Se buscan los Productos según la Categoría seleccionada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CategoriasSelectedIndexChanged() Handles cbxCategorias.SelectedIndexChanged
        CargarProductos()
    End Sub

    ''' <summary>
    ''' Se actualiza el ComboBox de Productos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ProductosSelectedIndexChanged() Handles cbxProductos.SelectedIndexChanged
        CargarDatosProductos()
    End Sub

    Private Sub AgregarProducto() Handles btnAgregar.Click
        If cbxCantidad.SelectedIndex > 0 Then
            Dim products = cbxProductos.SelectedItem
            dgvProductos.Rows.Add(products.idProducto, products.Producto, cbxCantidad.Text, _
                                  products.Valor, products.Estado)
            ValorTotal += products.Valor * cbxCantidad.SelectedIndex
            txtTotal.Text = ValorTotal
        End If
    End Sub

    Private Sub Descuento() Handles btnDescuento.Click
        If FrmMain.mnuiAdministrador.Visible Then
            If dgvProductos.Rows.Count > 0 Then
                Dim ingresarDescuento As String
                ingresarDescuento = InputBox("Ingrese cantidad de Descuento:", "Ingresar Descuento", 0)
                If IsNumeric(ingresarDescuento) Then
                    Dim totalTemp As Integer = ValorTotal
                    If txtDescuento.Text <> 0 Then
                        ValorTotal += txtDescuento.Text
                        totalTemp = ValorTotal
                        txtDescuento.Text = ingresarDescuento.ToString()
                        ValorTotal -= ingresarDescuento
                        txtTotal.Text = ValorTotal
                    ElseIf ingresarDescuento > ValorTotal Then
                        MsgBox("El descuento ingresado es mayor al total.", MsgBoxStyle.Exclamation, "Error!")
                    Else
                        txtDescuento.Text = ingresarDescuento.ToString()
                        ValorTotal -= ingresarDescuento
                        txtTotal.Text = ValorTotal
                    End If
                    If ValorTotal < 0 Then
                        ValorTotal = totalTemp
                        txtDescuento.Text = 0
                        txtTotal.Text = ValorTotal
                    End If
                Else
                    MsgBox("Ingrese solo números!", MsgBoxStyle.Exclamation, "Error!")
                End If
            Else
                MsgBox("Primero ingrese productos!", MsgBoxStyle.Exclamation, "Error!")
            End If
        Else
            MsgBox("Consulte al administrador!", MsgBoxStyle.Information, "Descuento")
        End If
    End Sub

    Private Sub RutEmpleadoSelectedValueChanged() Handles cbxRUTEmpleado.SelectedValueChanged
        Dim apePaterno As String = ListaEmpleados(cbxRUTEmpleado.SelectedIndex).ApPaterno
        Dim apeMaterno As String = ListaEmpleados(cbxRUTEmpleado.SelectedIndex).ApMaterno
        lblApPaternoEmp.Text = apePaterno + " " + apeMaterno
    End Sub

    Private Sub RutClienteSelectedValueChanged() Handles cbxRUTCliente.SelectedValueChanged
        Dim apePaterno As String = ListaClientes(cbxRUTCliente.SelectedIndex).ApPaterno
        Dim apeMaterno As String = ListaClientes(cbxRUTCliente.SelectedIndex).ApMaterno
        lblApPaternoCli.Text = apePaterno + " " + apeMaterno
    End Sub

    Private Sub QuitarProducto(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.ColumnIndex = 4 Then
            If Not e.RowIndex = -1 Then
                ValorTotal -= dgvProductos.CurrentRow.Cells(3).Value * dgvProductos.CurrentRow.Cells(2).Value
                txtTotal.Text = ValorTotal
                dgvProductos.Rows.RemoveAt(e.RowIndex)
                If ValorTotal <= 0 Then
                    ValorTotal = 0
                    txtTotal.Text = 0
                    txtDescuento.Text = 0
                End If
            End If
        End If
    End Sub

#End Region

End Class