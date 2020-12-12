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
using System.Globalization;
namespace Presentación
{
    public partial class Garantías : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_garantia obj_garnatia = new Clase_garantia();
        public Garantías()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
            
        }
      
        DataTable garantia;
        void limpiar()
        {
            // limpiar texbox
            fecha_inicio_dtpck.Text = "";
            id_estado_garantias_cmb.Text = "";
            tiempo_totaltxt.Text = "";
            fecha_inicio_dtpck.Text = "";
            fecha_fin_dtpick.Text = "";
            id_Glbl.Text = "";
          
        }
   


        private void id_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void fecha_garantiastxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void estado_garantiatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }
        private void Garantías_Load(object sender, EventArgs e)
        {
            DataTable gar = Datos.Estado.Llenar_grilla();
             garantia = Lógica.Clase_garantia.llenargrillagarantia();
            id_estado_garantias_cmb.DataSource = gar;

            Garantiasdtgrdview.DataSource = garantia ;
            id_estado_garantias_cmb.DisplayMember = "Nombre";
            id_estado_garantias_cmb.ValueMember = "Id";
            id_estado_garantias_cmb.SelectedIndex = -1;
            id_estado_garantias_cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Garantiasdtgrdview.Columns.Add(btn_img);
            if (Program.acceso == 2)
            {
                this.Garantiasdtgrdview.Columns["   "].Visible = false;
            }
        }

     

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (id_Glbl.Text == "" || id_Glbl.Text == "..." || fecha_inicio_dtpck.Text == "" || id_estado_garantias_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    int id_Garantia = int.Parse(id_Glbl.Text);
                    string tiempo_total = tiempo_totaltxt.Text;
                    string fecha_inicio_Garantia = fecha_inicio_dtpck.Text;
                    string fecha_fin_garantia = fecha_fin_dtpick.Text;
                    int id_estado_garantia = int.Parse(id_estado_garantias_cmb.SelectedValue.ToString());
                    int resultado = obj_garnatia.Modificar_garantia(id_Garantia, tiempo_total, fecha_inicio_Garantia, fecha_fin_garantia, id_estado_garantia);
                    if (resultado > 0)
                    {
                        DataTable garantia = Lógica.Clase_garantia.llenargrillagarantia();
                        Garantiasdtgrdview.DataSource = garantia;
                        obj_mensajes.Modificar();
                        limpiar();


                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (fecha_inicio_dtpck.Text == "" || id_estado_garantias_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    string tiempo_total = tiempo_totaltxt.Text;
                    string fecha_inicio_Garantia = fecha_inicio_dtpck.Text;
                    string fecha_fin_garantia = fecha_fin_dtpick.Text;
                    int id_estado_garantia = int.Parse(id_estado_garantias_cmb.SelectedValue.ToString());
                    int resultado = obj_garnatia.ingresar_garantia(tiempo_total, fecha_inicio_Garantia, fecha_fin_garantia, id_estado_garantia);
                    if (resultado > 0)
                    {
                        obj_mensajes.Agregar();
                        DataTable garantia = Lógica.Clase_garantia.llenargrillagarantia();
                        Garantiasdtgrdview.DataSource = garantia;
                        limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Garantiasdtgrdview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.Garantiasdtgrdview.Columns[e.ColumnIndex].Name == "   ")
            {

                try
                {
                    int id_garantia = int.Parse(Garantiasdtgrdview.CurrentRow.Cells["Id"].Value.ToString());
                    int resultado = obj_garnatia.Eliminar_garantia(id_garantia);
                    if (resultado > 0)
                    {


                        obj_mensajes.Eliminar();
                        DataTable garantia = Lógica.Clase_garantia.llenargrillagarantia();
                        Garantiasdtgrdview.DataSource = garantia;
                        limpiar();


                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }
        private void Garantiasdtgrdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            id_Glbl.Text = Garantiasdtgrdview.CurrentRow.Cells["Id"].Value.ToString();
            tiempo_totaltxt.Text = Garantiasdtgrdview.CurrentRow.Cells["Tiempo Total"].Value.ToString();
            fecha_inicio_dtpck.Text = Garantiasdtgrdview.CurrentRow.Cells["Fecha Inicio"].Value.ToString();
            fecha_fin_dtpick.Text = Garantiasdtgrdview.CurrentRow.Cells["Fecha Fin"].Value.ToString();
            id_estado_garantias_cmb.Text = Garantiasdtgrdview.CurrentRow.Cells["Estado"].Value.ToString();
          
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = garantia;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Id";
            }
            else if (Tiempo_totalrdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Tiempo Total";
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (slidepnl.Height >= 195)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 195)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Garantiasdtgrdview.Location = new Point(0, 304);
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            desplegartmr.Start();
            slidepnl.Visible = true;
        }

        private void Garantiasdtgrdview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Garantiasdtgrdview.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Garantiasdtgrdview.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Garantiasdtgrdview.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Garantiasdtgrdview.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void id_estado_garantias_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estado est = new Estado();
            est.Show();
        }


  


    }
}
