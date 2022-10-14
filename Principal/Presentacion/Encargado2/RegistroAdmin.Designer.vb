<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CBoxEstado = New System.Windows.Forms.ComboBox()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RBfemenino = New System.Windows.Forms.RadioButton()
        Me.RBmasculino = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TRepcontra = New System.Windows.Forms.TextBox()
        Me.TContra = New System.Windows.Forms.TextBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LRepetir = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LGenero = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.LinkVolver = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Registro Administrador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.TUsuario)
        Me.Panel2.Controls.Add(Me.LUsuario)
        Me.Panel2.Controls.Add(Me.CBoxEstado)
        Me.Panel2.Controls.Add(Me.LEstado)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.RBfemenino)
        Me.Panel2.Controls.Add(Me.RBmasculino)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.TDireccion)
        Me.Panel2.Controls.Add(Me.TTelefono)
        Me.Panel2.Controls.Add(Me.TRepcontra)
        Me.Panel2.Controls.Add(Me.TContra)
        Me.Panel2.Controls.Add(Me.TCorreo)
        Me.Panel2.Controls.Add(Me.TDni)
        Me.Panel2.Controls.Add(Me.TNombre)
        Me.Panel2.Controls.Add(Me.TApellido)
        Me.Panel2.Controls.Add(Me.LDireccion)
        Me.Panel2.Controls.Add(Me.LTelefono)
        Me.Panel2.Controls.Add(Me.LRepetir)
        Me.Panel2.Controls.Add(Me.LContraseña)
        Me.Panel2.Controls.Add(Me.LCorreo)
        Me.Panel2.Controls.Add(Me.LGenero)
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Controls.Add(Me.LDni)
        Me.Panel2.Controls.Add(Me.LNombre)
        Me.Panel2.Controls.Add(Me.LApellido)
        Me.Panel2.Location = New System.Drawing.Point(34, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 493)
        Me.Panel2.TabIndex = 1
        '
        'CBoxEstado
        '
        Me.CBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEstado.FormattingEnabled = True
        Me.CBoxEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBoxEstado.Location = New System.Drawing.Point(216, 450)
        Me.CBoxEstado.Name = "CBoxEstado"
        Me.CBoxEstado.Size = New System.Drawing.Size(284, 21)
        Me.CBoxEstado.TabIndex = 25
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LEstado.Location = New System.Drawing.Point(24, 451)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(66, 20)
        Me.LEstado.TabIndex = 24
        Me.LEstado.Text = "Estado"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(532, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 27)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Añadir Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(532, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'RBfemenino
        '
        Me.RBfemenino.AutoSize = True
        Me.RBfemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfemenino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBfemenino.Location = New System.Drawing.Point(387, 177)
        Me.RBfemenino.Name = "RBfemenino"
        Me.RBfemenino.Size = New System.Drawing.Size(98, 24)
        Me.RBfemenino.TabIndex = 20
        Me.RBfemenino.TabStop = True
        Me.RBfemenino.Text = "Femenino"
        Me.RBfemenino.UseVisualStyleBackColor = True
        '
        'RBmasculino
        '
        Me.RBmasculino.AutoSize = True
        Me.RBmasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmasculino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBmasculino.Location = New System.Drawing.Point(216, 175)
        Me.RBmasculino.Name = "RBmasculino"
        Me.RBmasculino.Size = New System.Drawing.Size(98, 24)
        Me.RBmasculino.TabIndex = 19
        Me.RBmasculino.TabStop = True
        Me.RBmasculino.Text = "Masculino"
        Me.RBmasculino.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(216, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(284, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(216, 414)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(284, 20)
        Me.TDireccion.TabIndex = 17
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(216, 378)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(284, 20)
        Me.TTelefono.TabIndex = 16
        '
        'TRepcontra
        '
        Me.TRepcontra.Location = New System.Drawing.Point(216, 299)
        Me.TRepcontra.Name = "TRepcontra"
        Me.TRepcontra.Size = New System.Drawing.Size(284, 20)
        Me.TRepcontra.TabIndex = 15
        '
        'TContra
        '
        Me.TContra.Location = New System.Drawing.Point(216, 261)
        Me.TContra.Name = "TContra"
        Me.TContra.Size = New System.Drawing.Size(284, 20)
        Me.TContra.TabIndex = 14
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(216, 223)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(284, 20)
        Me.TCorreo.TabIndex = 13
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(216, 104)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(284, 20)
        Me.TDni.TabIndex = 12
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(216, 67)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(284, 20)
        Me.TNombre.TabIndex = 11
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(216, 32)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(284, 20)
        Me.TApellido.TabIndex = 10
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDireccion.Location = New System.Drawing.Point(24, 412)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LDireccion.TabIndex = 9
        Me.LDireccion.Text = "Dirección"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTelefono.Location = New System.Drawing.Point(24, 378)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 8
        Me.LTelefono.Text = "Telefono"
        '
        'LRepetir
        '
        Me.LRepetir.AutoSize = True
        Me.LRepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRepetir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LRepetir.Location = New System.Drawing.Point(24, 299)
        Me.LRepetir.Name = "LRepetir"
        Me.LRepetir.Size = New System.Drawing.Size(166, 20)
        Me.LRepetir.TabIndex = 7
        Me.LRepetir.Text = "Repetir Contraseña"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LContraseña.Location = New System.Drawing.Point(24, 261)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(102, 20)
        Me.LContraseña.TabIndex = 6
        Me.LContraseña.Text = "Contraseña"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(24, 221)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(158, 20)
        Me.LCorreo.TabIndex = 5
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LGenero.Location = New System.Drawing.Point(24, 179)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(69, 20)
        Me.LGenero.TabIndex = 4
        Me.LGenero.Text = "Género"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LFecha.Location = New System.Drawing.Point(24, 143)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(178, 20)
        Me.LFecha.TabIndex = 3
        Me.LFecha.Text = "Fecha de Nacimiento"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDni.Location = New System.Drawing.Point(24, 104)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 20)
        Me.LDni.TabIndex = 2
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(24, 67)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(71, 20)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LApellido.Location = New System.Drawing.Point(24, 32)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'BConfirmar
        '
        Me.BConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmar.Location = New System.Drawing.Point(748, 564)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(174, 46)
        Me.BConfirmar.TabIndex = 23
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'LinkVolver
        '
        Me.LinkVolver.AutoSize = True
        Me.LinkVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkVolver.Location = New System.Drawing.Point(30, 577)
        Me.LinkVolver.Name = "LinkVolver"
        Me.LinkVolver.Size = New System.Drawing.Size(137, 20)
        Me.LinkVolver.TabIndex = 24
        Me.LinkVolver.TabStop = True
        Me.LinkVolver.Text = "<---Volver al menú"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LUsuario.Location = New System.Drawing.Point(24, 339)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(71, 20)
        Me.LUsuario.TabIndex = 26
        Me.LUsuario.Text = "Usuario"
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(216, 339)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(284, 20)
        Me.TUsuario.TabIndex = 27
        '
        'RegistroAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(964, 622)
        Me.Controls.Add(Me.LinkVolver)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "RegistroAdmin"
        Me.Text = "Registro Administrador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LApellido As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LGenero As Label
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LRepetir As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents TRepcontra As TextBox
    Friend WithEvents TContra As TextBox
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents RBfemenino As RadioButton
    Friend WithEvents RBmasculino As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents LinkVolver As LinkLabel
    Friend WithEvents LEstado As Label
    Friend WithEvents CBoxEstado As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents LUsuario As Label
End Class
