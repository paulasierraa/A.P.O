using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Conexion
    {
        static string cadena_conexion = @"DATA SOURCE = PAULA\SQLEXPRESS; INITIAL CATALOG =  PROYECTO_APO; INTEGRATED SECURITY = TRUE";

        public static string cadenaconexion
        {
            get { return cadena_conexion; }
        }
    }
}
