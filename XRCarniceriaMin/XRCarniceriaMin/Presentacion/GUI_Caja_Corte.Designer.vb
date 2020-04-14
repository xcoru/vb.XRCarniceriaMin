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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEgresoCaja = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtTotalCaja = New System.Windows.Forms.Label()
        Me.txtVentasdia = New System.Windows.Forms.Label()
        Me.txtInicioCaja = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(927, 60)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Corte de caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtEgresoCaja)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.txtTotalCaja)
        Me.Panel1.Controls.Add(Me.txtVentasdia)
        Me.Panel1.Controls.Add(Me.txtInicioCaja)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 218)
        Me.Panel1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(756, 120)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 41)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtEgresoCaja
        '
        Me.txtEgresoCaja.BackColor = System.Drawing.Color.Coral
        Me.txtEgresoCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoCaja.ForeColor = System.Drawing.Color.White
        Me.txtEgresoCaja.Location = New System.Drawing.Point(236, 71)
        Me.txtEgresoCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtEgresoCaja.Name = "txtEgresoCaja"
        Me.txtEgresoCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtEgresoCaja.TabIndex = 26
        Me.txtEgresoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 27)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Egreso de caja: $"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(756, 75)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(146, 41)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtTotalCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCaja.ForeColor = System.Drawing.Color.White
        Me.txtTotalCaja.Location = New System.Drawing.Point(236, 117)
        Me.txtTotalCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtTotalCaja.TabIndex = 23
        Me.txtTotalCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVentasdia
        '
        Me.txtVentasdia.BackColor = System.Drawing.Color.LightGreen
        Me.txtVentasdia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasdia.ForeColor = System.Drawing.Color.Blue
        Me.txtVentasdia.Location = New System.Drawing.Point(680, 26)
        Me.txtVentasdia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtVentasdia.Name = "txtVentasdia"
        Me.txtVentasdia.Size = New System.Drawing.Size(221, 34)
        Me.txtVentasdia.TabIndex = 22
        Me.txtVentasdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.BackColor = System.Drawing.Color.LightBlue
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.Blue
        Me.txtInicioCaja.Location = New System.Drawing.Point(236, 28)
        Me.txtInicioCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtInicioCaja.TabIndex = 21
        Me.txtInicioCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(927, 40)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Detalles de ventas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 27)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total en caja: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 27)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ventas del dia: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Inicio caja: $"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.dgvTabla)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel2.Size = New System.Drawing.Size(927, 294)
        Me.Panel2.TabIndex = 10
        '
        'dgvTabla
        '
        Me.dgvTabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabla.Location = New System.Drawing.Point(10, 0)
        Me.dgvTabla.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(907, 284)
        Me.dgvTabla.TabIndex = 9
        '
        'GUI_Caja_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(927, 572)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MinimizeBox = False
        Me.Name = "GUI_Caja_Corte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtEgresoCaja As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtTotalCaja As Label
    Friend WithEvents txtVentasdia As Label
    Friend WithEvents txtInicioCaja As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvTabla As DataGridView
End Class
