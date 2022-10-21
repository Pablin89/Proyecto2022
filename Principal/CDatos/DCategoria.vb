Public Class DCategoria
    Dim ctx As ProyectoEntities8 = New ProyectoEntities8

    Function DGuardar_categoria(ByVal ocat As Categoria) As Boolean
        Try
            ctx.Categoria.Add(ocat)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getAll_categorias() As List(Of Categoria)
        Dim listaCategorias = (From c In ctx.Categoria Select c).ToList
        Return listaCategorias

    End Function
End Class
