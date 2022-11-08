Public Class ReporteCajeros
    Dim emp = New DEmpleado
    Dim det = New DDetalle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Gerente.Show()
        End If
    End Sub

    Private Sub ReportesSucursalIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportesSucursalIndividual_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Gerente.Show()
    End Sub

    Private Sub BBusqueda_Click(sender As Object, e As EventArgs) Handles BBusqueda.Click
        emp.reporte_cajero(TCajero.Text, TId.Text, DateDesde.Value, DateHasta.Value, dgvEmpleado)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        GridCajero.Show()
    End Sub

    Private Sub dgvEmpleado_Click(sender As Object, e As EventArgs) Handles dgvEmpleado.Click
        Dim i As Integer = dgvEmpleado.CurrentRow.Index

        det.ver_detalle(dgvEmpleado.Rows(i).Cells(3).Value, dgvDetalle)
    End Sub
End Class