using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_tipo_presentacion
    {
          Datos.Tipo_presentacion acceso = new Datos.Tipo_presentacion();

       public int ingresar_tpresentacion(string nombre_tpresentacion, int id_Estado_tpresentacion)
       {
           return acceso.Insertar_tipo_presentacion(nombre_tpresentacion, id_Estado_tpresentacion);
       }
       public int Modificar_tpresentacion(int codigo_tpresentacion,string nombre_tpresentacion, int id_Estado_tpresentacion)
       {
           return acceso.modificar_tipo_presentacion(codigo_tpresentacion,nombre_tpresentacion,id_Estado_tpresentacion);
       }
       public int Eliminar_tpresentacion(int codigo_tpresentacion)
       {
           return acceso.eliminar_tipo_presentacion(codigo_tpresentacion);
       }
       public static DataTable llenargrillapresentacion()
       {
           return Datos.Tipo_presentacion.llenar_grilla_presentacion();
       }
     
    }
}
