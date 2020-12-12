GO
USE PROYECTO_APO
GO


--------------------------------------------------ALTERACIONES CARGO----------------------------------------------------------------

ALTER TABLE CARGO ADD CONSTRAINT ID_ESTADO_CARGO_FK FOREIGN KEY (ID_ESTADO_CARGO_FK) REFERENCES ESTADO (ID_ESTADO)

--------------------------------------------------ALTERACIONES CLIENTES-------------------------------------------------------------

ALTER TABLE CLIENTES ADD CONSTRAINT ID_ESTADO_CLIENTE_FK FOREIGN KEY (ID_ESTADO_CLIENTE_FK) REFERENCES ESTADO (ID_ESTADO)

--------------------------------------------------ALTERACIONES COMPRA---------------------------------------------------------------

ALTER TABLE COMPRAS ADD CONSTRAINT CODIGO_PROVEDOR_FC FOREIGN KEY (CODIGO_PROVEDOR_FC) REFERENCES PROVEEDORES (CODIGO_PROVEEDOR)
ALTER TABLE COMPRAS ADD CONSTRAINT ID_ESTADO_FC FOREIGN KEY (ID_ESTADO_FC) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE COMPRAS ADD CONSTRAINT ID_EMPLEADOFC FOREIGN KEY (ID_EMPLEADOFC) REFERENCES EMPLEADO (IDENTIFICACION_EMPLEADO)
ALTER TABLE COMPRAS ADD  ID_FORMA_PAGO_FK  INT FOREIGN KEY (ID_FORMA_PAGO_FK) REFERENCES FORMA_PAGO (ID_FORMA_PAGO)

-------------------------------------------------ALTERACIONES CONTRATO----------------------------------------------------------------

ALTER TABLE CONTRATO ADD CONSTRAINT ID_ESTADO_C FOREIGN KEY (ID_ESTADO_C) REFERENCES ESTADO (ID_ESTADO)

--------------------------------------------------ALTERACIONES DEVOLUCION PRODUCTO----------------------------------------------------

ALTER TABLE DEVOLUCION_PRODUCTO ADD CONSTRAINT ID_ESTADO_D_FK FOREIGN KEY (ID_ESTADO_D_FK) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE DEVOLUCION_PRODUCTO ADD CONSTRAINT ID_CLIENTE_D FOREIGN KEY (ID_CLIENTE_D) REFERENCES CLIENTES (IDENTIFICACION_CLIENTE)
ALTER TABLE DEVOLUCION_PRODUCTO ADD CONSTRAINT ID_EMPLEADO_D FOREIGN KEY (ID_EMPLEADO_D) REFERENCES EMPLEADO (IDENTIFICACION_EMPLEADO)

--------------------------------------------------ALTERACIONES EMPLEADO----------------------------------------------------------------

ALTER TABLE EMPLEADO ADD CONSTRAINT ID_ESTADO_E FOREIGN KEY (ID_ESTADO_E) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE EMPLEADO ADD CONSTRAINT NUMERO_CONTRATO_E FOREIGN KEY (NUMERO_CONTRATO_E) REFERENCES CONTRATO (NUMERO_CONTRATO)
ALTER TABLE EMPLEADO ADD CONSTRAINT CODIGO_CARGO_E FOREIGN KEY (CODIGO_CARGO_E) REFERENCES CARGO (CODIGO_CARGO)

-------------------------------------------------ALTERACIONES FORMA PAGO---------------------------------------------------------------

ALTER TABLE FORMA_PAGO ADD CONSTRAINT ID_ESTADO_FP FOREIGN KEY (ID_ESTADO_FP) REFERENCES ESTADO (ID_ESTADO)

-------------------------------------------------ALTERACIONES GARANTIAS----------------------------------------------------------------

ALTER TABLE GARANTIA ADD CONSTRAINT ID_ESTADO_GARANTIA FOREIGN KEY (ID_ESTADO_GARANTIA) REFERENCES ESTADO (ID_ESTADO)

-------------------------------------------------ALTERACIONES INVENTARIO---------------------------------------------------------------

ALTER TABLE INVENTARIO ADD CONSTRAINT ID_ESTADO_INVENTARIO FOREIGN KEY (ID_ESTADO_INVENTARIO) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE INVENTARIO ADD CONSTRAINT EMPLEADO_INVENTARIO FOREIGN KEY (EMPLEADO_INVENTARIO) REFERENCES EMPLEADO (IDENTIFICACION_EMPLEADO)

-------------------------------------------------ALTERACIONES PRODUCTO-----------------------------------------------------------------

ALTER TABLE PRODUCTOS ADD CONSTRAINT ID_ESTADO_PRODUCTO FOREIGN KEY (ID_ESTADO_PRODUCTO) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE PRODUCTOS ADD CONSTRAINT ID_GARANTIA_PRODUCTO FOREIGN KEY (ID_GARANTIA_PRODUCTO) REFERENCES GARANTIA (ID_GARANTIA)
ALTER TABLE PRODUCTOS ADD CONSTRAINT CODIGO_PRESENTACION_PRODUCTO FOREIGN KEY (CODIGO_PRESENTACION_PRODUCTO ) REFERENCES TIPO_PRESENTACION (CODIGO_TPRESENTACION)

-------------------------------------------------ALTERACIONES PROVEEDORES--------------------------------------------------------------

ALTER TABLE PROVEEDORES ADD CONSTRAINT ID_ESTADO_PROVEEDOR FOREIGN KEY (ID_ESTADO_PROVEEDOR) REFERENCES ESTADO (ID_ESTADO)



-------------------------------------------------ALTERACIONES TIPO_PRESENTACION--------------------------------------------------------

ALTER TABLE TIPO_PRESENTACION ADD CONSTRAINT  ID_ESTADO_TPRESENTACION FOREIGN KEY (ID_ESTADO_TPRESENTACION) REFERENCES ESTADO (ID_ESTADO)

-------------------------------------------------ALTERACIONES USUARIO------------------------------------------------------------------

ALTER TABLE USUARIO ADD CONSTRAINT ID_ESTADO_U FOREIGN KEY (ID_ESTADO_U) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE USUARIO ADD CONSTRAINT ID_EMPLEADO_U FOREIGN KEY (ID_EMPLEADO_U) REFERENCES EMPLEADO (IDENTIFICACION_EMPLEADO)



-------------------------------------------------ALTERACIONES VENTA--------------------------------------------------------------------

ALTER TABLE VENTAS ADD CONSTRAINT ID_CLIENTEFV FOREIGN KEY (ID_CLIENTEFV) REFERENCES CLIENTES (IDENTIFICACION_CLIENTE)
ALTER TABLE VENTAS ADD CONSTRAINT ID_ESTADO_FV FOREIGN KEY (ID_ESTADO_FV) REFERENCES ESTADO (ID_ESTADO)
ALTER TABLE VENTAS ADD  ID_EMPLEADOFV INT FOREIGN KEY (ID_EMPLEADOFV) REFERENCES EMPLEADO (IDENTIFICACION_EMPLEADO)
ALTER TABLE VENTAS ADD ID_FORMA_PAGO_FV INT FOREIGN KEY (ID_FORMA_PAGO_FV) REFERENCES FORMA_PAGO (ID_FORMA_PAGO)

-------------------------------------------------ALTERACIONES DETALLES----------------------------------------------------------------



-------------------------------------------------ALTERACIONES DETALLE DEVOLUCION-------------------------------------------------------

ALTER TABLE DETALLE_DEVOLUCION ADD CONSTRAINT CODIGO_DEVOLUCION_FK FOREIGN KEY (CODIGO_DEVOLUCION_FK) REFERENCES DEVOLUCION_PRODUCTO (CODIGO_DEVOLUCION)
ALTER TABLE DETALLE_DEVOLUCION ADD CONSTRAINT CODIGO_PRODUCTODTD FOREIGN KEY (CODIGO_PRODUCTODTD) REFERENCES PRODUCTOS (CODIGO_PRODUCTO)

-------------------------------------------------ALTERACIONES DETALLE F COMPRA --------------------------------------------------------


ALTER TABLE DETALLE_FACTURA_COMPRA ADD CONSTRAINT NUMERO_FACTURAC_FK FOREIGN KEY (NUMERO_FACTURAC_FK) REFERENCES COMPRAS (NUMERO_FACTURAC)
ALTER TABLE DETALLE_FACTURA_COMPRA ADD CONSTRAINT CODIGO_PRODUCTO_FC FOREIGN KEY (CODIGO_PRODUCTO_FC) REFERENCES PRODUCTOS (CODIGO_PRODUCTO)


-------------------------------------------------ALTERACIONDES DETALLE F VENTA---------------------------------------------------------

ALTER TABLE DETALLE_FACTURA_VENTA ADD CONSTRAINT NUMERO_FACTURAV FOREIGN KEY (NUMERO_FACTURAV) REFERENCES VENTAS (NUMERO_FACTURA_V)
ALTER TABLE DETALLE_FACTURA_VENTA ADD CONSTRAINT CODIGO_PRODUCTODFV FOREIGN KEY (CODIGO_PRODUCTODFV) REFERENCES PRODUCTOS (CODIGO_PRODUCTO)
