Public Class NProducto
    Function agregar_producto(ByVal nombre As String, ByVal descripcion As String, ByVal codigo As Integer, ByVal precio As Decimal, ByVal stock As Integer, ByVal categoria As Integer, ByVal estado As Integer) As Boolean
        Dim oproductos = New Producto

        With oproductos
            .nombre = nombre
            .descripcion = descripcion
            .codigo = codigo
            .precio = precio
            .stock = stock
            .categoria_id = categoria
            .estado = estado
        End With


        Dim objproductos = New DProducto

        If objproductos.DGuardar_producto(oproductos) Then
            Return True
        Else
            Return False

        End If
    End Function
    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim producto As DProducto = New DProducto
        grid.DataSource = producto.getAll_productos()

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).HeaderText = "Categoria"
        grid.Columns(7).HeaderText = "Estado"
        grid.Columns(8).Visible = False
        grid.Columns(9).Visible = False

        grid.Columns(0).Visible = False


    End Sub
    Public Sub cargarGrid_facturacion(ByVal grid As DataGridView)
        Dim producto As DProducto = New DProducto
        grid.DataSource = producto.getAll_productos()

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Producto"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).Visible = False
        grid.Columns(7).Visible = False
        grid.Columns(8).Visible = False
        grid.Columns(9).Visible = False
        grid.Columns(0).Visible = False


    End Sub

End Class
