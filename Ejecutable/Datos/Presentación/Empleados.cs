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
    public partial class Empleados : Form
    {
        
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        Lógica.Clase_Empleado obj_empleado = new Clase_Empleado();

        public static DataTable empleados;

        public Empleados()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
         void limpiar()
        {
            Id_empleadotxt.Text = "";
            Nombre_empleadotxt.Text = "";
            telefono_empleadotxt.Text = "";
            Direccion_empleadotxt.Text = "";
            Correoempleadotxt.Text = "";
            Fecha_nacimientobtp.Text ="";
            Fecha_ingresodtp.Text ="";
            Salario_empleadotxt.Text = "";
            codcargo_empleadotxt.Text="";
            N_contratotxt.Text ="";
            id_estado_empleado_cmb.Text = "";
        }


         #region
         private void Id_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }
        private void telefono_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Salario_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void correo_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void Nombre_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void Direccion_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void fecha_nacimiento_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void Id_estado_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }


        private void Fecha_ingreso_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        #endregion // VALIDACION 

        private void Empleados_Load(object sender, EventArgs e)
        {
            DataTable est = Lógica.Clase_Estado.llenargrilla();
            DataTable contrato = Lógica.Clase_contrato.llenargrillacontrato();
            DataTable cargo = Lógica.Clase_cargo.llenargrillacargo();
            empleados = Lógica.Clase_Empleado.llenargrilla_empleados();

            id_estado_empleado_cmb.DataSource = est;
            empleado_datagridview.DataSource = empleados;

            id_estado_empleado_cmb.DisplayMember = "Nombre";
            id_estado_empleado_cmb.ValueMember = "Id";
            id_estado_empleado_cmb.SelectedIndex = -1;
            id_estado_empleado_cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            N_contratotxt.DataSource = contrato;
            N_contratotxt.DisplayMember = "Nombre";
            N_contratotxt.ValueMember = "Numero Contrato";
            N_contratotxt.SelectedIndex = -1;
            N_contratotxt.DropDownStyle = ComboBoxStyle.DropDownList;

            codcargo_empleadotxt.DataSource = cargo;
            codcargo_empleadotxt.DisplayMember = "Nombre";
            codcargo_empleadotxt.ValueMember = "Codigo";
            codcargo_empleadotxt.SelectedIndex = -1;
            codcargo_empleadotxt.DropDownStyle = ComboBoxStyle.DropDownList;

                       
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            empleado_datagridview.Columns.Add(btn_img);

            if (Program.acceso == 2)
            {
                this.empleado_datagridview.Columns["   "].Visible = false;
            }
        }
        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Id_empleadotxt.Text == "" || Nombre_empleadotxt.Text == "" || telefono_empleadotxt.Text == "" || Direccion_empleadotxt.Text == "" || Correoempleadotxt.Text == "" || Fecha_nacimientobtp.Text == "" || Fecha_ingresodtp.Text == "" || Salario_empleadotxt.Text == "" || codcargo_empleadotxt.Text == "" || N_contratotxt.Text == "" || id_estado_empleado_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else if (Correoempleadotxt.ForeColor == Color.Red)
            {
                MessageBox.Show("Verifique su correo");
            }
            else
            {
                if (Id_empleadotxt.Text.Length < 5)
                {
                    MessageBox.Show("No se puede digitar una identificación con menos de 5 caracteres");
                }
                else if (telefono_empleadotxt.Text.Length < 7)
                {
                    MessageBox.Show("No se puede digitar un telefono con menos de 7 caracteres");
                }
                else
                {
                    try
                    {

                        int identificacion_empleado = int.Parse(Id_empleadotxt.Text);
                        string nombre_empleado = Nombre_empleadotxt.Text;
                        long telefono_empleado = long.Parse(telefono_empleadotxt.Text);
                        string direccion_empleado = Direccion_empleadotxt.Text;
                        long salario_empleado = long.Parse(Salario_empleadotxt.Text);
                        string fecha_nacimiento_empleado = Fecha_nacimientobtp.Text;
                        string correo_empleado = Correoempleadotxt.Text;
                        string fecha_ingreso_empleado = Fecha_ingresodtp.Text;
                        int id_estado_empleado = int.Parse(id_estado_empleado_cmb.SelectedValue.ToString());
                        int numero_contrato = int.Parse(N_contratotxt.SelectedValue.ToString());
                        int codigo_cargo_empleado = int.Parse(codcargo_empleadotxt.SelectedValue.ToString());

                        int resultado = obj_empleado.IngresarEmpleado(identificacion_empleado, nombre_empleado, telefono_empleado, direccion_empleado, salario_empleado, fecha_nacimiento_empleado, correo_empleado, fecha_ingreso_empleado, id_estado_empleado, numero_contrato, codigo_cargo_empleado);
                        if (resultado > 0)
                        {
                            DataTable empleados = Lógica.Clase_Empleado.llenargrilla_empleados();
                            empleado_datagridview.DataSource = empleados;
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
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (Id_empleadotxt.Text == "" || Nombre_empleadotxt.Text == "" || telefono_empleadotxt.Text == "" || Direccion_empleadotxt.Text == "" || Correoempleadotxt.Text == "" || Fecha_nacimientobtp.Text == "" || Fecha_ingresodtp.Text == "" || Salario_empleadotxt.Text == "" || codcargo_empleadotxt.Text == "" || N_contratotxt.Text == "" || id_estado_empleado_cmb.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {

                    int identificacion_empleado = int.Parse(Id_empleadotxt.Text);
                    string nombre_empleado = Nombre_empleadotxt.Text;
                    long telefono_empleado = long.Parse(telefono_empleadotxt.Text);
                    string direccion_empleado = Direccion_empleadotxt.Text;
                    long salario_empleado = long.Parse(Salario_empleadotxt.Text);
                    string fecha_nacimiento_empleado = Fecha_nacimientobtp.Text;
                    string correo_empleado = Correoempleadotxt.Text;
                    string fecha_ingreso_empleado = Fecha_ingresodtp.Text;
                    int id_estado_empleado = int.Parse(id_estado_empleado_cmb.SelectedValue.ToString());
                    int numero_contrato = int.Parse(N_contratotxt.SelectedValue.ToString());
                    int codigo_cargo_empleado = int.Parse(codcargo_empleadotxt.SelectedValue.ToString());

                    int resultado = obj_empleado.ModificarEmpleado(identificacion_empleado, nombre_empleado, telefono_empleado, direccion_empleado, salario_empleado, fecha_nacimiento_empleado, correo_empleado, fecha_ingreso_empleado, id_estado_empleado, numero_contrato, codigo_cargo_empleado);
                    if (resultado > 0)
                    {
                        int posicion = empleado_datagridview.CurrentRow.Index;
                        DataTable empleados = Lógica.Clase_Empleado.llenargrilla_empleados();
                        empleado_datagridview.DataSource = empleados;
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

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void desplegartmr_Tick(object sender, EventArgs e)
        {
            if (panel_des.Height >= 230)
            {
                desplegartmr.Stop();
            }
            else if (panel_des.Height < 230)
            {
                panel_des.Visible = true;
                panel_des.Height += 15;
                empleado_datagridview.Location = new Point(0, 343);
            }
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (panel_des.Height < 213)
            {
                desplegartmr.Start();
                panel_des.Visible = true;
            }
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = empleados;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Identificación";
            }
            else if (Nombrerdbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Nombre";

            }
        }


        private void empleado_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.empleado_datagridview.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {


                    int Identidicacion_empl = int.Parse(empleado_datagridview.CurrentRow.Cells["Identificación"].Value.ToString());
                    int resultado = obj_empleado.EliminarEmpleado(Identidicacion_empl);
                    if (resultado > 0)
                    {
                        obj_mensajes.Eliminar();
                        empleados = Lógica.Clase_Empleado.llenargrilla_empleados();
                        empleado_datagridview.DataSource = empleados;

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void empleado_datagridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.empleado_datagridview.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.empleado_datagridview.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.empleado_datagridview.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.empleado_datagridview.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void empleado_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Identificación"].Value.ToString();
            Nombre_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Nombre"].Value.ToString();
            telefono_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Telefono"].Value.ToString();
            Direccion_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Dirección"].Value.ToString();
            Salario_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Salario"].Value.ToString();
            Fecha_nacimientobtp.Text = empleado_datagridview.CurrentRow.Cells["Fecha nacimiento"].Value.ToString();
            Correoempleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Correo"].Value.ToString();
            Fecha_ingresodtp.Text = empleado_datagridview.CurrentRow.Cells["Fecha ingreso"].Value.ToString();

            codcargo_empleadotxt.Text = empleado_datagridview.CurrentRow.Cells["Cargo"].Value.ToString();
            N_contratotxt.Text = empleado_datagridview.CurrentRow.Cells["Contrato"].Value.ToString();
            id_estado_empleado_cmb.Text = empleado_datagridview.CurrentRow.Cells["Estado"].Value.ToString();
        }

        private void codcargo_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void N_contratotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void id_estado_empleado_cmb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Contrato con = new Contrato();
            con.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cargo car = new Cargo();
            car.Show();
        }

      
        private void Correoempleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lógica.Validacion valid = new Validacion();
            if (valid.ValidarEmail(Correoempleadotxt.Text))
            {
                Correoempleadotxt.Focus();
                Correoempleadotxt.BackColor = Color.White;
                Correoempleadotxt.ForeColor = Color.Green;
            }
            else
            {
                Correoempleadotxt.Focus();
                Correoempleadotxt.ForeColor = Color.Red;
            }
        }



    }
}
