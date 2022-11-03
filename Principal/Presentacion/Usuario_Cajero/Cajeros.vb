Public Class Cajeros
    Dim emp = New DEmpleado

    Private Sub Cajeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        LCajero.Text = "Cajero:" + " " + empDatos.nombre_empleado + " " + empDatos.apellido_empleado
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está a punto de cerrar su sesión, ¿Desea continuar?", vbYesNo + vbExclamation, "Cerrar Sesión")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Principal.Show()

        End If
    End Sub

    Private Sub GestiónClientestem_Click(sender As Object, e As EventArgs) Handles GestiónClientestem.Click
        GestionCliente.Show()
        Me.Hide()
    End Sub

    Private Sub VentasItem_Click(sender As Object, e As EventArgs) Handles VentasItem.Click
        MisVentas.Show()
        Me.Hide()

    End Sub

    Private Sub ListarProductosItem_Click(sender As Object, e As EventArgs)
        ListarProductos.Show()
        Me.Hide()
    End Sub

    Private Sub FacturacionItem_Click(sender As Object, e As EventArgs) Handles FacturacionItem.Click
        Facturacion.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MisDatosItem.Click
        MisDatos.Show()
        Me.Hide()
    End Sub

    Private Sub ListaProductos_Click(sender As Object, e As EventArgs) Handles ListaProductos.Click
        ListarProductos.Show()
        Me.Hide()
    End Sub

End Class