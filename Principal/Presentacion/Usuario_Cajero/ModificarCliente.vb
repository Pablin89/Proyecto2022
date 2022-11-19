Imports System.ComponentModel

Public Class ModificarCliente
    Dim objcliente = New NCliente
    Dim cli = New DCliente
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido2.KeyPress, TNombre2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo2.Text) Or
           String.IsNullOrWhiteSpace(MTelefono.Text) Or String.IsNullOrWhiteSpace(TDireccion.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or EmailValido(TCorreo2.Text) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Modificar")
        Else
            op = MsgBox("¿Desea modificar los datos del Cliente?", vbYesNo + vbDefaultButton2 + vbInformation, "Modificar")
            If op = DialogResult.Yes And RBmasculino.Checked = True Then
                If (cli.modificar_cliente(TDni2.Text, TNombre2.Text, TApellido2.Text, TDireccion.Text, MTelefono.Text, RBmasculino.Text, TCorreo2.Text, GestionCliente.dgvCliente.CurrentRow.Cells(0).Value)) Then
                    op = MsgBox("Los datos se actualizaron correctamente", vbOKOnly + vbInformation, "Modificar")
                    If op = MsgBoxResult.Ok Then
                        Me.Close()
                        GestionCliente.Show()
                        objcliente.cargarGrid(GestionCliente.dgvCliente)
                    End If
                Else
                    MsgBox("Los datos no se pudieron modificar", vbOKOnly + vbCritical, "Modificar")
                End If
            ElseIf op = MsgBoxResult.Yes And RBfemenino.Checked = True Then

                If (cli.modificar_cliente(TDni2.Text, TNombre2.Text, TApellido2.Text, TDireccion.Text, MTelefono.Text, RBfemenino.Text, TCorreo2.Text, GestionCliente.dgvCliente.CurrentRow.Cells(0).Value)) Then
                    op = MsgBox("Los datos se actualizaron correctamente", vbOKOnly + vbInformation, "Modificar")
                    If op = MsgBoxResult.Ok Then
                        Me.Close()
                        GestionCliente.Show()
                        objcliente.cargarGrid(GestionCliente.dgvCliente)
                    End If
                Else
                    MsgBox("Los datos no se pudieron modificar", vbOKOnly + vbCritical, "Modificar")
                End If


            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            GestionCliente.Show()
        End If
    End Sub

    Private Sub ModificarCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GestionCliente.Show()
    End Sub

    Private Sub TCorreo2_Validating(sender As Object, e As CancelEventArgs) Handles TCorreo2.Validating
        If EmailValido(TCorreo2.Text) = False Then
            ErrorCorreo.SetError(sender, "debe introducir una dirección de correo")
        Else
            ErrorCorreo.SetError(sender, "")
        End If
    End Sub

    Private Shared Function EmailValido(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function
End Class