using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Empleado
    {
        public int Insertar_Empleado(int identificacion_empleado, string nombre_empleado, long telefono_empleado, string direccion_empleado, long salario_empleado, string fecha_nacimiento_empleado, string correo_empleado, string fecha_ingreso_empleado, int id_estado_empleado, int numero_contrato, int codigo_cargo_empleado)
        {

            SqlCommand comando = Metodos.CrearComandoProc("AGREGAR_EMPLEADO");
            comando.Parameters.AddWithValue("@IDENTIFICACION_EMPLEADO", identificacion_empleado);
            comando.Parameters.AddWithValue("@NOMBRE_EMPLEADO", nombre_empleado);
            comando.Parameters.AddWithValue("@TELEFONO_EMPLEADO ", telefono_empleado);
            comando.Parameters.AddWithValue("@DIRECCION_EMPLEADO", direccion_empleado);
            comando.Parameters.AddWithValue("@SALARIO_EMPLEADO ", salario_empleado);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_EMPLEADO", fecha_nacimiento_empleado);
            comando.Parameters.AddWithValue("@CORREO_EMPLEADO", correo_empleado);
            comando.Parameters.AddWithValue("@FECHA_INGRESO_EMPLEADO", fecha_ingreso_empleado);
            comando.Parameters.AddWithValue("@ID_ESTADO_E", id_estado_empleado);
            comando.Parameters.AddWithValue("@NUMERO_CONTRATO_E", numero_contrato);
            comando.Parameters.AddWithValue("@CODIGO_CARGO_E", codigo_cargo_empleado);
            return Metodos.EjecutarComando(comando);

        }
        public int Modificar_Empleado(int identificacion_empleado, string nombre_empleado, long telefono_empleado, string direccion_empleado, long salario_empleado, string fecha_nacimiento_empleado, string correo_empleado, string fecha_ingreso_empleado, int id_estado_empleado, int numero_contrato, int codigo_cargo_empleado)
        {

            SqlCommand comando = Metodos.CrearComandoProc("MODIFICAR_EMPLEADO");
            comando.Parameters.AddWithValue("@IDENTIFICACION_EMPLEADO", identificacion_empleado);
            comando.Parameters.AddWithValue("@NOMBRE_EMPLEADO", nombre_empleado);
            comando.Parameters.AddWithValue("@TELEFONO_EMPLEADO ", telefono_empleado);
            comando.Parameters.AddWithValue("@DIRECCION_EMPLEADO", direccion_empleado);
            comando.Parameters.AddWithValue("@SALARIO_EMPLEADO ", salario_empleado);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO_EMPLEADO", fecha_nacimiento_empleado);
            comando.Parameters.AddWithValue("@CORREO_EMPLEADO", correo_empleado);
            comando.Parameters.AddWithValue("@FECHA_INGRESO_EMPLEADO", fecha_ingreso_empleado);
            comando.Parameters.AddWithValue("@ID_ESTADO_E", id_estado_empleado);
            comando.Parameters.AddWithValue("@NUMERO_CONTRATO_E", numero_contrato);
            comando.Parameters.AddWithValue("@CODIGO_cARGO_E", codigo_cargo_empleado);
            return Metodos.EjecutarComando(comando);

        }
        public int Eliminar_Empleado(int identificacion_empleado)
        {
            SqlCommand comando = Metodos.CrearComandoProc("ELIMINAR_EMPLEADO");
            comando.Parameters.AddWithValue("@IDENTIFICACION_EMPLEADO", identificacion_empleado);
            return Metodos.EjecutarComando(comando);
        }
        public static DataTable llenar_grilla_empleado()
        {
            SqlCommand comando = Metodos.CrearComando();
            comando.CommandText = "CONSULTAR_EMPLEADOS";
            return Metodos.EjecutarComandoSelect(comando);
        }

      
        
             
    }
}
