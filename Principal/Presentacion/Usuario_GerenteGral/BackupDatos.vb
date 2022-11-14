Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class BackupDatos
    Dim cmd As SqlCommand
    Dim cnn As New SqlConnection(My.Settings.conexion2)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            GerenteGral.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim abrir As DialogResult
        abrir = Buscar.ShowDialog

        If abrir = DialogResult.OK Then
            TextBox1.Text = Buscar.SelectedPath
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ask As MsgBoxResult
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Debe introducir una ruta", vbOKOnly + vbExclamation, "Realizar Backup")
        Else
            ask = MsgBox("¿Desea realizar el backup?", vbYesNo + vbInformation, "Realizar Backup")
            If ask = MsgBoxResult.Yes Then
                cnn.Open()
                System.IO.Directory.CreateDirectory(TextBox1.Text)
                Dim querry As String = "BACKUP DATABASE Proyecto TO DISK ='" + TextBox1.Text + "\Proyecto" & Today.Date.ToString("dd-mm-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak'"
                cmd = New SqlCommand(querry, cnn)

                If cmd.ExecuteNonQuery Then
                    MsgBox("Bakup realizado", vbOKOnly + vbInformation, "Realizar Backup")
                Else
                    MsgBox("No se puede realizar el backup", vbOKOnly + vbCritical, "Realizar Backup")
                End If
                TextBox1.Clear()
            End If

        End If

    End Sub
End Class