Imports System.ComponentModel

Public Class MisDatos
    Dim emp = New DEmpleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then
            If Principal.TUsuario.Text = "Gerente" Then
                Me.Close()

            ElseIf Principal.TUsuario.Text = "Cajero" Then
                Me.Close()
                Cajeros.Show()
            ElseIf Principal.TUsuario.Text = "Encargado" Then
                Me.Close()
                Encargado.Show()
            ElseIf Principal.TUsuario.Text = "GerenteGral" Then
                Me.Close()
                GerenteGral.Show()
            End If


        End If
    End Sub

    Private Sub MisDatos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Principal.TUsuario.Text = "Gerente" Then

        ElseIf Principal.TUsuario.Text = "Cajero" Then
            Cajeros.Show()
        ElseIf Principal.TUsuario.Text = "Encargado" Then
            Encargado.Show()
        ElseIf Principal.TUsuario.Text = "GerenteGral" Then
            GerenteGral.Show()
        End If
    End Sub

    Private Sub MisDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        TNombre2.Text = empDatos.nombre_empleado
        TApellido2.Text = empDatos.apellido_empleado
        TDni2.Text = empDatos.dni_empleado
        DTFecha.Value = empDatos.fecha_nacimiento
        TDireccion.Text = empDatos.direccion
        TCorreo.Text = empDatos.correo
        TTelofono.Text = empDatos.telefono
        TGenero.Text = empDatos.genero


    End Sub
End Class