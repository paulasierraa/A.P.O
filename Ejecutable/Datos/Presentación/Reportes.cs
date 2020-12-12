using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {

            if (panel2.Height >= 192)
            {
                desplegartmr.Stop();
            }
            else if (panel2.Height < 192)
            {
                panel2.Visible = true;
                panel2.Height += 15;

            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            desplegartmr.Start();
        }

        private void generar_btn_Click(object sender, EventArgs e)
        {
            if (cmb_consulta.Text == "Empleados" && general_rdbtn.Checked == true)
            {
                Empleado_general gen = new Empleado_general();
                gen.Show();
            }
            if (cmb_consulta.Text == "Empleados" && especifica_rdbtn.Checked == true)
            {
                Empleado_Especifico es = new Empleado_Especifico();
                es.Show();
               
            }
            if (cmb_consulta.Text == "Clientes" && general_rdbtn.Checked == true)
            {
                Cliente_general cl_general = new Cliente_general();
                cl_general.Show();
            }
            if (cmb_consulta.Text == "Clientes" && especifica_rdbtn.Checked == true)
            {
                Cliente_Especifico cl_especifico = new Cliente_Especifico();
                cl_especifico.Show();
            }
            if (cmb_consulta.Text == "Productos" && general_rdbtn.Checked == true)
            {
                Productos_Reporte prod_g = new Productos_Reporte();
                prod_g.Show();
            }
            
        }
    }
}
