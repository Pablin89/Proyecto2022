﻿Public Class NCliente
    Function agregar_cliente(ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal correo As String, ByVal genero As String) As Boolean
        Dim oclientes = New Cliente

        With oclientes
            .dni = dni
            .nombre = nombre
            .apellido = apellido
            .direccion = direccion
            .telefono = telefono
            .correo = correo
            .genero = genero
        End With


        Dim objcliente = New DCliente

        If objcliente.DGuardar_cliente(oclientes) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim cliente As DCliente = New DCliente
        grid.DataSource = cliente.getClienteAll()

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "DNI"
        grid.Columns(2).HeaderText = "Nombre"
        grid.Columns(3).HeaderText = "Apellido"
        grid.Columns(4).HeaderText = "Direccion"
        grid.Columns(5).HeaderText = "Telefono"
        grid.Columns(6).HeaderText = "Genero"
        grid.Columns(7).HeaderText = "Correo"
        grid.Columns.Add(8, "Modificar")



    End Sub
End Class
