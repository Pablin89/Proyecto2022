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

    Function getAll_empleados() As List(Of Empleado)
        Dim listaEmpleados = (From c In ctx.Empleado Select c).ToList
        Return listaEmpleados

    End Function
End Class
