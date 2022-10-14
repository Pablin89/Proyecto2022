Public Class DatosPersonales
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim respuesta As MsgBoxResult

        respuesta = MsgBox("¿Está seguro que desea salir? Si las modificaciones no fueron guardadas, los datos continuaran con los valores actuales.", 4 + vbDefaultButton2, "Salir sin modificar")
        If respuesta = MsgBoxResult.Yes Then
            Me.Close()
            Gerente.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub CBModificarDatos_CheckedChanged(sender As Object, e As EventArgs) Handles CBModificarDatos.CheckedChanged
        If CBModificarDatos.Checked = True Then
            TModificarApellido.Enabled = True
            TModificarNombres.Enabled = True
            TModificarDni.Enabled = True
            TModificarCorreo.Enabled = True
            BModificarDatos.Enabled = True
            DateTimeModificar.Enabled = True
            CBoxGeneros.Enabled = True

        Else
            TModificarApellido.Enabled = False
            TModificarNombres.Enabled = False
            TModificarDni.Enabled = False
            TModificarCorreo.Enabled = False
            BModificarDatos.Enabled = False
            DateTimeModificar.Enabled = False
            CBoxGeneros.Enabled = False

        End If
    End Sub




End Class