Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class BackUp

    Public Function resguardoDatos(p_nombreResguardo As String, p_direccion As String)
        Try
            Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cultural;Integrated Security=True")
            Using conexion
                conexion.Open()
                Dim cmd As New SqlCommand("resguardar")
                cmd.Parameters().Add(New SqlParameter("@nombre", p_nombreResguardo))
                cmd.Parameters().Add(New SqlParameter("@ubicacion", p_direccion))
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()
                conexion.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '
    'Realiza una restauracion de la base de datos segun el archivo elegido
    '

    Public Function restaurarDatos(p_nombreResguardo As String, p_direccion As String)
        Try
            Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Cultural;Integrated Security=True")
            Using conexion
                conexion.Open()
                Dim cmd As New SqlCommand("ALTER DATABASE Cultural SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE Cultural FROM disk='" & p_direccion & p_nombreResguardo & "'", conexion)
                cmd.ExecuteNonQuery()
                conexion.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
