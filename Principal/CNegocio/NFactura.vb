﻿Public Class NFactura

    Function agregar_factura(ByVal factura As Integer, ByVal fecha As Date, ByVal total As Decimal, ByVal forma As String, ByVal cliente As Integer, ByVal empleado As Integer) As Boolean
        Dim ofactura = New Factura

        With ofactura
            .Nro_factura = factura
            .fecha_venta = fecha
            .total = total
            .forma_pago = forma
            .id_cliente = cliente
            .id_empleado = empleado

        End With

        Dim objfactura = New DFactura

        If objfactura.guardar_factura(ofactura) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(ByVal id As Integer, ByVal grid As DataGridView)
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Where f.id_empleado = id
                      Select f.Nro_factura, f.total, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList


        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = "Nro Factura"
        grid.Columns(1).HeaderText = "Total"
        grid.Columns(2).HeaderText = "Fecha de Venta"
        grid.Columns(3).HeaderText = "Nombre Cliente"
        grid.Columns(4).HeaderText = "Apellido Cliente"
        grid.Columns(5).HeaderText = "Forma de Pago"


    End Sub

    Public Sub cargarGrid_ventas(ByVal grid As DataGridView)
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Select f.Nro_factura, e.nombre_empleado, e.apellido_empleado, f.fecha_venta, c.nombre, c.apellido, f.forma_pago, f.total).ToList


        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = "Nro Factura"
        grid.Columns(1).HeaderText = "Nombre Empleado"
        grid.Columns(2).HeaderText = "Apellido Empleado"
        grid.Columns(3).HeaderText = "Fecha Venta"
        grid.Columns(4).HeaderText = "Nombre Cliente"
        grid.Columns(5).HeaderText = "Apellido Cliente"
        grid.Columns(6).HeaderText = "Forma de Pago"
        grid.Columns(7).HeaderText = "Total"

    End Sub

End Class