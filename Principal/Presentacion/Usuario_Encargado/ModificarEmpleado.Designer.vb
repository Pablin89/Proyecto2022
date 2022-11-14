<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarEmpleado
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.LEstado = New System.Windows.Forms.Label()
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
        Me.RBfemenino = New System.Windows.Forms.RadioButton()
        Me.RBmasculino = New System.Windows.Forms.RadioButton()
        Me.ErrorCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFecha = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1350, 73)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Modificar datos del Empleado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MTelefono
        '
        Me.MTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTelefono.Location = New System.Drawing.Point(570, 414)
        Me.MTelefono.Mask = "(999)000-0000"
        Me.MTelefono.Name = "MTelefono"
        Me.MTelefono.Size = New System.Drawing.Size(276, 22)
        Me.MTelefono.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(635, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Datos Personales"
        '
        'BModificar
        '
        Me.BModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificar.Location = New System.Drawing.Point(639, 603)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(137, 46)
        Me.BModificar.TabIndex = 76
        Me.BModificar.Text = "Modificar"
        Me.BModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'CBEstado
        '
        Me.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"1", "0"})
        Me.CBEstado.Location = New System.Drawing.Point(570, 504)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(276, 24)
        Me.CBEstado.TabIndex = 75
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LEstado.Location = New System.Drawing.Point(383, 508)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(66, 20)
        Me.LEstado.TabIndex = 74
        Me.LEstado.Text = "Estado"
        '
        'DTFecha
        '
        Me.DTFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFecha.Location = New System.Drawing.Point(570, 316)
        Me.DTFecha.Name = "DTFecha"
        Me.DTFecha.Size = New System.Drawing.Size(276, 22)
        Me.DTFecha.TabIndex = 71
        '
        'TDireccion
        '
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(570, 461)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(276, 22)
        Me.TDireccion.TabIndex = 70
        '
        'TCorreo
        '
        Me.TCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo.Location = New System.Drawing.Point(570, 367)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(276, 22)
        Me.TCorreo.TabIndex = 69
        '
        'TDni2
        '
        Me.TDni2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni2.Location = New System.Drawing.Point(570, 269)
        Me.TDni2.Name = "TDni2"
        Me.TDni2.Size = New System.Drawing.Size(276, 22)
        Me.TDni2.TabIndex = 68
        '
        'TNombre2
        '
        Me.TNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre2.Location = New System.Drawing.Point(570, 224)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(276, 22)
        Me.TNombre2.TabIndex = 67
        '
        'TApellido2
        '
        Me.TApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido2.Location = New System.Drawing.Point(570, 181)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(276, 22)
        Me.TApellido2.TabIndex = 66
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDireccion.Location = New System.Drawing.Point(383, 464)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LDireccion.TabIndex = 65
        Me.LDireccion.Text = "Dirección"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTelefono.Location = New System.Drawing.Point(383, 420)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 64
        Me.LTelefono.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(383, 370)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(158, 20)
        Me.LCorreo.TabIndex = 63
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LGenero.Location = New System.Drawing.Point(383, 551)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(74, 20)
        Me.LGenero.TabIndex = 62
        Me.LGenero.Text = "Género:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LFecha.Location = New System.Drawing.Point(383, 319)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(178, 20)
        Me.LFecha.TabIndex = 61
        Me.LFecha.Text = "Fecha de Nacimiento"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDni.Location = New System.Drawing.Point(383, 272)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 20)
        Me.LDni.TabIndex = 60
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(383, 227)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(71, 20)
        Me.LNombre.TabIndex = 59
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LApellido.Location = New System.Drawing.Point(383, 184)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 58
        Me.LApellido.Text = "Apellido"
        '
        'RBfemenino
        '
        Me.RBfemenino.AutoSize = True
        Me.RBfemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfemenino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBfemenino.Location = New System.Drawing.Point(748, 549)
        Me.RBfemenino.Name = "RBfemenino"
        Me.RBfemenino.Size = New System.Drawing.Size(98, 24)
        Me.RBfemenino.TabIndex = 82
        Me.RBfemenino.TabStop = True
        Me.RBfemenino.Text = "Femenino"
        Me.RBfemenino.UseVisualStyleBackColor = True
        '
        'RBmasculino
        '
        Me.RBmasculino.AutoSize = True
        Me.RBmasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmasculino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBmasculino.Location = New System.Drawing.Point(570, 549)
        Me.RBmasculino.Name = "RBmasculino"
        Me.RBmasculino.Size = New System.Drawing.Size(98, 24)
        Me.RBmasculino.TabIndex = 81
        Me.RBmasculino.TabStop = True
        Me.RBmasculino.Text = "Masculino"
        Me.RBmasculino.UseVisualStyleBackColor = True
        '
        'ErrorCorreo
        '
        Me.ErrorCorreo.ContainerControl = Me
        '
        'ErrorFecha
        '
        Me.ErrorFecha.ContainerControl = Me
        '
        'ModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 661)
        Me.Controls.Add(Me.RBfemenino)
        Me.Controls.Add(Me.RBmasculino)
        Me.Controls.Add(Me.MTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.LEstado)
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
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "ModificarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MTelefono As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BModificar As Button
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents LEstado As Label
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
    Friend WithEvents RBfemenino As RadioButton
    Friend WithEvents RBmasculino As RadioButton
    Friend WithEvents ErrorCorreo As ErrorProvider
    Friend WithEvents ErrorFecha As ErrorProvider
End Class
