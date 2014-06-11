Imports SISFAC.Entidades
Imports SISFAC.Datos

''' <summary>
''' Clase de negocio para los Empleados
''' </summary>
''' <remarks></remarks>
Public Class EmpleadosBo

    ''' <summary>
    ''' Se crea contexto para la conexión a la capa de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly _datos As EmpleadosDa

    ''' <summary>
    ''' Se obtienen los métodos del contexto
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _datos = New EmpleadosDa()
    End Sub

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Empleados
    ''' </summary>
    ''' <returns>Lista de empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleados() As List(Of Empleados)
            Return _datos.ObtenerEmpleados()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener la lista de Empleados
    ''' </summary>
    ''' <returns>Lista de empleados</returns>
    ''' <remarks></remarks>
    Public Function ObtenerEmpleadosVendedores() As List(Of Empleados)
        Return _datos.ObtenerEmpleados()
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado a buscar</param>
    ''' <returns>Datos del Empleado</returns>
    ''' <remarks></remarks>
    Function ObtenerEmpleadoPorRut(ByVal empleado As Integer) As Empleados
        Return _datos.ObtenerEmpleadoPorRut(empleado)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado a buscar</param>
    ''' <returns>Datos del Empleado</returns>
    ''' <remarks></remarks>
    Function ObtenerEmpleadoPorRutList(ByVal empleado As String) As List(Of Empleados)
        Return _datos.ObtenerEmpleadoPorRutList(empleado)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado a buscar</param>
    ''' <returns>Datos del Empleado</returns>
    ''' <remarks></remarks>
    Function ObtenerEmpleadoPorNombre(ByVal empleado As String) As List(Of Empleados)
        Return _datos.ObtenerEmpleadoPorNombre(empleado)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para obtener un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado a buscar</param>
    ''' <returns>Datos del Empleado</returns>
    ''' <remarks></remarks>
    Function ObtenerEmpleadoPorApellido(ByVal empleado As String) As List(Of Empleados)
        Return _datos.ObtenerEmpleadoPorApellido(empleado)
    End Function

    Function IngresoLogin(ByVal empleado As Empleados) As Boolean
        Dim comprobar = _datos.ObtenerEmpleadoPorRut(empleado.RUT)
        If IsNothing(comprobar) Then
            Return False
        End If
        If comprobar.RUT = empleado.RUT And comprobar.Password = empleado.Password Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para guardar un nuevo Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado del ingreso</returns>
    ''' <remarks></remarks>
    Function GuardarEmpleado(ByVal empleado As Empleados) As Boolean
        Return _datos.GuardarEmpleado(empleado)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para actualizar un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado de la actualización</returns>
    ''' <remarks></remarks>
    Function ActualizarEmpleado(ByVal empleado As Empleados) As Boolean
        Return _datos.ActualizarEmpleado(empleado)
    End Function

    ''' <summary>
    ''' Se llama a la capa de datos para eliminar un Empleado
    ''' </summary>
    ''' <param name="empleado">Datos del empleado</param>
    ''' <returns>Estado de la eliminación</returns>
    ''' <remarks></remarks>
    Function EliminarEmpleado(ByVal empleado As Empleados) As Boolean
        Return _datos.EliminarEmpleado(empleado)
    End Function

End Class
