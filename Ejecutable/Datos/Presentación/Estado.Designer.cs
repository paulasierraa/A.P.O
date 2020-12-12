namespace Presentación
{
    partial class Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.info_estadolb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.id_Estadolbl = new System.Windows.Forms.Label();
            this.Nombre_Estadotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre_estadolb = new System.Windows.Forms.Label();
            this.Id_estadolb = new System.Windows.Forms.Label();
            this.Estado_dtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.idrdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.slidepnl = new System.Windows.Forms.Panel();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estado_dtgrdvw)).BeginInit();
            this.consultar_pnl.SuspendLayout();
            this.slidepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.info_estadolb);
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 33);
            this.panel4.TabIndex = 4;
            // 
            // info_estadolb
            // 
            this.info_estadolb.AutoSize = true;
            this.info_estadolb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_estadolb.ForeColor = System.Drawing.Color.White;
            this.info_estadolb.Location = new System.Drawing.Point(23, 6);
            this.info_estadolb.Name = "info_estadolb";
            this.info_estadolb.Size = new System.Drawing.Size(191, 21);
            this.info_estadolb.TabIndex = 0;
            this.info_estadolb.Text = "Información del estado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.modificarbtn);
            this.panel2.Controls.Add(this.guardarbtn);
            this.panel2.Controls.Add(this.id_Estadolbl);
            this.panel2.Controls.Add(this.Nombre_Estadotxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Nombre_estadolb);
            this.panel2.Controls.Add(this.Id_estadolb);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 98);
            this.panel2.TabIndex = 5;
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
            this.modificarbtn.Location = new System.Drawing.Point(446, 49);
            this.modificarbtn.Name = "modificarbtn";
            this.modificarbtn.Size = new System.Drawing.Size(62, 44);
            this.modificarbtn.TabIndex = 33;
            this.modificarbtn.Click += new System.EventHandler(this.modificarbtn_Click);
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
            this.guardarbtn.Location = new System.Drawing.Point(446, 3);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(62, 44);
            this.guardarbtn.TabIndex = 32;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // id_Estadolbl
            // 
            this.id_Estadolbl.AutoSize = true;
            this.id_Estadolbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Estadolbl.Location = new System.Drawing.Point(211, 17);
            this.id_Estadolbl.Name = "id_Estadolbl";
            this.id_Estadolbl.Size = new System.Drawing.Size(17, 17);
            this.id_Estadolbl.TabIndex = 5;
            this.id_Estadolbl.Text = "...";
            // 
            // Nombre_Estadotxt
            // 
            this.Nombre_Estadotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_Estadotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Estadotxt.Location = new System.Drawing.Point(203, 49);
            this.Nombre_Estadotxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nombre_Estadotxt.MaxLength = 40;
            this.Nombre_Estadotxt.Name = "Nombre_Estadotxt";
            this.Nombre_Estadotxt.Size = new System.Drawing.Size(116, 22);
            this.Nombre_Estadotxt.TabIndex = 4;
            this.Nombre_Estadotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_Estadotxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1017, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "id estado";
            // 
            // Nombre_estadolb
            // 
            this.Nombre_estadolb.AutoSize = true;
            this.Nombre_estadolb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_estadolb.Location = new System.Drawing.Point(127, 54);
            this.Nombre_estadolb.Name = "Nombre_estadolb";
            this.Nombre_estadolb.Size = new System.Drawing.Size(61, 17);
            this.Nombre_estadolb.TabIndex = 1;
            this.Nombre_estadolb.Text = "Nombre";
            // 
            // Id_estadolb
            // 
            this.Id_estadolb.AutoSize = true;
            this.Id_estadolb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_estadolb.Location = new System.Drawing.Point(127, 17);
            this.Id_estadolb.Name = "Id_estadolb";
            this.Id_estadolb.Size = new System.Drawing.Size(69, 17);
            this.Id_estadolb.TabIndex = 0;
            this.Id_estadolb.Text = "Id estado";
            // 
            // Estado_dtgrdvw
            // 
            this.Estado_dtgrdvw.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Estado_dtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Estado_dtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.Estado_dtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Estado_dtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Estado_dtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado_dtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Estado_dtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado_dtgrdvw.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado_dtgrdvw.DoubleBuffered = true;
            this.Estado_dtgrdvw.EnableHeadersVisualStyles = false;
            this.Estado_dtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Estado_dtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Estado_dtgrdvw.Location = new System.Drawing.Point(109, 138);
            this.Estado_dtgrdvw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Estado_dtgrdvw.Name = "Estado_dtgrdvw";
            this.Estado_dtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Estado_dtgrdvw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Estado_dtgrdvw.Size = new System.Drawing.Size(305, 150);
            this.Estado_dtgrdvw.TabIndex = 15;
            this.Estado_dtgrdvw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Estado_dtgrdvw_CellClick);
            this.Estado_dtgrdvw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Estado_dtgrdvw_CellContentClick);
            this.Estado_dtgrdvw.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Estado_dtgrdvw_CellPainting);
            // 
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.idrdbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(249, 87);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(192, 23);
            this.consultar_pnl.TabIndex = 33;
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
            // idrdbtn
            // 
            this.idrdbtn.AutoSize = true;
            this.idrdbtn.Location = new System.Drawing.Point(15, 5);
            this.idrdbtn.Name = "idrdbtn";
            this.idrdbtn.Size = new System.Drawing.Size(33, 15);
            this.idrdbtn.TabIndex = 0;
            this.idrdbtn.TabStop = true;
            this.idrdbtn.Text = "Id";
            this.idrdbtn.UseVisualStyleBackColor = true;
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
            this.buscarbtn.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buscarbtn.Location = new System.Drawing.Point(161, 86);
            this.buscarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(85, 25);
            this.buscarbtn.TabIndex = 32;
            this.buscarbtn.Text = "Buscar...";
            this.buscarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscarbtn.Textcolor = System.Drawing.Color.White;
            this.buscarbtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // consultarcmbx
            // 
            this.consultarcmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.consultarcmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.consultarcmbx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarcmbx.ForeColor = System.Drawing.Color.Gray;
            this.consultarcmbx.FormattingEnabled = true;
            this.consultarcmbx.Location = new System.Drawing.Point(22, 85);
            this.consultarcmbx.Name = "consultarcmbx";
            this.consultarcmbx.Size = new System.Drawing.Size(224, 25);
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
            this.limpiarbtn.Location = new System.Drawing.Point(133, 44);
            this.limpiarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Normalcolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHovercolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarbtn.selected = false;
            this.limpiarbtn.Size = new System.Drawing.Size(98, 25);
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
            this.nuevobtn.Location = new System.Drawing.Point(29, 44);
            this.nuevobtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuevobtn.Name = "nuevobtn";
            this.nuevobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.nuevobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuevobtn.selected = false;
            this.nuevobtn.Size = new System.Drawing.Size(98, 25);
            this.nuevobtn.TabIndex = 29;
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
            this.label1.Location = new System.Drawing.Point(37, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estado";
            // 
            // slidepnl
            // 
            this.slidepnl.Controls.Add(this.panel2);
            this.slidepnl.Controls.Add(this.panel4);
            this.slidepnl.Location = new System.Drawing.Point(2, 121);
            this.slidepnl.Name = "slidepnl";
            this.slidepnl.Size = new System.Drawing.Size(548, 10);
            this.slidepnl.TabIndex = 34;
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(16, 20);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 43;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 452);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.slidepnl);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estado_dtgrdvw);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Estado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado";
            this.Load += new System.EventHandler(this.Estado_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estado_dtgrdvw)).EndInit();
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            this.slidepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label info_estadolb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Nombre_Estadotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre_estadolb;
        private System.Windows.Forms.Label Id_estadolb;
        private System.Windows.Forms.Label id_Estadolbl;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Estado_dtgrdvw;
        private System.Windows.Forms.Panel consultar_pnl;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private MetroFramework.Controls.MetroRadioButton idrdbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel slidepnl;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private System.Windows.Forms.Timer desplegartmr;
        private System.Windows.Forms.PictureBox backbtn;
    }
}