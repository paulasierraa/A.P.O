using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
 public   class Forma_pago
    {
     public int insertar_forma_pago(string nombre_forma_pago, int id_estado_fp)
     {
         SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_FORMA_PAGO");
         comando.Parameters.AddWithValue("@NOMBRE_FORMA_PAGO", nombre_forma_pago);
         comando.Parameters.AddWithValue("@ID_ESTADO_FP", id_estado_fp);
         return Metodos.EjecutarComando(comando);
     }

     public int modificar_forma_pago(int id_forma_pago,string nombre_forma_pago, int id_estado_fp)
     {
         SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_FORMA_PAGO");
         comando.Parameters.AddWithValue("@ID_FORMA_PAGO",id_forma_pago);
         comando.Parameters.AddWithValue("@NOMBRE_FORMA_PAGO", nombre_forma_pago);
         comando.Parameters.AddWithValue("@ID_ESTADO_FP", id_estado_fp);
         return Metodos.EjecutarComando(comando);
     }
     public int Eliminar_forma_pago(int id_forma_pago)
     {
         SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_FORMA_PAGO");
         comando.Parameters.AddWithValue("@ID_FORMA_PAGO",id_forma_pago);
         return Metodos.EjecutarComando(comando);
     }
     public static DataTable llenar_grilla_fp()
     {
         SqlCommand comando = Metodos.CrearComando();
         comando.CommandText = "CONSULTAR_FORMAS_PAGO";
         return Metodos.EjecutarComandoSelect(comando);
     }
     public static DataTable Consulta_especifica_formap(int id_forma_pago)
     {
         SqlCommand comando = Metodos.CrearComandoProc("CONSULTAR_FORMA_PAGO");
         return Metodos.EjecutarComandoSelect(comando);
     }
     public static DataTable Filtrar_forma_pago(string nombre_fp)
     {
         SqlCommand comando = Metodos.CrearComandoProc("FILTRAR_FORMA_PAGO");
         return Metodos.EjecutarComandoSelect(comando);
     }
  
    }
}
