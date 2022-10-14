Imports System.ComponentModel

Public Class MisDatos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            If Principal.TUsuario.Text = "Gerente" Then
                Me.Close()
                Gerente.Show()
            ElseIf Principal.TUsuario.Text = "Cajero" Then
                Me.Close()
                Cajeros.Show()
            ElseIf Principal.TUsuario.Text = "Encargado" Then
                Me.Close()
                Encargado.Show()
            ElseIf Principal.TUsuario.Text = "GerenteGral" Then
                Me.Close()
                GerenteGral.Show()
            End If


        End If
    End Sub

    Private Sub MisDatos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Principal.TUsuario.Text = "Gerente" Then
            Gerente.Show()
        ElseIf Principal.TUsuario.Text = "Cajero" Then
            Cajeros.Show()
        ElseIf Principal.TUsuario.Text = "Encargado" Then
            Encargado.Show()
        ElseIf Principal.TUsuario.Text = "GerenteGral" Then
            GerenteGral.Show()
        End If
    End Sub

End Class