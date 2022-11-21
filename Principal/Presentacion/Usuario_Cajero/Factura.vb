Imports System.IO
Imports Microsoft.Reporting
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Public NombreReporte As String = "Principal.Report1.rdlc"
    Public FormaReporte As String = "Normal"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub


    Public Sub Populate()
        Dim dt As New DataTable

        Try
            QuerryReporte.Adaptador.Fill(dt)
            Dim rds As ReportDataSource = New ReportDataSource
            rds.Name = "DSfactura"
            rds.Value = dt

            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportEmbeddedResource = NombreReporte
            ReportViewer1.LocalReport.EnableExternalImages = True

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

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

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MisVentas.Show()
    End Sub
End Class