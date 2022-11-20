Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Module Conexion
    Public conexion As New SqlConnection
    Public DataAdapterSql As New SqlDataAdapter
    Public CommandBuilderSql As New SqlCommandBuilder
    Public DataTable As New DataTable
    Public row As Integer = 0

    Public Sub DoConnection()
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
            conexion.Open()

    End Sub
End Module
