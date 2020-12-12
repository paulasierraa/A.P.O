using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Entrada_Salida_Dinero
    {

        public static DataTable entrada_dinero()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "ENTRADA_DINERO";
            return Metodos.EjecutarComandoSelect(comando);
        }
        public static DataTable total_capital()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "DINERO_EXISTENTE";
            return Metodos.EjecutarComandoSelect(comando);
        }
        public static DataTable salida_dinero()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "SALIDA_DINERO";
            return Metodos.EjecutarComandoSelect(comando);
        }
    }

 
}
  
