Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class RestaurarDatos
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
        Buscar.InitialDirectory = "D:"
        Buscar.Filter = "SQL Backup Files|*.bak"
        Buscar.FileName = ""

        If Buscar.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = Buscar.FileName
            TextBox2.Text = "Proyecto"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ask As MsgBoxResult

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Debe introducir una ruta", vbOKOnly + vbExclamation, "Restaurar Backup")
        Else
            ask = MsgBox("¿Desea restaurar la base de datos?", vbYesNo + vbInformation, "Restaurar Backup")
            If ask = MsgBoxResult.Yes Then
                cnn.Open()
                Dim querry As String = "ALTER DATABASE Proyecto SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [" & TextBox2.Text & "] FROM DISK = '" & TextBox1.Text & "'"

                cmd = New SqlCommand(querry, cnn)
                If cmd.ExecuteNonQuery Then
                    MsgBox("Restauracion de base de datos completada", vbOKOnly + vbInformation, "Realizar Backup")
                Else
                    MsgBox("No se puede realizar el backup", vbOKOnly + vbCritical, "Realizar Backup")
                End If
                TextBox1.Clear()
            End If
        End If

    End Sub
End Class