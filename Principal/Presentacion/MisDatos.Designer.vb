<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MisDatos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LDatos = New System.Windows.Forms.Label()
        Me.DTFecha = New System.Windows.Forms.DateTimePicker()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TDni2 = New System.Windows.Forms.TextBox()
        Me.TNombre2 = New System.Windows.Forms.TextBox()
        Me.TApellido2 = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LGenero = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TTelofono = New System.Windows.Forms.TextBox()
        Me.TGenero = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 82)
        Me.Panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(45, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LDatos
        '
        Me.LDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.LDatos.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDatos.Location = New System.Drawing.Point(0, 0)
        Me.LDatos.Name = "LDatos"
        Me.LDatos.Size = New System.Drawing.Size(1354, 100)
        Me.LDatos.TabIndex = 17
        Me.LDatos.Text = "Mis Datos Personales"
        Me.LDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTFecha
        '
        Me.DTFecha.Enabled = False
        Me.DTFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFecha.Location = New System.Drawing.Point(888, 258)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(276, 22)
        Me.DTFecha.TabIndex = 45
        Me.DTFecha.Value = New Date(2022, 10, 13, 18, 9, 42, 0)
        '
        'TDireccion
        '
        Me.TDireccion.Enabled = False
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(888, 498)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(276, 22)
        Me.TDireccion.TabIndex = 44
        '
        'TCorreo
        '
        Me.TCorreo.Enabled = False
        Me.TCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo.Location = New System.Drawing.Point(888, 338)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(276, 22)
        Me.TCorreo.TabIndex = 43
        '
        'TDni2
        '
        Me.TDni2.Enabled = False
        Me.TDni2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni2.Location = New System.Drawing.Point(888, 178)
        Me.TDni2.Name = "TDni2"
        Me.TDni2.Size = New System.Drawing.Size(276, 22)
        Me.TDni2.TabIndex = 42
        '
        'TNombre2
        '
        Me.TNombre2.Enabled = False
        Me.TNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre2.Location = New System.Drawing.Point(342, 578)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(276, 22)
        Me.TNombre2.TabIndex = 41
        '
        'TApellido2
        '
        Me.TApellido2.Enabled = False
        Me.TApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido2.Location = New System.Drawing.Point(342, 495)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(276, 22)
        Me.TApellido2.TabIndex = 40
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDireccion.Location = New System.Drawing.Point(787, 500)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LDireccion.TabIndex = 39
        Me.LDireccion.Text = "Dirección"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTelefono.Location = New System.Drawing.Point(792, 420)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 38
        Me.LTelefono.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(713, 340)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(158, 20)
        Me.LCorreo.TabIndex = 37
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LGenero.Location = New System.Drawing.Point(797, 580)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(74, 20)
        Me.LGenero.TabIndex = 36
        Me.LGenero.Text = "Género:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LFecha.Location = New System.Drawing.Point(693, 260)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(178, 20)
        Me.LFecha.TabIndex = 35
        Me.LFecha.Text = "Fecha de Nacimiento"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDni.Location = New System.Drawing.Point(831, 180)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 20)
        Me.LDni.TabIndex = 34
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(255, 580)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(71, 20)
        Me.LNombre.TabIndex = 33
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LApellido.Location = New System.Drawing.Point(253, 497)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 32
        Me.LApellido.Text = "Apellido"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(277, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TTelofono
        '
        Me.TTelofono.Enabled = False
        Me.TTelofono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTelofono.Location = New System.Drawing.Point(888, 418)
        Me.TTelofono.Name = "TTelofono"
        Me.TTelofono.Size = New System.Drawing.Size(276, 22)
        Me.TTelofono.TabIndex = 57
        '
        'TGenero
        '
        Me.TGenero.Enabled = False
        Me.TGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGenero.Location = New System.Drawing.Point(888, 578)
        Me.TGenero.Name = "TGenero"
        Me.TGenero.Size = New System.Drawing.Size(276, 22)
        Me.TGenero.TabIndex = 56
        '
        'MisDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.TTelofono)
        Me.Controls.Add(Me.TGenero)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TCorreo)
        Me.Controls.Add(Me.TDni2)
        Me.Controls.Add(Me.TNombre2)
        Me.Controls.Add(Me.TApellido2)
        Me.Controls.Add(Me.LDireccion)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LGenero)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MisDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MisDatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LDatos As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTFecha As DateTimePicker
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents TDni2 As TextBox
    Friend WithEvents TNombre2 As TextBox
    Friend WithEvents TApellido2 As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LGenero As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TTelofono As TextBox
    Friend WithEvents TGenero As TextBox
End Class
