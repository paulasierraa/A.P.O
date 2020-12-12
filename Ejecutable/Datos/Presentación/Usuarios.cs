using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Presentación
{
    public partial class Usuarios : Form
    {
        Lógica.Validacion Obj_validacion = new Lógica.Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Lógica.Clase_mensajes();
        Lógica.Clase_Estado obj_Estado = new Lógica.Clase_Estado();
        Lógica.Clase_usuario obj_usuario = new Lógica.Clase_usuario();
        public Usuarios()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
        void Limpiar()
        {
            Id_usuariotxt.Text = "";
            Nombre_usuariotxt.Text = "";
            clave_usuariotxt.Text = "";
            id_estado_usuario_cmb.Text = "";
            id_empleadotxt.Text = "";
          
        }
        public static DataTable usuario;
        private void Id_usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }


        private void Id_usuariotxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }


        private void Estado_usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }
    


        private void Usuarios_Load(object sender, EventArgs e)
        {
            usuario = Lógica.Clase_usuario.llenargrillausuario();
            DataTable est = Lógica.Clase_Estado.llenargrilla();
            DataTable llenar_empleado = Lógica.Clase_Empleado.llenargrilla_empleados();

            id_estado_usuario_cmb.DataSource = est;

            Usuariodtgrdvw.DataSource = usuario;


            id_estado_usuario_cmb.DisplayMember = "Nombre";
            id_estado_usuario_cmb.ValueMember = "Id";
            id_estado_usuario_cmb.SelectedIndex = -1;
            id_estado_usuario_cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            id_empleadotxt.DataSource = llenar_empleado;
            id_empleadotxt.DisplayMember = "Nombre";
            id_empleadotxt.ValueMember = "Identificación";
            id_empleadotxt.SelectedIndex = -1;
            id_empleadotxt.DropDownStyle = ComboBoxStyle.DropDownList;

            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Usuariodtgrdvw.Columns.Add(btn_img);

            if (Program.acceso == 2)
            {
                this.Usuariodtgrdvw.Columns["   "].Visible = false;
            }
        }



        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Nombre_usuariotxt.Text == " " || clave_usuariotxt.Text == " " || id_estado_usuario_cmb.Text ==  " " || id_empleadotxt.Text == " " ||tipo_usuariotxt.Text == " ")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    string nombre_usuario = Nombre_usuariotxt.Text;
                    string clave_usuario = clave_usuariotxt.Text;
                    string tipo_usuario = tipo_usuariotxt.Text;
                    int id_Estado_u = int.Parse(id_estado_usuario_cmb.SelectedValue.ToString());
                    int id_empleado_u = int.Parse(id_empleadotxt.SelectedValue.ToString());
                    
                    int resultado = obj_usuario.ingresar_usuario(nombre_usuario, clave_usuario,tipo_usuario,id_Estado_u,id_empleado_u);
                    if (resultado > 0)
                    {
                        DataTable usu = Lógica.Clase_usuario.llenargrillausuario();
                        Usuariodtgrdvw.DataSource = usu;
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
            if (Id_usuariotxt.Text == " " || Id_usuariotxt.Text == "..." || Nombre_usuariotxt.Text == " " || clave_usuariotxt.Text == " " || id_estado_usuario_cmb.Text == " " || id_empleadotxt.Text == " " || tipo_usuariotxt.Text == " ")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    int id_usuario = int.Parse(Id_usuariotxt.Text);
                    string nombre_usuario = Nombre_usuariotxt.Text;
                    string clave_usuario = clave_usuariotxt.Text;
                    string tipo_usuario = tipo_usuariotxt.Text;
                    int id_Estado_u = int.Parse(id_estado_usuario_cmb.SelectedValue.ToString());
                    int id_empleado_u = int.Parse(id_empleadotxt.SelectedValue.ToString());
                    int resultado = obj_usuario.Modificar_usuario(id_usuario,nombre_usuario,clave_usuario,tipo_usuario,id_Estado_u,id_empleado_u);
                    if (resultado > 0)
                    {
                        DataTable usu = Lógica.Clase_usuario.llenargrillausuario();
                        Usuariodtgrdvw.DataSource = usu;
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

        private void Usuariodtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Id_usuariotxt.Text = Usuariodtgrdvw.CurrentRow.Cells["Id"].Value.ToString();
            Nombre_usuariotxt.Text = Usuariodtgrdvw.CurrentRow.Cells["Nombre"].Value.ToString();
            clave_usuariotxt.Text = Usuariodtgrdvw.CurrentRow.Cells["Clave"].Value.ToString();
            tipo_usuariotxt.Text = Usuariodtgrdvw.CurrentRow.Cells["Tipo"].Value.ToString();
            id_estado_usuario_cmb.Text = Usuariodtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
            id_empleadotxt.Text = Usuariodtgrdvw.CurrentRow.Cells["Nombre Empleado"].Value.ToString();
         
        }

        private void id_empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void id_estado_usuario_cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void Usuariodtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Usuariodtgrdvw.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Usuariodtgrdvw.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Usuariodtgrdvw.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Usuariodtgrdvw.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void Usuariodtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (this.Usuariodtgrdvw.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {
                    int id_usuario = int.Parse(Usuariodtgrdvw.CurrentRow.Cells["Id"].Value.ToString());
                    int resultado = obj_usuario.Eliminar_usuario(id_usuario);
                    if (resultado > 0)
                    {
                        obj_mensajes.Eliminar();
                        DataTable usu = Lógica.Clase_usuario.llenargrillausuario();
                        Usuariodtgrdvw.DataSource = usu;
                        Limpiar();
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
            if (slidepnl.Height >= 210)
            {
                desplegartmr.Stop();
            }
            else if (slidepnl.Height < 210)
            {
                slidepnl.Visible = true;
                slidepnl.Height += 15;
                Usuariodtgrdvw.Location = new Point(3, 321);
            }
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = usuario;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Id";
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

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            Empleados em = new Empleados();
            em.Show();
        }

     
    }
}
