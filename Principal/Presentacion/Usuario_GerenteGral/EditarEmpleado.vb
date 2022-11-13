Imports System.ComponentModel

Public Class EditarEmpleado
    Dim objusuario = New NUsuario
    Dim perfiles = New DPerfil
    Dim us = New DUsuario
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Está seguro que desea salir? Si ha realizado un cambio no se guardará", vbYesNo + vbExclamation, "Salir sin guardar")

        If ask = MsgBoxResult.Yes Then

            Me.Close()

        End If

    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult
        If String.IsNullOrWhiteSpace(TUsuario.Text) Or String.IsNullOrWhiteSpace(TRepcontra.Text) Or String.IsNullOrWhiteSpace(TContraseña.Text) Or
            String.IsNullOrWhiteSpace(CBperfil.Text) Or contraseñaValida(TContraseña.Text) = False Or contraseñaIguales(TContraseña.Text, TRepcontra.Text) = False Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Completar campos")
        Else
            op = MsgBox("¿Desea guardar los cambios?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then

                objusuario.agregar_usuario(TUsuario.Text, TContraseña.Text, CBperfil.SelectedValue, PermisosUsuario.dgvEmpleados.CurrentRow.Cells(0).Value)
                    MsgBox("Los cambios se realizaron correctamente", vbOKOnly + vbDefaultButton1 + vbInformation, "Cambios realizados")
                us.cargarGrid(PermisosUsuario.dgvUsuario)
                TUsuario.Clear()
                TContraseña.Clear()
                TRepcontra.Clear()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub comboPerfil()
        Dim list = perfiles.getPerfiles()

        If (list.count > 0) Then
            CBperfil.DisplayMember = "desc_pefil"
            CBperfil.ValueMember = "id_perfil"
            CBperfil.SelectedValue = "id_perfil"
            CBperfil.DataSource = list

        End If
    End Sub

    Private Sub EditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboPerfil()
    End Sub

    Friend Shared Function contraseñaValida(password As String) As Boolean

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

    Private Sub TContraseña_Validating(sender As Object, e As CancelEventArgs) Handles TContraseña.Validating
        If contraseñaValida(TContraseña.Text) = True Then
            ErrorContra.SetError(sender, "")
        Else
            ErrorContra.SetError(sender, "Debe contener al menos una mayuscula y más de 6 digitos")
        End If
    End Sub

    Function contraseñaIguales(contra As String, repcontra As String) As Boolean
        If (contra = repcontra) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub TRepcontra_Validating(sender As Object, e As CancelEventArgs) Handles TRepcontra.Validating
        If contraseñaIguales(TContraseña.Text, TRepcontra.Text) = True Then
            ErrorRepContra.SetError(sender, "")
        Else
            ErrorRepContra.SetError(sender, "Las contraseñas deben ser iguales")
        End If
    End Sub
End Class