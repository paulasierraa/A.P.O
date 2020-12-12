using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;

namespace Lógica
{
    
  public class Clase_mensajes
   {
       public void Campos_vacios ()
  {
      MessageBox.Show("Campos vacios");
  }
      public void Agregar()
  {
      MessageBox.Show("Se han registrado los datos con exito");
  }
      public void Eliminar()
      {
          MessageBox.Show("Se han eliminado los datos con exito");
      }
      public void Modificar()
  {
      MessageBox.Show("Se han modificado los datos con exito");
  }
      public void Inicio_seison()
      {
          MessageBox.Show("Bienvenido al sistema");
      }
   public void Cerrar_sesion()
  {
      MessageBox.Show("Sesión cerrada con exito");
  }

   }
}
    

