namespace Presentación
{
    partial class Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.codigordbtn = new MetroFramework.Controls.MetroRadioButton();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.slidepnl = new System.Windows.Forms.Panel();
            this.infopnl = new System.Windows.Forms.Panel();
            this.info_contrato_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agregar_productobtn = new System.Windows.Forms.Button();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.numero_cargotxt = new System.Windows.Forms.Label();
            this.estadocmbx = new System.Windows.Forms.ComboBox();
            this.nombre_cargotxt = new System.Windows.Forms.TextBox();
            this.cantidad_productosdvlbl = new System.Windows.Forms.Label();
            this.Estado_cargolbl = new System.Windows.Forms.Label();
            this.Nombre_cargolbl = new System.Windows.Forms.Label();
            this.Numero_cargolbl = new System.Windows.Forms.Label();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.Cargo_dtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.consultar_pnl.SuspendLayout();
            this.slidepnl.SuspendLayout();
            this.infopnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cargo_dtgrdvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.codigordbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(354, 87);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(192, 23);
            this.consultar_pnl.TabIndex = 47;
            this.consultar_pnl.Visible = false;
            // 
            // Nombrerdbtn
            // 
            this.Nombrerdbtn.AutoSize = true;
            this.Nombrerdbtn.Location = new System.Drawing.Point(107, 5);
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
            this.codigordbtn.Location = new System.Drawing.Point(15, 5);
            this.codigordbtn.Name = "codigordbtn";
            this.codigordbtn.Size = new System.Drawing.Size(62, 15);
            this.codigordbtn.TabIndex = 0;
            this.codigordbtn.TabStop = true;
            this.codigordbtn.Text = "Codigo";
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
            this.buscarbtn.Location = new System.Drawing.Point(268, 87);
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
            this.consultarcmbx.Location = new System.Drawing.Point(17, 87);
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
            this.limpiarbtn.Location = new System.Drawing.Point(107, 51);
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
            this.nuevobtn.Location = new System.Drawing.Point(15, 51);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cargo";
            // 
            // slidepnl
            // 
            this.slidepnl.BackColor = System.Drawing.Color.White;
            this.slidepnl.Controls.Add(this.infopnl);
            this.slidepnl.Controls.Add(this.panel2);
            this.slidepnl.Location = new System.Drawing.Point(0, 118);
            this.slidepnl.Name = "slidepnl";
            this.slidepnl.Size = new System.Drawing.Size(589, 10);
            this.slidepnl.TabIndex = 40;
            this.slidepnl.Visible = false;
            // 
            // infopnl
            // 
            this.infopnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.infopnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infopnl.Controls.Add(this.info_contrato_lbl);
            this.infopnl.Location = new System.Drawing.Point(-10, 12);
            this.infopnl.Name = "infopnl";
            this.infopnl.Size = new System.Drawing.Size(599, 27);
            this.infopnl.TabIndex = 10;
            // 
            // info_contrato_lbl
            // 
            this.info_contrato_lbl.AutoSize = true;
            this.info_contrato_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_contrato_lbl.ForeColor = System.Drawing.Color.White;
            this.info_contrato_lbl.Location = new System.Drawing.Point(21, 4);
            this.info_contrato_lbl.Name = "info_contrato_lbl";
            this.info_contrato_lbl.Size = new System.Drawing.Size(113, 17);
            this.info_contrato_lbl.TabIndex = 0;
            this.info_contrato_lbl.Text = "Datos del cargo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.agregar_productobtn);
            this.panel2.Controls.Add(this.modificarbtn);
            this.panel2.Controls.Add(this.guardarbtn);
            this.panel2.Controls.Add(this.numero_cargotxt);
            this.panel2.Controls.Add(this.estadocmbx);
            this.panel2.Controls.Add(this.nombre_cargotxt);
            this.panel2.Controls.Add(this.cantidad_productosdvlbl);
            this.panel2.Controls.Add(this.Estado_cargolbl);
            this.panel2.Controls.Add(this.Nombre_cargolbl);
            this.panel2.Controls.Add(this.Numero_cargolbl);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 128);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // agregar_productobtn
            // 
            this.agregar_productobtn.FlatAppearance.BorderSize = 0;
            this.agregar_productobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_productobtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_productobtn.ForeColor = System.Drawing.Color.Lime;
            this.agregar_productobtn.Location = new System.Drawing.Point(452, 6);
            this.agregar_productobtn.Name = "agregar_productobtn";
            this.agregar_productobtn.Size = new System.Drawing.Size(34, 28);
            this.agregar_productobtn.TabIndex = 36;
            this.agregar_productobtn.Text = "+";
            this.agregar_productobtn.UseVisualStyleBackColor = true;
            this.agregar_productobtn.Click += new System.EventHandler(this.agregar_productobtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.White;
            this.modificarbtn.Image = ((System.Drawing.Image)(resources.GetObject("modificarbtn.Image")));
            this.modificarbtn.ImagePosition = 10;
            this.modificarbtn.ImageZoom = 20;
            this.modificarbtn.LabelPosition = 28;
            this.modificarbtn.LabelText = "Editar";
            this.modificarbtn.Location = new System.Drawing.Point(501, 66);
            this.modificarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(59, 51);
            this.modificarbtn.TabIndex = 35;
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
            this.guardarbtn.Location = new System.Drawing.Point(501, 5);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(59, 54);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // numero_cargotxt
            // 
            this.numero_cargotxt.AutoSize = true;
            this.numero_cargotxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_cargotxt.Location = new System.Drawing.Point(153, 17);
            this.numero_cargotxt.Name = "numero_cargotxt";
            this.numero_cargotxt.Size = new System.Drawing.Size(20, 17);
            this.numero_cargotxt.TabIndex = 10;
            this.numero_cargotxt.Text = "...";
            // 
            // estadocmbx
            // 
            this.estadocmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estadocmbx.FormattingEnabled = true;
            this.estadocmbx.Location = new System.Drawing.Point(325, 12);
            this.estadocmbx.Name = "estadocmbx";
            this.estadocmbx.Size = new System.Drawing.Size(121, 25);
            this.estadocmbx.TabIndex = 9;
            this.estadocmbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadocmbx_KeyPress);
            // 
            // nombre_cargotxt
            // 
            this.nombre_cargotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre_cargotxt.Location = new System.Drawing.Point(156, 53);
            this.nombre_cargotxt.MaxLength = 40;
            this.nombre_cargotxt.Name = "nombre_cargotxt";
            this.nombre_cargotxt.Size = new System.Drawing.Size(131, 23);
            this.nombre_cargotxt.TabIndex = 6;
            this.nombre_cargotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_cargotxt_KeyPress);
            // 
            // cantidad_productosdvlbl
            // 
            this.cantidad_productosdvlbl.AutoSize = true;
            this.cantidad_productosdvlbl.Location = new System.Drawing.Point(21, 109);
            this.cantidad_productosdvlbl.Name = "cantidad_productosdvlbl";
            this.cantidad_productosdvlbl.Size = new System.Drawing.Size(0, 17);
            this.cantidad_productosdvlbl.TabIndex = 4;
            // 
            // Estado_cargolbl
            // 
            this.Estado_cargolbl.AutoSize = true;
            this.Estado_cargolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_cargolbl.Location = new System.Drawing.Point(255, 17);
            this.Estado_cargolbl.Name = "Estado_cargolbl";
            this.Estado_cargolbl.Size = new System.Drawing.Size(52, 17);
            this.Estado_cargolbl.TabIndex = 2;
            this.Estado_cargolbl.Text = "Estado";
            // 
            // Nombre_cargolbl
            // 
            this.Nombre_cargolbl.AutoSize = true;
            this.Nombre_cargolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cargolbl.Location = new System.Drawing.Point(21, 55);
            this.Nombre_cargolbl.Name = "Nombre_cargolbl";
            this.Nombre_cargolbl.Size = new System.Drawing.Size(104, 17);
            this.Nombre_cargolbl.TabIndex = 1;
            this.Nombre_cargolbl.Text = "Nombre cargo";
            // 
            // Numero_cargolbl
            // 
            this.Numero_cargolbl.AutoSize = true;
            this.Numero_cargolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_cargolbl.Location = new System.Drawing.Point(21, 17);
            this.Numero_cargolbl.Name = "Numero_cargolbl";
            this.Numero_cargolbl.Size = new System.Drawing.Size(101, 17);
            this.Numero_cargolbl.TabIndex = 0;
            this.Numero_cargolbl.Text = "Codigo cargo";
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // Cargo_dtgrdvw
            // 
            this.Cargo_dtgrdvw.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cargo_dtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Cargo_dtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.Cargo_dtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cargo_dtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Cargo_dtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cargo_dtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Cargo_dtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargo_dtgrdvw.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cargo_dtgrdvw.DoubleBuffered = true;
            this.Cargo_dtgrdvw.EnableHeadersVisualStyles = false;
            this.Cargo_dtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Cargo_dtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Cargo_dtgrdvw.Location = new System.Drawing.Point(89, 135);
            this.Cargo_dtgrdvw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cargo_dtgrdvw.Name = "Cargo_dtgrdvw";
            this.Cargo_dtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Cargo_dtgrdvw.Size = new System.Drawing.Size(398, 155);
            this.Cargo_dtgrdvw.TabIndex = 48;
            this.Cargo_dtgrdvw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cargo_dtgrdvw_CellClick);
            this.Cargo_dtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cargo_dtgrdvw_CellContentClick_1);
            this.Cargo_dtgrdvw.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Cargo_dtgrdvw_CellPainting_1);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(7, 21);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 49;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 483);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Cargo_dtgrdvw);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slidepnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo";
            this.Load += new System.EventHandler(this.Cargo_Load);
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            this.slidepnl.ResumeLayout(false);
            this.infopnl.ResumeLayout(false);
            this.infopnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cargo_dtgrdvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel consultar_pnl;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private MetroFramework.Controls.MetroRadioButton codigordbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel slidepnl;
        private System.Windows.Forms.Panel infopnl;
        private System.Windows.Forms.Label info_contrato_lbl;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private System.Windows.Forms.Label numero_cargotxt;
        private System.Windows.Forms.ComboBox estadocmbx;
        private System.Windows.Forms.TextBox nombre_cargotxt;
        private System.Windows.Forms.Label cantidad_productosdvlbl;
        private System.Windows.Forms.Label Estado_cargolbl;
        private System.Windows.Forms.Label Nombre_cargolbl;
        private System.Windows.Forms.Label Numero_cargolbl;
        private System.Windows.Forms.Timer desplegartmr;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Cargo_dtgrdvw;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Button agregar_productobtn;

    }
}