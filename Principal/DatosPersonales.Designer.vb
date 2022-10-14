<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosPersonales
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
        Me.LModificarApellido = New System.Windows.Forms.Label()
        Me.LModificarNombre = New System.Windows.Forms.Label()
        Me.LModificarDni = New System.Windows.Forms.Label()
        Me.LModificarNacimiento = New System.Windows.Forms.Label()
        Me.LModificarCorreo = New System.Windows.Forms.Label()
        Me.BModificarDatos = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TModificarApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBoxGeneros = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TModificarNombres = New System.Windows.Forms.TextBox()
        Me.TModificarDni = New System.Windows.Forms.TextBox()
        Me.TModificarCorreo = New System.Windows.Forms.TextBox()
        Me.LModificarImagen = New System.Windows.Forms.Panel()
        Me.CBModificarDatos = New System.Windows.Forms.CheckBox()
        Me.DateTimeModificar = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDatos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LModificarImagen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LModificarApellido
        '
        Me.LModificarApellido.AutoSize = True
        Me.LModificarApellido.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificarApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LModificarApellido.Location = New System.Drawing.Point(15, 20)
        Me.LModificarApellido.Name = "LModificarApellido"
        Me.LModificarApellido.Size = New System.Drawing.Size(73, 20)
        Me.LModificarApellido.TabIndex = 0
        Me.LModificarApellido.Text = "Apellido"
        '
        'LModificarNombre
        '
        Me.LModificarNombre.AutoSize = True
        Me.LModificarNombre.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificarNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LModificarNombre.Location = New System.Drawing.Point(15, 62)
        Me.LModificarNombre.Name = "LModificarNombre"
        Me.LModificarNombre.Size = New System.Drawing.Size(80, 20)
        Me.LModificarNombre.TabIndex = 1
        Me.LModificarNombre.Text = "Nombres"
        '
        'LModificarDni
        '
        Me.LModificarDni.AutoSize = True
        Me.LModificarDni.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificarDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LModificarDni.Location = New System.Drawing.Point(14, 105)
        Me.LModificarDni.Name = "LModificarDni"
        Me.LModificarDni.Size = New System.Drawing.Size(40, 20)
        Me.LModificarDni.TabIndex = 2
        Me.LModificarDni.Text = "DNI"
        '
        'LModificarNacimiento
        '
        Me.LModificarNacimiento.AutoSize = True
        Me.LModificarNacimiento.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificarNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LModificarNacimiento.Location = New System.Drawing.Point(14, 141)
        Me.LModificarNacimiento.Name = "LModificarNacimiento"
        Me.LModificarNacimiento.Size = New System.Drawing.Size(178, 20)
        Me.LModificarNacimiento.TabIndex = 3
        Me.LModificarNacimiento.Text = "Fecha de Nacimiento"
        '
        'LModificarCorreo
        '
        Me.LModificarCorreo.AutoSize = True
        Me.LModificarCorreo.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificarCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LModificarCorreo.Location = New System.Drawing.Point(14, 185)
        Me.LModificarCorreo.Name = "LModificarCorreo"
        Me.LModificarCorreo.Size = New System.Drawing.Size(156, 20)
        Me.LModificarCorreo.TabIndex = 4
        Me.LModificarCorreo.Text = "Correo electrónico"
        '
        'BModificarDatos
        '
        Me.BModificarDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BModificarDatos.Enabled = False
        Me.BModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarDatos.Location = New System.Drawing.Point(598, 392)
        Me.BModificarDatos.Name = "BModificarDatos"
        Me.BModificarDatos.Size = New System.Drawing.Size(174, 46)
        Me.BModificarDatos.TabIndex = 5
        Me.BModificarDatos.Text = "Guardar Modifiaciones"
        Me.BModificarDatos.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 421)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(137, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "<---Volver al menú"
        '
        'TModificarApellido
        '
        Me.TModificarApellido.Enabled = False
        Me.TModificarApellido.Location = New System.Drawing.Point(198, 20)
        Me.TModificarApellido.Name = "TModificarApellido"
        Me.TModificarApellido.Size = New System.Drawing.Size(200, 20)
        Me.TModificarApellido.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Género"
        '
        'CBoxGeneros
        '
        Me.CBoxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxGeneros.Enabled = False
        Me.CBoxGeneros.FormattingEnabled = True
        Me.CBoxGeneros.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro"})
        Me.CBoxGeneros.Location = New System.Drawing.Point(198, 225)
        Me.CBoxGeneros.Name = "CBoxGeneros"
        Me.CBoxGeneros.Size = New System.Drawing.Size(200, 21)
        Me.CBoxGeneros.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(453, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 211)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TModificarNombres
        '
        Me.TModificarNombres.Enabled = False
        Me.TModificarNombres.Location = New System.Drawing.Point(198, 62)
        Me.TModificarNombres.Name = "TModificarNombres"
        Me.TModificarNombres.Size = New System.Drawing.Size(200, 20)
        Me.TModificarNombres.TabIndex = 12
        '
        'TModificarDni
        '
        Me.TModificarDni.Enabled = False
        Me.TModificarDni.Location = New System.Drawing.Point(198, 105)
        Me.TModificarDni.Name = "TModificarDni"
        Me.TModificarDni.Size = New System.Drawing.Size(200, 20)
        Me.TModificarDni.TabIndex = 13
        '
        'TModificarCorreo
        '
        Me.TModificarCorreo.Enabled = False
        Me.TModificarCorreo.Location = New System.Drawing.Point(198, 185)
        Me.TModificarCorreo.Name = "TModificarCorreo"
        Me.TModificarCorreo.Size = New System.Drawing.Size(200, 20)
        Me.TModificarCorreo.TabIndex = 15
        '
        'LModificarImagen
        '
        Me.LModificarImagen.AutoSize = True
        Me.LModificarImagen.BackColor = System.Drawing.Color.MidnightBlue
        Me.LModificarImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LModificarImagen.Controls.Add(Me.CBModificarDatos)
        Me.LModificarImagen.Controls.Add(Me.Label1)
        Me.LModificarImagen.Controls.Add(Me.DateTimeModificar)
        Me.LModificarImagen.Controls.Add(Me.LModificarApellido)
        Me.LModificarImagen.Controls.Add(Me.LModificarNombre)
        Me.LModificarImagen.Controls.Add(Me.LModificarDni)
        Me.LModificarImagen.Controls.Add(Me.LModificarNacimiento)
        Me.LModificarImagen.Controls.Add(Me.LModificarCorreo)
        Me.LModificarImagen.Controls.Add(Me.Label2)
        Me.LModificarImagen.Controls.Add(Me.TModificarCorreo)
        Me.LModificarImagen.Controls.Add(Me.TModificarDni)
        Me.LModificarImagen.Controls.Add(Me.TModificarNombres)
        Me.LModificarImagen.Controls.Add(Me.CBoxGeneros)
        Me.LModificarImagen.Controls.Add(Me.TModificarApellido)
        Me.LModificarImagen.Controls.Add(Me.PictureBox1)
        Me.LModificarImagen.Location = New System.Drawing.Point(36, 52)
        Me.LModificarImagen.Name = "LModificarImagen"
        Me.LModificarImagen.Size = New System.Drawing.Size(726, 318)
        Me.LModificarImagen.TabIndex = 16
        '
        'CBModificarDatos
        '
        Me.CBModificarDatos.AutoSize = True
        Me.CBModificarDatos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBModificarDatos.ForeColor = System.Drawing.Color.White
        Me.CBModificarDatos.Location = New System.Drawing.Point(296, 273)
        Me.CBModificarDatos.Name = "CBModificarDatos"
        Me.CBModificarDatos.Size = New System.Drawing.Size(161, 23)
        Me.CBModificarDatos.TabIndex = 18
        Me.CBModificarDatos.Text = "Modificar mis datos"
        Me.CBModificarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CBModificarDatos.UseVisualStyleBackColor = True
        '
        'DateTimeModificar
        '
        Me.DateTimeModificar.Enabled = False
        Me.DateTimeModificar.Location = New System.Drawing.Point(198, 141)
        Me.DateTimeModificar.Name = "DateTimeModificar"
        Me.DateTimeModificar.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeModificar.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(519, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Imagen"
        '
        'LDatos
        '
        Me.LDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LDatos.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDatos.Location = New System.Drawing.Point(0, 0)
        Me.LDatos.Name = "LDatos"
        Me.LDatos.Size = New System.Drawing.Size(800, 30)
        Me.LDatos.TabIndex = 17
        Me.LDatos.Text = "Mis Datos"
        Me.LDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.LDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 46)
        Me.Panel1.TabIndex = 18
        '
        'MisDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BModificarDatos)
        Me.Controls.Add(Me.LModificarImagen)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MisDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mis Datos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LModificarImagen.ResumeLayout(False)
        Me.LModificarImagen.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LModificarApellido As Label
    Friend WithEvents LModificarNombre As Label
    Friend WithEvents LModificarDni As Label
    Friend WithEvents LModificarNacimiento As Label
    Friend WithEvents LModificarCorreo As Label
    Friend WithEvents BModificarDatos As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TModificarApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBoxGeneros As ComboBox
    Friend WithEvents TModificarNombres As TextBox
    Friend WithEvents TModificarDni As TextBox
    Friend WithEvents TModificarCorreo As TextBox
    Friend WithEvents LModificarImagen As Panel
    Friend WithEvents DateTimeModificar As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents LDatos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBModificarDatos As CheckBox
End Class
