<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarProductos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LLista = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.RBcat = New System.Windows.Forms.RadioButton()
        Me.TNombre2 = New System.Windows.Forms.TextBox()
        Me.RBnombre = New System.Windows.Forms.RadioButton()
        Me.RBcodigo = New System.Windows.Forms.RadioButton()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.ComboCat = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LLista
        '
        Me.LLista.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.LLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LLista.Location = New System.Drawing.Point(0, 0)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(1362, 73)
        Me.LLista.TabIndex = 4
        Me.LLista.Text = "Lista de Productos"
        Me.LLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBuscar.Image = Global.Principal.My.Resources.Resources.buscar2
        Me.BBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscar.Location = New System.Drawing.Point(617, 215)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(120, 43)
        Me.BBuscar.TabIndex = 37
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvProductos)
        Me.Panel1.Location = New System.Drawing.Point(3, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 455)
        Me.Panel1.TabIndex = 38
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.ColumnHeadersHeight = 40
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductos.Location = New System.Drawing.Point(0, 3)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(1359, 449)
        Me.dgvProductos.TabIndex = 1
        '
        'RBcat
        '
        Me.RBcat.AutoSize = True
        Me.RBcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBcat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBcat.Location = New System.Drawing.Point(887, 143)
        Me.RBcat.Name = "RBcat"
        Me.RBcat.Size = New System.Drawing.Size(187, 22)
        Me.RBcat.TabIndex = 46
        Me.RBcat.TabStop = True
        Me.RBcat.Text = "Buscar por Categoria"
        Me.RBcat.UseVisualStyleBackColor = True
        '
        'TNombre2
        '
        Me.TNombre2.Enabled = False
        Me.TNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNombre2.Location = New System.Drawing.Point(629, 141)
        Me.TNombre2.Name = "TNombre2"
        Me.TNombre2.Size = New System.Drawing.Size(229, 22)
        Me.TNombre2.TabIndex = 45
        '
        'RBnombre
        '
        Me.RBnombre.AutoSize = True
        Me.RBnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBnombre.Location = New System.Drawing.Point(442, 141)
        Me.RBnombre.Name = "RBnombre"
        Me.RBnombre.Size = New System.Drawing.Size(174, 22)
        Me.RBnombre.TabIndex = 44
        Me.RBnombre.TabStop = True
        Me.RBnombre.Text = "Buscar por Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBnombre.UseVisualStyleBackColor = True
        '
        'RBcodigo
        '
        Me.RBcodigo.AutoSize = True
        Me.RBcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBcodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RBcodigo.Location = New System.Drawing.Point(14, 141)
        Me.RBcodigo.Name = "RBcodigo"
        Me.RBcodigo.Size = New System.Drawing.Size(168, 22)
        Me.RBcodigo.TabIndex = 43
        Me.RBcodigo.TabStop = True
        Me.RBcodigo.Text = "Buscar por Codigo"
        Me.RBcodigo.UseVisualStyleBackColor = True
        '
        'TCodigo
        '
        Me.TCodigo.Enabled = False
        Me.TCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCodigo.Location = New System.Drawing.Point(195, 140)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(228, 22)
        Me.TCodigo.TabIndex = 42
        '
        'ComboCat
        '
        Me.ComboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCat.Enabled = False
        Me.ComboCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCat.FormattingEnabled = True
        Me.ComboCat.Location = New System.Drawing.Point(1080, 141)
        Me.ComboCat.Name = "ComboCat"
        Me.ComboCat.Size = New System.Drawing.Size(257, 24)
        Me.ComboCat.TabIndex = 41
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.RBcat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TNombre2)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.RBnombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RBcodigo)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.LLista)
        Me.Controls.Add(Me.ComboCat)
        Me.KeyPreview = True
        Me.Name = "ListarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LLista As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents RBcat As RadioButton
    Friend WithEvents TNombre2 As TextBox
    Friend WithEvents RBnombre As RadioButton
    Friend WithEvents RBcodigo As RadioButton
    Friend WithEvents TCodigo As TextBox
    Friend WithEvents ComboCat As ComboBox
End Class
