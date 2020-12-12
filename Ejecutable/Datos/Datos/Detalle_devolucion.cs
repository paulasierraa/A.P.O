using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
  public  class Detalle_devolucion
    {
      public int insertar_detalle_devolucion(int codigo_productodtd, long valor_productodtd, int cantidad_productodtd, int codigo_devolucion_fk)
      {
          SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_DETALLE_DEVOLUCION");
          comando.Parameters.AddWithValue("@CODIGO_PRODUCTODTD", codigo_productodtd);
          comando.Parameters.AddWithValue("@VALOR_PRODUCTODTD", valor_productodtd);
          comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTODTD", cantidad_productodtd);
          comando.Parameters.AddWithValue("@CODIGO_DEVOLUCION_FK", codigo_devolucion_fk);
          return Metodos.EjecutarComando(comando);

      }
      public int Modificar_Detalle_Devolucion(int id_Dt ,int codigo_productodtd, long valor_productodtd, int cantidad_productodtd)
      {
          SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_DETALLE_DEVOLUCION");
          comando.Parameters.AddWithValue("@ID_DETALLEDV",id_Dt);
          comando.Parameters.AddWithValue("@CODIGO_PRODUCTODTD", codigo_productodtd);
          comando.Parameters.AddWithValue("@VALOR_PRODUCTODTD", valor_productodtd);
          comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTODTD", cantidad_productodtd);
          return Metodos.EjecutarComando(comando);

      }
      public int Eliminar_Detalle_Devolucion(int id_detalle_devolucion)
      {
          SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_DETALLE_DEVOLUCION");
          comando.Parameters.AddWithValue("@ID_DETALLEDV", id_detalle_devolucion);
          return Metodos.EjecutarComando(comando);
      }
      public static DataTable identity_Detalle_devolucion()
      {
          SqlCommand comando = Metodos.CrearComando();
          comando.CommandText = "IDENTITY_DTDEVOLUCION";
          return Metodos.EjecutarComandoSelect(comando);
      }
      public static DataTable consulta_Detalle_devolucion(int codigo_Devolucion)
      {
          SqlCommand comando = Metodos.CrearComandoProc("CONSULTAR_DETALLE_DEVOLUCION");
          comando.Parameters.AddWithValue("@NUMERO_DEVOLUCION",codigo_Devolucion);
          return Metodos.EjecutarComandoSelect(comando);
      }
    }
}
