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

    Public Sub cargarGrid(grid As DataGridView)
        Dim cat As DCategoria = New DCategoria
        grid.DataSource = cat.getAll_categorias()

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Categoria"
        grid.Columns(2).Visible = False

    End Sub
End Class
