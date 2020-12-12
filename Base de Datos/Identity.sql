GO
USE PROYECTO_APO

--VENTA--
CREATE PROCEDURE IDENTITY_VENTA
AS
SELECT MAX (VENTAS.NUMERO_FACTURA_V) FROM VENTAS

--COMPRA--
CREATE PROCEDURE IDENTITY_COMPRA 
AS 
SELECT MAX (COMPRAS.NUMERO_FACTURAC) FROM COMPRAS

--DETALLES--
CREATE PROCEDURE IDENTITY_DETALLE_VENTA
AS
SELECT MAX (DETALLE_FACTURA_VENTA.ID_DETALLEFACTURAV) FROM DETALLE_FACTURA_VENTA

CREATE PROCEDURE IDENTITY_DETALLE_COMPRA
AS
SELECT MAX (DETALLE_FACTURA_COMPRA.ID_DETALLE_FACTURA_C) FROM DETALLE_FACTURA_COMPRA


CREATE PROCEDURE IDENTITY_INVENTARIO
AS 
SELECT MAX (INVENTARIO.NUMERO_INVENTARIO) FROM INVENTARIO 

CREATE PROCEDURE IDENTITY_DEVOLUCION 
AS
SELECT MAX (DEVOLUCION_PRODUCTO.CODIGO_DEVOLUCION) FROM DEVOLUCION_PRODUCTO

CREATE PROCEDURE IDENTITY_DTDEVOLUCION
AS 
SELECT MAX (DETALLE_DEVOLUCION.ID_DETALLEDV) FROM DETALLE_DEVOLUCION


