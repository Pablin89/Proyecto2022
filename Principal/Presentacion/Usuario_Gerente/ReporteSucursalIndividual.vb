﻿Public Class ReporteSucursalIndividual

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Gerente.Show()
        End If
    End Sub

    Private Sub CHfecha_CheckedChanged(sender As Object, e As EventArgs)
        If CHfecha.Checked = True Then
            CHmes.Checked = False
            DateDesde.Enabled = True
            DateHasta.Enabled = True
            CBcategoria.Enabled = True
            CBproducto.Enabled = True
            CHfecha.Font = New Font(CHfecha.Font.Bold, 13)
        Else
            DateDesde.Enabled = False
            DateHasta.Enabled = False
            CBcategoria.Enabled = False
            CBproducto.Enabled = False
            CHfecha.Font = New Font(CHfecha.Font.Name, 12)
        End If
    End Sub

    Private Sub CHmes_CheckedChanged(sender As Object, e As EventArgs)
        If CHmes.Checked = True Then
            CHfecha.Checked = False
            CBcategoria.Enabled = True
            CBproducto.Enabled = True
            CBmes.Enabled = True
            CBaño.Enabled = True
            CHmes.Font = New Font(CHmes.Font.Bold, 13)

        Else
            CBmes.Enabled = False
            CBaño.Enabled = False
            CBcategoria.Enabled = False
            CBproducto.Enabled = False
            CHmes.Font = New Font(CHmes.Font.Name, 12)
        End If
    End Sub

    Private Sub ReportesSucursalIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportesSucursalIndividual_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Gerente.Show()
    End Sub
End Class