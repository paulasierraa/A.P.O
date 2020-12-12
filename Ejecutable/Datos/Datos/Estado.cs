using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class Estado
    {
        
        public int Insertar_Estado(string nombre_Estado )
        {
            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_ESTADO");
            comando.Parameters.AddWithValue("@NOMBRE_ESTADO", nombre_Estado);
            return Metodos.EjecutarComando(comando);
        }

        public int Modificar_Estado(int id_estado,string nombre_Estado)
        {
            SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_ESTADO");
            comando.Parameters.AddWithValue("@ID_ESTADO", id_estado);
            comando.Parameters.AddWithValue("@NOMBRE_ESTADO", nombre_Estado);
            return Metodos.EjecutarComando(comando);
        }
        public int Eliminar_Estado(int id_estado)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_ESTADO");
            comando.Parameters.AddWithValue("@ID_ESTADO", id_estado);
            return Metodos.EjecutarComando(comando);
        }

        public static DataTable Llenar_grilla()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_ESTADOS";
            return Metodos.EjecutarComandoSelect(comando);
        }
      
              //public static DataTable verificar_estado(string nombre_estado)
              //{
              //    SqlCommand comando = Metodos.CrearComandoProc("V_NOMBRE_ESTADO");
              //    comando.Parameters.AddWithValue("@NOMBRE_ESTADO",nombre_estado);
              //    return Metodos.EjecutarComandoSelect(comando);
              //}

    }
}
