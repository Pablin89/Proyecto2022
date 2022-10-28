Public Class Facturacion
    Dim objproducto = New NProducto
    Dim cliente = New DCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
        End If
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TProducto.Text) Or String.IsNullOrWhiteSpace(TCantidad.Text) Or String.IsNullOrWhiteSpace(TNombreCli.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")

        Else
            op = MsgBox("¿Desea confirmar la Venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then
                Me.Close()
                Cajeros.Show()

            End If
        End If
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        objproducto.cargarGrid_facturacion(dgvProductos)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Esta seguro de cancelar la venta?", vbYesNo + vbExclamation, "Cancelar Venta")

        If ask = DialogResult.Yes Then
            TNombreCli.Clear()
            TApellidoCli.Clear()
            TDniCli.Clear()
            TTelefono.Clear()
            TTotal.Clear()
        End If

    End Sub
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCantidad.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Facturacion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim lista As List(Of Cliente) = cliente.buscar_cliente(TCliente.Text)
        Dim datos = lista.ToList
        Dim u = datos(0)

        TDniCli.Text = u.dni
        TNombreCli.Text = u.nombre
        TApellidoCli.Text = u.apellido
        TTelefono.Text = u.telefono

    End Sub
End Class