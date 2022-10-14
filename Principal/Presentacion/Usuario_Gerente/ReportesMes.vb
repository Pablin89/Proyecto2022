Public Class ReportesMes
    Dim cate = New DCategoria
    Dim fact = New DFactura
    Dim det = New DDetalle
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


            If det.existe_fechas(fechaD, fechaH).Equals(True) Then
                Dim q = (From f In ctx.Factura
                         Where Month(f.fecha_venta) >= Month(fechaD) And Month(f.fecha_venta) <= Month(fechaH) Group f.Nro_factura By f.fecha_venta.Month Into grupo = Group Select Total = grupo.Count(), Mes = Month).ToList
                Dim datos = q.ToList(0)
                Dim j As Integer
                Chart1.Series.Clear()


                For j = 0 To q.Count - 1
                    Chart1.Series.Add(MonthName(q.ToList(j).Mes))
                    If q.ToList(j).Total = 0 Then
                        Chart1.Series(MonthName(q.ToList(j).Mes)).Points.AddXY(q.ToList(j).Mes, 0)
                    Else
                        Chart1.Series(MonthName(q.ToList(j).Mes)).Points.AddXY(q.ToList(j).Mes, q.ToList(j).Total)
                    End If

                    Chart1.Series(MonthName(q.ToList(j).Mes)).IsValueShownAsLabel = True
                Next

                Chart1.DataSource = datos
                TTotal.Text = "$" + "" + fact.recaudado_porfechas(DateDesde.Value, DateHasta.Value).ToString
                Dim querry = (From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                              Where Month(f.fecha_venta) >= Month(fechaD) And Month(f.fecha_venta) <= Month(fechaH) Group d.cantidad By p.nombre Into grupo = Group Select Total = grupo.Sum(), Producto = nombre
                              Order By Total Descending).Take(10)

                DataGridView1.DataSource = querry.ToList()
            Else
                MsgBox("No existen resultados", vbOKOnly + vbExclamation, "Aplicar Selección")
            End If

        End Using
    End Sub

    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TTotal_TextChanged(sender As Object, e As EventArgs) Handles TTotal.TextChanged

    End Sub
End Class