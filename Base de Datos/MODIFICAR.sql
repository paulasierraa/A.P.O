	GO 
	USE PROYECTO_APO
	GO

	------------------------------------------MODIFICACIONES----------------------------------

----------------------------CARGO-----------------------------------
CREATE PROCEDURE MODIFICAR_CARGO
	@CODIGO_CARGO INT,
	@NOMBRE_CARGO VARCHAR (30),
	@ID_ESTADO_CARGO_FK INT
AS
	UPDATE CARGO
	SET NOMBRE_CARGO = @NOMBRE_CARGO , ID_ESTADO_CARGO_FK = @ID_ESTADO_CARGO_FK
	WHERE @CODIGO_CARGO = CODIGO_CARGO

---------------------------CLIENTES-----------------------------------
CREATE PROCEDURE MODIFICAR_CLIENTE 
	@IDENTIFICACION_CLIENTE INT,
	@NOMBRE_CLIENTE VARCHAR (30),
	@TELEFONO_CLIENTE BIGINT,
	@CORREO_CLIENTE VARCHAR(30),
	@ID_ESTADO_CLIENTE_FK INT
AS
	UPDATE CLIENTES
	SET IDENTIFICACION_CLIENTE = @IDENTIFICACION_CLIENTE ,NOMBRE_CLIENTE = @NOMBRE_CLIENTE , TELEFONO_CLIENTE = @TELEFONO_CLIENTE , CORREO_CLIENTE = @CORREO_CLIENTE , ID_ESTADO_CLIENTE_FK = @ID_ESTADO_CLIENTE_FK
	WHERE IDENTIFICACION_CLIENTE = @IDENTIFICACION_CLIENTE OR  CORREO_CLIENTE = @CORREO_CLIENTE
	


--------------------------COMPRAS--------------------------------
CREATE PROCEDURE MODIFICAR_COMPRAS
	@NUMERO_FACTURAC INT,
	@NUMERO_FACTURA_PROVEEDOR INT,
	@SUBTOTAL_FACTURAC BIGINT,
	@FECHA_FACTURAC VARCHAR (30),
	@VALOR_FACTURA_C BIGINT,
	@IVA_FACTURA_C BIGINT,
	@ID_EMPLEADOFC INT,
	@CODIGO_PROVEEDOR_FC INT,
	@ID_ESTADO_FC INT,
	@ID_FORMA_PAGO_FK INT 
AS
	UPDATE COMPRAS
	SET NUMERO_FACTURA_PROVEEDOR = @NUMERO_FACTURA_PROVEEDOR , SUBTOTAL_FACTURAC = @SUBTOTAL_FACTURAC , FECHA_FACTURAC = @FECHA_FACTURAC , VALOR_FACTURA_C = @VALOR_FACTURA_C , IVA_FACTURA_C = @IVA_FACTURA_C , ID_EMPLEADOFC = @ID_EMPLEADOFC , CODIGO_PROVEDOR_FC = @CODIGO_PROVEEDOR_FC , ID_ESTADO_FC = @ID_ESTADO_FC , ID_FORMA_PAGO_FK = @ID_FORMA_PAGO_FK
	WHERE @NUMERO_FACTURAC = NUMERO_FACTURAC
	
---------------------------MODIFICAR_CONTRATO-------------------------
	CREATE PROCEDURE MODIFICAR_CONTRATO
	@NUMERO_CONTRATO INT,
	@NOMBRE_CONTRATO VARCHAR (30),
	@FECHA_INICIO_CONTRATO VARCHAR (30),
	@DURACION_CONTRATO VARCHAR (30),
	@FECHA_FIN_CONTRATO VARCHAR (30),
	@ID_ESTADO_C INT,
	@VALOR_CONTRATO BIGINT
AS
	UPDATE CONTRATO
	SET NOMBRE_CONTRATO = @NOMBRE_CONTRATO ,FECHA_INICIO_CONTRATO = @FECHA_INICIO_CONTRATO ,DURACION_CONTRATO = @DURACION_CONTRATO,FECHA_FIN_CONTRATO = @FECHA_FIN_CONTRATO, ID_ESTADO_C = @ID_ESTADO_C , VALOR_CONTRATO = @VALOR_CONTRATO
	WHERE @NUMERO_CONTRATO = NUMERO_CONTRATO


---------------------------MODIFICAR_DEVOLUCION----------------------}
CREATE PROCEDURE MODIFICAR_DEVOLUCION
	@CODIGO_DEVOLUCION INT	,
	@FECHA_DEVOLUCION VARCHAR (30),
	@ID_ESTADO_DV INT,
	@ID_CLIENTE_D INT,
	@ID_EMPLEADO_D INT
	AS 
	UPDATE DEVOLUCION_PRODUCTO 
	SET FECHA_DEVOLUCION = @FECHA_DEVOLUCION , ID_ESTADO_D_FK = @ID_ESTADO_DV , ID_CLIENTE_D = @ID_CLIENTE_D , ID_EMPLEADO_D = @ID_EMPLEADO_D
	WHERE @CODIGO_DEVOLUCION = CODIGO_DEVOLUCION

-----------------------EMPLEADO------------------------------------------
	CREATE PROCEDURE MODIFICAR_EMPLEADO
	@IDENTIFICACION_EMPLEADO INT,
	@NOMBRE_EMPLEADO VARCHAR (30),
	@TELEFONO_EMPLEADO BIGINT,
	@DIRECCION_EMPLEADO VARCHAR (30),
	@SALARIO_EMPLEADO BIGINT,
	@FECHA_NACIMIENTO_EMPLEADO VARCHAR (20),	
	@CORREO_EMPLEADO VARCHAR (30),
	@FECHA_INGRESO_EMPLEADO VARCHAR (30),
	@ID_ESTADO_E INT,
	@NUMERO_CONTRATO_E INT,
	@CODIGO_CARGO_E INT
AS
	UPDATE EMPLEADO
	SET IDENTIFICACION_EMPLEADO = @IDENTIFICACION_EMPLEADO, NOMBRE_EMPLEADO = @NOMBRE_EMPLEADO , TELEFONO_EMPLEADO = @TELEFONO_EMPLEADO , DIRECCION_EMPLEADO = @DIRECCION_EMPLEADO , SALARIO_EMPLEADO = @SALARIO_EMPLEADO , FECHA_NACIMIENTO_EMPLEADO = @FECHA_NACIMIENTO_EMPLEADO , CORREO_EMPLEADO = @CORREO_EMPLEADO , FECHA_INGRESO_EMPLEADO = @FECHA_INGRESO_EMPLEADO , ID_ESTADO_E = @ID_ESTADO_E , NUMERO_CONTRATO_E = @NUMERO_CONTRATO_E,CODIGO_CARGO_E = @CODIGO_CARGO_E
	WHERE @IDENTIFICACION_EMPLEADO = IDENTIFICACION_EMPLEADO OR CORREO_EMPLEADO = @CORREO_EMPLEADO 
----------------------------ESTADO-----------------------------------
CREATE PROCEDURE MODIFICAR_ESTADO
	@ID_ESTADO INT ,
	@NOMBRE_ESTADO VARCHAR (30)
AS
	UPDATE ESTADO
	SET NOMBRE_ESTADO = @NOMBRE_ESTADO 
	WHERE @ID_ESTADO = ID_ESTADO


----------------------------FORMA_PAGO--------------------------------
	CREATE PROCEDURE MODIFICAR_FORMA_PAGO

	@ID_FORMA_PAGO INT ,
	@NOMBRE_FORMA_PAGO VARCHAR (30),
	@ID_ESTADO_FP INT
	AS
	UPDATE FORMA_PAGO
	SET NOMBRE_FORMA_PAGO = @NOMBRE_FORMA_PAGO , ID_ESTADO_FP = @ID_ESTADO_FP
	WHERE @ID_FORMA_PAGO = ID_FORMA_PAGO 


---------------------------GARANT�A----------------------------------

	CREATE PROCEDURE MODIFICAR_GARANTIA
	@ID_GARANTIA INT,
	@TIEMPO_TOTAL VARCHAR (30),
	@FECHA_INICIO_GARANTIA VARCHAR (30),
	@FECHA_FIN_GARANTIA VARCHAR (30),
	@ID_ESTADO_GARANTIA INT

	AS
	UPDATE GARANTIA
	SET TIEMPO_TOTAL = @TIEMPO_TOTAL ,FECHA_INICIO_GARANTIA = @FECHA_INICIO_GARANTIA , FECHA_FIN_GARANTIA = @FECHA_FIN_GARANTIA, ID_ESTADO_GARANTIA = @ID_ESTADO_GARANTIA
	WHERE @ID_GARANTIA = ID_GARANTIA



---------------------------PRODUCTO-----------------------------------

	CREATE PROCEDURE MODIFICAR_PRODUCTO
	@CODIGO_PRODUCTO INT,
	@NOMBRE_PRODUCTO VARCHAR(30),
	@CANTIDAD_PRODUCTOS INT,
	@CANTIDAD_MINIMA_PRODUCTOS BIGINT,
	@CANTIDAD_MAXIMA_PRODUCTOS BIGINT,
	@VALOR_COMPRA_PRODUCTOS BIGINT,
	@VALOR_VENTA_PRODUCTOS BIGINT,
	@ID_ESTADO_PRODUCTO INT,
	@ID_GARANTIA_PRODUCTO INT,
	@CODIGO_PRESENTACION_PRODUCTO INT,
	@UNIDAD_MEDIDA_PRODUCTO VARCHAR(30)
	AS
	UPDATE PRODUCTOS
	SET NOMBRE_PRODUCTO = @NOMBRE_PRODUCTO , CANTIDAD_PRODUCTOS = @CANTIDAD_PRODUCTOS , CANTIDAD_MINIMA_PRODUCTOS = @CANTIDAD_MINIMA_PRODUCTOS , CANTIDAD_MAXIMA_PRODUCTOS = @CANTIDAD_MAXIMA_PRODUCTOS,VALOR_COMPRA_PRODUCTOS = @VALOR_COMPRA_PRODUCTOS,VALOR_VENTA_PRODUCTOS = @VALOR_VENTA_PRODUCTOS,ID_ESTADO_PRODUCTO = @ID_ESTADO_PRODUCTO ,ID_GARANTIA_PRODUCTO = @ID_GARANTIA_PRODUCTO ,CODIGO_PRESENTACION_PRODUCTO = @CODIGO_PRESENTACION_PRODUCTO, UNIDAD_MEDIDA_PRODUCTO = @UNIDAD_MEDIDA_PRODUCTO
	WHERE @CODIGO_PRODUCTO = CODIGO_PRODUCTO OR NOMBRE_PRODUCTO = @NOMBRE_PRODUCTO


--------------------------PROVEEDORES--------------------------

	CREATE PROCEDURE MODIFICAR_PROVEEDOR
	@CODIGO_PROVEEDOR INT,
	@NOMBRE_PROVEEDOR VARCHAR(30),
	@R_SOCIAL_PROVEEDOR VARCHAR(30),
	@DIRECCION_PROVEEDOR VARCHAR(30),
	@CIUDAD_PROVEEDOR VARCHAR (30),
	@C_POSTAL_PROVEEDOR NUMERIC,
	@TELEFONO_PROVEEDOR BIGINT,
	@C_ELECTRONICO_PROVEEDOR VARCHAR(30),
	@ID_ESTADO_PROVEEDOR INT
	AS
	UPDATE PROVEEDORES
	SET CODIGO_PROVEEDOR = @CODIGO_PROVEEDOR,NOMBRE_PROVEEDOR = @NOMBRE_PROVEEDOR , R_SOCIAL_PROVEEDOR = @R_SOCIAL_PROVEEDOR , DIRECCION_PROVEEDOR = @DIRECCION_PROVEEDOR , CIUDAD_PROVEEDOR = @CIUDAD_PROVEEDOR , C_POSTAL_PROVEEDOR = @C_POSTAL_PROVEEDOR ,TELEFONO_PROVEEDOR = @TELEFONO_PROVEEDOR ,C_ELECTRONICO_PROVEEDOR = @C_ELECTRONICO_PROVEEDOR,ID_ESTADO_PROVEEDOR = @ID_ESTADO_PROVEEDOR
	WHERE @CODIGO_PROVEEDOR = CODIGO_PROVEEDOR OR NOMBRE_PROVEEDOR = @NOMBRE_PROVEEDOR OR R_SOCIAL_PROVEEDOR = @R_SOCIAL_PROVEEDOR


---------------------------TIPO PRESENTACION----------------
	CREATE PROCEDURE MODIFICAR_TIPO_PRESENTACION
	@CODIGO_TPRESENTACION INT,
	@NOMBRE_TPRESENTACION VARCHAR (30),
	@ID_ESTADO_TPRESENTACION INT
	AS
	UPDATE TIPO_PRESENTACION
	SET NOMBRE_TPRESENTACION = @NOMBRE_TPRESENTACION, ID_ESTADO_TPRESENTACION = @ID_ESTADO_TPRESENTACION
	WHERE @CODIGO_TPRESENTACION = CODIGO_TPRESENTACION



------------------------USUARIO-------------------------------

	CREATE PROCEDURE MODIFICAR_USUARIO
	@ID_USUARIO INT,
	@NOMBRE_USUARIO VARCHAR(30),
	@CLAVE_USUARIO VARCHAR (30),
	@TIPO_USUARIO VARCHAR (30),
	@ID_ESTADO_U INT,
	@ID_EMPLEADO_U INT
	AS
	UPDATE USUARIO
	SET NOMBRE_USUARIO = @NOMBRE_USUARIO , CLAVE_USUARIO = @CLAVE_USUARIO , ID_ESTADO_U = @ID_ESTADO_U,ID_EMPLEADO_U = @ID_EMPLEADO_U
	WHERE @ID_USUARIO = ID_USUARIO
	
---------------------------VENTAS----------------------
	CREATE PROCEDURE MODIFICAR_VENTA 
	@NUMERO_FACTURA_V INT,
    @FECHA_FACV VARCHAR (30),
	@SUBTOTAL_FACV BIGINT,
	@IVA_FACTURA_V BIGINT,
	@VALOR_FACTURAV BIGINT,
	@ID_CLIENTEFV INT,
	@ID_ESTADO_FV INT,
	@ID_EMPLEADOFV INT,
	@ID_FORMA_PAGO_FV INT
	AS
	UPDATE VENTAS
	SET FECHA_FACV = @FECHA_FACV,SUBTOTAL_FACV = @SUBTOTAL_FACV,IVA_FACTURA_V = @IVA_FACTURA_V,VALOR_FACTURAV = @VALOR_FACTURAV ,ID_CLIENTEFV = @ID_CLIENTEFV, ID_ESTADO_FV = @ID_ESTADO_FV,ID_EMPLEADOFV = @ID_EMPLEADOFV,ID_FORMA_PAGO_FV = @ID_FORMA_PAGO_FV
	WHERE @NUMERO_FACTURA_V = NUMERO_FACTURA_V
	
--------------------------------------------------DETALLES------------------------------


-----------------DETALLE DEVOLUCION--------------
CREATE PROCEDURE MODIFICAR_DETALLE_DEVOLUCION
	@ID_DETALLEDV INT ,
	@CODIGO_PRODUCTODTD INT,
	@VALOR_PRODUCTODTD BIGINT,
	@CANTIDAD_PRODUCTODTD NUMERIC
	
AS
	UPDATE DETALLE_DEVOLUCION
SET CODIGO_PRODUCTODTD = @CODIGO_PRODUCTODTD , VALOR_PRODUCTODTD = @VALOR_PRODUCTODTD, CANTIDAD_PRODUCTODTD = @CANTIDAD_PRODUCTODTD 

	WHERE @ID_DETALLEDV = ID_DETALLEDV

----------------DETALLE FACTURA COMPRA--------
CREATE PROCEDURE MODIFICAR_DETALLE_COMPRA 
	@ID_DETALLE_FACTURA_C INT,
	@CODIGO_PRODUCTO_FC INT,
	@VALOR_UNITARIO_FC BIGINT,
	@CANTIDAD_PRODUCTOSFC NUMERIC,
	@SUBTOTAL_FC BIGINT,
	@NUMERO_FACTURAC_FK INT 
AS
	UPDATE DETALLE_FACTURA_COMPRA 
SET CODIGO_PRODUCTO_FC = @CODIGO_PRODUCTO_FC , VALOR_UNITARIO_FC = @VALOR_UNITARIO_FC , CANTIDAD_PRODUCTOSFC = @CANTIDAD_PRODUCTOSFC , SUBTOTAL_FC = @SUBTOTAL_FC , NUMERO_FACTURAC_FK = @NUMERO_FACTURAC_FK
	WHERE @ID_DETALLE_FACTURA_C = ID_DETALLE_FACTURA_C
----------------DETALLE FACTURA VENTA------------
CREATE PROCEDURE MODIFICAR_DETALLE_VENTA
	@ID_DETALLEFACTURAV INT,
	@CODIGO_PRODUCTODFV INT,
	@NUMERO_FACTURAV INT,
	@CANTIDAD_PRODUCTOS_FACV NUMERIC,
	@VALOR_UNITARIOFV BIGINT,
	@SUBTOTALFV BIGINT
AS
	UPDATE DETALLE_FACTURA_VENTA
SET CODIGO_PRODUCTODFV = @CODIGO_PRODUCTODFV , NUMERO_FACTURAV = @NUMERO_FACTURAV , CANTIDAD_PRODUCTOS_FACV = @CANTIDAD_PRODUCTOS_FACV, VALOR_UNITARIOFV = @VALOR_UNITARIOFV , SUBTOTALFV = @SUBTOTALFV
WHERE @ID_DETALLEFACTURAV = ID_DETALLEFACTURAV
