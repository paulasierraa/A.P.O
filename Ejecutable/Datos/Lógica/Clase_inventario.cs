using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
  public   class Clase_inventario
    {
     
      public static DataTable identityinventario()
      {
          return Datos.Inventario.identity_inventario();
      }
      public static DataTable llenar_inventario()
      {
          return Datos.Inventario.llenar_inventario();
      }
      public static DataTable Consultarinventario(string fecha)
      {
          return Datos.Inventario.consultar_inventario(fecha);
      }
      public static DataTable especifica_inventario(int numero_inventario)
      {
          return Datos.Inventario.especifica_inventario(numero_inventario);
      }
    }
}
