Public Class NProducto
    Function agregar_producto(ByVal nombre As String, ByVal descripcion As String, ByVal codigo As Integer, ByVal precio As Decimal, ByVal stockMin As Integer, ByVal stock As Integer, ByVal categoria As Integer, ByVal estado As Integer) As Boolean
        Dim oproductos = New Producto

        With oproductos
            .nombre = nombre
            .descripcion = descripcion
            .codigo = codigo
            .precio = precio
            .stock_minimo = stockMin
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
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, p.stock_minimo, c.desc_categoria, p.estado).ToList


        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).HeaderText = "Stock Minimo"
        grid.Columns(7).HeaderText = "Categoria"
        grid.Columns(8).HeaderText = "Estado"


    End Sub
    Public Sub cargarGrid_facturacion(ByVal grid As DataGridView)
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria
                      Where p.stock > 0 And p.estado = 1 Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria).ToList


        grid.DataSource = querry.ToList()
        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Producto"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).HeaderText = "Catgoria"
    End Sub
    Public Sub cargarGridLista(ByVal grid As DataGridView)
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.estado = 1
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, p.stock_minimo, c.desc_categoria).ToList


        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).HeaderText = "Stock Minimo"
        grid.Columns(7).HeaderText = "Categoria"


    End Sub


End Class
