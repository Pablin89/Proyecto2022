﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCajeros
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
        Me.TabGestionarCajeros = New System.Windows.Forms.TabControl()
        Me.TabAgregarCajero = New System.Windows.Forms.TabPage()
        Me.TabEditarCajeros = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.CBcorreo = New System.Windows.Forms.CheckBox()
        Me.CBdni = New System.Windows.Forms.CheckBox()
        Me.CBnombre = New System.Windows.Forms.CheckBox()
        Me.CBapellido = New System.Windows.Forms.CheckBox()
        Me.TabEliminarCajeros = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabGestionarCajeros.SuspendLayout()
        Me.TabEditarCajeros.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGestionarCajeros
        '
        Me.TabGestionarCajeros.Controls.Add(Me.TabAgregarCajero)
        Me.TabGestionarCajeros.Controls.Add(Me.TabEditarCajeros)
        Me.TabGestionarCajeros.Controls.Add(Me.TabEliminarCajeros)
        Me.TabGestionarCajeros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabGestionarCajeros.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabGestionarCajeros.Location = New System.Drawing.Point(0, 57)
        Me.TabGestionarCajeros.Name = "TabGestionarCajeros"
        Me.TabGestionarCajeros.Padding = New System.Drawing.Point(20, 15)
        Me.TabGestionarCajeros.SelectedIndex = 0
        Me.TabGestionarCajeros.Size = New System.Drawing.Size(1087, 649)
        Me.TabGestionarCajeros.TabIndex = 0
        '
        'TabAgregarCajero
        '
        Me.TabAgregarCajero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabAgregarCajero.Location = New System.Drawing.Point(4, 51)
        Me.TabAgregarCajero.Name = "TabAgregarCajero"
        Me.TabAgregarCajero.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAgregarCajero.Size = New System.Drawing.Size(1079, 651)
        Me.TabAgregarCajero.TabIndex = 0
        Me.TabAgregarCajero.Text = "Agregar Cajeros"
        '
        'TabEditarCajeros
        '
        Me.TabEditarCajeros.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabEditarCajeros.Controls.Add(Me.LinkLabel1)
        Me.TabEditarCajeros.Controls.Add(Me.Panel2)
        Me.TabEditarCajeros.Location = New System.Drawing.Point(4, 51)
        Me.TabEditarCajeros.Name = "TabEditarCajeros"
        Me.TabEditarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEditarCajeros.Size = New System.Drawing.Size(1079, 594)
        Me.TabEditarCajeros.TabIndex = 1
        Me.TabEditarCajeros.Text = "Editar Cajeros"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Dni, Me.Fecha, Me.Genero, Me.Correo, Me.Telefono, Me.Direccion, Me.Estado, Me.Imagen, Me.Modificar, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1068, 116)
        Me.DataGridView1.TabIndex = 6
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Dni
        '
        Me.Dni.HeaderText = "DNI"
        Me.Dni.Name = "Dni"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha de Nacimiento"
        Me.Fecha.Name = "Fecha"
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo Electronico"
        Me.Correo.Name = "Correo"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Imagen
        '
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TCorreo)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.TNombre)
        Me.Panel2.Controls.Add(Me.TApellido)
        Me.Panel2.Controls.Add(Me.CBcorreo)
        Me.Panel2.Controls.Add(Me.CBdni)
        Me.Panel2.Controls.Add(Me.CBnombre)
        Me.Panel2.Controls.Add(Me.CBapellido)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1073, 588)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(806, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TCorreo
        '
        Me.TCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TCorreo.Enabled = False
        Me.TCorreo.Location = New System.Drawing.Point(376, 248)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(535, 26)
        Me.TCorreo.TabIndex = 7
        '
        'TDni
        '
        Me.TDni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(376, 172)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(535, 26)
        Me.TDni.TabIndex = 6
        '
        'TNombre
        '
        Me.TNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombre.Enabled = False
        Me.TNombre.Location = New System.Drawing.Point(376, 98)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(535, 26)
        Me.TNombre.TabIndex = 5
        '
        'TApellido
        '
        Me.TApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellido.Enabled = False
        Me.TApellido.Location = New System.Drawing.Point(376, 26)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(535, 26)
        Me.TApellido.TabIndex = 4
        '
        'CBcorreo
        '
        Me.CBcorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBcorreo.AutoSize = True
        Me.CBcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBcorreo.Location = New System.Drawing.Point(159, 248)
        Me.CBcorreo.Name = "CBcorreo"
        Me.CBcorreo.Size = New System.Drawing.Size(154, 24)
        Me.CBcorreo.TabIndex = 3
        Me.CBcorreo.Text = "Buscar por correo"
        Me.CBcorreo.UseVisualStyleBackColor = True
        '
        'CBdni
        '
        Me.CBdni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBdni.AutoSize = True
        Me.CBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBdni.Location = New System.Drawing.Point(159, 172)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(137, 24)
        Me.CBdni.TabIndex = 2
        Me.CBdni.Text = "Buscar por DNI"
        Me.CBdni.UseVisualStyleBackColor = True
        '
        'CBnombre
        '
        Me.CBnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBnombre.AutoSize = True
        Me.CBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBnombre.Location = New System.Drawing.Point(159, 98)
        Me.CBnombre.Name = "CBnombre"
        Me.CBnombre.Size = New System.Drawing.Size(165, 24)
        Me.CBnombre.TabIndex = 1
        Me.CBnombre.Text = "Buscar por Nombre"
        Me.CBnombre.UseVisualStyleBackColor = True
        '
        'CBapellido
        '
        Me.CBapellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBapellido.AutoSize = True
        Me.CBapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBapellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBapellido.Location = New System.Drawing.Point(159, 26)
        Me.CBapellido.Name = "CBapellido"
        Me.CBapellido.Size = New System.Drawing.Size(165, 24)
        Me.CBapellido.TabIndex = 0
        Me.CBapellido.Text = "Buscar por Apellido"
        Me.CBapellido.UseVisualStyleBackColor = True
        '
        'TabEliminarCajeros
        '
        Me.TabEliminarCajeros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabEliminarCajeros.Location = New System.Drawing.Point(4, 51)
        Me.TabEliminarCajeros.Name = "TabEliminarCajeros"
        Me.TabEliminarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEliminarCajeros.Size = New System.Drawing.Size(1038, 501)
        Me.TabEliminarCajeros.TabIndex = 2
        Me.TabEliminarCajeros.Text = "Eliminar Cajeros"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabGestionarCajeros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 706)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(1087, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestión de Cajeros"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Himalaya", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 567)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(168, 24)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Volver al Menú principal"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GestionarCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1087, 706)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GestionarCajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Cajeros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabGestionarCajeros.ResumeLayout(False)
        Me.TabEditarCajeros.ResumeLayout(False)
        Me.TabEditarCajeros.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGestionarCajeros As TabControl
    Friend WithEvents TabAgregarCajero As TabPage
    Friend WithEvents TabEditarCajeros As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabEliminarCajeros As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents CBcorreo As CheckBox
    Friend WithEvents CBdni As CheckBox
    Friend WithEvents CBnombre As CheckBox
    Friend WithEvents CBapellido As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Dni As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class
