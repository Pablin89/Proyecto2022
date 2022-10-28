Public Class NEmpleado
    Function agregar_empleado(ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal genero As String, ByVal fecha As Date, ByVal direccion As String, ByVal correo As String, ByVal telefono As String, ByVal estado As Integer) As Boolean
        Dim oempleados = New Empleado

        With oempleados
            .dni_empleado = dni
            .nombre_empleado = nombre
            .apellido_empleado = apellido
            .genero = genero
            .fecha_nacimiento = fecha
            .direccion = direccion
            .correo = correo
            .telefono = telefono
            ' .imagen = imagen
            .estado = estado
        End With


        Dim objempleado = New DEmpleado

        If objempleado.DGuardar_empleado(oempleados) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(ByVal grid As DataGridView)
        Dim empleado As DEmpleado = New DEmpleado
        grid.DataSource = empleado.getEmpleadosAll()

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "DNI"
        grid.Columns(2).HeaderText = "Nombre"
        grid.Columns(3).HeaderText = "Apellido"
        grid.Columns(4).HeaderText = "Genero"
        grid.Columns(5).HeaderText = "Fecha de nacimiento"
        grid.Columns(6).HeaderText = "Dirección"
        grid.Columns(7).HeaderText = "Correo"
        grid.Columns(8).HeaderText = "Telefono"
        grid.Columns(9).HeaderText = "Estado"
        grid.Columns(10).Visible = False
        grid.Columns(11).Visible = False
        grid.Columns(12).Visible = False

    End Sub


End Class
