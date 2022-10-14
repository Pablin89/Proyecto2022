<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.CBcorreo = New System.Windows.Forms.CheckBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.CBdni = New System.Windows.Forms.CheckBox()
        Me.CBnombre = New System.Windows.Forms.CheckBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.CBapellido = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LEditar = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 393)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 377)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Navy
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Dni, Me.Fecha, Me.Genero, Me.Correo, Me.Telefono, Me.Direccion, Me.Estado, Me.Imagen, Me.Eliminar, Me.Modificar})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1243, 371)
        Me.DataGridView1.TabIndex = 0
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
        Me.Fecha.HeaderText = "Fecha de nacimiento"
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
        Me.Direccion.HeaderText = "Direccion"
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
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.BBuscar)
        Me.Panel2.Controls.Add(Me.TCorreo)
        Me.Panel2.Controls.Add(Me.CBcorreo)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.TNombre)
        Me.Panel2.Controls.Add(Me.CBdni)
        Me.Panel2.Controls.Add(Me.CBnombre)
        Me.Panel2.Controls.Add(Me.TApellido)
        Me.Panel2.Controls.Add(Me.CBapellido)
        Me.Panel2.Location = New System.Drawing.Point(235, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 338)
        Me.Panel2.TabIndex = 1
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Location = New System.Drawing.Point(644, 288)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(125, 31)
        Me.BBuscar.TabIndex = 8
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'TCorreo
        '
        Me.TCorreo.Enabled = False
        Me.TCorreo.Location = New System.Drawing.Point(304, 220)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(407, 20)
        Me.TCorreo.TabIndex = 7
        '
        'CBcorreo
        '
        Me.CBcorreo.AutoSize = True
        Me.CBcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBcorreo.Location = New System.Drawing.Point(41, 220)
        Me.CBcorreo.Name = "CBcorreo"
        Me.CBcorreo.Size = New System.Drawing.Size(157, 24)
        Me.CBcorreo.TabIndex = 6
        Me.CBcorreo.Text = "Buscar por Correo"
        Me.CBcorreo.UseVisualStyleBackColor = True
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(304, 165)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(407, 20)
        Me.TDni.TabIndex = 5
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Location = New System.Drawing.Point(304, 111)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(407, 20)
        Me.TNombre.TabIndex = 4
        '
        'CBdni
        '
        Me.CBdni.AutoSize = True
        Me.CBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBdni.Location = New System.Drawing.Point(41, 165)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(137, 24)
        Me.CBdni.TabIndex = 3
        Me.CBdni.Text = "Buscar por DNI"
        Me.CBdni.UseVisualStyleBackColor = True
        '
        'CBnombre
        '
        Me.CBnombre.AutoSize = True
        Me.CBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBnombre.Location = New System.Drawing.Point(41, 111)
        Me.CBnombre.Name = "CBnombre"
        Me.CBnombre.Size = New System.Drawing.Size(163, 24)
        Me.CBnombre.TabIndex = 2
        Me.CBnombre.Text = "Buscar por nombre"
        Me.CBnombre.UseVisualStyleBackColor = True
        '
        'TApellido
        '
        Me.TApellido.Enabled = False
        Me.TApellido.Location = New System.Drawing.Point(304, 58)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(407, 20)
        Me.TApellido.TabIndex = 1
        '
        'CBapellido
        '
        Me.CBapellido.AutoSize = True
        Me.CBapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBapellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBapellido.Location = New System.Drawing.Point(41, 58)
        Me.CBapellido.Name = "CBapellido"
        Me.CBapellido.Size = New System.Drawing.Size(163, 24)
        Me.CBapellido.TabIndex = 0
        Me.CBapellido.Text = "Buscar por apellido"
        Me.CBapellido.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel3.Controls.Add(Me.LEditar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1260, 46)
        Me.Panel3.TabIndex = 19
        '
        'LEditar
        '
        Me.LEditar.BackColor = System.Drawing.SystemColors.Control
        Me.LEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.LEditar.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEditar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LEditar.Location = New System.Drawing.Point(0, 0)
        Me.LEditar.Name = "LEditar"
        Me.LEditar.Size = New System.Drawing.Size(1260, 30)
        Me.LEditar.TabIndex = 17
        Me.LEditar.Text = "Editar Encargado"
        Me.LEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuscarAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1260, 770)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "BuscarAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TApellido As TextBox
    Friend WithEvents CBapellido As CheckBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents CBdni As CheckBox
    Friend WithEvents CBnombre As CheckBox
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents CBcorreo As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LEditar As Label
    Friend WithEvents BBuscar As Button
End Class
