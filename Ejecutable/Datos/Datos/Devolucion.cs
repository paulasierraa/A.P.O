using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Devolucion
    {
       public int Insertar_Devolucion(string fecha_devolucion, int id_Estado_d,int id_cliente_D, int id_empleado_d)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_DEVOLUCION");
           comando.Parameters.AddWithValue("@FECHA_DEVOLUCION", fecha_devolucion);
           comando.Parameters.AddWithValue("@ID_ESTADO_F_FK", id_Estado_d);
           comando.Parameters.AddWithValue("@ID_CLIENTE_D ", id_cliente_D);
           comando.Parameters.AddWithValue("@ID_EMPLEADO_D",id_empleado_d);
           return Metodos.EjecutarComando(comando);

       }
       public int Modificar_Devolucion(int codigo_devolucion,string fecha_devolucion, int id_Estado_d , int id_cliente_d, int id_Empleado_d)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_DEVOLUCION");
           comando.Parameters.AddWithValue("@CODIGO_DEVOLUCION", codigo_devolucion);
           comando.Parameters.AddWithValue("@FECHA_DEVOLUCION", fecha_devolucion);
           comando.Parameters.AddWithValue("@ID_ESTADO_DV", id_Estado_d);
           comando.Parameters.AddWithValue("@ID_CLIENTE_D ", id_cliente_d);
           comando.Parameters.AddWithValue("@ID_EMPLEADO_D",id_Empleado_d);
           return Metodos.EjecutarComando(comando);

       }
       public int Eliminar_Devolucion(int codigo_devolucion)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_DEVOLUCION");
           comando.Parameters.AddWithValue("@CODIGO_DEVOLUCION", codigo_devolucion);
           return Metodos.EjecutarComando(comando);
       }
       public static DataTable identity_devolucion()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "IDENTITY_DEVOLUCION";
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable llenar_devolucion()
       {
           SqlCommand comando = Metodos.CrearComando();
           comando.CommandText = "CONSULTAR_DEVOLUCION";
           return Metodos.EjecutarComandoSelect(comando);
       }
       public static DataTable buscar_devolucion(string fecha_devolucion)
       {
           SqlCommand comando = Metodos.CrearComandoProc("BUSCAR_DEVOLUCION");
           comando.Parameters.AddWithValue("@FECHA_DEV", fecha_devolucion);
           return Metodos.EjecutarComandoSelect(comando);
       }
    }
}
