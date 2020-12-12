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
    public partial class Mensaje_bienvenidos : Form
    {
        public Mensaje_bienvenidos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Menu_principal menu = new Menu_principal();
            menu.Show();
            this.Hide();
        }
    }
}
