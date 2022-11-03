Public Class MisVentas
    Dim objfactura = New NFactura
    Dim objdetalle = New NDetalle
    Dim det = New DDetalle
    Dim fac = New DFactura
    Dim cli = New DCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
        End If

    End Sub

    Private Sub MisVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub

    Private Sub MisVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objfactura.cargarGrid(dgvFactura)
    End Sub

    Private Sub dgvFactura_Click(sender As Object, e As EventArgs) Handles dgvFactura.Click
        Dim i As Integer = dgvFactura.CurrentRow.Index

        det.ver_detalle(dgvFactura.Rows(i).Cells(0).Value, dgvDetalle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        fac.buscar_nombre(TextBox1.Text, dgvFactura)
    End Sub
End Class