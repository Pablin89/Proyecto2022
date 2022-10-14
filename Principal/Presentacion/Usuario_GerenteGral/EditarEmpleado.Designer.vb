<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarEmpleado
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
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.CBperfil = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TRepcontra = New System.Windows.Forms.TextBox()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TUsuario
        '
        Me.TUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUsuario.Location = New System.Drawing.Point(428, 178)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(338, 26)
        Me.TUsuario.TabIndex = 84
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LUsuario.Location = New System.Drawing.Point(223, 184)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(160, 20)
        Me.LUsuario.TabIndex = 83
        Me.LUsuario.Text = "Nombre de usuario"
        '
        'CBperfil
        '
        Me.CBperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBperfil.FormattingEnabled = True
        Me.CBperfil.Location = New System.Drawing.Point(428, 388)
        Me.CBperfil.Name = "CBperfil"
        Me.CBperfil.Size = New System.Drawing.Size(338, 28)
        Me.CBperfil.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(362, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 24)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Datos de Inicio Sesión"
        '
        'TRepcontra
        '
        Me.TRepcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRepcontra.Location = New System.Drawing.Point(428, 318)
        Me.TRepcontra.Name = "TRepcontra"
        Me.TRepcontra.Size = New System.Drawing.Size(338, 26)
        Me.TRepcontra.TabIndex = 78
        Me.TRepcontra.UseSystemPasswordChar = True
        '
        'TContraseña
        '
        Me.TContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TContraseña.Location = New System.Drawing.Point(428, 248)
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.Size = New System.Drawing.Size(338, 26)
        Me.TContraseña.TabIndex = 77
        Me.TContraseña.UseSystemPasswordChar = True
        '
        'TDni
        '
        Me.TDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni.Location = New System.Drawing.Point(428, 108)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(338, 26)
        Me.TDni.TabIndex = 76
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(234, 396)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(149, 20)
        Me.LCorreo.TabIndex = 75
        Me.LCorreo.Text = "Seleccionar Perfil"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDni.Location = New System.Drawing.Point(217, 325)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(166, 20)
        Me.LDni.TabIndex = 74
        Me.LDni.Text = "Repetir Contraseña"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(281, 254)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(102, 20)
        Me.LNombre.TabIndex = 73
        Me.LNombre.Text = "Contraseña"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LApellido.Location = New System.Drawing.Point(140, 111)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(243, 20)
        Me.LApellido.TabIndex = 72
        Me.LApellido.Text = "Ingresar el DNI del empleado"
        '
        'BCancelar
        '
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(428, 476)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(131, 44)
        Me.BCancelar.TabIndex = 82
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.Location = New System.Drawing.Point(635, 475)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(131, 44)
        Me.BConfirmar.TabIndex = 81
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'EditarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 546)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.CBperfil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TRepcontra)
        Me.Controls.Add(Me.TContraseña)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EditarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TUsuario As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents CBperfil As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TRepcontra As TextBox
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
End Class
