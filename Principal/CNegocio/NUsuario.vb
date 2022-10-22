Public Class NUsuario
    Function agregar_usuario(ByVal nombre As String, ByVal contraseña As String, ByVal perfil As Integer) As Boolean
        Dim ousuarios = New Usuario

        With ousuarios
            .nombre_usuario = nombre
            .contraseña = contraseña
            .perfil_id = perfil
        End With


        Dim objusuario = New DUsuario

        If objusuario.DGuardar_usuario(ousuarios) Then
            Return True
        Else
            Return False

        End If
    End Function
End Class
