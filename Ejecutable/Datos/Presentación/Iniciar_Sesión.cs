using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lógica;
using System.Data.SqlClient;
namespace Presentación
{

   
        public partial class Iniciar_Sesión : Form
        {
            Clase_usuario obj_usuario = new Clase_usuario();
            Clase_cargo obj_Cargo = new Clase_cargo();
            Clase_mensajes obj_mensajes = new Clase_mensajes();
      
            public Iniciar_Sesión()
            {
              
                
                InitializeComponent();
            
            }
            
        
          

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (registerpnl.Width <= 10)
                {
                    timer1.Stop();
                }
                else
                {
                    registerpnl.Width -= 30;
                }
            }

            private void timer_Tick(object sender, EventArgs e)
            {
                if (registerpnl.Width >= 342)
                {
                    timer.Stop();
                    

                }
                else
                {
                    registerpnl.Width += 30;
                }
            
            }

            private void agregar_btn_Click(object sender, EventArgs e)
            {
                if (registerpnl.Width <= 10)
                {
                    timer.Start();
                    
 
                }
                else if (registerpnl.Width >= 342)
                {
                    timer1.Start();
                }
       
            }

            private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
            {

            }

            private void bunifuFlatButton1_Click(object sender, EventArgs e)
            {
                
                if (usuariotxt.Text == "" || clavetxt.Text == "" )
                {
                    obj_mensajes.Campos_vacios();
                }
                else
                {

                    try
                    {

                        string usuario = usuariotxt.Text;
                        string clave = clavetxt.Text;
                        string rol = rolcmbx.Text;
                        DataTable inicio = Lógica.Clase_usuario.logeo(usuario,clave,rol);
                        if (inicio.Rows.Count == 1 )
                        {
                                
                            if (inicio.Rows[0][2].ToString() == "Administrador")
                            {
                                Program.acceso = 1;
                                Mensaje_bienvenidos msg = new Mensaje_bienvenidos();
                                msg.Show();
                                this.Hide();
                            }
                          
                  
                            else  if (inicio.Rows[0][2].ToString() == "Vendedor")
                            {
                                Program.acceso = 2;
                                Menu_principal menu = new Menu_principal();
                                menu.sistema_conpng.Visible = false;
                                Mensaje_bienvenidos msg = new Mensaje_bienvenidos();
                                msg.Show();
                                this.Hide();
                            }
                        }

                      
                        else 
                        {
                            MessageBox.Show("Verifique su usuario y contraseña");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                }
           
            }

            private void Iniciar_Sesión_Load(object sender, EventArgs e)
            {
                rolcmbx.DropDownStyle = ComboBoxStyle.DropDownList;
           
            }

            private void registrarbtn_Click(object sender, EventArgs e)
            {
                if (register_usuarioitxt.Text == "" || register_clavetxt.Text == "" || emailtxt.Text == "" || empleadotxt.Text == "")
                {
                    obj_mensajes.Campos_vacios();
                }
                else
                {
                    try
                    {
                        Lógica.Clase_usuario insertar = new Clase_usuario();
                        string Usuario = register_usuarioitxt.Text;
                        string clave = register_clavetxt.Text;
                        int id_estado = 1;
                        string tipo_usuario = "Vendedor";
                        int empleado = int.Parse(empleadotxt.Text);
                        int resultado = insertar.ingresar_usuario(Usuario,clave,tipo_usuario,id_estado,empleado);
                        if (resultado > 0 )
                        {
                            MessageBox.Show("Usuario registrado con éxito");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
             
            }

            private void verpcbx_Click(object sender, EventArgs e)
            {
                register_clavetxt.isPassword = false;
                clavetxt.isPassword = false;

            }

            private void verpcbx_DoubleClick(object sender, EventArgs e)
            {
                register_clavetxt.isPassword = true;
                clavetxt.isPassword = true;
            }

         
        }
    }
