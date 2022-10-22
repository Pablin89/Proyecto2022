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
End Class
