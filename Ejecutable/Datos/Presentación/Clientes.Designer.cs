namespace Presentación
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datos_clientepnl = new System.Windows.Forms.Panel();
            this.Correoclientetxt = new System.Windows.Forms.TextBox();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.id_estado_cliente_cmb = new System.Windows.Forms.ComboBox();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Id_Estado_cliente = new System.Windows.Forms.Label();
            this.nombre_clientetxt = new System.Windows.Forms.TextBox();
            this.telefono_clientetxt = new System.Windows.Forms.TextBox();
            this.identificacion_clientetxt = new System.Windows.Forms.TextBox();
            this.Correo_clientelbl = new System.Windows.Forms.Label();
            this.telefono_clientelbl = new System.Windows.Forms.Label();
            this.Nombre_clientelbl = new System.Windows.Forms.Label();
            this.Identificacion_clientelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datos_clientelbl = new System.Windows.Forms.Label();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.codigordbtn = new MetroFramework.Controls.MetroRadioButton();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.Clientedtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.datos_clientepnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.consultar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientedtgrdvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // datos_clientepnl
            // 
            this.datos_clientepnl.BackColor = System.Drawing.SystemColors.Window;
            this.datos_clientepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datos_clientepnl.Controls.Add(this.Correoclientetxt);
            this.datos_clientepnl.Controls.Add(this.modificarbtn);
            this.datos_clientepnl.Controls.Add(this.id_estado_cliente_cmb);
            this.datos_clientepnl.Controls.Add(this.guardarbtn);
            this.datos_clientepnl.Controls.Add(this.Id_Estado_cliente);
            this.datos_clientepnl.Controls.Add(this.nombre_clientetxt);
            this.datos_clientepnl.Controls.Add(this.telefono_clientetxt);
            this.datos_clientepnl.Controls.Add(this.identificacion_clientetxt);
            this.datos_clientepnl.Controls.Add(this.Correo_clientelbl);
            this.datos_clientepnl.Controls.Add(this.telefono_clientelbl);
            this.datos_clientepnl.Controls.Add(this.Nombre_clientelbl);
            this.datos_clientepnl.Controls.Add(this.Identificacion_clientelbl);
            this.datos_clientepnl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_clientepnl.Location = new System.Drawing.Point(1, 40);
            this.datos_clientepnl.Name = "datos_clientepnl";
            this.datos_clientepnl.Size = new System.Drawing.Size(687, 137);
            this.datos_clientepnl.TabIndex = 1;
            // 
            // Correoclientetxt
            // 
            this.Correoclientetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Correoclientetxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correoclientetxt.Location = new System.Drawing.Point(413, 18);
            this.Correoclientetxt.MaxLength = 20;
            this.Correoclientetxt.Name = "Correoclientetxt";
            this.Correoclientetxt.Size = new System.Drawing.Size(156, 22);
            this.Correoclientetxt.TabIndex = 36;
            this.Correoclientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Correoclientetxt_KeyPress);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.White;
            this.modificarbtn.Image = ((System.Drawing.Image)(resources.GetObject("modificarbtn.Image")));
            this.modificarbtn.ImagePosition = 10;
            this.modificarbtn.ImageZoom = 20;
            this.modificarbtn.LabelPosition = 28;
            this.modificarbtn.LabelText = "Editar";
            this.modificarbtn.Location = new System.Drawing.Point(615, 76);
            this.modificarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(59, 51);
            this.modificarbtn.TabIndex = 35;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // id_estado_cliente_cmb
            // 
            this.id_estado_cliente_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_estado_cliente_cmb.FormattingEnabled = true;
            this.id_estado_cliente_cmb.Location = new System.Drawing.Point(417, 60);
            this.id_estado_cliente_cmb.Name = "id_estado_cliente_cmb";
            this.id_estado_cliente_cmb.Size = new System.Drawing.Size(159, 25);
            this.id_estado_cliente_cmb.TabIndex = 13;
            this.id_estado_cliente_cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_estado_cliente_cmb_KeyPress);
            // 
            // guardarbtn
            // 
            this.guardarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbtn.ForeColor = System.Drawing.Color.White;
            this.guardarbtn.Image = ((System.Drawing.Image)(resources.GetObject("guardarbtn.Image")));
            this.guardarbtn.ImagePosition = 10;
            this.guardarbtn.ImageZoom = 20;
            this.guardarbtn.LabelPosition = 28;
            this.guardarbtn.LabelText = "Guardar";
            this.guardarbtn.Location = new System.Drawing.Point(615, 15);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(59, 54);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // Id_Estado_cliente
            // 
            this.Id_Estado_cliente.AutoSize = true;
            this.Id_Estado_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Estado_cliente.Location = new System.Drawing.Point(354, 64);
            this.Id_Estado_cliente.Name = "Id_Estado_cliente";
            this.Id_Estado_cliente.Size = new System.Drawing.Size(52, 17);
            this.Id_Estado_cliente.TabIndex = 10;
            this.Id_Estado_cliente.Text = "Estado";
            // 
            // nombre_clientetxt
            // 
            this.nombre_clientetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre_clientetxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_clientetxt.Location = new System.Drawing.Point(140, 57);
            this.nombre_clientetxt.MaxLength = 40;
            this.nombre_clientetxt.Name = "nombre_clientetxt";
            this.nombre_clientetxt.Size = new System.Drawing.Size(156, 22);
            this.nombre_clientetxt.TabIndex = 9;
            this.nombre_clientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_clientetxt_KeyPress);
            // 
            // telefono_clientetxt
            // 
            this.telefono_clientetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefono_clientetxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_clientetxt.Location = new System.Drawing.Point(140, 101);
            this.telefono_clientetxt.MaxLength = 10;
            this.telefono_clientetxt.Name = "telefono_clientetxt";
            this.telefono_clientetxt.Size = new System.Drawing.Size(156, 22);
            this.telefono_clientetxt.TabIndex = 8;
            this.telefono_clientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_clientetxt_KeyPress);
            // 
            // identificacion_clientetxt
            // 
            this.identificacion_clientetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identificacion_clientetxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identificacion_clientetxt.Location = new System.Drawing.Point(140, 15);
            this.identificacion_clientetxt.MaxLength = 11;
            this.identificacion_clientetxt.Name = "identificacion_clientetxt";
            this.identificacion_clientetxt.Size = new System.Drawing.Size(156, 22);
            this.identificacion_clientetxt.TabIndex = 5;
            this.identificacion_clientetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.identificacion_clientetxt_KeyPress);
            // 
            // Correo_clientelbl
            // 
            this.Correo_clientelbl.AutoSize = true;
            this.Correo_clientelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo_clientelbl.Location = new System.Drawing.Point(354, 23);
            this.Correo_clientelbl.Name = "Correo_clientelbl";
            this.Correo_clientelbl.Size = new System.Drawing.Size(53, 17);
            this.Correo_clientelbl.TabIndex = 4;
            this.Correo_clientelbl.Text = "Correo";
            // 
            // telefono_clientelbl
            // 
            this.telefono_clientelbl.AutoSize = true;
            this.telefono_clientelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_clientelbl.Location = new System.Drawing.Point(12, 97);
            this.telefono_clientelbl.Name = "telefono_clientelbl";
            this.telefono_clientelbl.Size = new System.Drawing.Size(112, 17);
            this.telefono_clientelbl.TabIndex = 3;
            this.telefono_clientelbl.Text = "Telefono Cliente";
            // 
            // Nombre_clientelbl
            // 
            this.Nombre_clientelbl.AutoSize = true;
            this.Nombre_clientelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_clientelbl.Location = new System.Drawing.Point(12, 58);
            this.Nombre_clientelbl.Name = "Nombre_clientelbl";
            this.Nombre_clientelbl.Size = new System.Drawing.Size(111, 17);
            this.Nombre_clientelbl.TabIndex = 1;
            this.Nombre_clientelbl.Text = "Nombre Cliente";
            // 
            // Identificacion_clientelbl
            // 
            this.Identificacion_clientelbl.AutoSize = true;
            this.Identificacion_clientelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identificacion_clientelbl.Location = new System.Drawing.Point(12, 23);
            this.Identificacion_clientelbl.Name = "Identificacion_clientelbl";
            this.Identificacion_clientelbl.Size = new System.Drawing.Size(96, 17);
            this.Identificacion_clientelbl.TabIndex = 0;
            this.Identificacion_clientelbl.Text = "Identificación";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.datos_clientepnl);
            this.panel2.Location = new System.Drawing.Point(-2, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 10);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datos_clientelbl);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 27);
            this.panel1.TabIndex = 4;
            // 
            // datos_clientelbl
            // 
            this.datos_clientelbl.AutoSize = true;
            this.datos_clientelbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_clientelbl.ForeColor = System.Drawing.Color.White;
            this.datos_clientelbl.Location = new System.Drawing.Point(10, 5);
            this.datos_clientelbl.Name = "datos_clientelbl";
            this.datos_clientelbl.Size = new System.Drawing.Size(132, 20);
            this.datos_clientelbl.TabIndex = 0;
            this.datos_clientelbl.Text = "Datos del cliente";
            // 
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.codigordbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(362, 77);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(192, 23);
            this.consultar_pnl.TabIndex = 47;
            this.consultar_pnl.Visible = false;
            // 
            // Nombrerdbtn
            // 
            this.Nombrerdbtn.AutoSize = true;
            this.Nombrerdbtn.Location = new System.Drawing.Point(116, 4);
            this.Nombrerdbtn.Name = "Nombrerdbtn";
            this.Nombrerdbtn.Size = new System.Drawing.Size(67, 15);
            this.Nombrerdbtn.TabIndex = 1;
            this.Nombrerdbtn.TabStop = true;
            this.Nombrerdbtn.Text = "Nombre";
            this.Nombrerdbtn.UseVisualStyleBackColor = true;
            // 
            // codigordbtn
            // 
            this.codigordbtn.AutoSize = true;
            this.codigordbtn.Location = new System.Drawing.Point(8, 5);
            this.codigordbtn.Name = "codigordbtn";
            this.codigordbtn.Size = new System.Drawing.Size(95, 15);
            this.codigordbtn.TabIndex = 0;
            this.codigordbtn.TabStop = true;
            this.codigordbtn.Text = "Identificación";
            this.codigordbtn.UseVisualStyleBackColor = true;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarbtn.BorderRadius = 0;
            this.buscarbtn.ButtonText = "Buscar...";
            this.buscarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.buscarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.buscarbtn.Iconimage = null;
            this.buscarbtn.Iconimage_right = null;
            this.buscarbtn.Iconimage_right_Selected = null;
            this.buscarbtn.Iconimage_Selected = null;
            this.buscarbtn.IconMarginLeft = 0;
            this.buscarbtn.IconMarginRight = 0;
            this.buscarbtn.IconRightVisible = true;
            this.buscarbtn.IconRightZoom = 0D;
            this.buscarbtn.IconVisible = true;
            this.buscarbtn.IconZoom = 90D;
            this.buscarbtn.IsTab = false;
            this.buscarbtn.Location = new System.Drawing.Point(277, 77);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(79, 25);
            this.buscarbtn.TabIndex = 46;
            this.buscarbtn.Text = "Buscar...";
            this.buscarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscarbtn.Textcolor = System.Drawing.Color.White;
            this.buscarbtn.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // consultarcmbx
            // 
            this.consultarcmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.consultarcmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.consultarcmbx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarcmbx.ForeColor = System.Drawing.Color.Gray;
            this.consultarcmbx.FormattingEnabled = true;
            this.consultarcmbx.Location = new System.Drawing.Point(20, 77);
            this.consultarcmbx.Name = "consultarcmbx";
            this.consultarcmbx.Size = new System.Drawing.Size(322, 25);
            this.consultarcmbx.TabIndex = 45;
            this.consultarcmbx.TextChanged += new System.EventHandler(this.consultarcmbx_TextChanged);
            // 
            // limpiarbtn
            // 
            this.limpiarbtn.Activecolor = System.Drawing.Color.Orange;
            this.limpiarbtn.BackColor = System.Drawing.Color.Orange;
            this.limpiarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.limpiarbtn.BorderRadius = 0;
            this.limpiarbtn.ButtonText = "Limpiar";
            this.limpiarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.limpiarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.limpiarbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("limpiarbtn.Iconimage")));
            this.limpiarbtn.Iconimage_right = null;
            this.limpiarbtn.Iconimage_right_Selected = null;
            this.limpiarbtn.Iconimage_Selected = null;
            this.limpiarbtn.IconMarginLeft = 0;
            this.limpiarbtn.IconMarginRight = 0;
            this.limpiarbtn.IconRightVisible = true;
            this.limpiarbtn.IconRightZoom = 0D;
            this.limpiarbtn.IconVisible = true;
            this.limpiarbtn.IconZoom = 30D;
            this.limpiarbtn.IsTab = false;
            this.limpiarbtn.Location = new System.Drawing.Point(116, 41);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Normalcolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHovercolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarbtn.selected = false;
            this.limpiarbtn.Size = new System.Drawing.Size(89, 25);
            this.limpiarbtn.TabIndex = 44;
            this.limpiarbtn.Text = "Limpiar";
            this.limpiarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.limpiarbtn.Textcolor = System.Drawing.Color.White;
            this.limpiarbtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarbtn.Click += new System.EventHandler(this.limpiarbtn_Click);
            // 
            // nuevobtn
            // 
            this.nuevobtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuevobtn.BorderRadius = 0;
            this.nuevobtn.ButtonText = "Nuevo";
            this.nuevobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevobtn.DisabledColor = System.Drawing.Color.Gray;
            this.nuevobtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nuevobtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("nuevobtn.Iconimage")));
            this.nuevobtn.Iconimage_right = null;
            this.nuevobtn.Iconimage_right_Selected = null;
            this.nuevobtn.Iconimage_Selected = null;
            this.nuevobtn.IconMarginLeft = 0;
            this.nuevobtn.IconMarginRight = 0;
            this.nuevobtn.IconRightVisible = true;
            this.nuevobtn.IconRightZoom = 0D;
            this.nuevobtn.IconVisible = true;
            this.nuevobtn.IconZoom = 30D;
            this.nuevobtn.IsTab = false;
            this.nuevobtn.Location = new System.Drawing.Point(21, 41);
            this.nuevobtn.Name = "nuevobtn";
            this.nuevobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.nuevobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuevobtn.selected = false;
            this.nuevobtn.Size = new System.Drawing.Size(89, 25);
            this.nuevobtn.TabIndex = 43;
            this.nuevobtn.Text = "Nuevo";
            this.nuevobtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nuevobtn.Textcolor = System.Drawing.Color.White;
            this.nuevobtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevobtn.Click += new System.EventHandler(this.nuevobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Clientes";
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // Clientedtgrdvw
            // 
            this.Clientedtgrdvw.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Clientedtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Clientedtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.Clientedtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clientedtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Clientedtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Clientedtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Clientedtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Clientedtgrdvw.DefaultCellStyle = dataGridViewCellStyle3;
            this.Clientedtgrdvw.DoubleBuffered = true;
            this.Clientedtgrdvw.EnableHeadersVisualStyles = false;
            this.Clientedtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Clientedtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Clientedtgrdvw.Location = new System.Drawing.Point(54, 136);
            this.Clientedtgrdvw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clientedtgrdvw.Name = "Clientedtgrdvw";
            this.Clientedtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Clientedtgrdvw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Clientedtgrdvw.Size = new System.Drawing.Size(577, 150);
            this.Clientedtgrdvw.TabIndex = 48;
            this.Clientedtgrdvw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientedtgrdvw_CellClick);
            this.Clientedtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientedtgrdvw_CellContentClick);
            this.Clientedtgrdvw.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Clientedtgrdvw_CellPainting);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(7, 17);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 49;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 478);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Clientedtgrdvw);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.datos_clientepnl.ResumeLayout(false);
            this.datos_clientepnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clientedtgrdvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel datos_clientepnl;
        private System.Windows.Forms.TextBox nombre_clientetxt;
        private System.Windows.Forms.TextBox telefono_clientetxt;
        private System.Windows.Forms.TextBox identificacion_clientetxt;
        private System.Windows.Forms.Label Correo_clientelbl;
        private System.Windows.Forms.Label telefono_clientelbl;
        private System.Windows.Forms.Label Nombre_clientelbl;
        private System.Windows.Forms.Label Identificacion_clientelbl;
        private System.Windows.Forms.Label Id_Estado_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datos_clientelbl;
        private System.Windows.Forms.ComboBox id_estado_cliente_cmb;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private System.Windows.Forms.Panel consultar_pnl;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private MetroFramework.Controls.MetroRadioButton codigordbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer desplegartmr;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Clientedtgrdvw;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.TextBox Correoclientetxt;
    }
}