Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina las Categorias en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class CategoriasBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As CategoriasDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New CategoriasDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Categorias
    ''' </summary>
    ''' <returns>Lista de categorias</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCategorias() As List(Of Categorias)
        Return _datos.ObtenerCategorias()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para el ingreso de la categoria
    ''' </summary>
    ''' <param name="categoria">Datos del categoria</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarCategoria(ByVal categoria As Categorias) As Boolean
        Return _datos.GuardarCategoria(categoria)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para actualizar los datos de la categoria
    ''' </summary>
    ''' <param name="categoria">Datos del categoria</param>
    ''' <returns>Estado de la actualizacion</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCategoria(ByVal categoria As Categorias) As Boolean
        Return _datos.ActualizarCategoria(categoria)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para la eliminación de la categoria
    ''' </summary>
    ''' <param name="categoria">Datos del categoria</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Public Function EliminarCategoria(ByVal categoria As Categorias) As Boolean
        Return _datos.EliminarCategoria(categoria)
    End Function

End Class
