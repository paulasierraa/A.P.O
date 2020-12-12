using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Tipo_presentacion
    {
        public int Insertar_tipo_presentacion(string nombre_tpresentacion, int id_estado_tpresentacion)
        {
            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_TIPO_PRESENTACION");
            comando.Parameters.AddWithValue("@NOMBRE_TPRESENTACION", nombre_tpresentacion);
            comando.Parameters.AddWithValue("@ID_ESTADO_TPRESENTACION", id_estado_tpresentacion);
            return Metodos.EjecutarComando(comando);
        }
        public int modificar_tipo_presentacion(int codigo_tpresentacion,string nombre_tpresentacion, int id_estado_tpresentacion)
        {
             SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_TIPO_PRESENTACION");
             comando.Parameters.AddWithValue("@CODIGO_TPRESENTACION", codigo_tpresentacion);
            comando.Parameters.AddWithValue("@NOMBRE_TPRESENTACION", nombre_tpresentacion);
            comando.Parameters.AddWithValue("@ID_ESTADO_TPRESENTACION", id_estado_tpresentacion);
            return Metodos.EjecutarComando(comando);
        }
        public int eliminar_tipo_presentacion (int codigo_tpresentacion)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_TIPO_PRESENTACION");
                comando.Parameters.AddWithValue("@CODIGO_TPRESENTACION ",codigo_tpresentacion);
            return Metodos.EjecutarComando(comando);
        }
        public static DataTable llenar_grilla_presentacion()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_PRESENTACIONES";
            return Metodos.EjecutarComandoSelect(comando);
        }
    
    }
}
