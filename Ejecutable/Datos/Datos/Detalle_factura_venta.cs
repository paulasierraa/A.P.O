using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
  public  class Detalle_factura_venta
    {
      public int insertar_detalle_Factura_Venta(int codigo_productodfv, int numero_Facturav, int cantidad_productos_Facv, long valor_unitariofv, long subtotalfv)
      {
          SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_DETALLE_FACTURA_VENTA");
          comando.Parameters.AddWithValue("@CODIGO_PRODUCTODFV", codigo_productodfv);
          comando.Parameters.AddWithValue("@NUMERO_FACTURAV", numero_Facturav);
          comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOS_FACV", cantidad_productos_Facv);
          comando.Parameters.AddWithValue("@VALOR_UNITARIOFV", valor_unitariofv);
          comando.Parameters.AddWithValue("@SUBTOTALFV", subtotalfv);
          return Metodos.EjecutarComando(comando);
      }
      public int modificar_Detalle_Venta(int id_detalle,int codigo_productodfv, int numero_Facturav, int cantidad_productos_Facv, long valor_unitariofv, long subtotalfv)
      {
          SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_DETALLE_VENTA");
          comando.Parameters.AddWithValue("@ID_DETALLEFACTURAV",id_detalle);
          comando.Parameters.AddWithValue("@CODIGO_PRODUCTODFV", codigo_productodfv);
          comando.Parameters.AddWithValue("@NUMERO_FACTURAV", numero_Facturav);
          comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOS_FACV", cantidad_productos_Facv);
          comando.Parameters.AddWithValue("@VALOR_UNITARIOFV", valor_unitariofv);
          comando.Parameters.AddWithValue("@SUBTOTALFV", subtotalfv);
          return Metodos.EjecutarComando(comando);
      }
      public int Eliminar_detalle_Venta(int id_detallefacturav)
      {
          SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_DETALLE_VENTA");
          comando.Parameters.AddWithValue("@ID_DETALLEFACTURAV",id_detallefacturav);
          return Metodos.EjecutarComando(comando);
      }
      public static DataTable Llenar_venta(int num_ven)
    {
        SqlCommand comando = Metodos.CrearComandoProc("CONSULTAR_DETALLE_VENTA");
        comando.Parameters.AddWithValue("@NUMERO_FACTURA_V",num_ven);
        return Metodos.EjecutarComandoSelect(comando);
    }
    public static DataTable identity_venta()
    {
        SqlCommand comando = Metodos.CrearComando();
        comando.CommandText = "IDENTITY_DETALLE_VENTA";
        return Metodos.EjecutarComandoSelect(comando);
    }
    public static DataTable valor_prod(int codigo_producto)
    {
        SqlCommand comando = Metodos.CrearComandoProc("VALOR_PRODUCTO_VENTA");
        comando.Parameters.AddWithValue("@CODIGO_PRODUCTO",codigo_producto);
        return Metodos.EjecutarComandoSelect(comando);
    }
    }
}
