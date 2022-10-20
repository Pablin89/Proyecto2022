Public Class GestionProductos
    Dim objproducto = New NProducto
    Dim objcategoria = New NCategoria

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStock.KeyPress, TPrecioProd.KeyPress, TCodigoProd.KeyPress, TCodigo.KeyPress, TPrecio.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreProd.KeyPress, TDesc.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TNombreProd.Text) Or Not IsNumeric(TStock.Text) Or String.IsNullOrWhiteSpace(TCodigoProd.Text) Or Not IsNumeric(TPrecioProd.Text) Or
            String.IsNullOrWhiteSpace(CBcategoria.Text) Or String.IsNullOrWhiteSpace(TDescripcion.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            op = MsgBox("¿Desea agregar el nuevo producto?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then
                If (objproducto.agregar_producto(TNombreProd.Text, TDescripcion.Text, TCodigoProd.Text, TPrecioProd.Text, TStock.Text, CBcategoria.Text, 1)) Then
                    MsgBox("El producto se registro correctamente", vbOKOnly + vbInformation, "Confirmar")

                    objproducto.cargarGrid(DataGridView1)
                Else
                    MsgBox("El producto ya existe", vbOKOnly + vbCritical, "Confirmar")

                End If


                TNombreProd.Clear()
                TPrecioProd.Clear()
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

    Private Sub CBnombre_CheckedChanged(sender As Object, e As EventArgs) Handles CBnombre.CheckedChanged
        If CBnombre.Checked = True Then
            CBnombre.Font = New Font(CBnombre.Font.Bold, 13)
            TNombre.Enabled = True
        Else
            CBnombre.Font = New Font(CBnombre.Font.Name, 12)
            TNombre.Enabled = False
        End If
    End Sub

    Private Sub CBcodigo_CheckedChanged(sender As Object, e As EventArgs) Handles CBcodigo.CheckedChanged
        If CBcodigo.Checked = True Then
            CBcodigo.Font = New Font(CBcodigo.Font.Bold, 13)
            TCodigo.Enabled = True
        Else
            CBcodigo.Font = New Font(CBcodigo.Font.Name, 12)
            TCodigo.Enabled = False
        End If
    End Sub

    Private Sub CBprecio_CheckedChanged(sender As Object, e As EventArgs) Handles CBprecio.CheckedChanged
        If CBprecio.Checked = True Then
            CBprecio.Font = New Font(CBprecio.Font.Bold, 13)
            TPrecio.Enabled = True
        Else
            CBprecio.Font = New Font(CBprecio.Font.Name, 12)
            TPrecio.Enabled = False
        End If
    End Sub

    Private Sub CBcat_CheckedChanged(sender As Object, e As EventArgs) Handles CBcat.CheckedChanged
        If CBcat.Checked = True Then
            CBcat.Font = New Font(CBcat.Font.Bold, 13)
            ComboCat.Enabled = True
        Else
            CBcat.Font = New Font(CBcat.Font.Name, 12)
            ComboCat.Enabled = False
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
        If String.IsNullOrWhiteSpace(TNombre.Text) And String.IsNullOrWhiteSpace(TCodigo.Text) And String.IsNullOrWhiteSpace(TPrecio.Text) And String.IsNullOrWhiteSpace(ComboCat.Text) Then
            MsgBox("Debe realizar la busqueda por al menos una opcion", vbOKOnly + vbExclamation, "Buscar")

        End If
    End Sub

    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objproducto.cargarGrid(DataGridView1)
    End Sub

    Private Sub BConfirmarCat_Click(sender As Object, e As EventArgs) Handles BConfirmarCat.Click
        Dim ask As MsgBoxResult

        If String.IsNullOrWhiteSpace(TCat.Text) Or String.IsNullOrWhiteSpace(TDesc.Text) Then
            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")
        Else
            ask = MsgBox("¿Desea agregar la nueva Categoria?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If ask = DialogResult.Yes Then
                If (objcategoria.agregar_categoria(TDesc.Text)) Then
                    MsgBox("La categoria se registro correctamente", vbOKOnly + vbInformation, "Confirmar")
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

    Private Sub TCat_TextChanged(sender As Object, e As EventArgs) Handles TCat.TextChanged
        Dim cat = New Categoria
        TCat.Text = cat.Id_categoria
    End Sub
End Class