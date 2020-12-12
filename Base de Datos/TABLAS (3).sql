
CREATE DATABASE PROYECTO_APO

CREATE TABLE CARGO
(
	CODIGO_CARGO INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NOMBRE_CARGO VARCHAR (30) NOT NULL,
	ID_ESTADO_CARGO_FK INT NOT NULL
)

CREATE TABLE CLIENTES
(
	IDENTIFICACION_CLIENTE INT PRIMARY KEY NOT NULL,
	NOMBRE_CLIENTE VARCHAR (30) NOT NULL,
	TELEFONO_CLIENTE BIGINT NOT NULL,
	CORREO_CLIENTE VARCHAR (30) NULL,
	ID_ESTADO_CLIENTE_FK INT NOT NULL
)

CREATE TABLE COMPRAS
(
	NUMERO_FACTURAC INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NUMERO_FACTURA_PROVEEDOR INT NOT NULL,
	SUBTOTAL_FACTURAC BIGINT NULL,
	FECHA_FACTURAC VARCHAR (30) NOT NULL,
	VALOR_FACTURA_C BIGINT NULL,
	IVA_FACTURA_C BIGINT NULL,
	ID_EMPLEADOFC INT NOT NULL,
	CODIGO_PROVEDOR_FC INT NOT NULL,
	ID_ESTADO_FC INT NOT NULL
)

CREATE TABLE CONTRATO
(
	NUMERO_CONTRATO INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NOMBRE_CONTRATO VARCHAR (30) NOT NULL,
	FECHA_INICIO_CONTRATO VARCHAR (30) NOT NULL,
	DURACION_CONTRATO VARCHAR (30) NOT NULL,
	FECHA_FIN_CONTRATO VARCHAR (30) NOT NULL,
	ID_ESTADO_C INT NOT NULL,
	VALOR_CONTRATO BIGINT NOT NULL
)

CREATE TABLE DEVOLUCION_PRODUCTO
(
	CODIGO_DEVOLUCION INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	FECHA_DEVOLUCION VARCHAR(30) NOT NULL,
	ID_ESTADO_D_FK INT NOT NULL,
	ID_CLIENTE_D INT NOT NULL,
	ID_EMPLEADO_D INT NOT NULL
)

CREATE TABLE EMPLEADO
(
	IDENTIFICACION_EMPLEADO INT PRIMARY KEY NOT NULL,
	NOMBRE_EMPLEADO VARCHAR (30) NOT NULL,
	TELEFONO_EMPLEADO BIGINT NOT NULL,
    DIRECCION_EMPLEADO VARCHAR (30) NOT NULL,
	SALARIO_EMPLEADO BIGINT NOT NULL,
	FECHA_NACIMIENTO_EMPLEADO VARCHAR (30) NOT NULL,
	CORREO_EMPLEADO VARCHAR (30) NULL,
	FECHA_INGRESO_EMPLEADO VARCHAR (30) NOT NULL,
	ID_ESTADO_E INT NOT NULL,
	NUMERO_CONTRATO_E INT NOT NULL,
	CODIGO_CARGO_E INT NOT NULL
)

CREATE TABLE ESTADO
(
	ID_ESTADO INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NOMBRE_ESTADO VARCHAR (30) NOT NULL
)
CREATE TABLE FORMA_PAGO 
(
	ID_FORMA_PAGO INT  IDENTITY (1,1) PRIMARY KEY NOT NULL,
	NOMBRE_FORMA_PAGO VARCHAR (30) NOT NULL,
	ID_ESTADO_FP INT NOT NULL
)
CREATE TABLE GARANTIA
(
	ID_GARANTIA INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	TIEMPO_TOTAL VARCHAR (30) NOT NULL,
	FECHA_INICIO_GARANTIA VARCHAR (30) NOT NULL,
	FECHA_FIN_GARANTIA VARCHAR (30) NOT NULL,
	ID_ESTADO_GARANTIA INT NOT NULL

)
CREATE TABLE INVENTARIO
(
	NUMERO_INVENTARIO INT  IDENTITY (1,1) PRIMARY KEY NOT NULL,
	FECHA_INVENTARIO VARCHAR(30) NOT NULL,
	TIPO_MOVIMIENTO VARCHAR(30) NOT NULL,
	EMPLEADO_INVENTARIO INT NOT NULL,	
	ID_ESTADO_INVENTARIO INT NOT NULL
)
CREATE TABLE PRODUCTOS 
(
	CODIGO_PRODUCTO INT PRIMARY KEY NOT NULL,
	NOMBRE_PRODUCTO VARCHAR (30) NOT NULL,
	CANTIDAD_PRODUCTOS BIGINT NOT NULL,
	CANTIDAD_MINIMA_PRODUCTOS BIGINT NOT NULL,
	CANTIDAD_MAXIMA_PRODUCTOS BIGINT NOT NULL,
	VALOR_COMPRA_PRODUCTOS BIGINT NOT NULL,
	VALOR_VENTA_PRODUCTOS BIGINT NOT NULL,
	ID_ESTADO_PRODUCTO INT NOT NULL,
	ID_GARANTIA_PRODUCTO INT NOT NULL,
	CODIGO_PRESENTACION_PRODUCTO INT NOT NULL,
	UNIDAD_MEDIDA_PRODUCTO VARCHAR (30) NOT NULL
)

CREATE TABLE PROVEEDORES 
(
	CODIGO_PROVEEDOR INT PRIMARY KEY NOT NULL,
	NOMBRE_PROVEEDOR VARCHAR (30) NOT NULL,
	R_SOCIAL_PROVEEDOR VARCHAR (30) NOT NULL,
	DIRECCION_PROVEEDOR VARCHAR (30) NOT NULL,
	CIUDAD_PROVEEDOR VARCHAR (30) NOT NULL,
	C_POSTAL_PROVEEDOR NUMERIC NOT NULL,
	TELEFONO_PROVEEDOR BIGINT  NOT NULL,
	C_ELECTRONICO_PROVEEDOR VARCHAR (30) NOT NULL,
	ID_ESTADO_PROVEEDOR INT NOT NULL
)
CREATE TABLE TIPO_PRESENTACION 
(
	CODIGO_TPRESENTACION INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOMBRE_TPRESENTACION VARCHAR (30) NOT NULL,
	ID_ESTADO_TPRESENTACION INT NOT NULL
)


CREATE TABLE USUARIO
(
	ID_USUARIO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOMBRE_USUARIO VARCHAR (30) NOT NULL,
	CLAVE_USUARIO VARCHAR (30) NOT NULL,
	TIPO_USUARIO VARCHAR (30) NOT NULL,
	ID_ESTADO_U INT NOT NULL,
	ID_EMPLEADO_U INT NOT NULL

)


CREATE TABLE VENTAS
(
	NUMERO_FACTURA_V INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FECHA_FACV VARCHAR (30) NOT NULL,
	SUBTOTAL_FACV BIGINT NULL,
	IVA_FACTURA_V BIGINT NULL,
	VALOR_FACTURAV BIGINT NULL,
	ID_CLIENTEFV INT NOT NULL,
	ID_ESTADO_FV INT NOT NULL
)

CREATE TABLE DETALLE_DEVOLUCION 
(
	ID_DETALLEDV INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	CODIGO_PRODUCTODTD INT NOT NULL,
	VALOR_PRODUCTODTD BIGINT NOT NULL,
	CANTIDAD_PRODUCTODTD NUMERIC NOT NULL,
	CODIGO_DEVOLUCION_FK INT NOT NULL
	
)

CREATE TABLE DETALLE_FACTURA_COMPRA
(
	ID_DETALLE_FACTURA_C INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	CODIGO_PRODUCTO_FC INT NOT NULL,
	VALOR_UNITARIO_FC BIGINT NOT NULL,
	CANTIDAD_PRODUCTOSFC NUMERIC NOT NULL,
	SUBTOTAL_FC BIGINT NOT NULL,
	NUMERO_FACTURAC_FK INT  NULL
)
CREATE TABLE DETALLE_FACTURA_VENTA
(
	ID_DETALLEFACTURAV INT IDENTITY (1,1)PRIMARY KEY NOT NULL,
	CODIGO_PRODUCTODFV INT NOT NULL,
	NUMERO_FACTURAV INT NOT NULL,
	CANTIDAD_PRODUCTOS_FACV NUMERIC NOT NULL,
	VALOR_UNITARIOFV BIGINT NOT NULL,
	SUBTOTALFV BIGINT  NULL
)





