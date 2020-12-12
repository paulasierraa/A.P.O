using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Lógica
{
   public class Clase_Venta
    {
        public int ingresar_ventas(string fecha_Facv, long subtotal_facv, long iva_facv, long valor_facv, int id_Clientefv, int id_estado_Fv, int id_empleadofv, int id_forma_pago_Fv)
        {
            Datos.Ventas acceso = new Datos.Ventas();
            return acceso.insertar_venta(fecha_Facv, subtotal_facv, iva_facv, valor_facv, id_Clientefv, id_estado_Fv, id_empleadofv, id_forma_pago_Fv);
        }
        public int modificar_Venta(int numero_factura_v, string fecha_Facv, long sb_Facv, long iva_facv, long valor_Facv, int id_clientefv, int id_Estado_fv, int id_empleado_fv, int id_forma_pagofv)
        {
            Datos.Ventas acceso = new Datos.Ventas();
            return acceso.modificar_venta( numero_factura_v , fecha_Facv,  sb_Facv,  iva_facv, valor_Facv,  id_clientefv,  id_Estado_fv, id_empleado_fv,  id_forma_pagofv);
        }
        public int eliminarventa(int numero_Factura_v)
        {
            Datos.Ventas acceso = new Datos.Ventas();
            return acceso.Eliminar_venta(numero_Factura_v);
        }
        public static DataTable llenarventa()
        {
            return Datos.Ventas.Llenar_ventas();
        }
        public static DataTable identityventa()
        {
            return Datos.Ventas.consulta_identity();
        }
        public static DataTable buscarventa(string fecha)
        {
            return Datos.Ventas.buscar_venta_fecha(fecha);
        }
    }
}
