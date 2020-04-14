<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI_Config
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Config))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLogotipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImpresora = New System.Windows.Forms.Button()
        Me.txtImpresora = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.imgLogoTipo = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.diaArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.diaImpresora = New System.Windows.Forms.PrintDialog()
        CType(Me.imgLogoTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Configuraciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Información del Negocio:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(22, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(22, 173)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(245, 35)
        Me.txtNombre.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(290, 173)
        Me.txtDireccion.MaxLength = 250
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(362, 35)
        Me.txtDireccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(290, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(22, 262)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(245, 35)
        Me.txtTelefono.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(22, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogotipo
        '
        Me.txtLogotipo.BackColor = System.Drawing.Color.Lavender
        Me.txtLogotipo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogotipo.Location = New System.Drawing.Point(293, 265)
        Me.txtLogotipo.Name = "txtLogotipo"
        Me.txtLogotipo.ReadOnly = True
        Me.txtLogotipo.Size = New System.Drawing.Size(303, 29)
        Me.txtLogotipo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(294, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(358, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Logotipo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImpresora
        '
        Me.btnImpresora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImpresora.Location = New System.Drawing.Point(217, 425)
        Me.btnImpresora.Name = "btnImpresora"
        Me.btnImpresora.Size = New System.Drawing.Size(50, 35)
        Me.btnImpresora.TabIndex = 12
        Me.btnImpresora.Text = ">>"
        Me.btnImpresora.UseVisualStyleBackColor = False
        '
        'txtImpresora
        '
        Me.txtImpresora.BackColor = System.Drawing.Color.White
        Me.txtImpresora.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpresora.Location = New System.Drawing.Point(22, 428)
        Me.txtImpresora.Name = "txtImpresora"
        Me.txtImpresora.ReadOnly = True
        Me.txtImpresora.Size = New System.Drawing.Size(189, 29)
        Me.txtImpresora.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(22, 396)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Impresora"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnArchivo
        '
        Me.btnArchivo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchivo.Location = New System.Drawing.Point(602, 262)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(50, 35)
        Me.btnArchivo.TabIndex = 15
        Me.btnArchivo.Text = ">>"
        Me.btnArchivo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(472, 492)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(179, 44)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'imgLogoTipo
        '
        Me.imgLogoTipo.BackColor = System.Drawing.Color.Lavender
        Me.imgLogoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogoTipo.Location = New System.Drawing.Point(296, 305)
        Me.imgLogoTipo.Name = "imgLogoTipo"
        Me.imgLogoTipo.Size = New System.Drawing.Size(356, 157)
        Me.imgLogoTipo.TabIndex = 17
        Me.imgLogoTipo.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tomato
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(275, 492)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 44)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Atras"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'diaArchivo
        '
        Me.diaArchivo.FileName = "OpenFileDialog1"
        '
        'diaImpresora
        '
        Me.diaImpresora.AllowPrintToFile = False
        Me.diaImpresora.UseEXDialog = True
        '
        'GUI_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 544)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.imgLogoTipo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnArchivo)
        Me.Controls.Add(Me.txtImpresora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImpresora)
        Me.Controls.Add(Me.txtLogotipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuraciones"
        CType(Me.imgLogoTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLogotipo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnImpresora As Button
    Friend WithEvents txtImpresora As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnArchivo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents imgLogoTipo As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents diaArchivo As OpenFileDialog
    Friend WithEvents diaImpresora As PrintDialog
End Class
