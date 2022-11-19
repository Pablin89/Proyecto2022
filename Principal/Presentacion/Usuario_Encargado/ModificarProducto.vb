Public Class ModificarProducto
    Dim cat = New DCategoria
    Dim prod = New DProducto
    Dim objprod = New NProducto
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecioProd.KeyPress, TCodigoProd.KeyPress, TStock.KeyPress, TStockMin.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TNombreProd.Text) Or Not IsNumeric(TStock.Text) Or String.IsNullOrWhiteSpace(TCodigoProd.Text) Or Not IsNumeric(TPrecioProd.Text) Or
            String.IsNullOrWhiteSpace(CBcategoria.Text) Or String.IsNullOrWhiteSpace(TDescripcion.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Modificar")
        Else
            op = MsgBox("¿Desea modificar los datos del producto?", vbYesNo + vbDefaultButton2 + vbInformation, "Modificar")
            If op = DialogResult.Yes Then
                prod.modificar_producto(TNombreProd.Text, TDescripcion.Text, TCodigoProd.Text, TPrecioProd.Text, TStockMin.Text, TStock.Text, CBcategoria.SelectedValue, CBoxEstado.Text, GestionProductos.dgvProductos.CurrentRow.Cells(0).Value)
                op = MsgBox("Los datos se guardaron correctamente", vbOKOnly + vbInformation, "Confirmar")
                If op = MsgBoxResult.Ok Then
                    Me.Close()
                    GestionProductos.Show()
                    objprod.cargarGrid(GestionProductos.dgvProductos)

                End If


            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GestionProductos.Show()
        End If
    End Sub

    Private Sub comboCategoria()

        Dim list = cat.getAll_categorias()

        If (list.count > 0) Then
            CBcategoria.DisplayMember = "desc_categoria"
            CBcategoria.ValueMember = "id_categoria"
            CBcategoria.SelectedValue = "id_categoria"
            CBcategoria.DataSource = list

        End If

    End Sub

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCategoria()
    End Sub

End Class