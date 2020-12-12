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
    public class Clase_Devolucion
    {
        public int IngresarDevolucion(string fecha_devolucion, int id_Estado_D , int id_cliente_D , int id_Empleado_d)
        {
            Datos.Devolucion acceso = new Devolucion();
            return acceso.Insertar_Devolucion(fecha_devolucion, id_Estado_D, id_cliente_D, id_Empleado_d);
        }
        public int ModificarDevolucion(int codigo_devolucion, string fecha_devolucion, int id_Estado_d, int id_cliente_d, int id_Empleado_d)
        {
            Datos.Devolucion acceso = new Devolucion();
            return acceso.Modificar_Devolucion(codigo_devolucion,fecha_devolucion, id_Estado_d,id_cliente_d,  id_Empleado_d);
        }
        public int EliminarDevolucion(int codigo_devolucion)
        {
            Datos.Devolucion acceso = new Devolucion();
            return acceso.Eliminar_Devolucion(codigo_devolucion);
        }
        public static DataTable Identitydevolucion()
        {
            return Datos.Devolucion.identity_devolucion();
        }
        public static DataTable llenardevolucion()
        {
            return Datos.Devolucion.llenar_devolucion();
        }
        public static DataTable Buscar_devolucionfecha(string fecha_devolucion)
        {
            return Devolucion.buscar_devolucion(fecha_devolucion);
        }
    }
}
