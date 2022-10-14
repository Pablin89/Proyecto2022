<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModificarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.MTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RBfemenino = New System.Windows.Forms.RadioButton()
        Me.RBmasculino = New System.Windows.Forms.RadioButton()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TCorreo2 = New System.Windows.Forms.TextBox()
        Me.TDni2 = New System.Windows.Forms.TextBox()
        Me.TNombre2 = New System.Windows.Forms.TextBox()
        Me.TApellido2 = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LGenero = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.ErrorCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(1334, 73)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Modificar datos del Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificar.Location = New System.Drawing.Point(802, 515)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(131, 44)
        Me.BModificar.TabIndex = 65
        Me.BModificar.Text = "Modificar"
        Me.BModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'MTelefono
        '
        Me.MTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTelefono.Location = New System.Drawing.Point(586, 365)
        Me.MTelefono.Mask = "(999)000-0000"
        Me.MTelefono.Name = "MTelefono"
        Me.MTelefono.Size = New System.Drawing.Size(338, 22)
        Me.MTelefono.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(665, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Datos Personales"
        '
        'RBfemenino
        '
        Me.RBfemenino.AutoSize = True
        Me.RBfemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfemenino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBfemenino.Location = New System.Drawing.Point(835, 454)
        Me.RBfemenino.Name = "RBfemenino"
        Me.RBfemenino.Size = New System.Drawing.Size(98, 24)
        Me.RBfemenino.TabIndex = 62
        Me.RBfemenino.TabStop = True
        Me.RBfemenino.Text = "Femenino"
        Me.RBfemenino.UseVisualStyleBackColor = True
        '
        'RBmasculino
        '
        Me.RBmasculino.AutoSize = True
        Me.RBmasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmasculino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBmasculino.Location = New System.Drawing.Point(586, 458)
        Me.RBmasculino.Name = "RBmasculino"
        Me.RBmasculino.Size = New System.Drawing.Size(98, 24)
        Me.RBmasculino.TabIndex = 61
        Me.RBmasculino.TabStop = True
        Me.RBmasculino.Text = "Masculino"
        Me.RBmasculino.UseVisualStyleBackColor = True
        '
        'TDireccion
        '
        Me.TDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDireccion.Location = New System.Drawing.Point(586, 409)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(338, 22)
        Me.TDireccion.TabIndex = 60
        '
        'TCorreo2
        '
        Me.TCorreo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCorreo2.Location = New System.Drawing.Point(586, 321)
        Me.TCorreo2.Name = "TCorreo2"
        Me.TCorreo2.Size = New System.Drawing.Size(338, 22)
        Me.TCorreo2.TabIndex = 59
        '
        'TDni2
        '
        Me.TDni2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni2.Location = New System.Drawing.Point(586, 278)
        Me.TDni2.Name = "TDni2"
        Me.TDni2.Size = New System.Drawing.Size(338, 22)
        Me.TDni2.TabIndex = 58
        '
        'TNombre2
        '
        Me.TNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre2.Location = New System.Drawing.Point(586, 230)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(338, 22)
        Me.TNombre2.TabIndex = 57
        '
        'TApellido2
        '
        Me.TApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido2.Location = New System.Drawing.Point(586, 182)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(338, 22)
        Me.TApellido2.TabIndex = 56
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDireccion.Location = New System.Drawing.Point(403, 415)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LDireccion.TabIndex = 55
        Me.LDireccion.Text = "Dirección"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTelefono.Location = New System.Drawing.Point(403, 368)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 54
        Me.LTelefono.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(403, 321)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(158, 20)
        Me.LCorreo.TabIndex = 53
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGenero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LGenero.Location = New System.Drawing.Point(403, 458)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(74, 20)
        Me.LGenero.TabIndex = 52
        Me.LGenero.Text = "Género:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDni.Location = New System.Drawing.Point(403, 278)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 20)
        Me.LDni.TabIndex = 51
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(403, 236)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(71, 20)
        Me.LNombre.TabIndex = 50
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LApellido.Location = New System.Drawing.Point(401, 188)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 49
        Me.LApellido.Text = "Apellido"
        '
        'ErrorCorreo
        '
        Me.ErrorCorreo.ContainerControl = Me
        '
        'ModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1334, 661)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.MTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RBfemenino)
        Me.Controls.Add(Me.RBmasculino)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TCorreo2)
        Me.Controls.Add(Me.TDni2)
        Me.Controls.Add(Me.TNombre2)
        Me.Controls.Add(Me.TApellido2)
        Me.Controls.Add(Me.LDireccion)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LGenero)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "ModificarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents MTelefono As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RBfemenino As RadioButton
    Friend WithEvents RBmasculino As RadioButton
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TCorreo2 As TextBox
    Friend WithEvents TDni2 As TextBox
    Friend WithEvents TNombre2 As TextBox
    Friend WithEvents TApellido2 As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents LGenero As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents ErrorCorreo As ErrorProvider
End Class
