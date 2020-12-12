using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
    public class Clase_Detalle_venta
    {
        Datos.Detalle_factura_venta acceso = new Datos.Detalle_factura_venta();

        public int ingresar_detalle_Venta(int codigo_productodfv, int numero_Facturav, int cantidad_productos_Facv, long valor_unitariofv, long subtotalfv)
        {
           
            return acceso.insertar_detalle_Factura_Venta(codigo_productodfv,numero_Facturav,cantidad_productos_Facv,valor_unitariofv,subtotalfv);
        }
        public int Modificar_Detalle_venta(int id_detalle,int codigo_productodfv, int numero_Facturav, int cantidad_productos_Facv, long valor_unitariofv, long subtotalfv)
        {

            return acceso.modificar_Detalle_Venta(id_detalle,codigo_productodfv, numero_Facturav, cantidad_productos_Facv, valor_unitariofv, subtotalfv);
        }
        public int Eliminar_Detalle_Venta(int id_detallefacturav)
        {
            return acceso.Eliminar_detalle_Venta(id_detallefacturav);
        }
        public static DataTable Llenar_detalle_venta(int num_ven)
        {
            return Datos.Detalle_factura_venta.Llenar_venta(num_ven);
        }
        public static DataTable IdentityVenta()
        {
            return Datos.Detalle_factura_venta.identity_venta();
        }
        public static DataTable valor_producto(int codigo_producto)
        {
            return Datos.Detalle_factura_venta.valor_prod(codigo_producto);
        }
    }
}
