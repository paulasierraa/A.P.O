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
    public partial class Bienvenidos : Form
    {
        List<Color> colors = new List<Color>();

   
        public Bienvenidos()
        {

          
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer_bienvenidos_Tick(object sender, EventArgs e)
        {
       
            //MOSTRAR PANTALLAZO INICIO SESION CUANDO FINALIZE EL TIMER
           
                timer_bienvenidos.Enabled = false;
                Iniciar_Sesión inicio = new Iniciar_Sesión();
                inicio.Show();
                this.Hide();
            
            
            
            }

        private void Bienvenidos_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
        }
    }

