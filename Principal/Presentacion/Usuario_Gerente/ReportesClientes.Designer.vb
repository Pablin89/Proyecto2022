<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesClientes
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BDescarga = New System.Windows.Forms.Button()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.BDescarga.Location = New System.Drawing.Point(871, 465)
        Me.BDescarga.Name = "BDescarga"
        Me.BDescarga.Size = New System.Drawing.Size(219, 28)
        Me.BDescarga.TabIndex = 61
        Me.BDescarga.Text = "Descargar Reporte"
        Me.BDescarga.UseVisualStyleBackColor = True
        '
        'TCliente
        '
        Me.TCliente.Location = New System.Drawing.Point(368, 293)
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(270, 20)
        Me.TCliente.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(210, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Seleccionar cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(304, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Seleccionar periodo de tiempo"
        '
        'BBusqueda
        '
        Me.BBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBusqueda.Location = New System.Drawing.Point(328, 354)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(219, 28)
        Me.BBusqueda.TabIndex = 54
        Me.BBusqueda.Text = "Aplicar criterios seleccionados"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Lfiltro
        '
        Me.Lfiltro.AutoSize = True
        Me.Lfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lfiltro.Location = New System.Drawing.Point(381, 224)
        Me.Lfiltro.Name = "Lfiltro"
        Me.Lfiltro.Size = New System.Drawing.Size(64, 20)
        Me.Lfiltro.TabIndex = 53
        Me.Lfiltro.Text = "Filtros:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-202, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateHasta
        '
        Me.DateHasta.Enabled = False
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(499, 167)
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
        Me.LHasta.Location = New System.Drawing.Point(441, 167)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(52, 20)
        Me.LHasta.TabIndex = 46
        Me.LHasta.Text = "Hasta"
        '
        'DateDesde
        '
        Me.DateDesde.Enabled = False
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(285, 167)
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
        Me.LDesde.Location = New System.Drawing.Point(210, 167)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(56, 20)
        Me.LDesde.TabIndex = 44
        Me.LDesde.Text = "Desde"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(730, 120)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
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
        Me.Label2.Size = New System.Drawing.Size(1335, 70)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Reportes por clientes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 23)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "<---Volver al menú principal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LMayores
        '
        Me.LMayores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LMayores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMayores.ForeColor = System.Drawing.Color.White
        Me.LMayores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LMayores.Location = New System.Drawing.Point(0, 524)
        Me.LMayores.Name = "LMayores"
        Me.LMayores.Size = New System.Drawing.Size(1335, 31)
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 555)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1335, 126)
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
        'ReportesClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1335, 681)
        Me.Controls.Add(Me.LMayores)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BDescarga)
        Me.Controls.Add(Me.TCliente)
        Me.Controls.Add(Me.Label4)
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
        Me.Name = "ReportesClientes"
        Me.Text = "ReportesCliente"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDescarga As Button
    Friend WithEvents TCliente As TextBox
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Button2 As Button
    Friend WithEvents LMayores As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Desde As DataGridViewTextBoxColumn
    Friend WithEvents Hasta As DataGridViewTextBoxColumn
End Class
