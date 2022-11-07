Public Class RestaurarDatos
    Dim back = New BackUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GerenteGral.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Buscar.InitialDirectory = "D:"
        Buscar.Filter = "Base Datos|*.mdf"
        Buscar.ShowDialog()
        TextBox1.Text = Buscar.FileName
        TextBox2.Text = Buscar.FileName
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        back.restaurarDatos(TextBox1.Text, TextBox2.Text)
    End Sub
End Class