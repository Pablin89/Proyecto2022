Public Class DFactura
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

    Function guardar_factura(ByVal ofactura As Factura) As Boolean
        Try
            ctx.Factura.Add(ofactura)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getFactura() As List(Of Factura)

        Dim listaFactura = (From c In ctx.Factura Select c).ToList

        Return listaFactura

    End Function
End Class
