Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase que Obtiene las Regiones, las Ciudades y los Cargos en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class VariosBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As VariosDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New VariosDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Cargos
    ''' </summary>
    ''' <returns>Lista de Cargos</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCargos() As List(Of Cargos)
        Return _datos.ObtenerCargos()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Regiones
    ''' </summary>
    ''' <returns>Lista de Regiones</returns>
    ''' <remarks></remarks>
    Public Function ObtenerRegiones() As List(Of Regiones)
        Return _datos.ObtenerRegiones()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Regiones
    ''' </summary>
    ''' <returns>Lista de Regiones</returns>
    ''' <remarks></remarks>
    Public Function ObtenerCiudadesPorRegion(ByVal region As Regiones) As List(Of Ciudades)
        Try
            Dim listadoCiudades = _datos.ObtenerCiudades()
            Return (From ciudades In listadoCiudades Where ciudades.idRegion = region.idRegion Select ciudades).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
