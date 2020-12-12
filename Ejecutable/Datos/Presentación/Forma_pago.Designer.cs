namespace Presentación
{
    partial class Forma_pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_pago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.id_fplbl = new System.Windows.Forms.Label();
            this.id_estado_forma_pago_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_forma_pagotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre_estadolb = new System.Windows.Forms.Label();
            this.Id_estadolb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.info_estadolb = new System.Windows.Forms.Label();
            this.Forma_pago_dtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.codigordbtn = new MetroFramework.Controls.MetroRadioButton();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.slidepnl = new System.Windows.Forms.Panel();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Forma_pago_dtgrdvw)).BeginInit();
            this.consultar_pnl.SuspendLayout();
            this.slidepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.guardarbtn);
            this.panel2.Controls.Add(this.modificarbtn);
            this.panel2.Controls.Add(this.id_fplbl);
            this.panel2.Controls.Add(this.id_estado_forma_pago_cmb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Nombre_forma_pagotxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Nombre_estadolb);
            this.panel2.Controls.Add(this.Id_estadolb);
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 110);
            this.panel2.TabIndex = 10;
            // 
            // guardarbtn
            // 
            this.guardarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(13)))), ((int)(((byte)(88)))));
            this.guardarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbtn.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbtn.ForeColor = System.Drawing.Color.White;
            this.guardarbtn.Image = ((System.Drawing.Image)(resources.GetObject("guardarbtn.Image")));
            this.guardarbtn.ImagePosition = 4;
            this.guardarbtn.ImageZoom = 30;
            this.guardarbtn.LabelPosition = 23;
            this.guardarbtn.LabelText = "Guardar";
            this.guardarbtn.Location = new System.Drawing.Point(506, 5);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(62, 44);
            this.guardarbtn.TabIndex = 34;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // modificarbtn
            // 
            this.modificarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.modificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarbtn.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarbtn.ForeColor = System.Drawing.Color.White;
            this.modificarbtn.Image = ((System.Drawing.Image)(resources.GetObject("modificarbtn.Image")));
            this.modificarbtn.ImagePosition = 4;
            this.modificarbtn.ImageZoom = 30;
            this.modificarbtn.LabelPosition = 21;
            this.modificarbtn.LabelText = "Editar";
            this.modificarbtn.Location = new System.Drawing.Point(505, 55);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(62, 44);
            this.modificarbtn.TabIndex = 35;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
            // 
            // id_fplbl
            // 
            this.id_fplbl.AutoSize = true;
            this.id_fplbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_fplbl.Location = new System.Drawing.Point(132, 27);
            this.id_fplbl.Name = "id_fplbl";
            this.id_fplbl.Size = new System.Drawing.Size(17, 17);
            this.id_fplbl.TabIndex = 7;
            this.id_fplbl.Text = "...";
            // 
            // id_estado_forma_pago_cmb
            // 
            this.id_estado_forma_pago_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_estado_forma_pago_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_estado_forma_pago_cmb.FormattingEnabled = true;
            this.id_estado_forma_pago_cmb.Location = new System.Drawing.Point(367, 62);
            this.id_estado_forma_pago_cmb.Name = "id_estado_forma_pago_cmb";
            this.id_estado_forma_pago_cmb.Size = new System.Drawing.Size(100, 25);
            this.id_estado_forma_pago_cmb.TabIndex = 6;
            this.id_estado_forma_pago_cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_estado_forma_pago_cmb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // Nombre_forma_pagotxt
            // 
            this.Nombre_forma_pagotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_forma_pagotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_forma_pagotxt.Location = new System.Drawing.Point(367, 20);
            this.Nombre_forma_pagotxt.MaxLength = 40;
            this.Nombre_forma_pagotxt.Name = "Nombre_forma_pagotxt";
            this.Nombre_forma_pagotxt.Size = new System.Drawing.Size(100, 22);
            this.Nombre_forma_pagotxt.TabIndex = 4;
            this.Nombre_forma_pagotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_forma_pagotxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(872, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "id estado";
            // 
            // Nombre_estadolb
            // 
            this.Nombre_estadolb.AutoSize = true;
            this.Nombre_estadolb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_estadolb.Location = new System.Drawing.Point(210, 27);
            this.Nombre_estadolb.Name = "Nombre_estadolb";
            this.Nombre_estadolb.Size = new System.Drawing.Size(145, 17);
            this.Nombre_estadolb.TabIndex = 1;
            this.Nombre_estadolb.Text = "Nombre Forma Pago";
            // 
            // Id_estadolb
            // 
            this.Id_estadolb.AutoSize = true;
            this.Id_estadolb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_estadolb.Location = new System.Drawing.Point(21, 25);
            this.Id_estadolb.Name = "Id_estadolb";
            this.Id_estadolb.Size = new System.Drawing.Size(105, 17);
            this.Id_estadolb.TabIndex = 0;
            this.Id_estadolb.Text = "Id Forma pago";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.info_estadolb);
            this.panel4.Location = new System.Drawing.Point(0, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 32);
            this.panel4.TabIndex = 9;
            // 
            // info_estadolb
            // 
            this.info_estadolb.AutoSize = true;
            this.info_estadolb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_estadolb.ForeColor = System.Drawing.Color.White;
            this.info_estadolb.Location = new System.Drawing.Point(21, 7);
            this.info_estadolb.Name = "info_estadolb";
            this.info_estadolb.Size = new System.Drawing.Size(277, 18);
            this.info_estadolb.TabIndex = 0;
            this.info_estadolb.Text = "Información de la forma de pago";
            // 
            // Forma_pago_dtgrdvw
            // 
            this.Forma_pago_dtgrdvw.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Forma_pago_dtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Forma_pago_dtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.Forma_pago_dtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Forma_pago_dtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Forma_pago_dtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Forma_pago_dtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Forma_pago_dtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Forma_pago_dtgrdvw.DefaultCellStyle = dataGridViewCellStyle6;
            this.Forma_pago_dtgrdvw.DoubleBuffered = true;
            this.Forma_pago_dtgrdvw.EnableHeadersVisualStyles = false;
            this.Forma_pago_dtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Forma_pago_dtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Forma_pago_dtgrdvw.Location = new System.Drawing.Point(103, 124);
            this.Forma_pago_dtgrdvw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Forma_pago_dtgrdvw.Name = "Forma_pago_dtgrdvw";
            this.Forma_pago_dtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Forma_pago_dtgrdvw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Forma_pago_dtgrdvw.Size = new System.Drawing.Size(399, 170);
            this.Forma_pago_dtgrdvw.TabIndex = 16;
            this.Forma_pago_dtgrdvw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Forma_pago_dtgrdvw_CellClick_1);
            this.Forma_pago_dtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Forma_pago_dtgrdvw_CellContentClick);
            this.Forma_pago_dtgrdvw.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Forma_pago_dtgrdvw_CellPainting);
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
            this.buscarbtn.Location = new System.Drawing.Point(268, 77);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(79, 25);
            this.buscarbtn.TabIndex = 32;
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
            this.consultarcmbx.Location = new System.Drawing.Point(25, 77);
            this.consultarcmbx.Name = "consultarcmbx";
            this.consultarcmbx.Size = new System.Drawing.Size(322, 25);
            this.consultarcmbx.TabIndex = 31;
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
            this.limpiarbtn.Location = new System.Drawing.Point(117, 43);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Normalcolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHovercolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarbtn.selected = false;
            this.limpiarbtn.Size = new System.Drawing.Size(89, 25);
            this.limpiarbtn.TabIndex = 30;
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
            this.nuevobtn.Location = new System.Drawing.Point(25, 43);
            this.nuevobtn.Name = "nuevobtn";
            this.nuevobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.nuevobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuevobtn.selected = false;
            this.nuevobtn.Size = new System.Drawing.Size(89, 25);
            this.nuevobtn.TabIndex = 29;
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
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Forma pago";
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
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.codigordbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(353, 78);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(192, 23);
            this.consultar_pnl.TabIndex = 33;
            this.consultar_pnl.Visible = false;
            // 
            // slidepnl
            // 
            this.slidepnl.Controls.Add(this.panel2);
            this.slidepnl.Controls.Add(this.panel4);
            this.slidepnl.Location = new System.Drawing.Point(0, 107);
            this.slidepnl.Name = "slidepnl";
            this.slidepnl.Size = new System.Drawing.Size(581, 10);
            this.slidepnl.TabIndex = 34;
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
            this.backbtn.TabIndex = 43;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(467, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 28);
            this.button2.TabIndex = 49;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Forma_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 492);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.slidepnl);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Forma_pago_dtgrdvw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forma_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma_pago";
            this.Load += new System.EventHandler(this.Forma_pago_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Forma_pago_dtgrdvw)).EndInit();
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            this.slidepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_forma_pagotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre_estadolb;
        private System.Windows.Forms.Label Id_estadolb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label info_estadolb;
        private System.Windows.Forms.ComboBox id_estado_forma_pago_cmb;
        private System.Windows.Forms.Label id_fplbl;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Forma_pago_dtgrdvw;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroRadioButton codigordbtn;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private System.Windows.Forms.Panel consultar_pnl;
        private System.Windows.Forms.Panel slidepnl;
        private System.Windows.Forms.Timer desplegartmr;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Button button2;
    }
}