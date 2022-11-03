Public Class DDetalle
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

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
        Dim querry = (From d In ctx.Detalle Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                      Where id = d.nro_factura Select d.cantidad, d.precio, p.nombre).ToList
        grid.DataSource = querry.ToList

        grid.Columns(0).HeaderText = "Cantidad"
        grid.Columns(1).HeaderText = "Precio"
        grid.Columns(2).HeaderText = "Producto"

    End Sub
End Class
