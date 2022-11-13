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

    Public Sub buscar_nombre(ByVal idemp As Integer, ByVal nom As String, ByVal grid As DataGridView)

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente
                      Where f.id_empleado = idemp And c.nombre.Contains(nom) Select f.Nro_factura, f.total, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList

        grid.DataSource = querry.ToList


    End Sub

    Public Sub buscar_fecha(ByVal id As Integer, ByVal fechaD As Date, ByVal fechaH As Date, ByVal grid As DataGridView)

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Where f.id_empleado = id And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Select f.Nro_factura, f.total, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList
        grid.DataSource = querry.ToList
    End Sub
    Public Sub clientes_compras(grid As DataGridView)
        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente
                      Group f By c.nombre, c.apellido Into grupo = Group
                      Select Cantidad = grupo.Count(), Apellido = apellido, Nombre = nombre Order By Cantidad Descending)

        grid.DataSource = querry.ToList
    End Sub
    Public Sub clientes_masCompras(ByVal fechaD As Date, ByVal fechaH As Date, grid As DataGridView)
        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente
                      Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group f By c.nombre, c.apellido Into grupo = Group
                      Select Cantidad = grupo.Count(), Apellido = apellido, Nombre = nombre Order By Cantidad Descending)

        grid.DataSource = querry.ToList
    End Sub
    Public Sub cajero_ventas(grid As DataGridView)
        Dim querry = (From f In ctx.Factura Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Group f By e.nombre_empleado, e.apellido_empleado Into grupo = Group
                      Select Cantidad = grupo.Count(), Apellido = apellido_empleado, Nombre = nombre_empleado Order By Cantidad Descending)

        grid.DataSource = querry.ToList
    End Sub
    Public Sub cajero_masVentas(ByVal fechaD As Date, ByVal fechaH As Date, grid As DataGridView)
        Dim querry = (From f In ctx.Factura Join e In ctx.Empleado On e.Id_empleado Equals f.id_empleado
                      Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group f By e.nombre_empleado, e.apellido_empleado Into grupo = Group
                      Select Cantidad = grupo.Count(), Apellido = apellido_empleado, Nombre = nombre_empleado Order By Cantidad Descending)

        grid.DataSource = querry.ToList
    End Sub

    Public Sub buscar_nombreCajero(ByVal nom As String, ByVal grid As DataGridView)

        Dim querry = (From f In ctx.Factura Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente
                      Where e.nombre_empleado.Contains(nom) Select f.Nro_factura, e.nombre_empleado, e.apellido_empleado, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList

        grid.DataSource = querry.ToList


    End Sub

    Public Sub buscar_fechaCajero(ByVal fechaD As Date, ByVal fechaH As Date, ByVal grid As DataGridView)

        Dim querry = (From f In ctx.Factura Join c In ctx.Cliente On f.id_cliente Equals c.Id_cliente Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Select f.Nro_factura, e.nombre_empleado, e.apellido_empleado, f.fecha_venta, c.nombre, c.apellido, f.forma_pago).ToList
        grid.DataSource = querry.ToList
    End Sub
End Class
