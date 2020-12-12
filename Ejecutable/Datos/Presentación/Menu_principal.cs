using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Presentación
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(entrada_pnl, 5);
            Bunifu.Framework.Lib.Elipse.Apply(total_pnl, 5);
            Bunifu.Framework.Lib.Elipse.Apply(bunifuGradientPanel3, 5);
            if (Program.acceso == 2)
            {
                sistema_conpng.Visible = false;
                entrada_dinerolbl.Visible = false;
                total_capitallbl.Visible = false;
                salida_dinerolbl.Visible = false;
            }
        }

        private void next_Tick(object sender, EventArgs e)
        {
            if (menu1_pnl.Width >= 163)
            {
                next.Stop();
            }
            else
            {
                menu1_pnl.Width += 50;
            }

        }

        private void back_Tick(object sender, EventArgs e)
        {
            if (menu1_pnl.Width <= 2)
            {
                back.Stop();
            }
            else
            {
                menu1_pnl.Width -= 50;
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
          
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

            ajustespnl.Visible = false;
            DataTable entrada = Lógica.Clase_entrada_salida_dinero.entrada_dinero();
            entrada_dinerolbl.Text = entrada.Rows[0][0].ToString();

            DataTable capital = Lógica.Clase_entrada_salida_dinero.total_capital();
            total_capitallbl.Text = capital.Rows[0][0].ToString();

            DataTable salida = Lógica.Clase_entrada_salida_dinero.salida_dinero();
            salidalbl.Text = salida.Rows[0][0].ToString();

            
         
        }
        private void sistema_conpng_Click(object sender, EventArgs e)
        {
            if (ajustespnl.Visible == false)
            {

                ajustespnl.Visible = true;
            }
            else
            {
                ajustespnl.Visible = false;
            }
        }

        private void Garantiasbtn_Click(object sender, EventArgs e)
        {



        }

        private void productosbtn_Click(object sender, EventArgs e)
        {
    
        }

        private void controlbtn_Click(object sender, EventArgs e)
        {
            if (menu1_pnl.Width >= 163)
            {
                back.Start();

            

            }
            else if (menu1_pnl.Width <= 2)
            {
                next.Start();
            
            }
        }

        private void sistema_conpng_Click_1(object sender, EventArgs e)
        {
            ajustespnl.Visible = true;
        }

        private void productosbtn_Click_1(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Productos prod = new Productos();
            prod.TopLevel = false;
            prod.Dock = DockStyle.Fill;
            this.mostrar.Controls.Add(prod);
            prod.Show();
        }

        private void ventasbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Ventas ventas = new Ventas();
            ventas.TopLevel = false;
            ventas.Location = new Point(161, 12);
            this.mostrar.Controls.Add(ventas);
            ventas.Show();
        }

        private void Estadobtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Estado estado = new Estado();
            estado.TopLevel = false;
            estado.Location = new Point(322, 6);
            this.mostrar.Controls.Add(estado);
            estado.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Compras compras = new Compras();
            compras.TopLevel = false;
            compras.Location = new Point(161, 12);
            this.mostrar.Controls.Add(compras);
            compras.Show();
            
        }

        private void proveedoresbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Proveedores prov = new Proveedores();
            prov.TopLevel = false;
            prov.Location = new Point(106, 9);
            mostrar.Controls.Add(prov);
            prov.Show();
        }

        private void inventariobtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Inventario inventario = new Inventario();
            inventario.TopLevel = false;
            inventario.Location = new Point(257, 6);
            mostrar.Controls.Add(inventario);
            inventario.Show();
        }

        private void bodegabtn_Click(object sender, EventArgs e)
        {
  
        }

        private void t_presentacionbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Tipo_presentacion tp = new Tipo_presentacion();
            tp.TopLevel = false;
            tp.Location = new Point(303, 3);
            mostrar.Controls.Add(tp);
            tp.Show();
        }

        private void Garantiasbtn_Click_1(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Garantías garantia = new Garantías();
            garantia.TopLevel = false;
            garantia.Location = new Point(303, 3);
            mostrar.Controls.Add(garantia);
            garantia.Show();
        }

        private void forma_pagobtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Forma_pago fp = new Forma_pago();
            fp.TopLevel = false;
            fp.Location = new Point(303,3);
            mostrar.Controls.Add(fp);
            fp.Show();
        }

        private void clientesbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Clientes clientes = new Clientes();
            clientes.TopLevel = false;
            clientes.Location = new Point(295, 6);
            mostrar.Controls.Add(clientes);
            clientes.Show();
        }

        private void empleadosbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Empleados empleado = new Empleados();
            empleado.TopLevel = false;
            empleado.Location = new Point(34, 6);
            mostrar.Controls.Add(empleado);
            empleado.Show();

        }

        private void Cargosbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Cargo cargo = new Cargo();
            cargo.TopLevel = false;
            cargo.Location = new Point(305, 6);
            mostrar.Controls.Add(cargo);
            cargo.Show();
        }

        private void contratosbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Contrato contrato = new Contrato();
            contrato.TopLevel = false;
            contrato.Location = new Point(305,6);
            mostrar.Controls.Add(contrato);
            contrato.Show();

        }

        private void usuariosbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Usuarios usuario = new Usuarios();
            usuario.TopLevel = false;
            usuario.Location = new Point(305,6);
            mostrar.Controls.Add(usuario);
            usuario.Show();
        }

        private void devolcionbtn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Devolucion_producto dv = new Devolucion_producto();
            dv.TopLevel = false;
            dv.Location = new Point(181, 13);
            mostrar.Controls.Add(dv);
            dv.Show();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            mostrar.Controls.Clear();
            mostrar.Controls.Add(salida_dinerolbl);
            salida_dinerolbl.Show();

            DataTable entrada = Lógica.Clase_entrada_salida_dinero.entrada_dinero();
            entrada_dinerolbl.Text = entrada.Rows[0][0].ToString();

            DataTable capital = Lógica.Clase_entrada_salida_dinero.total_capital();
            total_capitallbl.Text = capital.Rows[0][0].ToString();

            DataTable salida = Lógica.Clase_entrada_salida_dinero.salida_dinero();
            salidalbl.Text = salida.Rows[0][0].ToString();
        }

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión cerrada con éxito");
            Iniciar_Sesión inicio = new Iniciar_Sesión();
            inicio.Show();
            this.Hide();
        }

        private void reportes_btn_Click(object sender, EventArgs e)
        {
            mostrar.BackColor = Color.White;
            mostrar.Controls.Clear();
            Reportes rep = new Reportes();
            rep.TopLevel = false;
            rep.Location = new Point(390, 18);
            this.mostrar.Controls.Add(rep);
            rep.Show();
        }

   
 


     






     
    }
}
