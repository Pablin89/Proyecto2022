Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class DUsuario
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9
    Public Resultado As String


    Function DGuardar_usuario(ByVal ousuario As Usuario) As Boolean
        Try
            ctx.Usuario.Add(ousuario)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getUsuariosAll() As List(Of Empleado)
        Dim listaEmpleados = (From c In ctx.Empleado Select c).ToList
        Return listaEmpleados

    End Function

    Function login(usuario As String, pass As String) As Boolean
        Try
            Dim querry As IQueryable(Of Usuario) = From u In ctx.Usuario Where u.nombre_usuario = usuario And u.contraseña = pass Select u

            If querry.Count() = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function login_id(usuario As String, pass As String) As Integer
        Try
            Dim querry As IQueryable(Of Usuario) = From us In ctx.Usuario Where us.nombre_usuario = usuario And us.contraseña = pass Select us

            Dim lista As List(Of Usuario) = querry.ToList
            Dim datos = lista.ToList(0)

            Return datos.perfil_id

        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function buscar_usuario(ByVal id As String) As Boolean
        Try
            Dim consulta As IQueryable(Of Usuario) = From u In ctx.Usuario Where u.empleado_id = id Select u

            Dim lista = consulta.ToList(0)

            Return True

        Catch ex As Exception

            Return False
        End Try
    End Function


    Function usuario(ByVal id As String) As List(Of Usuario)

        Dim q As IQueryable(Of Usuario) = (From u In ctx.Usuario Where u.empleado_id = id Select u)
        Dim lista As List(Of Usuario) = q.ToList

        Return lista


    End Function
    Function modificar_usuario(usuario As String, contra As String, ByVal perf As Integer, emp As Integer, id As Integer) As Boolean
        Try
            Dim act = (From u In ctx.Usuario Where u.Id_usuario = id).ToList()(0)
            act.nombre_usuario = usuario
            act.contraseña = contra
            act.perfil_id = perf
            act.empleado_id = emp
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub buscar_nombre(nombre As String, grid As DataGridView)
        Dim querry = (From u In ctx.Usuario Join e In ctx.Empleado On u.empleado_id Equals e.Id_empleado Join p In ctx.Perfil On u.perfil_id Equals p.Id_perfil
                      Where e.nombre_empleado.Contains(nombre) Select u.Id_usuario, e.nombre_empleado, e.apellido_empleado, e.dni_empleado, u.nombre_usuario, u.contraseña, p.desc_pefil, u.empleado_id).ToList

        grid.DataSource = querry.ToList

    End Sub
    Public Sub buscar_apellido(apellido As String, grid As DataGridView)
        Dim querry = (From u In ctx.Usuario Join e In ctx.Empleado On u.empleado_id Equals e.Id_empleado Join p In ctx.Perfil On u.perfil_id Equals p.Id_perfil
                      Where e.apellido_empleado.Contains(apellido) Select u.Id_usuario, e.nombre_empleado, e.apellido_empleado, e.dni_empleado, u.nombre_usuario, u.contraseña, p.desc_pefil, u.empleado_id).ToList

        grid.DataSource = querry.ToList

    End Sub
    Public Sub buscar_dni(dni As String, grid As DataGridView)
        Dim querry = (From u In ctx.Usuario Join e In ctx.Empleado On u.empleado_id Equals e.Id_empleado Join p In ctx.Perfil On u.perfil_id Equals p.Id_perfil
                      Where e.dni_empleado.ToString.Contains(dni) Select u.Id_usuario, e.nombre_empleado, e.apellido_empleado, e.dni_empleado, u.nombre_usuario, u.contraseña, p.desc_pefil, u.empleado_id).ToList

        grid.DataSource = querry.ToList

    End Sub

    Public Function verificar_usuario(ByVal text As String) As String
        Dim ue As New UnicodeEncoding
        Dim ByteSourceText() As Byte = ue.GetBytes(text)
        Dim mds As New MD5CryptoServiceProvider()
        Dim ByteHash() As Byte = mds.ComputeHash(ByteSourceText)

        Resultado = Convert.ToBase64String(ByteHash)
        Return Convert.ToBase64String(ByteHash)
    End Function

End Class
