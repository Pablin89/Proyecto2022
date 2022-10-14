Public Class Encargado
    Private Sub Encargado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub


    Private Sub Cajeros_MouseHover(sender As Object, e As EventArgs)

        TTMenuEncargado.SetToolTip(MenuEncargado, "Esta función permite agregar, editar y eliminar cajeros, unicamente en su propia sucursal. ")
        TTMenuEncargado.ToolTipTitle = "Gestión de Cajeros"
        TTMenuEncargado.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub MisDatosPersonalesToolStripMenuItem_MouseHover(sender As Object, e As EventArgs)
        TTMenuEncargado.SetToolTip(MenuEncargado, " Esta función le permite gestionar sus datos personales y de inicio de sesión.")
        TTMenuEncargado.ToolTipTitle = "Gestión de Datos Personales"
        TTMenuEncargado.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub MenuEncargado_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está a punto de cerrar su sesión, ¿Desea continuar?", vbYesNo + vbExclamation, "Cerrar Sesión")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Principal.Show()

        End If
    End Sub


    Private Sub GestiónCajerosItem_Click_1(sender As Object, e As EventArgs) Handles GestiónCajerosItem.Click
        GestionEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub VentasItem_Click(sender As Object, e As EventArgs) Handles VentasItem.Click
        GestionVentas.Show()
        Me.Hide()
    End Sub

    Private Sub GestiónProductosItem_Click(sender As Object, e As EventArgs) Handles GestiónProductosItem.Click
        GestionProductos.Show()
        Me.Hide()
    End Sub

    Private Sub MisDatosPersonalesItem_Click(sender As Object, e As EventArgs)
        MisDatos.Show()
        Me.Hide()
    End Sub
End Class