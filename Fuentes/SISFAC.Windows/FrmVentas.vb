Imports SISFAC.Entidades
Imports SISFAC.Negocio

Public Class FrmVentas

#Region "Atributos"

    ''' <summary>
    ''' Lista de Ventas
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaVentas As List(Of Ventas)

#End Region

#Region "Load"

    ''' <summary>
    ''' Se inicial al cargar el formulario FrmVentas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmVentasLoad() Handles MyBase.Load
        CargarVentas()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se cargan los empleados en la grilla dgvEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarVentas()
        Dim negocio As New VentasBo
        ListaVentas = negocio.ObtenerVentas()
        CargarVentasGrilla(ListaVentas)
    End Sub

    ''' <summary>
    ''' Se cargan los empleados en la grilla dgvEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarVentasGrilla(ByVal listadoVent As List(Of Ventas))
        Dim rutCliConcat As String
        Dim rutEmpConcat As String
        dgvVentas.Rows.Clear()
        For Each listaVenta As Ventas In listadoVent
            rutCliConcat = listaVenta.RUTCliente.ToString() + "-" + listaVenta.Clientes.RUTVer.ToString()
            rutEmpConcat = listaVenta.RUTEmpleado.ToString() + "-" + listaVenta.Empleados.RUTVer.ToString()
            dgvVentas.Rows.Add(listaVenta.RUTCliente, listaVenta.RUTEmpleado, listaVenta.idVenta, rutCliConcat, rutEmpConcat, _
                                 listaVenta.Fecha.ToShortDateString(), listaVenta.Pagado, listaVenta.Entregado)
        Next
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se cierra el formulario FrmVentas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cerrar() Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Ingresar() Handles btnIngresar.Click
        FrmDetalleVentas.Text = "Ingresar Venta"
        FrmDetalleVentas.TipoAccion = 1
        FrmDetalleVentas.Show()
        FrmMain.Enabled = False
    End Sub

    Private Sub Ver() Handles btnVerVenta.Click
        If Not IsNothing(dgvVentas.CurrentRow) Then
            FrmDetalleVentas.Text = "Ver Venta"
            FrmDetalleVentas.TipoAccion = 2
            FrmDetalleVentas.Venta = dgvVentas.Rows(dgvVentas.CurrentRow.Index).Cells(2).Value
            FrmDetalleVentas.Show()
            FrmDetalleVentas.btnGuardar.Enabled = False
            FrmMain.Enabled = False
        Else
            MsgBox("No hay venta seleccionada", MsgBoxStyle.Critical, "Ventas")
        End If
    End Sub

    Private Sub Eliminar() Handles btnEliminar.Click
        Dim negocio As New VentasBo
        Dim seleccionVenta As New Ventas
        Dim eliminar = MsgBox("¿Desea eliminar la Venta seleccionada?", MsgBoxStyle.OkCancel, "Eliminar Venta")
        If IsNothing(dgvVentas.CurrentRow) Then
            MsgBox("Error al eliminar la Venta.", MsgBoxStyle.Critical, "Error!")
            Return
        End If
        If eliminar = DialogResult.OK Then
            seleccionVenta.idVenta = dgvVentas.Rows(dgvVentas.CurrentRow.Index).Cells(2).Value
            If negocio.EliminarVenta(seleccionVenta) Then
                MsgBox("Venta eliminada correctamente.", MsgBoxStyle.Information, "Eliminar Venta")
                CargarVentas()
            Else
                MsgBox("Error al eliminar la Venta.", MsgBoxStyle.Critical, "Error!")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Se busca una venta específica
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Buscar() Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtBuscar.Text.Trim()) Or Not IsNumeric(txtBuscar.Text) Then
            CargarVentas()
            Return
        End If
        If rbIdVenta.Checked Then
            Dim negocio As New VentasBo
            Dim ventaPorId = negocio.ObtenerVentaPorId(txtBuscar.Text)
            If Not IsNothing(ventaPorId) Then
                CargarVentasGrilla(ventaPorId.ToList())
            Else
                MsgBox("No se encontraron ventas por ID.", MsgBoxStyle.Information, "Buscar Ventas")
            End If
        End If
        If rbRUTCliente.Checked Then
            Dim negocio As New VentasBo
            Dim ventaPorCliente = negocio.ObtenerVentaPorRutCliente(txtBuscar.Text)
            If Not IsNothing(ventaPorCliente) Then
                CargarVentasGrilla(ventaPorCliente.ToList())
            Else
                MsgBox("No se encontraron ventas por el RUT del Cliente.", MsgBoxStyle.Information, "Buscar Ventas")
            End If
        End If
        If rbRUTEmpleado.Checked Then
            Dim negocio As New VentasBo
            Dim ventaPorEmpleado = negocio.ObtenerVentaPorRutEmpleado(txtBuscar.Text)
            If Not IsNothing(ventaPorEmpleado) Then
                CargarVentasGrilla(ventaPorEmpleado.ToList())
            Else
                MsgBox("No se encontraron ventas por el RUT del Empleado.", MsgBoxStyle.Information, "Buscar Ventas")
            End If
        End If
    End Sub

#End Region

End Class