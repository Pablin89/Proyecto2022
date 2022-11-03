﻿Public Class DFactura
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

    Function ultimaFactura()
        Try
            Dim qultimo = (From q In ctx.Factura Select q).ToList
            Dim i As Integer = qultimo.Count
            If i = 0 Then
                Return 0
            Else
                Return qultimo.Item(i - 1).Nro_factura
            End If
        Catch ex As Exception
            Return MsgBox("Error al obtener la ultima factura")
        End Try
    End Function

    Public Sub buscar_nombre(ByVal nom As String, ByVal grid As DataGridView)

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente
                      Where c.nombre.Contains(nom) Select f.Nro_factura, f.total, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList

        grid.DataSource = querry.ToList


    End Sub

End Class