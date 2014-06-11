Imports SISFAC.Negocio
Imports SISFAC.Entidades

''' <summary>
''' Clase del formulario Categorías
''' </summary>
''' <remarks></remarks>
Public Class FrmCategorias

#Region "Load"

    ''' <summary>
    ''' Al iniciar se llama al método CargarCategorias
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmCategoriasLoad() Handles MyBase.Load
        CargarCategorias()
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Método que carga las Categorías en el ListBox "lbCategorias"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCategorias()
        Dim negocio As New CategoriasBo
        lbCategorias.DataSource = negocio.ObtenerCategorias()
        lbCategorias.ValueMember = "idCategoria"
        lbCategorias.DisplayMember = "Categoria"
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que cierra el formulario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnCerrarClick() Handles btnCerrar.Click
        Close()
    End Sub

    ''' <summary>
    ''' Evento que guarda una nueva Categoría en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnIngresarClick() Handles btnIngresar.Click
        Dim negocio As New CategoriasBo
        Dim nuevaCategoria As New Categorias
        Dim categoria As String

        categoria = InputBox("Ingrese una nueva categoría:", "Ingresar Categoría", Nothing).ToString()
        If categoria.Length < 21 Then
            If Not String.IsNullOrEmpty(categoria.Trim()) Then
                categoria = StrConv(categoria, VbStrConv.ProperCase)
                nuevaCategoria.Categoria = categoria
                If negocio.GuardarCategoria(nuevaCategoria) Then
                    MsgBox("Categoría ingresada correctamente.", MsgBoxStyle.Information, "Ingresar Categoría")
                Else
                    MsgBox("Error al ingresar la categoría.", MsgBoxStyle.Critical, "Ingresar Categoría")
                End If
            Else
                MsgBox("Por favor, ingrese una categoría válida.", MsgBoxStyle.Exclamation, "Error!")
            End If
            CargarCategorias()
        Else
            MsgBox("La categoría debe tener menos de 20 carácteres.", MsgBoxStyle.Critical, "Ingresar Categoría")
        End If
    End Sub

    ''' <summary>
    ''' Evento que actualiza una Categoria en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnActualizarClick() Handles btnActualizar.Click

        Dim negocio As New CategoriasBo
        Dim nuevaCategoria As New Categorias
        Dim categoria As String

        categoria = InputBox("Ingrese una nueva categoría:", "Actualizar Categoría", Nothing)
        If categoria.Length < 21 Then
            If Not String.IsNullOrEmpty(categoria.Trim()) Then
                categoria = StrConv(categoria, VbStrConv.ProperCase)
                nuevaCategoria.Categoria = categoria
                nuevaCategoria.idCategoria = lbCategorias.SelectedValue
                If negocio.ActualizarCategoria(nuevaCategoria) Then
                    MsgBox("Categoría actualizada correctamente.", MsgBoxStyle.Information, "Actualizar Categoría")
                Else
                    MsgBox("Error al actualizar la categoría.", MsgBoxStyle.Critical, "Actualizar Categoría")
                End If
            Else
                MsgBox("Por favor, ingrese una categoría válida.", MsgBoxStyle.Exclamation, "Error!")
            End If
            CargarCategorias()
        Else
            MsgBox("La categoría debe tener menos de 20 carácteres.", MsgBoxStyle.Critical, "Actualizar Categoría")
        End If
    End Sub

    ''' <summary>
    ''' Evento que elimina una Categoría en la Base de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BtnEliminarClick() Handles btnEliminar.Click

        Dim negocio As New CategoriasBo
        Dim nuevaCategoria As New Categorias
        Dim eliminar = MsgBox("¿Desea eliminar la categoría seleccionada?", MsgBoxStyle.OkCancel, "Eliminar Categoría")

        If eliminar = DialogResult.OK Then
            nuevaCategoria.idCategoria = lbCategorias.SelectedValue
            If negocio.EliminarCategoria(nuevaCategoria) Then
                MsgBox("Categoría eliminada correctamente.", MsgBoxStyle.Information, "Eliminar Categoría")
            Else
                MsgBox("Error al eliminar la categoría.", MsgBoxStyle.Critical, "Eliminar Categoría")
            End If
        End If

        CargarCategorias()
    End Sub

#End Region
    
End Class