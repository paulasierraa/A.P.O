using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
namespace Lógica
{
   public class Clase_contrato
    {
        public int IngresarContrato(string nombre_contrato,string fecha_inicio_contrato, string duracion_contrato,string fecha_fin_contrato, int id_estado_contrato, long valor_contrato)
        {
            Datos.Contrato acceso = new Contrato();
            return acceso.Insertar_Contrato(nombre_contrato,fecha_inicio_contrato, duracion_contrato,fecha_fin_contrato, id_estado_contrato, valor_contrato);

        }
        public int ModificarContrato(int numero_contrato, string nombre_contrato,string fecha_inicio_Contrato, string duracion_contrato,string fecha_fin_contrato, int id_estado_contrato, long valor_contrato)
        {
            Datos.Contrato acceso = new Contrato();
            return acceso.Modificar_Contrato(numero_contrato, nombre_contrato,fecha_inicio_Contrato, duracion_contrato,fecha_fin_contrato, id_estado_contrato, valor_contrato);

        }
       public int EliminarContrato(int numero_contrato)
       {
           Datos.Contrato acceso = new Contrato();
           return acceso.Eliminar_Contrato(numero_contrato);
       }
       public static DataTable llenargrillacontrato()
       {
           return Datos.Contrato.llenar_grilla_contrato();
       }
    
    }
}
