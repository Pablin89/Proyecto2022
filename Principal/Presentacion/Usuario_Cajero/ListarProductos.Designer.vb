﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarProductos
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
        Me.LLista = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.ComboCat = New System.Windows.Forms.ComboBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.CBcodigo = New System.Windows.Forms.CheckBox()
        Me.TPrecio = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.CBcat = New System.Windows.Forms.CheckBox()
        Me.CBprecio = New System.Windows.Forms.CheckBox()
        Me.CBnombre = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imgaen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLista
        '
        Me.LLista.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.LLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLista.Location = New System.Drawing.Point(0, 0)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(1362, 73)
        Me.LLista.TabIndex = 4
        Me.LLista.Text = "Lista de Productos"
        Me.LLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar2
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(614, 198)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(120, 43)
        Me.BBuscar.TabIndex = 37
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'ComboCat
        '
        Me.ComboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCat.FormattingEnabled = True
        Me.ComboCat.Location = New System.Drawing.Point(907, 157)
        Me.ComboCat.Name = "ComboCat"
        Me.ComboCat.Size = New System.Drawing.Size(287, 21)
        Me.ComboCat.TabIndex = 36
        '
        'TCodigo
        '
        Me.TCodigo.Enabled = False
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(362, 159)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(284, 22)
        Me.TCodigo.TabIndex = 35
        '
        'CBcodigo
        '
        Me.CBcodigo.AutoSize = True
        Me.CBcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBcodigo.Location = New System.Drawing.Point(150, 157)
        Me.CBcodigo.Name = "CBcodigo"
        Me.CBcodigo.Size = New System.Drawing.Size(159, 24)
        Me.CBcodigo.TabIndex = 34
        Me.CBcodigo.Text = "Buscar por Codigo"
        Me.CBcodigo.UseVisualStyleBackColor = True
        '
        'TPrecio
        '
        Me.TPrecio.Enabled = False
        Me.TPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPrecio.Location = New System.Drawing.Point(907, 96)
        Me.TPrecio.Name = "TPrecio"
        Me.TPrecio.Size = New System.Drawing.Size(287, 22)
        Me.TPrecio.TabIndex = 33
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(362, 96)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(284, 22)
        Me.TNombre.TabIndex = 32
        '
        'CBcat
        '
        Me.CBcat.AutoSize = True
        Me.CBcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBcat.Location = New System.Drawing.Point(713, 159)
        Me.CBcat.Name = "CBcat"
        Me.CBcat.Size = New System.Drawing.Size(178, 24)
        Me.CBcat.TabIndex = 31
        Me.CBcat.Text = "Buscar por Categoria"
        Me.CBcat.UseVisualStyleBackColor = True
        '
        'CBprecio
        '
        Me.CBprecio.AutoSize = True
        Me.CBprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBprecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBprecio.Location = New System.Drawing.Point(713, 98)
        Me.CBprecio.Name = "CBprecio"
        Me.CBprecio.Size = New System.Drawing.Size(153, 24)
        Me.CBprecio.TabIndex = 30
        Me.CBprecio.Text = "Buscar por Precio"
        Me.CBprecio.UseVisualStyleBackColor = True
        '
        'CBnombre
        '
        Me.CBnombre.AutoSize = True
        Me.CBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBnombre.Location = New System.Drawing.Point(150, 96)
        Me.CBnombre.Name = "CBnombre"
        Me.CBnombre.Size = New System.Drawing.Size(165, 24)
        Me.CBnombre.TabIndex = 29
        Me.CBnombre.Text = "Buscar por Nombre"
        Me.CBnombre.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(3, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 455)
        Me.Panel1.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Descripcion, Me.Codigo, Me.Precio, Me.Stock, Me.Categoria, Me.Imgaen})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1359, 449)
        Me.DataGridView1.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Imgaen
        '
        Me.Imgaen.HeaderText = "Imagen"
        Me.Imgaen.Name = "Imgaen"
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.ComboCat)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.CBcodigo)
        Me.Controls.Add(Me.TPrecio)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.CBcat)
        Me.Controls.Add(Me.CBprecio)
        Me.Controls.Add(Me.CBnombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LLista)
        Me.KeyPreview = True
        Me.Name = "ListarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LLista As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents ComboCat As ComboBox
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents CBcodigo As CheckBox
    Friend WithEvents TPrecio As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents CBcat As CheckBox
    Friend WithEvents CBprecio As CheckBox
    Friend WithEvents CBnombre As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Imgaen As DataGridViewImageColumn
End Class
