'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Producto
    Public Property Id_producto As Integer
    Public Property nombre As String
    Public Property descripcion As String
    Public Property codigo As String
    Public Property precio As Decimal
    Public Property stock As Integer
    Public Property categoria_id As Integer
    Public Property estado As Integer
    Public Property stock_minimo As Nullable(Of Integer)

    Public Overridable Property Categoria As Categoria
    Public Overridable Property Detalle As ICollection(Of Detalle) = New HashSet(Of Detalle)

End Class
