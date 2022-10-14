Public Class EditarProducto
    Private Sub CBnombre_CheckedChanged(sender As Object, e As EventArgs) Handles CBnombre.CheckedChanged
        If CBnombre.Checked = True Then
            CBnombre.Font = New Font(CBnombre.Font.Bold, 13)
            TNombre.Enabled = True
        Else
            CBnombre.Font = New Font(CBnombre.Font.Name, 12)
            TNombre.Enabled = False
        End If
    End Sub

    Private Sub CBcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles CBcodigo.CheckedChanged
        If CBcodigo.Checked = True Then
            CBcodigo.Font = New Font(CBcodigo.Font.Bold, 13)
            TCodigo.Enabled = True
        Else
            CBcodigo.Font = New Font(CBcodigo.Font.Name, 12)
            TCodigo.Enabled = False
        End If
    End Sub

    Private Sub CBprecio_CheckedChanged(sender As Object, e As EventArgs) Handles CBprecio.CheckedChanged
        If CBprecio.Checked = True Then
            CBprecio.Font = New Font(CBprecio.Font.Bold, 13)
            TPrecio.Enabled = True
        Else
            CBprecio.Font = New Font(CBprecio.Font.Name, 12)
            TPrecio.Enabled = False
        End If
    End Sub

    Private Sub CBcat_CheckedChanged(sender As Object, e As EventArgs) Handles CBcat.CheckedChanged
        If CBcat.Checked = True Then
            CBcat.Font = New Font(CBcat.Font.Bold, 13)
            ComboCat.Enabled = True
        Else
            CBcat.Font = New Font(CBcat.Font.Name, 12)
            ComboCat.Enabled = False
        End If
    End Sub
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecio.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class