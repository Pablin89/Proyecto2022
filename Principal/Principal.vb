Public Class Principal
    Dim us = New DUsuario
    Dim emp = New DEmpleado
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LUsuario.Visible = False
        LContraseña.Visible = False
        TUsuario.Visible = False
        TContraseña.Visible = False
        BSesion.Visible = False

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            LCarga.Text = "Cargando: " & ProgressBar1.Value & "%"
        Else
            LCarga.Visible = False
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            LUsuario.Visible = True
            LContraseña.Visible = True
            TUsuario.Visible = True
            TContraseña.Visible = True
            BSesion.Visible = True
            PictureBox2.Dock = DockStyle.Left
            PictureBox2.Width = 200
            PictureBox2.Height = 151
            TUsuario.Focus()

        End If
    End Sub


    Private Sub BSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BSesion_Click(sender As Object, e As EventArgs) Handles BSesion.Click

        Dim isValidLogin As Boolean = us.login(TUsuario.Text, TContraseña.Text)
        Dim datos As Integer = us.login_id(TUsuario.Text, TContraseña.Text)

        If isValidLogin = True And datos = 1 Then
            Cajeros.Show()
            Me.Hide()
        ElseIf isValidLogin = True And datos = 2 Then
            Encargado.Show()
            Me.Hide()
        ElseIf isValidLogin = True And datos = 3 Then
            Gerente.Show()
            Me.Hide()
        ElseIf isValidLogin = False And datos = 0 Then
            MsgBox("Usuario o Contraseña incorrectos!, por favor verifique.", vbOKOnly + vbCritical, "Inicio Sesion")
        Else
            GerenteGral.Show()
            Me.Hide()
        End If

    End Sub
End Class
