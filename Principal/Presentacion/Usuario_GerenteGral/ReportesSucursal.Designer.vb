<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesSucursal
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BBusqueda = New System.Windows.Forms.Button()
        Me.Lfiltro = New System.Windows.Forms.Label()
        Me.Laño = New System.Windows.Forms.Label()
        Me.CBaño = New System.Windows.Forms.ComboBox()
        Me.Lproducto = New System.Windows.Forms.Label()
        Me.CBproducto = New System.Windows.Forms.ComboBox()
        Me.Lcategoria = New System.Windows.Forms.Label()
        Me.CBcategoria = New System.Windows.Forms.ComboBox()
        Me.LMes = New System.Windows.Forms.Label()
        Me.CBmes = New System.Windows.Forms.ComboBox()
        Me.CHmes = New System.Windows.Forms.CheckBox()
        Me.DateHasta = New System.Windows.Forms.DateTimePicker()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.DateDesde = New System.Windows.Forms.DateTimePicker()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.CHfecha = New System.Windows.Forms.CheckBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LSucursales = New System.Windows.Forms.Label()
        Me.ComboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1362, 73)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Reportes de Sucursales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "<---Volver al menú principal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BBusqueda
        '
        Me.BBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBusqueda.Location = New System.Drawing.Point(539, 498)
        Me.BBusqueda.Name = "BBusqueda"
        Me.BBusqueda.Size = New System.Drawing.Size(227, 37)
        Me.BBusqueda.TabIndex = 52
        Me.BBusqueda.Text = "Aplicar criterios de busqueda"
        Me.BBusqueda.UseVisualStyleBackColor = True
        '
        'Lfiltro
        '
        Me.Lfiltro.AutoSize = True
        Me.Lfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lfiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lfiltro.Location = New System.Drawing.Point(331, 353)
        Me.Lfiltro.Name = "Lfiltro"
        Me.Lfiltro.Size = New System.Drawing.Size(56, 20)
        Me.Lfiltro.TabIndex = 51
        Me.Lfiltro.Text = "Filtros:"
        '
        'Laño
        '
        Me.Laño.AutoSize = True
        Me.Laño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Laño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Laño.Location = New System.Drawing.Point(183, 215)
        Me.Laño.Name = "Laño"
        Me.Laño.Size = New System.Drawing.Size(123, 20)
        Me.Laño.TabIndex = 50
        Me.Laño.Text = "Seleccionar año"
        '
        'CBaño
        '
        Me.CBaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBaño.Enabled = False
        Me.CBaño.FormattingEnabled = True
        Me.CBaño.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBaño.Items.AddRange(New Object() {"2022", "2021", "2020", "2019", "2018", "2017", "2016"})
        Me.CBaño.Location = New System.Drawing.Point(318, 214)
        Me.CBaño.Name = "CBaño"
        Me.CBaño.Size = New System.Drawing.Size(270, 21)
        Me.CBaño.TabIndex = 49
        '
        'Lproducto
        '
        Me.Lproducto.AutoSize = True
        Me.Lproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lproducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lproducto.Location = New System.Drawing.Point(150, 443)
        Me.Lproducto.Name = "Lproducto"
        Me.Lproducto.Size = New System.Drawing.Size(159, 20)
        Me.Lproducto.TabIndex = 48
        Me.Lproducto.Text = "Seleccionar producto"
        '
        'CBproducto
        '
        Me.CBproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBproducto.FormattingEnabled = True
        Me.CBproducto.Location = New System.Drawing.Point(318, 442)
        Me.CBproducto.Name = "CBproducto"
        Me.CBproducto.Size = New System.Drawing.Size(270, 21)
        Me.CBproducto.TabIndex = 47
        '
        'Lcategoria
        '
        Me.Lcategoria.AutoSize = True
        Me.Lcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lcategoria.Location = New System.Drawing.Point(147, 398)
        Me.Lcategoria.Name = "Lcategoria"
        Me.Lcategoria.Size = New System.Drawing.Size(162, 20)
        Me.Lcategoria.TabIndex = 46
        Me.Lcategoria.Text = "Seleccionar categoria"
        '
        'CBcategoria
        '
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Location = New System.Drawing.Point(318, 397)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(270, 21)
        Me.CBcategoria.TabIndex = 45
        '
        'LMes
        '
        Me.LMes.AutoSize = True
        Me.LMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LMes.Location = New System.Drawing.Point(183, 184)
        Me.LMes.Name = "LMes"
        Me.LMes.Size = New System.Drawing.Size(126, 20)
        Me.LMes.TabIndex = 44
        Me.LMes.Text = "Seleccionar mes"
        '
        'CBmes
        '
        Me.CBmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBmes.Enabled = False
        Me.CBmes.FormattingEnabled = True
        Me.CBmes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CBmes.Location = New System.Drawing.Point(318, 183)
        Me.CBmes.Name = "CBmes"
        Me.CBmes.Size = New System.Drawing.Size(270, 21)
        Me.CBmes.TabIndex = 43
        '
        'CHmes
        '
        Me.CHmes.AutoSize = True
        Me.CHmes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHmes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CHmes.Location = New System.Drawing.Point(154, 153)
        Me.CHmes.Name = "CHmes"
        Me.CHmes.Size = New System.Drawing.Size(140, 24)
        Me.CHmes.TabIndex = 42
        Me.CHmes.Text = "Ventas por mes"
        Me.CHmes.UseVisualStyleBackColor = True
        '
        'DateHasta
        '
        Me.DateHasta.Enabled = False
        Me.DateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHasta.Location = New System.Drawing.Point(398, 290)
        Me.DateHasta.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateHasta.MinDate = New Date(2015, 11, 25, 0, 0, 0, 0)
        Me.DateHasta.Name = "DateHasta"
        Me.DateHasta.Size = New System.Drawing.Size(106, 20)
        Me.DateHasta.TabIndex = 41
        Me.DateHasta.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHasta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LHasta.Location = New System.Drawing.Point(340, 290)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(52, 20)
        Me.LHasta.TabIndex = 40
        Me.LHasta.Text = "Hasta"
        '
        'DateDesde
        '
        Me.DateDesde.Enabled = False
        Me.DateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDesde.Location = New System.Drawing.Point(212, 287)
        Me.DateDesde.MaxDate = New Date(2022, 9, 17, 0, 0, 0, 0)
        Me.DateDesde.MinDate = New Date(2015, 11, 24, 0, 0, 0, 0)
        Me.DateDesde.Name = "DateDesde"
        Me.DateDesde.Size = New System.Drawing.Size(102, 20)
        Me.DateDesde.TabIndex = 39
        Me.DateDesde.Value = New Date(2022, 9, 17, 0, 0, 0, 0)
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDesde.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LDesde.Location = New System.Drawing.Point(150, 287)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(56, 20)
        Me.LDesde.TabIndex = 38
        Me.LDesde.Text = "Desde"
        '
        'CHfecha
        '
        Me.CHfecha.AutoSize = True
        Me.CHfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CHfecha.Location = New System.Drawing.Point(154, 260)
        Me.CHfecha.Name = "CHfecha"
        Me.CHfecha.Size = New System.Drawing.Size(242, 24)
        Me.CHfecha.TabIndex = 37
        Me.CHfecha.Text = "Seleccionar periodo de tiempo"
        Me.CHfecha.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(731, 138)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(531, 325)
        Me.Chart1.TabIndex = 36
        Me.Chart1.Text = "Chart1"
        '
        'LSucursales
        '
        Me.LSucursales.AutoSize = True
        Me.LSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSucursales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LSucursales.Location = New System.Drawing.Point(726, 101)
        Me.LSucursales.Name = "LSucursales"
        Me.LSucursales.Size = New System.Drawing.Size(108, 25)
        Me.LSucursales.TabIndex = 35
        Me.LSucursales.Text = "Sucursal: "
        '
        'ComboBoxSucursal
        '
        Me.ComboBoxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSucursal.FormattingEnabled = True
        Me.ComboBoxSucursal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBoxSucursal.Location = New System.Drawing.Point(318, 102)
        Me.ComboBoxSucursal.Name = "ComboBoxSucursal"
        Me.ComboBoxSucursal.Size = New System.Drawing.Size(270, 21)
        Me.ComboBoxSucursal.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(149, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Seleccionar Sucursal"
        '
        'ReportesSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 661)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxSucursal)
        Me.Controls.Add(Me.BBusqueda)
        Me.Controls.Add(Me.Lfiltro)
        Me.Controls.Add(Me.Laño)
        Me.Controls.Add(Me.CBaño)
        Me.Controls.Add(Me.Lproducto)
        Me.Controls.Add(Me.CBproducto)
        Me.Controls.Add(Me.Lcategoria)
        Me.Controls.Add(Me.CBcategoria)
        Me.Controls.Add(Me.LMes)
        Me.Controls.Add(Me.CBmes)
        Me.Controls.Add(Me.CHmes)
        Me.Controls.Add(Me.DateHasta)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.DateDesde)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.CHfecha)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.LSucursales)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ReportesSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Sucursales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BBusqueda As Button
    Friend WithEvents Lfiltro As Label
    Friend WithEvents Laño As Label
    Friend WithEvents CBaño As ComboBox
    Friend WithEvents Lproducto As Label
    Friend WithEvents CBproducto As ComboBox
    Friend WithEvents Lcategoria As Label
    Friend WithEvents CBcategoria As ComboBox
    Friend WithEvents LMes As Label
    Friend WithEvents CBmes As ComboBox
    Friend WithEvents CHmes As CheckBox
    Friend WithEvents DateHasta As DateTimePicker
    Friend WithEvents LHasta As Label
    Friend WithEvents DateDesde As DateTimePicker
    Friend WithEvents LDesde As Label
    Friend WithEvents CHfecha As CheckBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LSucursales As Label
    Friend WithEvents ComboBoxSucursal As ComboBox
    Friend WithEvents Label1 As Label
End Class
