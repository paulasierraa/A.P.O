using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Proveedores
    {
       public int insertar_proveedores(int codigo_proveedor, string nombre_proveedor, string r_social_proveedor, string direccion_proveedor, string ciudad_proveedor, int c_postal_proveedor, long telefono_proveedor, string c_electronico_proveedor, int id_Estado_proveedor)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_PROVEEDOR");
           comando.Parameters.AddWithValue("@CODIGO_PROVEEDOR", codigo_proveedor);
           comando.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", nombre_proveedor);
           comando.Parameters.AddWithValue("@R_SOCIAL_PROVEEDOR", r_social_proveedor);
           comando.Parameters.AddWithValue("@DIRECCION_PROVEEDOR", direccion_proveedor);
           comando.Parameters.AddWithValue("@CIUDAD_PROVEEDOR", ciudad_proveedor);
           comando.Parameters.AddWithValue("@C_POSTAL_PROVEEDOR", c_postal_proveedor);
           comando.Parameters.AddWithValue("@TELEFONO_PROVEEDOR", telefono_proveedor);
           comando.Parameters.AddWithValue("@C_ELECTRONICO_PROVEEDOR", c_electronico_proveedor);
           comando.Parameters.AddWithValue("@ID_ESTADO_PROVEEDOR", id_Estado_proveedor);
           return Metodos.EjecutarComando(comando);
       }
       public int modificar_proveedores( int codigo_proveedor,string nombre_proveedor, string r_social_proveedor, string direccion_proveedor, string ciudad_proveedor, int c_postal_proveedor, long telefono_proveedor, string c_electronico_proveedor, int id_Estado_proveedor)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_PROVEEDOR");
           comando.Parameters.AddWithValue("@CODIGO_PROVEEDOR",codigo_proveedor);
           comando.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", nombre_proveedor);
           comando.Parameters.AddWithValue("@R_SOCIAL_PROVEEDOR", r_social_proveedor);
           comando.Parameters.AddWithValue("@DIRECCION_PROVEEDOR", direccion_proveedor);
           comando.Parameters.AddWithValue("@CIUDAD_PROVEEDOR", ciudad_proveedor);
           comando.Parameters.AddWithValue("@C_POSTAL_PROVEEDOR", c_postal_proveedor);
           comando.Parameters.AddWithValue("@TELEFONO_PROVEEDOR", telefono_proveedor);
           comando.Parameters.AddWithValue("@C_ELECTRONICO_PROVEEDOR", c_electronico_proveedor);
           comando.Parameters.AddWithValue("@ID_ESTADO_PROVEEDOR", id_Estado_proveedor);
           return Metodos.EjecutarComando(comando);
       }
       public int eliminar_proveedor(int codigo_proveedor)
       {
           SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_PROVEEDORES");
           comando.Parameters.AddWithValue("@CODIGO_PROVEEDOR",codigo_proveedor);
           return Metodos.EjecutarComando(comando);
       }
              public static DataTable llenar_grilla_proveedores()
   {
       SqlCommand comando = Metodos.CrearComando();
       comando.CommandText = "CONSULTAR_PROVEEDORES";
       return Metodos.EjecutarComandoSelect(comando);
   }
 
    }

}
