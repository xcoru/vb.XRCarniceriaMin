<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Ventas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCorte = New System.Windows.Forms.Button()
        Me.btnEgreso = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtFecha = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnCorte)
        Me.Panel1.Controls.Add(Me.btnEgreso)
        Me.Panel1.Controls.Add(Me.btnConfig)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 95)
        Me.Panel1.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(12, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 80)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCorte
        '
        Me.btnCorte.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCorte.FlatAppearance.BorderSize = 0
        Me.btnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorte.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorte.Location = New System.Drawing.Point(236, 8)
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(80, 80)
        Me.btnCorte.TabIndex = 3
        Me.btnCorte.Text = "Corte"
        Me.btnCorte.UseVisualStyleBackColor = False
        '
        'btnEgreso
        '
        Me.btnEgreso.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEgreso.FlatAppearance.BorderSize = 0
        Me.btnEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEgreso.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgreso.Location = New System.Drawing.Point(322, 8)
        Me.btnEgreso.Name = "btnEgreso"
        Me.btnEgreso.Size = New System.Drawing.Size(80, 80)
        Me.btnEgreso.TabIndex = 2
        Me.btnEgreso.Text = "Egreso"
        Me.btnEgreso.UseVisualStyleBackColor = False
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.AliceBlue
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.Location = New System.Drawing.Point(98, 8)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(80, 80)
        Me.btnConfig.TabIndex = 1
        Me.btnConfig.Text = "Config"
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.txtEmpresa)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(668, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 95)
        Me.Panel2.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(46, 50)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(276, 31)
        Me.txtTelefono.TabIndex = 5
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpresa.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(46, 14)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(276, 31)
        Me.txtEmpresa.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnCobrar)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1037, 92)
        Me.Panel3.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(408, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 80)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCobrar
        '
        Me.btnCobrar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCobrar.FlatAppearance.BorderSize = 0
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(494, 6)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(80, 80)
        Me.btnCobrar.TabIndex = 9
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Location = New System.Drawing.Point(112, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(112, 46)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(276, 31)
        Me.txtTotal.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtFecha)
        Me.Panel5.Controls.Add(Me.txtUsuario)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(743, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(294, 92)
        Me.Panel5.TabIndex = 6
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(9, 49)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(276, 31)
        Me.txtFecha.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(9, 13)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(276, 31)
        Me.txtUsuario.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(12, 6)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 80)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agre.."
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.dgvTabla)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel4.Size = New System.Drawing.Size(1037, 476)
        Me.Panel4.TabIndex = 3
        '
        'dgvTabla
        '
        Me.dgvTabla.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        Me.dgvTabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabla.Location = New System.Drawing.Point(15, 15)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTabla.Size = New System.Drawing.Size(1007, 446)
        Me.dgvTabla.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 67
        '
        'Column2
        '
        Me.Column2.HeaderText = "Calve"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 162
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 104
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 82
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cantidad"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 134
        '
        'Column7
        '
        Me.Column7.HeaderText = "SubTotal"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 131
        '
        'GUI_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 663)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "GUI_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCorte As Button
    Friend WithEvents btnEgreso As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvTabla As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtFecha As Label
    Friend WithEvents txtUsuario As Label
    Friend WithEvents txtTelefono As Label
    Friend WithEvents txtEmpresa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnCancelar As Button
End Class
