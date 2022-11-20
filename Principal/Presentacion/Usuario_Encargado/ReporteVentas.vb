﻿Public Class ReporteVentas
    Dim emp = New DEmpleado
    Dim det = New DDetalle
    Dim fact = New DFactura
    Dim miform As New GraficoCajero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Encargado.Show()
        End If
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        CajerosGrid.Show()
    End Sub

    Private Sub BBusqueda_Click(sender As Object, e As EventArgs) Handles BBusqueda.Click
        Using ctx As New ProyectoEntities9


            Dim fechaD, fechaH As Date
            fechaD = DateDesde.Value
            fechaH = DateHasta.Value


            If String.IsNullOrEmpty(TId.Text) Or String.IsNullOrEmpty(TCajero.Text) Then
                If fact.existe_fecha(fechaD, fechaH).Equals(True) Then
                    Dim querry = (From f In ctx.Factura Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH
                                  Group f By f.fecha_venta Into grupo = Group Select total = grupo.Count(), fecha = fecha_venta)

                    Dim lista = querry.ToList(0)
                    Dim i As Integer
                    Chart1.Series.Clear()
                    Chart1.Series.Add("Datos")
                    Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    For i = 0 To querry.Count - 1
                        Chart1.Series("Datos").Points.AddXY(querry.ToList(i).fecha, querry.ToList(i).total)
                        Chart1.Series("Datos").IsValueShownAsLabel = True
                    Next
                    TTotal.Text = "$" + "" + fact.recaudado_porfechas(DateDesde.Value, DateHasta.Value).ToString
                    Chart1.DataSource = lista
                Else
                    MsgBox("Introducir nuevas fechas", vbOKOnly + vbExclamation, "Aplicar Criterios")
                End If


            Else
                Dim id As Integer
                id = TId.Text
                If fact.existe_fechas(id, fechaD, fechaH).Equals(True) Then
                    Dim querry = (From f In ctx.Factura Where f.id_empleado = id And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH
                                  Group f By f.fecha_venta Into grupo = Group Select total = grupo.Count(), fecha = fecha_venta)

                    Dim lista = querry.ToList(0)
                    Dim i As Integer
                    Chart1.Series.Clear()
                    Chart1.Series.Add("Datos")
                    Chart1.Series("Datos").ChartType = DataVisualization.Charting.SeriesChartType.Pie

                    For i = 0 To querry.Count - 1
                        Chart1.Series("Datos").Points.AddXY(querry.ToList(i).fecha, querry.ToList(i).total)
                        Chart1.Series("Datos").IsValueShownAsLabel = True
                    Next
                    TTotal.Text = "$" + "" + fact.recaudado_porfechasCajero(TId.Text, DateDesde.Value, DateHasta.Value).ToString
                    Chart1.DataSource = lista
                    emp.reporte_cajero(TCajero.Text, TId.Text, DateDesde.Value, DateHasta.Value, dgvEmpleado)
                Else
                    MsgBox("Introducir nuevas fechas", vbOKOnly + vbExclamation, "Aplicar Criterios")
                End If
            End If

        End Using
    End Sub
    Private Sub dgvEmpleado_Click(sender As Object, e As EventArgs) Handles dgvEmpleado.Click
        Dim i As Integer = dgvEmpleado.CurrentRow.Index

        det.ver_detalle(dgvEmpleado.Rows(i).Cells(3).Value, dgvDetalle)
    End Sub

    Private Sub BDescarga_Click(sender As Object, e As EventArgs) Handles BGenerar.Click
        If String.IsNullOrEmpty(TId.Text) Then
            Imprimir(DateDesde.Value, DateHasta.Value)
        Else
            ImprimirID(TId.Text, DateDesde.Value, DateHasta.Value)
        End If

    End Sub
    Public Sub Imprimir(ByVal fechaD As Date, ByVal fechaH As Date)

        QuerryCajero.ReporteCajero(fechaD, fechaH)
        miform.NombreReporte = "Principal.GraficoCajero.rdlc"
        miform.Show()

    End Sub
    Public Sub ImprimirID(ByVal id As Integer, ByVal fechaD As Date, ByVal fechaH As Date)

        QuerryCajero.ReporteCajeroID(id, fechaD, fechaH)
        miform.NombreReporte = "Principal.GraficoCajero.rdlc"
        miform.Show()

    End Sub

End Class