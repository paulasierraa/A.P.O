using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_entrada_salida_dinero
    {
       public static DataTable entrada_dinero()
       {
          return Datos.Entrada_Salida_Dinero.entrada_dinero();
       }
       public static DataTable total_capital()
       {
           return Datos.Entrada_Salida_Dinero.total_capital();
       }
       public static DataTable salida_dinero()
       {
           return Datos.Entrada_Salida_Dinero.salida_dinero();
       }
    }
}
