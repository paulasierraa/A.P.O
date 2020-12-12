using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_proveedores
    {
       public int ingresar_proveedores(int codigo_proveedor, string nombre_proveedor, string r_social_proveedor, string direccion_proveedor, string ciudad_proveedor, int c_postal_proveedor, long telefono_proveedor, string c_electronico_proveedor, int id_estado_proveedor)
       {
           Datos.Proveedores acceso = new Datos.Proveedores();
           return acceso.insertar_proveedores(codigo_proveedor, nombre_proveedor, r_social_proveedor, direccion_proveedor, ciudad_proveedor, c_postal_proveedor, telefono_proveedor, c_electronico_proveedor, id_estado_proveedor);
       }
       public int Modificar_proveedores(int codigo_proveedor, string nombre_proveedor, string r_social_proveedor, string direccion_proveedor, string ciudad_proveedor, int c_postal_proveedor, long telefono_proveedor, string c_electronico_proveedor, int id_estado_proveedor)
       {
           Datos.Proveedores acceso = new Datos.Proveedores();
           return acceso.modificar_proveedores(codigo_proveedor,nombre_proveedor, r_social_proveedor, direccion_proveedor, ciudad_proveedor, c_postal_proveedor, telefono_proveedor, c_electronico_proveedor, id_estado_proveedor);
       
       }
       public int eliminar_proveedores(int codigo_proveedor)
       {
           Datos.Proveedores acceso = new Datos.Proveedores();
           return acceso.eliminar_proveedor(codigo_proveedor);
       }
       public static DataTable llenargrillaproveedores()
       {
           return Datos.Proveedores.llenar_grilla_proveedores();
       }
     
    }
}
