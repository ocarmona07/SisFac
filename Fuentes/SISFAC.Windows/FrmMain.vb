''' <summary>
''' Clase del formulario principal (Main)
''' </summary>
''' <remarks></remarks>
Public Class FrmMain

#Region "Load"

    ''' <summary>
    ''' Carga inicial del formulario principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmMainLoad() Handles Me.Load
        tmrHora.Start()
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se finaliza el programa
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Salir() Handles mnuiSalir.Click
        End
    End Sub

    ''' <summary>
    ''' Se finaliza el programa
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Salir2() Handles mnuiSalir2.Click
        End
    End Sub

    ''' <summary>
    ''' Se finaliza el programa
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Salir3() Handles mnuiSalir3.Click
        End
    End Sub

    ''' <summary>
    ''' Se finaliza el programa
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Salir4() Handles mnuiSalir4.Click
        End
    End Sub

    ''' <summary>
    ''' Se actualiza la carga de hora y fecha en el formulario principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub TmrHoraTick() Handles tmrHora.Tick
        tsslFechaHora.Text = Date.Now
    End Sub

    ''' <summary>
    ''' Se carga el formulario Categorías
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Categorias() Handles mnuiCategorias.Click
        tsslProgreso.Text = "Cargando Categorias..."
        ssBarra.Refresh()
        FrmCategorias.MdiParent = Me
        FrmCategorias.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Productos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Productos() Handles mnuiProductos.Click
        tsslProgreso.Text = "Cargando Productos..."
        ssBarra.Refresh()
        FrmProductos.MdiParent = Me
        FrmProductos.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Empleados
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Empleados() Handles mnuiEmpleados.Click
        tsslProgreso.Text = "Cargando Empleados..."
        ssBarra.Refresh()
        FrmEmpleados.MdiParent = Me
        FrmEmpleados.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Clientes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Clientes() Handles mnuiClientes.Click
        tsslProgreso.Text = "Cargando Clientes..."
        ssBarra.Refresh()
        FrmClientes.MdiParent = Me
        FrmClientes.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Ventas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Ventas() Handles mnuiDetalleVentas.Click
        tsslProgreso.Text = "Cargando Detalle de Ventas..."
        ssBarra.Refresh()
        FrmVentas.MdiParent = Me
        FrmVentas.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Ingreso de Ventas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub IngresarVenta() Handles mnuiIngresarVenta.Click
        tsslProgreso.Text = "Cargando Ingreso de Venta..."
        ssBarra.Refresh()
        FrmDetalleVentas.Text = "Ingresar Venta"
        FrmDetalleVentas.TipoAccion = 1
        FrmDetalleVentas.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
        Enabled = False
    End Sub

    ''' <summary>
    ''' Se carga el formulario de Categorías
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BodegaCategorias() Handles mnuiBodegaCat.Click
        tsslProgreso.Text = "Cargando Categorias..."
        ssBarra.Refresh()
        FrmCategorias.MdiParent = Me
        FrmCategorias.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario Productos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BodegaProductos() Handles mnuiBodegaProd.Click
        tsslProgreso.Text = "Cargando Productos..."
        ssBarra.Refresh()
        FrmProductos.MdiParent = Me
        FrmProductos.Show()
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    ''' <summary>
    ''' Se carga el formulario de Registro de Clientes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RegistroCliente() Handles mnuiRegistroCli.Click
        tsslProgreso.Text = "Cargando Registro de Cliente..."
        ssBarra.Refresh()
        FrmDetalleCliente.Text = "Ingresar Cliente"
        FrmDetalleCliente.TipoAccion = 1
        FrmDetalleCliente.Show()
        Enabled = False
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    Private Sub ConfirmarVenta() Handles mnuiVentaConf.Click
        tsslProgreso.Text = "Cargando Confirmación de Pago..."
        ssBarra.Refresh()
        Dim ingresarVenta As String
        ingresarVenta = InputBox("Ingrese el número de venta:", "Ingresar N° Venta", Nothing).ToString()
        If IsNumeric(ingresarVenta) Then
            FrmDetalleVentas.Venta = ingresarVenta
            FrmDetalleVentas.MdiParent = Me
            FrmDetalleVentas.Text = "Confirmar Pago de Venta"
            FrmDetalleVentas.TipoAccion = 3
            FrmDetalleVentas.Show()
        Else
            MsgBox("Ingrese solo números!", MsgBoxStyle.Exclamation, "Error!")
        End If
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    Private Sub ConfirmarEntrega() Handles mnuiBodegaEntrega.Click
        tsslProgreso.Text = "Cargando Confirmación de Entrega..."
        ssBarra.Refresh()
        Dim ingresarVenta As String
        ingresarVenta = InputBox("Ingrese el número de venta:", "Ingresar N° Venta", Nothing).ToString()
        If IsNumeric(ingresarVenta) Then
            FrmDetalleVentas.Venta = ingresarVenta
            FrmDetalleVentas.MdiParent = Me
            FrmDetalleVentas.Text = "Confirmar Entrega de Venta"
            FrmDetalleVentas.TipoAccion = 4
            FrmDetalleVentas.Show()
        Else
            MsgBox("Ingrese solo números!", MsgBoxStyle.Exclamation, "Error!")
        End If
        tsslProgreso.Text = String.Empty
        ssBarra.Refresh()
    End Sub

    Private Sub AcercaDe() Handles mnuiAcercaDe.Click
        FrmAcercaDe.Show()
        Enabled = False
    End Sub

#End Region

End Class
