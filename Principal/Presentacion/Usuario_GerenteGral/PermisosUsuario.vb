Imports System.ComponentModel

Public Class PermisosUsuario
    Dim objempleado = New NEmpleado
    Private Sub BConfirmar_Click(sender As Object, e As EventArgs)
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TContraseña.Text) Or String.IsNullOrWhiteSpace(TRepcontra.Text) Or
            String.IsNullOrWhiteSpace(CBperfil.Text) Or ContraseñaValida(TContraseña.Text) = False Or ContraseñasIguales(TContraseña.Text, TRepcontra.Text) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desa confirmar el permiso?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then
                MsgBox("El permiso se registro correctamente", vbOKOnly + vbInformation, "Confirmar")

                TNombre.Clear()
                TContraseña.Clear()
                TRepcontra.Clear()

            End If
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs)
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Estas seguro de cancelar el registro?", vbYesNo + vbExclamation, "Cancelar")

        If ask = DialogResult.Yes Then
            TNombre.Clear()
            TContraseña.Clear()
            TRepcontra.Clear()
        End If
    End Sub
    Private Shared Function ContraseñaValida(password As String) As Boolean

        If (password Is Nothing) Then
            Return False
        End If

        If (password.Length < 6) Then
            Return False
        End If

        Dim existeLetraMayuscula As Boolean

        For Each c As Char In password

            If (c = c.ToString().ToUpper()) Then
                existeLetraMayuscula = True
            End If
        Next

        Return (existeLetraMayuscula)

    End Function

    Private Shared Function ContraseñasIguales(Contraseña As String, RepContra As String) As Boolean

        If Contraseña = RepContra Then
            Return True
        End If

        Return False
    End Function

    Private Sub TContraseña_Validating(sender As Object, e As CancelEventArgs)
        If ContraseñaValida(TContraseña.Text) = True Then
            ErrorContra.SetError(sender, "")
        Else
            ErrorContra.SetError(sender, "la contraseña debe tener mas de 6 digitos y contener una letra mayuscula")
        End If
    End Sub
    Private Sub TRepcontra_Validating(sender As Object, e As CancelEventArgs)
        If ContraseñasIguales(TContraseña.Text, TRepcontra.Text) = True Then
            ErrorRepcontra.SetError(sender, "")
        Else
            ErrorRepcontra.SetError(sender, "las contraseñas deben ser iguales")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GerenteGral.Show()
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
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub BEditarEmpleado_Click(sender As Object, e As EventArgs) Handles BEditarEmpleado.Click
        EditarEmpleado.Show()
    End Sub

    Private Sub PermisosUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objempleado.cargarGrid(DataGridView1)
    End Sub
End Class