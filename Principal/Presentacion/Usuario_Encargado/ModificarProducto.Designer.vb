<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BAgregarImagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1362, 73)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Modificar datos del Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificar.Location = New System.Drawing.Point(966, 477)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(137, 46)
        Me.BModificar.TabIndex = 48
        Me.BModificar.Text = "Modificar"
        Me.BModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BAgregarImagen
        '
        Me.BAgregarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregarImagen.Location = New System.Drawing.Point(966, 398)
        Me.BAgregarImagen.Name = "BAgregarImagen"
        Me.BAgregarImagen.Size = New System.Drawing.Size(137, 27)
        Me.BAgregarImagen.TabIndex = 47
        Me.BAgregarImagen.Text = "Añadir Imagen"
        Me.BAgregarImagen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(909, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'CBcategoria
        '
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Items.AddRange(New Object() {"Bazar", "Jugueteria", "Regaleria"})
        Me.CBcategoria.Location = New System.Drawing.Point(387, 499)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(388, 24)
        Me.CBcategoria.TabIndex = 45
        '
        'TStock
        '
        Me.TStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStock.Location = New System.Drawing.Point(387, 436)
        Me.TStock.Name = "TStock"
        Me.TStock.Size = New System.Drawing.Size(388, 22)
        Me.TStock.TabIndex = 44
        '
        'TPrecioProd
        '
        Me.TPrecioProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecioProd.Location = New System.Drawing.Point(387, 377)
        Me.TPrecioProd.Name = "TPrecioProd"
        Me.TPrecioProd.Size = New System.Drawing.Size(388, 22)
        Me.TPrecioProd.TabIndex = 43
        '
        'TCodigoProd
        '
        Me.TCodigoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigoProd.Location = New System.Drawing.Point(387, 315)
        Me.TCodigoProd.Name = "TCodigoProd"
        Me.TCodigoProd.Size = New System.Drawing.Size(388, 22)
        Me.TCodigoProd.TabIndex = 42
        '
        'TDescripcion
        '
        Me.TDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDescripcion.Location = New System.Drawing.Point(387, 252)
        Me.TDescripcion.Name = "TDescripcion"
        Me.TDescripcion.Size = New System.Drawing.Size(388, 22)
        Me.TDescripcion.TabIndex = 41
        '
        'TNombreProd
        '
        Me.TNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombreProd.Location = New System.Drawing.Point(387, 191)
        Me.TNombreProd.Name = "TNombreProd"
        Me.TNombreProd.Size = New System.Drawing.Size(388, 22)
        Me.TNombreProd.TabIndex = 40
        '
        'LDatos
        '
        Me.LDatos.AutoSize = True
        Me.LDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDatos.Location = New System.Drawing.Point(513, 134)
        Me.LDatos.Name = "LDatos"
        Me.LDatos.Size = New System.Drawing.Size(134, 20)
        Me.LDatos.TabIndex = 39
        Me.LDatos.Text = "Datos Producto"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LPrecio.Location = New System.Drawing.Point(224, 380)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(59, 20)
        Me.LPrecio.TabIndex = 38
        Me.LPrecio.Text = "Precio"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCategoria.Location = New System.Drawing.Point(224, 500)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(87, 20)
        Me.LCategoria.TabIndex = 37
        Me.LCategoria.Text = "Categoria"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LStock.Location = New System.Drawing.Point(224, 439)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(55, 20)
        Me.LStock.TabIndex = 36
        Me.LStock.Text = "Stock"
        '
        'LCodigo
        '
        Me.LCodigo.AutoSize = True
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCodigo.Location = New System.Drawing.Point(224, 318)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(65, 20)
        Me.LCodigo.TabIndex = 35
        Me.LCodigo.Text = "Codigo"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDescripcion.Location = New System.Drawing.Point(224, 255)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(103, 20)
        Me.LDescripcion.TabIndex = 34
        Me.LDescripcion.Text = "Descripción"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(224, 197)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(76, 20)
        Me.LNombre.TabIndex = 33
        Me.LNombre.Text = "Nombre "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 661)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BAgregarImagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CBcategoria)
        Me.Controls.Add(Me.TStock)
        Me.Controls.Add(Me.TPrecioProd)
        Me.Controls.Add(Me.TCodigoProd)
        Me.Controls.Add(Me.TDescripcion)
        Me.Controls.Add(Me.TNombreProd)
        Me.Controls.Add(Me.LDatos)
        Me.Controls.Add(Me.LPrecio)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.LDescripcion)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "ModificarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarProducto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BAgregarImagen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBcategoria As ComboBox
    Friend WithEvents TStock As TextBox
    Friend WithEvents TPrecioProd As TextBox
    Friend WithEvents TCodigoProd As TextBox
    Friend WithEvents TDescripcion As TextBox
    Friend WithEvents TNombreProd As TextBox
    Friend WithEvents LDatos As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LCodigo As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
