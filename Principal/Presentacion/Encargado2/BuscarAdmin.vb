Public Class BuscarAdmin
    Private Sub CBapellido_CheckedChanged(sender As Object, e As EventArgs) Handles CBapellido.CheckedChanged

        If CBapellido.Checked = True Then
            CBapellido.Font = New Font(CBapellido.Font.Bold, 13)
            TApellido.Enabled = True
        Else
            CBapellido.Font = New Font(CBapellido.Font.Name, 12)
            TApellido.Enabled = False
        End If
    End Sub

    Private Sub CBnombre_CheckedChanged(sender As Object, e As EventArgs) Handles CBnombre.CheckedChanged
        If CBnombre.Checked = True Then
            CBnombre.Font = New Font(CBnombre.Font.Bold, 13)
            TNombre.Enabled = True
        Else
            CBnombre.Font = New Font(CBnombre.Font.Name, 12)
            TNombre.Enabled = False
        End If
    End Sub

    Private Sub CBdni_CheckedChanged(sender As Object, e As EventArgs) Handles CBdni.CheckedChanged
        If CBdni.Checked = True Then
            CBdni.Font = New Font(CBdni.Font.Bold, 13)
            TDni.Enabled = True
        Else
            CBdni.Font = New Font(CBdni.Font.Name, 12)
            TDni.Enabled = False
        End If
    End Sub

    Private Sub CBcorreo_CheckedChanged(sender As Object, e As EventArgs) Handles CBcorreo.CheckedChanged
        If CBcorreo.Checked = True Then
            CBcorreo.Font = New Font(CBcorreo.Font.Bold, 13)
            TCorreo.Enabled = True
        Else
            CBcorreo.Font = New Font(CBcorreo.Font.Name, 12)
            TCorreo.Enabled = False
        End If
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress, TNombre.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class
