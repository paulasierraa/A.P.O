using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Lógica
{
   public class Clase_compras
    {
       public int IngresarCompras(int numero_factura_proveedor, long subtotal_facturac, string fecha_facturac, long valor_factura_c, long iva_factura_c, int id_empleadofc, int codigo_proveedor, int id_estado_fc, int id_forma_pago_fk)
       {
           Datos.Compras acceso = new Compras();
           return acceso.Insertar_Compras(numero_factura_proveedor, subtotal_facturac, fecha_facturac, valor_factura_c, iva_factura_c, id_empleadofc, codigo_proveedor, id_estado_fc, id_forma_pago_fk);
       }
       public int ModificarCompras(int numero_facturac,int numero_factura_proveedor, long subtotal_facturac, string fecha_facturac, long valor_factura_c, long iva_factura_c, int id_empleadofc, int codigo_proveedor, int id_estado_fc, int id_forma_pago_fk)
       {
           Datos.Compras acceso = new Compras();
           return acceso.Modificar_Compras(numero_facturac,numero_factura_proveedor, subtotal_facturac, fecha_facturac, valor_factura_c, iva_factura_c, id_empleadofc, codigo_proveedor, id_estado_fc, id_forma_pago_fk);
       }
       public int EliminarCompras(int Numero_factura_c)
       {
           Datos.Compras acceso = new Compras();
           return acceso.Eliminar_Compras(Numero_factura_c);
       }
       public static DataTable Identitycompra()
       {
           return Datos.Compras.identity_compra();
       }
       public static DataTable llenarcompra()
       {
           return Datos.Compras.llenar_compra();
       }
       public static DataTable Buscar_comprafecha(string fecha_compra)
       {
           return Compras.buscar_compra(fecha_compra);
       }

    }
}
