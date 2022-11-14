Imports System.ComponentModel

Public Class ModificarEmpleado
    Dim emp = New DEmpleado
    Dim objempleado = New NEmpleado

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
           String.IsNullOrWhiteSpace(TDireccion.Text) Or String.IsNullOrWhiteSpace(MTelefono.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBEstado.Text) Or
           EmailValido(TCorreo.Text) = False Or FechaValida(DTFecha.Value.Year) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Modificar")
        Else
            op = MsgBox("Desea guardar los cambios?", vbYesNo + vbDefaultButton2 + vbInformation, "Modificar")
            If op = DialogResult.Yes And RBmasculino.Checked = True Then
                If (emp.modificar_empleado(TDni2.Text, TNombre2.Text, TApellido2.Text, RBmasculino.Text, DTFecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBEstado.Text, GestionEmpleados.dgEmpleados.CurrentRow.Cells(0).Value)) Then
                    op = MsgBox("Los datos se guardaron correctamente", vbOKOnly + vbInformation, "Modificar")
                    If op = MsgBoxResult.Ok Then
                        Me.Close()
                        GestionEmpleados.Show()
                        objempleado.cargarGrid(GestionEmpleados.dgEmpleados)
                        GestionEmpleados.dgEmpleados.ClearSelection()

                    End If
                Else

                    MsgBox("Los datos no se pudieron modificar", vbOKOnly)
                End If
            ElseIf op = DialogResult.Yes And RBfemenino.Checked = True Then
                If (emp.modificar_empleado(TDni2.Text, TNombre2.Text, TApellido2.Text, RBfemenino.Text, DTFecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBEstado.Text, GestionEmpleados.dgEmpleados.CurrentRow.Cells(0).Value)) Then
                    op = MsgBox("Los datos se guardaron correctamente", vbOKOnly + vbInformation, "Modificar")
                    If op = MsgBoxResult.Ok Then
                        Me.Close()
                        GestionEmpleados.Show()
                        objempleado.cargarGrid(GestionEmpleados.dgEmpleados)

                    End If
                Else

                    MsgBox("Los datos no se pudieron modificar", vbOKOnly)
                End If

            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GestionEmpleados.Show()
        End If
    End Sub
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTelefono.KeyPress, TDni2.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido2.KeyPress, TNombre2.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Shared Function EmailValido(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function


    Private Sub TCorreo_Validating(sender As Object, e As CancelEventArgs) Handles TCorreo.Validating
        If EmailValido(TCorreo.Text) = False Then
            ErrorCorreo.SetError(sender, "Debe introducir una dirección de correo")
        Else
            ErrorCorreo.SetError(sender, "")
        End If
    End Sub


    Private Shared Function FechaValida(fechanac As Integer) As Boolean
        Dim hoy As String = Now.Date.ToString("dd/MM/yy")
        Dim fechahoy As Integer
        Dim años As Integer

        fechahoy = CDate(hoy).Date.Year
        años = fechahoy - fechanac

        If años < 18 Then
            Return False
        End If

        Return True

    End Function

    Private Sub DTfecha_Validating(sender As Object, e As CancelEventArgs) Handles DTFecha.Validating
        If FechaValida(DTFecha.Value.Year) = True Then
            ErrorFecha.SetError(sender, "")
        Else
            ErrorFecha.SetError(sender, "Debe ingresar fecha correcta")
        End If
    End Sub

End Class