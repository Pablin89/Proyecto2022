<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridClientes
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
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RBnombre = New System.Windows.Forms.RadioButton()
        Me.RBapellido = New System.Windows.Forms.RadioButton()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.RBdni = New System.Windows.Forms.RadioButton()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCliente.BackgroundColor = System.Drawing.Color.Navy
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(4, 119)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(971, 350)
        Me.dgvCliente.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(835, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RBnombre
        '
        Me.RBnombre.AutoSize = True
        Me.RBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBnombre.Location = New System.Drawing.Point(60, 71)
        Me.RBnombre.Name = "RBnombre"
        Me.RBnombre.Size = New System.Drawing.Size(160, 20)
        Me.RBnombre.TabIndex = 19
        Me.RBnombre.TabStop = True
        Me.RBnombre.Text = "Buscar por Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBnombre.UseVisualStyleBackColor = True
        '
        'RBapellido
        '
        Me.RBapellido.AutoSize = True
        Me.RBapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBapellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBapellido.Location = New System.Drawing.Point(60, 24)
        Me.RBapellido.Name = "RBapellido"
        Me.RBapellido.Size = New System.Drawing.Size(163, 20)
        Me.RBapellido.TabIndex = 18
        Me.RBapellido.TabStop = True
        Me.RBapellido.Text = "Buscar por Apellido"
        Me.RBapellido.UseVisualStyleBackColor = True
        '
        'TNombre
        '
        Me.TNombre.Enabled = False
        Me.TNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre.Location = New System.Drawing.Point(229, 72)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(201, 22)
        Me.TNombre.TabIndex = 17
        '
        'TApellido
        '
        Me.TApellido.Enabled = False
        Me.TApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TApellido.Location = New System.Drawing.Point(229, 23)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(201, 22)
        Me.TApellido.TabIndex = 16
        '
        'RBdni
        '
        Me.RBdni.AutoSize = True
        Me.RBdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBdni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBdni.Location = New System.Drawing.Point(526, 25)
        Me.RBdni.Name = "RBdni"
        Me.RBdni.Size = New System.Drawing.Size(131, 20)
        Me.RBdni.TabIndex = 21
        Me.RBdni.TabStop = True
        Me.RBdni.Text = "Buscar por DNI"
        Me.RBdni.UseVisualStyleBackColor = True
        '
        'TDni
        '
        Me.TDni.Enabled = False
        Me.TDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDni.Location = New System.Drawing.Point(681, 23)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(207, 22)
        Me.TDni.TabIndex = 20
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(722, 69)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(119, 44)
        Me.BBuscar.TabIndex = 22
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 34)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Registrar Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GridClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(977, 530)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.RBdni)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.RBnombre)
        Me.Controls.Add(Me.RBapellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvCliente)
        Me.Name = "GridClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCliente As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents RBnombre As RadioButton
    Friend WithEvents RBapellido As RadioButton
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents RBdni As RadioButton
    Friend WithEvents TDni As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents Button2 As Button
End Class
