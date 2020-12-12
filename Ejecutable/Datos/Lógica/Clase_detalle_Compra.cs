using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
    public class Clase_detalle_Compra
    {
        public int ingresar_Detalle_compra(int codigo_producto_Fc, long valor_unitario_Fc, int cantidad_productosfc, long subtotal_Fc, int numero_Facturac_fk)
        {
            Datos.Detalle_factura_compra acceso = new Datos.Detalle_factura_compra();
            return acceso.ingresar_Detalle_Factura_compra(codigo_producto_Fc, valor_unitario_Fc, cantidad_productosfc, subtotal_Fc, numero_Facturac_fk);
        }
        public int ModificarDetalleCompra(int id_Detalle ,int codigo_producto_Fc, long valor_unitario_Fc, int cantidad_productosfc, long subtotal_Fc, int numero_Facturac_fk)
        {
            Datos.Detalle_factura_compra acceso = new Datos.Detalle_factura_compra();
            return acceso.Modificar_Detalle_Factura_Compra(id_Detalle,codigo_producto_Fc, valor_unitario_Fc, cantidad_productosfc, subtotal_Fc, numero_Facturac_fk);

        }
        public int EliminarDetalleCompra(int id_detallefacturac)
        {
            Datos.Detalle_factura_compra acceso = new Datos.Detalle_factura_compra();
            return acceso.Eliminar_Detalle_Factura_Compra(id_detallefacturac);
        }
        public static DataTable identitycompra()
        {
            return Datos.Detalle_factura_compra.identity_Detalle_compra();
        }
        public static DataTable consultadetalle(int numero_Facturac)
        {
            return Datos.Detalle_factura_compra.consulta_Detalle(numero_Facturac);
        }
        public static DataTable valor_produc(int codigo_producto)
        {
            return Datos.Detalle_factura_compra.valor_prod(codigo_producto);
        }
    }
}
