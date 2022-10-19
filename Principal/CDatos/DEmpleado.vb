Public Class DEmpleado
    Dim ctx As ProyectoEntities6 = New ProyectoEntities6
    Function DGuardar_empleado(ByVal oempleado As Empleado) As Boolean
        Try
            ctx.Empleado.Add(oempleado)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False

        End Try
    End Function
    Function getEmpleadoAll() As List(Of Empleado)
        Dim listaEmpleado = (From c In ctx.Empleado Select c).ToList
        Return listaEmpleado

    End Function

End Class
