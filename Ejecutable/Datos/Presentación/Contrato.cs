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
    public partial class Contrato : Form
    {
  
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_Estado = new Clase_Estado();
        Lógica.Clase_contrato obj_contrato = new Clase_contrato();
     
        public Contrato()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
     
        }
        
       public static DataTable contrato;

        void Limpiar()
        {
            numero_contratotxt.Text = "";
            nombre_contratotxt.Text = "";
            id_estado_contrato_cmb.Text = "";
            valor_txt.Text = "";
            duracion_contratotxt.Text = "";
                 
        }



        private void numero_contratotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void cestado_contratotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void nombre_contratotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }



     


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Contrato_Load(object sender, EventArgs e)
        {
            DataTable con = Datos.Estado.Llenar_grilla();
             contrato = Lógica.Clase_contrato.llenargrillacontrato();
           id_estado_contrato_cmb.DataSource = con;

           Contratoftgrdview.DataSource = contrato;
            
            id_estado_contrato_cmb.DisplayMember = "Nombre";
            id_estado_contrato_cmb.ValueMember = "Id";
            id_estado_contrato_cmb.SelectedIndex = -1;
            id_estado_contrato_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Contratoftgrdview.Columns.Add(btn_img);
            if (Program.acceso == 2)
            {
                this.Contratoftgrdview.Columns["   "].Visible = false;
            }
            
        }

      
       

       

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (nombre_contratotxt.Text == "" || id_estado_contrato_cmb.Text == "" || valor_txt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    //contrato
                    string nombre_contrato = nombre_contratotxt.Text;
                    string fecha_ini = fecha_iniciodtp.Text;
                    string duracion_contrato = duracion_contratotxt.Text;
                    string fecha_fin = fecha_fin_dtp.Text;
                    int id_estado_contrato = int.Parse(id_estado_contrato_cmb.SelectedValue.ToString());
                    long valor_contrato = long.Parse(valor_txt.Text);
                    //tipo contrato

                    int resultado = obj_contrato.IngresarContrato(nombre_contrato,fecha_ini, duracion_contrato,fecha_fin, id_estado_contrato, valor_contrato);

                    if (resultado > 0)
                    {
                         contrato = Lógica.Clase_contrato.llenargrillacontrato();
                        Contratoftgrdview.DataSource = contrato;   
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
            if (numero_contratotxt.Text == " " ||numero_contratotxt.Text == "..."|| nombre_contratotxt.Text == " " || duracion_contratotxt.Text == " " || id_estado_contrato_cmb.Text == " " || valor_txt.Text == " ")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    //contrato
                    int numero_contrato = int.Parse(numero_contratotxt.Text);
                    string nombre_contrato = nombre_contratotxt.Text;
                    string fecha_ini = fecha_iniciodtp.Text;
                    string fecha_fin = fecha_fin_dtp.Text;
                    int id_estado_contrato = int.Parse(id_estado_contrato_cmb.SelectedValue.ToString());
                    int valor_contrato = int.Parse(valor_txt.Text);
                    string duracion_contrato = duracion_contratotxt.Text;
                    int resultado = obj_contrato.ModificarContrato(numero_contrato, nombre_contrato, fecha_ini,duracion_contrato,fecha_fin, id_estado_contrato, valor_contrato);
                    if (resultado > 0)
                    {
                        DataTable con = Lógica.Clase_contrato.llenargrillacontrato();
                        Contratoftgrdview.DataSource = con;
                        obj_mensajes.Modificar();
                        Limpiar();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (panel_des.Height < 191)
            {
                desplegartmr.Start();
                panel_des.Visible = true;
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {

            if (panel_des.Height >= 191)
            {
                desplegartmr.Stop();
            }
            else if (panel_des.Height < 191)
            {
                panel_des.Visible = true;
                panel_des.Height += 15;
                Contratoftgrdview.Location = new Point(12, 311);
            }
        }

   

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = contrato;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Numero Contrato";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";

            }
        }

        private void Contratoftgrdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            numero_contratotxt.Text = Contratoftgrdview.CurrentRow.Cells["Numero Contrato"].Value.ToString();
            nombre_contratotxt.Text = Contratoftgrdview.CurrentRow.Cells["Nombre"].Value.ToString();
            fecha_iniciodtp.Text = Contratoftgrdview.CurrentRow.Cells["Inicio"].Value.ToString();
            duracion_contratotxt.Text = Contratoftgrdview.CurrentRow.Cells["Duración"].Value.ToString();
            fecha_fin_dtp.Text = Contratoftgrdview.CurrentRow.Cells["Fin"].Value.ToString();
            id_estado_contrato_cmb.Text = Contratoftgrdview.CurrentRow.Cells["Estado"].Value.ToString();
            valor_txt.Text = Contratoftgrdview.CurrentRow.Cells["Valor"].Value.ToString();
        }

        private void Contratoftgrdview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Contratoftgrdview.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Contratoftgrdview.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Contratoftgrdview.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Contratoftgrdview.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void Contratoftgrdview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Contratoftgrdview.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {
                    int Numero_contrato = int.Parse(Contratoftgrdview.CurrentRow.Cells["Numero Contrato"].Value.ToString());
                    int resultado = obj_contrato.EliminarContrato(Numero_contrato);
                    if (resultado > 0)
                    {
                        DataTable contrato = Lógica.Clase_contrato.llenargrillacontrato();
                        Contratoftgrdview.DataSource = contrato;
                        obj_mensajes.Eliminar();
                       
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void duracion_contratotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void valor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void id_estado_contrato_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estado est = new Estado();
            est.Show();
        }

      
  
    }
}
