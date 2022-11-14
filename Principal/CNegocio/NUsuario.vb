Public Class NUsuario
    Function agregar_usuario(ByVal nombre As String, ByVal contraseña As String, ByVal perfil As Integer, ByVal empleado As Integer) As Boolean
        Dim ousuarios = New Usuario

        With ousuarios
            .nombre_usuario = nombre
            .contraseña = contraseña
            .perfil_id = perfil
            .empleado_id = empleado
        End With


        Dim objusuario = New DUsuario

        If objusuario.DGuardar_usuario(ousuarios) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub cargarGrid(grid As DataGridView)
        Dim ctx As ProyectoEntities9 = New ProyectoEntities9
        Dim querry = (From u In ctx.Usuario Join e In ctx.Empleado On u.empleado_id Equals e.Id_empleado Join p In ctx.Perfil On u.perfil_id Equals p.Id_perfil
                      Select u.Id_usuario, e.nombre_empleado, e.apellido_empleado, u.nombre_usuario, u.contraseña, p.desc_pefil, u.empleado_id)
        grid.DataSource = querry.ToList

        grid.Columns(0).HeaderText = ""
        grid.Columns(1).HeaderText = "Nombre Empleado"
        grid.Columns(2).HeaderText = "Apellido Empleado"
        grid.Columns(3).HeaderText = "Nombre Usuario"
        grid.Columns(4).HeaderText = "Contraseña"
        grid.Columns(5).HeaderText = "Perfil"
        grid.Columns(4).Visible = False
        grid.Columns(6).Visible = False
    End Sub

End Class
