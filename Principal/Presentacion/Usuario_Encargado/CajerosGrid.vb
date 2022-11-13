Public Class CajerosGrid
    Dim objempleado = New NEmpleado

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteVentas.TCajero.Text = DataGridView1.CurrentRow.Cells(1).Value
        ReporteVentas.TId.Text = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()

    End Sub

    Private Sub GridCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objempleado.gridCajero(1, DataGridView1)
    End Sub
End Class