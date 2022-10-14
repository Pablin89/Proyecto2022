<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encargado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encargado))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LHora = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.MenuEncargado = New System.Windows.Forms.MenuStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MisDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDeMiSucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuEncargado.SuspendLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.LHora)
        Me.Panel1.Controls.Add(Me.LFecha)
        Me.Panel1.Controls.Add(Me.LUsuario)
        Me.Panel1.Controls.Add(Me.PBLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1130, 149)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(997, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 147)
        Me.Panel3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(19, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cerrar Sesión"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHora.ForeColor = System.Drawing.Color.Black
        Me.LHora.Location = New System.Drawing.Point(175, 59)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(58, 25)
        Me.LHora.TabIndex = 5
        Me.LHora.Text = "Hora"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(175, 15)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(72, 25)
        Me.LFecha.TabIndex = 4
        Me.LFecha.Text = "Fecha"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.Black
        Me.LUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LUsuario.Location = New System.Drawing.Point(475, 6)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(236, 25)
        Me.LUsuario.TabIndex = 3
        Me.LUsuario.Text = "Encargado: José Perez"
        Me.LUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuEncargado
        '
        Me.MenuEncargado.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuEncargado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuEncargado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuEncargado.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEncargado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MisDatosToolStripMenuItem, Me.ReportresToolStripMenuItem, Me.ToolStripMenuItem1, Me.DatosDeMiSucursalToolStripMenuItem})
        Me.MenuEncargado.Location = New System.Drawing.Point(0, 149)
        Me.MenuEncargado.MdiWindowListItem = Me.ReportresToolStripMenuItem
        Me.MenuEncargado.Name = "MenuEncargado"
        Me.MenuEncargado.Size = New System.Drawing.Size(1130, 279)
        Me.MenuEncargado.TabIndex = 5
        Me.MenuEncargado.Text = "MenuStrip1"
        '
        'Timer1
        '
        '
        'MisDatosToolStripMenuItem
        '
        Me.MisDatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MisDatosToolStripMenuItem.Image = Global.Principal.My.Resources.Resources.product_document_file_1512
        Me.MisDatosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MisDatosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.MisDatosToolStripMenuItem.Name = "MisDatosToolStripMenuItem"
        Me.MisDatosToolStripMenuItem.Size = New System.Drawing.Size(268, 275)
        Me.MisDatosToolStripMenuItem.Text = "Administrar productos"
        Me.MisDatosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MisDatosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ReportresToolStripMenuItem
        '
        Me.ReportresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportresToolStripMenuItem.Image = Global.Principal.My.Resources.Resources.users_clients_group_167741
        Me.ReportresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportresToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ReportresToolStripMenuItem.Name = "ReportresToolStripMenuItem"
        Me.ReportresToolStripMenuItem.Size = New System.Drawing.Size(268, 275)
        Me.ReportresToolStripMenuItem.Text = "Administrar Cajeros"
        Me.ReportresToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReportresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripMenuItem1.Image = Global.Principal.My.Resources.Resources._1111111
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 275)
        Me.ToolStripMenuItem1.Text = "Mis Datos Personales"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'DatosDeMiSucursalToolStripMenuItem
        '
        Me.DatosDeMiSucursalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DatosDeMiSucursalToolStripMenuItem.Image = Global.Principal.My.Resources.Resources.ubi
        Me.DatosDeMiSucursalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DatosDeMiSucursalToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.DatosDeMiSucursalToolStripMenuItem.Name = "DatosDeMiSucursalToolStripMenuItem"
        Me.DatosDeMiSucursalToolStripMenuItem.Size = New System.Drawing.Size(268, 275)
        Me.DatosDeMiSucursalToolStripMenuItem.Text = "Datos de mi Sucursal"
        Me.DatosDeMiSucursalToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DatosDeMiSucursalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(40, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(62, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.Principal.My.Resources.Resources.Messirve__1_
        Me.PBLogo.Location = New System.Drawing.Point(3, 3)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(141, 141)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 0
        Me.PBLogo.TabStop = False
        Me.PBLogo.WaitOnLoad = True
        '
        'Encargado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 428)
        Me.Controls.Add(Me.MenuEncargado)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Encargado"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Encargado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuEncargado.ResumeLayout(False)
        Me.MenuEncargado.PerformLayout()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LHora As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents MisDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuEncargado As MenuStrip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReportresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDeMiSucursalToolStripMenuItem As ToolStripMenuItem
End Class
