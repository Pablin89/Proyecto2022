Public Class ModificarProducto
    Dim cat = New DCategoria
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStock.KeyPress, TPrecioProd.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreProd.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
                MsgBox("Los datos se guardaron correctamente", vbOKOnly + vbInformation, "Confirmar")

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
            CBcategoria.DisplayMember = "id_categoria"
            CBcategoria.ValueMember = "id_categoria"
            CBcategoria.DataSource = list

        End If

    End Sub

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCategoria()
    End Sub
End Class