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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.BGenerar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TId = New System.Windows.Forms.TextBox()
        Me.TCajero = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.Lfiltro = New System.Windows.Forms.Label()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.LMayores = New System.Windows.Forms.Label()
        Me.dgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.TTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BGenerar
        '
        Me.BGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGenerar.Location = New System.Drawing.Point(867, 442)
        Me.BGenerar.Name = "BGenerar"
        Me.BGenerar.Size = New System.Drawing.Size(219, 28)
        Me.BGenerar.TabIndex = 55
        Me.BGenerar.Text = "Descargar Reporte"
        Me.BGenerar.UseVisualStyleBackColor = True
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
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(726, 97)
        Me.Chart1.Name = "Chart1"
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
        Me.Label2.Size = New System.Drawing.Size(1354, 70)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Reportes de ventas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TId
        '
        Me.TId.Location = New System.Drawing.Point(602, 321)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(29, 20)
        Me.TId.TabIndex = 75
        Me.TId.Visible = False
        '
        'TCajero
        '
        Me.TCajero.Enabled = False
        Me.TCajero.Location = New System.Drawing.Point(298, 275)
        Me.TCajero.Name = "TCajero"
        Me.TCajero.Size = New System.Drawing.Size(262, 20)
        Me.TCajero.TabIndex = 74
        '
        'Buscar
        '
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Image = Global.Principal.My.Resources.Resources.buscar2
        Me.Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Buscar.Location = New System.Drawing.Point(566, 262)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(106, 42)
        Me.Buscar.TabIndex = 73
        Me.Buscar.Text = "Buscar"
        Me.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(152, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Seleccionar cajero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(256, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Seleccionar periodo de tiempo"
        '
        'BBusqueda
        '
        Me.BBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBusqueda.Location = New System.Drawing.Point(298, 344)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(243, 28)
        Me.BBusqueda.TabIndex = 70
        Me.BBusqueda.Text = "Aplicar criterios seleccionados"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Lfiltro
        '
        Me.Lfiltro.AutoSize = True
        Me.Lfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lfiltro.Location = New System.Drawing.Point(333, 201)
        Me.Lfiltro.Name = "Lfiltro"
        Me.Lfiltro.Size = New System.Drawing.Size(64, 20)
        Me.Lfiltro.TabIndex = 69
        Me.Lfiltro.Text = "Filtros:"
        '
        'DateHasta
        '
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(451, 144)
        Me.DateHasta.MaxDate = New Date(2105, 7, 10, 0, 0, 0, 0)
        Me.DateHasta.MinDate = New Date(2015, 11, 25, 0, 0, 0, 0)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(127, 20)
        Me.DateHasta.TabIndex = 68
        Me.DateHasta.Value = New Date(2022, 11, 16, 0, 0, 0, 0)
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LHasta.Location = New System.Drawing.Point(393, 144)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(52, 20)
        Me.LHasta.TabIndex = 67
        Me.LHasta.Text = "Hasta"
        '
        'DateDesde
        '
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(237, 144)
        Me.DateDesde.MaxDate = New Date(2100, 3, 12, 0, 0, 0, 0)
        Me.DateDesde.MinDate = New Date(2015, 11, 24, 0, 0, 0, 0)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(132, 20)
        Me.DateDesde.TabIndex = 66
        Me.DateDesde.Value = New Date(2022, 11, 16, 0, 0, 0, 0)
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDesde.Location = New System.Drawing.Point(162, 144)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(56, 20)
        Me.LDesde.TabIndex = 65
        Me.LDesde.Text = "Desde"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.Navy
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(738, 516)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(610, 195)
        Me.dgvDetalle.TabIndex = 78
        '
        'LMayores
        '
        Me.LMayores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LMayores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMayores.ForeColor = System.Drawing.Color.White
        Me.LMayores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LMayores.Location = New System.Drawing.Point(40, 489)
        Me.LMayores.Name = "LMayores"
        Me.LMayores.Size = New System.Drawing.Size(1320, 24)
        Me.LMayores.TabIndex = 77
        Me.LMayores.Text = "Resultados"
        Me.LMayores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvEmpleado
        '
        Me.dgvEmpleado.AllowUserToAddRows = False
        Me.dgvEmpleado.AllowUserToDeleteRows = False
        Me.dgvEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleado.BackgroundColor = System.Drawing.Color.Navy
        Me.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleado.Location = New System.Drawing.Point(0, 516)
        Me.dgvEmpleado.Name = "dgvEmpleado"
        Me.dgvEmpleado.ReadOnly = True
        Me.dgvEmpleado.Size = New System.Drawing.Size(732, 195)
        Me.dgvEmpleado.TabIndex = 76
        '
        'TTotal
        '
        Me.TTotal.Enabled = False
        Me.TTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTotal.Location = New System.Drawing.Point(1216, 473)
        Me.TTotal.Name = "TTotal"
        Me.TTotal.Size = New System.Drawing.Size(126, 22)
        Me.TTotal.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1213, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Total Recaudado"
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.TTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.LMayores)
        Me.Controls.Add(Me.dgvEmpleado)
        Me.Controls.Add(Me.TId)
        Me.Controls.Add(Me.TCajero)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BBusqueda)
        Me.Controls.Add(Me.Lfiltro)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.BGenerar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportesVentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BGenerar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents TId As TextBox
    Friend WithEvents TCajero As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BBusqueda As Button
    Friend WithEvents Lfiltro As Label
    Friend WithEvents DateHasta As DateTimePicker
    Friend WithEvents LHasta As Label
    Friend WithEvents DateDesde As DateTimePicker
    Friend WithEvents LDesde As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents LMayores As Label
    Friend WithEvents dgvEmpleado As DataGridView
    Friend WithEvents TTotal As TextBox
    Friend WithEvents Label4 As Label
End Class
