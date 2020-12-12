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
  public  class Clase_Estado
    {

      Datos.Metodos obj_metodos = new Datos.Metodos();

     string _cadenaConexion = Datos.Conexion.cadenaconexion;


      public int Ingresar_estado(string nombre_Estado)
      {
          Datos.Estado acceso = new Datos.Estado();
          return acceso.Insertar_Estado(nombre_Estado);
      }
      public static DataTable llenargrilla()
      {
          return Datos.Estado.Llenar_grilla();
          
      }
      public int modificar_estado(int id_estado,string nombre_estado)
      {
          Datos.Estado acceso = new Datos.Estado();
          return acceso.Modificar_Estado(id_estado,nombre_estado);
      }
      public int eliminar_estado(int id_estado)
      {
          Datos.Estado acceso = new Datos.Estado();
          return acceso.Eliminar_Estado(id_estado);
      }

    
      //public static DataTable v_nombre_usuario(string nombre_estado)
      //{
      //    return Datos.Estado.verificar_estado(nombre_estado);
      //}
         

     


    }
}
