Imports SISFAC.Entidades
Imports SISFAC.Negocio

''' <summary>
''' Clase que muestra el formulario de Productos
''' </summary>
''' <remarks></remarks>
Public Class FrmProductos

#Region "Load"
    
    ''' <summary>
    ''' Al iniciar se cargan la Categorías y los Productos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmProductosLoad() Handles MyBase.Load
        CargarCategorias()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se cargan las Categorías en el ComboBox "cbxCategorias"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarCategorias()
        Dim negocio As New CategoriasBo
        cbxCategorias.DataSource = negocio.ObtenerCategorias()
        cbxCategorias.ValueMember = "idCategoria"
        cbxCategorias.DisplayMember = "Categoria"
    End Sub

    ''' <summary>
    ''' Se cargan los Productos en el ListBox "lbProductos"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CargarProductos()
        Dim negocio As New ProductosBo
        lbProductos.DataSource = negocio.ObtenerPorIdCategoria(cbxCategorias.SelectedItem)
        lbProductos.ValueMember = "idProducto"
        lbProductos.DisplayMember = "Producto"
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se cierra el formulario de Productos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnCerrarClick() Handles btnCerrar.Click
        Close()
    End Sub

    ''' <summary>
    ''' Se abre el formulario "FrmDetalleProducto" para Ingresar un Producto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Ingresar() Handles btnIngresar.Click
        FrmDetalleProductos.Text = "Ingresar Producto"
        FrmDetalleProductos.TipoAccion = 1
        FrmDetalleProductos.Show()
        FrmMain.Enabled = False
    End Sub

    ''' <summary>
    ''' Se abre el formulario "FrmDetalleProducto" para Actualizar un Producto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Actualizar() Handles btnActualizar.Click
        FrmDetalleProductos.Text = "Actualizar Producto"
        FrmDetalleProductos.TipoAccion = 2
        FrmDetalleProductos.Producto = lbProductos.SelectedValue
        FrmDetalleProductos.Show()
        FrmMain.Enabled = False
    End Sub

    ''' <summary>
    ''' Se abre el formulario "FrmDetalleProducto" para Eliminar un Producto
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Eliminar() Handles btnEliminar.Click
        Dim negocio As New ProductosBo
        Dim seleccionProducto As New Productos
        Dim eliminar = MsgBox("¿Desea eliminar el Producto seleccionado?", MsgBoxStyle.OkCancel, "Eliminar Producto")

        If eliminar = DialogResult.OK Then
            seleccionProducto.idProducto = lbProductos.SelectedValue
            If negocio.EliminarProducto(seleccionProducto) Then
                MsgBox("Producto eliminado correctamente.", MsgBoxStyle.Information, "Eliminar Producto")
            Else
                MsgBox("Error al eliminar el Producto.", MsgBoxStyle.Critical, "Eliminar Producto")
            End If
        End If

        CargarProductos()
    End Sub

    ''' <summary>
    ''' Se buscan los Productos según la Categoría seleccionada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CbxCategoriasSelectedIndexChanged() Handles cbxCategorias.SelectedIndexChanged
        CargarProductos()
    End Sub

#End Region

End Class