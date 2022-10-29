Public Class NDetalle
    Function agregar_detalle(ByVal cantidad As Integer, ByVal precio As Decimal) As Boolean
        Dim odetalle = New Detalle_venta

        With odetalle
            .cantidad = cantidad
            .precio = precio
        End With


        Dim objdetalle = New DDetalle

        If objdetalle.guardar_detalle(odetalle) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim odetalle As DDetalle = New DDetalle

        grid.DataSource = odetalle.getDetalle()
        grid.Columns(0).Visible = False
        grid.Columns(1).HeaderText = "Cantidad"
        grid.Columns(2).HeaderText = "Precio"
        grid.Columns(3).HeaderText = "Nro Factura"
        grid.Columns(4).HeaderText = "Producto"

    End Sub
End Class
