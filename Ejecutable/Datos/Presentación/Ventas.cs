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
    public partial class Ventas : Form
    {
       
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Detalle_venta obj_dtventa = new Clase_Detalle_venta();
        Lógica.Clase_Venta obj_Venta = new Clase_Venta();
        public Ventas()
        {
            InitializeComponent();
            
        }
       
        void limpiar()
        {
            productotxt.Text = "";
            cantidad_Txt.Text = "";
            valor_unitariotxt.Text = "";
        }
        void limpiar_datos()
        {
            Numero_Factxt.Text = "";
            clientetxt.Text = "";
            estadocmbx.Text = "";
            forma_pagocmbx.Text = "";
        }
        public static DataTable llenar_detalle_Venta;

        private void codigo_productoventatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);

        }

        private void cantidad_productosventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

   

        private void fecha_factxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void valor_unitarioproductoventatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Id_Detalle_fvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);

        }

        private void valor_unitario_profvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void cantidad_productosfvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Codigo_productofvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Id_clienteFVtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Id_empleado_fvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Fecha_facturaV_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void Subtotal_Fvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void iva_fvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void total_fvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }
        private void Valor_unitarioV__KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

  

        private void Ventas_Load(object sender, EventArgs e)
        {
            DataTable llenar_venta = Datos.Ventas.Llenar_ventas();
            Ventasdtgrdvw.DataSource = llenar_venta;


            DataTable llenar_estado = Lógica.Clase_Estado.llenargrilla();
            estadocmbx.DataSource = llenar_estado;
            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable llenar_fp = Lógica.Clase_forma_pago.llenargrillafp();
            forma_pagocmbx.DataSource = llenar_fp;
            forma_pagocmbx.DisplayMember = "Nombre";
            forma_pagocmbx.ValueMember = "Codigo";
            forma_pagocmbx.SelectedIndex = -1;
            forma_pagocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable llenar_emple = Lógica.Clase_Empleado.llenargrilla_empleados();
            empleadotxt.DataSource = llenar_emple;
            empleadotxt.DisplayMember = "Nombre";
            empleadotxt.ValueMember = "Identificación";
            empleadotxt.SelectedIndex = -1;
            empleadotxt.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable llenar_cliente = Lógica.Clase_clientes.llenargrillacliente();
            clientetxt.DataSource = llenar_cliente;
            clientetxt.DisplayMember = "Nombre";
            clientetxt.ValueMember = "Identificación";
            clientetxt.SelectedIndex = -1;
            clientetxt.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable llenar_producto = Lógica.Clase_productos.llenargrillaproductos();
            productotxt.DataSource = llenar_producto;
            productotxt.DisplayMember = "Nombre";
            productotxt.ValueMember = "Codigo";
            productotxt.SelectedIndex = -1;
            productotxt.DropDownStyle = ComboBoxStyle.DropDownList;
           

 

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (Fecha_ventasdtp.Text == "" || estadocmbx.Text == "" || forma_pagocmbx.Text == "" || empleadotxt.Text == "" || clientetxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_Venta insertar = new Clase_Venta();
                    string fecha_Fac = Fecha_ventasdtp.Text;
                    long subtotal_v = 0;
                    long iva_v = 0;
                    long total_facv = 0;
                    int id_clientefv = int.Parse(clientetxt.SelectedValue.ToString());
                    int id_Estadofv = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_empleadofv = int.Parse(empleadotxt.SelectedValue.ToString());
                    int id_forma_pago_fv = int.Parse(forma_pagocmbx.SelectedValue.ToString());
                    int resultado = insertar.ingresar_ventas(fecha_Fac,subtotal_v,iva_v,total_facv,id_clientefv,id_Estadofv,id_empleadofv,id_forma_pago_fv);
               if (resultado>0)
               {
                   obj_mensajes.Agregar();
                   DataTable nu = Lógica.Clase_Venta.identityventa();
                   Numero_Factxt.Text = nu.Rows[0][0].ToString();
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

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (Numero_Factxt.Text == "" || Numero_Factxt.Text == "..."||Fecha_ventasdtp.Text == "" || estadocmbx.Text == "" || forma_pagocmbx.Text == "" || empleadotxt.Text == "" || clientetxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_Venta modificar = new Clase_Venta();
                    int nu_Fac = int.Parse(Numero_Factxt.Text);
                    string fecha_Fac = Fecha_ventasdtp.Text;
                    long subtotal_v = 0;
                    long iva_v = 0;
                    long total_facv = 0;
                    int id_clientefv = int.Parse(clientetxt.SelectedValue.ToString());
                    int id_Estadofv = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_empleadofv = int.Parse(empleadotxt.SelectedValue.ToString());
                    int id_forma_pago_fv = int.Parse(forma_pagocmbx.SelectedValue.ToString());
                    int resultado = modificar.modificar_Venta(nu_Fac,fecha_Fac, subtotal_v, iva_v, total_facv, id_clientefv, id_Estadofv, id_empleadofv, id_forma_pago_fv);
                    if (resultado > 0)
                    { 
                        obj_mensajes.Modificar(); 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Detalle_dtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
     
        }

        private void guardar_detallebtn_Click(object sender, EventArgs e)
        {
            if (productotxt.Text == "" || valor_unitariotxt.Text == "" || cantidad_Txt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    long subtotal_v = 0;
                    long iva_v = 0;
                    long total_facv = 0;
                    Lógica.Clase_Detalle_venta dt = new Clase_Detalle_venta();
                    int producto = int.Parse(productotxt.SelectedValue.ToString());
                    int numero_fac = int.Parse(Numero_Factxt.Text);
                    int cantidad = int.Parse(cantidad_Txt.Text);
                    long valor = long.Parse(valor_unitariotxt.Text);
                    long subtotal = valor * cantidad;
                    int resultado = dt.ingresar_detalle_Venta(producto,numero_fac,cantidad,valor,subtotal);
                    if (resultado > 0)
                    {
                        obj_mensajes.Agregar();
                        DataTable detalle_no = Lógica.Clase_Detalle_venta.IdentityVenta();
                       det_nulbl.Text = detalle_no.Rows[0][0].ToString();
                       Detalle_dtgrdvw.Rows.Add(det_nulbl.Text ,productotxt.Text , valor_unitariotxt.Text , cantidad_Txt.Text ,subtotal );
                        foreach (DataGridViewRow row in Detalle_dtgrdvw.Rows)
                        {
                            subtotal_v += Convert.ToInt64(row.Cells["Subtotalclm"].Value);
                          
                        }
                        subtotaltxt.Text = subtotal_v.ToString();
                        iva_v = subtotal_v * 19 / 100;
                        ivatxt.Text = iva_v.ToString();
                        total_facv = subtotal_v + iva_v;
                        Totaltxt.Text = total_facv.ToString();
                        limpiar();
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }

            }
        }

        private void Detalle_dtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Detalle_dtgrdvw.Columns[e.ColumnIndex].Name == "eliminar")
            {
                long subtotal_v = 0;
                long iva_v = 0;
                long total_facv = 0;
                Lógica.Clase_Detalle_venta dtv = new Clase_Detalle_venta();
                int pocision = Detalle_dtgrdvw.CurrentRow.Index;
                int id_Detalle = int.Parse(Detalle_dtgrdvw[0, pocision].Value.ToString());
                int resultado = dtv.Eliminar_Detalle_Venta(id_Detalle);
                if (resultado > 0)
                {
                    int posicion = Detalle_dtgrdvw.CurrentRow.Index;
                    obj_mensajes.Eliminar();
                    Detalle_dtgrdvw.Rows.RemoveAt(pocision);
                    foreach (DataGridViewRow row in Detalle_dtgrdvw.Rows)
                    {
                        subtotal_v += Convert.ToInt64(row.Cells["Subtotalclm"].Value);

                    }
                    subtotaltxt.Text = subtotal_v.ToString();
                    iva_v = subtotal_v * 19 / 100;
                    ivatxt.Text = iva_v.ToString();
                    total_facv = subtotal_v + iva_v;
                    Totaltxt.Text = total_facv.ToString();
                
                }
             
            }
        }

        private void Detalle_dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

            posicion = Detalle_dtgrdvw.CurrentRow.Index;
            det_nulbl.Text = Detalle_dtgrdvw[0, posicion].Value.ToString();
            productotxt.Text = Detalle_dtgrdvw[1, posicion].Value.ToString();
            valor_unitariotxt.Text = Detalle_dtgrdvw[2, posicion].Value.ToString();
            cantidad_Txt.Text = Detalle_dtgrdvw[3, posicion].Value.ToString();
        }

        private void editar_Detallebtn_Click(object sender, EventArgs e)
        {
            if (det_nulbl.Text == ""||productotxt.Text == "" || valor_unitariotxt.Text == "" || cantidad_Txt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    long subtotal_v = 0;
                    long iva_v = 0;
                    long total_facv = 0;
                    Lógica.Clase_Detalle_venta dt = new Clase_Detalle_venta();
                    int producto = int.Parse(productotxt.SelectedValue.ToString());
                    int numero_fac = int.Parse(Numero_Factxt.Text);
                    int cantidad = int.Parse(cantidad_Txt.Text);
                    long valor = long.Parse(valor_unitariotxt.Text);
                    long subtotal = valor * cantidad;
                    int id_Detalle = int.Parse(det_nulbl.Text);
                    
                    int resultado = dt.Modificar_Detalle_venta(id_Detalle,producto,numero_fac,cantidad,valor,subtotal);
                    if (resultado > 0)
                    {
                        obj_mensajes.Modificar();
                        int posicion = Detalle_dtgrdvw.CurrentRow.Index;
                        Detalle_dtgrdvw[1, posicion].Value = productotxt.Text;
                        Detalle_dtgrdvw[2, posicion].Value = long.Parse(valor.ToString());
                        Detalle_dtgrdvw[3, posicion].Value = int.Parse(cantidad.ToString());
                        Detalle_dtgrdvw[4, posicion].Value = long.Parse(subtotal.ToString());
                        foreach (DataGridViewRow row in Detalle_dtgrdvw.Rows)
                        {
                            subtotal_v += Convert.ToInt64(row.Cells["Subtotalclm"].Value);
                   
                        }
                        subtotaltxt.Text = subtotal_v.ToString();
                        iva_v = subtotal_v * 19 / 100;
                        ivatxt.Text = iva_v.ToString();
                        total_facv = subtotal_v + iva_v;
                        Totaltxt.Text = total_facv.ToString();
                        limpiar();
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }

        private void generar_facturabtn_Click(object sender, EventArgs e)
        {
            if (Numero_Factxt.Text == "" || Numero_Factxt.Text == "..." || Fecha_ventasdtp.Text == "" || estadocmbx.Text == "" || forma_pagocmbx.Text == "" || empleadotxt.Text == "" || clientetxt.Text == ""|| subtotaltxt.Text == "..." || ivatxt.Text == "..."||Totaltxt.Text == "...")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_Venta modificar = new Clase_Venta();
                    int nu_Fac = int.Parse(Numero_Factxt.Text);
                    string fecha_Fac = Fecha_ventasdtp.Text;
                    long subtotal_v = long.Parse(subtotaltxt.Text);
                    long iva_v = long.Parse(ivatxt.Text);
                    long total_facv = long.Parse(Totaltxt.Text);
                    int id_clientefv = int.Parse(clientetxt.SelectedValue.ToString());
                    int id_Estadofv = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_empleadofv = int.Parse(empleadotxt.SelectedValue.ToString());
                    int id_forma_pago_fv = int.Parse(forma_pagocmbx.SelectedValue.ToString());
                    int resultado = modificar.modificar_Venta(nu_Fac, fecha_Fac, subtotal_v, iva_v, total_facv, id_clientefv, id_Estadofv, id_empleadofv, id_forma_pago_fv);
                    if (resultado > 0)
                    {

                            MessageBox.Show("Factura Generada Con Éxito!");
                            DataTable venta = Lógica.Clase_Venta.llenarventa();
                            Ventasdtgrdvw.DataSource = venta;
                            limpiar_datos();
                            Detalle_dtgrdvw.Rows.Clear();
                            detallepnl.Enabled = false;
                            Detalle_dtgrdvw.Enabled = false;
                            subtotaltxt.Text = "...";
                            ivatxt.Text = "...";
                            Totaltxt.Text = "...";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
        }

        private void Ventasdtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_dtgrdvw.Columns.Clear();
            Numero_Factxt.Text = Ventasdtgrdvw.CurrentRow.Cells["No"].Value.ToString();
            Fecha_ventasdtp.Text = Ventasdtgrdvw.CurrentRow.Cells["Fecha"].Value.ToString();
            estadocmbx.Text = Ventasdtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
            empleadotxt.Text = Ventasdtgrdvw.CurrentRow.Cells["Empleado"].Value.ToString();
            clientetxt.Text = Ventasdtgrdvw.CurrentRow.Cells["Cliente"].Value.ToString();
            forma_pagocmbx.Text = Ventasdtgrdvw.CurrentRow.Cells["Forma Pago"].Value.ToString();
            subtotaltxt.Text = Ventasdtgrdvw.CurrentRow.Cells["Subtotal"].Value.ToString();
            ivatxt.Text = Ventasdtgrdvw.CurrentRow.Cells["Iva"].Value.ToString();
            Totaltxt.Text = Ventasdtgrdvw.CurrentRow.Cells["Valor Factura"].Value.ToString();
            int nu_Fac = int.Parse(Numero_Factxt.Text);
            DataTable detalle = Lógica.Clase_Detalle_venta.Llenar_detalle_venta(nu_Fac);
            Detalle_dtgrdvw.DataSource = detalle;
            detallepnl.Enabled = false;
            guardar_detallebtn.Enabled = false;
            editar_Detallebtn.Enabled = false;
            generar_facturabtn.Enabled = false;
            guardarbtn.Enabled = false;
        
            
        }

        private void productotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void cantidad_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_unitariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void clientetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void empleadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void estadocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void forma_pagocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            string fecha = Fecha_ventasdtp.Text;
            DataTable consulta = Lógica.Clase_Venta.buscarventa(fecha);
            Ventasdtgrdvw.DataSource = consulta;
        }

        private void reloadpctb_Click(object sender, EventArgs e)
        {
            DataTable ventas = Lógica.Clase_Venta.llenarventa();
            Ventasdtgrdvw.DataSource = ventas;
        }

        private void productosbtn_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
            DataTable llenar_producto = Lógica.Clase_productos.llenargrillaproductos();
            productotxt.DataSource = llenar_producto;
            productotxt.DisplayMember = "Nombre";
            productotxt.ValueMember = "Codigo";
            productotxt.SelectedIndex = -1;
            productotxt.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void empleadobtn_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados();
            emple.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clien = new Clientes();
            clien.Show();
          
            DataTable llenar_cliente = Lógica.Clase_clientes.llenargrillacliente();
            clientetxt.DataSource = llenar_cliente;
            clientetxt.DisplayMember = "Nombre";
            clientetxt.ValueMember = "Identificación";
            clientetxt.SelectedIndex = -1;
            clientetxt.DropDownStyle = ComboBoxStyle.DropDownList;

     
        }

        private void estadobtn_Click(object sender, EventArgs e)
        {
            Estado est = new Estado();
            est.Show();
            DataTable llenar_estado = Lógica.Clase_Estado.llenargrilla();
            estadocmbx.DataSource = llenar_estado;
            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void fp_btn_Click(object sender, EventArgs e)
        {
            Forma_pago fp = new Forma_pago();
            fp.Show();
            DataTable llenar_fp = Lógica.Clase_forma_pago.llenargrillafp();
            forma_pagocmbx.DataSource = llenar_fp;
            forma_pagocmbx.DisplayMember = "Nombre";
            forma_pagocmbx.ValueMember = "Codigo";
            forma_pagocmbx.SelectedIndex = -1;
            forma_pagocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

           
        }

        private void Ventasdtgrdvw_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
      
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            RPTFactura_venta ven = new RPTFactura_venta();
            ven.Show();
            
        }

        private void productotxt_TextChanged(object sender, EventArgs e)
        {
            if (productotxt.SelectedIndex == -1 && productotxt.Enabled == false)
            {
            }
            else if (productotxt.SelectedIndex >=0 && productotxt.Enabled == true)
            {
                int codigo_producto = int.Parse(productotxt.SelectedValue.ToString());
                DataTable valor = Lógica.Clase_Detalle_venta.valor_producto(codigo_producto);
                valor_unitariotxt.Text = valor.Rows[0][0].ToString();
            }
        }





    

    }
}
