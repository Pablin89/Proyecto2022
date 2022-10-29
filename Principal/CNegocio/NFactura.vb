Public Class NFactura
    Function agregar_factura(ByVal total As Decimal, ByVal fecha As Date) As Boolean
        Dim ofactura = New Factura

        With ofactura
            .total = total
            .fecha_venta = fecha
        End With

        Dim objfactura = New DFactura

        If objfactura.guardar_factura(ofactura) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim ofactura As DFactura = New DFactura

        grid.DataSource = ofactura.getFactura()
        grid.Columns(0).HeaderText = "Nro Factura"
        grid.Columns(1).HeaderText = "Total"
        grid.Columns(2).HeaderText = "Fecha de Venta"
        grid.Columns(3).HeaderText = "Nombre Cliente"
        grid.Columns(4).HeaderText = "Nombre empleado"

    End Sub


End Class
