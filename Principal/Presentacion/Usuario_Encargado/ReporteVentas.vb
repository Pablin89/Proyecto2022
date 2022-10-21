Public Class ReporteVentas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Encargado.Show()
        End If
    End Sub

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBCajero_CheckedChanged(sender As Object, e As EventArgs) Handles CBCajero.CheckedChanged
        If CBCajero.Checked = True Then
            CBCliente.Checked = False
            CBProducto.Checked = False
            TCajero.Enabled = True
            TCliente.Enabled = False
            TCliente.Clear()
            TProducto.Enabled = False
            TProducto.Clear()

        End If
    End Sub

    Private Sub CBCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CBCliente.CheckedChanged
        If CBCliente.Checked = True Then
            CBCajero.Checked = False
            TCajero.Clear()
            CBProducto.Checked = False
            TCliente.Enabled = True
            TCajero.Enabled = False
            TProducto.Enabled = False
            TProducto.Clear()
        End If

    End Sub

    Private Sub CBProducto_CheckedChanged(sender As Object, e As EventArgs) Handles CBProducto.CheckedChanged
        If CBProducto.Checked = True Then
            CBCliente.Checked = False
            CBCajero.Checked = False
            TProducto.Enabled = True
            TCliente.Enabled = False
            TCliente.Clear()
            TCajero.Enabled = False
            TCajero.Clear()
        End If
    End Sub
End Class