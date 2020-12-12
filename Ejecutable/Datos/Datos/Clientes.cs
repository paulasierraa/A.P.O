using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Clientes
    {
       public int Insertar_Clientes(int identificacion_cliente, string nombre_cliente, long telefono_cliente, string correo_cliete, int id_estado)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_CLIENTE");
           comando.Parameters.AddWithValue("@IDENTIFICACION_CLIENTE", identificacion_cliente);
           comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", nombre_cliente);
           comando.Parameters.AddWithValue("@TELEFONO_CLIENTE", telefono_cliente);
           comando.Parameters.AddWithValue("@CORREO_CLIENTE", correo_cliete);
           comando.Parameters.AddWithValue("@ID_ESTADO_CLIENTE_FK", id_estado);
           return Metodos.EjecutarComando(comando);

       }
       public int Modificar_Clientes(int identificacion_cliente, string nombre_cliente, long telefono_cliente, string correo_cliete, int id_estado)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_CLIENTE");
           comando.Parameters.AddWithValue("@IDENTIFICACION_CLIENTE", identificacion_cliente);
           comando.Parameters.AddWithValue("@NOMBRE_CLIENTE", nombre_cliente);
           comando.Parameters.AddWithValue("@TELEFONO_CLIENTE", telefono_cliente);
           comando.Parameters.AddWithValue("@CORREO_CLIENTE", correo_cliete);
           comando.Parameters.AddWithValue("@ID_ESTADO_CLIENTE_FK", id_estado);
           return Metodos.EjecutarComando(comando);

       }
       public int Eliminar_Clientes(int identificacion_cliente)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_CLIENTES");
           comando.Parameters.AddWithValue("@IDENTIFICACION_CLIENTE", identificacion_cliente);
           return Metodos.EjecutarComando(comando);
       }
       public static DataTable llenar_grilla_clientes()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "CONSULTAR_CLIENTES";
           return Metodos.EjecutarComandoSelect(comando);
       
       }
     
    }
}
