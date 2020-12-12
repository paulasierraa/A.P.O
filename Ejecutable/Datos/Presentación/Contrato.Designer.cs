namespace Presentación
{
    partial class Contrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fecha_fin_dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_iniciodtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modificarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.guardarbtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.numero_contratotxt = new System.Windows.Forms.Label();
            this.duracion_contratotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valor_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.id_estado_contrato_cmb = new System.Windows.Forms.ComboBox();
            this.nombre_contratotxt = new System.Windows.Forms.TextBox();
            this.cantidad_productosdvlbl = new System.Windows.Forms.Label();
            this.Estado_contrato = new System.Windows.Forms.Label();
            this.numero_facturalbl = new System.Windows.Forms.Label();
            this.Numero_contratolbl = new System.Windows.Forms.Label();
            this.panel_des = new System.Windows.Forms.Panel();
            this.consultar_pnl = new System.Windows.Forms.Panel();
            this.Nombrerdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.codigordbtn = new MetroFramework.Controls.MetroRadioButton();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consultarcmbx = new System.Windows.Forms.ComboBox();
            this.limpiarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuevobtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.Contratoftgrdview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel_des.SuspendLayout();
            this.consultar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contratoftgrdview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.fecha_fin_dtp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fecha_iniciodtp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.modificarbtn);
            this.panel2.Controls.Add(this.guardarbtn);
            this.panel2.Controls.Add(this.numero_contratotxt);
            this.panel2.Controls.Add(this.duracion_contratotxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.valor_txt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.id_estado_contrato_cmb);
            this.panel2.Controls.Add(this.nombre_contratotxt);
            this.panel2.Controls.Add(this.cantidad_productosdvlbl);
            this.panel2.Controls.Add(this.Estado_contrato);
            this.panel2.Controls.Add(this.numero_facturalbl);
            this.panel2.Controls.Add(this.Numero_contratolbl);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 166);
            this.panel2.TabIndex = 13;
            // 
            // fecha_fin_dtp
            // 
            this.fecha_fin_dtp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_fin_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fin_dtp.Location = new System.Drawing.Point(372, 18);
            this.fecha_fin_dtp.Name = "fecha_fin_dtp";
            this.fecha_fin_dtp.Size = new System.Drawing.Size(121, 22);
            this.fecha_fin_dtp.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha Fin";
            // 
            // fecha_iniciodtp
            // 
            this.fecha_iniciodtp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_iniciodtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_iniciodtp.Location = new System.Drawing.Point(148, 96);
            this.fecha_iniciodtp.Name = "fecha_iniciodtp";
            this.fecha_iniciodtp.Size = new System.Drawing.Size(118, 22);
            this.fecha_iniciodtp.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Fecha Inicio";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(491, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 28);
            this.button1.TabIndex = 48;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.modificarbtn.Location = new System.Drawing.Point(520, 72);
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
            this.guardarbtn.Location = new System.Drawing.Point(520, 11);
            this.guardarbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarbtn.Name = "guardarbtn";
            this.guardarbtn.Size = new System.Drawing.Size(59, 54);
            this.guardarbtn.TabIndex = 36;
            this.guardarbtn.Click += new System.EventHandler(this.guardarbtn_Click);
            // 
            // numero_contratotxt
            // 
            this.numero_contratotxt.AutoSize = true;
            this.numero_contratotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_contratotxt.Location = new System.Drawing.Point(147, 19);
            this.numero_contratotxt.Name = "numero_contratotxt";
            this.numero_contratotxt.Size = new System.Drawing.Size(17, 17);
            this.numero_contratotxt.TabIndex = 13;
            this.numero_contratotxt.Text = "...";
            // 
            // duracion_contratotxt
            // 
            this.duracion_contratotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duracion_contratotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracion_contratotxt.Location = new System.Drawing.Point(145, 132);
            this.duracion_contratotxt.MaxLength = 40;
            this.duracion_contratotxt.Name = "duracion_contratotxt";
            this.duracion_contratotxt.Size = new System.Drawing.Size(121, 22);
            this.duracion_contratotxt.TabIndex = 12;
            this.duracion_contratotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.duracion_contratotxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Duración ";
            // 
            // valor_txt
            // 
            this.valor_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valor_txt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor_txt.Location = new System.Drawing.Point(372, 58);
            this.valor_txt.MaxLength = 15;
            this.valor_txt.Name = "valor_txt";
            this.valor_txt.Size = new System.Drawing.Size(121, 22);
            this.valor_txt.TabIndex = 10;
            this.valor_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_txt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor";
            // 
            // id_estado_contrato_cmb
            // 
            this.id_estado_contrato_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_estado_contrato_cmb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_estado_contrato_cmb.FormattingEnabled = true;
            this.id_estado_contrato_cmb.Location = new System.Drawing.Point(372, 93);
            this.id_estado_contrato_cmb.Name = "id_estado_contrato_cmb";
            this.id_estado_contrato_cmb.Size = new System.Drawing.Size(118, 25);
            this.id_estado_contrato_cmb.TabIndex = 8;
            this.id_estado_contrato_cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_estado_contrato_cmb_KeyPress);
            // 
            // nombre_contratotxt
            // 
            this.nombre_contratotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre_contratotxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_contratotxt.Location = new System.Drawing.Point(148, 56);
            this.nombre_contratotxt.MaxLength = 40;
            this.nombre_contratotxt.Name = "nombre_contratotxt";
            this.nombre_contratotxt.Size = new System.Drawing.Size(118, 22);
            this.nombre_contratotxt.TabIndex = 6;
            this.nombre_contratotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_contratotxt_KeyPress);
            // 
            // cantidad_productosdvlbl
            // 
            this.cantidad_productosdvlbl.AutoSize = true;
            this.cantidad_productosdvlbl.Location = new System.Drawing.Point(21, 109);
            this.cantidad_productosdvlbl.Name = "cantidad_productosdvlbl";
            this.cantidad_productosdvlbl.Size = new System.Drawing.Size(0, 21);
            this.cantidad_productosdvlbl.TabIndex = 4;
            // 
            // Estado_contrato
            // 
            this.Estado_contrato.AutoSize = true;
            this.Estado_contrato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_contrato.Location = new System.Drawing.Point(303, 96);
            this.Estado_contrato.Name = "Estado_contrato";
            this.Estado_contrato.Size = new System.Drawing.Size(52, 17);
            this.Estado_contrato.TabIndex = 2;
            this.Estado_contrato.Text = "Estado";
            // 
            // numero_facturalbl
            // 
            this.numero_facturalbl.AutoSize = true;
            this.numero_facturalbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_facturalbl.Location = new System.Drawing.Point(14, 58);
            this.numero_facturalbl.Name = "numero_facturalbl";
            this.numero_facturalbl.Size = new System.Drawing.Size(122, 17);
            this.numero_facturalbl.TabIndex = 1;
            this.numero_facturalbl.Text = "Nombre contrato";
            // 
            // Numero_contratolbl
            // 
            this.Numero_contratolbl.AutoSize = true;
            this.Numero_contratolbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_contratolbl.Location = new System.Drawing.Point(16, 18);
            this.Numero_contratolbl.Name = "Numero_contratolbl";
            this.Numero_contratolbl.Size = new System.Drawing.Size(84, 17);
            this.Numero_contratolbl.TabIndex = 0;
            this.Numero_contratolbl.Text = "N° contrato";
            // 
            // panel_des
            // 
            this.panel_des.BackColor = System.Drawing.Color.White;
            this.panel_des.Controls.Add(this.panel2);
            this.panel_des.Location = new System.Drawing.Point(-1, 114);
            this.panel_des.Name = "panel_des";
            this.panel_des.Size = new System.Drawing.Size(595, 10);
            this.panel_des.TabIndex = 18;
            this.panel_des.Visible = false;
            // 
            // consultar_pnl
            // 
            this.consultar_pnl.Controls.Add(this.Nombrerdbtn);
            this.consultar_pnl.Controls.Add(this.codigordbtn);
            this.consultar_pnl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_pnl.Location = new System.Drawing.Point(353, 77);
            this.consultar_pnl.Name = "consultar_pnl";
            this.consultar_pnl.Size = new System.Drawing.Size(192, 23);
            this.consultar_pnl.TabIndex = 53;
            this.consultar_pnl.Visible = false;
            // 
            // Nombrerdbtn
            // 
            this.Nombrerdbtn.AutoSize = true;
            this.Nombrerdbtn.Location = new System.Drawing.Point(98, 5);
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
            this.buscarbtn.Location = new System.Drawing.Point(254, 77);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(79, 25);
            this.buscarbtn.TabIndex = 52;
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
            this.consultarcmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarcmbx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarcmbx.ForeColor = System.Drawing.Color.Gray;
            this.consultarcmbx.FormattingEnabled = true;
            this.consultarcmbx.Location = new System.Drawing.Point(11, 77);
            this.consultarcmbx.Name = "consultarcmbx";
            this.consultarcmbx.Size = new System.Drawing.Size(322, 25);
            this.consultarcmbx.TabIndex = 51;
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
            this.limpiarbtn.Location = new System.Drawing.Point(107, 41);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Normalcolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHovercolor = System.Drawing.Color.Orange;
            this.limpiarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.limpiarbtn.selected = false;
            this.limpiarbtn.Size = new System.Drawing.Size(89, 25);
            this.limpiarbtn.TabIndex = 50;
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
            this.nuevobtn.Location = new System.Drawing.Point(12, 41);
            this.nuevobtn.Name = "nuevobtn";
            this.nuevobtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.nuevobtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.nuevobtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuevobtn.selected = false;
            this.nuevobtn.Size = new System.Drawing.Size(89, 25);
            this.nuevobtn.TabIndex = 49;
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
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Contrato";
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // Contratoftgrdview
            // 
            this.Contratoftgrdview.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Contratoftgrdview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Contratoftgrdview.BackgroundColor = System.Drawing.Color.White;
            this.Contratoftgrdview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contratoftgrdview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Contratoftgrdview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contratoftgrdview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Contratoftgrdview.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Contratoftgrdview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Contratoftgrdview.DoubleBuffered = true;
            this.Contratoftgrdview.EnableHeadersVisualStyles = false;
            this.Contratoftgrdview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.Contratoftgrdview.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.Contratoftgrdview.Location = new System.Drawing.Point(11, 133);
            this.Contratoftgrdview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Contratoftgrdview.Name = "Contratoftgrdview";
            this.Contratoftgrdview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Contratoftgrdview.Size = new System.Drawing.Size(570, 112);
            this.Contratoftgrdview.TabIndex = 54;
            this.Contratoftgrdview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contratoftgrdview_CellClick);
            this.Contratoftgrdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contratoftgrdview_CellContentClick);
            this.Contratoftgrdview.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Contratoftgrdview_CellPainting);
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(4, 13);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 55;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 501);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Contratoftgrdview);
            this.Controls.Add(this.consultar_pnl);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.consultarcmbx);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.nuevobtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_des);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.Contrato_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_des.ResumeLayout(false);
            this.consultar_pnl.ResumeLayout(false);
            this.consultar_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contratoftgrdview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nombre_contratotxt;
        private System.Windows.Forms.Label cantidad_productosdvlbl;
        private System.Windows.Forms.Label Estado_contrato;
        private System.Windows.Forms.Label numero_facturalbl;
        private System.Windows.Forms.Label Numero_contratolbl;
        private System.Windows.Forms.Panel panel_des;
        private System.Windows.Forms.ComboBox id_estado_contrato_cmb;
        private System.Windows.Forms.TextBox valor_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox duracion_contratotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numero_contratotxt;
        private Bunifu.Framework.UI.BunifuTileButton modificarbtn;
        private Bunifu.Framework.UI.BunifuTileButton guardarbtn;
        private System.Windows.Forms.Panel consultar_pnl;
        private MetroFramework.Controls.MetroRadioButton Nombrerdbtn;
        private MetroFramework.Controls.MetroRadioButton codigordbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private System.Windows.Forms.ComboBox consultarcmbx;
        private Bunifu.Framework.UI.BunifuFlatButton limpiarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuevobtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer desplegartmr;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Contratoftgrdview;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha_iniciodtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_fin_dtp;
        private System.Windows.Forms.Label label4;
    }
}