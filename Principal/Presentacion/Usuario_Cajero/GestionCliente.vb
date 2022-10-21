Imports System.ComponentModel

Public Class GestionCliente

    Dim objCliente = New NCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Cajeros.Show()
        End If

    End Sub

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

    Private Sub CBestado_CheckedChanged(sender As Object, e As EventArgs) Handles CBcorreo.CheckedChanged
        If CBcorreo.Checked = True Then
            CBcorreo.Font = New Font(CBcorreo.Font.Bold, 13)
            TCorreo2.Enabled = True
        Else
            CBcorreo.Font = New Font(CBcorreo.Font.Name, 12)
            TCorreo2.Enabled = False
        End If
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress, TDni2.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress, TNombre.KeyPress, TApellido2.KeyPress, TNombre2.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
           String.IsNullOrWhiteSpace(TDireccion.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or EmailValido(TCorreo.Text) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desea agregar el nuevo Cliente?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes And RBmasculino.Checked Then

                If (objCliente.agregar_cliente(TDni2.Text, TNombre2.Text, TApellido2.Text, TDireccion.Text, MTelefono.Text, RBmasculino.Text, TCorreo.Text)) Then

                    MsgBox("El cliente se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
                    objCliente.cargarGrid(dgvCliente)


                Else
                    MsgBox("El cliente ya existe", vbOKOnly + vbCritical, "Confirmar")
                    TDni.Focus()

                End If
                TDni2.Clear()
                TNombre2.Clear()
                TApellido2.Clear()
                TDireccion.Clear()
                TCorreo.Clear()
                MTelefono.Clear()
                RBmasculino.Checked = False

            ElseIf op = DialogResult.Yes And RBfemenino.Checked Then
                If (objCliente.agregar_cliente(TDni2.Text, TNombre2.Text, TApellido2.Text, TDireccion.Text, MTelefono.Text, TCorreo.Text, RBfemenino.Text)) Then
                    MsgBox("El cliente se registro correctamente", vbOKOnly + vbInformation, "Confirmar")

                    objCliente.cargarGrid(dgvCliente)

                Else
                    MsgBox("El cliente ya existe", vbOKOnly + vbCritical, "Confirmar")
                    TDni.Focus()

                End If
                TDni2.Clear()
                TNombre2.Clear()
                TApellido2.Clear()
                TDireccion.Clear()
                TCorreo.Clear()
                MTelefono.Clear()
                RBfemenino.Checked = False
            End If

        End If
    End Sub

    Private Sub GestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCliente.cargarGrid(dgvCliente)
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Estas seguro de cancelar el registro?", vbYesNo + vbExclamation, "Cancelar")

        If ask = DialogResult.Yes Then
            TDni2.Clear()
            TNombre2.Clear()
            TApellido2.Clear()
            TDireccion.Clear()
            TCorreo.Clear()
            MTelefono.Clear()
            RBmasculino.Checked = False
            RBfemenino.Checked = False

        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If String.IsNullOrWhiteSpace(TNombre.Text) And String.IsNullOrWhiteSpace(TApellido.Text) And String.IsNullOrWhiteSpace(TDni.Text) And EmailValido(TCorreo2.Text) = False Then
            MsgBox("Debe realizar la busqueda por al menos una opcion", vbOKOnly + vbExclamation, "Buscar")

        End If
    End Sub

    Private Sub GestionCliente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub

    Private Sub TCorreo_Validating(sender As Object, e As CancelEventArgs) Handles TCorreo.Validating
        If EmailValido(TCorreo.Text) = False Then
            ErrorCorreo.SetError(sender, "debe introducir una dirección de correo")
        Else
            ErrorCorreo.SetError(sender, "")
        End If
    End Sub
    Private Shared Function EmailValido(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Private Sub TCorreo2_Validating(sender As Object, e As CancelEventArgs) Handles TCorreo2.Validating
        If EmailValido(TCorreo.Text) = False Then
            ErrorCorreo2.SetError(sender, "debe introducir una dirección de correo")
        Else
            ErrorCorreo2.SetError(sender, "")
        End If
    End Sub

    Private Sub BVentas_Click(sender As Object, e As EventArgs) Handles BVentas.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver a la sección de ventas?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Facturacion.Show()
        End If

    End Sub
End Class