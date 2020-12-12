GO
USE PROYECTO_APO
GO


---------------------------	MULTITABLAS----------------------------

-----------COMPRAS FECHAS--------------
CREATE PROCEDURE BUSCAR_COMPRA
@FECHA_COMPRA VARCHAR (30)
AS
SELECT COMPRAS.NUMERO_FACTURAC AS [No], COMPRAS.NUMERO_FACTURA_PROVEEDOR AS [No Proveedor] , COMPRAS.FECHA_FACTURAC AS [Fecha] , PROVEEDORES.NOMBRE_PROVEEDOR AS [Proveedor], EMPLEADO.NOMBRE_EMPLEADO AS [Empleado] , FORMA_PAGO.NOMBRE_FORMA_PAGO AS [Forma Pago], ESTADO.NOMBRE_ESTADO AS [Estado] , COMPRAS.SUBTOTAL_FACTURAC AS [Subtotal], COMPRAS.IVA_FACTURA_C AS [Iva],COMPRAS.VALOR_FACTURA_C AS [Valor Factura]
FROM COMPRAS 
INNER JOIN PROVEEDORES ON PROVEEDORES.CODIGO_PROVEEDOR = COMPRAS.CODIGO_PROVEDOR_FC
INNER JOIN EMPLEADO ON EMPLEADO.IDENTIFICACION_EMPLEADO = COMPRAS.ID_EMPLEADOFC
INNER JOIN FORMA_PAGO ON FORMA_PAGO.ID_FORMA_PAGO = COMPRAS.ID_FORMA_PAGO_FK 
INNER JOIN ESTADO ON ESTADO.ID_ESTADO = COMPRAS.ID_ESTADO_FC
WHERE @FECHA_COMPRA = COMPRAS.FECHA_FACTURAC

------------VENTAS FECHAS--------------
CREATE PROCEDURE BUSCAR_VENTA
@FECHA_VENTA VARCHAR (30)
AS
SELECT VENTAS.NUMERO_FACTURA_V AS [No], VENTAS.FECHA_FACV AS [Fecha] ,ESTADO.NOMBRE_ESTADO AS [Estado],  EMPLEADO.NOMBRE_EMPLEADO AS [Empleado]  ,CLIENTES.NOMBRE_CLIENTE AS [Cliente], FORMA_PAGO.NOMBRE_FORMA_PAGO AS [Forma Pago], VENTAS.SUBTOTAL_FACV AS [Subtotal], VENTAS.IVA_FACTURA_V AS [Iva] , VENTAS.VALOR_FACTURAV AS [Valor Factura] 
FROM VENTAS INNER JOIN ESTADO ON ESTADO.ID_ESTADO = VENTAS.ID_ESTADO_FV INNER JOIN EMPLEADO ON EMPLEADO.IDENTIFICACION_EMPLEADO = VENTAS.ID_EMPLEADOFV INNER JOIN CLIENTES ON CLIENTES.IDENTIFICACION_CLIENTE = VENTAS.ID_CLIENTEFV INNER JOIN FORMA_PAGO ON FORMA_PAGO.ID_FORMA_PAGO = VENTAS.ID_FORMA_PAGO_FV
WHERE @FECHA_VENTA = VENTAS.FECHA_FACV

---INVENTARIO FECHAS--
CREATE PROCEDURE BUSCAR_INVENTARIO
@FECHA_INVENTARIO VARCHAR (30)
AS
SELECT INVENTARIO.NUMERO_INVENTARIO AS [Numero] , INVENTARIO.FECHA_INVENTARIO AS [Fecha] ,INVENTARIO.TIPO_MOVIMIENTO AS [Movimiento] ,EMPLEADO.NOMBRE_EMPLEADO AS [Empleado],ESTADO.NOMBRE_ESTADO AS [Estado]  FROM  INVENTARIO INNER JOIN EMPLEADO ON IDENTIFICACION_EMPLEADO = INVENTARIO.EMPLEADO_INVENTARIO INNER JOIN  ESTADO ON  ESTADO.ID_ESTADO = INVENTARIO.ID_ESTADO_INVENTARIO
WHERE INVENTARIO.FECHA_INVENTARIO LIKE @FECHA_INVENTARIO

--ESPECIFICA INVENTARIO--
CREATE PROCEDURE ESPECIFICA_INVENTARIO
@NUMERO_INVENTARIO INT 
AS
SELECT INVENTARIO.NUMERO_INVENTARIO AS [Numero] , INVENTARIO.FECHA_INVENTARIO AS [Fecha] ,INVENTARIO.TIPO_MOVIMIENTO AS [Movimiento] ,EMPLEADO.NOMBRE_EMPLEADO AS [Empleado],ESTADO.NOMBRE_ESTADO AS [Estado]  FROM  INVENTARIO INNER JOIN EMPLEADO ON IDENTIFICACION_EMPLEADO = INVENTARIO.EMPLEADO_INVENTARIO INNER JOIN  ESTADO ON  ESTADO.ID_ESTADO = INVENTARIO.ID_ESTADO_INVENTARIO
WHERE NUMERO_INVENTARIO = @NUMERO_INVENTARIO
-------------------DEVOLUCION FECHA------------
CREATE PROCEDURE BUSCAR_DEVOLUCION
@FECHA_DEV VARCHAR (30)
AS
SELECT DEVOLUCION_PRODUCTO.CODIGO_DEVOLUCION AS [Devolucion No], DEVOLUCION_PRODUCTO.FECHA_DEVOLUCION AS [Fecha], ESTADO.NOMBRE_ESTADO AS [Estado] , CLIENTES.NOMBRE_CLIENTE AS [Cliente], EMPLEADO.NOMBRE_EMPLEADO AS [Empleado]
FROM DEVOLUCION_PRODUCTO
 INNER JOIN ESTADO ON ID_ESTADO = ID_ESTADO_D_FK INNER JOIN CLIENTES ON IDENTIFICACION_CLIENTE = ID_CLIENTE_D
 INNER JOIN EMPLEADO ON IDENTIFICACION_EMPLEADO = DEVOLUCION_PRODUCTO.ID_EMPLEADO_D
WHERE FECHA_DEVOLUCION = @FECHA_DEV


