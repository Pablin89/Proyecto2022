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

Partial Public Class Empleado
    Public Property Id_empleado As Integer
    Public Property dni_empleado As Integer
    Public Property nombre_empleado As String
    Public Property apellido_empleado As String
    Public Property genero As String
    Public Property fecha_nacimiento As Date
    Public Property direccion As String
    Public Property correo As String
    Public Property telefono As String
    Public Property estado As Integer
    Public Property id_usuario As Nullable(Of Integer)

    Public Overridable Property Usuario As Usuario
    Public Overridable Property Factura As ICollection(Of Factura) = New HashSet(Of Factura)

End Class
