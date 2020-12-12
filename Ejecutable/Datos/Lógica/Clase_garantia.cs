using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_garantia
    {
       public int ingresar_garantia(string tiempo_total, string fecha_inicio_Garantia, string fecha_fin_garantia, int id_estado_garantia)
       {
           Datos.Garantia acceso = new Datos.Garantia();
           return acceso.Insertar_garantia( tiempo_total, fecha_inicio_Garantia, fecha_fin_garantia, id_estado_garantia);
       }
       public int Modificar_garantia(int id_garantia,string tiempo_total, string fecha_inicio_Garantia, string fecha_fin_garantia, int id_estado_garantia)
       {
           Datos.Garantia acceso = new Datos.Garantia();
           return acceso.modificar_garantia(id_garantia,tiempo_total, fecha_inicio_Garantia, fecha_fin_garantia, id_estado_garantia);
       }
        public int Eliminar_garantia (int id_Garantia)
        {
            Datos.Garantia acceso = new Datos.Garantia();
            return acceso.eliminar_garantia(id_Garantia);
        }
        public static DataTable llenargrillagarantia()
        {
            return Datos.Garantia.llenar_grilla_garantias();
        }
   
    }
}
