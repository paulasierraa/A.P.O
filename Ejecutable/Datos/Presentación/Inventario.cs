using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;
using System.Data.SqlClient;
namespace Presentación
{
    public partial class Inventario : Form
    {
        Lógica.Validacion obj_validacion = new Validacion();
  
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_inventario obj_inventario = new Clase_inventario();
        public Inventario()
        {
            InitializeComponent();
        }
     
     

        private void estadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

        private void codigo_productotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

        private void valor_unitariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

        private void numero_Facturatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

        private void cantidad_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

      


        private void nuevobtn_Click(object sender, EventArgs e)
        {
            desplegartmr.Start();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            DataTable llenar = Lógica.Clase_inventario.llenar_inventario();
            inventariodtgrdvw.DataSource = llenar;
        }

        private void estadocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_letras(e);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            
            if (buscar_numerotxt.Checked == true)
            {
                no_buscartxt.Visible = true;
                fecha_consultadtp.Visible = false;

            }
            else if (buscar_fechatxt.Checked == true)
            {
                fecha_consultadtp.Visible = true;
                no_buscartxt.Visible = false;
            }
        }

        private void buscartxt_Click(object sender, EventArgs e)
        {
            if (buscar_fechatxt.Checked == true)
            {
                string fecha = fecha_consultadtp.Text;
                DataTable con1 = Lógica.Clase_inventario.Consultarinventario(fecha);
                inventariodtgrdvw.DataSource = con1;
            }
            else if (buscar_numerotxt.Checked == true)
            {
                int numero = int.Parse(no_buscartxt.Text);
                DataTable con2 = Lógica.Clase_inventario.especifica_inventario(numero);
                inventariodtgrdvw.DataSource = con2;
            }
        }

        private void reloadpctb_Click(object sender, EventArgs e)
        {
               DataTable llenar = Lógica.Clase_inventario.llenar_inventario();
               inventariodtgrdvw.DataSource = llenar;
        }

        private void no_buscartxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj_validacion.Vali_num(e);
        }

  
    }
}
