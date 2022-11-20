﻿Public Class NumerosDelMes
    Dim prod = New DProducto
    Dim fact = New DFactura
    Dim miform As New Numeros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Gerentes.Show()
        End If
    End Sub

    Private Sub ReportesVenta_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Gerentes.Show()
    End Sub

    Private Sub NumerosDelMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prod.productos_stock(DataGridView2)
        prod.productos_vendidos(DataGridView1)
        fact.clientes_compras(DataGridView3)
        fact.cajero_ventas(DataGridView4)
        TextBox1.Text = "$" + "" + fact.recaudado().ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If fact.existe_fecha(DateDesde.Value, DateHasta.Value).Equals(True) Then
            prod.productos_masVendidos(DateDesde.Value, DateHasta.Value, DataGridView1)
            fact.clientes_masCompras(DateDesde.Value, DateHasta.Value, DataGridView3)
            fact.cajero_masVentas(DateDesde.Value, DateHasta.Value, DataGridView4)
            TextBox1.Text = "$" + "" + fact.recaudado_porfechas(DateDesde.Value, DateHasta.Value).ToString
        Else
            MsgBox("Introducir nuevas fechas", vbOKOnly + vbExclamation, "Aplicar Seleccion")
        End If

    End Sub

    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        Imprimir(DateDesde.Value, DateHasta.Value)
    End Sub

    Public Sub Imprimir(ByVal fechaD As Date, ByVal fechaH As Date)

        QuerryNumeros.ReporteNumeros(fechaD, fechaH)
        miform.NombreReporte = "Principal.Numeros.rdlc"
        miform.Show()

    End Sub
End Class