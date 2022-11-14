Public Class DCategoria
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9

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

    Function existe_categoria(ByVal desc As String)
        Try
            Dim existe As Boolean
            Dim querry = (From c In ctx.Categoria Where c.desc_categoria = desc Select c).First()
            If querry.desc_categoria = desc Then
                existe = True
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
