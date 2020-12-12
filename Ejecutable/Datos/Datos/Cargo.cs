using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Cargo
    {
       public int Insertar_Cargo(string nombre_cargo, int id_estado_cargo)
       {

           SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_CARGO");
           comando.Parameters.AddWithValue("@NOMBRE_CARGO", nombre_cargo);
           comando.Parameters.AddWithValue("@ID_ESTADO_CARGO_FK ", id_estado_cargo);
           return Metodos.EjecutarComando(comando);

       }

       public int Modificar_Cargo(int codigo_cargo,string nombre_cargo, int id_estado_cargo)
       {
           SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_CARGO");
           comando.Parameters.AddWithValue("@CODIGO_CARGO", codigo_cargo);
           comando.Parameters.AddWithValue("@NOMBRE_CARGO", nombre_cargo);
           comando.Parameters.AddWithValue("@ID_ESTADO_CARGO_FK ", id_estado_cargo);
           return Metodos.EjecutarComando(comando);

       }
        public int Eliminar_Cargo(int codigo_cargo)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_CARGO");
            comando.Parameters.AddWithValue("@CODIGO_CARGO", codigo_cargo);
            return Metodos.EjecutarComando(comando);
        }
        public static DataTable llenar_grilla_cargo()
        {
            SqlCommand comando = Metodos.CrearComando() ;
            comando.CommandText = "CONSULTAR_CARGOS";
            return Metodos.EjecutarComandoSelect(comando);
        }
     
    }
}
   
