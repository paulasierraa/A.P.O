using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
    public class Clase_usuario
    {
        Datos.Usuario acceso = new Datos.Usuario();

        public int ingresar_usuario(string nombre_usuario, string clave_usuario,string tipo_usuario, int id_Estado_u, int id_empleado_u)
        {

            return acceso.insertar_usuario(nombre_usuario, clave_usuario, tipo_usuario, id_Estado_u, id_empleado_u);
        }
        public int Modificar_usuario(int id_usuario,string nombre_usuario, string clave_usuario,string tipo_usuario, int id_Estado_u, int id_empleado_u)
        {
            return acceso.modificar_usuario(id_usuario,nombre_usuario, clave_usuario,tipo_usuario, id_Estado_u, id_empleado_u);
        }
        public int Eliminar_usuario(int id_usuario)
        {
            return acceso.eliminar_usuario(id_usuario);
        }
        public static DataTable llenargrillausuario()
        {
            return Datos.Usuario.llenar_grilla_usuario();
        }
        public static DataTable logeo(string nombre_usuario , string clave_usuario, string tipo_usuario)
        {
            return Datos.Usuario.login(nombre_usuario,clave_usuario,tipo_usuario);
        }
  
    }
}
