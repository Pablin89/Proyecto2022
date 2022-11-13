<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermisosUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorContra = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorRepcontra = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BuscarEmpleado = New System.Windows.Forms.TabPage()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.BEditarEmpleado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre2 = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.CBestado = New System.Windows.Forms.CheckBox()
        Me.CBdni = New System.Windows.Forms.CheckBox()
        Me.CBnombre = New System.Windows.Forms.CheckBox()
        Me.CBapellido = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BBuscar = New System.Windows.Forms.Button()
        CType(Me.ErrorContra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorRepcontra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuscarEmpleado.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1354, 73)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Permisos de Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorContra
        '
        Me.ErrorContra.ContainerControl = Me
        '
        'ErrorRepcontra
        '
        Me.ErrorRepcontra.ContainerControl = Me
        '
        'BuscarEmpleado
        '
        Me.BuscarEmpleado.BackColor = System.Drawing.Color.DarkGray
        Me.BuscarEmpleado.Controls.Add(Me.BModificar)
        Me.BuscarEmpleado.Controls.Add(Me.dgvUsuario)
        Me.BuscarEmpleado.Controls.Add(Me.BEditarEmpleado)
        Me.BuscarEmpleado.Controls.Add(Me.Label2)
        Me.BuscarEmpleado.Controls.Add(Me.dgvEmpleados)
        Me.BuscarEmpleado.Controls.Add(Me.ComboEstado)
        Me.BuscarEmpleado.Controls.Add(Me.BBuscar)
        Me.BuscarEmpleado.Controls.Add(Me.TDni)
        Me.BuscarEmpleado.Controls.Add(Me.TNombre2)
        Me.BuscarEmpleado.Controls.Add(Me.TApellido)
        Me.BuscarEmpleado.Controls.Add(Me.CBestado)
        Me.BuscarEmpleado.Controls.Add(Me.CBdni)
        Me.BuscarEmpleado.Controls.Add(Me.CBnombre)
        Me.BuscarEmpleado.Controls.Add(Me.CBapellido)
        Me.BuscarEmpleado.Location = New System.Drawing.Point(4, 76)
        Me.BuscarEmpleado.Name = "BuscarEmpleado"
        Me.BuscarEmpleado.Padding = New System.Windows.Forms.Padding(3)
        Me.BuscarEmpleado.Size = New System.Drawing.Size(1343, 574)
        Me.BuscarEmpleado.TabIndex = 0
        Me.BuscarEmpleado.Text = "Seleccionar Empleado"
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BModificar.Enabled = False
        Me.BModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BModificar.Location = New System.Drawing.Point(956, 156)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(291, 34)
        Me.BModificar.TabIndex = 26
        Me.BModificar.Text = "Editar empleado seleccionado"
        Me.BModificar.UseVisualStyleBackColor = False
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Location = New System.Drawing.Point(736, 231)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.Size = New System.Drawing.Size(601, 337)
        Me.dgvUsuario.TabIndex = 25
        '
        'BEditarEmpleado
        '
        Me.BEditarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BEditarEmpleado.Enabled = False
        Me.BEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEditarEmpleado.Location = New System.Drawing.Point(32, 156)
        Me.BEditarEmpleado.Name = "BEditarEmpleado"
        Me.BEditarEmpleado.Size = New System.Drawing.Size(228, 34)
        Me.BEditarEmpleado.TabIndex = 24
        Me.BEditarEmpleado.Text = "Otrogar Permiso"
        Me.BEditarEmpleado.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(694, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Lista de Empleados"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 232)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(727, 337)
        Me.dgvEmpleados.TabIndex = 22
        '
        'ComboEstado
        '
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.Enabled = False
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"1", "0"})
        Me.ComboEstado.Location = New System.Drawing.Point(886, 88)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(302, 28)
        Me.ComboEstado.TabIndex = 21
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(886, 34)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(303, 26)
        Me.TDni.TabIndex = 19
        '
        'TNombre2
        '
        Me.TNombre2.Enabled = False
        Me.TNombre2.Location = New System.Drawing.Point(321, 90)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(274, 26)
        Me.TNombre2.TabIndex = 18
        '
        'TApellido
        '
        Me.TApellido.Enabled = False
        Me.TApellido.Location = New System.Drawing.Point(321, 34)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(274, 26)
        Me.TApellido.TabIndex = 17
        '
        'CBestado
        '
        Me.CBestado.AutoSize = True
        Me.CBestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBestado.ForeColor = System.Drawing.Color.Black
        Me.CBestado.Location = New System.Drawing.Point(698, 92)
        Me.CBestado.Name = "CBestado"
        Me.CBestado.Size = New System.Drawing.Size(158, 24)
        Me.CBestado.TabIndex = 16
        Me.CBestado.Text = "Buscar por estado"
        Me.CBestado.UseVisualStyleBackColor = True
        '
        'CBdni
        '
        Me.CBdni.AutoSize = True
        Me.CBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdni.ForeColor = System.Drawing.Color.Black
        Me.CBdni.Location = New System.Drawing.Point(698, 36)
        Me.CBdni.Name = "CBdni"
        Me.CBdni.Size = New System.Drawing.Size(137, 24)
        Me.CBdni.TabIndex = 15
        Me.CBdni.Text = "Buscar por DNI"
        Me.CBdni.UseVisualStyleBackColor = True
        '
        'CBnombre
        '
        Me.CBnombre.AutoSize = True
        Me.CBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBnombre.ForeColor = System.Drawing.Color.Black
        Me.CBnombre.Location = New System.Drawing.Point(133, 92)
        Me.CBnombre.Name = "CBnombre"
        Me.CBnombre.Size = New System.Drawing.Size(165, 24)
        Me.CBnombre.TabIndex = 14
        Me.CBnombre.Text = "Buscar por Nombre"
        Me.CBnombre.UseVisualStyleBackColor = True
        '
        'CBapellido
        '
        Me.CBapellido.AutoSize = True
        Me.CBapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBapellido.ForeColor = System.Drawing.Color.Black
        Me.CBapellido.Location = New System.Drawing.Point(133, 36)
        Me.CBapellido.Name = "CBapellido"
        Me.CBapellido.Size = New System.Drawing.Size(165, 24)
        Me.CBapellido.TabIndex = 13
        Me.CBapellido.Text = "Buscar por Apellido"
        Me.CBapellido.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.BuscarEmpleado)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(3, 76)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(60, 25)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1351, 654)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 6
        Me.TabControl1.TabStop = False
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(578, 134)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(120, 46)
        Me.BBuscar.TabIndex = 20
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'PermisosUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PermisosUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos de Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorContra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorRepcontra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuscarEmpleado.ResumeLayout(False)
        Me.BuscarEmpleado.PerformLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorContra As ErrorProvider
    Friend WithEvents ErrorRepcontra As ErrorProvider
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BuscarEmpleado As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BCancelar As Button
    Friend WithEvents BConfirmar As Button
    Friend WithEvents CBperfil As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TRepcontra As TextBox
    Friend WithEvents TContraseña As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre2 As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents CBestado As CheckBox
    Friend WithEvents CBdni As CheckBox
    Friend WithEvents CBnombre As CheckBox
    Friend WithEvents CBapellido As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BEditarEmpleado As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents BModificar As Button
    Friend WithEvents dgvUsuario As DataGridView
End Class
