Public Class ReportesCliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Gerente.Show()
        End If
    End Sub
End Class