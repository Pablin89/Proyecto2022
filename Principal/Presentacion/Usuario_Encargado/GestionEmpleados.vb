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

        If String.IsNullOrWhiteSpace(TNombre2.Text) Or String.IsNullOrWhiteSpace(TApellido2.Text) Or Not IsNumeric(TDni2.Text) Or String.IsNullOrWhiteSpace(TCorreo.Text) Or
            String.IsNullOrWhiteSpace(TDireccion.Text) Or String.IsNullOrWhiteSpace(MTelefono.Text) Or Not RBmasculino.Checked And Not RBfemenino.Checked Or String.IsNullOrWhiteSpace(CBoxEstado.Text) Or IsNothing(PictureBox1.Image) Or
            EmailValido(TCorreo.Text) = False Or FechaValida(DTfecha.Value.Year) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
            Exit Sub
        End If

        Dim op As MsgBoxResult
        op = MsgBox("¿Desea agregar el nuevo empleado?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")

        If MsgBoxResult.Yes = op And RBmasculino.Checked Then

            If (objempleado.agregar_empleado(CInt(TDni2.Text), TNombre2.Text, TApellido2.Text, RBmasculino.Text, DTfecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBoxEstado.Text)) Then

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
            PictureBox1.Image = Nothing

        ElseIf MsgBoxResult.Yes = op And RBfemenino.Checked Then

            If (objempleado.agregar_empleado(TDni2.Text, TNombre2.Text, TApellido2.Text, RBfemenino.Text, DTfecha.Value, TDireccion.Text, TCorreo.Text, MTelefono.Text, CBoxEstado.Text)) Then

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
            PictureBox1.Image = Nothing
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

        If Not String.IsNullOrEmpty(TNombre.Text) And CBnombre.Checked = True Then
            emp.buscar_nombre(TNombre.Text, dgEmpleados)
        ElseIf Not String.IsNullOrEmpty(TApellido.Text) And CBapellido.Checked = True Then
            emp.buscar_apellido(TApellido.Text, dgEmpleados)
        ElseIf Not String.IsNullOrEmpty(TDni.Text) And CBdni.Checked = True Then
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
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Estas seguro de dar de baja al producto", vbYesNo + vbInformation, "Eliminar")

        If ask = MsgBoxResult.Yes Then
            emp.baja_empleado(0, dgEmpleados.CurrentRow.Cells(0).Value.ToString)
            objempleado.cargarGrid(dgEmpleados)
        End If

    End Sub
End Class