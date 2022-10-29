Public Class DProducto
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

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

    Public Sub buscar_nombre(ByVal nombre As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Producto.SqlQuery("SELECT * FROM Producto WHERE nombre LIKE '%" + nombre + "%'").ToList
    End Sub

    Public Sub buscar_codigo(ByVal codigo As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Producto.SqlQuery("SELECT * FROM Producto WHERE codigo like '%" + codigo + "%'").ToList
    End Sub
    Public Sub buscar_precio(ByVal precio As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Producto.SqlQuery("SELECT * FROM Producto WHERE precio like '%" + precio + "%'").ToList
    End Sub
    Public Sub buscar_categoria(ByVal cat As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Producto.SqlQuery("SELECT * FROM Producto WHERE categoria_id like '%" + cat + "%'").ToList
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

    Function modificar_producto(nombre As String, descripcion As String, codigo As Integer, precio As Decimal, stock As Integer, cat As Integer, estado As Integer, id As String) As Boolean
        Try
            Dim act = (From p In ctx.Producto Where p.Id_producto = id).ToList()(0)
            act.nombre = nombre
            act.descripcion = descripcion
            act.codigo = codigo
            act.precio = precio
            act.stock = stock
            act.categoria_id = cat
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
