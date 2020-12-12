using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Lógica
{
    public class Clase_forma_pago
    {
        public int ingresar_forma_pago(string nombre_forma_pago, int id_estado_fp)
        {
            Datos.Forma_pago acceso = new Datos.Forma_pago();
            return acceso.insertar_forma_pago(nombre_forma_pago, id_estado_fp);
        }
   
        public int Modificar_forma_pago(int id_forma_pago,string nombre_forma_pago, int id_estado_fp)
        {
            Datos.Forma_pago acceso = new Datos.Forma_pago();
            return acceso.modificar_forma_pago(id_forma_pago,nombre_forma_pago, id_estado_fp);
        }
        public int eliminar_forma_pago(int id_forma_pago)
        {
            Datos.Forma_pago acceso = new Datos.Forma_pago();
            return acceso.Eliminar_forma_pago(id_forma_pago);
        }
        public static DataTable llenargrillafp()
        {
            return Datos.Forma_pago.llenar_grilla_fp();
        }
   

    }

}
