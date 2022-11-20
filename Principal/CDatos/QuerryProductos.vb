Imports System.Data.SqlClient
Imports System.Text

Public Class QuerryProductos
    Public Shared conexion As New SqlConnection
    Public Shared Adaptador As New SqlDataAdapter
    Public Shared Adaptador2 As New SqlDataAdapter

    Public Shared ds1 As DataSet
    Public Shared Sub ReporteProducto(ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("SELECT COUNT(d.id_producto) AS Cantidad, c.desc_categoria AS Categoria FROM Detalle d
                                    INNER JOIN Producto p ON d.id_producto = p.Id_producto
                                    INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
                                    INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
                                    WHERE f.fecha_venta BETWEEN @fechaD AND @fechaH GROUP BY c.desc_categoria", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)

        ds1 = New DataSet
        Adaptador = New SqlDataAdapter(cmd)
        Adaptador.Fill(ds1)

    End Sub

    Public Shared Sub ReporteProductoCat(ByVal id As Integer, ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("SELECT TOP 10 SUM(d.cantidad) AS Total, p.nombre AS Producto FROM Detalle d
                                    INNER JOIN Producto p ON d.id_producto = p.Id_producto
                                    INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
                                    INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
                                    WHERE p.categoria_id = @id AND f.fecha_venta BETWEEN @fechaD AND @fechaH GROUP BY p.nombre ORDER BY Total DESC", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)
        cmd.Parameters.AddWithValue("@id", id)
        ds1 = New DataSet
        Adaptador2 = New SqlDataAdapter(cmd)
        Adaptador2.Fill(ds1)

    End Sub
End Class
