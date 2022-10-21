Public Class DProducto
    Dim ctx As ProyectoEntities6 = New ProyectoEntities6

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
End Class
