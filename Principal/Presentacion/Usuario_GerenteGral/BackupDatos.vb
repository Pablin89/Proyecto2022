Public Class BackupDatos
    Dim back = New BackUp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GerenteGral.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Conectar.InitialDirectory = "D:"
        Conectar.Filter = "Base Datos|*.mdf"
        Conectar.ShowDialog()
        ComboBox.Text = Conectar.FileName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Buscar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = Buscar.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        back.resguardoDatos(ComboBox.Text, TextBox1.Text)
    End Sub
End Class