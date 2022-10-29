Public Class DDetalle
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

    Function guardar_detalle(ByVal odetalle As Detalle_venta) As Boolean
        Try
            ctx.Detalle_venta.Add(odetalle)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getDetalle() As List(Of Detalle_venta)

        Dim listaDetalle = (From c In ctx.Detalle_venta Select c).ToList

        Return listaDetalle

    End Function

End Class
