using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
 public   class Inventario
    {
   
     public static DataTable identity_inventario()
     {
         SqlCommand comando = Metodos.CrearComando();
         comando.CommandText = "IDENTITY_INVENTARIO";
         return Metodos.EjecutarComandoSelect(comando);
     }
     public static DataTable llenar_inventario()
     {
         SqlCommand comando = Metodos.CrearComando();
         comando.CommandText = "CONSULTAR_INVENTARIOS";
         return Metodos.EjecutarComandoSelect(comando);
     }
     public static DataTable consultar_inventario(string fecha)
     {
         SqlCommand comando = Metodos.CrearComandoProc("BUSCAR_INVENTARIO");
         comando.Parameters.AddWithValue("@FECHA_INVENTARIO",fecha);
         return Metodos.EjecutarComandoSelect(comando);
     }
     public static DataTable especifica_inventario(int numero_inventario)
     {
         SqlCommand comando = Metodos.CrearComandoProc("ESPECIFICA_INVENTARIO");
         comando.Parameters.AddWithValue("@NUMERO_INVENTARIO",numero_inventario);
         return Metodos.EjecutarComandoSelect(comando);
     }
    }
}
