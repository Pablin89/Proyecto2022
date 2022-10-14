Public Class ModificarAdmin
    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or Not IsNumeric(TDni.Text) Or String.IsNullOrWhiteSpace(TUsuario.Text) Or
           String.IsNullOrWhiteSpace(TContra.Text) Or String.IsNullOrWhiteSpace(TRepecontra.Text) Or String.IsNullOrWhiteSpace(TDireccion.Text) Or Not IsNumeric(TTelefono.Text) Or
           Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBoxEstado.Text) Or IsNothing(PictureBox1.Image) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Modificar")
        Else
            op = MsgBox("¿Estas seguro de modificar los datos?", vbYesNo + vbDefaultButton2 + vbInformation, "Modificar")
            If op = DialogResult.Yes Then
                MsgBox("Los datos se modificaron correctamente", vbOKOnly + vbDefaultButton2 + vbInformation, "Modificar")
            End If
        End If
    End Sub

    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress, TNombre.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress, TTelefono.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "D:"
        OpenFileDialog1.Filter = "Archivos imagenes|*.png|Archivos imagenes|*.jpg"
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub
End Class