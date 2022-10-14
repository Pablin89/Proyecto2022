Public Class NumerosDelMes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Gerente.Show()
        End If
    End Sub

    Private Sub ReportesVenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Gerente.Show()
    End Sub


End Class