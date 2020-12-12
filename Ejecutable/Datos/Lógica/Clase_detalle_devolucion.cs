using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_detalle_devolucion
    {
       public int ingresar_Detalle_devolucion(int codigo_productodtd, long valor_productodtd, int cantidad_productodtd, int codigo_devolucion_fk)
       {
           Datos.Detalle_devolucion acceso = new Datos.Detalle_devolucion();
           return acceso.insertar_detalle_devolucion(codigo_productodtd, valor_productodtd, cantidad_productodtd, codigo_devolucion_fk);
       }
       public int ModificarDetalleDevolucion(int id_Dt,int codigo_productodtd, long valor_productodtd, int cantidad_productodtd)
       {
           Datos.Detalle_devolucion acceso = new Datos.Detalle_devolucion();
           return acceso.Modificar_Detalle_Devolucion( id_Dt,codigo_productodtd, valor_productodtd, cantidad_productodtd);
       }
       public int EliminarDetalleDevolucion(int id_detalle_devolucion)
       {
           Datos.Detalle_devolucion acceso = new Datos.Detalle_devolucion();
           return acceso.Eliminar_Detalle_Devolucion(id_detalle_devolucion);
       }
       public static DataTable identitydevolucion()
       {
           return Datos.Detalle_devolucion.identity_Detalle_devolucion();
       }
       public static DataTable consultadetalle(int codigo_devolucion)
       {
           return Datos.Detalle_devolucion.consulta_Detalle_devolucion(codigo_devolucion) ;
       }
    }
}
