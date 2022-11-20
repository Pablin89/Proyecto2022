CREATE PROCEDURE facturacion
AS
BEGIN 
SELECT d.Id_detalle, d.cantidad, d.precio, c.nombre, c.apellido, c.dni, c.telefono, p.nombre, p.codigo, p.precio, f.nro_factura, f.fecha_venta, f.total FROM Detalle d
INNER JOIN factura f  ON  f.Nro_factura = d.nro_factura 
INNER JOIN Cliente c ON f.id_cliente = c.Id_cliente
INNER JOIN Producto p ON  d.id_producto = p.Id_producto
END

execute facturacion

DECLARE @fechaD DATE = '2022-11-01'
DECLARE @fechaH DATE = '2022-11-16'
SELECT COUNT(f.Nro_factura) AS Total, f.fecha_venta AS Fecha FROM Factura f
WHERE f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-16' GROUP BY f.fecha_venta

SELECT COUNT(d.id_producto) AS Cantidad, c.desc_categoria AS Categoria FROM Detalle d
INNER JOIN Producto p ON d.id_producto = p.Id_producto
INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
WHERE f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-16' GROUP BY c.desc_categoria

From d In ctx.Detalle Join f In ctx.Factura On d.nro_factura Equals f.Nro_factura Join p In ctx.Producto On d.id_producto Equals p.Id_producto
                                  Join c In ctx.Categoria On p.categoria_id Equals c.Id_categoria Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group d By c.desc_categoria Into grupo = Group Select Cantidad = grupo.Count(), Categoria = desc_categoria)



