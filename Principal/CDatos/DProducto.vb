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
End Class
