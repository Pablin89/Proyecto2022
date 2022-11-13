Public Class NumerosDelMes
    Dim prod = New DProducto
    Dim fact = New DFactura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Gerente.Show()
        End If
    End Sub

    Private Sub ReportesVenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Gerente.Show()
    End Sub

    Private Sub NumerosDelMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod.productos_stock(DataGridView2)
        prod.productos_vendidos(DataGridView1)
        fact.clientes_compras(DataGridView3)
        fact.cajero_ventas(DataGridView4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        prod.productos_masVendidos(DateDesde.Value, DateHasta.Value, DataGridView1)
        fact.clientes_masCompras(DateDesde.Value, DateHasta.Value, DataGridView3)
        fact.cajero_masVentas(DateDesde.Value, DateHasta.Value, DataGridView4)
    End Sub
End Class