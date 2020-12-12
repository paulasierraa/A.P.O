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
    public partial class Cargo : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes Obj_mensaje = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_cargo obj_cargo = new Clase_cargo();
        public Cargo()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }

        }
        DataTable carg;

        void limpiar()
        {
            numero_cargotxt.Text = "";
            nombre_cargotxt.Text = "";
            estadocmbx.Text = "";
        }

 

        private void Cargo_Load(object sender, EventArgs e)
        {
            DataTable est = Datos.Estado.Llenar_grilla();
             carg = Lógica.Clase_cargo.llenargrillacargo();

            estadocmbx.DataSource = est;
            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            Cargo_dtgrdvw.DataSource = carg;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Cargo_dtgrdvw.Columns.Add(btn_img);
            if (Program.acceso == 2)
            {
                this.Cargo_dtgrdvw.Columns["   "].Visible = false;
            }
        }



        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (slidepnl.Height < 213)
            {
                desplegartmr.Start();
                slidepnl.Visible = true;
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (slidepnl.Height >= 192)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 192)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Cargo_dtgrdvw.Location = new Point(88, 305);
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
           
            consultarcmbx.DataSource = carg;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Codigo";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";

            }
        }


        private void Cargo_dtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Cargo_dtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Cargo_dtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Cargo_dtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Cargo_dtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

     

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (nombre_cargotxt.Text == "" || estadocmbx.Text == "")
            {
                Obj_mensaje.Campos_vacios();
            }
            else
            {
                try
                {

                    string nombre_cargo = nombre_cargotxt.Text;
                    int id_estado_cargo = int.Parse(estadocmbx.SelectedValue.ToString());

                    int resultado = obj_cargo.IngresarCargo(nombre_cargo, id_estado_cargo);
                    if (resultado > 0)
                    {
                        DataTable carg = Lógica.Clase_cargo.llenargrillacargo();
                        Cargo_dtgrdvw.DataSource = carg;
                        Obj_mensaje.Agregar();
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
            if (numero_cargotxt.Text == " " || numero_cargotxt.Text == "..." || nombre_cargotxt.Text == " " || estadocmbx.Text == " ")
            {
                Obj_mensaje.Campos_vacios();
            }
            else
            {
                try
                {
                   
                    int numero_cargo = int.Parse(numero_cargotxt.Text);
                    string nombre_cargo = nombre_cargotxt.Text;
                    int id_estado_cargo = int.Parse(estadocmbx.SelectedValue.ToString());

                    int resultado = obj_cargo.ModificarCargo(numero_cargo, nombre_cargo, id_estado_cargo);
                    if (resultado > 0)
                    {
                        int posicion = Cargo_dtgrdvw.CurrentRow.Index;
                        DataTable carg = Lógica.Clase_cargo.llenargrillacargo();
                        Cargo_dtgrdvw.DataSource = carg;
                        Obj_mensaje.Modificar();
                        limpiar();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void Cargo_dtgrdvw_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            numero_cargotxt.Text = Cargo_dtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString();
            nombre_cargotxt.Text = Cargo_dtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();
            estadocmbx.Text = Cargo_dtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void Cargo_dtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Cargo_dtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {
            try
            {


                int Codigo_Cargo = int.Parse(Cargo_dtgrdvw.CurrentRow.Cells["Codigo"].Value.ToString());
                int resultado = obj_cargo.EliminarCargo(Codigo_Cargo);
                if (resultado > 0)
                {
                    Obj_mensaje.Eliminar();
                    DataTable carg = Lógica.Clase_cargo.llenargrillacargo();
                    Cargo_dtgrdvw.DataSource = carg;
                    limpiar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            }
        }

        private void Cargo_dtgrdvw_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >=0 && this.Cargo_dtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >=0 )
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Cargo_dtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Cargo_dtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Cargo_dtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void estadocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void nombre_cargotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_Mayusculas(e);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregar_productobtn_Click(object sender, EventArgs e)
        {
            Estado est = new Estado();
            est.Show();
        }



       


 
        }
    }

