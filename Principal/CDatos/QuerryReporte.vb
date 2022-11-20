Imports System.Data.SqlClient
Imports System.Text
Public Class QuerryReporte
    Public Shared conexion As New SqlConnection
    Public Shared Adaptador As New SqlDataAdapter

    Public Shared ds1 As DataSet

    Public Shared Sub ReporteFactura(ByVal ID_FACTURA As Integer)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()

        Adaptador = New SqlDataAdapter("SELECT d.Id_detalle, d.cantidad, d.precio, c.nombre, c.apellido, c.dni, c.telefono, p.nombre, p.codigo, p.precio, f.Nro_factura, f.fecha_venta, f.total FROM Detalle d  
                                                INNER JOIN Factura f  ON  f.Nro_factura = d.nro_factura 
                                               INNER JOIN Cliente c ON f.id_cliente = c.Id_cliente 
                                                INNER JOIN Producto p ON  d.id_producto = p.Id_producto WHERE f.Nro_factura =" & ID_FACTURA, conexion)
        ds1 = New DataSet
        Adaptador.Fill(ds1)

    End Sub


End Class
