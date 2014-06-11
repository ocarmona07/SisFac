Imports SISFAC.Entidades
Imports SISFAC.Negocio

Public Class FrmClientes

#Region "Atributos"

    ''' <summary>
    ''' Lista de clientes
    ''' </summary>
    ''' <remarks></remarks>
    Public ListaClientes As List(Of Clientes)

#End Region

#Region "Load"

    ''' <summary>
    ''' Se inicial al cargar el formulario FrmClientes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmClientesLoad() Handles MyBase.Load
        CargarClientes()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se cargan los Clientes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarClientes()
        Dim negocio As New ClientesBo
        ListaClientes = negocio.ObtenerClientes()
        CargarClientesGrilla(ListaClientes)
    End Sub

    ''' <summary>
    ''' Se cargan los Clientes en la grilla dgvClientes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarClientesGrilla(ByVal listadoCli As List(Of Clientes))
        Dim rutConcat As String
        dgvClientes.Rows.Clear()
        For Each listaCliente As Clientes In listadoCli
            rutConcat = listaCliente.RUT.ToString() + "-" + listaCliente.RUTVer.ToString()
            dgvClientes.Rows.Add(listaCliente.RUT, rutConcat, listaCliente.Nombres, _
                                 listaCliente.ApPaterno, listaCliente.ApMaterno, listaCliente.Estado)
        Next
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se cierra el formulario FrmClientes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cerrar() Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Ingresar() Handles btnIngresar.Click
        FrmDetalleCliente.Text = "Ingresar Cliente"
        FrmDetalleCliente.TipoAccion = 1
        FrmDetalleCliente.Show()
        FrmMain.Enabled = False
    End Sub

    Private Sub Actualizar() Handles btnActualizar.Click
        Dim Cliente As New Clientes
        Cliente.RUT = dgvClientes.CurrentRow.Index
        FrmDetalleCliente.Text = "Actualizar Cliente"
        FrmDetalleCliente.TipoAccion = 2
        FrmDetalleCliente.Cliente = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(0).Value
        FrmDetalleCliente.Show()
        FrmMain.Enabled = False
    End Sub

    Private Sub Eliminar() Handles btnEliminar.Click
        Dim negocio As New ClientesBo
        Dim seleccionCliente As New Clientes
        Dim eliminar = MsgBox("¿Desea eliminar el Cliente seleccionado?", MsgBoxStyle.OkCancel, "Eliminar Cliente")

        If eliminar = DialogResult.OK Then
            seleccionCliente.RUT = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(0).Value
            seleccionCliente.Estado = False
            If negocio.EliminarCliente(seleccionCliente) Then
                MsgBox("Cliente eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Cliente")
                CargarClientes()
            Else
                MsgBox("Error al eliminar el Cliente.", MsgBoxStyle.Critical, "Error!")
            End If
        End If
    End Sub

    Private Sub Buscar() Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtBuscar.Text.Trim()) Then
            CargarClientes()
            Return
        End If
        If rbRUT.Checked Then
            Dim negocio As New ClientesBo
            Try
                Dim rutBuscar As Integer = Convert.ToInt32(txtBuscar.Text)
            Catch ex As Exception
                MsgBox("Escriba solo números para el RUT.", MsgBoxStyle.Information, "Buscar Cliente")
                Return
            End Try
            Dim clientePorId = negocio.ObtenerClientePorRutList(txtBuscar.Text)
            If Not clientePorId.Count = 0 Then
                dgvClientes.Rows.Clear()
                CargarClientesGrilla(clientePorId)
            Else
                MsgBox("No se encontraron Clientes por el RUT.", MsgBoxStyle.Information, "Buscar Cliente")
            End If
        End If
        If rbNombre.Checked Then
            Dim negocio As New ClientesBo
            Dim clientePorCliente = negocio.ObtenerClientePorNombre(txtBuscar.Text)
            If Not clientePorCliente.Count = 0 Then
                dgvClientes.Rows.Clear()
                CargarClientesGrilla(clientePorCliente)
            Else
                MsgBox("No se encontraron Clientes por el Nombre.", MsgBoxStyle.Information, "Buscar Cliente")
            End If
        End If
        If rbApellido.Checked Then
            Dim negocio As New ClientesBo
            Dim clientePorEmpleado = negocio.ObtenerClientePorApellido(txtBuscar.Text)
            If Not clientePorEmpleado.Count = 0 Then
                dgvClientes.Rows.Clear()
                CargarClientesGrilla(clientePorEmpleado)
            Else
                MsgBox("No se encontraron Clientes por el Apellido.", MsgBoxStyle.Information, "Buscar Cliente")
            End If
        End If
    End Sub

#End Region

End Class