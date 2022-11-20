Imports System.Data.SqlClient
Imports System.Text
Public Class QuerryCajero
    Public Shared conexion As New SqlConnection
    Public Shared Adaptador As New SqlDataAdapter
    Public Shared Adaptador2 As New SqlDataAdapter
    Public Shared fechaDes As Date
    Public Shared fechaHas As Date

    Public Shared ds1 As DataSet
    Public Shared Sub ReporteCajero(ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("Select COUNT(f.Nro_factura) As Total, f.fecha_venta As Fecha FROM Factura f
                                        WHERE f.fecha_venta BETWEEN @fechaD And @fechaH  GROUP BY f.fecha_venta", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)

        ds1 = New DataSet
        Adaptador = New SqlDataAdapter(cmd)
        Adaptador.Fill(ds1)

    End Sub
    Public Shared Sub ReporteCajeroID(ByVal id As Integer, ByVal fechaD As Date, ByVal fechaH As Date)
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        conexion.Open()
        Dim cmd As New SqlCommand("Select COUNT(f.Nro_factura) As Total, f.fecha_venta As Fecha FROM Factura f
                                        WHERE @id = f.id_empleado AND f.fecha_venta BETWEEN @fechaD And @fechaH  GROUP BY f.fecha_venta", conexion)
        cmd.Parameters.AddWithValue("@fechaD", fechaD)
        cmd.Parameters.AddWithValue("@fechaH", fechaH)
        cmd.Parameters.AddWithValue("@id", id)

        ds1 = New DataSet
        Adaptador2 = New SqlDataAdapter(cmd)
        Adaptador2.Fill(ds1)

    End Sub
End Class
