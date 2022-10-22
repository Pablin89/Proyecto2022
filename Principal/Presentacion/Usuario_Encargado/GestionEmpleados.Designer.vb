<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionEmpleados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorFecha = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AgregarCajeros = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.MTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BConfirmar = New System.Windows.Forms.Button()
        Me.CBoxEstado = New System.Windows.Forms.ComboBox()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RBfemenino = New System.Windows.Forms.RadioButton()
        Me.RBmasculino = New System.Windows.Forms.RadioButton()
        Me.DTfecha = New System.Windows.Forms.DateTimePicker()
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
        Me.EditarCajeros = New System.Windows.Forms.TabPage()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.CBestado = New System.Windows.Forms.CheckBox()
        Me.CBdni = New System.Windows.Forms.CheckBox()
        Me.CBnombre = New System.Windows.Forms.CheckBox()
        Me.CBapellido = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LEncargado = New System.Windows.Forms.Label()
        Me.Encargados = New System.Windows.Forms.TabControl()
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgregarCajeros.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditarCajeros.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Encargados.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1354, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gestión de Empleados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorCorreo
        '
        Me.ErrorCorreo.ContainerControl = Me
        '
        'ErrorFecha
        '
        Me.ErrorFecha.ContainerControl = Me
        '
        'AgregarCajeros
        '
        Me.AgregarCajeros.Controls.Add(Me.Panel4)
        Me.AgregarCajeros.Location = New System.Drawing.Point(4, 76)
        Me.AgregarCajeros.Name = "AgregarCajeros"
        Me.AgregarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.AgregarCajeros.Size = New System.Drawing.Size(1362, 620)
        Me.AgregarCajeros.TabIndex = 1
        Me.AgregarCajeros.Text = "Agregar Nuevo Empleado"
        Me.AgregarCajeros.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BCancelar)
        Me.Panel4.Controls.Add(Me.MTelefono)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.BConfirmar)
        Me.Panel4.Controls.Add(Me.CBoxEstado)
        Me.Panel4.Controls.Add(Me.LEstado)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.RBfemenino)
        Me.Panel4.Controls.Add(Me.RBmasculino)
        Me.Panel4.Controls.Add(Me.DTfecha)
        Me.Panel4.Controls.Add(Me.TDireccion)
        Me.Panel4.Controls.Add(Me.TCorreo)
        Me.Panel4.Controls.Add(Me.TDni2)
        Me.Panel4.Controls.Add(Me.TNombre2)
        Me.Panel4.Controls.Add(Me.TApellido2)
        Me.Panel4.Controls.Add(Me.LDireccion)
        Me.Panel4.Controls.Add(Me.LTelefono)
        Me.Panel4.Controls.Add(Me.LCorreo)
        Me.Panel4.Controls.Add(Me.LGenero)
        Me.Panel4.Controls.Add(Me.LFecha)
        Me.Panel4.Controls.Add(Me.LDni)
        Me.Panel4.Controls.Add(Me.LNombre)
        Me.Panel4.Controls.Add(Me.LApellido)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1356, 614)
        Me.Panel4.TabIndex = 25
        '
        'BCancelar
        '
        Me.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(844, 409)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(137, 46)
        Me.BCancelar.TabIndex = 34
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'MTelefono
        '
        Me.MTelefono.Location = New System.Drawing.Point(535, 336)
        Me.MTelefono.Mask = "(999)000-0000"
        Me.MTelefono.Name = "MTelefono"
        Me.MTelefono.Size = New System.Drawing.Size(276, 26)
        Me.MTelefono.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(600, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Datos Personales"
        '
        'BConfirmar
        '
        Me.BConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfirmar.Image = Global.Principal.My.Resources.Resources.iconoguardar__1_
        Me.BConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BConfirmar.Location = New System.Drawing.Point(1017, 409)
        Me.BConfirmar.Name = "BConfirmar"
        Me.BConfirmar.Size = New System.Drawing.Size(137, 46)
        Me.BConfirmar.TabIndex = 26
        Me.BConfirmar.Text = "Confirmar"
        Me.BConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BConfirmar.UseVisualStyleBackColor = True
        '
        'CBoxEstado
        '
        Me.CBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEstado.FormattingEnabled = True
        Me.CBoxEstado.Items.AddRange(New Object() {"1", "0"})
        Me.CBoxEstado.Location = New System.Drawing.Point(535, 426)
        Me.CBoxEstado.Name = "CBoxEstado"
        Me.CBoxEstado.Size = New System.Drawing.Size(276, 28)
        Me.CBoxEstado.TabIndex = 25
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LEstado.Location = New System.Drawing.Point(348, 435)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(66, 20)
        Me.LEstado.TabIndex = 24
        Me.LEstado.Text = "Estado"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(909, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 27)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Añadir Imagen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(844, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'RBfemenino
        '
        Me.RBfemenino.AutoSize = True
        Me.RBfemenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfemenino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBfemenino.Location = New System.Drawing.Point(963, 109)
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
        Me.RBmasculino.Location = New System.Drawing.Point(963, 79)
        Me.RBmasculino.Name = "RBmasculino"
        Me.RBmasculino.Size = New System.Drawing.Size(98, 24)
        Me.RBmasculino.TabIndex = 19
        Me.RBmasculino.TabStop = True
        Me.RBmasculino.Text = "Masculino"
        Me.RBmasculino.UseVisualStyleBackColor = True
        '
        'DTfecha
        '
        Me.DTfecha.Location = New System.Drawing.Point(535, 238)
        Me.DTfecha.Name = "DTfecha"
        Me.DTfecha.Size = New System.Drawing.Size(276, 26)
        Me.DTfecha.TabIndex = 18
        Me.DTfecha.Value = New Date(2022, 9, 30, 0, 0, 0, 0)
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(535, 383)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(276, 26)
        Me.TDireccion.TabIndex = 17
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(535, 289)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(276, 26)
        Me.TCorreo.TabIndex = 13
        '
        'TDni2
        '
        Me.TDni2.Location = New System.Drawing.Point(535, 191)
        Me.TDni2.Name = "TDni2"
        Me.TDni2.Size = New System.Drawing.Size(276, 26)
        Me.TDni2.TabIndex = 12
        '
        'TNombre2
        '
        Me.TNombre2.Location = New System.Drawing.Point(535, 146)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(276, 26)
        Me.TNombre2.TabIndex = 11
        '
        'TApellido2
        '
        Me.TApellido2.Location = New System.Drawing.Point(535, 103)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(276, 26)
        Me.TApellido2.TabIndex = 10
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDireccion.Location = New System.Drawing.Point(348, 386)
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
        Me.LTelefono.Location = New System.Drawing.Point(348, 342)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(79, 20)
        Me.LTelefono.TabIndex = 8
        Me.LTelefono.Text = "Telefono"
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCorreo.Location = New System.Drawing.Point(348, 292)
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
        Me.LGenero.Location = New System.Drawing.Point(866, 81)
        Me.LGenero.Name = "LGenero"
        Me.LGenero.Size = New System.Drawing.Size(74, 20)
        Me.LGenero.TabIndex = 4
        Me.LGenero.Text = "Género:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LFecha.Location = New System.Drawing.Point(348, 241)
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
        Me.LDni.Location = New System.Drawing.Point(348, 194)
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
        Me.LNombre.Location = New System.Drawing.Point(348, 149)
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
        Me.LApellido.Location = New System.Drawing.Point(348, 106)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(73, 20)
        Me.LApellido.TabIndex = 0
        Me.LApellido.Text = "Apellido"
        '
        'EditarCajeros
        '
        Me.EditarCajeros.Controls.Add(Me.dgEmpleados)
        Me.EditarCajeros.Controls.Add(Me.Panel3)
        Me.EditarCajeros.Controls.Add(Me.Panel2)
        Me.EditarCajeros.Location = New System.Drawing.Point(4, 76)
        Me.EditarCajeros.Name = "EditarCajeros"
        Me.EditarCajeros.Padding = New System.Windows.Forms.Padding(3)
        Me.EditarCajeros.Size = New System.Drawing.Size(1362, 620)
        Me.EditarCajeros.TabIndex = 0
        Me.EditarCajeros.Text = "Editar Empleado"
        Me.EditarCajeros.UseVisualStyleBackColor = True
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgEmpleados.Location = New System.Drawing.Point(3, 241)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(1356, 307)
        Me.dgEmpleados.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BModificar)
        Me.Panel3.Controls.Add(Me.BEliminar)
        Me.Panel3.Controls.Add(Me.ComboEstado)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BBuscar)
        Me.Panel3.Controls.Add(Me.TDni)
        Me.Panel3.Controls.Add(Me.TNombre)
        Me.Panel3.Controls.Add(Me.TApellido)
        Me.Panel3.Controls.Add(Me.CBestado)
        Me.Panel3.Controls.Add(Me.CBdni)
        Me.Panel3.Controls.Add(Me.CBnombre)
        Me.Panel3.Controls.Add(Me.CBapellido)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1356, 238)
        Me.Panel3.TabIndex = 9
        '
        'BModificar
        '
        Me.BModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BModificar.Enabled = False
        Me.BModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModificar.Location = New System.Drawing.Point(1071, 151)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(120, 46)
        Me.BModificar.TabIndex = 14
        Me.BModificar.Text = "Modificar"
        Me.BModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BEliminar.Enabled = False
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BEliminar.Image = Global.Principal.My.Resources.Resources.cancelar
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(889, 151)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(120, 46)
        Me.BEliminar.TabIndex = 13
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'ComboEstado
        '
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.Enabled = False
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.ComboEstado.Location = New System.Drawing.Point(889, 92)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(302, 28)
        Me.ComboEstado.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(548, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Lista de Empleados"
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(581, 138)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(120, 46)
        Me.BBuscar.TabIndex = 8
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Location = New System.Drawing.Point(889, 38)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(303, 26)
        Me.TDni.TabIndex = 6
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Location = New System.Drawing.Point(324, 94)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(274, 26)
        Me.TNombre.TabIndex = 5
        '
        'TApellido
        '
        Me.TApellido.Enabled = False
        Me.TApellido.Location = New System.Drawing.Point(324, 38)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(274, 26)
        Me.TApellido.TabIndex = 4
        '
        'CBestado
        '
        Me.CBestado.AutoSize = True
        Me.CBestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBestado.ForeColor = System.Drawing.Color.Black
        Me.CBestado.Location = New System.Drawing.Point(701, 96)
        Me.CBestado.Name = "CBestado"
        Me.CBestado.Size = New System.Drawing.Size(158, 24)
        Me.CBestado.TabIndex = 3
        Me.CBestado.Text = "Buscar por estado"
        Me.CBestado.UseVisualStyleBackColor = True
        '
        'CBdni
        '
        Me.CBdni.AutoSize = True
        Me.CBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBdni.ForeColor = System.Drawing.Color.Black
        Me.CBdni.Location = New System.Drawing.Point(701, 40)
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
        Me.CBnombre.ForeColor = System.Drawing.Color.Black
        Me.CBnombre.Location = New System.Drawing.Point(136, 96)
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
        Me.CBapellido.ForeColor = System.Drawing.Color.Black
        Me.CBapellido.Location = New System.Drawing.Point(136, 40)
        Me.CBapellido.Name = "CBapellido"
        Me.CBapellido.Size = New System.Drawing.Size(165, 24)
        Me.CBapellido.TabIndex = 0
        Me.CBapellido.Text = "Buscar por Apellido"
        Me.CBapellido.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Controls.Add(Me.LEncargado)
        Me.Panel2.Location = New System.Drawing.Point(-526, -189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1244, 48)
        Me.Panel2.TabIndex = 8
        '
        'LEncargado
        '
        Me.LEncargado.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.LEncargado.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEncargado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LEncargado.Location = New System.Drawing.Point(163, 0)
        Me.LEncargado.Name = "LEncargado"
        Me.LEncargado.Size = New System.Drawing.Size(800, 30)
        Me.LEncargado.TabIndex = 17
        Me.LEncargado.Text = "Lista de Encargados"
        Me.LEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Encargados
        '
        Me.Encargados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Encargados.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.Encargados.Controls.Add(Me.EditarCajeros)
        Me.Encargados.Controls.Add(Me.AgregarCajeros)
        Me.Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Encargados.Location = New System.Drawing.Point(-4, 79)
        Me.Encargados.Multiline = True
        Me.Encargados.Name = "Encargados"
        Me.Encargados.Padding = New System.Drawing.Point(60, 25)
        Me.Encargados.SelectedIndex = 0
        Me.Encargados.Size = New System.Drawing.Size(1370, 700)
        Me.Encargados.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.Encargados.TabIndex = 4
        Me.Encargados.TabStop = False
        '
        'GestionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.Encargados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GestionEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgregarCajeros.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditarCajeros.ResumeLayout(False)
        Me.EditarCajeros.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Encargados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorCorreo As ErrorProvider
    Friend WithEvents ErrorFecha As ErrorProvider
    Friend WithEvents Encargados As TabControl
    Friend WithEvents EditarCajeros As TabPage
    Friend WithEvents dgEmpleados As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents CBestado As CheckBox
    Friend WithEvents CBdni As CheckBox
    Friend WithEvents CBnombre As CheckBox
    Friend WithEvents CBapellido As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LEncargado As Label
    Friend WithEvents AgregarCajeros As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BCancelar As Button
    Friend WithEvents MTelefono As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BConfirmar As Button
    Friend WithEvents CBoxEstado As ComboBox
    Friend WithEvents LEstado As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBfemenino As RadioButton
    Friend WithEvents RBmasculino As RadioButton
    Friend WithEvents DTfecha As DateTimePicker
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
    Friend WithEvents BModificar As Button
    Friend WithEvents BEliminar As Button
End Class
