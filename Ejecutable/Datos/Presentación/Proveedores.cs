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
    public partial class Proveedores : Form
    {

        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_proveedores obj_proveedor = new Clase_proveedores();
        public Proveedores()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
        public static DataTable prov;
        public static DataTable proveedores;
        void Limpiar()
        {
            Codigo_provedorestxt.Text = "";
            Nombre_provedorestxt.Text = "";
            R_social_provedorestxt.Text = "";
            Direccion_provedorestxt.Text = "";
            Ciudad_provedorestxt.Text = "";
            C_postal_provedorestxt.Text = "";
            Telefono_provedorestxt.Text = "";
            Correoproveedortxt.Text = "";
            id_estado_proveedor_cmb.Text = "";
        }
  

        private void Codigo_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void R_social_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Direccion_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void Ciudad_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void C_postal_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Telefono_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void C_electronico_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void Ccn_provedorestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo_proveedor = int.Parse(Codigo_provedorestxt.Text);
               int resultado = obj_proveedor.eliminar_proveedores(codigo_proveedor);
                if (resultado > 0)
                {
                    obj_mensajes.Eliminar();
                    DataTable prov = Lógica.Clase_proveedores.llenargrillaproveedores();
                    dataGridView_provedores.DataSource = prov;
                    Limpiar();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
             prov = Datos.Estado.Llenar_grilla();
             proveedores = Lógica.Clase_proveedores.llenargrillaproveedores();
            id_estado_proveedor_cmb.DataSource = prov;
            dataGridView_provedores.DataSource = proveedores;
            id_estado_proveedor_cmb.DisplayMember = "Nombre";
            id_estado_proveedor_cmb.ValueMember = "Id";
            id_estado_proveedor_cmb.SelectedIndex = -1;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            dataGridView_provedores.Columns.Add(btn_img);

            if (Program.acceso == 2)
            {
                this.dataGridView_provedores.Columns["   "].Visible = false;
            }

        }





        private void guardarbtn_Click(object sender, EventArgs e)
        {
               Lógica.Validacion valid = new Validacion();
            if (Codigo_provedorestxt.Text == "" || Nombre_provedorestxt.Text == "" || R_social_provedorestxt.Text == "" || Direccion_provedorestxt.Text == "" || Ciudad_provedorestxt.Text == "" || C_postal_provedorestxt.Text == "" || Telefono_provedorestxt.Text == "" || Correoproveedortxt.Text == "" || id_estado_proveedor_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
                 
            else if (Correoproveedortxt.ForeColor == Color.Red)
            {
                MessageBox.Show("Verifique su correo");
            }

            else
            {

                if (Codigo_provedorestxt.Text.Length < 5)
                {
                    MessageBox.Show("No se puede digitar una identificación con menos de 5 caracteres");
                }
                else if (Telefono_provedorestxt.Text.Length < 7)
                {
                    MessageBox.Show("No se puede digitar un telefono con menos de 7 caracteres");
                }
                else
                {
                    try
                    {
                        int codigo_proveedor = int.Parse(Codigo_provedorestxt.Text);
                        string nombre_proveedor = Nombre_provedorestxt.Text;
                        string r_social_proveedor = R_social_provedorestxt.Text;
                        string direccion_proveedor = Direccion_provedorestxt.Text;
                        string ciudad_proveedor = Ciudad_provedorestxt.Text;
                        int c_postal_proveedor = int.Parse(C_postal_provedorestxt.Text);
                        long telefono_proveedor = long.Parse(Telefono_provedorestxt.Text);
                        string c_electronico_proveedor = Correoproveedortxt.Text;
                        int id_estado_proveedor = int.Parse(id_estado_proveedor_cmb.SelectedValue.ToString());
                        int resultado = obj_proveedor.ingresar_proveedores(codigo_proveedor, nombre_proveedor, r_social_proveedor, direccion_proveedor, ciudad_proveedor, c_postal_proveedor, telefono_proveedor, c_electronico_proveedor, id_estado_proveedor);
                        if (resultado > 0)
                        {
                            obj_mensajes.Agregar();
                            DataTable prov = Lógica.Clase_proveedores.llenargrillaproveedores();
                            dataGridView_provedores.DataSource = prov;
                            Limpiar();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (Codigo_provedorestxt.Text == "" || Nombre_provedorestxt.Text == "" || R_social_provedorestxt.Text == "" || Direccion_provedorestxt.Text == "" || Ciudad_provedorestxt.Text == "" || C_postal_provedorestxt.Text == "" || Telefono_provedorestxt.Text == "" || Correoproveedortxt.Text == "" || id_estado_proveedor_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    int codigo_proveedor = int.Parse(Codigo_provedorestxt.Text);
                    string nombre_proveedor = Nombre_provedorestxt.Text;
                    string r_social_proveedor = R_social_provedorestxt.Text;
                    string direccion_proveedor = Direccion_provedorestxt.Text;
                    string ciudad_proveedor = Ciudad_provedorestxt.Text;
                    int c_postal_proveedor = int.Parse(C_postal_provedorestxt.Text);
                    long telefono_proveedor = long.Parse(Telefono_provedorestxt.Text);
                    string c_electronico_proveedor = Correoproveedortxt.Text;
                    int id_estado_proveedor = int.Parse(id_estado_proveedor_cmb.SelectedValue.ToString());
                    int resultado = obj_proveedor.Modificar_proveedores(codigo_proveedor, nombre_proveedor, r_social_proveedor, direccion_proveedor, ciudad_proveedor, c_postal_proveedor, telefono_proveedor, c_electronico_proveedor, id_estado_proveedor);
                    if (resultado > 0)
                    {
                        obj_mensajes.Modificar();
                        DataTable prov = Lógica.Clase_proveedores.llenargrillaproveedores();
                        dataGridView_provedores.DataSource = prov;
                        Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void dataGridView_provedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Codigo_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Codigo"].Value.ToString();
            Nombre_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Nombre"].Value.ToString();
            R_social_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Razón Social"].Value.ToString();
            Direccion_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Dirección"].Value.ToString();
            Ciudad_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Ciudad"].Value.ToString();
            C_postal_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Codigo Postal"].Value.ToString();
            Telefono_provedorestxt.Text = dataGridView_provedores.CurrentRow.Cells["Telefono"].Value.ToString();
            Correoproveedortxt.Text = dataGridView_provedores.CurrentRow.Cells["Correo Electronico"].Value.ToString();
            id_estado_proveedor_cmb.Text = dataGridView_provedores.CurrentRow.Cells["Estado"].Value.ToString();
            
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

   

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (slidepnl.Height >= 181)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 181)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                dataGridView_provedores.Location = new Point(12, 295);
            }
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = proveedores;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Codigo";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            desplegartmr.Start();
        }

        private void dataGridView_provedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (this.dataGridView_provedores.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {

                    int codigo_proveedor = int.Parse(dataGridView_provedores.CurrentRow.Cells["Codigo"].Value.ToString());
                    int resultado = obj_proveedor.eliminar_proveedores(codigo_proveedor);
                    if (resultado > 0)
                    {
                        obj_mensajes.Eliminar();
                        DataTable prov = Lógica.Clase_proveedores.llenargrillaproveedores();
                        dataGridView_provedores.DataSource = prov;
                    }
                 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void dataGridView_provedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView_provedores.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.dataGridView_provedores.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dataGridView_provedores.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.dataGridView_provedores.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void id_estado_proveedor_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void R_social_provedorestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Correo_proveedorcbx_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void Correoproveedortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lógica.Validacion valid = new Validacion();
            if (valid.ValidarEmail(Correoproveedortxt.Text))
            {
                Correoproveedortxt.Focus();
                Correoproveedortxt.BackColor = Color.White;
                Correoproveedortxt.ForeColor = Color.Green;
            }
            else
            {
                Correoproveedortxt.Focus();
                Correoproveedortxt.ForeColor = Color.Red;
            }
        }



 



    
 
        }
    }

