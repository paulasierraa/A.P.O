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
   public class Clase_clientes
    {
       public int IngresarClientes(int identificacion_cliente, string nombre_cliente, long telefono_cliente, string correo_cliente, int id_estado)
       {
           Datos.Clientes acceso = new Clientes();
           return acceso.Insertar_Clientes(identificacion_cliente, nombre_cliente, telefono_cliente, correo_cliente, id_estado);
       }
       public int ModificarClientes(int identificacion_cliente, string nombre_cliente, long telefono_cliente, string correo_cliente, int id_estado)
       {
           Datos.Clientes acceso = new Clientes();
           return acceso.Modificar_Clientes(identificacion_cliente, nombre_cliente, telefono_cliente, correo_cliente, id_estado);
       }
       public int EliminarClientes(int identificacion_cliente)
       {
           Datos.Clientes acceso = new Clientes();
           return acceso.Eliminar_Clientes(identificacion_cliente);
       }
       public static DataTable llenargrillacliente()
       {
           return Datos.Clientes.llenar_grilla_clientes();
       }

    }
}
