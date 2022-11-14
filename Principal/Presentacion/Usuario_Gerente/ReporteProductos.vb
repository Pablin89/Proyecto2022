Public Class ReporteProductos
    Dim cate = New DCategoria
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Gerente.Show()
        End If
    End Sub

    Private Sub BBusqueda_Click_1(sender As Object, e As EventArgs) Handles BBusqueda.Click
        Using ctx As New ProyectoEntities9
            Dim fechaD, fechaH As Date

            fechaD = DateDesde.Value
            fechaH = DateHasta.Value

            If CheckBox2.Checked = True Then
                Dim cat As Integer = ComboBox2.SelectedValue
                Dim q = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                         Where p.categoria_id = cat And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre Into grupo = Group Select total = grupo.Sum(), prod = nombre Order By total Descending).Take(10)

                DataGridView1.DataSource = q.ToList
                Dim datos = q.ToList(0)
                Dim j As Integer
                Chart1.Series.Clear()
                Chart1.Series.Add("Datos")
                Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                For j = 0 To q.Count - 1
                    Chart1.Series("Datos").Points.AddXY(q.ToList(j).prod, q.ToList(j).total)
                    Chart1.Series("Datos").IsValueShownAsLabel = True
                Next

                Chart1.DataSource = datos
            Else
                Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                              Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre Into grupo = Group Select total = grupo.Sum(), prod = nombre Order By total Descending).Take(10)

                DataGridView1.DataSource = querry.ToList

                Dim i As Integer
                Dim lista = querry.ToList(0)
                Chart1.Series.Clear()
                Chart1.Series.Add("Datos")
                Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                For i = 0 To querry.Count - 1
                    Chart1.Series("Datos").Points.AddXY(querry.ToList(i).prod, querry.ToList(i).total)
                    Chart1.Series("Datos").IsValueShownAsLabel = True
                Next

                Chart1.DataSource = lista
            End If


        End Using
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub
    Private Sub comboCategoria()

        Dim list = cate.getAll_categorias()

        If (list.count > 0) Then
            ComboBox2.DisplayMember = "desc_categoria"
            ComboBox2.ValueMember = "id_categoria"
            ComboBox2.SelectedValue = "id_categoria"
            ComboBox2.DataSource = list

        End If

    End Sub

    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCategoria()
    End Sub
End Class