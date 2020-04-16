<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Ventas_Agregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Ventas_Agregar))
        Me.P_Body = New System.Windows.Forms.Panel()
        Me.Tabla = New System.Windows.Forms.FlowLayoutPanel()
        Me.Opciones = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.P_Body.SuspendLayout()
        Me.Opciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Body
        '
        Me.P_Body.Controls.Add(Me.Tabla)
        Me.P_Body.Controls.Add(Me.Opciones)
        Me.P_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Body.Location = New System.Drawing.Point(0, 0)
        Me.P_Body.Name = "P_Body"
        Me.P_Body.Size = New System.Drawing.Size(1108, 711)
        Me.P_Body.TabIndex = 2
        '
        'Tabla
        '
        Me.Tabla.AutoScroll = True
        Me.Tabla.AutoSize = True
        Me.Tabla.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabla.Location = New System.Drawing.Point(0, 0)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(817, 711)
        Me.Tabla.TabIndex = 1
        '
        'Opciones
        '
        Me.Opciones.BackColor = System.Drawing.Color.Azure
        Me.Opciones.Controls.Add(Me.Panel2)
        Me.Opciones.Controls.Add(Me.Panel1)
        Me.Opciones.Controls.Add(Me.Label1)
        Me.Opciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.Opciones.Location = New System.Drawing.Point(817, 0)
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(291, 711)
        Me.Opciones.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtArticulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 197)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(9, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cantidad:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 35)
        Me.TextBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.Label2.Location = New System.Drawing.Point(100, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 31)
        Me.Label2.TabIndex = 8
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtArticulo
        '
        Me.txtArticulo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtArticulo.Location = New System.Drawing.Point(8, 9)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(273, 31)
        Me.txtArticulo.TabIndex = 7
        Me.txtArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 634)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 77)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(10, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(271, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Terminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GUI_Ventas_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 711)
        Me.Controls.Add(Me.P_Body)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MinimizeBox = False
        Me.Name = "GUI_Ventas_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Articulos"
        Me.P_Body.ResumeLayout(False)
        Me.P_Body.PerformLayout()
        Me.Opciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P_Body As Panel
    Friend WithEvents Tabla As FlowLayoutPanel
    Friend WithEvents Opciones As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtArticulo As Label
End Class
