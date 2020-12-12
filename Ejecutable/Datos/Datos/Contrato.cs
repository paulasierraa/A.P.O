using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public  class Contrato
    {
        public int Insertar_Contrato(string nombre_contrato,string fecha_inicio_contrato, string duracion_contrato,string fecha_fin_contrato, int id_estado_contrato, long valor_contrato)
        {
            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_CONTRATO");
            comando.Parameters.AddWithValue("@NOMBRE_CONTRATO", nombre_contrato);
            comando.Parameters.AddWithValue("@FECHA_INICIO_CONTRATO",fecha_inicio_contrato);
            comando.Parameters.AddWithValue("@DURACION_CONTRATO", duracion_contrato);
            comando.Parameters.AddWithValue("@FECHA_FIN_CONTRATO",fecha_fin_contrato);
            comando.Parameters.AddWithValue("@ID_ESTADO_C", id_estado_contrato);
            comando.Parameters.AddWithValue("@VALOR_CONTRATO ", valor_contrato);
            return Metodos.EjecutarComando(comando);

        }
        public int Modificar_Contrato(int numero_contrato, string nombre_contrato, string fecha_inicio_contrato, string duracion_contrato, string fecha_fin_contrato, int id_estado_contrato, long valor_contrato)
        {
            SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_CONTRATO");
            comando.Parameters.AddWithValue("@NUMERO_CONTRATO", numero_contrato);
             comando.Parameters.AddWithValue("@NOMBRE_CONTRATO", nombre_contrato);
             comando.Parameters.AddWithValue("@FECHA_INICIO_CONTRATO", fecha_inicio_contrato);
             comando.Parameters.AddWithValue("@DURACION_CONTRATO", duracion_contrato);
             comando.Parameters.AddWithValue("@FECHA_FIN_CONTRATO", fecha_fin_contrato);
            comando.Parameters.AddWithValue("@ID_ESTADO_C", id_estado_contrato);
            comando.Parameters.AddWithValue("@VALOR_CONTRATO ", valor_contrato);
            return Metodos.EjecutarComando(comando);

        }
        public int Eliminar_Contrato(int numero_contrato)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_CONTRATO");
            comando.Parameters.AddWithValue("@NUMERO_CONTRATO", numero_contrato);

            return Metodos.EjecutarComando(comando);
        }
        public static DataTable llenar_grilla_contrato()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_CONTRATOS";
            return Metodos.EjecutarComandoSelect(comando);
            }

    }
}
