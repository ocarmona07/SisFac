Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene las Regiones, las Ciudades, y los Cargos de la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class VariosDa

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
    ''' Se obtienen los cargos desde la BD
    ''' </summary>
    ''' <returns>Lista de cargos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCargos() As List(Of Cargos)
        Try
            Return _ctx.Cargos.ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen las regiones desde la BD
    ''' </summary>
    ''' <returns>Lista de regiones</returns>
    ''' <remarks></remarks>
    Public Function ObtenerRegiones() As List(Of Regiones)
        Try
            Return _ctx.Regiones.ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen las ciudades desde la BD
    ''' </summary>
    ''' <returns>Lista de ciudades</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCiudades() As List(Of Ciudades)
        Try
            Return _ctx.Ciudades.ToList()
        Catch es As Exception
            Return Nothing
        End Try
    End Function

End Class
