Public Class Gerentes
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

    Private Sub Gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        LGerente.Text = "Gerente:" + " " + empDatos.nombre_empleado + " " + empDatos.apellido_empleado
    End Sub


    Private Sub GenerarReporte_Click(sender As Object, e As EventArgs) Handles ReportesCajeros.Click
        ReporteCajeros.Show()
        Me.Hide()
    End Sub

    Private Sub NumerosMes_Click(sender As Object, e As EventArgs) Handles NumerosMes.Click
        NumerosDelMes.Show()
        Me.Hide()
    End Sub

    Private Sub ReportesClientes_Click(sender As Object, e As EventArgs) Handles ReporteCategoria.Click
        ReporteCategorias.Show()
        Me.Hide()
    End Sub

    Private Sub ReporteMes_Click(sender As Object, e As EventArgs) Handles ReporteMes.Click
        ReportesMes.Show()
        Me.Hide()
    End Sub
End Class