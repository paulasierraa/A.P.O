namespace Presentación
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tipo_usuariotxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_empleadotxt = new System.Windows.Forms.ComboBox();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Id_usuariotxt = new System.Windows.Forms.Label();
            this.id_estado_usuario_cmb = new System.Windows.Forms.ComboBox();
            this.empleado_usuartiolb = new System.Windows.Forms.Label();
            this.clave_usuariotxt = new System.Windows.Forms.TextBox();
            this.Nombre_usuariotxt = new System.Windows.Forms.TextBox();
            this.rol_usuariolbl = new System.Windows.Forms.Label();
            this.clave_usuariolbl = new System.Windows.Forms.Label();
            this.nombre_usuariolbl = new System.Windows.Forms.Label();
            this.Id_usuariolbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CaracteristicasT_presentacion = new System.Windows.Forms.Label();
            this.slidepnl = new System.Windows.Forms.Panel();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.codigordbtn = new MetroFramework.Controls.MetroRadioButton();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuariodtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.slidepnl.SuspendLayout();
            this.consultar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuariodtgrdvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tipo_usuariotxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.id_empleadotxt);
            this.panel2.Controls.Add(this.modificarbtn);
            this.panel2.Controls.Add(this.guardarbtn);
            this.panel2.Controls.Add(this.Id_usuariotxt);
            this.panel2.Controls.Add(this.id_estado_usuario_cmb);
            this.panel2.Controls.Add(this.empleado_usuartiolb);
            this.panel2.Controls.Add(this.clave_usuariotxt);
            this.panel2.Controls.Add(this.Nombre_usuariotxt);
            this.panel2.Controls.Add(this.rol_usuariolbl);
            this.panel2.Controls.Add(this.clave_usuariolbl);
            this.panel2.Controls.Add(this.nombre_usuariolbl);
            this.panel2.Controls.Add(this.Id_usuariolbl);
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 152);
            this.panel2.TabIndex = 5;
            // 
            // tipo_usuariotxt
            // 
            this.tipo_usuariotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo_usuariotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_usuariotxt.FormattingEnabled = true;
            this.tipo_usuariotxt.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.tipo_usuariotxt.Location = new System.Drawing.Point(304, 21);
            this.tipo_usuariotxt.Name = "tipo_usuariotxt";
            this.tipo_usuariotxt.Size = new System.Drawing.Size(107, 25);
            this.tipo_usuariotxt.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tipo Usuario";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(416, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 50;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(417, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 28);
            this.button2.TabIndex = 49;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_empleadotxt
            // 
            this.id_empleadotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_empleadotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_empleadotxt.FormattingEnabled = true;
            this.id_empleadotxt.Location = new System.Drawing.Point(307, 87);
            this.id_empleadotxt.Name = "id_empleadotxt";
            this.id_empleadotxt.Size = new System.Drawing.Size(104, 25);
            this.id_empleadotxt.TabIndex = 38;
            this.id_empleadotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_empleadotxt_KeyPress);
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
            this.modificarbtn.Location = new System.Drawing.Point(452, 69);
            this.modificarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(59, 51);
            this.modificarbtn.TabIndex = 37;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
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
            this.guardarbtn.Location = new System.Drawing.Point(452, 8);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(59, 54);
            this.guardarbtn.TabIndex = 36;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // Id_usuariotxt
            // 
            this.Id_usuariotxt.AutoSize = true;
            this.Id_usuariotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_usuariotxt.Location = new System.Drawing.Point(130, 21);
            this.Id_usuariotxt.Name = "Id_usuariotxt";
            this.Id_usuariotxt.Size = new System.Drawing.Size(17, 17);
            this.Id_usuariotxt.TabIndex = 15;
            this.Id_usuariotxt.Text = "...";
            // 
            // id_estado_usuario_cmb
            // 
            this.id_estado_usuario_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_estado_usuario_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_estado_usuario_cmb.FormattingEnabled = true;
            this.id_estado_usuario_cmb.Location = new System.Drawing.Point(307, 56);
            this.id_estado_usuario_cmb.Name = "id_estado_usuario_cmb";
            this.id_estado_usuario_cmb.Size = new System.Drawing.Size(104, 25);
            this.id_estado_usuario_cmb.TabIndex = 14;
            this.id_estado_usuario_cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_estado_usuario_cmb_KeyPress);
            // 
            // empleado_usuartiolb
            // 
            this.empleado_usuartiolb.AutoSize = true;
            this.empleado_usuartiolb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleado_usuartiolb.Location = new System.Drawing.Point(226, 93);
            this.empleado_usuartiolb.Name = "empleado_usuartiolb";
            this.empleado_usuartiolb.Size = new System.Drawing.Size(75, 17);
            this.empleado_usuartiolb.TabIndex = 8;
            this.empleado_usuartiolb.Text = "Empleado";
            // 
            // clave_usuariotxt
            // 
            this.clave_usuariotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clave_usuariotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_usuariotxt.Location = new System.Drawing.Point(103, 80);
            this.clave_usuariotxt.MaxLength = 30;
            this.clave_usuariotxt.Name = "clave_usuariotxt";
            this.clave_usuariotxt.Size = new System.Drawing.Size(107, 22);
            this.clave_usuariotxt.TabIndex = 6;
            // 
            // Nombre_usuariotxt
            // 
            this.Nombre_usuariotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_usuariotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_usuariotxt.Location = new System.Drawing.Point(104, 49);
            this.Nombre_usuariotxt.MaxLength = 40;
            this.Nombre_usuariotxt.Name = "Nombre_usuariotxt";
            this.Nombre_usuariotxt.Size = new System.Drawing.Size(106, 22);
            this.Nombre_usuariotxt.TabIndex = 5;
            // 
            // rol_usuariolbl
            // 
            this.rol_usuariolbl.AutoSize = true;
            this.rol_usuariolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol_usuariolbl.Location = new System.Drawing.Point(226, 62);
            this.rol_usuariolbl.Name = "rol_usuariolbl";
            this.rol_usuariolbl.Size = new System.Drawing.Size(52, 17);
            this.rol_usuariolbl.TabIndex = 3;
            this.rol_usuariolbl.Text = "Estado";
            // 
            // clave_usuariolbl
            // 
            this.clave_usuariolbl.AutoSize = true;
            this.clave_usuariolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_usuariolbl.Location = new System.Drawing.Point(13, 87);
            this.clave_usuariolbl.Name = "clave_usuariolbl";
            this.clave_usuariolbl.Size = new System.Drawing.Size(47, 17);
            this.clave_usuariolbl.TabIndex = 2;
            this.clave_usuariolbl.Text = "Clave";
            // 
            // nombre_usuariolbl
            // 
            this.nombre_usuariolbl.AutoSize = true;
            this.nombre_usuariolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_usuariolbl.Location = new System.Drawing.Point(13, 50);
            this.nombre_usuariolbl.Name = "nombre_usuariolbl";
            this.nombre_usuariolbl.Size = new System.Drawing.Size(61, 17);
            this.nombre_usuariolbl.TabIndex = 1;
            this.nombre_usuariolbl.Text = "Nombre";
            // 
            // Id_usuariolbl
            // 
            this.Id_usuariolbl.AutoSize = true;
            this.Id_usuariolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_usuariolbl.Location = new System.Drawing.Point(24, 21);
            this.Id_usuariolbl.Name = "Id_usuariolbl";
            this.Id_usuariolbl.Size = new System.Drawing.Size(20, 17);
            this.Id_usuariolbl.TabIndex = 0;
            this.Id_usuariolbl.Text = "Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.CaracteristicasT_presentacion);
            this.panel3.Location = new System.Drawing.Point(0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 29);
            this.panel3.TabIndex = 14;
            // 
            // CaracteristicasT_presentacion
            // 
            this.CaracteristicasT_presentacion.AutoSize = true;
            this.CaracteristicasT_presentacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaracteristicasT_presentacion.ForeColor = System.Drawing.Color.White;
            this.CaracteristicasT_presentacion.Location = new System.Drawing.Point(12, 6);
            this.CaracteristicasT_presentacion.Name = "CaracteristicasT_presentacion";
            this.CaracteristicasT_presentacion.Size = new System.Drawing.Size(192, 21);
            this.CaracteristicasT_presentacion.TabIndex = 1;
            this.CaracteristicasT_presentacion.Text = "Información del Usuario";
            // 
            // slidepnl
            // 
            this.slidepnl.Controls.Add(this.panel3);
            this.slidepnl.Controls.Add(this.panel2);
            this.slidepnl.Location = new System.Drawing.Point(0, 117);
            this.slidepnl.Name = "slidepnl";
            this.slidepnl.Size = new System.Drawing.Size(521, 10);
            this.slidepnl.TabIndex = 18;
            this.slidepnl.Visible = false;
            // 
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.codigordbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(344, 82);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(136, 23);
            this.consultar_pnl.TabIndex = 45;
            this.consultar_pnl.Visible = false;
            // 
            // Nombrerdbtn
            // 
            this.Nombrerdbtn.AutoSize = true;
            this.Nombrerdbtn.Location = new System.Drawing.Point(59, 5);
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
            this.codigordbtn.Location = new System.Drawing.Point(20, 5);
            this.codigordbtn.Name = "codigordbtn";
            this.codigordbtn.Size = new System.Drawing.Size(33, 15);
            this.codigordbtn.TabIndex = 0;
            this.codigordbtn.TabStop = true;
            this.codigordbtn.Text = "Id";
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
            this.buscarbtn.Location = new System.Drawing.Point(259, 81);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(79, 25);
            this.buscarbtn.TabIndex = 44;
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
            this.consultarcmbx.Location = new System.Drawing.Point(16, 81);
            this.consultarcmbx.Name = "consultarcmbx";
            this.consultarcmbx.Size = new System.Drawing.Size(322, 25);
            this.consultarcmbx.TabIndex = 43;
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
            this.limpiarbtn.Location = new System.Drawing.Point(108, 43);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Normalcolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHovercolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarbtn.selected = false;
            this.limpiarbtn.Size = new System.Drawing.Size(89, 25);
            this.limpiarbtn.TabIndex = 42;
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
            this.nuevobtn.Location = new System.Drawing.Point(16, 43);
            this.nuevobtn.Name = "nuevobtn";
            this.nuevobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.nuevobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuevobtn.selected = false;
            this.nuevobtn.Size = new System.Drawing.Size(89, 25);
            this.nuevobtn.TabIndex = 41;
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
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Usuarios";
            // 
            // Usuariodtgrdvw
            // 
            this.Usuariodtgrdvw.AllowUserToAddRows = false;
            this.Usuariodtgrdvw.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Usuariodtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuariodtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.Usuariodtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuariodtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Usuariodtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuariodtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Usuariodtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuariodtgrdvw.DefaultCellStyle = dataGridViewCellStyle3;
            this.Usuariodtgrdvw.DoubleBuffered = true;
            this.Usuariodtgrdvw.EnableHeadersVisualStyles = false;
            this.Usuariodtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Usuariodtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Usuariodtgrdvw.Location = new System.Drawing.Point(0, 133);
            this.Usuariodtgrdvw.Name = "Usuariodtgrdvw";
            this.Usuariodtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Usuariodtgrdvw.Size = new System.Drawing.Size(518, 87);
            this.Usuariodtgrdvw.TabIndex = 46;
            this.Usuariodtgrdvw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuariodtgrdvw_CellClick);
            this.Usuariodtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuariodtgrdvw_CellContentClick);
            this.Usuariodtgrdvw.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Usuariodtgrdvw_CellPainting);
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(12, 15);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 47;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 428);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Usuariodtgrdvw);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slidepnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.slidepnl.ResumeLayout(false);
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuariodtgrdvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label empleado_usuartiolb;
        private System.Windows.Forms.TextBox clave_usuariotxt;
        private System.Windows.Forms.TextBox Nombre_usuariotxt;
        private System.Windows.Forms.Label rol_usuariolbl;
        private System.Windows.Forms.Label clave_usuariolbl;
        private System.Windows.Forms.Label nombre_usuariolbl;
        private System.Windows.Forms.Label Id_usuariolbl;
        private System.Windows.Forms.ComboBox id_estado_usuario_cmb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Id_usuariotxt;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private System.Windows.Forms.Panel slidepnl;
        private System.Windows.Forms.Label CaracteristicasT_presentacion;
        private System.Windows.Forms.Panel consultar_pnl;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private MetroFramework.Controls.MetroRadioButton codigordbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Usuariodtgrdvw;
        private System.Windows.Forms.ComboBox id_empleadotxt;
        private System.Windows.Forms.Timer desplegartmr;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipo_usuariotxt;
    }
}