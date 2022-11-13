Public Class GestionVentas
    Dim objfactura = New NFactura
    Dim fact = New DFactura

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Encargado.Show()
        End If
    End Sub

    Private Sub GestionVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Encargado.Show()
    End Sub

    Private Sub GestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objfactura.cargarGrid_ventas(dgvVentas)
    End Sub

    Private Sub TCajero_TextChanged(sender As Object, e As EventArgs) Handles TCajero.TextChanged
        fact.buscar_nombreCajero(TCajero.Text, dgvVentas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fact.buscar_fechaCajero(DTdesde.Value, DThasta.Value, dgvVentas)
    End Sub
End Class