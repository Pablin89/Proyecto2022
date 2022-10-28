Public Class ListarProductos
    Dim objproduto = New NProducto
    Dim objcategoria = New NCategoria
    Dim cat = New DCategoria

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim prod = New DProducto

        If Not String.IsNullOrEmpty(TNombre.Text) And CBnombre.Checked = True Then
            prod.buscar_nombre(TNombre.Text, dgvProductos)
        ElseIf Not String.IsNullOrEmpty(TCodigo.Text) And CBcodigo.Checked = True Then
            prod.buscar_codigo(TCodigo.Text, dgvProductos)
        ElseIf Not String.IsNullOrEmpty(TPrecio.Text) And CBprecio.Checked = True Then
            prod.buscar_precio(TPrecio.Text, dgvProductos)
        Else
            prod.buscar_categoria(ComboCat.SelectedValue, dgvProductos)
        End If
    End Sub

    Private Sub ListarProductos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub
    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress, TPrecio.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub ListarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objproduto.cargarGrid(dgvProductos)
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
End Class