<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIAgregarCliente
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.MTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RBfemenino = New System.Windows.Forms.RadioButton()
        Me.RBmasculino = New System.Windows.Forms.RadioButton()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TCorreo = New System.Windows.Forms.TextBox()
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
        Me.ErrorCorreo2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCorreo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCancelar
        '
        Me.BCancelar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(329, 466)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(131, 44)
        Me.BCancelar.TabIndex = 67
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BConfirmar
        '
        Me.BConfirmar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.Location = New System.Drawing.Point(545, 466)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(131, 44)
        Me.BConfirmar.TabIndex = 66
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'MTelefono
        '
        Me.MTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MTelefono.Location = New System.Drawing.Point(329, 310)
        Me.MTelefono.Mask = "(999)000-0000"
        Me.MTelefono.Name = "MTelefono"
        Me.MTelefono.Size = New System.Drawing.Size(338, 20)
        Me.MTelefono.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(408, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Datos Personales"
        '
        'RBfemenino
        '
        Me.RBfemenino.AutoSize = True
        Me.RBfemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfemenino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBfemenino.Location = New System.Drawing.Point(578, 399)
        Me.RBfemenino.Name = "RBfemenino"
        Me.RBfemenino.Size = New System.Drawing.Size(98, 24)
        Me.RBfemenino.TabIndex = 63
        Me.RBfemenino.TabStop = True
        Me.RBfemenino.Text = "Femenino"
        Me.RBfemenino.UseVisualStyleBackColor = True
        '
        'RBmasculino
        '
        Me.RBmasculino.AutoSize = True
        Me.RBmasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmasculino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBmasculino.Location = New System.Drawing.Point(329, 403)
        Me.RBmasculino.Name = "RBmasculino"
        Me.RBmasculino.Size = New System.Drawing.Size(98, 24)
        Me.RBmasculino.TabIndex = 62
        Me.RBmasculino.TabStop = True
        Me.RBmasculino.Text = "Masculino"
        Me.RBmasculino.UseVisualStyleBackColor = True
        '
        'TDireccion
        '
        Me.TDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TDireccion.Location = New System.Drawing.Point(329, 354)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(338, 20)
        Me.TDireccion.TabIndex = 61
        '
        'TCorreo
        '
        Me.TCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TCorreo.Location = New System.Drawing.Point(329, 266)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(338, 20)
        Me.TCorreo.TabIndex = 60
        '
        'TDni2
        '
        Me.TDni2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TDni2.Location = New System.Drawing.Point(329, 223)
        Me.TDni2.Name = "TDni2"
        Me.TDni2.Size = New System.Drawing.Size(338, 20)
        Me.TDni2.TabIndex = 59
        '
        'TNombre2
        '
        Me.TNombre2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TNombre2.Location = New System.Drawing.Point(329, 175)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(338, 20)
        Me.TNombre2.TabIndex = 58
        '
        'TApellido2
        '
        Me.TApellido2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TApellido2.Location = New System.Drawing.Point(329, 127)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(338, 20)
        Me.TApellido2.TabIndex = 57
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LDireccion.Location = New System.Drawing.Point(146, 360)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(84, 20)
        Me.LDireccion.TabIndex = 56
        Me.LDireccion.Text = "Dirección"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LTelefono.Location = New System.Drawing.Point(146, 313)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 55
        Me.LTelefono.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LCorreo.Location = New System.Drawing.Point(146, 266)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(158, 20)
        Me.LCorreo.TabIndex = 54
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LGenero
        '
        Me.LGenero.AutoSize = True
        Me.LGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LGenero.Location = New System.Drawing.Point(146, 403)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(74, 20)
        Me.LGenero.TabIndex = 53
        Me.LGenero.Text = "Género:"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LDni.Location = New System.Drawing.Point(146, 223)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(40, 20)
        Me.LDni.TabIndex = 52
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LNombre.Location = New System.Drawing.Point(146, 181)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(71, 20)
        Me.LNombre.TabIndex = 51
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LApellido.Location = New System.Drawing.Point(144, 133)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 50
        Me.LApellido.Text = "Apellido"
        '
        'ErrorCorreo
        '
        Me.ErrorCorreo.ContainerControl = Me
        '
        'ErrorCorreo2
        '
        Me.ErrorCorreo2.ContainerControl = Me
        '
        'MDIAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(820, 557)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConfirmar)
        Me.Controls.Add(Me.MTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RBfemenino)
        Me.Controls.Add(Me.RBmasculino)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TCorreo)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Name = "MDIAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIParent1"
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCorreo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents MTelefono As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RBfemenino As RadioButton
    Friend WithEvents RBmasculino As RadioButton
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TCorreo As TextBox
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
    Friend WithEvents ErrorCorreo2 As ErrorProvider
End Class
