Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina las Categorias en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class CategoriasDa

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
    ''' Se obtienen las categorias desde la BD
    ''' </summary>
    ''' <returns>Lista de categorias</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCategorias() As List(Of Categorias)
        Try
            Return _ctx.Categorias.ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se guarda la categoria en la BD
    ''' </summary>
    ''' <param name="categoria"></param>
    ''' <returns>Confirmacion de guardado</returns>
    ''' <remarks></remarks>
    Public Function GuardarCategoria(ByVal categoria As Categorias) As Boolean
        Try
            _ctx.AddToCategorias(categoria)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualiza o cambia la categoria en caso de realizar cambios
    ''' </summary>
    ''' <param name="categoria"></param>
    ''' <returns>Devuelve la nueva informacion</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCategoria(ByVal categoria As Categorias) As Boolean
        Try
            Dim obtenerCategoria = From sup In _ctx.Categorias Where sup.idCategoria = categoria.idCategoria Select sup
            obtenerCategoria.First.Categoria = categoria.Categoria
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se puede eliminar la categoria ingresada
    ''' </summary>
    ''' <param name="categoria"></param>
    ''' <returns>Se confirma la eliminacion</returns>
    ''' <remarks></remarks>
    Public Function EliminarCategoria(ByVal categoria As Categorias) As Boolean
        Try
            Dim obtenerCategoria = From cat In _ctx.Categorias Where cat.idCategoria = categoria.idCategoria Select cat
            obtenerCategoria.First.idCategoria = categoria.idCategoria
            _ctx.DeleteObject(obtenerCategoria.First)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
