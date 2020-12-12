using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
   public class Detalle_factura_compra
    {
       public int ingresar_Detalle_Factura_compra(int codigo_producto_fc, long valor_unitario_fc, int cantidad_productosfc, long subtotal_fc, int numero_Facturac_fk)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_DETALLE_FACTURA_COMPRA");
           comando.Parameters.AddWithValue("@CODIGO_PRODUCTO_FC", codigo_producto_fc);
           comando.Parameters.AddWithValue("@VALOR_UNITARIO_FC", valor_unitario_fc);
           comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOSFC", cantidad_productosfc);
           comando.Parameters.AddWithValue("@SUBTOTAL_FC", subtotal_fc);
           comando.Parameters.AddWithValue("@NUMERO_FACTURAC_FK", numero_Facturac_fk);
           return Metodos.EjecutarComando(comando);
       }
       public int Modificar_Detalle_Factura_Compra(int id_Detalle,int codigo_producto_fc, long valor_unitario_fc, int cantidad_productosfc, long subtotal_fc, int numero_Facturac_fk)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_DETALLE_COMPRA");
           comando.Parameters.AddWithValue("@ID_DETALLE_FACTURA_C",id_Detalle);
           comando.Parameters.AddWithValue("@CODIGO_PRODUCTO_FC", codigo_producto_fc);
           comando.Parameters.AddWithValue("@VALOR_UNITARIO_FC", valor_unitario_fc);
           comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOSFC", cantidad_productosfc);
           comando.Parameters.AddWithValue("@SUBTOTAL_FC", subtotal_fc);
           comando.Parameters.AddWithValue("@NUMERO_FACTURAC_FK", numero_Facturac_fk);
           return Metodos.EjecutarComando(comando);
       }
       public int Eliminar_Detalle_Factura_Compra(int id_detallefacturac)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_DETALLE_COMPRA");
           comando.Parameters.AddWithValue("@ID_DETALLE_FACTURA_C", id_detallefacturac);
           return Metodos.EjecutarComando(comando);
       }
       public static DataTable identity_Detalle_compra()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "IDENTITY_DETALLE_COMPRA";
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable consulta_Detalle(int numero_Facturac)
       {
           SqlCommand comando = Metodos.CrearComandoProc("CONSULTAR_DETALLE_COMPRA");
           comando.Parameters.AddWithValue("@NUMERO_FACTURA_C",numero_Facturac);
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable valor_prod(int codigo_producto)
       {
           SqlCommand comando = Metodos.CrearComandoProc("VALOR_PRODUCTO_COMPRA");
           comando.Parameters.AddWithValue("@CODIGO_PRODUCTO",codigo_producto);
           return Metodos.EjecutarComandoSelect(comando);
       }
    }
}
