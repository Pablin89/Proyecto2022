<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturacion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.LCajero = New System.Windows.Forms.Label()
        Me.TFactura = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.TDniCli = New System.Windows.Forms.TextBox()
        Me.TApellidoCli = New System.Windows.Forms.TextBox()
        Me.TNombreCli = New System.Windows.Forms.TextBox()
        Me.LSeleccionar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDa = New System.Windows.Forms.Label()
        Me.LDniC = New System.Windows.Forms.Label()
        Me.LApellidoC = New System.Windows.Forms.Label()
        Me.LNombreC = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TCantidad = New System.Windows.Forms.TextBox()
        Me.TProducto = New System.Windows.Forms.TextBox()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sutotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LHora = New System.Windows.Forms.Label()
        Me.CBForma = New System.Windows.Forms.ComboBox()
        Me.LForna = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCajero
        '
        Me.LCajero.AutoSize = True
        Me.LCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCajero.Location = New System.Drawing.Point(207, 25)
        Me.LCajero.Name = "LCajero"
        Me.LCajero.Size = New System.Drawing.Size(83, 24)
        Me.LCajero.TabIndex = 0
        Me.LCajero.Text = "Cajero: "
        '
        'TFactura
        '
        Me.TFactura.Enabled = False
        Me.TFactura.Location = New System.Drawing.Point(296, 30)
        Me.TFactura.Name = "TFactura"
        Me.TFactura.Size = New System.Drawing.Size(187, 20)
        Me.TFactura.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.TCliente)
        Me.Panel1.Controls.Add(Me.TDniCli)
        Me.Panel1.Controls.Add(Me.TApellidoCli)
        Me.Panel1.Controls.Add(Me.TNombreCli)
        Me.Panel1.Controls.Add(Me.LSeleccionar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LDa)
        Me.Panel1.Controls.Add(Me.LDniC)
        Me.Panel1.Controls.Add(Me.LApellidoC)
        Me.Panel1.Controls.Add(Me.LNombreC)
        Me.Panel1.Location = New System.Drawing.Point(12, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 306)
        Me.Panel1.TabIndex = 2
        '
        'TTelefono
        '
        Me.TTelefono.Enabled = False
        Me.TTelefono.Location = New System.Drawing.Point(159, 258)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(237, 20)
        Me.TTelefono.TabIndex = 13
        '
        'TCliente
        '
        Me.TCliente.Location = New System.Drawing.Point(159, 62)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(237, 20)
        Me.TCliente.TabIndex = 12
        '
        'TDniCli
        '
        Me.TDniCli.Enabled = False
        Me.TDniCli.Location = New System.Drawing.Point(157, 211)
        Me.TDniCli.Name = "TDniCli"
        Me.TDniCli.Size = New System.Drawing.Size(237, 20)
        Me.TDniCli.TabIndex = 10
        '
        'TApellidoCli
        '
        Me.TApellidoCli.Enabled = False
        Me.TApellidoCli.Location = New System.Drawing.Point(159, 162)
        Me.TApellidoCli.Name = "TApellidoCli"
        Me.TApellidoCli.Size = New System.Drawing.Size(237, 20)
        Me.TApellidoCli.TabIndex = 9
        '
        'TNombreCli
        '
        Me.TNombreCli.Enabled = False
        Me.TNombreCli.Location = New System.Drawing.Point(159, 113)
        Me.TNombreCli.Name = "TNombreCli"
        Me.TNombreCli.Size = New System.Drawing.Size(237, 20)
        Me.TNombreCli.TabIndex = 8
        '
        'LSeleccionar
        '
        Me.LSeleccionar.AutoSize = True
        Me.LSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSeleccionar.Location = New System.Drawing.Point(136, 21)
        Me.LSeleccionar.Name = "LSeleccionar"
        Me.LSeleccionar.Size = New System.Drawing.Size(164, 20)
        Me.LSeleccionar.TabIndex = 6
        Me.LSeleccionar.Text = "Seleccionar Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingresar DNI"
        '
        'LDa
        '
        Me.LDa.AutoSize = True
        Me.LDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDa.Location = New System.Drawing.Point(68, 260)
        Me.LDa.Name = "LDa"
        Me.LDa.Size = New System.Drawing.Size(79, 20)
        Me.LDa.TabIndex = 4
        Me.LDa.Text = "Telefono"
        '
        'LDniC
        '
        Me.LDniC.AutoSize = True
        Me.LDniC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDniC.Location = New System.Drawing.Point(107, 211)
        Me.LDniC.Name = "LDniC"
        Me.LDniC.Size = New System.Drawing.Size(40, 20)
        Me.LDniC.TabIndex = 3
        Me.LDniC.Text = "DNI"
        '
        'LApellidoC
        '
        Me.LApellidoC.AutoSize = True
        Me.LApellidoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellidoC.Location = New System.Drawing.Point(74, 162)
        Me.LApellidoC.Name = "LApellidoC"
        Me.LApellidoC.Size = New System.Drawing.Size(73, 20)
        Me.LApellidoC.TabIndex = 2
        Me.LApellidoC.Text = "Apellido"
        '
        'LNombreC
        '
        Me.LNombreC.AutoSize = True
        Me.LNombreC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreC.Location = New System.Drawing.Point(76, 113)
        Me.LNombreC.Name = "LNombreC"
        Me.LNombreC.Size = New System.Drawing.Size(71, 20)
        Me.LNombreC.TabIndex = 1
        Me.LNombreC.Text = "Nombre"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BAgregar)
        Me.Panel3.Controls.Add(Me.TCantidad)
        Me.Panel3.Controls.Add(Me.TProducto)
        Me.Panel3.Controls.Add(Me.LProducto)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(484, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 117)
        Me.Panel3.TabIndex = 4
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BAgregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.Black
        Me.BAgregar.Image = Global.Principal.My.Resources.Resources.shopping_cart_add_button_icon_icons_com_56132
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.Location = New System.Drawing.Point(531, 24)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(242, 58)
        Me.BAgregar.TabIndex = 18
        Me.BAgregar.Text = "Agregar a la lista"
        Me.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'TCantidad
        '
        Me.TCantidad.Location = New System.Drawing.Point(236, 60)
        Me.TCantidad.Name = "TCantidad"
        Me.TCantidad.Size = New System.Drawing.Size(135, 20)
        Me.TCantidad.TabIndex = 23
        '
        'TProducto
        '
        Me.TProducto.Location = New System.Drawing.Point(236, 21)
        Me.TProducto.Name = "TProducto"
        Me.TProducto.Size = New System.Drawing.Size(201, 20)
        Me.TProducto.TabIndex = 28
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.Location = New System.Drawing.Point(48, 21)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(180, 20)
        Me.LProducto.TabIndex = 7
        Me.LProducto.Text = "Seleccionar Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cantidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Precio, Me.Sutotal, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(484, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.Size = New System.Drawing.Size(858, 297)
        Me.DataGridView1.TabIndex = 10
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio "
        Me.Precio.Name = "Precio"
        '
        'Sutotal
        '
        Me.Sutotal.HeaderText = "Total"
        Me.Sutotal.Name = "Sutotal"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TTotal
        '
        Me.TTotal.Enabled = False
        Me.TTotal.Location = New System.Drawing.Point(1122, 600)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(220, 20)
        Me.TTotal.TabIndex = 7
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(1048, 596)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(56, 24)
        Me.LTotal.TabIndex = 6
        Me.LTotal.Text = "Total"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(801, 30)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(75, 24)
        Me.LFecha.TabIndex = 9
        Me.LFecha.Text = "Fecha:"
        Me.LFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(20, 651)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.BackColor = System.Drawing.Color.Transparent
        Me.LHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHora.ForeColor = System.Drawing.Color.Black
        Me.LHora.Location = New System.Drawing.Point(1070, 29)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(61, 24)
        Me.LHora.TabIndex = 16
        Me.LHora.Text = "Hora:"
        Me.LHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBForma
        '
        Me.CBForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBForma.FormattingEnabled = True
        Me.CBForma.Items.AddRange(New Object() {"Tarjeta de Credito", "Tarjeta de Debito", "MercadoPago", "Efectivo"})
        Me.CBForma.Location = New System.Drawing.Point(628, 599)
        Me.CBForma.Name = "CBForma"
        Me.CBForma.Size = New System.Drawing.Size(235, 21)
        Me.CBForma.TabIndex = 22
        '
        'LForna
        '
        Me.LForna.AutoSize = True
        Me.LForna.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LForna.Location = New System.Drawing.Point(480, 600)
        Me.LForna.Name = "LForna"
        Me.LForna.Size = New System.Drawing.Size(131, 20)
        Me.LForna.TabIndex = 21
        Me.LForna.Text = "Forma de Pago"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(67, 470)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(326, 32)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Agregar nuevo cliente"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.TFactura)
        Me.Panel4.Controls.Add(Me.LCajero)
        Me.Panel4.Controls.Add(Me.LHora)
        Me.Panel4.Controls.Add(Me.LFecha)
        Me.Panel4.Location = New System.Drawing.Point(7, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1335, 129)
        Me.Panel4.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Brown
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Principal.My.Resources.Resources.shoppingcart_below_compra_12831
        Me.Button2.Location = New System.Drawing.Point(1006, 642)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 55)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar Venta"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BConfirmar
        '
        Me.BConfirmar.BackColor = System.Drawing.Color.SpringGreen
        Me.BConfirmar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmar.Image = Global.Principal.My.Resources.Resources.shoppingcart_accept_compra_12832
        Me.BConfirmar.Location = New System.Drawing.Point(1186, 642)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(156, 55)
        Me.BConfirmar.TabIndex = 8
        Me.BConfirmar.Text = "Confirmar Venta"
        Me.BConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmar.UseVisualStyleBackColor = False
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1354, 710)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CBForma)
        Me.Controls.Add(Me.LForna)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.KeyPreview = True
        Me.Name = "Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LCajero As Label
    Friend WithEvents TFactura As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LSeleccionar As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDa As Label
    Friend WithEvents LDniC As Label
    Friend WithEvents LApellidoC As Label
    Friend WithEvents LNombreC As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LProducto As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TTotal As TextBox
    Friend WithEvents LTotal As Label
    Friend WithEvents BConfirmar As Button
    Friend WithEvents LFecha As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents LHora As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBForma As ComboBox
    Friend WithEvents LForna As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Sutotal As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TCantidad As TextBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TCliente As TextBox
    Friend WithEvents TDniCli As TextBox
    Friend WithEvents TApellidoCli As TextBox
    Friend WithEvents TNombreCli As TextBox
    Friend WithEvents BAgregar As Button
    Friend WithEvents TProducto As TextBox
End Class
