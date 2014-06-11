Imports SISFAC.Negocio
Imports SISFAC.Entidades

Public Class FrmLogin

#Region "Métodos"

    Public Function Validar() As Boolean
        If String.IsNullOrEmpty(txtRUT.Text.Trim()) Or txtRUT.Text.Length < 7 Then
            MsgBox("Falta completar RUT", MsgBoxStyle.Exclamation, "Ingreso fallido")
            Return False
        End If
        If Not IsNumeric(txtRUT.Text) Then
            MsgBox("Solo debe ingresar números para el RUT", MsgBoxStyle.Exclamation, "Ingreso fallido")
            Return False
        End If
        If txtPassword.Text.Length <= 3 Then
            MsgBox("Clave Incorrecta!", MsgBoxStyle.Exclamation, "Ingreso fallido")
            Return False
        End If
        If IsNumeric(txtRUT.Text) And txtPassword.Text.Length >= 4 Then
            Return True
        End If
        Return False
    End Function

    Public Sub Comprobar()
        Dim negocio As New EmpleadosBo
        Dim usuario As New Empleados
        usuario.RUT = txtRUT.Text
        usuario.Password = txtPassword.Text
        Dim ingreso = negocio.IngresoLogin(usuario)
        If ingreso Then
            Dim obtenerCargo As New EmpleadosBo
            Dim empleadoCargo = obtenerCargo.ObtenerEmpleadoPorRut(usuario.RUT)
            Dim cargo As Integer = empleadoCargo.idCargo
            Select Case cargo
                Case 1
                    FrmMain.mnuiBodega.Visible = True
                Case 2
                    FrmMain.mnuiCajero.Visible = True
                Case 3
                    FrmMain.mnuiVentas.Visible = True
                Case 4
                    FrmMain.mnuiAdministrador.Visible = True
            End Select
            FrmMain.Show()
            Close()
        Else
            MsgBox("RUT o clave incorrecta!", MsgBoxStyle.Exclamation, "Ingreso fallido")
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub Ingresar() Handles btnIngresar.Click
        If Validar() Then
            Comprobar()
        End If
    End Sub

    Private Sub Cancelar() Handles btnCancelar.Click
        Close()
    End Sub

#End Region

End Class
