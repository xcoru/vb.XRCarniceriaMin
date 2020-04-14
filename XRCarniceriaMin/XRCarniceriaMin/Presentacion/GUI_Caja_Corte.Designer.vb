<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Caja_Corte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Caja_Corte))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.txtInicioCaja = New System.Windows.Forms.Label()
        Me.txtVentasdia = New System.Windows.Forms.Label()
        Me.txtTotalCaja = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtEgresoCaja = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 60)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Corte de caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inicio caja: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vetas del dia: $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total en caja: $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Detalles de ventas"
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTabla.Location = New System.Drawing.Point(0, 243)
        Me.dgvTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(888, 349)
        Me.dgvTabla.TabIndex = 8
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.BackColor = System.Drawing.Color.LightBlue
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.Blue
        Me.txtInicioCaja.Location = New System.Drawing.Point(215, 86)
        Me.txtInicioCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtInicioCaja.TabIndex = 9
        Me.txtInicioCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVentasdia
        '
        Me.txtVentasdia.BackColor = System.Drawing.Color.LightGreen
        Me.txtVentasdia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasdia.ForeColor = System.Drawing.Color.Blue
        Me.txtVentasdia.Location = New System.Drawing.Point(659, 84)
        Me.txtVentasdia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtVentasdia.Name = "txtVentasdia"
        Me.txtVentasdia.Size = New System.Drawing.Size(221, 34)
        Me.txtVentasdia.TabIndex = 10
        Me.txtVentasdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtTotalCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCaja.ForeColor = System.Drawing.Color.White
        Me.txtTotalCaja.Location = New System.Drawing.Point(215, 175)
        Me.txtTotalCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtTotalCaja.TabIndex = 11
        Me.txtTotalCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(732, 133)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(146, 41)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtEgresoCaja
        '
        Me.txtEgresoCaja.BackColor = System.Drawing.Color.Coral
        Me.txtEgresoCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoCaja.ForeColor = System.Drawing.Color.White
        Me.txtEgresoCaja.Location = New System.Drawing.Point(215, 129)
        Me.txtEgresoCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEgresoCaja.Name = "txtEgresoCaja"
        Me.txtEgresoCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtEgresoCaja.TabIndex = 15
        Me.txtEgresoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 124)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 27)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Egreso de caja: $"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(732, 178)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GUI_Caja_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(888, 592)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEgresoCaja)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTotalCaja)
        Me.Controls.Add(Me.txtVentasdia)
        Me.Controls.Add(Me.txtInicioCaja)
        Me.Controls.Add(Me.dgvTabla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GUI_Caja_Corte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvTabla As DataGridView
    Friend WithEvents txtInicioCaja As Label
    Friend WithEvents txtVentasdia As Label
    Friend WithEvents txtTotalCaja As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtEgresoCaja As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
End Class
