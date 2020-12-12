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
    public partial class Devolucion_producto : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_estado = new Clase_Estado();
        public Devolucion_producto()
        {
            InitializeComponent();
   
        }
      
        void Limpiar_general()
        {
                Numero_Dv.Text = "...";
                estadocmbx.Text = "";
                clientecmbx.Text = "";
                productocmb.Text = "";
                Cantidad_productos_Dproductotxt.Text = "";
                valor_producto_Dproductotxt.Text = "";
                Detalle_dtgrdvw.Rows.Clear();
        
        }
        void limpiar_Detalle()
        {
            productocmb.Text = "";
            Cantidad_productos_Dproductotxt.Text = "";
            valor_producto_Dproductotxt.Text = "";
            detallelbl.Text = "";
        }
     

        private void codigo_dproductostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void estado_dpreoductostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void fecha_dproductostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void id_cliente_dproductostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);

        }

        private void iddetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Cod_producto_Dproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_producto_Dproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void valor_producto_Dproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Cantidad_productos_Dproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Devolucion_producto_Load(object sender, EventArgs e)
        {
            DataTable dev = Datos.Estado.Llenar_grilla();
            DataTable clien = Datos.Clientes.llenar_grilla_clientes();
            DataTable prod = Datos.Productos.llenar_grilla_productos();
            DataTable devolucion = Datos.Devolucion.llenar_devolucion();

            DataTable empleado = Lógica.Clase_Empleado.llenargrilla_empleados();

            estadocmbx.DataSource = dev;
            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            clientecmbx.DataSource = clien;
            clientecmbx.DisplayMember = "Nombre";
            clientecmbx.ValueMember = "Identificación";
            clientecmbx.SelectedIndex = -1;
            clientecmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            productocmb.DataSource = prod;
            productocmb.DisplayMember = "Nombre";
            productocmb.ValueMember = "Codigo";
            productocmb.SelectedIndex = -1;
            productocmb.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_empleado.DataSource = empleado;
            cmb_empleado.DisplayMember = "Nombre";
            cmb_empleado.ValueMember = "Identificación";
            cmb_empleado.SelectedIndex = -1;
            cmb_empleado.DropDownStyle = ComboBoxStyle.DropDownList;

            Devolucion_dtgrw.DataSource = devolucion;
        }

        private void nombre_clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Fecha_devoluciondtp.Text == "" || estadocmbx.Text == "" || clientecmbx.Text == "" )
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_Devolucion insertar = new Clase_Devolucion();

                    string fecha_devolucion = Fecha_devoluciondtp.Text;
                    int id_cliente_d = int.Parse(clientecmbx.SelectedValue.ToString());
                    int id_estado_d = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_empleado_d = int.Parse(cmb_empleado.SelectedValue.ToString());
                    int resultado = insertar.IngresarDevolucion(fecha_devolucion, id_estado_d, id_cliente_d,id_empleado_d);
                    if (resultado > 0)
                    {
                        obj_mensajes.Agregar();
                        DataTable devol_codi = Lógica.Clase_Devolucion.Identitydevolucion();
                        Numero_Dv.Text= devol_codi.Rows[0][0].ToString();
                        detallepnl.Enabled = true;
                        Detalle_dtgrdvw.Enabled = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void guardar_detallebtn_Click(object sender, EventArgs e)
        {
            if (productocmb.Text == "" || Cantidad_productos_Dproductotxt.Text == "" || valor_producto_Dproductotxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    
                    Lógica.Clase_detalle_devolucion ing_detalle = new Clase_detalle_devolucion();
                    int producto = int.Parse(productocmb.SelectedValue.ToString());
                    long valor_productodtd = long.Parse(valor_producto_Dproductotxt.Text);
                    int cantidad_productodtd = int.Parse(Cantidad_productos_Dproductotxt.Text);
                    int codigo_devolucion_fka = int.Parse(Numero_Dv.Text);
                  
                    int resultado = ing_detalle.ingresar_Detalle_devolucion(producto ,  valor_productodtd,  cantidad_productodtd, codigo_devolucion_fka);
                    if (resultado > 0)
                    {
                        obj_mensajes.Agregar();
                        DataTable id_dt = Lógica.Clase_detalle_devolucion.identitydevolucion();
                        detallelbl.Text = id_dt.Rows[0][0].ToString();
                        Detalle_dtgrdvw.Rows.Add(detallelbl.Text, productocmb.Text, valor_producto_Dproductotxt.Text, Cantidad_productos_Dproductotxt.Text);
                        limpiar_Detalle();
                       
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
            if (Fecha_devoluciondtp.Text == "" || estadocmbx.Text == "" || clientecmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_Devolucion modificar = new Clase_Devolucion();
                    int id_devolucion = int.Parse(Numero_Dv.Text);
                    string fecha_devolucion = Fecha_devoluciondtp.Text;
                    int id_cliente_d = int.Parse(clientecmbx.SelectedValue.ToString());
                    int id_estado_d = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_empleado_d = int.Parse(cmb_empleado.SelectedValue.ToString());
                    int resultado = modificar.ModificarDevolucion(id_devolucion,fecha_devolucion,id_estado_d,id_cliente_d,id_empleado_d);
                    if (resultado > 0)
                    {
                        obj_mensajes.Modificar();
                        DataTable dt = Lógica.Clase_Devolucion.llenardevolucion();
                        Devolucion_dtgrw.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

   
        private void editar_Detallebtn_Click(object sender, EventArgs e)
        {
            if (productocmb.Text == "" || Cantidad_productos_Dproductotxt.Text == "" || valor_producto_Dproductotxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {

                    Lógica.Clase_detalle_devolucion modificar_detalle = new Clase_detalle_devolucion();
                    int posicion = Detalle_dtgrdvw.CurrentRow.Index;
                    int id_Dt = int.Parse(Detalle_dtgrdvw[0,posicion].Value.ToString());
                    int producto = int.Parse(productocmb.SelectedValue.ToString());
                    long valor_productodtd = long.Parse(valor_producto_Dproductotxt.Text);
                    int cantidad_productodtd = int.Parse(Cantidad_productos_Dproductotxt.Text);
         
                    int resultado = modificar_detalle.ModificarDetalleDevolucion(id_Dt,producto, valor_productodtd, cantidad_productodtd);
                    if (resultado > 0)
                    {

                        Detalle_dtgrdvw[1, posicion].Value = productocmb.Text;
                        Detalle_dtgrdvw[2, posicion].Value = long.Parse(valor_producto_Dproductotxt.Text);
                        Detalle_dtgrdvw[3, posicion].Value = int.Parse(Cantidad_productos_Dproductotxt.Text);
                        obj_mensajes.Modificar();
                    

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
            string fecha = Fecha_devoluciondtp.Text;
            DataTable consulta = Lógica.Clase_Devolucion.Buscar_devolucionfecha(fecha);
            Devolucion_dtgrw.DataSource = consulta;
        }

        private void reloadpctb_Click(object sender, EventArgs e)
        {
            DataTable DEVO = Lógica.Clase_Devolucion.llenardevolucion();
            Devolucion_dtgrw.DataSource = DEVO;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Estado est = new Estado();
            est.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes clie = new Clientes();
            clie.Show();
        }

        private void agregar_productobtn_Click(object sender, EventArgs e)
        {
            Productos pr = new Productos();
            pr.Show();
        }

        private void Detalle_dtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (this.Detalle_dtgrdvw.Columns[e.ColumnIndex].Name == "eliminar")
           {

                   int posicion = Detalle_dtgrdvw.CurrentRow.Index;
                   Lógica.Clase_detalle_devolucion eliminar_mtd = new Clase_detalle_devolucion();
                  
                   int id_Dt = int.Parse(Detalle_dtgrdvw[0,posicion].Value.ToString());
                   int resultado = eliminar_mtd.EliminarDetalleDevolucion(id_Dt);
                   if (resultado > 0)
                   {
                       Detalle_dtgrdvw.Rows.RemoveAt(posicion);
                       obj_mensajes.Eliminar();
                   }
                   else
                   {
                       MessageBox.Show("Ha ocurrido un error");
                   }
               
              
           }

        }

        private void Detalle_dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = Detalle_dtgrdvw.CurrentRow.Index;
            detallelbl.Text = Detalle_dtgrdvw[0, pocision].Value.ToString();
            productocmb.Text = Detalle_dtgrdvw[1, pocision].Value.ToString();
            valor_producto_Dproductotxt.Text = Detalle_dtgrdvw[2,pocision].Value.ToString();
            Cantidad_productos_Dproductotxt.Text = Detalle_dtgrdvw[3, pocision].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados();
            emple.Show();
        }

        private void generar_DVbtn_Click(object sender, EventArgs e)
        {
            Limpiar_general();
            obj_mensajes.Agregar();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            RPTDevolucion dv = new RPTDevolucion();
            dv.Show();
        }

        private void Cantidad_productos_Dproductotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_producto_Dproductotxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void productocmb_TextChanged(object sender, EventArgs e)
        {
            if (productocmb.SelectedIndex == -1 && productocmb.Enabled == false)
            {
            }
            else if (productocmb.SelectedIndex >= 0 && productocmb.Enabled == true)
            {
                int codigo_producto = int.Parse(productocmb.SelectedValue.ToString());
                DataTable valor = Lógica.Clase_Detalle_venta.valor_producto(codigo_producto);
                valor_producto_Dproductotxt.Text = valor.Rows[0][0].ToString();
            }
        }

        private void reloadpctb_Click_1(object sender, EventArgs e)
        {

        }

        private void Devolucion_dtgrw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_dtgrdvw.Columns.Clear();
            Numero_Dv.Text = Devolucion_dtgrw.CurrentRow.Cells["Devolucion No"].Value.ToString();
            Fecha_devoluciondtp.Text = Devolucion_dtgrw.CurrentRow.Cells["Fecha"].Value.ToString();
            estadocmbx.Text = Devolucion_dtgrw.CurrentRow.Cells["Estado"].Value.ToString();
            clientecmbx.Text = Devolucion_dtgrw.CurrentRow.Cells["Cliente"].Value.ToString();
            cmb_empleado.Text = Devolucion_dtgrw.CurrentRow.Cells["Empleado"].Value.ToString();
            int nu_dv = int.Parse(Numero_Dv.Text);
            DataTable dt = Lógica.Clase_detalle_devolucion.consultadetalle(nu_dv);
            Detalle_dtgrdvw.DataSource = dt;
            detallepnl.Enabled = false;
          
            guardar_detallebtn.Enabled = false;
            guardarbtn.Enabled = false;
            editar_Detallebtn.Enabled = false;
            modificarbtn.Enabled = false;
            generar_DVbtn.Enabled = false;
        }


      
      

 
    }
}

