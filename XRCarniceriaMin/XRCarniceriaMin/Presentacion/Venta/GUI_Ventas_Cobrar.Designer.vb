<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Ventas_Cobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Ventas_Cobrar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtCambio = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.txtTicket = New System.Windows.Forms.CheckBox()
        Me.btnAtras = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(405, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cobrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Efectivo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cambio: $"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(164, 69)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(221, 40)
        Me.txtTotal.TabIndex = 6
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCambio
        '
        Me.txtCambio.BackColor = System.Drawing.Color.Transparent
        Me.txtCambio.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio.ForeColor = System.Drawing.Color.Green
        Me.txtCambio.Location = New System.Drawing.Point(164, 187)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(221, 42)
        Me.txtCambio.TabIndex = 7
        Me.txtCambio.Text = "0"
        Me.txtCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.Location = New System.Drawing.Point(171, 124)
        Me.txtEfectivo.MaxLength = 20
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(214, 44)
        Me.txtEfectivo.TabIndex = 8
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCobrar.FlatAppearance.BorderSize = 0
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.ForeColor = System.Drawing.Color.White
        Me.btnCobrar.Location = New System.Drawing.Point(241, 310)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(144, 50)
        Me.btnCobrar.TabIndex = 9
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'txtTicket
        '
        Me.txtTicket.AutoSize = True
        Me.txtTicket.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicket.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTicket.Location = New System.Drawing.Point(268, 250)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(117, 40)
        Me.txtTicket.TabIndex = 10
        Me.txtTicket.Text = "Ticket"
        Me.txtTicket.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Tomato
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.White
        Me.btnAtras.Location = New System.Drawing.Point(80, 310)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(144, 50)
        Me.btnAtras.TabIndex = 11
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'GUI_Ventas_Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(405, 370)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_Ventas_Cobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtCambio As Label
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents btnCobrar As Button
    Friend WithEvents txtTicket As CheckBox
    Friend WithEvents btnAtras As Button
End Class
