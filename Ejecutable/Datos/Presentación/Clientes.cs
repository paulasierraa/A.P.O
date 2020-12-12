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
    public partial class Clientes : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_clientes obj_cliente = new Clase_clientes();
        public Clientes()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }

        DataTable clien;
        void Limpiar()
        
        {
            identificacion_clientetxt.Text = "";
            nombre_clientetxt.Text = "";
            telefono_clientetxt.Text = "";
            Correoclientetxt.Text = "";
            id_estado_cliente_cmb.Text = "";

        }


      
        private void identificacion_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Direccion_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void correo_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void nombre_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void telefono_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Id_estado_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }



        private void Clientes_Load(object sender, EventArgs e)
        {
            

            DataTable cest = Datos.Estado.Llenar_grilla();
            clien = Lógica.Clase_clientes.llenargrillacliente();
           Clientedtgrdvw.DataSource  = clien;
           id_estado_cliente_cmb.DataSource = cest;

            id_estado_cliente_cmb.DisplayMember = "Nombre";
            id_estado_cliente_cmb.ValueMember = "Id";
            id_estado_cliente_cmb.SelectedIndex = -1;
            id_estado_cliente_cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Clientedtgrdvw.Columns.Add(btn_img);
            if (Program.acceso == 2)
            {
                this.Clientedtgrdvw.Columns["   "].Visible = false;
            }

        }

     


        private void id_estado_cliente_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (identificacion_clientetxt.Text == "" || nombre_clientetxt.Text == "" || telefono_clientetxt.Text == "" || Correoclientetxt.Text == "" || id_estado_cliente_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else if (Correoclientetxt.ForeColor == Color.Red)
            {
                MessageBox.Show("Verifique su correo");
            }

            else
            {
                if (identificacion_clientetxt.Text.Length < 5)
                {
                    MessageBox.Show("No se puede digitar una identificación con menos de 5 caracteres");
                }
                else if(telefono_clientetxt.Text.Length < 7)
                {
                    MessageBox.Show("No se puede digitar un telefono con menos de 7 caracteres");
                }
                else
                {


                    try
                    {

                        int identificacion_cliente = int.Parse(identificacion_clientetxt.Text);
                        string nombre_cliente = nombre_clientetxt.Text;
                        long telefono_cliente = long.Parse(telefono_clientetxt.Text);
                        string correo_cliete = Correoclientetxt.Text;
                        int id_estado = int.Parse(id_estado_cliente_cmb.SelectedValue.ToString());

                        int resultado = obj_cliente.IngresarClientes(identificacion_cliente, nombre_cliente, telefono_cliente, correo_cliete, id_estado);
                        if (resultado > 0)
                        {

                            DataTable cliente = Datos.Clientes.llenar_grilla_clientes();
                            Clientedtgrdvw.DataSource = cliente;
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
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (identificacion_clientetxt.Text == "" || nombre_clientetxt.Text == "" || telefono_clientetxt.Text == "" || Correoclientetxt.Text == "" || id_estado_cliente_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_clientes cli = new Clase_clientes();
                    int identificacion_cliente = int.Parse(identificacion_clientetxt.Text);
                    string nombre_cliente = nombre_clientetxt.Text;
                    long telefono_cliente = long.Parse(telefono_clientetxt.Text);
                    string correo_cliete = Correoclientetxt.Text;
                    int id_estado = int.Parse(id_estado_cliente_cmb.SelectedValue.ToString());

                    int resultado = obj_cliente.ModificarClientes(identificacion_cliente, nombre_cliente, telefono_cliente, correo_cliete, id_estado);
                    if (resultado > 0)
                    {
                        int posicion = Clientedtgrdvw.CurrentRow.Index;
                        DataTable cliente = Datos.Clientes.llenar_grilla_clientes();
                        Clientedtgrdvw.DataSource = cliente;
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

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (panel2.Height < 213)
            {
                desplegartmr.Start();
                panel2.Visible = true;
            }
        }

        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (panel2.Height >= 192)
            {
                desplegartmr.Stop();
            }
            else if (panel2.Height < 192)
            {
                panel2.Visible = true;
                panel2.Height += 15;
                Clientedtgrdvw.Location = new Point(57, 308);
            }
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }


        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = clien;

            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Identificación";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";

            }
        }

        private void Clientedtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Clientedtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {


                    int Identificacion_cliente = int.Parse(Clientedtgrdvw.CurrentRow.Cells["Identificación"].Value.ToString());
                    int resultado = obj_cliente.EliminarClientes(Identificacion_cliente);
                    if (resultado > 0)
                    {
                        obj_mensajes.Eliminar();
                        DataTable clien = Lógica.Clase_clientes.llenargrillacliente();
                        Clientedtgrdvw.DataSource = clien;
                        Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Clientedtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identificacion_clientetxt.Text = Clientedtgrdvw.CurrentRow.Cells["Identificación"].Value.ToString();
            nombre_clientetxt.Text = Clientedtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();
            telefono_clientetxt.Text = Clientedtgrdvw.CurrentRow.Cells["Telefono"].Value.ToString();
            Correoclientetxt.Text = Clientedtgrdvw.CurrentRow.Cells["Correo Electronico"].Value.ToString();
            id_estado_cliente_cmb.Text = Clientedtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void Clientedtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Clientedtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Clientedtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Clientedtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Clientedtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      

        private void Correoclientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lógica.Validacion valid = new Validacion();
            if (valid.ValidarEmail(Correoclientetxt.Text))
            {
                Correoclientetxt.Focus();
                Correoclientetxt.BackColor = Color.White;
                Correoclientetxt.ForeColor = Color.Green;
            }
            else
            {
                Correoclientetxt.Focus();
                Correoclientetxt.ForeColor = Color.Red;
            }

        }
        }

       
    }

