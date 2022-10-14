<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionProductos
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
        Me.Productos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBcat = New System.Windows.Forms.RadioButton()
        Me.TNombre2 = New System.Windows.Forms.TextBox()
        Me.RBnombre = New System.Windows.Forms.RadioButton()
        Me.RBcodigo = New System.Windows.Forms.RadioButton()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.ComboCat = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TStockMin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.CBcategoria = New System.Windows.Forms.ComboBox()
        Me.TStock = New System.Windows.Forms.TextBox()
        Me.TPrecioProd = New System.Windows.Forms.TextBox()
        Me.TCodigoProd = New System.Windows.Forms.TextBox()
        Me.TDescripcion = New System.Windows.Forms.TextBox()
        Me.TNombreProd = New System.Windows.Forms.TextBox()
        Me.LDatos = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.BCancelarcat = New System.Windows.Forms.Button()
        Me.BConfirmarCat = New System.Windows.Forms.Button()
        Me.TDesc = New System.Windows.Forms.TextBox()
        Me.LDatoscat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Productos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Productos
        '
        Me.Productos.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Productos.Controls.Add(Me.TabPage1)
        Me.Productos.Controls.Add(Me.TabPage2)
        Me.Productos.Controls.Add(Me.TabPage3)
        Me.Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productos.Location = New System.Drawing.Point(0, 76)
        Me.Productos.Multiline = True
        Me.Productos.Name = "Productos"
        Me.Productos.Padding = New System.Drawing.Point(60, 25)
        Me.Productos.SelectedIndex = 0
        Me.Productos.Size = New System.Drawing.Size(1366, 668)
        Me.Productos.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.Productos.TabIndex = 4
        Me.Productos.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvProductos)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage1.Location = New System.Drawing.Point(4, 76)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1358, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editar Producto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(0, 273)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(1358, 263)
        Me.dgvProductos.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RBcat)
        Me.Panel2.Controls.Add(Me.TNombre2)
        Me.Panel2.Controls.Add(Me.RBnombre)
        Me.Panel2.Controls.Add(Me.RBcodigo)
        Me.Panel2.Controls.Add(Me.TCodigo)
        Me.Panel2.Controls.Add(Me.BModificar)
        Me.Panel2.Controls.Add(Me.BEliminar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BBuscar)
        Me.Panel2.Controls.Add(Me.ComboCat)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(-4, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 266)
        Me.Panel2.TabIndex = 7
        '
        'RBcat
        '
        Me.RBcat.AutoSize = True
        Me.RBcat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBcat.Location = New System.Drawing.Point(890, 67)
        Me.RBcat.Name = "RBcat"
        Me.RBcat.Size = New System.Drawing.Size(197, 24)
        Me.RBcat.TabIndex = 40
        Me.RBcat.TabStop = True
        Me.RBcat.Text = "Buscar por Categoria"
        Me.RBcat.UseVisualStyleBackColor = True
        '
        'TNombre2
        '
        Me.TNombre2.Enabled = False
        Me.TNombre2.Location = New System.Drawing.Point(632, 65)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(229, 26)
        Me.TNombre2.TabIndex = 38
        '
        'RBnombre
        '
        Me.RBnombre.AutoSize = True
        Me.RBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBnombre.Location = New System.Drawing.Point(445, 65)
        Me.RBnombre.Name = "RBnombre"
        Me.RBnombre.Size = New System.Drawing.Size(181, 24)
        Me.RBnombre.TabIndex = 37
        Me.RBnombre.TabStop = True
        Me.RBnombre.Text = "Buscar por Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBnombre.UseVisualStyleBackColor = True
        '
        'RBcodigo
        '
        Me.RBcodigo.AutoSize = True
        Me.RBcodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBcodigo.Location = New System.Drawing.Point(17, 65)
        Me.RBcodigo.Name = "RBcodigo"
        Me.RBcodigo.Size = New System.Drawing.Size(175, 24)
        Me.RBcodigo.TabIndex = 36
        Me.RBcodigo.TabStop = True
        Me.RBcodigo.Text = "Buscar por Codigo"
        Me.RBcodigo.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Enabled = False
        Me.TCodigo.Location = New System.Drawing.Point(198, 64)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(228, 26)
        Me.TCodigo.TabIndex = 35
        '
        'BModificar
        '
        Me.BModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BModificar.Enabled = False
        Me.BModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificar.Location = New System.Drawing.Point(1071, 174)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(120, 46)
        Me.BModificar.TabIndex = 31
        Me.BModificar.Text = "Modificar"
        Me.BModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BEliminar.Enabled = False
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BEliminar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(889, 174)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(120, 46)
        Me.BEliminar.TabIndex = 30
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(597, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Lista de Productos"
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar2
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(611, 157)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(120, 44)
        Me.BBuscar.TabIndex = 28
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'ComboCat
        '
        Me.ComboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCat.FormattingEnabled = True
        Me.ComboCat.Location = New System.Drawing.Point(1093, 65)
        Me.ComboCat.Name = "ComboCat"
        Me.ComboCat.Size = New System.Drawing.Size(257, 28)
        Me.ComboCat.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(611, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TStockMin)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.BCancelar)
        Me.TabPage2.Controls.Add(Me.BConfirmar)
        Me.TabPage2.Controls.Add(Me.CBcategoria)
        Me.TabPage2.Controls.Add(Me.TStock)
        Me.TabPage2.Controls.Add(Me.TPrecioProd)
        Me.TabPage2.Controls.Add(Me.TCodigoProd)
        Me.TabPage2.Controls.Add(Me.TDescripcion)
        Me.TabPage2.Controls.Add(Me.TNombreProd)
        Me.TabPage2.Controls.Add(Me.LDatos)
        Me.TabPage2.Controls.Add(Me.LPrecio)
        Me.TabPage2.Controls.Add(Me.LCategoria)
        Me.TabPage2.Controls.Add(Me.LStock)
        Me.TabPage2.Controls.Add(Me.LCodigo)
        Me.TabPage2.Controls.Add(Me.LDescripcion)
        Me.TabPage2.Controls.Add(Me.LNombre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 76)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1358, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registrar Producto"
        '
        'TStockMin
        '
        Me.TStockMin.Location = New System.Drawing.Point(539, 293)
        Me.TStockMin.Name = "TStockMin"
        Me.TStockMin.Size = New System.Drawing.Size(388, 26)
        Me.TStockMin.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(363, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Stock Minimo"
        '
        'BCancelar
        '
        Me.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(550, 477)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(136, 46)
        Me.BCancelar.TabIndex = 30
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.Location = New System.Drawing.Point(759, 477)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(136, 46)
        Me.BConfirmar.TabIndex = 29
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'CBcategoria
        '
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CBcategoria.Location = New System.Drawing.Point(539, 410)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(388, 28)
        Me.CBcategoria.TabIndex = 12
        '
        'TStock
        '
        Me.TStock.Location = New System.Drawing.Point(539, 354)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(388, 26)
        Me.TStock.TabIndex = 11
        '
        'TPrecioProd
        '
        Me.TPrecioProd.Location = New System.Drawing.Point(539, 236)
        Me.TPrecioProd.Name = "TPrecioProd"
        Me.TPrecioProd.Size = New System.Drawing.Size(388, 26)
        Me.TPrecioProd.TabIndex = 10
        '
        'TCodigoProd
        '
        Me.TCodigoProd.Location = New System.Drawing.Point(539, 179)
        Me.TCodigoProd.Name = "TCodigoProd"
        Me.TCodigoProd.Size = New System.Drawing.Size(388, 26)
        Me.TCodigoProd.TabIndex = 9
        '
        'TDescripcion
        '
        Me.TDescripcion.Location = New System.Drawing.Point(539, 119)
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(388, 26)
        Me.TDescripcion.TabIndex = 8
        '
        'TNombreProd
        '
        Me.TNombreProd.Location = New System.Drawing.Point(539, 62)
        Me.TNombreProd.Name = "TNombreProd"
        Me.TNombreProd.Size = New System.Drawing.Size(388, 26)
        Me.TNombreProd.TabIndex = 7
        '
        'LDatos
        '
        Me.LDatos.AutoSize = True
        Me.LDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDatos.Location = New System.Drawing.Point(664, 22)
        Me.LDatos.Name = "LDatos"
        Me.LDatos.Size = New System.Drawing.Size(134, 20)
        Me.LDatos.TabIndex = 6
        Me.LDatos.Text = "Datos Producto"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LPrecio.Location = New System.Drawing.Point(374, 244)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(59, 20)
        Me.LPrecio.TabIndex = 5
        Me.LPrecio.Text = "Precio"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCategoria.Location = New System.Drawing.Point(365, 413)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(87, 20)
        Me.LCategoria.TabIndex = 4
        Me.LCategoria.Text = "Categoria"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LStock.Location = New System.Drawing.Point(376, 357)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(55, 20)
        Me.LStock.TabIndex = 3
        Me.LStock.Text = "Stock"
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCodigo.Location = New System.Drawing.Point(376, 182)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(65, 20)
        Me.LCodigo.TabIndex = 2
        Me.LCodigo.Text = "Codigo"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDescripcion.Location = New System.Drawing.Point(376, 122)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(103, 20)
        Me.LDescripcion.TabIndex = 1
        Me.LDescripcion.Text = "Descripción"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(376, 68)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(76, 20)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.dgvCategoria)
        Me.TabPage3.Controls.Add(Me.BCancelarcat)
        Me.TabPage3.Controls.Add(Me.BConfirmarCat)
        Me.TabPage3.Controls.Add(Me.TDesc)
        Me.TabPage3.Controls.Add(Me.LDatoscat)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 76)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1358, 588)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registrar Categoria"
        '
        'dgvCategoria
        '
        Me.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategoria.BackgroundColor = System.Drawing.Color.Navy
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoria.Location = New System.Drawing.Point(0, 346)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.Size = New System.Drawing.Size(1362, 195)
        Me.dgvCategoria.TabIndex = 33
        '
        'BCancelarcat
        '
        Me.BCancelarcat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCancelarcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarcat.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BCancelarcat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelarcat.Location = New System.Drawing.Point(556, 231)
        Me.BCancelarcat.Name = "BCancelarcat"
        Me.BCancelarcat.Size = New System.Drawing.Size(136, 46)
        Me.BCancelarcat.TabIndex = 32
        Me.BCancelarcat.Text = "Cancelar"
        Me.BCancelarcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarcat.UseVisualStyleBackColor = True
        '
        'BConfirmarCat
        '
        Me.BConfirmarCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BConfirmarCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmarCat.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BConfirmarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmarCat.Location = New System.Drawing.Point(765, 231)
        Me.BConfirmarCat.Name = "BConfirmarCat"
        Me.BConfirmarCat.Size = New System.Drawing.Size(136, 46)
        Me.BConfirmarCat.TabIndex = 31
        Me.BConfirmarCat.Text = "Confirmar"
        Me.BConfirmarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmarCat.UseVisualStyleBackColor = True
        '
        'TDesc
        '
        Me.TDesc.Location = New System.Drawing.Point(546, 159)
        Me.TDesc.Name = "TDesc"
        Me.TDesc.Size = New System.Drawing.Size(388, 26)
        Me.TDesc.TabIndex = 13
        '
        'LDatoscat
        '
        Me.LDatoscat.AutoSize = True
        Me.LDatoscat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDatoscat.ForeColor = System.Drawing.Color.White
        Me.LDatoscat.Location = New System.Drawing.Point(617, 65)
        Me.LDatoscat.Name = "LDatoscat"
        Me.LDatoscat.Size = New System.Drawing.Size(201, 29)
        Me.LDatoscat.TabIndex = 11
        Me.LDatoscat.Text = "Datos Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(383, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1362, 73)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Gestión de Productos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "<---Volver al menú principal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GestionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 687)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Productos)
        Me.KeyPreview = True
        Me.Name = "GestionProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Productos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Productos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboCat As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents LPrecio As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LCodigo As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TStock As TextBox
    Friend WithEvents TPrecioProd As TextBox
    Friend WithEvents TCodigoProd As TextBox
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents TNombreProd As TextBox
    Friend WithEvents LDatos As Label
    Friend WithEvents CBcategoria As ComboBox
    Friend WithEvents BConfirmar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TDesc As TextBox
    Friend WithEvents LDatoscat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BCancelarcat As Button
    Friend WithEvents BConfirmarCat As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents TStockMin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents RBcat As RadioButton
    Friend WithEvents TNombre2 As TextBox
    Friend WithEvents RBnombre As RadioButton
    Friend WithEvents RBcodigo As RadioButton
    Friend WithEvents TCodigo As TextBox
End Class
