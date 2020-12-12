using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Lógica
{
   public class Clase_productos
    {
       public int ingresar_productos(int codigo_producto, string nombre_producto, long cantidad_productos, long cantidad_minima_productos, long cantidad_maxima_productos, long valor_compra_productos, long valor_Venta_productos, int id_estado_producto, int id_garantia_producto, int codigo_presentacion_producto, string unidad_medida_producto)
       {
           Datos.Productos acceso = new Datos.Productos();
           return acceso.insertar_productos(codigo_producto, nombre_producto, cantidad_productos, cantidad_minima_productos, cantidad_maxima_productos, valor_compra_productos, valor_Venta_productos, id_estado_producto, id_garantia_producto, codigo_presentacion_producto, unidad_medida_producto);
       }
       public int Modificar_productos(int codigo_producto, string nombre_producto, long cantidad_productos, long cantidad_minima_productos, long cantidad_maxima_productos, long valor_compra_productos, long valor_Venta_productos, int id_estado_producto, int id_garantia_producto, int codigo_presentacion_producto, string unidad_medida_producto)
       {
           Datos.Productos acceso = new Datos.Productos();
           return acceso.modificar_productos(codigo_producto, nombre_producto,  cantidad_productos, cantidad_minima_productos, cantidad_maxima_productos, valor_compra_productos, valor_Venta_productos, id_estado_producto, id_garantia_producto, codigo_presentacion_producto, unidad_medida_producto);
       }
       public int Eliminar_productos(int codigo_producto)
       {
           Datos.Productos acceso = new Datos.Productos();
           return acceso.eliminar_productos(codigo_producto);
       }
       public static DataTable llenargrillaproductos()
       {
           return Datos.Productos.llenar_grilla_productos();
       }
   
    }
}
