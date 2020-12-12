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
    public class Clase_cargo
    {
        public int IngresarCargo(string nombre_cargo, int id_estado_cargo)
        {
            Datos.Cargo acceso = new Cargo();
            return acceso.Insertar_Cargo(nombre_cargo, id_estado_cargo);
        }
        public int ModificarCargo(int codigo_cargo,string nombre_cargo, int id_estado_cargo)
        {
            Datos.Cargo acceso = new Cargo();
            return acceso.Modificar_Cargo(codigo_cargo,nombre_cargo, id_estado_cargo);
        }
        public int EliminarCargo(int codigo_cargo)
        {
            Datos.Cargo acceso = new Cargo();
            return acceso.Eliminar_Cargo(codigo_cargo);
        }
        public static DataTable llenargrillacargo()
        {
            return Datos.Cargo.llenar_grilla_cargo();
        }
  
    }
}
 