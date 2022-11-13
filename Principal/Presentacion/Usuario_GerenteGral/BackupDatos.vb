Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class BackupDatos
    Dim back = New BackUp
    Dim cmd As SqlCommand
    Dim cnn As New SqlConnection(My.Settings.conexion)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GerenteGral.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "SQL Backup Files|*.bak"
        SaveFileDialog1.FileName = ComboBox.Text & Today.Date.ToString("dd-mm-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cnn.Open()
        System.IO.Directory.CreateDirectory(TextBox1.Text)
        Dim querry = "BACKUP DATABASE Proyecto TO DISK = '" & TextBox1.Text & "\BACKUP.bak'"

        cmd.ExecuteNonQuery()

    End Sub

End Class