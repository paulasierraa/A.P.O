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
    public partial class Empleado_Especifico : Form
    {
        public Empleado_Especifico()
        {
            InitializeComponent();
        }

        private void cerrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
