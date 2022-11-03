﻿Public Class DProducto
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
    Public Sub buscar_precio(ByVal prec As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.precio.ToString.Contains(prec)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria, p.estado).ToList

        grid.DataSource = querry.ToList
    End Sub
    Public Sub buscar_categoria(ByVal cat As String, ByVal grid As DataGridView)
        Dim querry = (From p In ctx.Producto Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where p.categoria_id.ToString.Contains(cat)
                      Select p.Id_producto, p.nombre, p.descripcion, p.codigo, p.precio, p.stock, c.desc_categoria, p.estado).ToList
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

    Function existe_producto(ByVal nombre As String, ByVal desc As String, ByVal codigo As Integer)
        Try
            Dim existe As Boolean
            Dim querry = (From p In ctx.Producto Where p.nombre = nombre And p.descripcion = desc And p.codigo = codigo Select p).First()
            If (querry.nombre = nombre And querry.descripcion = desc And querry.codigo = codigo) Then
                existe = True
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
