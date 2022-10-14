Public Class Facturacion

    Dim objproducto = New NProducto
    Dim cliente = New DCliente
    Dim prod = New DProducto
    Dim us = New DUsuario
    Dim emp = New DEmpleado
    Dim objdetalle = New NDetalle
    Dim objfactura = New NFactura
    Dim fac = New DFactura
    Dim det = New DDetalle
    Public tabla As New DataTable
    Dim total As Double


    Structure productoFactura
        Dim id As Integer
        Dim nombre As String
        Dim cantidad As Integer
        Dim precio As Double
        Dim subtotal As Double
    End Structure

    Public mercaderia(100) As productoFactura

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Está seguro que desea volver al menú principal?", vbYesNo + vbExclamation, "Volver")

        If ask = MsgBoxResult.Yes Then

            Me.Close()
            Cajeros.Show()
        End If
    End Sub

    Private Sub BConfirmar_Click(sender As Object, e As EventArgs) Handles BConfirmar.Click
        Dim op As MsgBoxResult

        If String.IsNullOrWhiteSpace(TDniCli.Text) Or String.IsNullOrWhiteSpace(TCantidad.Text) Or String.IsNullOrWhiteSpace(TNombreCli.Text) Or String.IsNullOrWhiteSpace(TCajero.Text) Or
            String.IsNullOrWhiteSpace(TTelefono.Text) Or String.IsNullOrWhiteSpace(TApellidoCli.Text) Or IsNothing(dgvCompra) Or String.IsNullOrWhiteSpace(CBForma.Text) Then

            MsgBox("Debe completar todos los campos", vbOKOnly + vbDefaultButton1 + vbCritical, "Confirmar")

        Else
            op = MsgBox("¿Desea confirmar la Venta?", vbYesNo + vbDefaultButton2 + vbInformation, "Confirmar")
            If op = DialogResult.Yes Then

                Using ctx As New ProyectoEntities9
                    Dim ultimaFactura As Integer = fac.ultimaFactura()
                    Dim f = ultimaFactura + 1

                    Dim i As Integer = 0


                    Dim row As System.Windows.Forms.DataGridViewRow
                    Dim ultimo As Integer = det.ultimoDetalle()
                    While i < (dgvCompra.Rows.Count)
                        row = dgvCompra.Rows(i)

                        Dim odetalle As New Detalle

                        With odetalle
                            .cantidad = dgvCompra.Item(2, i).Value
                            .precio = (CDec(dgvCompra.Item(4, i).Value))
                                .nro_factura = f
                                .id_producto = dgvCompra.Item(0, i).Value


                        End With
                        ctx.Detalle.Add(odetalle)

                        prod.actualizar_stock(dgvCompra.Item(0, i).Value, dgvCompra.Item(2, i).Value)
                        i += 1


                    End While

                    objfactura.agregar_factura(f, DateAndTime.Today.ToLongDateString, TTotal.Text, CBForma.Text, TIdcli.Text, TIdCajero.Text)
                    ctx.SaveChanges()

                    objproducto.cargarGrid_facturacion(dgvProductos)
                End Using

                MsgBox("La facturacion se realizo con exito", vbOKOnly + vbInformation, "Confirmar Venta")

                dgvCompra.DataSource = Nothing
                tabla.Rows.Clear()
                TIdcli.Clear()
                TNombreCli.Clear()
                TApellidoCli.Clear()
                TDniCli.Clear()
                TTelefono.Clear()
                TTotal.Clear()


            End If
        End If
    End Sub

    Private Sub Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        tabla.Columns.Add("id", GetType(Integer)) '0
        tabla.Columns.Add("Producto", GetType(String)) '1
        tabla.Columns.Add("Cantidad", GetType(Integer)) '2
        tabla.Columns.Add("Precio", GetType(Double)) '3
        tabla.Columns.Add("Sub total", GetType(Double)) '4

        objproducto.cargarGrid_facturacion(dgvProductos)

        Dim lista As List(Of Empleado) = emp.datos_empleado(Principal.TUsuario.Text, Principal.TContraseña.Text)
        Dim empDatos = lista.ToList(0)

        TCajero.Text = empDatos.nombre_empleado + " " + empDatos.apellido_empleado
        TIdCajero.Text = empDatos.Id_empleado

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LFecha.Text = DateAndTime.Today.ToLongDateString
        LHora.Text = DateAndTime.TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("¿Esta seguro de cancelar la venta?", vbYesNo + vbExclamation, "Cancelar Venta")

        If ask = DialogResult.Yes Then
            dgvCompra.DataSource = Nothing
            tabla.Rows.Clear()
            TIdcli.Clear()
            TNombreCli.Clear()
            TApellidoCli.Clear()
            TDniCli.Clear()
            TTelefono.Clear()
            TTotal.Clear()
        End If

    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCantidad.KeyPress
        If (Char.IsNumber(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Facturacion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Cajeros.Show()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        'Dim lista As List(Of Cliente)

        'If cliente.buscar_cliente(TCliente.Text).Equals(False) Then
        'Dim ask As MsgBoxResult
        'MsgBox("El cliente no esta registrado", vbOKOnly + vbCritical, "Buscar Cliente")

        'ask = MsgBox("Desea registrar al cliente?", vbYesNo + vbInformation, "Buscar Cliente")
        'If ask = MsgBoxResult.Yes Then
        'Me.Close()
        'GestionCliente.Show()
        'End If

        'Else

        'lista = cliente.datos_cliente(TCliente.Text)
        'Dim datos = lista.ToList
        'Dim u = datos(0)

        'TDniCli.Text = u.dni
        'TNombreCli.Text = u.nombre
        'TApellidoCli.Text = u.apellido
        'TTelefono.Text = u.telefono
        'TIdcli.Text = u.Id_cliente
        'End If


        GridClientes.Show()

    End Sub

    Private Sub TProducto_TextChanged(sender As Object, e As EventArgs) Handles TProducto.TextChanged
        prod.buscar_nombre(TProducto.Text, dgvProductos)
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        Dim ask As MsgBoxResult
        Dim i, j As Integer
        Dim carga As Boolean = False

        i = dgvProductos.CurrentRow.Index

        Dim stock = dgvProductos.Rows(i).Cells(5).Value

        If dgvCompra.Rows.Count > 0 Then
            For j = 0 To (dgvCompra.Rows.Count - 1)
                If dgvCompra.Item(0, j).Value = (CInt(dgvProductos.Rows(i).Cells(0).Value)) Then
                    carga = True
                End If
            Next
            dgvCompra.ClearSelection()
        End If

        If carga = False Then
            If (CInt(TCantidad.Text) > stock) Then
                MsgBox("Cantidad supera al stock", vbOKOnly + vbCritical, "Agregar Producto")
                Exit Sub
            Else
                ask = MsgBox("Desea agregar el prducto?", vbYesNo + vbInformation, "Agregar Producto")

                If MsgBoxResult.Yes = ask Then
                    mercaderia(0).id = dgvProductos.Rows(i).Cells(0).Value
                    mercaderia(1).nombre = dgvProductos.Rows(i).Cells(1).Value.ToString
                    mercaderia(2).cantidad = TCantidad.Text
                    mercaderia(3).precio = dgvProductos.Rows(i).Cells(4).Value
                    mercaderia(4).subtotal = TCantidad.Text * dgvProductos.Rows(i).Cells(4).Value

                    tabla.Rows.Add(mercaderia(0).id, mercaderia(1).nombre, mercaderia(2).cantidad, mercaderia(3).precio, mercaderia(4).subtotal)
                    dgvCompra.DataSource = tabla

                    total = TCantidad.Text * dgvProductos.Rows(i).Cells(4).Value + total
                    TTotal.Text = total
                End If
            End If
        Else
            MsgBox("El producto ya esta agregado", vbOKOnly + vbCritical, "Agregar Producto")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ask As MsgBoxResult
        If dgvCompra.Rows.Count = 0 Then
            MsgBox("No hay productos para eliminar", vbOKOnly + vbInformation, "Eliminar")
            TTotal.Text = 0
        Else
            ask = MsgBox("Estas seguro de eliminar el producto", vbYesNo + vbCritical, "Eliminar")
            If MsgBoxResult.Yes = ask Then
                total = total - dgvCompra.Item(4, dgvCompra.CurrentRow.Index).Value
                TTotal.Text = total
                dgvCompra.Rows.Remove(dgvCompra.Rows(dgvCompra.CurrentRow.Index))
            End If
        End If
    End Sub

    Private Sub dgvCompra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompra.CellContentClick

    End Sub
End Class