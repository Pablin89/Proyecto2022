Public Class Encargado
    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs)
        Me.Close()
        Principal.Show()
    End Sub



    Private Sub ReportresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportresToolStripMenuItem.Click
        Me.Hide()
        GestionCajeros.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Encargado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        MisDatos.Show()
    End Sub
End Class