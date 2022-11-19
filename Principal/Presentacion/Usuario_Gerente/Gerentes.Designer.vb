<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerentes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LHora = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.LSalirG = New System.Windows.Forms.Label()
        Me.LGerente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuGerente = New System.Windows.Forms.MenuStrip()
        Me.ReportesCajeros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteCategoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumerosMes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteMes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuGerente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.LFecha)
        Me.Panel1.Controls.Add(Me.LHora)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LGerente)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1362, 170)
        Me.Panel1.TabIndex = 1
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.White
        Me.LFecha.Location = New System.Drawing.Point(174, 44)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(69, 24)
        Me.LFecha.TabIndex = 7
        Me.LFecha.Text = "Fecha"
        Me.LFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.BackColor = System.Drawing.Color.Transparent
        Me.LHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHora.ForeColor = System.Drawing.Color.White
        Me.LHora.Location = New System.Drawing.Point(174, 92)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(55, 24)
        Me.LHora.TabIndex = 8
        Me.LHora.Text = "Hora"
        Me.LHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BCerrarSesion)
        Me.Panel3.Controls.Add(Me.LSalirG)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1231, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 170)
        Me.Panel3.TabIndex = 6
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.BackgroundImage = Global.Principal.My.Resources.Resources.Logout_37127
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCerrarSesion.Location = New System.Drawing.Point(35, 59)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BCerrarSesion.Size = New System.Drawing.Size(62, 56)
        Me.BCerrarSesion.TabIndex = 1
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'LSalirG
        '
        Me.LSalirG.AutoSize = True
        Me.LSalirG.BackColor = System.Drawing.Color.Transparent
        Me.LSalirG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LSalirG.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSalirG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LSalirG.Location = New System.Drawing.Point(3, 34)
        Me.LSalirG.Name = "LSalirG"
        Me.LSalirG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LSalirG.Size = New System.Drawing.Size(102, 19)
        Me.LSalirG.TabIndex = 2
        Me.LSalirG.Text = "Cerrar Sesión"
        Me.LSalirG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LGerente
        '
        Me.LGerente.BackColor = System.Drawing.Color.Transparent
        Me.LGerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGerente.ForeColor = System.Drawing.Color.White
        Me.LGerente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LGerente.Location = New System.Drawing.Point(548, 27)
        Me.LGerente.Name = "LGerente"
        Me.LGerente.Size = New System.Drawing.Size(315, 51)
        Me.LGerente.TabIndex = 3
        Me.LGerente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Principal.My.Resources.Resources.Messirve__1_
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'MenuGerente
        '
        Me.MenuGerente.AutoSize = False
        Me.MenuGerente.BackColor = System.Drawing.Color.Transparent
        Me.MenuGerente.BackgroundImage = Global.Principal.My.Resources.Resources.azulnaranja
        Me.MenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuGerente.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuGerente.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuGerente.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuGerente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesCajeros, Me.ReporteCategoria, Me.NumerosMes, Me.ReporteMes})
        Me.MenuGerente.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuGerente.Location = New System.Drawing.Point(0, 170)
        Me.MenuGerente.MdiWindowListItem = Me.ReportesCajeros
        Me.MenuGerente.Name = "MenuGerente"
        Me.MenuGerente.Padding = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.MenuGerente.ShowItemToolTips = True
        Me.MenuGerente.Size = New System.Drawing.Size(1362, 555)
        Me.MenuGerente.TabIndex = 2
        Me.MenuGerente.Text = " "
        '
        'ReportesCajeros
        '
        Me.ReportesCajeros.AutoSize = False
        Me.ReportesCajeros.AutoToolTip = True
        Me.ReportesCajeros.BackColor = System.Drawing.Color.Orange
        Me.ReportesCajeros.ForeColor = System.Drawing.Color.Black
        Me.ReportesCajeros.Image = Global.Principal.My.Resources.Resources.statistic_icon_129319
        Me.ReportesCajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportesCajeros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesCajeros.Name = "ReportesCajeros"
        Me.ReportesCajeros.Size = New System.Drawing.Size(1370, 128)
        Me.ReportesCajeros.Text = "Reportes por cajeros"
        Me.ReportesCajeros.ToolTipText = "Esta sección del menú nos permite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "generar reportes a partir de distintos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "puntos" &
    " de vista."
        '
        'ReporteCategoria
        '
        Me.ReporteCategoria.AutoSize = False
        Me.ReporteCategoria.BackColor = System.Drawing.Color.LightGreen
        Me.ReporteCategoria.ForeColor = System.Drawing.Color.Black
        Me.ReporteCategoria.Image = Global.Principal.My.Resources.Resources._2422208__1_
        Me.ReporteCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReporteCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReporteCategoria.Name = "ReporteCategoria"
        Me.ReporteCategoria.Size = New System.Drawing.Size(1360, 128)
        Me.ReporteCategoria.Text = "Reportes por Categorias"
        '
        'NumerosMes
        '
        Me.NumerosMes.AutoSize = False
        Me.NumerosMes.BackColor = System.Drawing.Color.DarkSalmon
        Me.NumerosMes.ForeColor = System.Drawing.Color.Black
        Me.NumerosMes.Image = Global.Principal.My.Resources.Resources.financial_report_calculator_chart_pie_icon_205131
        Me.NumerosMes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NumerosMes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NumerosMes.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.NumerosMes.Name = "NumerosMes"
        Me.NumerosMes.RightToLeftAutoMirrorImage = True
        Me.NumerosMes.Size = New System.Drawing.Size(1370, 128)
        Me.NumerosMes.Text = "Números del último mes"
        Me.NumerosMes.ToolTipText = "Esta sección del menú nos permite ver el rendimiento de la sucursal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desde el pun" &
    "to de vista de las ventas realizadas."
        '
        'ReporteMes
        '
        Me.ReporteMes.AutoSize = False
        Me.ReporteMes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ReporteMes.Image = Global.Principal.My.Resources.Resources.box_search_product_ean_barcode_icon_148907
        Me.ReporteMes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReporteMes.Name = "ReporteMes"
        Me.ReporteMes.Size = New System.Drawing.Size(1360, 128)
        Me.ReporteMes.Text = "Reporte Mes"
        Me.ReporteMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gerentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 720)
        Me.Controls.Add(Me.MenuGerente)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Gerentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuGerente.ResumeLayout(False)
        Me.MenuGerente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LFecha As Label
    Friend WithEvents LHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LSalirG As Label
    Friend WithEvents LGerente As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuGerente As MenuStrip
    Friend WithEvents ReportesCajeros As ToolStripMenuItem
    Friend WithEvents ReporteCategoria As ToolStripMenuItem
    Friend WithEvents NumerosMes As ToolStripMenuItem
    Friend WithEvents ReporteMes As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
