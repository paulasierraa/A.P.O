using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class Garantia
    {
      public int Insertar_garantia(string tiempo_total,string fecha_inicio_Garantia,string fecha_fin_garantia,int id_estado_garantia)
       {
           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_GARANTIA");
           comando.Parameters.AddWithValue("@TIEMPO_TOTAL",tiempo_total);
           comando.Parameters.AddWithValue("@FECHA_INICIO_GARANTIA",fecha_inicio_Garantia);
           comando.Parameters.AddWithValue("@FECHA_FIN_GARANTIA" ,fecha_fin_garantia);
           comando.Parameters.AddWithValue("ID_ESTADO_GARANTIA",id_estado_garantia);
           return Metodos.EjecutarComando(comando);
        }
      public int modificar_garantia(int id_Garantia,string tiempo_total, string fecha_inicio_Garantia, string fecha_fin_garantia, int id_estado_garantia)
      {
          SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_GARANTIA");
          comando.Parameters.AddWithValue("@ID_GARANTIA", id_Garantia);
          comando.Parameters.AddWithValue("@TIEMPO_TOTAL", tiempo_total);
          comando.Parameters.AddWithValue("@FECHA_INICIO_GARANTIA", fecha_inicio_Garantia);
          comando.Parameters.AddWithValue("@FECHA_FIN_GARANTIA", fecha_fin_garantia);
          comando.Parameters.AddWithValue("ID_ESTADO_GARANTIA", id_estado_garantia);
          return Metodos.EjecutarComando(comando);
      }
      public int eliminar_garantia(int id_garantia)
      {
          SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_GARANTIA");
          comando.Parameters.AddWithValue("@ID_GARANTIA", id_garantia);
              return Metodos.EjecutarComando(comando);
      }
      public static DataTable llenar_grilla_garantias()
      {
          SqlCommand comando = Metodos.CrearComando();
          comando.CommandText = "CONSULTAR_GARANTIAS";
          return Metodos.EjecutarComandoSelect(comando);
      }
  
        
    }
    
}
