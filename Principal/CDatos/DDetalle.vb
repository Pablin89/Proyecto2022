Public Class DDetalle
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9

    Function guardar_detalle(ByVal odetalle As Detalle) As Boolean
        Try
            ctx.Detalle.Add(odetalle)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getDetalle() As List(Of Detalle)

        Dim listaDetalle = (From c In ctx.Detalle Select c).ToList

        Return listaDetalle

    End Function
    Function ultimoDetalle()
        Try
            Dim qultimo = (From q In ctx.Detalle Select q).ToList
            Dim i As Integer = qultimo.Count
            If i = 0 Then
                Return 0
            Else
                Return qultimo.Item(i - 1).Id_detalle
            End If
        Catch ex As Exception
            Return MsgBox("Error al obtener la ultima factura")
        End Try
    End Function

    Public Sub ver_detalle(id As Integer, grid As DataGridView)
        Dim querry = (From d In ctx.Detalle Join p In ctx.Producto On d.id_producto Equals p.Id_producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria
                      Where id = d.nro_factura Select d.cantidad, d.precio, p.nombre, c.desc_categoria).ToList
        grid.DataSource = querry.ToList

        grid.Columns(0).HeaderText = "Cantidad"
        grid.Columns(1).HeaderText = "Precio"
        grid.Columns(2).HeaderText = "Producto"


    End Sub

    Function existe_datos(cat As Integer, fechaD As Date, fechaH As Date)
        Try
            Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                          Where p.categoria_id = cat And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre Into grupo = Group Select Total = grupo.Sum(), Producto = nombre
                          Order By Total Descending).Take(10)

            Dim lista = querry.ToList(0)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function existe_fechas(fechaD As Date, fechaH As Date)
        Try
            Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                          Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre Into grupo = Group Select Total = grupo.Sum(), Producto = nombre
                          Order By Total Descending).Take(10)

            Dim lista = querry.ToList(0)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function existe_fechasCat(fechaD As Date, fechaH As Date)
        Try
            Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                          Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d By c.desc_categoria Into grupo = Group Select Cantidad = grupo.Count(), Categoria = desc_categoria)


            Dim lista = querry.ToList(0)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function existe_datosCat(cat As Integer, fechaD As Date, fechaH As Date)
        Try
            Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                          Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.categoria_id = cat And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d By c.desc_categoria Into grupo = Group Select Cantidad = grupo.Count(), Categoria = desc_categoria)

            Dim lista = querry.ToList(0)

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
