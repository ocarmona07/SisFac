Imports SISFAC.Entidades

''' <summary>
''' Clase que Obtiene, Crea, Actualiza y Elimina los Empleados en la Base de Datos (BD)
''' </summary>
''' <remarks></remarks>
Public Class EmpleadosDa

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
    ''' Se obtienen los empleados desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleados() As List(Of Empleados)
        Try
            Return _ctx.Empleados.ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los empleados desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadosVendedores() As List(Of Empleados)
        Try
            Return (From vend In _ctx.Empleados Where vend.idCargo = 3 Select vend).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtiene un empleado por Rut desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadoPorRut(ByVal empleado As Integer) As Empleados
        Try
            Return (From empl In _ctx.Empleados Where empl.RUT = empleado Select empl).First()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los empleados desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadoPorRutList(ByVal empleado As String) As List(Of Empleados)
        Try
            Return (From cli In _ctx.Empleados Where cli.RUT = empleado Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los empleados desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadoPorNombre(ByVal empleado As String) As List(Of Empleados)
        Try
            Return (From cli In _ctx.Empleados Where cli.Nombres = empleado Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se obtienen los empleados desde la BD
    ''' </summary>
    ''' <returns>Lista de Empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadoPorApellido(ByVal empleado As String) As List(Of Empleados)
        Try
            Return (From cli In _ctx.Empleados Where cli.ApPaterno = empleado Or cli.ApMaterno = empleado Select cli).ToList()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Se ingresa al nuevo empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Public Function GuardarEmpleado(ByVal empleado As Empleados) As Boolean
        Try
            _ctx.AddToEmpleados(empleado)
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se actualiza al empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado de actualización</returns>
    ''' <remarks></remarks>
    Public Function ActualizarEmpleado(ByVal empleado As Empleados) As Boolean
        Try
            Dim obtenerEmpleado = From empl In _ctx.Empleados Where empl.RUT = empleado.RUT Select empl
            obtenerEmpleado.First.Nombres = empleado.Nombres
            obtenerEmpleado.First.ApPaterno = empleado.ApPaterno
            obtenerEmpleado.First.ApMaterno = empleado.ApMaterno
            obtenerEmpleado.First.FechaNac = empleado.FechaNac
            obtenerEmpleado.First.Sexo = empleado.Sexo
            obtenerEmpleado.First.Email = empleado.Email
            obtenerEmpleado.First.Telefono = empleado.Telefono
            obtenerEmpleado.First.Direccion = empleado.Direccion
            obtenerEmpleado.First.idRegion = empleado.idRegion
            obtenerEmpleado.First.idCiudad = empleado.idCiudad
            obtenerEmpleado.First.idCargo = empleado.idCargo
            obtenerEmpleado.First.Password = empleado.Password
            obtenerEmpleado.First.Estado = empleado.Estado
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Se eliminar los datos del empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Function EliminarEmpleado(ByVal empleado As Empleados) As Boolean
        Try
            Dim obtenerEmpleado = From empl In _ctx.Empleados Where empl.RUT = empleado.RUT Select empl
            obtenerEmpleado.First.Estado = empleado.Estado
            _ctx.SaveChanges()
            _ctx.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
