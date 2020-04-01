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
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(885, 49)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Corte de caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inicio caja: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vetas del dia: $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total en caja: $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Detalles de ventas"
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvTabla.Location = New System.Drawing.Point(0, 237)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(885, 284)
        Me.dgvTabla.TabIndex = 8
        '
        'txtInicioCaja
        '
        Me.txtInicioCaja.BackColor = System.Drawing.Color.LightBlue
        Me.txtInicioCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicioCaja.ForeColor = System.Drawing.Color.Blue
        Me.txtInicioCaja.Location = New System.Drawing.Point(163, 63)
        Me.txtInicioCaja.Name = "txtInicioCaja"
        Me.txtInicioCaja.Size = New System.Drawing.Size(174, 28)
        Me.txtInicioCaja.TabIndex = 9
        Me.txtInicioCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVentasdia
        '
        Me.txtVentasdia.BackColor = System.Drawing.Color.LightGreen
        Me.txtVentasdia.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasdia.ForeColor = System.Drawing.Color.Blue
        Me.txtVentasdia.Location = New System.Drawing.Point(516, 63)
        Me.txtVentasdia.Name = "txtVentasdia"
        Me.txtVentasdia.Size = New System.Drawing.Size(174, 28)
        Me.txtVentasdia.TabIndex = 10
        Me.txtVentasdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCaja
        '
        Me.txtTotalCaja.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtTotalCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCaja.ForeColor = System.Drawing.Color.White
        Me.txtTotalCaja.Location = New System.Drawing.Point(163, 135)
        Me.txtTotalCaja.Name = "txtTotalCaja"
        Me.txtTotalCaja.Size = New System.Drawing.Size(174, 28)
        Me.txtTotalCaja.TabIndex = 11
        Me.txtTotalCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(575, 130)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(115, 33)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtEgresoCaja
        '
        Me.txtEgresoCaja.BackColor = System.Drawing.Color.Coral
        Me.txtEgresoCaja.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresoCaja.ForeColor = System.Drawing.Color.White
        Me.txtEgresoCaja.Location = New System.Drawing.Point(163, 98)
        Me.txtEgresoCaja.Name = "txtEgresoCaja"
        Me.txtEgresoCaja.Size = New System.Drawing.Size(174, 28)
        Me.txtEgresoCaja.TabIndex = 15
        Me.txtEgresoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 22)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Egreso de caja: $"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GUI_Caja_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(885, 521)
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
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "GUI_Caja_Corte"
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
End Class
