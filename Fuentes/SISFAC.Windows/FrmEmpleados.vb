Imports SISFAC.Entidades
Imports SISFAC.Negocio

Public Class FrmEmpleados

#Region "Atributos"

    ''' <summary>
    ''' Lista de Empleados
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaEmpleados As List(Of Empleados)

#End Region

#Region "Load"

    ''' <summary>
    ''' Se inicial al cargar el formulario FrmEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmEmpleadosLoad() Handles MyBase.Load
        CargarEmpleados()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se cargan los empleados en la grilla dgvEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarEmpleados()
        Dim negocio As New EmpleadosBo
        ListaEmpleados = negocio.ObtenerEmpleados()
        CargarEmpleadosGrilla(ListaEmpleados)
    End Sub

    ''' <summary>
    ''' Se cargan los empleados en la grilla dgvEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarEmpleadosGrilla(ByVal listadoEmp As List(Of Empleados))
        Dim rutConcat As String
        dgvEmpleados.Rows.Clear()
        For Each listaEmpleado As Empleados In listadoEmp
            rutConcat = listaEmpleado.RUT.ToString() + "-" + listaEmpleado.RUTVer.ToString()
            dgvEmpleados.Rows.Add(listaEmpleado.RUT, rutConcat, listaEmpleado.Nombres, _
                                 listaEmpleado.ApPaterno, listaEmpleado.ApMaterno, listaEmpleado.Estado)
        Next
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se cierra el formulario FrmEmpleados
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cerrar() Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Ingresar() Handles btnIngresar.Click
        FrmDetalleEmpleados.Text = "Ingresar Empleado"
        FrmDetalleEmpleados.TipoAccion = 1
        FrmDetalleEmpleados.Show()
        FrmMain.Enabled = False
    End Sub

    Private Sub Actualizar() Handles btnActualizar.Click
        Dim empleado As New Empleados
        empleado.RUT = dgvEmpleados.CurrentRow.Index
        FrmDetalleEmpleados.Text = "Actualizar Empleado"
        FrmDetalleEmpleados.TipoAccion = 2
        FrmDetalleEmpleados.Empleado = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(0).Value
        FrmDetalleEmpleados.Show()
        FrmMain.Enabled = False
    End Sub


    Private Sub Eliminar() Handles btnEliminar.Click
        Dim negocio As New EmpleadosBo
        Dim seleccionEmpleado As New Empleados
        Dim eliminar = MsgBox("¿Desea eliminar el Cliente seleccionado?", MsgBoxStyle.OkCancel, "Eliminar Empleado")

        If eliminar = DialogResult.OK Then
            seleccionEmpleado.RUT = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(0).Value
            seleccionEmpleado.Estado = False
            If negocio.EliminarEmpleado(seleccionEmpleado) Then
                MsgBox("Empleado eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Empleado")
                CargarEmpleados()
            Else
                MsgBox("Error al eliminar el Empleado.", MsgBoxStyle.Critical, "Error!")
            End If
        End If
    End Sub

    Private Sub Buscar() Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtBuscar.Text.Trim()) Then
            CargarEmpleados()
            Return
        End If
        If rbRUT.Checked Then
            Dim negocio As New EmpleadosBo
            Try
                Dim rutBuscar As Integer = Convert.ToInt32(txtBuscar.Text)
            Catch ex As Exception
                MsgBox("Escriba solo números para el RUT.", MsgBoxStyle.Information, "Buscar Empleado")
                Return
            End Try
            Dim clientePorId = negocio.ObtenerEmpleadoPorRutList(txtBuscar.Text)
            If Not clientePorId.Count = 0 Then
                dgvEmpleados.Rows.Clear()
                CargarEmpleadosGrilla(clientePorId)
            Else
                MsgBox("No se encontraron Clientes por el RUT.", MsgBoxStyle.Information, "Buscar Empleado")
            End If
        End If
        If rbNombre.Checked Then
            Dim negocio As New EmpleadosBo
            Dim clientePorCliente = negocio.ObtenerEmpleadoPorNombre(txtBuscar.Text)
            If Not clientePorCliente.Count = 0 Then
                dgvEmpleados.Rows.Clear()
                CargarEmpleadosGrilla(clientePorCliente)
            Else
                MsgBox("No se encontraron Clientes por el Nombre.", MsgBoxStyle.Information, "Buscar Cliente")
            End If
        End If
        If rbApellido.Checked Then
            Dim negocio As New EmpleadosBo
            Dim clientePorEmpleado = negocio.ObtenerEmpleadoPorApellido(txtBuscar.Text)
            If Not clientePorEmpleado.Count = 0 Then
                dgvEmpleados.Rows.Clear()
                CargarEmpleadosGrilla(clientePorEmpleado)
            Else
                MsgBox("No se encontraron Clientes por el Apellido.", MsgBoxStyle.Information, "Buscar Cliente")
            End If
        End If
    End Sub

#End Region

End Class