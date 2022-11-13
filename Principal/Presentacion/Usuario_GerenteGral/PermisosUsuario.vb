Imports System.ComponentModel

Public Class PermisosUsuario
    Dim objempleado = New NEmpleado
    Dim objusuario = New NUsuario
    Dim us = New DUsuario

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
            TNombre2.Enabled = True
        Else
            CBnombre.Font = New Font(CBnombre.Font.Name, 12)
            TNombre2.Enabled = False
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
        objempleado.cargarGrid(dgvEmpleados)
        objusuario.cargarGrid(dgvUsuario)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgvEmpleados.Click

        If dgvEmpleados.CurrentRow IsNot Nothing Then
            BEditarEmpleado.Enabled = True
        Else
            BEditarEmpleado.Enabled = False
        End If


        Dim i As Integer
        i = dgvEmpleados.CurrentRow.Index

        Dim lista As List(Of Usuario)


        EditarEmpleado.TNombre.Text = dgvEmpleados.Rows(i).Cells(2).Value.ToString
        EditarEmpleado.TApellido.Text = dgvEmpleados.Rows(i).Cells(3).Value.ToString
        EditarEmpleado.TDni.Text = dgvEmpleados.Rows(i).Cells(1).Value.ToString

        If us.buscar_usuario(dgvEmpleados.Rows(i).Cells(0).Value.ToString).Equals(False) Then
            EditarEmpleado.TUsuario.Text = ""
            EditarEmpleado.TContraseña.Text = ""
            EditarEmpleado.TRepcontra.Text = ""
            EditarEmpleado.CBperfil.SelectedValue = ""
        Else
            EditarEmpleado.TUsuario.Enabled = False
            EditarEmpleado.TContraseña.Enabled = False
            EditarEmpleado.TRepcontra.Enabled = False
            EditarEmpleado.CBperfil.Enabled = False
            EditarEmpleado.BConfirmar.Enabled = False
            EditarEmpleado.BCancelar.Enabled = False

            lista = us.usuario(dgvEmpleados.Rows(i).Cells(0).Value.ToString)
            Dim datos = lista.ToList
            Dim u = datos(0)


            EditarEmpleado.TUsuario.Text = u.nombre_usuario
            EditarEmpleado.TContraseña.Text = u.contraseña
            EditarEmpleado.TRepcontra.Text = u.contraseña
            EditarEmpleado.CBperfil.ValueMember = u.perfil_id


        End If
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim emp = New DEmpleado

        If Not String.IsNullOrEmpty(TNombre2.Text) And CBnombre.Checked = True Then
            emp.buscar_nombre(TNombre2.Text, dgvEmpleados)

        ElseIf Not String.IsNullOrEmpty(TApellido.Text) And CBapellido.Checked = True Then
            emp.buscar_apellido(TApellido.Text, dgvEmpleados)

        ElseIf Not String.IsNullOrEmpty(TDni.Text) And CBdni.Checked = True Then
            emp.buscar_dni(TDni.Text, dgvEmpleados)
        Else
            emp.buscar_estado(ComboEstado.Text, dgvEmpleados)
        End If
    End Sub


    Private Sub dgvUsuario_Click(sender As Object, e As EventArgs) Handles dgvUsuario.Click
        If dgvEmpleados.CurrentRow IsNot Nothing Then
            BModificar.Enabled = True
        Else
            BModificar.Enabled = False
        End If


        Dim i As Integer
        i = dgvUsuario.CurrentRow.Index
        ModificarUsuario.TApellido.Text = dgvUsuario.Rows(i).Cells(2).Value.ToString
        ModificarUsuario.TNombre.Text = dgvUsuario.Rows(i).Cells(1).Value.ToString
        ModificarUsuario.TUsuario.Text = dgvUsuario.Rows(i).Cells(3).Value.ToString
        ModificarUsuario.TContraseña.Text = dgvUsuario.Rows(i).Cells(4).Value.ToString
        ModificarUsuario.TRepcontra.Text = dgvUsuario.Rows(i).Cells(4).Value.ToString



    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        ModificarUsuario.Show()
    End Sub
End Class