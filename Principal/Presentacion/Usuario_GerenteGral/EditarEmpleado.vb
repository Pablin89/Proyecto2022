Public Class EditarEmpleado
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Está seguro que desea salir? Si ha realizado un cambio no se guardará", vbYesNo + vbExclamation, "Salir sin guardar")

        If ask = MsgBoxResult.Yes Then

            Me.Close()

        End If

    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TDni.Text) Or String.IsNullOrWhiteSpace(TUsuario.Text) Or Not IsNumeric(TDni.Text) Or String.IsNullOrWhiteSpace(TRepcontra.Text) Or
           String.IsNullOrWhiteSpace(TContraseña.Text) Or String.IsNullOrWhiteSpace(CBperfil.Text) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Completar campos")
        Else
            op = MsgBox("¿Desea guardar los cambios?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then
                MsgBox("Los cambios se realizaron correctamente", vbOKOnly + vbDefaultButton1 + vbInformation, "Cambios realizados")
                Me.Close()
            End If
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


End Class