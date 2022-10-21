<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentas
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BDescarga = New System.Windows.Forms.Button()
        Me.TCajero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.Lfiltro = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.TProducto = New System.Windows.Forms.TextBox()
        Me.CBCajero = New System.Windows.Forms.CheckBox()
        Me.CBCliente = New System.Windows.Forms.CheckBox()
        Me.CBProducto = New System.Windows.Forms.CheckBox()
        Me.LMayores = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BDescarga
        '
        Me.BDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDescarga.Location = New System.Drawing.Point(867, 442)
        Me.BDescarga.Name = "BDescarga"
        Me.BDescarga.Size = New System.Drawing.Size(219, 28)
        Me.BDescarga.TabIndex = 55
        Me.BDescarga.Text = "Descargar Reporte"
        Me.BDescarga.UseVisualStyleBackColor = True
        '
        'TCajero
        '
        Me.TCajero.Enabled = False
        Me.TCajero.Location = New System.Drawing.Point(352, 254)
        Me.TCajero.Name = "TCajero"
        Me.TCajero.Size = New System.Drawing.Size(270, 20)
        Me.TCajero.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(300, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Seleccionar periodo de tiempo"
        '
        'BBusqueda
        '
        Me.BBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBusqueda.Location = New System.Drawing.Point(316, 442)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(219, 28)
        Me.BBusqueda.TabIndex = 51
        Me.BBusqueda.Text = "Aplicar criterios seleccionados"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Lfiltro
        '
        Me.Lfiltro.AutoSize = True
        Me.Lfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lfiltro.Location = New System.Drawing.Point(377, 201)
        Me.Lfiltro.Name = "Lfiltro"
        Me.Lfiltro.Size = New System.Drawing.Size(64, 20)
        Me.Lfiltro.TabIndex = 50
        Me.Lfiltro.Text = "Filtros:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateHasta
        '
        Me.DateHasta.Enabled = False
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(495, 144)
        Me.DateHasta.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateHasta.MinDate = New Date(2015, 11, 25, 0, 0, 0, 0)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(127, 20)
        Me.DateHasta.TabIndex = 47
        Me.DateHasta.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LHasta.Location = New System.Drawing.Point(437, 144)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(52, 20)
        Me.LHasta.TabIndex = 46
        Me.LHasta.Text = "Hasta"
        '
        'DateDesde
        '
        Me.DateDesde.Enabled = False
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(281, 144)
        Me.DateDesde.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateDesde.MinDate = New Date(2015, 11, 24, 0, 0, 0, 0)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(132, 20)
        Me.DateDesde.TabIndex = 45
        Me.DateDesde.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDesde.Location = New System.Drawing.Point(206, 144)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(56, 20)
        Me.LDesde.TabIndex = 44
        Me.LDesde.Text = "Desde"
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(726, 97)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(531, 325)
        Me.Chart1.TabIndex = 43
        Me.Chart1.Text = "Chart1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1369, 70)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Reportes de ventas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TCliente
        '
        Me.TCliente.Enabled = False
        Me.TCliente.Location = New System.Drawing.Point(352, 311)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(270, 20)
        Me.TCliente.TabIndex = 57
        '
        'TProducto
        '
        Me.TProducto.Enabled = False
        Me.TProducto.Location = New System.Drawing.Point(352, 366)
        Me.TProducto.Name = "TProducto"
        Me.TProducto.Size = New System.Drawing.Size(270, 20)
        Me.TProducto.TabIndex = 59
        '
        'CBCajero
        '
        Me.CBCajero.AutoSize = True
        Me.CBCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCajero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBCajero.Location = New System.Drawing.Point(196, 254)
        Me.CBCajero.Name = "CBCajero"
        Me.CBCajero.Size = New System.Drawing.Size(140, 20)
        Me.CBCajero.TabIndex = 60
        Me.CBCajero.Text = "Seleccionar cajero"
        Me.CBCajero.UseVisualStyleBackColor = True
        '
        'CBCliente
        '
        Me.CBCliente.AutoSize = True
        Me.CBCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBCliente.Location = New System.Drawing.Point(196, 311)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(141, 20)
        Me.CBCliente.TabIndex = 61
        Me.CBCliente.Text = "Seleccionar cliente"
        Me.CBCliente.UseVisualStyleBackColor = True
        '
        'CBProducto
        '
        Me.CBProducto.AutoSize = True
        Me.CBProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBProducto.Location = New System.Drawing.Point(181, 366)
        Me.CBProducto.Name = "CBProducto"
        Me.CBProducto.Size = New System.Drawing.Size(155, 20)
        Me.CBProducto.TabIndex = 62
        Me.CBProducto.Text = "Seleccionar producto"
        Me.CBProducto.UseVisualStyleBackColor = True
        '
        'LMayores
        '
        Me.LMayores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LMayores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMayores.ForeColor = System.Drawing.Color.White
        Me.LMayores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LMayores.Location = New System.Drawing.Point(0, 528)
        Me.LMayores.Name = "LMayores"
        Me.LMayores.Size = New System.Drawing.Size(1369, 42)
        Me.LMayores.TabIndex = 64
        Me.LMayores.Text = "Resultados"
        Me.LMayores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Navy
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desde, Me.Hasta})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 570)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1369, 137)
        Me.DataGridView1.TabIndex = 63
        '
        'Desde
        '
        Me.Desde.HeaderText = "Desde"
        Me.Desde.Name = "Desde"
        '
        'Hasta
        '
        Me.Hasta.HeaderText = "Hasta"
        Me.Hasta.Name = "Hasta"
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1369, 707)
        Me.Controls.Add(Me.LMayores)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CBProducto)
        Me.Controls.Add(Me.CBCliente)
        Me.Controls.Add(Me.CBCajero)
        Me.Controls.Add(Me.TProducto)
        Me.Controls.Add(Me.TCliente)
        Me.Controls.Add(Me.BDescarga)
        Me.Controls.Add(Me.TCajero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BBusqueda)
        Me.Controls.Add(Me.Lfiltro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReporteVentas"
        Me.Text = "ReportesVentas"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDescarga As Button
    Friend WithEvents TCajero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BBusqueda As Button
    Friend WithEvents Lfiltro As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DateHasta As DateTimePicker
    Friend WithEvents LHasta As Label
    Friend WithEvents DateDesde As DateTimePicker
    Friend WithEvents LDesde As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents TCliente As TextBox
    Friend WithEvents TProducto As TextBox
    Friend WithEvents CBCajero As CheckBox
    Friend WithEvents CBCliente As CheckBox
    Friend WithEvents CBProducto As CheckBox
    Friend WithEvents LMayores As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
End Class
