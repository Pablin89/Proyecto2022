Public Class GridCajero
    Dim objempleado = New NEmpleado
    Private Sub GridCajero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objempleado.gridCajero(1, DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteCajeros.TCajero.Text = DataGridView1.CurrentRow.Cells(1).Value
        ReporteCajeros.TId.Text = DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class