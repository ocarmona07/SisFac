Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina las Ventas en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class VentasBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As VentasDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New VentasDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Ventas
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentas() As List(Of Ventas)
        Return _datos.ObtenerVentas()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Ventas por ID
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorId(ByVal venta As Integer) As List(Of Ventas)
        Return _datos.ObtenerVentaPorId(venta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Ventas por RUT Cliente
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorRutCliente(ByVal cliente As Integer) As List(Of Ventas)
        Return _datos.ObtenerVentaPorRutCliente(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Ventas por RUT Empleado
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorRutEmpleado(ByVal empleado As Integer) As List(Of Ventas)
        Return _datos.ObtenerVentaPorRutEmpleado(empleado)
    End Function

    Public Function ObtenerDetalleVentas(ByVal venta As Integer) As List(Of DetallesVenta)
        Return _datos.ObtenerDetalleVentas(venta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso de la venta
    ''' </summary>
    ''' <param name="venta">Datos de la venta</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarVenta(ByVal venta As Ventas) As Integer
        Return _datos.GuardarVenta(venta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso del detalle de la venta
    ''' </summary>
    ''' <param name="detalleVenta">Datos de la venta</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarDetalleVenta(ByVal detalleVenta As DetallesVenta)
        Return _datos.GuardarDetalleVenta(detalleVenta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso del Pago de la venta
    ''' </summary>
    ''' <param name="venta">ID de la venta</param>
    ''' <returns>Confirmación</returns>
    ''' <remarks></remarks>
    Public Function ActualizarPago(ByVal venta As Integer) As Boolean
        Return _datos.ActualizarPago(venta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso de la Entrega de la venta
    ''' </summary>
    ''' <param name="venta">ID de la venta</param>
    ''' <returns>Confirmación</returns>
    ''' <remarks></remarks>
    Public Function ActualizarEntrega(ByVal venta As Integer) As Boolean
        Return _datos.ActualizarEntrega(venta)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para la eliminación de la venta
    ''' </summary>
    ''' <param name="venta">Datos de la venta</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Public Function EliminarVenta(ByVal venta As Ventas) As Boolean
        Return _datos.EliminarVenta(venta)
    End Function

End Class
