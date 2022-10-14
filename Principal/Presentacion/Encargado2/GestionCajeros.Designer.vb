<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCajeros
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
        Me.TabModificacionCajeros = New System.Windows.Forms.TabControl()
        Me.TabAgregarCajero = New System.Windows.Forms.TabPage()
        Me.TabModificarCajero = New System.Windows.Forms.TabPage()
        Me.LinkMenú = New System.Windows.Forms.LinkLabel()
        Me.TabEliminarCajero = New System.Windows.Forms.TabPage()
        Me.TabModificacionCajeros.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabModificacionCajeros
        '
        Me.TabModificacionCajeros.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabModificacionCajeros.Controls.Add(Me.TabAgregarCajero)
        Me.TabModificacionCajeros.Controls.Add(Me.TabModificarCajero)
        Me.TabModificacionCajeros.Controls.Add(Me.TabEliminarCajero)
        Me.TabModificacionCajeros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabModificacionCajeros.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabModificacionCajeros.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabModificacionCajeros.Location = New System.Drawing.Point(0, 0)
        Me.TabModificacionCajeros.Name = "TabModificacionCajeros"
        Me.TabModificacionCajeros.Padding = New System.Drawing.Point(80, 30)
        Me.TabModificacionCajeros.SelectedIndex = 0
        Me.TabModificacionCajeros.Size = New System.Drawing.Size(800, 650)
        Me.TabModificacionCajeros.TabIndex = 0
        '
        'TabAgregarCajero
        '
        Me.TabAgregarCajero.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabAgregarCajero.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabAgregarCajero.Location = New System.Drawing.Point(4, 99)
        Me.TabAgregarCajero.Name = "TabAgregarCajero"
        Me.TabAgregarCajero.Padding = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.TabAgregarCajero.Size = New System.Drawing.Size(792, 547)
        Me.TabAgregarCajero.TabIndex = 0
        Me.TabAgregarCajero.Text = "Agregar Cajeros"
        '
        'TabModificarCajero
        '
        Me.TabModificarCajero.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabModificarCajero.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabModificarCajero.Location = New System.Drawing.Point(4, 99)
        Me.TabModificarCajero.Name = "TabModificarCajero"
        Me.TabModificarCajero.Padding = New System.Windows.Forms.Padding(3)
        Me.TabModificarCajero.Size = New System.Drawing.Size(792, 547)
        Me.TabModificarCajero.TabIndex = 1
        Me.TabModificarCajero.Text = "Modificar Cajeros"
        '
        'LinkMenú
        '
        Me.LinkMenú.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkMenú.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkMenú.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkMenú.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkMenú.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkMenú.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkMenú.Location = New System.Drawing.Point(0, 650)
        Me.LinkMenú.Name = "LinkMenú"
        Me.LinkMenú.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.LinkMenú.Size = New System.Drawing.Size(800, 0)
        Me.LinkMenú.TabIndex = 1
        Me.LinkMenú.TabStop = True
        Me.LinkMenú.Text = "<---Volver al menú principal"
        Me.LinkMenú.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabEliminarCajero
        '
        Me.TabEliminarCajero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabEliminarCajero.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabEliminarCajero.Location = New System.Drawing.Point(4, 99)
        Me.TabEliminarCajero.Name = "TabEliminarCajero"
        Me.TabEliminarCajero.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEliminarCajero.Size = New System.Drawing.Size(792, 547)
        Me.TabEliminarCajero.TabIndex = 2
        Me.TabEliminarCajero.Text = "EliminarCajero"
        '
        'GestionCajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.LinkMenú)
        Me.Controls.Add(Me.TabModificacionCajeros)
        Me.Name = "GestionCajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Cajeros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabModificacionCajeros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabModificacionCajeros As TabControl
    Friend WithEvents TabAgregarCajero As TabPage
    Friend WithEvents TabModificarCajero As TabPage
    Friend WithEvents LinkMenú As LinkLabel
    Friend WithEvents TabEliminarCajero As TabPage
End Class
