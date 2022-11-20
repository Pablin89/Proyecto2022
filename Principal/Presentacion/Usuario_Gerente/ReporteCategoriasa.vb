Public Class ReporteCategorias
    Dim cat = New DCategoria
    Dim det = New DDetalle
    Dim fact = New DFactura
    Dim miform As New GraficoProductos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
            Gerentes.Show()
        End If
    End Sub

    Private Sub BBusqueda_Click(sender As Object, e As EventArgs) Handles BBusqueda.Click
        Using ctx As New ProyectoEntities9
            Dim fechaD, fechaH As Date

            fechaD = DateDesde.Value
            fechaH = DateHasta.Value

            If CheckBox2.Checked = True Then
                Dim cat As Integer = ComboBox2.SelectedValue

                If det.existe_datos(ComboBox2.SelectedValue, fechaD, fechaH).Equals(True) Then
                    Dim q = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                             Where p.categoria_id = cat And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d.cantidad By p.nombre Into grupo = Group Select Total = grupo.Sum(), Producto = nombre
                             Order By Total Descending).Take(10)

                    DataGridView1.DataSource = q.ToList
                    Dim datos = q.ToList(0)
                    Dim j As Integer
                    Chart1.Series.Clear()
                    Chart1.Series.Add("Datos")
                    Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    For j = 0 To q.Count - 1
                        Chart1.Series("Datos").Points.AddXY(q.ToList(j).Producto, q.ToList(j).Total)
                        Chart1.Series("Datos").IsValueShownAsLabel = True
                    Next

                    Chart1.DataSource = datos
                    TTotal.Text = "$" + "" + fact.recaudado_porfechas(DateDesde.Value, DateHasta.Value).ToString
                Else
                    MsgBox("No existen resultados", vbOKOnly + vbExclamation, "Aplicar Selección")
                End If


            Else
                If det.existe_fechasCat(fechaD, fechaH).Equals(True) Then

                    Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                                  Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d By c.desc_categoria Into grupo = Group Select Cantidad = grupo.Count(), Categoria = desc_categoria)

                    DataGridView1.DataSource = querry.ToList
                    Dim lista = querry.ToList(0)
                    Dim i As Integer
                    Chart1.Series.Clear()
                    Chart1.Series.Add("Datos")
                    Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    For i = 0 To querry.Count - 1

                        Chart1.Series("Datos").Points.AddXY(querry.ToList(i).Categoria, querry.ToList(i).Cantidad)
                        Chart1.Series("Datos").IsValueShownAsLabel = True
                    Next

                    Chart1.DataSource = lista
                    TTotal.Text = "$" + "" + fact.recaudado_porfechas(DateDesde.Value, DateHasta.Value).ToString
                Else
                    MsgBox("Introducir nuevas fechas", vbOKOnly + vbExclamation, "Aplicar Criterios")
                End If

            End If


        End Using
    End Sub

    Private Sub comboCategoria()

        Dim list = cat.getAll_categorias()

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

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub BDescarga_Click(sender As Object, e As EventArgs) Handles BDescarga.Click
        Imprimir(DateDesde.Value, DateHasta.Value)
    End Sub
    Public Sub Imprimir(ByVal fechaD As Date, ByVal fechaH As Date)

        QuerryProductos.ReporteProducto(fechaD, fechaH)
        miform.NombreReporte = "Principal.GraficoProductos.rdlc"
        miform.Show()

    End Sub
End Class