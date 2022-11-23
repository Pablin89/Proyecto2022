﻿Public Class DEmpleado
    Dim ctx As ProyectoEntities9 = New ProyectoEntities9

    Function DGuardar_empleado(ByVal oempleado As Empleado) As Boolean
        Try
            ctx.Empleado.Add(oempleado)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getEmpleadosAll() As List(Of Empleado)
        Dim listaEmpleados = (From c In ctx.Empleado Select c).ToList
        Return listaEmpleados

    End Function

    Public Sub buscar_nombre(ByVal nombre As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Empleado.SqlQuery("Select * from Empleado where nombre_empleado like '%" + nombre + "%'").ToList
    End Sub

    Public Sub buscar_apellido(ByVal apellido As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Empleado.SqlQuery("Select * from Empleado where apellido_empleado like '%" + apellido + "%'").ToList
    End Sub

    Public Sub buscar_dni(ByVal dni As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Empleado.SqlQuery("Select * from Empleado where dni_empleado like '%" + dni + "%'").ToList
    End Sub

    Public Sub buscar_estado(ByVal estado As String, ByVal grid As DataGridView)
        grid.DataSource = ctx.Empleado.SqlQuery("Select * from Empleado where estado like '%" + estado + "%'").ToList
    End Sub

    Function baja_empleado(estado As String, id As String) As Boolean

        Try
            Dim act = (From e In ctx.Empleado Where e.Id_empleado = id).Single()
            act.estado = estado

            Dim elim = (From u In ctx.Usuario Where u.empleado_id = id Select u)
            ctx.Usuario.RemoveRange(elim)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function modificar_empleado(ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal genero As String, ByVal fecha As Date, ByVal direccion As String, ByVal correo As String, ByVal telefono As String, ByVal estado As Integer, id As String) As Boolean
        Try
            Dim act = (From e In ctx.Empleado Where e.Id_empleado = id).ToList()(0)
            act.dni_empleado = dni
            act.nombre_empleado = nombre
            act.apellido_empleado = apellido
            act.genero = genero
            act.fecha_nacimiento = fecha
            act.direccion = direccion
            act.correo = correo
            act.telefono = telefono
            act.estado = estado
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function datos_empleado(usuario As String, pass As String) As List(Of Empleado)

        Dim querry As IQueryable(Of Empleado) = From emp In ctx.Empleado
                                                Join us In ctx.Usuario On us.empleado_id Equals emp.Id_empleado
                                                Where us.nombre_usuario = usuario And us.contraseña = pass
                                                Select emp

        Dim lista As List(Of Empleado) = querry.ToList

        Return lista
    End Function

    Function existe_empleado(ByVal dni As Integer)
        Try
            Dim existe As Boolean
            Dim querry = (From e In ctx.Empleado Where e.dni_empleado = dni Select e)

            If querry.Count > 0 Then
                existe = True

            End If
            Return existe
        Catch ex As Exception
            Return False
        End Try




    End Function

    Public Sub reporte_cajero(ByVal dni As Integer, ByVal id As Integer, ByVal fechaD As Date, ByVal fechaH As Date, grid As DataGridView)
        Dim querry = (From f In ctx.Factura Join e In ctx.Empleado On f.id_empleado Equals e.Id_empleado
                      Where e.dni_empleado = dni And f.id_empleado = id And f.fecha_venta >= fechaD And f.fecha_venta <= fechaH
                      Select e.dni_empleado, e.nombre_empleado, e.apellido_empleado, f.Nro_factura, f.fecha_venta).ToList

        grid.DataSource = querry.ToList
        grid.Columns(0).HeaderText = "DNI Empleado"
        grid.Columns(1).HeaderText = "Nombre Empleado"
        grid.Columns(2).HeaderText = "Apellido Empleado"
        grid.Columns(3).HeaderText = "Nro Factura"
        grid.Columns(4).HeaderText = "Fecha Venta"
    End Sub

End Class