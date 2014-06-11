Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase de negocio para los Productos
''' </summary>
''' <remarks></remarks>
Public Class ProductosBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As ProductosDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New ProductosDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Productos
    ''' </summary>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerProductos() As List(Of Productos)
        Return _datos.ObtenerProductos()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Productos
    ''' </summary>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerProducto(ByVal producto As Productos) As List(Of Productos)
        Return _datos.ObtenerProducto(producto)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Productos según la categoría seleccionada
    ''' </summary>
    ''' <param name="categoria">ID de la Categoría</param>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerPorIdCategoria(ByVal categoria As Categorias) As List(Of Productos)
        Return _datos.ObtenerPorIdCategoria(categoria)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Productos según su estado
    ''' </summary>
    ''' <param name="producto">Estado del producto</param>
    ''' <returns>Lista de Productos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEstadoProductos(ByVal producto As Productos) As List(Of Productos)
        Return _datos.ObtenerEstadoProductos(producto)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso del Producto
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarProducto(ByVal producto As Productos) As Boolean
        Return _datos.GuardarProducto(producto)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para la actualización de los datos del Producto
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado de la actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarProducto(ByVal producto As Productos) As Boolean
        Return _datos.ActualizarProducto(producto)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para la eliminación del Producto
    ''' </summary>
    ''' <param name="producto">Datos del Producto</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Public Function EliminarProducto(ByVal producto As Productos) As Boolean
        Return _datos.EliminarProducto(producto)
    End Function

End Class
