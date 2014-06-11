<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mstMain = New System.Windows.Forms.MenuStrip()
        Me.mnuiAdministrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAdminClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAdminPers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAdminProduc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiCategorias = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiDetalleVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuiSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiIngresarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiRegistroCli = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuiSalir3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiCajero = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiVentaConf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuiSalir4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiBodega = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiBodegaCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiBodegaProd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiBodegaEntrega = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuiSalir2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssBarra = New System.Windows.Forms.StatusStrip()
        Me.tsslProgreso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslMedio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslFechaHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.mstMain.SuspendLayout()
        Me.ssBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstMain
        '
        Me.mstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiAdministrador, Me.mnuiVentas, Me.mnuiCajero, Me.mnuiBodega, Me.mnuiAyuda})
        Me.mstMain.Location = New System.Drawing.Point(0, 0)
        Me.mstMain.Name = "mstMain"
        Me.mstMain.Size = New System.Drawing.Size(1004, 24)
        Me.mstMain.TabIndex = 1
        Me.mstMain.Text = "MenuStrip1"
        '
        'mnuiAdministrador
        '
        Me.mnuiAdministrador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiAdminClientes, Me.mnuiAdminPers, Me.mnuiAdminProduc, Me.mnuiDetalleVentas, Me.ToolStripSeparator1, Me.mnuiSalir})
        Me.mnuiAdministrador.Name = "mnuiAdministrador"
        Me.mnuiAdministrador.Size = New System.Drawing.Size(95, 20)
        Me.mnuiAdministrador.Text = "Administrador"
        Me.mnuiAdministrador.Visible = False
        '
        'mnuiAdminClientes
        '
        Me.mnuiAdminClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiClientes})
        Me.mnuiAdminClientes.Name = "mnuiAdminClientes"
        Me.mnuiAdminClientes.Size = New System.Drawing.Size(193, 22)
        Me.mnuiAdminClientes.Text = "Administrar Clientes"
        '
        'mnuiClientes
        '
        Me.mnuiClientes.Name = "mnuiClientes"
        Me.mnuiClientes.Size = New System.Drawing.Size(116, 22)
        Me.mnuiClientes.Text = "Clientes"
        '
        'mnuiAdminPers
        '
        Me.mnuiAdminPers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiEmpleados})
        Me.mnuiAdminPers.Name = "mnuiAdminPers"
        Me.mnuiAdminPers.Size = New System.Drawing.Size(193, 22)
        Me.mnuiAdminPers.Text = "Administrar Personal"
        '
        'mnuiEmpleados
        '
        Me.mnuiEmpleados.Name = "mnuiEmpleados"
        Me.mnuiEmpleados.Size = New System.Drawing.Size(132, 22)
        Me.mnuiEmpleados.Text = "Empleados"
        '
        'mnuiAdminProduc
        '
        Me.mnuiAdminProduc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiCategorias, Me.mnuiProductos})
        Me.mnuiAdminProduc.Name = "mnuiAdminProduc"
        Me.mnuiAdminProduc.Size = New System.Drawing.Size(193, 22)
        Me.mnuiAdminProduc.Text = "Administrar Productos"
        '
        'mnuiCategorias
        '
        Me.mnuiCategorias.Name = "mnuiCategorias"
        Me.mnuiCategorias.Size = New System.Drawing.Size(130, 22)
        Me.mnuiCategorias.Text = "Categorías"
        '
        'mnuiProductos
        '
        Me.mnuiProductos.Name = "mnuiProductos"
        Me.mnuiProductos.Size = New System.Drawing.Size(130, 22)
        Me.mnuiProductos.Text = "Productos"
        '
        'mnuiDetalleVentas
        '
        Me.mnuiDetalleVentas.Name = "mnuiDetalleVentas"
        Me.mnuiDetalleVentas.Size = New System.Drawing.Size(193, 22)
        Me.mnuiDetalleVentas.Text = "Detalle de Ventas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'mnuiSalir
        '
        Me.mnuiSalir.Name = "mnuiSalir"
        Me.mnuiSalir.Size = New System.Drawing.Size(193, 22)
        Me.mnuiSalir.Text = "Salir"
        '
        'mnuiVentas
        '
        Me.mnuiVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiIngresarVenta, Me.mnuiRegistroCli, Me.ToolStripSeparator3, Me.mnuiSalir3})
        Me.mnuiVentas.Name = "mnuiVentas"
        Me.mnuiVentas.Size = New System.Drawing.Size(54, 20)
        Me.mnuiVentas.Text = "Ventas"
        Me.mnuiVentas.Visible = False
        '
        'mnuiIngresarVenta
        '
        Me.mnuiIngresarVenta.Name = "mnuiIngresarVenta"
        Me.mnuiIngresarVenta.Size = New System.Drawing.Size(160, 22)
        Me.mnuiIngresarVenta.Text = "Ingresar Venta"
        '
        'mnuiRegistroCli
        '
        Me.mnuiRegistroCli.Name = "mnuiRegistroCli"
        Me.mnuiRegistroCli.Size = New System.Drawing.Size(160, 22)
        Me.mnuiRegistroCli.Text = "Registrar Cliente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'mnuiSalir3
        '
        Me.mnuiSalir3.Name = "mnuiSalir3"
        Me.mnuiSalir3.Size = New System.Drawing.Size(160, 22)
        Me.mnuiSalir3.Text = "Salir"
        '
        'mnuiCajero
        '
        Me.mnuiCajero.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiVentaConf, Me.ToolStripSeparator4, Me.mnuiSalir4})
        Me.mnuiCajero.Name = "mnuiCajero"
        Me.mnuiCajero.Size = New System.Drawing.Size(53, 20)
        Me.mnuiCajero.Text = "Cajero"
        Me.mnuiCajero.Visible = False
        '
        'mnuiVentaConf
        '
        Me.mnuiVentaConf.Name = "mnuiVentaConf"
        Me.mnuiVentaConf.Size = New System.Drawing.Size(158, 22)
        Me.mnuiVentaConf.Text = "Confirmar Pago"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(155, 6)
        '
        'mnuiSalir4
        '
        Me.mnuiSalir4.Name = "mnuiSalir4"
        Me.mnuiSalir4.Size = New System.Drawing.Size(158, 22)
        Me.mnuiSalir4.Text = "Salir"
        '
        'mnuiBodega
        '
        Me.mnuiBodega.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiBodegaCat, Me.mnuiBodegaProd, Me.mnuiBodegaEntrega, Me.ToolStripSeparator2, Me.mnuiSalir2})
        Me.mnuiBodega.Name = "mnuiBodega"
        Me.mnuiBodega.Size = New System.Drawing.Size(59, 20)
        Me.mnuiBodega.Text = "Bodega"
        Me.mnuiBodega.Visible = False
        '
        'mnuiBodegaCat
        '
        Me.mnuiBodegaCat.Name = "mnuiBodegaCat"
        Me.mnuiBodegaCat.Size = New System.Drawing.Size(171, 22)
        Me.mnuiBodegaCat.Text = "Categorías"
        '
        'mnuiBodegaProd
        '
        Me.mnuiBodegaProd.Name = "mnuiBodegaProd"
        Me.mnuiBodegaProd.Size = New System.Drawing.Size(171, 22)
        Me.mnuiBodegaProd.Text = "Productos"
        '
        'mnuiBodegaEntrega
        '
        Me.mnuiBodegaEntrega.Name = "mnuiBodegaEntrega"
        Me.mnuiBodegaEntrega.Size = New System.Drawing.Size(171, 22)
        Me.mnuiBodegaEntrega.Text = "Confirmar Entrega"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'mnuiSalir2
        '
        Me.mnuiSalir2.Name = "mnuiSalir2"
        Me.mnuiSalir2.Size = New System.Drawing.Size(171, 22)
        Me.mnuiSalir2.Text = "Salir"
        '
        'mnuiAyuda
        '
        Me.mnuiAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiAcercaDe})
        Me.mnuiAyuda.Name = "mnuiAyuda"
        Me.mnuiAyuda.Size = New System.Drawing.Size(53, 20)
        Me.mnuiAyuda.Text = "Ayuda"
        '
        'mnuiAcercaDe
        '
        Me.mnuiAcercaDe.Name = "mnuiAcercaDe"
        Me.mnuiAcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.mnuiAcercaDe.Text = "Acerca de..."
        '
        'ssBarra
        '
        Me.ssBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslProgreso, Me.tsslMedio, Me.tsslFechaHora})
        Me.ssBarra.Location = New System.Drawing.Point(0, 612)
        Me.ssBarra.Name = "ssBarra"
        Me.ssBarra.Size = New System.Drawing.Size(1004, 22)
        Me.ssBarra.TabIndex = 3
        '
        'tsslProgreso
        '
        Me.tsslProgreso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslProgreso.Name = "tsslProgreso"
        Me.tsslProgreso.Size = New System.Drawing.Size(494, 17)
        Me.tsslProgreso.Spring = True
        Me.tsslProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsslMedio
        '
        Me.tsslMedio.Name = "tsslMedio"
        Me.tsslMedio.Size = New System.Drawing.Size(0, 17)
        '
        'tsslFechaHora
        '
        Me.tsslFechaHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslFechaHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsslFechaHora.Name = "tsslFechaHora"
        Me.tsslFechaHora.Size = New System.Drawing.Size(494, 17)
        Me.tsslFechaHora.Spring = True
        Me.tsslFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tsslFechaHora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tmrHora
        '
        Me.tmrHora.Interval = 500
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SISFAC.Windows.My.Resources.Resources.Logo_SisFac_Acerca_de
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1004, 634)
        Me.Controls.Add(Me.ssBarra)
        Me.Controls.Add(Me.mstMain)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstMain
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Facturación"
        Me.mstMain.ResumeLayout(False)
        Me.mstMain.PerformLayout()
        Me.ssBarra.ResumeLayout(False)
        Me.ssBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mstMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuiAdministrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiAdminProduc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuiSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiCategorias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslProgreso As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslMedio As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslFechaHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents mnuiAdminPers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiAdminClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiDetalleVentas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiIngresarVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiBodega As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiBodegaCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiBodegaProd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiRegistroCli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiBodegaEntrega As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiCajero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiVentaConf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuiSalir2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuiSalir3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuiSalir4 As System.Windows.Forms.ToolStripMenuItem

End Class
