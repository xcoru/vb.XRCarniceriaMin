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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Caja_Corte))
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtEgresoCaja = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtTotalCaja = New System.Windows.Forms.Label()
        Me.txtVentasdia = New System.Windows.Forms.Label()
        Me.txtInicioCaja = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Divisor = New System.Windows.Forms.SplitContainer()
        Me.dgvEgresos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Divisor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Divisor.Panel1.SuspendLayout()
        Me.Divisor.Panel2.SuspendLayout()
        Me.Divisor.SuspendLayout()
        CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(927, 60)
        Me.txtTitulo.TabIndex = 3
        Me.txtTitulo.Text = "Corte de caja"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.txtEgresoCaja)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.txtTotalCaja)
        Me.Panel1.Controls.Add(Me.txtVentasdia)
        Me.Panel1.Controls.Add(Me.txtInicioCaja)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 168)
        Me.Panel1.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(756, 121)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(146, 41)
        Me.btnSalir.TabIndex = 28
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Tomato
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.ForeColor = System.Drawing.Color.White
        Me.btnAtras.Location = New System.Drawing.Point(602, 75)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(146, 41)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'txtEgresoCaja
        '
        Me.txtEgresoCaja.BackColor = System.Drawing.Color.AliceBlue
        Me.txtEgresoCaja.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.Label10.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(228, 32)
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
        Me.txtTotalCaja.BackColor = System.Drawing.Color.Green
        Me.txtTotalCaja.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtVentasdia.BackColor = System.Drawing.Color.AliceBlue
        Me.txtVentasdia.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtInicioCaja.BackColor = System.Drawing.Color.AliceBlue
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInicioCaja.Location = New System.Drawing.Point(236, 28)
        Me.txtInicioCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(221, 34)
        Me.txtInicioCaja.TabIndex = 21
        Me.txtInicioCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total en caja: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ventas del dia: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 32)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Inicio caja: $"
        '
        'Divisor
        '
        Me.Divisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Divisor.Location = New System.Drawing.Point(0, 228)
        Me.Divisor.Name = "Divisor"
        Me.Divisor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Divisor.Panel1
        '
        Me.Divisor.Panel1.BackColor = System.Drawing.Color.White
        Me.Divisor.Panel1.Controls.Add(Me.dgvEgresos)
        Me.Divisor.Panel1.Controls.Add(Me.Panel2)
        '
        'Divisor.Panel2
        '
        Me.Divisor.Panel2.BackColor = System.Drawing.Color.White
        Me.Divisor.Panel2.Controls.Add(Me.dgvVentas)
        Me.Divisor.Panel2.Controls.Add(Me.Panel3)
        Me.Divisor.Size = New System.Drawing.Size(927, 344)
        Me.Divisor.SplitterDistance = 111
        Me.Divisor.TabIndex = 10
        '
        'dgvEgresos
        '
        Me.dgvEgresos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvEgresos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEgresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEgresos.BackgroundColor = System.Drawing.Color.White
        Me.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEgresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEgresos.Location = New System.Drawing.Point(0, 32)
        Me.dgvEgresos.MultiSelect = False
        Me.dgvEgresos.Name = "dgvEgresos"
        Me.dgvEgresos.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEgresos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEgresos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEgresos.Size = New System.Drawing.Size(927, 79)
        Me.dgvEgresos.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 32)
        Me.Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(927, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Detalles Egresos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentas.Location = New System.Drawing.Point(0, 32)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(927, 197)
        Me.dgvVentas.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 32)
        Me.Panel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(927, 32)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Detalles Ventas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_Caja_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(927, 572)
        Me.Controls.Add(Me.Divisor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtTitulo)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.MinimizeBox = False
        Me.Name = "GUI_Caja_Corte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Divisor.Panel1.ResumeLayout(False)
        Me.Divisor.Panel2.ResumeLayout(False)
        CType(Me.Divisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Divisor.ResumeLayout(False)
        CType(Me.dgvEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAtras As Button
    Friend WithEvents txtEgresoCaja As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents txtTotalCaja As Label
    Friend WithEvents txtVentasdia As Label
    Friend WithEvents txtInicioCaja As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Divisor As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvEgresos As DataGridView
    Friend WithEvents dgvVentas As DataGridView
End Class
