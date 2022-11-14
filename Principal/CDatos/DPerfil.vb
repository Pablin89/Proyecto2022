Public Class DPerfil
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9
    Function getPerfiles() As List(Of Perfil)
        Dim listaPerfiles = (From c In ctx.Perfil Select c).ToList
        Return listaPerfiles
    End Function
End Class
