﻿Imports System.ComponentModel

Public Class GestionEmpleados
    Dim objEmpleado = New NEmpleado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Encargado.Show()
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

    Private Sub CBestado_CheckedChanged(sender As Object, e As EventArgs) Handles CBestado.CheckedChanged
        If CBestado.Checked = True Then
            CBestado.Font = New Font(CBestado.Font.Bold, 13)
            ComboEstado.Enabled = True
        Else
            CBestado.Font = New Font(CBestado.Font.Name, 12)
            ComboEstado.Enabled = False
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
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click

        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
            String.IsNullOrWhiteSpace(TDireccion.Text) Or String.IsNullOrWhiteSpace(MTelefono.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBoxEstado.Text) Or IsNothing(PictureBox1.Image) Or
            EmailValido(TCorreo.Text) = False Or FechaValida(DTfecha.Value.Year) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desea agregar el nuevo cajero?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then

                If (objEmpleado.agregar_empleado(CInt(TDni2.Text), TNombre2.Text, TApellido2.Text, RBmasculino.Text, DTfecha.Text, TDireccion.Text, TCorreo.Text, MTelefono.Text, PictureBox1.Image, CBoxEstado.Text)) Then

                    MsgBox("El cajero se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
                    objEmpleado.cargarGrid(DataGridView1)

                Else
                    MsgBox("El empleado ya existe", vbOKOnly + vbCritical, "Confirmar")
                    TDni2.Focus()

                End If

                TDni2.Clear()
                TNombre2.Clear()
                TApellido2.Clear()
                TDireccion.Clear()
                TCorreo.Clear()
                MTelefono.Clear()
                PictureBox1.Image = Nothing
                RBmasculino.Checked = False
                RBfemenino.Checked = False


            End If
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.InitialDirectory = "D:"
        OpenFileDialog1.Filter = "Archivos imagenes|*.png|Archivos imagenes|*.jpg"
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
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
            PictureBox1.Image = Nothing
            RBmasculino.Checked = False
            RBfemenino.Checked = False

        End If
    End Sub

    Private Sub GestionCajeros_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Encargado.Show()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        If String.IsNullOrWhiteSpace(TNombre.Text) And String.IsNullOrWhiteSpace(TApellido.Text) And String.IsNullOrWhiteSpace(TDni.Text) And String.IsNullOrWhiteSpace(ComboEstado.Text) Then
            MsgBox("Debe realizar la busqueda por al menos una opcion", vbOKOnly + vbExclamation, "Buscar")

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
            ErrorFecha.SetError(sender, "debe ingresar fecha correcta")
        End If
    End Sub

    Private Sub GestionEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objEmpleado.cargarGrid(DataGridView1)
    End Sub
End Class