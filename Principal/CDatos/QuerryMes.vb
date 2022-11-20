Imports System.Data.SqlClient
Imports System.Text
Public Class QuerryMes
    Public Shared conexion As New SqlConnection
    Public Shared Adaptador As New SqlDataAdapter
    Public Shared Adaptador2 As New SqlDataAdapter

    Public Shared ds1 As DataSet

    Public Shared Sub ReporteMes(ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("SELECT COUNT(f.Nro_factura) AS Total, DATENAME(MONTH, DATEADD(MONTH, MONTH(f.fecha_venta) -1, '1990-01-01')) AS Mes FROM Factura f
                                    WHERE MONTH(f.fecha_venta) BETWEEN MONTH(@fechaD) AND MONTH(@fechaH) GROUP BY MONTH(f.fecha_venta)", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)

        ds1 = New DataSet
        Adaptador = New SqlDataAdapter(cmd)
        Adaptador.Fill(ds1)

    End Sub
End Class
