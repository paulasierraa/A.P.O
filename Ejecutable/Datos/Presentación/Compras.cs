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
    public partial class Compras : Form
    {
        Lógica.Validacion Obj_validacion = new Validacion();
        Lógica.Clase_mensajes obj_mensajes = new Clase_mensajes();
        Lógica.Clase_Estado obj_Estado = new Clase_Estado();
        public Compras()
        {
            
            InitializeComponent();
        }

      public long Total_entrada;
      public long entrada;
        void Limpiar()
        {

            productocmb.Text = "";
            valor_unitario_compratxt.Text = "";
            cantidad_productos_compratxt.Text = "";
        
        }
        void limpiar_datos()
        {
            Numero_Factxt.Text = "";
            fecha_compratxt.Text = "";
            estadocmbx.Text = "";
            proveedorcmbx.Text = "";
            forma_pagocmbx.Text = "";
            numero_Factura_proveedortxt.Text = "";
        }

        private void Codigo_compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Cantidad_productos_compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void Nombre_productos_compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void proveedor_Compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void Valor_unitariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void numero_Facturatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void id_detalle_Factxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void fecha_facturaCtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras_numeros_simbolos(e);
        }

        private void id_empleadofac_compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void proveedor_comtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }


        private void cantidad_productos_compratxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void valor_unitario_compratxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
        }

        private void agregar_productobtn_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Show();
        }


   

        private void Compras_Load(object sender, EventArgs e)
        {
            DataTable com = Datos.Estado.Llenar_grilla();
            DataTable emple = Datos.Empleado.llenar_grilla_empleado();
            DataTable proveedor = Datos.Proveedores.llenar_grilla_proveedores();
            DataTable forma_pago = Datos.Forma_pago.llenar_grilla_fp();
            DataTable producto = Datos.Productos.llenar_grilla_productos();
            DataTable compra = Datos.Compras.llenar_compra();

            estadocmbx.DataSource = com;
            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            empleadotxt.DataSource = emple;
            empleadotxt.DisplayMember = "Nombre";
            empleadotxt.ValueMember = "Identificación";
            empleadotxt.SelectedIndex = -1;
            empleadotxt.DropDownStyle = ComboBoxStyle.DropDownList;

            proveedorcmbx.DataSource = proveedor;
            proveedorcmbx.DisplayMember = "Nombre";
            proveedorcmbx.ValueMember = "Codigo";
            proveedorcmbx.SelectedIndex = -1;
            proveedorcmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            forma_pagocmbx.DataSource = forma_pago;
            forma_pagocmbx.DisplayMember = "Nombre";
            forma_pagocmbx.ValueMember = "Codigo";
            forma_pagocmbx.SelectedIndex = -1;
            forma_pagocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

            productocmb.DataSource = producto;
            productocmb.DisplayMember = "Nombre";
            productocmb.ValueMember = "Codigo";
            productocmb.DropDownStyle = ComboBoxStyle.DropDownList;
            productocmb.SelectedIndex = -1;
           

            Comprasdtgrdvw.DataSource = compra;

               
        }



        private void numero_Factura_proveedortxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_num(e);
        }

        private void forma_pagocmbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Obj_validacion.Vali_letras(e);
        }

        private void proveedorcmbx_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guardar_detallebtn_Click(object sender, EventArgs e)
        {
            if (productocmb.Text == "" || cantidad_productos_compratxt.Text == "" || valor_unitario_compratxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    long subtotal_C = 0;
                    long iva_c = 0;
                    long total_fac_C = 0;
                    Lógica.Clase_detalle_Compra ing_detalle = new Clase_detalle_Compra();
                    int producto = int.Parse(productocmb.SelectedValue.ToString());
                    long valor_unitario = long.Parse(valor_unitario_compratxt.Text);
                    int cantidad_compra = int.Parse(cantidad_productos_compratxt.Text);
                    long subtotal = valor_unitario * cantidad_compra;
                    int numero_Factura = int.Parse(Numero_Factxt.Text);
                    int resultado = ing_detalle.ingresar_Detalle_compra(producto,valor_unitario,cantidad_compra,subtotal,numero_Factura);
                    if (resultado > 0)
                    {
                    obj_mensajes.Agregar();
                    DataTable id_dt = Lógica.Clase_detalle_Compra.identitycompra();
                    id_Detallelbl.Text = id_dt.Rows[0][0].ToString();
                    Detalle_dtgrdvw.Rows.Add(id_Detallelbl.Text ,productocmb.Text,valor_unitario,cantidad_compra,subtotal);

                    foreach (DataGridViewRow row in Detalle_dtgrdvw.Rows)
                    {
                        subtotal_C += Convert.ToInt64(row.Cells["Subtotalclm"].Value);

                    }
                    subtotaltxt.Text = subtotal_C.ToString();
                    iva_c = subtotal_C * 19 / 100;
                    ivatxt.Text = iva_c.ToString();
                    total_fac_C = subtotal_C + iva_c;
                    Totaltxt.Text = total_fac_C.ToString();
                    Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            if (empleadotxt.Text == "" || numero_Factura_proveedortxt.Text == "" || proveedorcmbx.Text == "" || forma_pagocmbx.Text == "" || estadocmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_compras insertar = new Clase_compras();
                    int numero_factura_proveedor = int.Parse(numero_Factura_proveedortxt.Text);
                    long subtotal = 0;
                    string fecha_facturac = fecha_compratxt.Text;
                    long valor_factura = 0;
                    long iva_factura = 0;
                    int id_empleadofc = int.Parse(empleadotxt.SelectedValue.ToString());
                    int codigo_proveedorfc = int.Parse(proveedorcmbx.SelectedValue.ToString());
                    int estadofc = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_fp_fc = int.Parse(forma_pagocmbx.SelectedValue.ToString());

                    int resultado = insertar.IngresarCompras(numero_factura_proveedor,subtotal,fecha_facturac,valor_factura,iva_factura,id_empleadofc,codigo_proveedorfc,estadofc,id_fp_fc);
                    if (resultado > 0)
                    {
                        obj_mensajes.Agregar();
                        DataTable nu_facc = Lógica.Clase_compras.Identitycompra();
                        Numero_Factxt.Text = nu_facc.Rows[0][0].ToString();
                        detallepnl.Enabled = true;
                        Detalle_dtgrdvw.Enabled = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (Numero_Factxt.Text == ""||Numero_Factxt.Text == "..."||empleadotxt.Text == "" || numero_Factura_proveedortxt.Text == "" || proveedorcmbx.Text == "" || forma_pagocmbx.Text == "" || estadocmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_compras modificar = new Clase_compras();
                    int numero_factura_proveedor = int.Parse(numero_Factura_proveedortxt.Text);
                    long subtotal = 0;
                    string fecha_facturac = fecha_compratxt.Text;
                    long valor_factura = 0;
                    long iva_factura = 0;
                    int id_empleadofc = int.Parse(empleadotxt.SelectedValue.ToString());
                    int codigo_proveedorfc = int.Parse(proveedorcmbx.SelectedValue.ToString());
                    int estadofc = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_fp_fc = int.Parse(forma_pagocmbx.SelectedValue.ToString());
                    int numero_Fac_c = int.Parse(Numero_Factxt.Text);
                    int resultado = modificar.ModificarCompras(numero_Fac_c,numero_factura_proveedor, subtotal, fecha_facturac, valor_factura, iva_factura, id_empleadofc, codigo_proveedorfc, estadofc, id_fp_fc);
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

        private void Detalle_dtgrdvw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Detalle_dtgrdvw.Columns[e.ColumnIndex].Name == "eliminar")
            {
                long subtotal_v = 0;
                long iva_v = 0;
                long total_facv = 0;
                Lógica.Clase_detalle_Compra dtv = new Clase_detalle_Compra();
                int pocision = Detalle_dtgrdvw.CurrentRow.Index;
                int id_Detalle = int.Parse(Detalle_dtgrdvw[0, pocision].Value.ToString());
                int resultado = dtv.EliminarDetalleCompra(id_Detalle);
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

        private void editar_Detallebtn_Click(object sender, EventArgs e)
        {
            if (productocmb.Text == "" || cantidad_productos_compratxt.Text == "" || valor_unitario_compratxt.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    long subtotal_C = 0;
                    long iva_c = 0;
                    long total_fac_C = 0;
                    Lógica.Clase_detalle_Compra ing_detalle = new Clase_detalle_Compra();
                    int producto = int.Parse(productocmb.SelectedValue.ToString());
                    long valor_unitario = long.Parse(valor_unitario_compratxt.Text);
                    int cantidad_compra = int.Parse(cantidad_productos_compratxt.Text);
                    long subtotal = valor_unitario * cantidad_compra;
                    int numero_Factura = int.Parse(Numero_Factxt.Text);
                    int id_Detalle = int.Parse(id_Detallelbl.Text);
                    int resultado = ing_detalle.ModificarDetalleCompra(id_Detalle,producto, valor_unitario, cantidad_compra, subtotal, numero_Factura);
                    if (resultado > 0)
                    {
                        int posicion = Detalle_dtgrdvw.CurrentRow.Index;
                        obj_mensajes.Modificar();
                        Detalle_dtgrdvw[1, posicion].Value = productocmb.Text;
                        Detalle_dtgrdvw[2, posicion].Value = long.Parse(valor_unitario_compratxt.Text);
                        Detalle_dtgrdvw[3, posicion].Value = int.Parse(cantidad_productos_compratxt.Text);
                        foreach (DataGridViewRow row in Detalle_dtgrdvw.Rows)
                        {
                            subtotal_C += Convert.ToInt64(row.Cells["Subtotalclm"].Value);

                        }
                        subtotaltxt.Text = subtotal_C.ToString();
                        iva_c = subtotal_C * 19 / 100;
                        ivatxt.Text = iva_c.ToString();
                        total_fac_C = subtotal_C + iva_c;
                        Totaltxt.Text = total_fac_C.ToString();
                        Limpiar();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Detalle_dtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = Detalle_dtgrdvw.CurrentRow.Index;
            id_Detallelbl.Text = Detalle_dtgrdvw[0, pocision].Value.ToString();
            productocmb.Text = Detalle_dtgrdvw[1, pocision].Value.ToString();
            valor_unitario_compratxt.Text = Detalle_dtgrdvw[2, pocision].Value.ToString();
            cantidad_productos_compratxt.Text = Detalle_dtgrdvw[3, pocision].Value.ToString();
        }

        private void generar_facturabtn_Click(object sender, EventArgs e)
        {
            if (Numero_Factxt.Text == "" || Numero_Factxt.Text == "..." || empleadotxt.Text == "" || numero_Factura_proveedortxt.Text == "" || proveedorcmbx.Text == "" || forma_pagocmbx.Text == "" || estadocmbx.Text == "")
            {
                obj_mensajes.Campos_vacios();
            }
            else
            {
                try
                {
                    Lógica.Clase_compras modificar = new Clase_compras();
                    int numero_factura_proveedor = int.Parse(numero_Factura_proveedortxt.Text);
                    long subtotal = long.Parse(subtotaltxt.Text);
                    string fecha_facturac = fecha_compratxt.Text;
                    long valor_factura = long.Parse(Totaltxt.Text);
                    long iva_factura = long.Parse(ivatxt.Text);
                    int id_empleadofc = int.Parse(empleadotxt.SelectedValue.ToString());
                    int codigo_proveedorfc = int.Parse(proveedorcmbx.SelectedValue.ToString());
                    int estadofc = int.Parse(estadocmbx.SelectedValue.ToString());
                    int id_fp_fc = int.Parse(forma_pagocmbx.SelectedValue.ToString());
                    int numero_Fac_c = int.Parse(Numero_Factxt.Text);
                    int resultado = modificar.ModificarCompras(numero_Fac_c, numero_factura_proveedor, subtotal, fecha_facturac, valor_factura, iva_factura, id_empleadofc, codigo_proveedorfc, estadofc, id_fp_fc);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Factura Generada Con Éxito!");     
                        DataTable compras = Lógica.Clase_compras.llenarcompra();
                        Comprasdtgrdvw.DataSource = compras;
                        limpiar_datos();
                        detallepnl.Enabled = false;
                        Detalle_dtgrdvw.Enabled = false;
                        Detalle_dtgrdvw.Rows.Clear();
                        subtotaltxt.Text = "...";
                        ivatxt.Text = "...";
                        Totaltxt.Text = "...";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Comprasdtgrdvw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_dtgrdvw.Columns.Clear();
                Numero_Factxt.Text = Comprasdtgrdvw.CurrentRow.Cells["No"].Value.ToString();
                numero_Factura_proveedortxt.Text = Comprasdtgrdvw.CurrentRow.Cells["No Proveedor"].Value.ToString();
                fecha_compratxt.Text = Comprasdtgrdvw.CurrentRow.Cells["Fecha"].Value.ToString();
                proveedorcmbx.Text = Comprasdtgrdvw.CurrentRow.Cells["Proveedor"].Value.ToString();
                empleadotxt.Text = Comprasdtgrdvw.CurrentRow.Cells["Empleado"].Value.ToString();
                forma_pagocmbx.Text = Comprasdtgrdvw.CurrentRow.Cells["Forma Pago"].Value.ToString();
                estadocmbx.Text = Comprasdtgrdvw.CurrentRow.Cells["Estado"].Value.ToString();
                subtotaltxt.Text = Comprasdtgrdvw.CurrentRow.Cells["Subtotal"].Value.ToString();
                ivatxt.Text = Comprasdtgrdvw.CurrentRow.Cells["Iva"].Value.ToString();
                Totaltxt.Text = Comprasdtgrdvw.CurrentRow.Cells["Valor Factura"].Value.ToString();
            int nu_Fac = int.Parse(Numero_Factxt.Text);
            DataTable dgv = Lógica.Clase_detalle_Compra.consultadetalle(nu_Fac);
            Detalle_dtgrdvw.DataSource = dgv;
      
            detallepnl.Enabled = false;
            guardar_detallebtn.Enabled = false;
            editar_Detallebtn.Enabled = false;
            generar_facturabtn.Enabled = false;
            guardarbtn.Enabled = false;
            
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            string fecha = fecha_consultadtp.Text;
           DataTable consulta = Lógica.Clase_compras.Buscar_comprafecha(fecha);
           Comprasdtgrdvw.DataSource = consulta;
        }

        private void reloadpctb_Click(object sender, EventArgs e)
        {
            DataTable compras = Lógica.Clase_compras.llenarcompra();
            Comprasdtgrdvw.DataSource = compras;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DataTable forma_pago = Lógica.Clase_forma_pago.llenargrillafp();
            forma_pagocmbx.DataSource = forma_pago;
            forma_pagocmbx.DisplayMember = "Nombre";
            forma_pagocmbx.ValueMember = "Codigo";
            forma_pagocmbx.SelectedIndex = -1;
            forma_pagocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

         
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estado es = new Estado();
            es.Show();

            DataTable est = Lógica.Clase_Estado.llenargrilla();

            estadocmbx.DisplayMember = "Nombre";
            estadocmbx.ValueMember = "Id";
            estadocmbx.SelectedIndex = -1;
            estadocmbx.DropDownStyle = ComboBoxStyle.DropDownList;

           

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            RPTFactura_compra fcom = new RPTFactura_compra();
            fcom.Show();
        }


        private void productocmb_TextChanged(object sender, EventArgs e)
        {
            if (productocmb.SelectedIndex == -1 && productocmb.Enabled == false)
            {

            }
            else if (productocmb.SelectedIndex >= 0 && productocmb.Enabled == true )
            {
                int codigo_producto = int.Parse(productocmb.SelectedValue.ToString());
                DataTable valor = Lógica.Clase_detalle_Compra.valor_produc(codigo_producto);
                valor_unitario_compratxt.Text = valor.Rows[0][0].ToString();
            }
        }

    

   

      
    }
}
