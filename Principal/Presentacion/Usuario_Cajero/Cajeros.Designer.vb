<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajeros
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
        Me.LCajero = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.FacturacionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónClientestem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MisDatosItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuEncargado.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.LCajero)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1354, 153)
        Me.Panel1.TabIndex = 6
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
        Me.Panel3.Location = New System.Drawing.Point(1221, 0)
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
        'LCajero
        '
        Me.LCajero.BackColor = System.Drawing.Color.Transparent
        Me.LCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCajero.ForeColor = System.Drawing.Color.Navy
        Me.LCajero.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LCajero.Location = New System.Drawing.Point(503, 27)
        Me.LCajero.Name = "LCajero"
        Me.LCajero.Size = New System.Drawing.Size(347, 51)
        Me.LCajero.TabIndex = 3
        Me.LCajero.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'Timer1
        '
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
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionItem, Me.GestiónClientestem, Me.VentasItem, Me.ListaProductos, Me.MisDatosItem})
        Me.MenuEncargado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 153)
        Me.MenuEncargado.MdiWindowListItem = Me.VentasItem
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.MenuEncargado.ShowItemToolTips = True
        Me.MenuEncargado.Size = New System.Drawing.Size(1354, 580)
        Me.MenuEncargado.TabIndex = 8
        Me.MenuEncargado.Text = " "
        '
        'FacturacionItem
        '
        Me.FacturacionItem.AutoSize = False
        Me.FacturacionItem.AutoToolTip = True
        Me.FacturacionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FacturacionItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FacturacionItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturacionItem.Image = Global.Principal.My.Resources.Resources.Factura__1_
        Me.FacturacionItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FacturacionItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FacturacionItem.Name = "FacturacionItem"
        Me.FacturacionItem.Size = New System.Drawing.Size(1370, 108)
        Me.FacturacionItem.Text = "Realizar Venta"
        Me.FacturacionItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FacturacionItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.FacturacionItem.ToolTipText = "Esta sección nos permite realizar la facturación de la venta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que se va a realiz" &
    "ar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GestiónClientestem
        '
        Me.GestiónClientestem.AutoSize = False
        Me.GestiónClientestem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GestiónClientestem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GestiónClientestem.ForeColor = System.Drawing.Color.Black
        Me.GestiónClientestem.Image = Global.Principal.My.Resources.Resources.person_user_customer_man_male_man_boy_people_1688
        Me.GestiónClientestem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GestiónClientestem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GestiónClientestem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.GestiónClientestem.Name = "GestiónClientestem"
        Me.GestiónClientestem.Size = New System.Drawing.Size(1370, 108)
        Me.GestiónClientestem.Text = "Gestión de Clientes"
        Me.GestiónClientestem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GestiónClientestem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.GestiónClientestem.ToolTipText = "Esta sección del menú nos permite:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Agregar clientes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Editar los datos de lo" &
    "s clientes existentes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'VentasItem
        '
        Me.VentasItem.AutoSize = False
        Me.VentasItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VentasItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasItem.ForeColor = System.Drawing.Color.Black
        Me.VentasItem.Image = Global.Principal.My.Resources.Resources.cashier_machine_cash_register_pos_icon_225168
        Me.VentasItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentasItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentasItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.VentasItem.Name = "VentasItem"
        Me.VentasItem.RightToLeftAutoMirrorImage = True
        Me.VentasItem.Size = New System.Drawing.Size(1370, 108)
        Me.VentasItem.Text = "Mis ventas"
        Me.VentasItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VentasItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.VentasItem.ToolTipText = "Esta sección del menú nos permite controlar las ventas realizadas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "En el caso qu" &
    "e sea necesario, es posible cancelar una venta."
        '
        'ListaProductos
        '
        Me.ListaProductos.AutoSize = False
        Me.ListaProductos.BackColor = System.Drawing.Color.MistyRose
        Me.ListaProductos.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaProductos.Image = Global.Principal.My.Resources.Resources.shirt_online_store_ecommerce_commerce_marketplace_website_shopping_clothing_icon_225154
        Me.ListaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListaProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ListaProductos.Name = "ListaProductos"
        Me.ListaProductos.Size = New System.Drawing.Size(13700, 108)
        Me.ListaProductos.Text = "Lista de Productos"
        Me.ListaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'MisDatosItem
        '
        Me.MisDatosItem.AutoSize = False
        Me.MisDatosItem.AutoToolTip = True
        Me.MisDatosItem.BackColor = System.Drawing.Color.Azure
        Me.MisDatosItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MisDatosItem.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MisDatosItem.ForeColor = System.Drawing.Color.Black
        Me.MisDatosItem.Image = Global.Principal.My.Resources.Resources._4_icon_icons_com_73775
        Me.MisDatosItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MisDatosItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MisDatosItem.Name = "MisDatosItem"
        Me.MisDatosItem.Size = New System.Drawing.Size(1370, 108)
        Me.MisDatosItem.Text = "Mis Datos Personales"
        Me.MisDatosItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MisDatosItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.MisDatosItem.ToolTipText = "En esta sección el usuario del sistema puede ver, agregar o modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "datos pers" &
    "onales y de inicio de sesión"
        '
        'Cajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.MenuEncargado)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Cajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajeros"
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

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LFecha As Label
    Friend WithEvents LHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LSalirG As Label
    Friend WithEvents LCajero As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents GestiónClientestem As ToolStripMenuItem
    Friend WithEvents VentasItem As ToolStripMenuItem
    Friend WithEvents FacturacionItem As ToolStripMenuItem
    Friend WithEvents MisDatosItem As ToolStripMenuItem
    Friend WithEvents ListaProductos As ToolStripMenuItem
End Class
