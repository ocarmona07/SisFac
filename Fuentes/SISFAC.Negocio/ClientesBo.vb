Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase de negocio para los Clientes
''' </summary>
''' <remarks></remarks>
Public Class ClientesBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As ClientesDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New ClientesDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Clientes
    ''' </summary>
    ''' <returns>Lista de clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientes() As List(Of Clientes)
            Return _datos.ObtenerClientes()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Clientes
    ''' </summary>
    ''' <returns>Lista de clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientesActivos() As List(Of Clientes)
        Return _datos.ObtenerClientesActivos()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente a buscar</param>
    ''' <returns>Datos del Cliente</returns>
    ''' <remarks></remarks>
    Function ObtenerClientePorRut(ByVal cliente As Integer) As Clientes
        Return _datos.ObtenerClientePorRut(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente a buscar</param>
    ''' <returns>Datos del Cliente</returns>
    ''' <remarks></remarks>
    Function ObtenerClientePorRutList(ByVal cliente As String) As List(Of Clientes)
        Return _datos.ObtenerClientePorRutList(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente a buscar</param>
    ''' <returns>Datos del Cliente</returns>
    ''' <remarks></remarks>
    Function ObtenerClientePorNombre(ByVal cliente As String) As List(Of Clientes)
        Return _datos.ObtenerClientePorNombre(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente a buscar</param>
    ''' <returns>Datos del Cliente</returns>
    ''' <remarks></remarks>
    Function ObtenerClientePorApellido(ByVal cliente As String) As List(Of Clientes)
        Return _datos.ObtenerClientePorApellido(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para guardar un nuevo Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Function GuardarCliente(ByVal cliente As Clientes) As Boolean
        Return _datos.GuardarCliente(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para actualizar un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado de la actualización</returns>
    ''' <remarks></remarks>
    Function ActualizarCliente(ByVal cliente As Clientes) As Boolean
        Return _datos.ActualizarCliente(cliente)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para eliminar un Cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Function EliminarCliente(ByVal cliente As Clientes) As Boolean
        Return _datos.EliminarCliente(cliente)
    End Function

End Class
