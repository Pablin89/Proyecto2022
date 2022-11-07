Public Class MisVentas
    Dim objfactura = New NFactura
    Dim objdetalle = New NDetalle
    Dim det = New DDetalle
    Dim fac = New DFactura
    Dim cli = New DCliente
    Dim emp = New DEmpleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
        End If

    End Sub

    Private Sub MisVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub

    Private Sub MisVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        objfactura.cargarGrid(empDatos.Id_empleado, dgvFactura)


    End Sub

    Private Sub dgvFactura_Click(sender As Object, e As EventArgs) Handles dgvFactura.Click
        Dim i As Integer = dgvFactura.CurrentRow.Index

        det.ver_detalle(dgvFactura.Rows(i).Cells(0).Value, dgvDetalle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        fac.buscar_nombre(empDatos.Id_empleado, TextBox1.Text, dgvFactura)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        fac.buscar_fecha(empDatos.Id_empleado, DTdesde.Value, DThasta.Value, dgvFactura)
    End Sub

End Class