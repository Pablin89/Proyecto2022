Public Class GridClientes
    Dim objCliente = New NCliente
    Dim cli = New DCliente
    Private Sub GridClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCliente.cargarGrid(dgvCliente)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op As MsgBoxResult
        op = MsgBox("¿Estas seguro de seleccionar al cliente?", vbYesNo + vbInformation, "Seleccionar")

        If op = MsgBoxResult.Yes Then
            Dim i As Integer
            i = dgvCliente.CurrentRow.Index
            Facturacion.TNombreCli.Text = dgvCliente.Rows(i).Cells(2).Value.ToString
            Facturacion.TApellidoCli.Text = dgvCliente.Rows(i).Cells(3).Value.ToString
            Facturacion.TDniCli.Text = dgvCliente.Rows(i).Cells(1).Value.ToString
            Facturacion.TTelefono.Text = dgvCliente.Rows(i).Cells(5).Value.ToString
            Facturacion.TIdcli.Text = dgvCliente.Rows(i).Cells(0).Value

            Me.Close()
        End If

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click

        If Not String.IsNullOrEmpty(TNombre.Text) And RBnombre.Checked = True Then

            cli.buscar_nombre(TNombre.Text, dgvCliente)
        ElseIf Not String.IsNullOrEmpty(TApellido.Text) And RBapellido.Checked = True Then

            cli.buscar_apellido(TApellido.Text, dgvCliente)
        Else

            cli.buscar_dni(TDni.Text, dgvCliente)

        End If

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim op As MsgBoxResult
        op = MsgBox("¿Quieres registrar un cliente?", vbYesNo + vbInformation, "Registrar cliente")

        If op = MsgBoxResult.Yes Then
            Facturacion.Close()
            GestionCliente.Show()
            Me.Close()

        End If

    End Sub
End Class