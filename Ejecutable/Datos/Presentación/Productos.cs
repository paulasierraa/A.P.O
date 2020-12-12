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
    public partial class Productos : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_Estado = new Clase_Estado();
        Lógica.Clase_productos obj_productos = new Clase_productos();
        public static DataTable produc;
        public static DataTable presentacion;
        public static DataTable garantia;
        public Productos()
        {
            InitializeComponent();
            if (Program.acceso == 2)
            {
                nuevobtn.Visible = false;
            }
        }
      
        void Limpiar()
        {
            Codigo_productotxt.Text = "";
            Nombre_productotxt.Text = "";
            cantidad_productostxt.Text = "";
            presentaciontxt.Text = "";
            cantidad_minima_productostxt.Text = "";
            cantidad_maxima_productostxt.Text = "";
            valor_compra_productostxt.Text = "";
            valor_venta_productostxt.Text = "";
            id_estado_producto_cmb.Text = "";
            id_garantiatxt.Text = "";
       
            unidad_medidacmbx.Text = "";
        }

        private void Codigo_productotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_productotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void cantidad_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void cantidad_minima_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void cantidad_maxima_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void presentaciontxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_unitario_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_compra_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_venta_productostxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }


        private void Id_estado_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void id_garantiatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

  

        private void agregar_proveedor_Click(object sender, EventArgs e)
        {
            Tipo_presentacion t_pre = new Tipo_presentacion();
            t_pre.Show();
        }

    

        private void Productos_Load(object sender, EventArgs e)
        {
            produc = Lógica.Clase_productos.llenargrillaproductos();
            Producto_datagridview.DataSource = produc;
            DataTable est = Lógica.Clase_Estado.llenargrilla();
             presentacion = Lógica.Clase_tipo_presentacion.llenargrillapresentacion();
             garantia = Lógica.Clase_garantia.llenargrillagarantia();
            id_estado_producto_cmb.DataSource = est;
            id_estado_producto_cmb.DisplayMember = "Nombre";
            id_estado_producto_cmb.ValueMember = "Id";
            presentaciontxt.DataSource = presentacion;
            presentaciontxt.DisplayMember = "Nombre";
            presentaciontxt.ValueMember = "Codigo";
            id_garantiatxt.DataSource = garantia;
            id_garantiatxt.DisplayMember = "Tiempo Total";
            id_garantiatxt.ValueMember = "Id";
            id_garantiatxt.SelectedIndex = -1;
            presentaciontxt.SelectedIndex = -1;
            id_estado_producto_cmb.SelectedIndex = -1;
            slidepnl.Visible = false;
            DataGridViewImageColumn btn_img = new DataGridViewImageColumn();
            btn_img.Name = "   ";
            Producto_datagridview.Columns.Add(btn_img);

            if (Program.acceso == 2)
            {
                this.Producto_datagridview.Columns["   "].Visible = false;
            }

        }

        private void Producto_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Producto_datagridview.Columns[e.ColumnIndex].Name == "   ")
            {
                try
                {

                    int codigo_producto = int.Parse(Producto_datagridview.CurrentRow.Cells["Codigo"].Value.ToString());
                    int resultado = obj_productos.Eliminar_productos(codigo_producto);
                    if (resultado > 0)
                    {
                        obj_mensajes.Eliminar();
                        DataTable produc = Lógica.Clase_productos.llenargrillaproductos();
                        Producto_datagridview.DataSource = produc;
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
               if(slidepnl.Height >= 170)
            {
                desplegartmr.Stop();
            }
               else if (slidepnl.Height < 170)
               {
                   slidepnl.Visible = true;
                   slidepnl.Height += 15;
                   Producto_datagridview.Location = new Point(0, 297);
               }
            
        }
        private void limpiarbtn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void nuevobtn_Click(object sender, EventArgs e)
        {
            if (slidepnl.Height < 213)
            {
                desplegartmr.Start();
                slidepnl.Visible = true;
            }
     
          
        }

        private void Producto_datagridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.Producto_datagridview.Columns[e.ColumnIndex].Name == "   " && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cel_eliminar = this.Producto_datagridview.Rows[e.RowIndex].Cells["   "] as DataGridViewButtonCell;
                Icon ico_Eliminar = new Icon(Environment.CurrentDirectory + @"\\eliminar.ico");
                e.Graphics.DrawIcon(ico_Eliminar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.Producto_datagridview.Rows[e.RowIndex].Height = ico_Eliminar.Height + 4;
                this.Producto_datagridview.Columns[e.ColumnIndex].Width = ico_Eliminar.Width + 4;
                e.Handled = true;
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Codigo_productotxt.Text == "" || Nombre_productotxt.Text == "" || cantidad_productostxt.Text == "" || presentaciontxt.Text == "" || cantidad_minima_productostxt.Text == "" || cantidad_maxima_productostxt.Text == "" || valor_compra_productostxt.Text == "" || valor_venta_productostxt.Text == "" || id_estado_producto_cmb.Text == "" || id_garantiatxt.Text == "" || unidad_medidacmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();

            }
            else
            {
                int valor_venta = int.Parse(valor_venta_productostxt.Text);
                int valor_compra = int.Parse(valor_compra_productostxt.Text);
                if(valor_venta < valor_compra)
                {
                    MessageBox.Show("El valor de venta no puede ser menor que el valor de compra");
                }
                else
                {
                try
                {
                    int codigo_producto = int.Parse(Codigo_productotxt.Text);
                    string nombre_producto = Nombre_productotxt.Text;
                    long cantidad_productos = long.Parse(cantidad_productostxt.Text);
                    long cantidad_minima_productos = long.Parse(cantidad_minima_productostxt.Text);
                    long cantidad_maxima_productos = long.Parse(cantidad_maxima_productostxt.Text);
                    long valor_compra_productos = long.Parse(valor_compra_productostxt.Text);
                    long valor_Venta_productos = long.Parse(valor_venta_productostxt.Text);
                    int id_estado_producto = int.Parse(id_estado_producto_cmb.SelectedValue.ToString());
                    int id_garantia_producto = int.Parse(id_garantiatxt.SelectedValue.ToString());
                    int codigo_presentacion_producto = int.Parse(presentaciontxt.SelectedValue.ToString());
                    string unidad_medida_productos = unidad_medidacmbx.Text;
                    int resultado = obj_productos.ingresar_productos(codigo_producto, nombre_producto, cantidad_productos, cantidad_minima_productos, cantidad_maxima_productos, valor_compra_productos, valor_Venta_productos, id_estado_producto, id_garantia_producto, codigo_presentacion_producto, unidad_medida_productos);
                    if (resultado > 0)
                    {
                        DataTable produc = Lógica.Clase_productos.llenargrillaproductos();
                        Producto_datagridview.DataSource = produc;
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
            if (Codigo_productotxt.Text == "" || Nombre_productotxt.Text == "" ||  cantidad_productostxt.Text == "" || presentaciontxt.Text == "" || cantidad_minima_productostxt.Text == "" || cantidad_maxima_productostxt.Text == "" || valor_compra_productostxt.Text == "" || valor_venta_productostxt.Text == "" || id_estado_producto_cmb.Text == "" || id_garantiatxt.Text == "" || unidad_medidacmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();

            }
            else
            {
                try
                {
                    int codigo_producto = int.Parse(Codigo_productotxt.Text);
                    string nombre_producto = Nombre_productotxt.Text;
                
                    long cantidad_productos = long.Parse(cantidad_productostxt.Text);
                    long cantidad_minima_productos = long.Parse(cantidad_minima_productostxt.Text);
                    long cantidad_maxima_productos = long.Parse(cantidad_maxima_productostxt.Text);
                    long valor_compra_productos = long.Parse(valor_compra_productostxt.Text);
                    long valor_Venta_productos = long.Parse(valor_venta_productostxt.Text);
                    int id_estado_producto = int.Parse(id_estado_producto_cmb.SelectedValue.ToString());
                    int id_garantia_producto = int.Parse(id_garantiatxt.SelectedValue.ToString());
                    int codigo_presentacion_producto = int.Parse(presentaciontxt.SelectedValue.ToString());
                    string unidad_medida_productos = unidad_medidacmbx.Text;
                    int resultado = obj_productos.Modificar_productos(codigo_producto, nombre_producto, cantidad_productos, cantidad_minima_productos, cantidad_maxima_productos, valor_compra_productos, valor_Venta_productos, id_estado_producto, id_garantia_producto, codigo_presentacion_producto, unidad_medida_productos);
                    if (resultado > 0)
                    {
                        obj_mensajes.Modificar();
                        DataTable produc = Lógica.Clase_productos.llenargrillaproductos();
                        Producto_datagridview.DataSource = produc;
                        Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void buscarbtn_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            consultar_pnl.Visible = true;
        }

        private void consultarcmbx_TextChanged(object sender, EventArgs e)
        {
            consultarcmbx.DataSource = produc;
            if (codigordbtn.Checked == true)
            {
                consultarcmbx.DisplayMember = "Codigo";
               
            }
            else if (Nombrerdbtn.Checked == true)
            {
             
                consultarcmbx.DisplayMember = "Nombre";
            }
        }

        private void Producto_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo_productotxt.Text = Producto_datagridview.CurrentRow.Cells["Codigo"].Value.ToString();
            Nombre_productotxt.Text = Producto_datagridview.CurrentRow.Cells["Nombre"].Value.ToString();
            cantidad_productostxt.Text = Producto_datagridview.CurrentRow.Cells["Cantidad"].Value.ToString();
            cantidad_minima_productostxt.Text = Producto_datagridview.CurrentRow.Cells["Cantidad Minima"].Value.ToString();
            cantidad_maxima_productostxt.Text = Producto_datagridview.CurrentRow.Cells["Cantidad Máxima"].Value.ToString();
            valor_compra_productostxt.Text = Producto_datagridview.CurrentRow.Cells["Valor Compra"].Value.ToString();
            valor_venta_productostxt.Text = Producto_datagridview.CurrentRow.Cells["Valor Venta"].Value.ToString();
            id_estado_producto_cmb.Text = Producto_datagridview.CurrentRow.Cells["Estado"].Value.ToString();
            id_garantiatxt.Text = Producto_datagridview.CurrentRow.Cells["Garantía"].Value.ToString();
            presentaciontxt.Text = Producto_datagridview.CurrentRow.Cells["Presentación"].Value.ToString();
            unidad_medidacmbx.Text = Producto_datagridview.CurrentRow.Cells["Unidad Medida"].Value.ToString();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void valor_venta_productostxt_TextChanged(object sender, EventArgs e)
        {

        }

      


 

   

    }
}
