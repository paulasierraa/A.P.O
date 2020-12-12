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
    public partial class Cliente_Especifico : Form
    {
        public Cliente_Especifico()
        {
            InitializeComponent();
        }

        private void cerrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
