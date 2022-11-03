Public Class NDetalle

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim odetalle As DDetalle = New DDetalle

        grid.DataSource = odetalle.getDetalle()
        grid.Columns(0).Visible = False
        grid.Columns(1).HeaderText = "Cantidad"
        grid.Columns(2).HeaderText = "Precio"
        grid.Columns(4).Visible = False
        grid.Columns(3).Visible = False
        grid.Columns(5).HeaderText = "Producto"
        grid.Columns(6).Visible = False



    End Sub
End Class
