Public Class NCategoria
    Function agregar_categoria(ByVal descripcion As String) As Boolean
        Dim ocat = New Categoria

        With ocat
            .desc_categoria = descripcion
        End With


        Dim objcategorias = New DCategoria

        If objcategorias.DGuardar_categoria(ocat) Then
            Return True
        Else
            Return False

        End If
    End Function
End Class
