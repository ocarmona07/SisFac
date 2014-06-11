Imports SISFAC.Entidades
Imports SISFAC.Negocio

''' <summary>
''' Formulario que muestra los Detalles del Producto
''' </summary>
''' <remarks></remarks>
Public Class FrmDetalleProductos

#Region "Atributos"

    ''' <summary>
    ''' Recibe el tipo de acción (1 = Ingresar, 2 = Actualizar)
    ''' </summary>
    ''' <remarks></remarks>
    Public TipoAccion As Integer

    ''' <summary>
    ''' Se recibe el producto seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    Public Producto As Integer

#End Region

#Region "Load"

    ''' <summary>
    ''' Carga inicial del formulario Detalle Indicador
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmDetalleProductosLoad() Handles Me.Load
        CargarCategorias()
        CargarCantidad()
        If TipoAccion = 2 Then
            ObtenerProducto()
            btnGuardar.Text = "Actualizar"
            btnGuardarCerrar.Text = "Actualizar y Cerrar"
        End If
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Método que carga las Categorías en el ListBox "lbCategorias"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCategorias()
        Dim negocio As New CategoriasBo
        cbxCategorias.DataSource = negocio.ObtenerCategorias()
        cbxCategorias.ValueMember = "idCategoria"
        cbxCategorias.DisplayMember = "Categoria"
    End Sub

    ''' <summary>
    ''' Se llena el ComboBox "cbxCantidad"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCantidad()
        Dim cant As Integer = 0
        While (cant < 20)
            cbxCantidad.Items.Add(cant)
            cant += 1
        End While
        cbxCantidad.Items.Add("+20")
        cbxCantidad.Items.Add("+30")
        cbxCantidad.Items.Add("+40")
        cbxCantidad.Items.Add("+50")
        cbxCantidad.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Se guarda el Producto en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarProducto()
        Dim negocio As New ProductosBo
        Dim nuevoProducto As New Productos

        If Not String.IsNullOrEmpty(txtProducto.Text.Trim()) And Not String.IsNullOrEmpty(txtValor.Text.Trim()) Then
            nuevoProducto.idCategoria = cbxCategorias.SelectedValue
            nuevoProducto.Producto = txtProducto.Text.Trim()
            nuevoProducto.Cantidad = cbxCantidad.SelectedIndex
            nuevoProducto.Valor = txtValor.Text
            nuevoProducto.Comentario = txtComentario.Text
            nuevoProducto.Estado = chkActivo.Checked
            
            If negocio.GuardarProducto(nuevoProducto) Then
                MsgBox("El Producto se a ingresado correctamente.", MsgBoxStyle.Information, "Producto Guardado")
            Else
                MsgBox("Error al ingresar el Producto", MsgBoxStyle.Critical, "Error!")
            End If
        Else
            MsgBox("Por favor, ingrese los datos del Producto", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ''' <summary>
    ''' Se obtiene el producto para actualizar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ObtenerProducto()
        Dim negocio As New ProductosBo
        Dim seleccionProducto As New Productos

        seleccionProducto.idProducto = Producto
        Dim actualizarProducto = negocio.ObtenerProducto(seleccionProducto).First()
        cbxCategorias.SelectedValue = actualizarProducto.idCategoria
        txtProducto.Text = actualizarProducto.Producto
        cbxCantidad.SelectedIndex = actualizarProducto.Cantidad
        txtValor.Text = actualizarProducto.Valor
        txtComentario.Text = actualizarProducto.Comentario
        chkActivo.Checked = actualizarProducto.Estado
    End Sub

    ''' <summary>
    ''' Se obtiene el producto para actualizar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActualizarProducto()
        Dim negocio As New ProductosBo
        Dim seleccionProducto As New Productos

        seleccionProducto.idProducto = Producto
        seleccionProducto.idCategoria = cbxCategorias.SelectedValue
        seleccionProducto.Producto = txtProducto.Text
        seleccionProducto.Cantidad = cbxCantidad.SelectedIndex
        seleccionProducto.Valor = txtValor.Text
        seleccionProducto.Comentario = txtComentario.Text
        seleccionProducto.Estado = chkActivo.Checked

        If negocio.ActualizarProducto(seleccionProducto) Then
            MsgBox("El Producto se a actualizado correctamente.", MsgBoxStyle.Information, "Producto actualizado")
        Else
            MsgBox("Error al actualizar el Producto", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    ''' <summary>
    ''' Actualiza las grillas del formulario FrmProductos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ActualizarGrillasProductos()
        FrmProductos.cbxCategorias.DataSource = Nothing
        FrmProductos.lbProductos.DataSource = Nothing
        FrmProductos.CargarCategorias()
        FrmProductos.CargarProductos()
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Se permite solo el ingreso de números en el TextBox "txtValor"
    ''' </summary>
    ''' <param name="sender">N/A</param>
    ''' <param name="e">Captura Tecla</param>
    ''' <remarks></remarks>
    Private Sub txtValorKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    ''' <summary>
    ''' Guarda el Producto en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnGuardarClick() Handles btnGuardar.Click
        If TipoAccion = 1 Then
            Dim salir = MsgBox("¿Desea guardar el Producto?", MsgBoxStyle.OkCancel, "Guardar " + txtProducto.Text)
            If salir = DialogResult.OK Then
                GuardarProducto()
            End If
        ElseIf TipoAccion = 2 Then
            Dim salir = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.OkCancel, "Guardar " + txtProducto.Text)
            If salir = DialogResult.OK Then
                ActualizarProducto()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Guarda el Producto en la Base de Datos y Cierra el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnGuardarCerrarClick() Handles btnGuardarCerrar.Click
        If TipoAccion.Equals(1) Then
            GuardarProducto()
        ElseIf TipoAccion = 2 Then
            ActualizarProducto()
        End If
        FrmMain.Enabled = True
        ActualizarGrillasProductos()
        Close()
    End Sub

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnCerrarClick() Handles btnCerrar.Click
        Dim salir = MsgBox("¿Desea cerrar la ventana?", MsgBoxStyle.OkCancel, "Cerrar " + Text)
        If salir = DialogResult.OK Then
            FrmMain.Enabled = True
            ActualizarGrillasProductos()
            Close()
        End If
    End Sub

#End Region

End Class