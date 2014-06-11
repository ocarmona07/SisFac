Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina las Ventas en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class VentasDa

    ''' <summary>
    ''' Se crea contexto para la BD
    ''' </summary>
    ''' <remarks>_ctx = SisFacEntities</remarks>
    Private ReadOnly _ctx As SisFacEntities

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks>_ctx.*()</remarks>
    Public Sub New()
        _ctx = New SisFacEntities
    End Sub

    ''' <summary>
    ''' Se obtienen las ventas desde la BD
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentas() As List(Of Ventas)
        Try
            Return (From vent In _ctx.Ventas Where vent.Pagado <> vbNull And vent.Entregado <> vbNull Select vent).ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene una venta específica desde la BD
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorId(ByVal venta As Integer) As List(Of Ventas)
        Try
            Return (From vent In _ctx.Ventas Where vent.idVenta = venta Select vent).ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene una venta específica desde la BD
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorRutCliente(ByVal cliente As Integer) As List(Of Ventas)
        Try
            Return (From vent In _ctx.Ventas Where vent.RUTCliente = cliente Select vent).ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Se obtiene una venta específica desde la BD
    ''' </summary>
    ''' <returns>Lista de ventas</returns>
    ''' <remarks></remarks>
    Public Function ObtenerVentaPorRutEmpleado(ByVal empleado As Integer) As List(Of Ventas)
        Try
            Return (From vent In _ctx.Ventas Where vent.RUTEmpleado = empleado Select vent).ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene el detalle de las ventas
    ''' </summary>
    ''' <param name="venta">id de Venta</param>
    ''' <returns>Lista Detalle de Venta</returns>
    ''' <remarks></remarks>
    Public Function ObtenerDetalleVentas(ByVal venta As Integer) As List(Of DetallesVenta)
        Try
            Return (From det In _ctx.DetallesVenta Where det.idVenta = venta Select det).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se guarda la venta en la BD
    ''' </summary>
    ''' <param name="venta">Datos de la venta</param>
    ''' <returns>Id de venta</returns>
    ''' <remarks></remarks>
    Public Function GuardarVenta(ByVal venta As Ventas) As Integer
        Try
            _ctx.AddToVentas(venta)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return venta.idVenta
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Se guarda el detalle de la venta en la BD
    ''' </summary>
    ''' <param name="detalleVenta">Detalle de la venta</param>
    ''' <returns>Confirmacion de guardado</returns>
    ''' <remarks></remarks>
    Public Function GuardarDetalleVenta(ByVal detalleVenta As DetallesVenta)
        Try
            _ctx.AddToDetallesVenta(detalleVenta)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualiza el artículo como pagado
    ''' </summary>
    ''' <param name="venta">Id de la Venta</param>
    ''' <returns>Confirmación de actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarPago(ByVal venta As Integer) As Boolean
        Try
            Dim obtenerVenta = (From vent In _ctx.Ventas Where vent.idVenta = venta Select vent).First()
            obtenerVenta.Pagado = True
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualiza el artículo como pagado
    ''' </summary>
    ''' <param name="venta">Id de la Venta</param>
    ''' <returns>Confirmación de actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarEntrega(ByVal venta As Integer) As Boolean
        Try
            Dim obtenerVenta = (From vent In _ctx.Ventas Where vent.idVenta = venta Select vent).First()
            obtenerVenta.Entregado = True
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se puede eliminar la venta ingresada
    ''' </summary>
    ''' <param name="venta">Datos de la venta</param>
    ''' <returns>Se confirma la eliminacion</returns>
    ''' <remarks></remarks>
    Public Function EliminarVenta(ByVal venta As Ventas) As Boolean
        Try
            Dim obtenerVenta = (From vent In _ctx.Ventas Where vent.idVenta = venta.idVenta Select vent).First()
            obtenerVenta.Pagado = Nothing
            obtenerVenta.Entregado = Nothing
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
