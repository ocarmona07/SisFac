<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcercaDe
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtCreditos = New System.Windows.Forms.TextBox()
        Me.tmrTexto1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTexto2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = Global.SISFAC.Windows.My.Resources.Resources.Logo_SisFac_Acerca_de
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(390, 191)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(13, 283)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(389, 36)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCreditos
        '
        Me.txtCreditos.BackColor = System.Drawing.Color.White
        Me.txtCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreditos.Enabled = False
        Me.txtCreditos.ForeColor = System.Drawing.Color.Black
        Me.txtCreditos.Location = New System.Drawing.Point(12, 209)
        Me.txtCreditos.Multiline = True
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.ReadOnly = True
        Me.txtCreditos.Size = New System.Drawing.Size(390, 68)
        Me.txtCreditos.TabIndex = 3
        Me.txtCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrTexto1
        '
        Me.tmrTexto1.Interval = 5000
        '
        'tmrTexto2
        '
        Me.tmrTexto2.Interval = 5000
        '
        'FrmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 331)
        Me.Controls.Add(Me.txtCreditos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcercaDe"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de..."
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents tmrTexto1 As System.Windows.Forms.Timer
    Friend WithEvents tmrTexto2 As System.Windows.Forms.Timer

End Class
