Public Class ListarProductos
    Dim objproduto = New NProducto
    Dim objcategoria = New NCategoria
    Dim cat = New DCategoria
    Dim prod = New DProducto

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BBuscar.Click

        If Not String.IsNullOrEmpty(TNombre2.Text) And RBnombre.Checked = True Then
            prod.buscar_nombreLista(TNombre2.Text, dgvProductos)
        ElseIf Not String.IsNullOrEmpty(TCodigo.Text) And RBcodigo.Checked = True Then
            prod.buscar_codigoLista(TCodigo.Text, dgvProductos)
        Else
            prod.buscar_categoriaLista(ComboCat.SelectedValue, dgvProductos)
        End If
    End Sub

    Private Sub ListarProductos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ListarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objproduto.cargarGridLista(dgvProductos)
        comboCategoria()
    End Sub

    Private Sub comboCategoria()
        Dim list = cat.getAll_categorias()

        If list.count > 0 Then
            ComboCat.DisplayMember = "desc_categoria"
            ComboCat.ValueMember = "id_categoria"
            ComboCat.SelectedValue = "id_categoria"
            ComboCat.DataSource = list

        End If

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