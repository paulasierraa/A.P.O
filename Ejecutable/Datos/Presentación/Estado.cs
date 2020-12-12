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
    public partial class Estado : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        public static DataTable est;
        public Estado()
        {
            InitializeComponent();
           if (Program.acceso == 2)
           {
               nuevobtn.Visible = false;
        
           }
           est = Clase_Estado.llenargrilla();
           Estado_dtgrdvw.DataSource = est;
        }

        void Limpiar()
        {
            id_Estadolbl.Text = "";
            Nombre_Estadotxt.Text = "";
        }
        private void Atraspctbx_Click(object sender, EventArgs e)
        {

        }

        private void Id_estadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_Estadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }





        private void pictureBox3_Click(object sender, EventArgs e)
        {

            try
            {
                int id_estado = int.Parse(id_Estadolbl.Text);
                string nombre_Estado = Nombre_Estadotxt.Text;

                int resultado = obj_estado.modificar_estado(id_estado, nombre_Estado);
                if (resultado > 0)
                {
                    DataTable est = Clase_Estado.llenargrilla();
                    Estado_dtgrdvw.DataSource = est;

                    obj_mensajes.Modificar();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {


        }



        private void Estado_Load(object sender, EventArgs e)
        {
          
            consultar_pnl.Visible = false;
            slidepnl.Visible = false;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Estado_dtgrdvw.Columns.Add(btn_img);
            if (Program.acceso == 2)
            {
                this.Estado_dtgrdvw.Columns["   "].Visible = false;
            }
          
        }




        private void Estado_dtgrdvw_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Nombre_Estadotxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                  
                    string nombre_Estado = Nombre_Estadotxt.Text;
                    //DataTable v_nombre = Lógica.Clase_Estado.v_nombre_usuario(nombre_Estado);
                    int resultado = obj_estado.Ingresar_estado(nombre_Estado);
                   
                    if (resultado > 0)
                    {
                        DataTable est = Clase_Estado.llenargrilla();
                        Estado_dtgrdvw.DataSource = est;
                        obj_mensajes.Agregar();
                        Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (id_Estadolbl.Text == "..." || Nombre_Estadotxt.Text == " " ||id_Estadolbl.Text == "" )
                {
                    obj_mensajes.Campos_vacios();
                }
                else
                {
                    int id_estado = int.Parse(id_Estadolbl.Text);
                    string nombre_Estado = Nombre_Estadotxt.Text;
                    int resultado = obj_estado.modificar_estado(id_estado, nombre_Estado);

                    if (resultado > 0)
                    {
                        DataTable est = Clase_Estado.llenargrilla();
                        Estado_dtgrdvw.DataSource = est;

                        obj_mensajes.Modificar();

                        Limpiar();

                    }
                }
              
              

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (slidepnl.Height >= 148)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 148)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Estado_dtgrdvw.Location = new Point(128, 276);
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (slidepnl.Height < 148)
            {
                desplegartmr.Start();
                slidepnl.Visible = true;
            }
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = est;
            if (idrdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Id";

            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";
            }
        }

        private void Estado_dtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Estado_dtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Estado_dtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Estado_dtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Estado_dtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void Estado_dtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Estado_dtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {
                int id_estado = int.Parse(Estado_dtgrdvw.CurrentRow.Cells["Id"].Value.ToString());
                int resultado = obj_estado.eliminar_estado(id_estado);
                if (resultado > 0)
                {
                    DataTable est = Clase_Estado.llenargrilla();
                    Estado_dtgrdvw.DataSource = est;
                    Limpiar();
                    obj_mensajes.Eliminar();
                }
            }
        }

        private void Estado_dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Estadolbl.Text = Estado_dtgrdvw.CurrentRow.Cells["Id"].Value.ToString();
            Nombre_Estadotxt.Text = Estado_dtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}