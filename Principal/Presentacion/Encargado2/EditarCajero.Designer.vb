<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCajero
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LCajero = New System.Windows.Forms.Label()
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
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TCorreo)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.TNombre)
        Me.Panel2.Controls.Add(Me.TApellido)
        Me.Panel2.Controls.Add(Me.CBcorreo)
        Me.Panel2.Controls.Add(Me.CBdni)
        Me.Panel2.Controls.Add(Me.CBnombre)
        Me.Panel2.Controls.Add(Me.CBapellido)
        Me.Panel2.Location = New System.Drawing.Point(248, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 419)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(611, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TCorreo
        '
        Me.TCorreo.Enabled = False
        Me.TCorreo.Location = New System.Drawing.Point(249, 272)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(412, 20)
        Me.TCorreo.TabIndex = 7
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(249, 196)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(412, 20)
        Me.TDni.TabIndex = 6
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Location = New System.Drawing.Point(249, 122)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(412, 20)
        Me.TNombre.TabIndex = 5
        '
        'TApellido
        '
        Me.TApellido.Enabled = False
        Me.TApellido.Location = New System.Drawing.Point(249, 50)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(412, 20)
        Me.TApellido.TabIndex = 4
        '
        'CBcorreo
        '
        Me.CBcorreo.AutoSize = True
        Me.CBcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBcorreo.Location = New System.Drawing.Point(32, 272)
        Me.CBcorreo.Name = "CBcorreo"
        Me.CBcorreo.Size = New System.Drawing.Size(154, 24)
        Me.CBcorreo.TabIndex = 3
        Me.CBcorreo.Text = "Buscar por correo"
        Me.CBcorreo.UseVisualStyleBackColor = True
        '
        'CBdni
        '
        Me.CBdni.AutoSize = True
        Me.CBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBdni.Location = New System.Drawing.Point(32, 196)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(137, 24)
        Me.CBdni.TabIndex = 2
        Me.CBdni.Text = "Buscar por DNI"
        Me.CBdni.UseVisualStyleBackColor = True
        '
        'CBnombre
        '
        Me.CBnombre.AutoSize = True
        Me.CBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBnombre.Location = New System.Drawing.Point(32, 122)
        Me.CBnombre.Name = "CBnombre"
        Me.CBnombre.Size = New System.Drawing.Size(165, 24)
        Me.CBnombre.TabIndex = 1
        Me.CBnombre.Text = "Buscar por Nombre"
        Me.CBnombre.UseVisualStyleBackColor = True
        '
        'CBapellido
        '
        Me.CBapellido.AutoSize = True
        Me.CBapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBapellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBapellido.Location = New System.Drawing.Point(32, 50)
        Me.CBapellido.Name = "CBapellido"
        Me.CBapellido.Size = New System.Drawing.Size(165, 24)
        Me.CBapellido.TabIndex = 0
        Me.CBapellido.Text = "Buscar por Apellido"
        Me.CBapellido.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.LCajero)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 46)
        Me.Panel1.TabIndex = 3
        '
        'LCajero
        '
        Me.LCajero.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.LCajero.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCajero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LCajero.Location = New System.Drawing.Point(214, 0)
        Me.LCajero.Name = "LCajero"
        Me.LCajero.Size = New System.Drawing.Size(800, 30)
        Me.LCajero.TabIndex = 17
        Me.LCajero.Text = "Editar Cajero"
        Me.LCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Navy
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Dni, Me.Fecha, Me.Genero, Me.Correo, Me.Telefono, Me.Direccion, Me.Estado, Me.Imagen, Me.Modificar, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 488)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1244, 242)
        Me.DataGridView1.TabIndex = 5
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
        'EditarCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 731)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditarCajero"
        Me.Text = "Editar Cajero"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LCajero As Label
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
