Public Class GestionCajeros
    Private Sub LinkMenú_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMenú.LinkClicked
        Me.Hide()
        Encargado.Show()
    End Sub
End Class