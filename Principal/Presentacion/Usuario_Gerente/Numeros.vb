Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class Numeros
    Public NombreReporte As String = "Principal.Numeros.rdlc"
    Public FormaReporte As String = "Normal"
    Private Sub Numeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Public Sub Populate()
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Dim dt4 As New DataTable

        Try
            QuerryNumeros.Adaptador.Fill(dt)
            Dim rds As ReportDataSource = New ReportDataSource
            rds.Name = "dsEmpleado"
            rds.Value = dt

            QuerryNumeros.Adaptador2.Fill(dt2)
            Dim rds2 As ReportDataSource = New ReportDataSource
            rds2.Name = "dsCliente"
            rds2.Value = dt2

            QuerryNumeros.Adaptador3.Fill(dt3)
            Dim rds3 As ReportDataSource = New ReportDataSource
            rds3.Name = "dsProd"
            rds3.Value = dt3

            QuerryNumeros.Adaptador4.Fill(dt4)
            Dim rds4 As ReportDataSource = New ReportDataSource
            rds4.Name = "dsStock"
            rds4.Value = dt4

            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportEmbeddedResource = NombreReporte
            ReportViewer1.LocalReport.EnableExternalImages = True

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.DataSources.Add(rds2)
            ReportViewer1.LocalReport.DataSources.Add(rds3)
            ReportViewer1.LocalReport.DataSources.Add(rds4)

            Dim newPageSettings As New System.Drawing.Printing.PageSettings
            newPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)

            If FormaReporte = "Acostado" Then
                newPageSettings.Landscape = True
            End If
            ReportViewer1.SetPageSettings(newPageSettings)
            Me.ReportViewer1.RefreshReport()


        Catch ex As Exception
            Console.WriteLine(Err.Description)
        End Try
    End Sub
End Class