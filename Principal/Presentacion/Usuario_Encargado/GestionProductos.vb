Public Class GestionProductos
    Dim objproducto = New NProducto
    Dim objcategoria = New NCategoria
    Dim cat = New DCategoria
    Dim prod = New DProducto

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStock.KeyPress, TPrecioProd.KeyPress, TCodigoProd.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TNombreProd.Text) Or Not IsNumeric(TStock.Text) Or String.IsNullOrWhiteSpace(TCodigoProd.Text) Or Not IsNumeric(TPrecioProd.Text) Or
            String.IsNullOrWhiteSpace(CBcategoria.Text) Or String.IsNullOrWhiteSpace(TDescripcion.Text) Or String.IsNullOrWhiteSpace(TStockMin.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desea agregar el nuevo producto?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then

                If prod.existe_producto(TNombreProd.Text, TDescripcion.Text, TCodigoProd.Text) = False Then

                    objproducto.agregar_producto(TNombreProd.Text, TDescripcion.Text, TCodigoProd.Text, TPrecioProd.Text, TStockMin.Text, TStock.Text, CBcategoria.SelectedValue, 1)
                    MsgBox("El producto se registro correctamente", vbOKOnly + vbInformation, "Confirmar")

                    objproducto.cargarGrid(dgvProductos)
                Else
                    MsgBox("El producto ya existe", vbOKOnly + vbCritical, "Confirmar")

                End If
                TNombreProd.Clear()
                TPrecioProd.Clear()
                TStockMin.Clear()
                TStock.Clear()
                TCodigoProd.Clear()
                TDescripcion.Clear()
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Encargado.Show()
        End If
    End Sub


    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Estas seguro de cancelar el registro?", vbYesNo + vbExclamation, "Cancelar")

        If ask = DialogResult.Yes Then
            TNombreProd.Clear()
            TPrecioProd.Clear()
            TStock.Clear()
            TCodigoProd.Clear()
            TDescripcion.Clear()

        End If
    End Sub

    Private Sub GestionProductos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Encargado.Show()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim prod = New DProducto

        If Not String.IsNullOrEmpty(TNombre2.Text) And RBnombre.Checked = True Then
            prod.buscar_nombre(TNombre2.Text, dgvProductos)
        ElseIf Not String.IsNullOrEmpty(TCodigo.Text) And rbcodigo.Checked = True Then
            prod.buscar_codigo(TCodigo.Text, dgvProductos)
        Else
            prod.buscar_categoria(ComboCat.SelectedValue, dgvProductos)
        End If
    End Sub

    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objproducto.cargarGrid(dgvProductos)
        comboCategoria()
        dgvProductos.ClearSelection()
        objcategoria.cargarGrid(dgvCategoria)
    End Sub

    Private Sub BConfirmarCat_Click(sender As Object, e As EventArgs) Handles BConfirmarCat.Click
        Dim ask As MsgBoxResult

        If String.IsNullOrWhiteSpace(TDesc.Text) Then
            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            ask = MsgBox("¿Desea agregar la nueva Categoria?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If ask = DialogResult.Yes Then

                If cat.existe_categoria(TDesc.Text) = False Then

                    objcategoria.agregar_categoria(TDesc.Text)
                    MsgBox("La categoria se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
                    objcategoria.cargarGrid(dgvCategoria)
                Else
                    MsgBox("La categoria ya existe", vbOKOnly + vbCritical, "Confirmar")
                End If

                TDesc.Clear()
            End If
        End If
    End Sub

    Private Sub BCancelarcat_Click(sender As Object, e As EventArgs) Handles BCancelarcat.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Estas seguro de cancelar el registro?", vbYesNo + vbExclamation, "Cancelar")

        If ask = DialogResult.Yes Then
            TDesc.Clear()
        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgvProductos.Click
        If dgvProductos.CurrentRow IsNot Nothing Then
            BEliminar.Enabled = True
            BModificar.Enabled = True
        Else
            BEliminar.Enabled = False
            BModificar.Enabled = False

        End If
        Dim i As Integer
        i = dgvProductos.CurrentRow.Index
        Dim cat As String = dgvProductos.Rows(i).Cells(7).Value


        ModificarProducto.TNombreProd.Text = dgvProductos.Rows(i).Cells(1).Value.ToString
        ModificarProducto.TDescripcion.Text = dgvProductos.Rows(i).Cells(2).Value.ToString
        ModificarProducto.TCodigoProd.Text = dgvProductos.Rows(i).Cells(3).Value
        ModificarProducto.TPrecioProd.Text = dgvProductos.Rows(i).Cells(4).Value
        ModificarProducto.TStock.Text = dgvProductos.Rows(i).Cells(5).Value
        ModificarProducto.TStockMin.Text = dgvProductos.Rows(i).Cells(6).Value
        ModificarProducto.CBoxEstado.Text = dgvProductos.Rows(i).Cells(8).Value
        ModificarProducto.CBcategoria.SelectedIndex = ModificarProducto.CBcategoria.FindString(cat)

    End Sub

    Private Sub comboCategoria()

        Dim list = cat.getAll_categorias()

        If (list.count > 0) Then
            CBcategoria.DisplayMember = "desc_categoria"
            CBcategoria.ValueMember = "id_categoria"
            CBcategoria.SelectedValue = "id_categoria"
            CBcategoria.DataSource = list

            ComboCat.DisplayMember = "desc_categoria"
            ComboCat.ValueMember = "id_categoria"
            ComboCat.SelectedValue = "id_categoria"
            ComboCat.DataSource = list
        End If

    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        ModificarProducto.Show()
        BModificar.Enabled = False
        BEliminar.Enabled = False
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim ask As MsgBoxResult
        If dgvProductos.CurrentRow.Cells(8).Value = 1 Then
            ask = MsgBox("¿Estas seguro de dar de baja al producto?", vbYesNo + vbInformation, "Eliminar")

            If ask = MsgBoxResult.Yes Then
                prod.baja_producto(0, dgvProductos.CurrentRow.Cells(0).Value.ToString)
                objproducto.cargarGrid(dgvProductos)
            End If
        Else
            MsgBox("El producto ya esta dado de baja", vbOKOnly + vbExclamation, "Elimniar")
        End If
        BEliminar.Enabled = False
        BModificar.Enabled = False
    End Sub

    Private Sub RBnombre_CheckedChanged(sender As Object, e As EventArgs) Handles RBnombre.CheckedChanged
        If RBnombre.Checked = True Then
            TNombre2.Enabled = True
        Else
            TNombre2.Enabled = False
        End If
    End Sub

    Private Sub RBcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RBcodigo.CheckedChanged
        If RBcodigo.Checked = True Then
            TCodigo.Enabled = True
        Else
            TCodigo.Enabled = False
        End If
    End Sub

    Private Sub RBcat_CheckedChanged(sender As Object, e As EventArgs) Handles RBcat.CheckedChanged
        If RBcat.Checked = True Then
            ComboCat.Enabled = True
        Else
            ComboCat.Enabled = False
        End If
    End Sub
End Class