using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Datos
{
   public class Ventas
    {
        public int insertar_venta(string fecha_Facv, long sb_Facv, long iva_facv, long valor_Facv, int id_clientefv, int id_Estado_fv, int id_empleado_fv, int id_forma_pagofv)
        {
            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_VENTAS");
            comando.Parameters.AddWithValue("@FECHA_FACV", fecha_Facv);
            comando.Parameters.AddWithValue("@SUBTOTAL_FACV", sb_Facv);
            comando.Parameters.AddWithValue("@IVA_FACTURA_V", iva_facv);
            comando.Parameters.AddWithValue("@VALOR_FACTURAV", valor_Facv);
            comando.Parameters.AddWithValue("@ID_CLIENTEFV", id_clientefv);
            comando.Parameters.AddWithValue("@ID_ESTADO_FV", id_Estado_fv);
            comando.Parameters.AddWithValue("@ID_EMPLEADOFV", id_empleado_fv);
            comando.Parameters.AddWithValue("@ID_FORMA_PAGO_FV", id_forma_pagofv);
            return Metodos.EjecutarComando(comando);
        }
        public int modificar_venta(int numero_factura_v ,string fecha_Facv, long sb_Facv, long iva_facv, long valor_Facv, int id_clientefv, int id_Estado_fv, int id_empleado_fv, int id_forma_pagofv)
        {
            SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_VENTA");
            comando.Parameters.AddWithValue("@NUMERO_FACTURA_V",numero_factura_v);
            comando.Parameters.AddWithValue("@FECHA_FACV", fecha_Facv);
            comando.Parameters.AddWithValue("@SUBTOTAL_FACV", sb_Facv);
            comando.Parameters.AddWithValue("@IVA_FACTURA_V", iva_facv);
            comando.Parameters.AddWithValue("@VALOR_FACTURAV", valor_Facv);
            comando.Parameters.AddWithValue("@ID_CLIENTEFV", id_clientefv);
            comando.Parameters.AddWithValue("@ID_ESTADO_FV", id_Estado_fv);
            comando.Parameters.AddWithValue("@ID_EMPLEADOFV", id_empleado_fv);
            comando.Parameters.AddWithValue("@ID_FORMA_PAGO_FV", id_forma_pagofv);
            return Metodos.EjecutarComando(comando);
        }
        public int Eliminar_venta(int numero_Facturav)
        {
            SqlCommand comando = new SqlCommand("ELIMINAR VENTAS");
            comando.Parameters.AddWithValue("@NUMERO_FACTURA_V",numero_Facturav);
            return Metodos.EjecutarComando(comando);
        }
        public static DataTable Llenar_ventas()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_VENTAS";
            return Metodos.EjecutarComandoSelect(comando);
        }
        public static DataTable consulta_identity()
        {
            SqlCommand comando = Metodos.CrearComando( );
            comando.CommandText = "IDENTITY_VENTA";
            return Metodos.EjecutarComandoSelect(comando);
      
        }
        public static DataTable buscar_venta_fecha(string fecha)
        {
            SqlCommand comando = Metodos.CrearComandoProc("BUSCAR_VENTA");
            comando.Parameters.AddWithValue("@FECHA_VENTA",fecha);
            return Metodos.EjecutarComandoSelect(comando);
        }
    }
}
