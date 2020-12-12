using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Compras
    {
       public int Insertar_Compras(int numero_factura_proveedor, long subtotal_facturac, string fecha_facturac, long valor_factura_c, long iva_factura_c, int id_empleadofc, int codigo_proveedor, int id_estado_fc, int id_forma_pago_fk)
       {

           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_COMPRA");
           comando.Parameters.AddWithValue("@NUMERO_FACTURA_PROVEEDOR", numero_factura_proveedor);
           comando.Parameters.AddWithValue("@SUBTOTAL_FACTURAC", subtotal_facturac);
           comando.Parameters.AddWithValue("@FECHA_FACTURAC ", fecha_facturac);
           comando.Parameters.AddWithValue("@VALOR_FACTURA_C", valor_factura_c);
           comando.Parameters.AddWithValue("@IVA_FACTURA_C ", iva_factura_c);
           comando.Parameters.AddWithValue("@ID_EMPLEADOFC", id_empleadofc);
           comando.Parameters.AddWithValue("@CODIGO_PROVEEDOR_FC", codigo_proveedor);
           comando.Parameters.AddWithValue("@ID_ESTADO_FC", id_estado_fc);
           comando.Parameters.AddWithValue("@ID_FORMA_PAGO_FK", id_forma_pago_fk);
           return Metodos.EjecutarComando(comando);

       }
       public int Modificar_Compras(int numero_facturac , int numero_factura_proveedor, long subtotal_facturac, string fecha_facturac, long valor_factura_c, long iva_factura_c, int id_empleadofc, int codigo_proveedor, int id_estado_fc, int id_forma_pago_fk)
       {

           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_COMPRAS");
           comando.Parameters.AddWithValue("@NUMERO_FACTURAC", numero_facturac);
           comando.Parameters.AddWithValue("@NUMERO_FACTURA_PROVEEDOR", numero_factura_proveedor);
           comando.Parameters.AddWithValue("@SUBTOTAL_FACTURAC", subtotal_facturac);
           comando.Parameters.AddWithValue("@FECHA_FACTURAC ", fecha_facturac);
           comando.Parameters.AddWithValue("@VALOR_FACTURA_C", valor_factura_c);
           comando.Parameters.AddWithValue("@IVA_FACTURA_C ", iva_factura_c);
           comando.Parameters.AddWithValue("@ID_EMPLEADOFC", id_empleadofc);
           comando.Parameters.AddWithValue("@CODIGO_PROVEEDOR_FC", codigo_proveedor);
           comando.Parameters.AddWithValue("@ID_ESTADO_FC", id_estado_fc);
           comando.Parameters.AddWithValue("@ID_FORMA_PAGO_FK", id_forma_pago_fk);
           return Metodos.EjecutarComando(comando);

       }
       public int Eliminar_Compras(int Numero_factura_c)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_COMPRAS");
           comando.Parameters.AddWithValue("@NUMERO_FACTURAC", Numero_factura_c);
           return Metodos.EjecutarComando(comando);
       }
       public static DataTable identity_compra()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "IDENTITY_COMPRA";
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable llenar_compra()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "CONSULTAR_COMPRAS";
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable buscar_compra(string fecha_compra)
       {
           SqlCommand comando = Metodos.CrearComandoProc("BUSCAR_COMPRA");
           comando.Parameters.AddWithValue("@FECHA_COMPRA",fecha_compra);
           return Metodos.EjecutarComandoSelect(comando);
       }
    }
}
