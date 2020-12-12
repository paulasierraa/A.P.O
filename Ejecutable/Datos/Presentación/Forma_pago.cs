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
    public partial class Forma_pago : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_forma_pago obj_Fpago = new Clase_forma_pago();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        public static DataTable fp;
        public Forma_pago()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
     
        void Limpiar()
        {
       
            Nombre_forma_pagotxt.Text = "";
            id_estado_forma_pago_cmb.Text = "";
            id_fplbl.Text = "";
        }

        private void Id_forma_pagotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_forma_pagotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }


        private void Forma_pago_Load(object sender, EventArgs e)
        {
            //CONSULTA GENERAR FP
            fp = Lógica.Clase_forma_pago.llenargrillafp();
            Forma_pago_dtgrdvw.DataSource = fp;
         
         
            //CARGAR COMBO
            DataTable cest = Lógica.Clase_Estado.llenargrilla();
            id_estado_forma_pago_cmb.DataSource = cest;
            id_estado_forma_pago_cmb.DisplayMember = "Nombre";
            id_estado_forma_pago_cmb.ValueMember = "Id";
            id_estado_forma_pago_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            id_estado_forma_pago_cmb.SelectedIndex = -1;

            slidepnl.Visible = false;
           

                DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
                btn_img.Name = "   ";
                Forma_pago_dtgrdvw.Columns.Add(btn_img);

                if (Program.acceso == 2)
                {
                    this.Forma_pago_dtgrdvw.Columns["   "].Visible = false;
                }
            }
        

  
  
        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Nombre_forma_pagotxt.Text == "" || id_estado_forma_pago_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();

            }
          
            else
            {
                try
                {
                    Lógica.Clase_forma_pago fp = new Clase_forma_pago();
                    string nombre_forma_pago = Nombre_forma_pagotxt.Text;
                    int id_estado_fp = int.Parse(id_estado_forma_pago_cmb.SelectedValue.ToString());
                    int resultado = obj_Fpago.ingresar_forma_pago(nombre_forma_pago, id_estado_fp);
                    if (resultado > 0)
                    {
                        DataTable fpp = Lógica.Clase_forma_pago.llenargrillafp();
                        Forma_pago_dtgrdvw.DataSource = fpp;
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
            if (id_fplbl.Text == " " || id_fplbl.Text == "..."||Nombre_forma_pagotxt.Text == "" || id_estado_forma_pago_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();

            }
            else
            {
                try
                {

                    Lógica.Clase_forma_pago fp = new Clase_forma_pago();
                    int id_forma_pago = int.Parse(id_fplbl.Text);
                    string nombre_forma_pago = Nombre_forma_pagotxt.Text;
                    int id_estado_fp = int.Parse(id_estado_forma_pago_cmb.SelectedValue.ToString());
                    int resultado = obj_Fpago.Modificar_forma_pago(id_forma_pago, nombre_forma_pago, id_estado_fp);
                    if (resultado > 0)
                    {
                        DataTable fpp = Lógica.Clase_forma_pago.llenargrillafp();
                        Forma_pago_dtgrdvw.DataSource = fpp;
                        Limpiar();
                        obj_mensajes.Modificar();
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
            if (slidepnl.Height >= 160)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 160)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Forma_pago_dtgrdvw.Location = new Point(93, 276);
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (slidepnl.Height < 160)
            {
                desplegartmr.Start();
                slidepnl.Visible = true;
            }
        }

        private void Forma_pago_dtgrdvw_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Forma_pago_dtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {

                try
                {
                    int id_forma_pago = int.Parse(Forma_pago_dtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString());
                    int resultado = obj_Fpago.eliminar_forma_pago(id_forma_pago);
                    if (resultado > 0)
                    {

                        Limpiar();
                        obj_mensajes.Eliminar();
                        DataTable fpp = Lógica.Clase_forma_pago.llenargrillafp();
                        Forma_pago_dtgrdvw.DataSource = fpp;

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Forma_pago_dtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Forma_pago_dtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Forma_pago_dtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Forma_pago_dtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Forma_pago_dtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }


        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = fp;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Codigo";

            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";
            }
        }

        private void Forma_pago_dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            id_fplbl.Text = Forma_pago_dtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString();
            Nombre_forma_pagotxt.Text = Forma_pago_dtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();
            id_estado_forma_pago_cmb.Text = Forma_pago_dtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void id_estado_forma_pago_cmb_KeyPress(object sender, KeyPressEventArgs e)
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
