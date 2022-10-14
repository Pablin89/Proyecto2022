<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteSucursalIndividual
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.CBcategoria = New System.Windows.Forms.ComboBox()
        Me.Lcategoria = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lproducto = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMayores = New System.Windows.Forms.Label()
        Me.Lfiltro = New System.Windows.Forms.Label()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BDescarga = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(729, 98)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(531, 325)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDesde.Location = New System.Drawing.Point(209, 145)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(56, 20)
        Me.LDesde.TabIndex = 14
        Me.LDesde.Text = "Desde"
        '
        'DateDesde
        '
        Me.DateDesde.Enabled = False
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(284, 145)
        Me.DateDesde.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateDesde.MinDate = New Date(2015, 11, 24, 0, 0, 0, 0)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(132, 20)
        Me.DateDesde.TabIndex = 15
        Me.DateDesde.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LHasta.Location = New System.Drawing.Point(440, 145)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(52, 20)
        Me.LHasta.TabIndex = 17
        Me.LHasta.Text = "Hasta"
        '
        'DateHasta
        '
        Me.DateHasta.Enabled = False
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(498, 145)
        Me.DateHasta.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateHasta.MinDate = New Date(2015, 11, 25, 0, 0, 0, 0)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(127, 20)
        Me.DateHasta.TabIndex = 18
        Me.DateHasta.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'CBcategoria
        '
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.Enabled = False
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Location = New System.Drawing.Point(356, 251)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(270, 21)
        Me.CBcategoria.TabIndex = 22
        '
        'Lcategoria
        '
        Me.Lcategoria.AutoSize = True
        Me.Lcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lcategoria.Location = New System.Drawing.Point(175, 252)
        Me.Lcategoria.Name = "Lcategoria"
        Me.Lcategoria.Size = New System.Drawing.Size(162, 20)
        Me.Lcategoria.TabIndex = 23
        Me.Lcategoria.Text = "Seleccionar categoria"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1272, 70)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Reportes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lproducto
        '
        Me.Lproducto.AutoSize = True
        Me.Lproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lproducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lproducto.Location = New System.Drawing.Point(178, 297)
        Me.Lproducto.Name = "Lproducto"
        Me.Lproducto.Size = New System.Drawing.Size(159, 20)
        Me.Lproducto.TabIndex = 28
        Me.Lproducto.Text = "Seleccionar producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Navy
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desde, Me.Hasta})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 521)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1272, 126)
        Me.DataGridView1.TabIndex = 29
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
        'LMayores
        '
        Me.LMayores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LMayores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMayores.ForeColor = System.Drawing.Color.White
        Me.LMayores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LMayores.Location = New System.Drawing.Point(0, 490)
        Me.LMayores.Name = "LMayores"
        Me.LMayores.Size = New System.Drawing.Size(1272, 31)
        Me.LMayores.TabIndex = 30
        Me.LMayores.Text = "Resultados"
        Me.LMayores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lfiltro
        '
        Me.Lfiltro.AutoSize = True
        Me.Lfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lfiltro.Location = New System.Drawing.Point(380, 202)
        Me.Lfiltro.Name = "Lfiltro"
        Me.Lfiltro.Size = New System.Drawing.Size(64, 20)
        Me.Lfiltro.TabIndex = 33
        Me.Lfiltro.Text = "Filtros:"
        '
        'BBusqueda
        '
        Me.BBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBusqueda.Location = New System.Drawing.Point(327, 443)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(219, 28)
        Me.BBusqueda.TabIndex = 34
        Me.BBusqueda.Text = "Aplicar criterios seleccionados"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(303, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Seleccionar periodo de tiempo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(198, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Seleccionar cajero"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(356, 297)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 20)
        Me.TextBox1.TabIndex = 38
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(356, 348)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(270, 20)
        Me.TextBox2.TabIndex = 39
        '
        'TCliente
        '
        Me.TCliente.Location = New System.Drawing.Point(356, 396)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(270, 20)
        Me.TCliente.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(198, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Seleccionar cliente"
        '
        'BDescarga
        '
        Me.BDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDescarga.Location = New System.Drawing.Point(870, 443)
        Me.BDescarga.Name = "BDescarga"
        Me.BDescarga.Size = New System.Drawing.Size(219, 28)
        Me.BDescarga.TabIndex = 42
        Me.BDescarga.Text = "Descargar Reporte"
        Me.BDescarga.UseVisualStyleBackColor = True
        '
        'ReporteSucursalIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 647)
        Me.Controls.Add(Me.BDescarga)
        Me.Controls.Add(Me.TCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BBusqueda)
        Me.Controls.Add(Me.Lfiltro)
        Me.Controls.Add(Me.LMayores)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lproducto)
        Me.Controls.Add(Me.Lcategoria)
        Me.Controls.Add(Me.CBcategoria)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReporteSucursalIndividual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi sucursal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LDesde As Label
    Friend WithEvents DateDesde As DateTimePicker
    Friend WithEvents LHasta As Label
    Friend WithEvents DateHasta As DateTimePicker
    Friend WithEvents CBcategoria As ComboBox
    Friend WithEvents Lcategoria As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Lproducto As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LMayores As Label
    Friend WithEvents Lfiltro As Label
    Friend WithEvents BBusqueda As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BDescarga As Button
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
End Class
