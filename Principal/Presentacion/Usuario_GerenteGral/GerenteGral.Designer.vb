<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GerenteGral
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
        Me.LSalirG = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuGerente = New System.Windows.Forms.MenuStrip()
        Me.AñadirEncargadoItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarBase = New System.Windows.Forms.ToolStripMenuItem()
        Me.BCerrarSesion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuGerente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.LFecha)
        Me.Panel1.Controls.Add(Me.LHora)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1354, 170)
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
        Me.Panel3.Location = New System.Drawing.Point(1223, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 170)
        Me.Panel3.TabIndex = 6
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(548, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 51)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gerente General: José Perez"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'MenuGerente
        '
        Me.MenuGerente.AutoSize = False
        Me.MenuGerente.BackColor = System.Drawing.Color.Transparent
        Me.MenuGerente.BackgroundImage = Global.Principal.My.Resources.Resources.azulnaranja
        Me.MenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuGerente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuGerente.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuGerente.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuGerente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirEncargadoItem, Me.BackupBase, Me.RestaurarBase})
        Me.MenuGerente.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuGerente.Location = New System.Drawing.Point(0, 170)
        Me.MenuGerente.MdiWindowListItem = Me.AñadirEncargadoItem
        Me.MenuGerente.Name = "MenuGerente"
        Me.MenuGerente.Padding = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.MenuGerente.ShowItemToolTips = True
        Me.MenuGerente.Size = New System.Drawing.Size(1354, 534)
        Me.MenuGerente.TabIndex = 2
        Me.MenuGerente.Text = " "
        '
        'AñadirEncargadoItem
        '
        Me.AñadirEncargadoItem.AutoSize = False
        Me.AñadirEncargadoItem.AutoToolTip = True
        Me.AñadirEncargadoItem.BackColor = System.Drawing.Color.Orange
        Me.AñadirEncargadoItem.ForeColor = System.Drawing.Color.Black
        Me.AñadirEncargadoItem.Image = Global.Principal.My.Resources.Resources.manager_icon_129392
        Me.AñadirEncargadoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AñadirEncargadoItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AñadirEncargadoItem.Name = "AñadirEncargadoItem"
        Me.AñadirEncargadoItem.Size = New System.Drawing.Size(1357, 120)
        Me.AñadirEncargadoItem.Text = "Permisos de Usuario"
        Me.AñadirEncargadoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AñadirEncargadoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.AñadirEncargadoItem.ToolTipText = "Esta sección del menú nos permite:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Agregar usuarios del tipo ""Gerente""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Edi" &
    "tar los datos de los gerentes existentes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Eliminar un usuario del tipo gerent" &
    "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BackupBase
        '
        Me.BackupBase.AutoSize = False
        Me.BackupBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackupBase.ForeColor = System.Drawing.Color.Black
        Me.BackupBase.Image = Global.Principal.My.Resources.Resources.Base
        Me.BackupBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackupBase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BackupBase.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.BackupBase.Name = "BackupBase"
        Me.BackupBase.RightToLeftAutoMirrorImage = True
        Me.BackupBase.Size = New System.Drawing.Size(1359, 130)
        Me.BackupBase.Text = "Backup de Base de Datos"
        Me.BackupBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BackupBase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BackupBase.ToolTipText = "Esta sección del menú nos permite ver el rendimiento de todas las sucursales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des" &
    "de el punto de vista de las ventas realizadas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RestaurarBase
        '
        Me.RestaurarBase.AutoSize = False
        Me.RestaurarBase.AutoToolTip = True
        Me.RestaurarBase.BackColor = System.Drawing.Color.PaleGreen
        Me.RestaurarBase.Image = Global.Principal.My.Resources.Resources.restaurar
        Me.RestaurarBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestaurarBase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestaurarBase.Name = "RestaurarBase"
        Me.RestaurarBase.Size = New System.Drawing.Size(1359, 124)
        Me.RestaurarBase.Text = "Restaurar Base de Datos"
        Me.RestaurarBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RestaurarBase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RestaurarBase.ToolTipText = "Esta sección nos permite agregar nuevas sucursales."
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
        'GerenteGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 704)
        Me.Controls.Add(Me.MenuGerente)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "GerenteGral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GerenteGral"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuGerente.ResumeLayout(False)
        Me.MenuGerente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LFecha As Label
    Friend WithEvents LHora As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BCerrarSesion As Button
    Friend WithEvents LSalirG As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuGerente As MenuStrip
    Friend WithEvents AñadirEncargadoItem As ToolStripMenuItem
    Friend WithEvents BackupBase As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RestaurarBase As ToolStripMenuItem
End Class
