Imports System.ComponentModel

Public Class RegistroAdmin

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or Not IsNumeric(TDni.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
           String.IsNullOrWhiteSpace(TContra.Text) Or String.IsNullOrWhiteSpace(TRepcontra.Text) Or String.IsNullOrWhiteSpace(TDireccion.Text) Or Not IsNumeric(TTelefono.Text) Or
           Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBoxEstado.Text) Or IsNothing(PictureBox1.Image) Or String.IsNullOrWhiteSpace(TUsuario.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desea agregar el nuevo administrador?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then
                MsgBox("El administrador se registró correctamente", vbOKOnly + vbDefaultButton2 + vbInformation, "Confirmar")
            End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "D:"
        OpenFileDialog1.Filter = "Archivos imagenes|*.png|Archivos imagenes|*.jpg"
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

End Class