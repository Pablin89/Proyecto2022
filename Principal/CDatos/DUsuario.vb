Public Class DUsuario
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

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
End Class
