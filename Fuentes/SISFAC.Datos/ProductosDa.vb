Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina los Productos en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class ProductosDa

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
    ''' Se obtienen los productos desde la BD
    ''' </summary>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerProductos() As List(Of Productos)
        Try
            Return _ctx.Productos.ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene una lista de productos según la categoría seleccionada
    ''' </summary>
    ''' <param name="categoria">ID de la Categoría</param>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerPorIdCategoria(ByVal categoria As Categorias) As List(Of Productos)
        Try
            Dim listaPorCategoria As List(Of Productos) = (From productos In _ctx.Productos Where productos.idCategoria = categoria.idCategoria And productos.Estado = True Select productos).ToList
            Return listaPorCategoria
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene una lista de productos según su estado Activo
    ''' </summary>
    ''' <returns>Lista de Productos</returns>
    ''' <param name="producto">ID del Producto</param>
    ''' <remarks></remarks>
    Public Function ObtenerEstadoProductos(ByVal producto As Productos) As List(Of Productos)
        Try
            Dim listaEstadoProductos As List(Of Productos) = (From productos In _ctx.Productos Where productos.Estado = producto.Estado Select productos).ToList()
            Return listaEstadoProductos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene un producto seleccionado
    ''' </summary>
    ''' <param name="producto">ID del Producto</param>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerProducto(ByVal producto As Productos) As List(Of Productos)
        Try
            Dim listaEstadoProductos As List(Of Productos) = (From productos In _ctx.Productos Where productos.idProducto = producto.idProducto Select productos).ToList()
            Return listaEstadoProductos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se guarda el producto en la BD
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado del Ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarProducto(ByVal producto As Productos) As Boolean
        Try
            _ctx.AddToProductos(producto)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualizan los Productos en la BD
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado de la actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarProducto(ByVal producto As Productos) As Boolean
        Try
            Dim obtenerProducto = From prod In _ctx.Productos Where prod.idProducto = producto.idProducto Select prod
            obtenerProducto.First.idCategoria = producto.idCategoria
            obtenerProducto.First.Producto = producto.Producto
            obtenerProducto.First.Cantidad = producto.Cantidad
            obtenerProducto.First.Valor = producto.Valor
            obtenerProducto.First.Comentario = producto.Comentario
            obtenerProducto.First.Estado = producto.Estado
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se elimina el Producto de la BD
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Public Function EliminarProducto(ByVal producto As Productos) As Boolean
        Try
            Dim obtenerProducto = From prod In _ctx.Productos Where prod.idProducto = producto.idProducto Select prod
            obtenerProducto.First.idProducto = producto.idProducto
            _ctx.DeleteObject(obtenerProducto.First)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
