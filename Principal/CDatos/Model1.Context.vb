﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class ProyectoEntities6
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ProyectoEntities6")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Categoria() As DbSet(Of Categoria)
    Public Overridable Property Cliente() As DbSet(Of Cliente)
    Public Overridable Property Detalle_venta() As DbSet(Of Detalle_venta)
    Public Overridable Property Empleado() As DbSet(Of Empleado)
    Public Overridable Property Factura() As DbSet(Of Factura)
    Public Overridable Property Perfil() As DbSet(Of Perfil)
    Public Overridable Property Producto() As DbSet(Of Producto)
    Public Overridable Property Usuario() As DbSet(Of Usuario)

End Class
