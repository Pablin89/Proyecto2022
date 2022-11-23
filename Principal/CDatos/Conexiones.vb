Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Module Conexion
    Public conexion As New SqlConnection
    Public adaptador As New SqlDataAdapter
    Public comando As New SqlCommandBuilder
    Public resultado As String


    Public Sub AbrirConexion()
        conexion = New SqlConnection
        conexion.ConnectionString = "Data Source=USER\SQL2;Initial Catalog=Proyecto;Integrated Security=True"
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

    End Sub

    Public Function verificar_usuario(ByVal texto As String) As String
        Dim Ue As New UnicodeEncoding()
        Dim ByteSourceText() As Byte = Ue.GetBytes(texto)
        Dim Md5 As New MD5CryptoServiceProvider()
        Dim byteHash() As Byte = Md5.ComputeHash(ByteSourceText)

        resultado = Convert.ToBase64String(byteHash)
        Return Convert.ToBase64String(byteHash)
    End Function
End Module
