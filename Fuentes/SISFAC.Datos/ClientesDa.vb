Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina los Clientes en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class ClientesDa

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
    ''' Se obtienen los clientes desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientes() As List(Of Clientes)
        Try
            Return _ctx.Clientes.ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Se obtienen los clientes activos desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientesActivos() As List(Of Clientes)
        Try
            Return (From cli In _ctx.Clientes Where cli.Estado = True Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene el cliente por Rut desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientePorRut(ByVal cliente As Integer) As Clientes
        Try
            Return (From cli In _ctx.Clientes Where cli.RUT = cliente Select cli).First()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los clientes desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientePorRutList(ByVal cliente As String) As List(Of Clientes)
        Try
            Return (From cli In _ctx.Clientes Where cli.RUT = cliente Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los clientes desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientePorNombre(ByVal cliente As String) As List(Of Clientes)
        Try
            Return (From cli In _ctx.Clientes Where cli.Nombres = cliente Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los clientes desde la BD
    ''' </summary>
    ''' <returns>Lista de Clientes</returns>
    ''' <remarks></remarks>
    Public Function ObtenerClientePorApellido(ByVal cliente As String) As List(Of Clientes)
        Try
            Return (From cli In _ctx.Clientes Where cli.ApPaterno = cliente Or cli.ApMaterno = cliente Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se ingresa al nuevo cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarCliente(ByVal cliente As Clientes) As Boolean
        Try
            _ctx.AddToClientes(cliente)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualiza al cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado de actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarCliente(ByVal cliente As Clientes) As Boolean
        Try
            Dim obtenerCliente = From cli In _ctx.Clientes Where cli.RUT = cliente.RUT Select cli
            obtenerCliente.First.Nombres = cliente.Nombres
            obtenerCliente.First.ApPaterno = cliente.ApPaterno
            obtenerCliente.First.ApMaterno = cliente.ApMaterno
            obtenerCliente.First.Empresa = cliente.Empresa
            obtenerCliente.First.FechaNac = cliente.FechaNac
            obtenerCliente.First.Sexo = cliente.Sexo
            obtenerCliente.First.Email = cliente.Email
            obtenerCliente.First.Telefono = cliente.Telefono
            obtenerCliente.First.Direccion = cliente.Direccion
            obtenerCliente.First.idRegion = cliente.idRegion
            obtenerCliente.First.idCiudad = cliente.idCiudad
            obtenerCliente.First.Estado = cliente.Estado
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se eliminar los datos del cliente
    ''' </summary>
    ''' <param name="cliente">Datos del cliente</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Function EliminarCliente(ByVal cliente As Clientes) As Boolean
        Try
            Dim obtenerCliente = From cli In _ctx.Clientes Where cli.RUT = cliente.RUT Select cli
            obtenerCliente.First.Estado = cliente.Estado
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
