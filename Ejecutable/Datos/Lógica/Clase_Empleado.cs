using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
namespace Lógica
{
 public  class Clase_Empleado
    {
         public int IngresarEmpleado(int identificacion_empleado, string nombre_empleado, long telefono_empleado, string direccion_empleado, long salario_empleado, string fecha_nacimiento_empleado, string correo_empleado, string fecha_ingreso_empleado, int id_estado_empleado, int numero_contrato, int codigo_cargo_empleado)
         {
             Datos.Empleado acceso = new Empleado();
             return acceso.Insertar_Empleado(identificacion_empleado, nombre_empleado, telefono_empleado, direccion_empleado, salario_empleado, fecha_nacimiento_empleado, correo_empleado, fecha_ingreso_empleado, id_estado_empleado, numero_contrato, codigo_cargo_empleado);
         }
         public int ModificarEmpleado(int identificacion_empleado, string nombre_empleado, long telefono_empleado, string direccion_empleado, long salario_empleado, string fecha_nacimiento_empleado, string correo_empleado, string fecha_ingreso_empleado, int id_estado_empleado, int numero_contrato, int codigo_cargo_empleado)
         {
             Datos.Empleado acceso = new Empleado();
             return acceso.Modificar_Empleado(identificacion_empleado, nombre_empleado, telefono_empleado, direccion_empleado, salario_empleado, fecha_nacimiento_empleado, correo_empleado, fecha_ingreso_empleado, id_estado_empleado, numero_contrato, codigo_cargo_empleado);
         }
         public int EliminarEmpleado(int identificacion_empleado)
         {
             Datos.Empleado acceso = new Empleado();
             return acceso.Eliminar_Empleado(identificacion_empleado);
         }
         public static DataTable llenargrilla_empleados()
         {
             return Datos.Empleado.llenar_grilla_empleado();
         }
  
 
    }
}
