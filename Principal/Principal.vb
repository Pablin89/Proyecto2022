Public Class Principal

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


        If TUsuario.Text = "Encargado" Then
            Me.Hide()
            Encargado.Show()
        ElseIf TUsuario.Text = "Gerente" Then
            Me.Hide()
            Gerente.Show()
        ElseIf TUsuario.Text = "Cajero" Then
            Me.Hide()
            Cajeros.Show()
        ElseIf TUsuario.Text = "GerenteGral" Then
            Me.Hide()
            GerenteGral.Show()
        Else
            MsgBox("El usuario o contraseña ingresados son incorrectos. Intente nuevamente o pongase en contacto con el administrador del sistema.", MsgBoxStyle.Critical, "Problema de inicio de sesión")

        End If


    End Sub
End Class
