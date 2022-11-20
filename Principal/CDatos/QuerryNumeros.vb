Imports System.Data.SqlClient
Imports System.Text
Public Class QuerryNumeros
    Public Shared conexion As New SqlConnection
    Public Shared Adaptador As New SqlDataAdapter
    Public Shared Adaptador2 As New SqlDataAdapter
    Public Shared Adaptador3 As New SqlDataAdapter
    Public Shared Adaptador4 As New SqlDataAdapter

    Public Shared ds1 As DataSet
    Public Shared ds2 As DataSet
    Public Shared ds3 As DataSet
    Public Shared ds4 As DataSet

    Public Shared Sub ReporteNumeros(ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("SELECT COUNT(f.Nro_factura) AS Cantidad, e.apellido_empleado AS Apellido, e.nombre_empleado AS Nombre FROM Factura f
                                    INNER JOIN Empleado e ON f.id_empleado = e.Id_empleado
                                    WHERE f.fecha_venta BETWEEN @fechaD AND @fechaH GROUP BY e.apellido_empleado, e.nombre_empleado ORDER BY Cantidad Desc", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)

        ds1 = New DataSet
        Adaptador = New SqlDataAdapter(cmd)
        Adaptador.Fill(ds1)

        Dim cmd2 As New SqlCommand("SELECT COUNT(f.Nro_factura) AS Cantidad, c.apellido AS Apellido, c.nombre AS Nombre FROM Factura f
                                    INNER JOIN Cliente c ON f.id_cliente = c.Id_cliente
                                   WHERE f.fecha_venta BETWEEN @fechaD AND @fechaH GROUP BY c.nombre, c.apellido ORDER BY Cantidad Desc", conexion)
        cmd2.Parameters.AddWithValue("@fechaD", fechaD)
        cmd2.Parameters.AddWithValue("@fechaH", fechaH)

        ds2 = New DataSet
        Adaptador2 = New SqlDataAdapter(cmd2)
        Adaptador2.Fill(ds2)

        Dim cmd3 As New SqlCommand("SELECT TOP 15 SUM(d.cantidad) AS Cantidad, p.nombre AS Producto, c.desc_categoria AS Categoria FROM Detalle d
                                    INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
                                    INNER JOIN Producto p ON d.id_producto = p.Id_producto
                                    INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
                                    WHERE f.fecha_venta BETWEEN @fechaD AND @fechaH GROUP BY p.nombre, c.desc_categoria ORDER BY Cantidad Desc", conexion)
        cmd3.Parameters.AddWithValue("@fechaD", fechaD)
        cmd3.Parameters.AddWithValue("@fechaH", fechaH)

        ds3 = New DataSet
        Adaptador3 = New SqlDataAdapter(cmd3)
        Adaptador3.Fill(ds3)


        Dim cmd4 As New SqlCommand("SELECT p.nombre AS Producto, c.desc_categoria AS Categoria, p.stock AS Stock, p.stock_minimo AS 'Stock Minimo' FROM Producto p
                                    INNER JOIN Categoria c ON c.Id_categoria = p.categoria_id
                                     WHERE p.stock <= p.stock_minimo", conexion)
        ds4 = New DataSet
        Adaptador4 = New SqlDataAdapter(cmd4)
        Adaptador4.Fill(ds4)
    End Sub
End Class
