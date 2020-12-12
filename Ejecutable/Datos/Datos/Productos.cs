using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Productos
    {
        public int insertar_productos(int codigo_producto, string nombre_producto, long cantidad_productos, long cantidad_minima_productos, long cantidad_maxima_productos, long valor_compra_productos, long valor_venta_productos, int id_estado_producto, int id_Garantia_producto, int codigo_presentacion_producto, string unidad_medida_producto)
        {
            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_PRODUCTOS");
            comando.Parameters.AddWithValue("@CODIGO_PRODUCTO", codigo_producto);
            comando.Parameters.AddWithValue("@NOMBRE_PRODUCTO", nombre_producto);
            comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOS", cantidad_productos);
            comando.Parameters.AddWithValue("@CANTIDAD_MINIMA_PRODUCTOS", cantidad_minima_productos);
            comando.Parameters.AddWithValue("@CANTIDAD_MAXIMA_PRODUCTOS ", cantidad_maxima_productos);
            comando.Parameters.AddWithValue("@VALOR_COMPRA_PRODUCTOS", valor_compra_productos);
            comando.Parameters.AddWithValue("@VALOR_VENTA_PRODUCTOS", valor_venta_productos);
            comando.Parameters.AddWithValue("@ID_ESTADO_PRODUCTO", id_estado_producto);
            comando.Parameters.AddWithValue("@ID_GARANTIA_PRODUCTO", id_Garantia_producto);
            comando.Parameters.AddWithValue("@CODIGO_PRESENTACION_PRODUCTO", codigo_presentacion_producto);
            comando.Parameters.AddWithValue("@UNIDAD_MEDIDA_PRODUCTO", unidad_medida_producto);
            return Metodos.EjecutarComando(comando);
        }
        public int modificar_productos(int codigo_producto, string nombre_producto, long cantidad_productos, long cantidad_minima_productos, long cantidad_maxima_productos, long valor_compra_productos, long valor_venta_productos, int id_estado_producto, int id_Garantia_producto, int codigo_presentacion_producto, string unidad_medida_producto)
        {
            SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_PRODUCTO");
            comando.Parameters.AddWithValue("@CODIGO_PRODUCTO", codigo_producto);
            comando.Parameters.AddWithValue("@NOMBRE_PRODUCTO", nombre_producto);
            comando.Parameters.AddWithValue("@CANTIDAD_PRODUCTOS", cantidad_productos);
            comando.Parameters.AddWithValue("@CANTIDAD_MINIMA_PRODUCTOS", cantidad_minima_productos);
            comando.Parameters.AddWithValue("@CANTIDAD_MAXIMA_PRODUCTOS ", cantidad_maxima_productos);
            comando.Parameters.AddWithValue("@VALOR_COMPRA_PRODUCTOS", valor_compra_productos);
            comando.Parameters.AddWithValue("@VALOR_VENTA_PRODUCTOS", valor_venta_productos);
            comando.Parameters.AddWithValue("@ID_ESTADO_PRODUCTO", id_estado_producto);
            comando.Parameters.AddWithValue("@ID_GARANTIA_PRODUCTO", id_Garantia_producto);
            comando.Parameters.AddWithValue("@CODIGO_PRESENTACION_PRODUCTO", codigo_presentacion_producto);
            comando.Parameters.AddWithValue("@UNIDAD_MEDIDA_PRODUCTO", unidad_medida_producto);
            return Metodos.EjecutarComando(comando);


        }
        public int eliminar_productos(int codigo_producto)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_PRODUCTOS");
            comando.Parameters.AddWithValue("@CODIGO_PRODUCTO", codigo_producto);
            return Metodos.EjecutarComando(comando);
        }
        public static DataTable llenar_grilla_productos()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_PRODUCTOS";
            return Metodos.EjecutarComandoSelect(comando);
        }

    }
}

