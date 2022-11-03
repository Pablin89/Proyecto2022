Public Class GerenteGral
    Dim emp = New DEmpleado
    Private Sub BSalir1_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está a punto de cerrar su sesión, ¿Desea continuar?", vbYesNo + vbExclamation, "Cerrar Sesión")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Principal.Show()

        End If

    End Sub

    Private Sub BSalir1_MouseHover(sender As Object, e As EventArgs) Handles BCerrarSesion.MouseHover
        LSalirG.Font = New Font(LSalirG.Font.Name, 14)

    End Sub

    Private Sub BSalir1_MouseLeave(sender As Object, e As EventArgs) Handles BCerrarSesion.MouseLeave
        LSalirG.Font = New Font(LSalirG.Font.Name, 12)

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub GerenteGral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        LSuper.Text = "Super Administrador:" + " " + empDatos.nombre_empleado + " " + empDatos.apellido_empleado
    End Sub

    Private Sub AñadirEncargadoItem_Click(sender As Object, e As EventArgs) Handles AñadirEncargadoItem.Click
        PermisosUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub BackupBase_Click(sender As Object, e As EventArgs) Handles BackupBase.Click
        BackupDatos.Show()
        Me.Hide()

    End Sub

    Private Sub RestaurarBase_Click(sender As Object, e As EventArgs) Handles RestaurarBase.Click
        RestaurarDatos.Show()
        Me.Hide()
    End Sub
End Class