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

SELECT TOP 10 SUM(d.cantidad) AS Total, p.nombre AS Producto FROM Detalle d
                                    INNER JOIN Producto p ON d.id_producto = p.Id_producto
                                    INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
                                    INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
                                    WHERE p.categoria_id = 1 AND f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-18' GROUP BY p.nombre ORDER BY Total DESC

SELECT COUNT(f.Nro_factura) AS Total, DATENAME(MONTH, DATEADD(MONTH, MONTH(f.fecha_venta) -1, '1990-01-01')) AS Mes FROM Factura f
                                    WHERE MONTH(f.fecha_venta) BETWEEN MONTH ('2022-06-01') AND MONTH('2022-11-18') GROUP BY MONTH(f.fecha_venta)

SELECT COUNT(f.Nro_factura) AS Cantidad, e.apellido_empleado AS Apellido, e.nombre_empleado AS Nombre FROM Factura f
INNER JOIN Empleado e ON f.id_empleado = e.Id_empleado
WHERE f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-18' GROUP BY e.apellido_empleado, e.nombre_empleado ORDER BY Cantidad Desc

SELECT COUNT(f.Nro_factura) AS Cantidad, c.apellido AS Apellido, c.nombre AS Nombre FROM Factura f
INNER JOIN Cliente c ON f.id_cliente = c.Id_cliente
WHERE f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-18' GROUP BY c.nombre, c.apellido ORDER BY Cantidad Desc

SELECT TOP 15 SUM(d.cantidad) AS Cantidad, p.nombre AS Producto, c.desc_categoria AS Categoria FROM Detalle d
INNER JOIN Factura f ON d.nro_factura = f.Nro_factura
INNER JOIN Producto p ON d.id_producto = p.Id_producto
INNER JOIN Categoria c ON p.categoria_id = c.Id_categoria
WHERE f.fecha_venta BETWEEN '2022-11-01' AND '2022-11-18' GROUP BY p.nombre, c.desc_categoria ORDER BY Cantidad Desc

SELECT p.nombre AS Producto, c.desc_categoria AS Categoria, p.stock AS Stock, p.stock_minimo AS 'Stock Minimo' FROM Producto p
INNER JOIN Categoria c ON c.Id_categoria = p.categoria_id
WHERE p.stock <= p.stock_minimo


From f In ctx.Factura Join e In ctx.Empleado On e.Id_empleado Equals f.id_empleado
                      Where f.fecha_venta >= fechaD And f.fecha_venta <= fechaH Group f By e.nombre_empleado, e.apellido_empleado Into grupo = Group
                      Select Cantidad = grupo.Count(), Apellido = apellido_empleado, Nombre = nombre_empleado Order By Cantidad Descending)