Public Class DProducto
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9

    Function DGuardar_producto(ByVal oproducto As Producto) As Boolean
        Try
            ctx.Producto.Add(oproducto)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getAll_productos() As List(Of Producto)

        Dim listaProductos = (From c In ctx.Producto Select c).ToList

        Return listaProductos

    End Function

    Public Sub buscar_nombre(ByVal nom As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.nombre.Contains(nom)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria, p.estado).ToList
        grid.DataSource = querry.ToList

    End Sub

    Public Sub buscar_codigo(ByVal cod As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.codigo.Contains(cod)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria, p.estado).ToList
        grid.DataSource = querry.ToList
    End Sub
    Public Sub buscar_categoria(ByVal cat As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.categoria_id.ToString.Contains(cat)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria, p.estado).ToList
        grid.DataSource = querry.ToList
    End Sub
    Public Sub buscar_nombreLista(ByVal nom As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.nombre.Contains(nom)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria).ToList
        grid.DataSource = querry.ToList

    End Sub
    Public Sub buscar_codigoLista(ByVal cod As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.codigo.Contains(cod)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria).ToList
        grid.DataSource = querry.ToList
    End Sub
    Public Sub buscar_categoriaLista(ByVal cat As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.categoria_id.ToString.Contains(cat)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria).ToList
        grid.DataSource = querry.ToList
    End Sub
    Function baja_producto(estado As String, id As String) As Boolean

        Try
            Dim act = (From p In ctx.Producto Where p.Id_producto = id).Single()
            act.estado = estado
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function modificar_producto(nombre As String, descripcion As String, codigo As Integer, precio As Decimal, stockMin As Integer, stock As Integer, cat As Integer, estado As Integer, id As String) As Boolean
        Try
            Dim act = (From p In ctx.Producto Where p.Id_producto = id).ToList()(0)
            act.nombre = nombre
            act.descripcion = descripcion
            act.codigo = codigo
            act.precio = precio
            act.stock_minimo = stockMin
            act.stock = stock
            act.categoria_id = cat
            act.estado = estado
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function actualizar_stock(ByVal id As Integer, ByVal cantidad As Integer)
        Try
            Dim prod = (From p In ctx.Producto Where id = p.Id_producto Select p).First

            Dim actStock = prod.stock - cantidad
            prod.stock = actStock

            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function existe_producto(ByVal cod As Integer)
        Try
            Dim existe As Boolean
            Dim querry = (From p In ctx.Producto Where p.codigo = cod Select p)

            If querry.Count > 0 Then
                existe = True

            End If
            Return existe

        Catch ex As Exception
            Return False
        End Try




    End Function
    Public Sub productos_vendidos(grid As DataGridView)
        Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                      Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Group d.cantidad By p.nombre, c.desc_categoria Into grupo = Group
                      Select Producto = nombre, Cantidad = grupo.Sum(), Categoria = desc_categoria Order By Cantidad Descending)
        grid.DataSource = querry.ToList
    End Sub

    Public Sub productos_masVendidos(ByVal fechaD As Date, ByVal fechaH As Date, grid As DataGridView)
        Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                      Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre, c.desc_categoria Into grupo = Group
                      Select Producto = nombre, Cantidad = grupo.Sum(), Categoria = desc_categoria Order By Cantidad Descending)
        grid.DataSource = querry.ToList
    End Sub

    Public Sub productos_stock(grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.stock <= p.stock_minimo
                      Select p.nombre, c.desc_categoria, p.stock, p.stock_minimo)
        grid.DataSource = querry.ToList

        grid.Columns(0).HeaderText = "Producto"
        grid.Columns(1).HeaderText = "Categoria"
        grid.Columns(2).HeaderText = "Stock"
        grid.Columns(3).HeaderText = "Stock Minimo"
    End Sub
    Public Sub buscar_nombreProd(ByVal nom As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria
                      Where p.nombre.Contains(nom) And p.stock > 0 And p.estado = 1 Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria).ToList
        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Producto"
        grid.Columns(2).HeaderText = "Descripcion"
        grid.Columns(3).HeaderText = "Codigo"
        grid.Columns(4).HeaderText = "Precio"
        grid.Columns(5).HeaderText = "Stock"
        grid.Columns(6).HeaderText = "Catgoria"
    End Sub


End Class

