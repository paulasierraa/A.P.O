using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public  class Usuario
    {
       public int insertar_usuario(string nombre_usuario, string clave_usuario,string tipo_usuario, int id_Estado_u, int id_empleado_u)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_USUARIO");
           comando.Parameters.AddWithValue("@NOMBRE_USUARIO", nombre_usuario);
           comando.Parameters.AddWithValue("@CLAVE_USUARIO", clave_usuario);
           comando.Parameters.AddWithValue("@TIPO_USUARIO",tipo_usuario);
           comando.Parameters.AddWithValue("@ID_ESTADO_U", id_Estado_u);
           comando.Parameters.AddWithValue("@ID_EMPLEADO_U", id_empleado_u);
       
           return Metodos.EjecutarComando(comando);
       }
       public int modificar_usuario(int id_usuario,string nombre_usuario, string clave_usuario,string tipo_usuario, int id_Estado_u, int id_empleado_u)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_USUARIO");
           comando.Parameters.AddWithValue("@ID_USUARIO",id_usuario);
           comando.Parameters.AddWithValue("@NOMBRE_USUARIO", nombre_usuario);
           comando.Parameters.AddWithValue("@CLAVE_USUARIO", clave_usuario);
           comando.Parameters.AddWithValue("@TIPO_USUARIO",tipo_usuario);
           comando.Parameters.AddWithValue("@ID_ESTADO_U", id_Estado_u);
           comando.Parameters.AddWithValue("@ID_EMPLEADO_U", id_empleado_u);

           return Metodos.EjecutarComando(comando);
       }
       public int eliminar_usuario(int id_usuario)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_USUARIO");
           comando.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
           return Metodos.EjecutarComando(comando);
       }
       public static DataTable llenar_grilla_usuario()
   {
       SqlCommand comando = Metodos.CrearComando();
       comando.CommandText = "CONSULTAR_USUARIOS";
       return Metodos.EjecutarComandoSelect(comando);
   }
       public static DataTable login(string nombre , string contraseña, string tipo_usuario)
       {
           SqlCommand comando = Metodos.CrearComandoProc("LOGEO");
           comando.Parameters.AddWithValue("@NOMBRE_LOGEO",nombre);
           comando.Parameters.AddWithValue("@CLAVE_LOGEO",contraseña);
           comando.Parameters.AddWithValue("@TIPO_USUARIO", tipo_usuario);
           return Metodos.EjecutarComandoSelect(comando);
       }

    }
}
