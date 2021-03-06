GO
USE PROYECTO_APO
GO

-------------------VALOR COMPRA---------
CREATE PROCEDURE VALOR_PRODUCTO_COMPRA
@CODIGO_PRODUCTO INT
AS
SELECT PRODUCTOS.VALOR_COMPRA_PRODUCTOS
FROM PRODUCTOS
WHERE PRODUCTOS.CODIGO_PRODUCTO = @CODIGO_PRODUCTO

-------------------VALOR VENTA-----------
CREATE PROCEDURE VALOR_PRODUCTO_VENTA
@CODIGO_PRODUCTO INT
AS
SELECT PRODUCTOS.VALOR_VENTA_PRODUCTOS
FROM PRODUCTOS
WHERE PRODUCTOS.CODIGO_PRODUCTO = @CODIGO_PRODUCTO


-------------------ENTRADA DINERO---------
CREATE PROCEDURE SALIDA_DINERO
AS
SELECT SUM (VALOR_FACTURA_C)
FROM COMPRAS

-------------------SALIDA DINERO-----------
CREATE PROCEDURE ENTRADA_DINERO
AS 
SELECT SUM (VALOR_FACTURAV)
FROM VENTAS

------------------DINERO EXISTENTE----------
CREATE PROCEDURE DINERO_EXISTENTE
AS
SELECT SUM (VALOR_FACTURAV) - SUM (VALOR_FACTURA_C)
FROM VENTAS,COMPRAS



