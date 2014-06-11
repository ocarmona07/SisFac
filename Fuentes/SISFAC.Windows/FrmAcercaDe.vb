Public NotInheritable Class FrmAcercaDe

#Region "Atributos"

    Public Salto As Boolean

#End Region

#Region "Load"

    Private Sub FrmAcercaDeLoad() Handles MyBase.Load
        Dim linea As String = Environment.NewLine
        Dim texto As String
        texto = linea + "Creado por: Omar Carmona, Esteban Valdebenito y Jesús Parra" + linea
        txtCreditos.Text = texto
        tmrTexto2.Enabled = True
    End Sub

#End Region

#Region "Eventos"

    Private Sub Aceptar() Handles btnAceptar.Click
        FrmMain.Enabled = True
        Close()
    End Sub

    Private Sub ScrollUp() Handles tmrTexto1.Tick
        txtCreditos.Clear()
        Dim linea As String = Environment.NewLine
        Dim texto As String
        texto = linea + "Creado por: Omar Carmona, Esteban Valdebenito y Jesús Parra" + linea
        txtCreditos.Text = texto
        tmrTexto1.Stop()
        tmrTexto2.Start()
    End Sub

    Private Sub ScrollDown() Handles tmrTexto2.Tick
        txtCreditos.Clear()
        Dim linea As String = Environment.NewLine
        Dim texto As String
        texto = linea + "Profesor: Alex R. Catalán Carrasco" + linea
        texto += "Ramo: Taller en Base a Proyectos de Programación" + linea
        txtCreditos.Text = texto
        tmrTexto2.Stop()
        tmrTexto1.Start()
    End Sub

#End Region

End Class
