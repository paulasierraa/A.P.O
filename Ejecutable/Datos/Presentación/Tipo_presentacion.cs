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
    public partial class Tipo_presentacion : Form
    {
  
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_tipo_presentacion obj_tpresentacion = new Clase_tipo_presentacion();
        public Tipo_presentacion()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
        public static DataTable tipo_presentacion;
       public void limpiar()
        {
            Codigo_Tpresentaciontxt.Text = "";
            Nombre_tpresentaciontxt.Text = "";
            id_estado_tipo_p_cmb.Text = "";
        }

        private void Codigo_Tpresentaciontxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_tpresentaciontxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void Id_Estado_Tpresentaciontxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

 
        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Nombre_tpresentaciontxt.Text == "" || id_estado_tipo_p_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    string nombre_tpresentacion = Nombre_tpresentaciontxt.Text;
                    int id_Estado_tpresentacion = int.Parse(id_estado_tipo_p_cmb.SelectedValue.ToString());
                    int resultado = obj_tpresentacion.ingresar_tpresentacion(nombre_tpresentacion, id_Estado_tpresentacion);
                    if (resultado > 0)
                    {
                        DataTable tp = Lógica.Clase_tipo_presentacion.llenargrillapresentacion();
                        Tipo_presentaciondtgrdvw.DataSource = tp;
                        obj_mensajes.Agregar();
                        limpiar();
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
            if (Codigo_Tpresentaciontxt.Text == "" || Codigo_Tpresentaciontxt.Text == "..."||Nombre_tpresentaciontxt.Text == "" || id_estado_tipo_p_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    int codigo_tpresentacion = int.Parse(Codigo_Tpresentaciontxt.Text);
                    string nombre_tpresentacion = Nombre_tpresentaciontxt.Text;
                    int id_Estado_tpresentacion = int.Parse(id_estado_tipo_p_cmb.SelectedValue.ToString());
                    int resultado = obj_tpresentacion.Modificar_tpresentacion(codigo_tpresentacion, nombre_tpresentacion, id_Estado_tpresentacion);
                    if (resultado > 0)
                    {
                        DataTable tp = Lógica.Clase_tipo_presentacion.llenargrillapresentacion();
                        Tipo_presentaciondtgrdvw.DataSource = tp;
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

        private void Tipo_presentaciondtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            Codigo_Tpresentaciontxt.Text = Tipo_presentaciondtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString();
            Nombre_tpresentaciontxt.Text = Tipo_presentaciondtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();
            id_estado_tipo_p_cmb.Text = Tipo_presentaciondtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void Tipo_presentaciondtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tipo_presentaciondtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {
           try
            {
                int codigo_tpresentacion = int.Parse(Tipo_presentaciondtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString());
                int resultado = obj_tpresentacion.Eliminar_tpresentacion(codigo_tpresentacion);
                if (resultado > 0)
                {
                    DataTable tp = Lógica.Clase_tipo_presentacion.llenargrillapresentacion();
                    Tipo_presentaciondtgrdvw.DataSource = tp;
                    obj_mensajes.Eliminar();
                    limpiar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }

            
               
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (slidepnl.Height >= 185)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 185)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Tipo_presentaciondtgrdvw.Location = new Point(58, 308);
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            desplegartmr.Start();
        }

        private void Tipo_presentaciondtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Tipo_presentaciondtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Tipo_presentaciondtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Tipo_presentaciondtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Tipo_presentaciondtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void Tipo_presentacion_Load(object sender, EventArgs e)
        {
            DataTable tip_P = Datos.Estado.Llenar_grilla();
             tipo_presentacion = Lógica.Clase_tipo_presentacion.llenargrillapresentacion();
            id_estado_tipo_p_cmb.DataSource = tip_P;
            Tipo_presentaciondtgrdvw.DataSource = tipo_presentacion;
            id_estado_tipo_p_cmb.DisplayMember = "Nombre";
            id_estado_tipo_p_cmb.ValueMember = "Id";
            id_estado_tipo_p_cmb.SelectedIndex = -1;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Tipo_presentaciondtgrdvw.Columns.Add(btn_img);

            if (Program.acceso == 2)
            {
                this.Tipo_presentaciondtgrdvw.Columns["   "].Visible = false;
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = tipo_presentacion;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Codigo";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";
            }
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void id_estado_tipo_p_cmb_KeyPress(object sender, KeyPressEventArgs e)
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

