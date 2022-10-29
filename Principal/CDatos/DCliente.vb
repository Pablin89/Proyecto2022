Public Class DCliente
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

    Function DGuardar_cliente(ByVal ocliente As Cliente) As Boolean
        Try
            ctx.Cliente.Add(ocliente)
            ctx.SaveChanges()
            Return True

        Catch ex As Exception
            Return False

        End Try
    End Function
    Function getClienteAll() As List(Of Cliente)
        Dim listaCliente = (From c In ctx.Cliente Select c).ToList
        Return listaCliente

    End Function

    Public Sub buscar_nombre(ByVal nombre As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Cliente.SqlQuery("Select * from Cliente where nombre like '%" + nombre + "%'").ToList
    End Sub

    Public Sub buscar_apellido(ByVal apellido As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Cliente.SqlQuery("Select * from Cliente where apellido like '%" + apellido + "%'").ToList
    End Sub

    Public Sub buscar_dni(ByVal dni As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Cliente.SqlQuery("Select * from Cliente where dni like '%" + dni + "%'").ToList
    End Sub

    Public Sub buscar_correo(ByVal correo As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Cliente.SqlQuery("Select * from Cliente where correo like '%" + correo + "%'").ToList
    End Sub

    Function buscar_cliente(ByVal dni As String) As Boolean
        Try
            Dim consulta As IQueryable(Of Cliente) = From c In ctx.Cliente Where c.dni = dni Select c

            Dim lista = consulta.ToList(0)

            Return True

        Catch ex As Exception

            Return False
        End Try


    End Function

    Function datos_cliente(dni As String) As List(Of Cliente)
        Dim consulta As IQueryable(Of Cliente) = From c In ctx.Cliente Where c.dni = dni Select c

        Dim lista As List(Of Cliente) = consulta.ToList

        Return lista
    End Function

    Function modificar_cliente(ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal genero As String, ByVal correo As String, id As String) As Boolean
        Try
            Dim act = (From c In ctx.Cliente Where c.Id_cliente = id).ToList()(0)
            act.dni = dni
            act.nombre = nombre
            act.apellido = apellido
            act.direccion = direccion
            act.telefono = telefono
            act.genero = genero
            act.correo = correo
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
