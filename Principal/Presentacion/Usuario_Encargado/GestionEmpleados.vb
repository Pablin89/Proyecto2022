Imports System.ComponentModel


Public Class GestionEmpleados
    Dim objempleado = New NEmpleado
    Dim emp = New DEmpleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Encargado.Show()
        End If

    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress, TDni2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress, TNombre.KeyPress, TApellido2.KeyPress, TNombre2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click

        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
            String.IsNullOrWhiteSpace(TDireccion.Text) Or String.IsNullOrWhiteSpace(MTelefono.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBoxEstado.Text) Or
            EmailValido(TCorreo.Text) = False Or FechaValida(DTfecha.Value.Year) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
            Exit Sub
        End If

        Dim op As MsgBoxResult
        op = MsgBox("¿Desea agregar el nuevo empleado?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")

        If MsgBoxResult.Yes = op And RBmasculino.Checked Then

            If emp.existe_empleado(TDni2.Text) = False Then
                objempleado.agregar_empleado(CInt(TDni2.Text), TNombre2.Text, TApellido2.Text, RBmasculino.Text, DTfecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBoxEstado.Text)

                MsgBox("El empleado se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
                objempleado.cargarGrid(dgEmpleados)

            Else
                MsgBox("El empleado ya existe", vbOKOnly + vbDefaultButton2 + vbCritical, "Confirmar")


            End If

            TDni2.Clear()
            TNombre2.Clear()
            TApellido2.Clear()
            TDireccion.Clear()
            TCorreo.Clear()
            MTelefono.Clear()
            RBmasculino.Checked = False

        ElseIf MsgBoxResult.Yes = op And RBfemenino.Checked Then

            If emp.existe_empleado(TNombre2.Text, TApellido2.Text, TDni2.Text) = False Then
                objempleado.agregar_empleado(CInt(TDni2.Text), TNombre2.Text, TApellido2.Text, RBmasculino.Text, DTfecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBoxEstado.Text)

                MsgBox("El empleado se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
                objempleado.cargarGrid(dgEmpleados)

            Else
                MsgBox("El empleado ya existe", vbOKOnly + vbDefaultButton2 + vbCritical, "Confirmar")


            End If


            TDni2.Clear()
            TNombre2.Clear()
            TApellido2.Clear()
            TDireccion.Clear()
            TCorreo.Clear()
            MTelefono.Clear()
            RBfemenino.Checked = False
        End If

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

        End If
    End Sub
    Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objempleado.cargarGrid(dgEmpleados)
    End Sub

    Private Sub GestionCajeros_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Encargado.Show()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim emp = New DEmpleado

        If Not String.IsNullOrEmpty(TNombre.Text) And RBnombre.Checked = True Then
            emp.buscar_nombre(TNombre.Text, dgEmpleados)
        ElseIf Not String.IsNullOrEmpty(TApellido.Text) And rbapellido.Checked = True Then
            emp.buscar_apellido(TApellido.Text, dgEmpleados)
        ElseIf Not String.IsNullOrEmpty(TDni.Text) And rbdni.Checked = True Then
            emp.buscar_dni(TDni.Text, dgEmpleados)
        Else
            emp.buscar_estado(ComboEstado.Text, dgEmpleados)
        End If
    End Sub

    Private Shared Function EmailValido(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Private Sub TCorreo_Validating(sender As Object, e As CancelEventArgs) Handles TCorreo.Validating
        If EmailValido(TCorreo.Text) = False Then
            ErrorCorreo.SetError(sender, "debe introducir una dirección de correo")
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

    Private Sub DTfecha_Validating(sender As Object, e As CancelEventArgs) Handles DTfecha.Validating
        If FechaValida(DTfecha.Value.Year) = True Then
            ErrorFecha.SetError(sender, "")
        Else
            ErrorFecha.SetError(sender, "debe ingresar una fecha correcta")
        End If
    End Sub

    Private Sub dgEmpleados_Click(sender As Object, e As EventArgs) Handles dgEmpleados.Click

        If dgEmpleados.CurrentRow IsNot Nothing Then
            BModificar.Enabled = True
            BEliminar.Enabled = True
        Else
            BModificar.Enabled = False
            BEliminar.Enabled = False
        End If

        Dim i As Integer
        i = dgEmpleados.CurrentRow.Index

        ModificarEmpleado.TNombre2.Text = dgEmpleados.Rows(i).Cells(2).Value.ToString
        ModificarEmpleado.TDni2.Text = dgEmpleados.Rows(i).Cells(1).Value.ToString
        ModificarEmpleado.TApellido2.Text = dgEmpleados.Rows(i).Cells(3).Value.ToString
        ModificarEmpleado.TDireccion.Text = dgEmpleados.Rows(i).Cells(6).Value
        ModificarEmpleado.TCorreo.Text = dgEmpleados.Rows(i).Cells(7).Value
        ModificarEmpleado.MTelefono.Text = dgEmpleados.Rows(i).Cells(8).Value
        ModificarEmpleado.DTFecha.Value = dgEmpleados.Rows(i).Cells(5).Value
        ModificarEmpleado.CBEstado.Text = dgEmpleados.Rows(i).Cells(9).Value

        If dgEmpleados.Rows(i).Cells(4).Value.ToString = "Masculino" Then
            ModificarEmpleado.RBmasculino.Checked = True
            ModificarEmpleado.RBfemenino.Checked = False
        Else
            ModificarEmpleado.RBfemenino.Checked = True
            ModificarEmpleado.RBmasculino.Checked = False
        End If

    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        ModificarEmpleado.Show()
        BModificar.Enabled = False
        BEliminar.Enabled = False
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult

        If dgEmpleados.CurrentRow.Cells(9).Value = 1 Then
            ask = MsgBox("¿Estas seguro de dar de baja al empleado?", vbYesNo + vbInformation, "Eliminar")

            If ask = MsgBoxResult.Yes Then
                emp.baja_empleado(0, dgEmpleados.CurrentRow.Cells(0).Value.ToString)
                objempleado.cargarGrid(dgEmpleados)
            End If
        Else
            MsgBox("El empleado ya esta dado de baja", vbOKOnly + vbExclamation, "Eliminar")
        End If
        BEliminar.Enabled = False
        BModificar.Enabled = False

    End Sub

    Private Sub RBapellido_CheckedChanged(sender As Object, e As EventArgs) Handles RBapellido.CheckedChanged
        If RBapellido.Checked = True Then
            TApellido.Enabled = True
        Else
            TApellido.Enabled = False
        End If
    End Sub

    Private Sub RBnombre_CheckedChanged(sender As Object, e As EventArgs) Handles RBnombre.CheckedChanged
        If RBnombre.Checked = True Then
            TNombre.Enabled = True
        Else
            TNombre.Enabled = False
        End If
    End Sub

    Private Sub RBdni_CheckedChanged(sender As Object, e As EventArgs) Handles RBdni.CheckedChanged
        If RBdni.Checked = True Then
            TDni.Enabled = True
        Else
            TDni.Enabled = False
        End If
    End Sub

    Private Sub RBestado_CheckedChanged(sender As Object, e As EventArgs) Handles RBestado.CheckedChanged
        If RBestado.Checked = True Then
            ComboEstado.Enabled = True
        Else
            ComboEstado.Enabled = False
        End If
    End Sub
End Class