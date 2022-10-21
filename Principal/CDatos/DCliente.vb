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
End Class
