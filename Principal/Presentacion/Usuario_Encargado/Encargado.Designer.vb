<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Encargado
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TTMenuEncargado = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LHora = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.LSalirG = New System.Windows.Forms.Label()
        Me.LEncargado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.GestiónCajerosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónProductosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuEncargado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LFecha)
        Me.Panel1.Controls.Add(Me.LHora)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LEncargado)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1122, 153)
        Me.Panel1.TabIndex = 5
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Navy
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
        Me.LHora.ForeColor = System.Drawing.Color.Navy
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
        Me.Panel3.Location = New System.Drawing.Point(989, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 151)
        Me.Panel3.TabIndex = 6
        '
        'BCerrarSesion
        '
        Me.BCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.BackgroundImage = Global.Principal.My.Resources.Resources.Logout_37127
        Me.BCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BCerrarSesion.ForeColor = System.Drawing.Color.Transparent
        Me.BCerrarSesion.Location = New System.Drawing.Point(47, 44)
        Me.BCerrarSesion.Name = "BCerrarSesion"
        Me.BCerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BCerrarSesion.Size = New System.Drawing.Size(62, 56)
        Me.BCerrarSesion.TabIndex = 1
        Me.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCerrarSesion.UseVisualStyleBackColor = False
        '
        'LSalirG
        '
        Me.LSalirG.AutoSize = True
        Me.LSalirG.BackColor = System.Drawing.Color.Transparent
        Me.LSalirG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LSalirG.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSalirG.ForeColor = System.Drawing.Color.Blue
        Me.LSalirG.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.LSalirG.Location = New System.Drawing.Point(18, 11)
        Me.LSalirG.Name = "LSalirG"
        Me.LSalirG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LSalirG.Size = New System.Drawing.Size(102, 19)
        Me.LSalirG.TabIndex = 2
        Me.LSalirG.Text = "Cerrar Sesión"
        Me.LSalirG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LEncargado
        '
        Me.LEncargado.BackColor = System.Drawing.Color.Transparent
        Me.LEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEncargado.ForeColor = System.Drawing.Color.Navy
        Me.LEncargado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LEncargado.Location = New System.Drawing.Point(548, 27)
        Me.LEncargado.Name = "LEncargado"
        Me.LEncargado.Size = New System.Drawing.Size(312, 51)
        Me.LEncargado.TabIndex = 3
        Me.LEncargado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Principal.My.Resources.Resources.Messirve__1_
        Me.PictureBox1.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AutoSize = False
        Me.MenuEncargado.BackColor = System.Drawing.Color.Transparent
        Me.MenuEncargado.BackgroundImage = Global.Principal.My.Resources.Resources.azulnaranja
        Me.MenuEncargado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuEncargado.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónCajerosItem, Me.VentasItem, Me.GestiónProductosItem, Me.ReportesVentas})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 153)
        Me.MenuEncargado.MdiWindowListItem = Me.VentasItem
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.MenuEncargado.ShowItemToolTips = True
        Me.MenuEncargado.Size = New System.Drawing.Size(1122, 580)
        Me.MenuEncargado.TabIndex = 7
        Me.MenuEncargado.Text = " "
        '
        'GestiónCajerosItem
        '
        Me.GestiónCajerosItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GestiónCajerosItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestiónCajerosItem.ForeColor = System.Drawing.Color.Black
        Me.GestiónCajerosItem.Image = Global.Principal.My.Resources.Resources.female_cashier_avatar_people_icon_142371__2_
        Me.GestiónCajerosItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GestiónCajerosItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GestiónCajerosItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.GestiónCajerosItem.Name = "GestiónCajerosItem"
        Me.GestiónCajerosItem.Size = New System.Drawing.Size(1109, 132)
        Me.GestiónCajerosItem.Text = "Gestión de Empleados"
        Me.GestiónCajerosItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GestiónCajerosItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.GestiónCajerosItem.ToolTipText = "Esta sección del menú nos permite:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Agregar usuarios del tipo ""cajero""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Edit" &
    "ar los datos de los cajeros existentes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Eliminar un usuario del tipo cajero"
        '
        'VentasItem
        '
        Me.VentasItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VentasItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasItem.ForeColor = System.Drawing.Color.Black
        Me.VentasItem.Image = Global.Principal.My.Resources.Resources.cashier_machine_cash_register_pos_icon_225168
        Me.VentasItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentasItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentasItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.VentasItem.Name = "VentasItem"
        Me.VentasItem.RightToLeftAutoMirrorImage = True
        Me.VentasItem.Size = New System.Drawing.Size(1109, 132)
        Me.VentasItem.Text = "Gestión de ventas"
        Me.VentasItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VentasItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.VentasItem.ToolTipText = "Esta sección del menú nos permite controlar las ventas realizadas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por los disti" &
    "ntos cajeros de nuestra sucursal." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En el caso que sea necesario, es posible canc" &
    "elar una venta."
        '
        'GestiónProductosItem
        '
        Me.GestiónProductosItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GestiónProductosItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestiónProductosItem.Image = Global.Principal.My.Resources.Resources.shirt_online_store_ecommerce_commerce_marketplace_website_shopping_clothing_icon_225154
        Me.GestiónProductosItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GestiónProductosItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GestiónProductosItem.Name = "GestiónProductosItem"
        Me.GestiónProductosItem.Size = New System.Drawing.Size(1109, 132)
        Me.GestiónProductosItem.Text = "Gestion de Productos"
        Me.GestiónProductosItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GestiónProductosItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.GestiónProductosItem.ToolTipText = "Esta sección del menú nos permite:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Agregar productos de cualquier rubro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Ed" &
    "itar los datos de los productos existentes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Eliminar un producto de la lista." &
    ""
        '
        'ReportesVentas
        '
        Me.ReportesVentas.BackColor = System.Drawing.Color.LightGreen
        Me.ReportesVentas.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesVentas.Image = Global.Principal.My.Resources.Resources.statistic_icon_129319
        Me.ReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportesVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesVentas.Name = "ReportesVentas"
        Me.ReportesVentas.Size = New System.Drawing.Size(1109, 132)
        Me.ReportesVentas.Text = "Reportes de Ventas"
        Me.ReportesVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReportesVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Encargado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 733)
        Me.Controls.Add(Me.MenuEncargado)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Encargado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuEncargado.ResumeLayout(False)
        Me.MenuEncargado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TTMenuEncargado As ToolTip
    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LFecha As Label
    Friend WithEvents LHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LSalirG As Label
    Friend WithEvents LEncargado As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents GestiónCajerosItem As ToolStripMenuItem
    Friend WithEvents VentasItem As ToolStripMenuItem
    Friend WithEvents GestiónProductosItem As ToolStripMenuItem
    Friend WithEvents ReportesVentas As ToolStripMenuItem
End Class
