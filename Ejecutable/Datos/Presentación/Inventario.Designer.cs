namespace Presentación
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.inventariodtgrdvw = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.reloadpctb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buscartxt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.no_buscartxt = new System.Windows.Forms.TextBox();
            this.fecha_consultadtp = new System.Windows.Forms.DateTimePicker();
            this.buscarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buscar_fechatxt = new MetroFramework.Controls.MetroRadioButton();
            this.buscar_numerotxt = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventariodtgrdvw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadpctb)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Inventario";
            // 
            // inventariodtgrdvw
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inventariodtgrdvw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventariodtgrdvw.BackgroundColor = System.Drawing.Color.White;
            this.inventariodtgrdvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventariodtgrdvw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventariodtgrdvw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventariodtgrdvw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventariodtgrdvw.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventariodtgrdvw.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventariodtgrdvw.DoubleBuffered = true;
            this.inventariodtgrdvw.EnableHeadersVisualStyles = false;
            this.inventariodtgrdvw.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.inventariodtgrdvw.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(96)))), ((int)(((byte)(90)))));
            this.inventariodtgrdvw.Location = new System.Drawing.Point(-2, 144);
            this.inventariodtgrdvw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventariodtgrdvw.Name = "inventariodtgrdvw";
            this.inventariodtgrdvw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventariodtgrdvw.Size = new System.Drawing.Size(697, 174);
            this.inventariodtgrdvw.TabIndex = 40;
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(20, 15);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 43;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // reloadpctb
            // 
            this.reloadpctb.BackColor = System.Drawing.Color.White;
            this.reloadpctb.Image = ((System.Drawing.Image)(resources.GetObject("reloadpctb.Image")));
            this.reloadpctb.Location = new System.Drawing.Point(354, 87);
            this.reloadpctb.Name = "reloadpctb";
            this.reloadpctb.Size = new System.Drawing.Size(32, 25);
            this.reloadpctb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reloadpctb.TabIndex = 56;
            this.reloadpctb.TabStop = false;
            this.reloadpctb.Click += new System.EventHandler(this.reloadpctb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buscartxt);
            this.panel2.Controls.Add(this.no_buscartxt);
            this.panel2.Controls.Add(this.fecha_consultadtp);
            this.panel2.Location = new System.Drawing.Point(36, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 55);
            this.panel2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Consultar ";
            // 
            // buscartxt
            // 
            this.buscartxt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscartxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscartxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscartxt.BorderRadius = 0;
            this.buscartxt.ButtonText = "Buscar";
            this.buscartxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscartxt.DisabledColor = System.Drawing.Color.Gray;
            this.buscartxt.Iconcolor = System.Drawing.Color.Transparent;
            this.buscartxt.Iconimage = null;
            this.buscartxt.Iconimage_right = null;
            this.buscartxt.Iconimage_right_Selected = null;
            this.buscartxt.Iconimage_Selected = null;
            this.buscartxt.IconMarginLeft = 0;
            this.buscartxt.IconMarginRight = 0;
            this.buscartxt.IconRightVisible = false;
            this.buscartxt.IconRightZoom = 0D;
            this.buscartxt.IconVisible = false;
            this.buscartxt.IconZoom = 90D;
            this.buscartxt.IsTab = false;
            this.buscartxt.Location = new System.Drawing.Point(209, 14);
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscartxt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscartxt.OnHoverTextColor = System.Drawing.Color.White;
            this.buscartxt.selected = false;
            this.buscartxt.Size = new System.Drawing.Size(79, 25);
            this.buscartxt.TabIndex = 53;
            this.buscartxt.Text = "Buscar";
            this.buscartxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscartxt.Textcolor = System.Drawing.Color.White;
            this.buscartxt.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscartxt.Click += new System.EventHandler(this.buscartxt_Click);
            // 
            // no_buscartxt
            // 
            this.no_buscartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.no_buscartxt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_buscartxt.Location = new System.Drawing.Point(98, 15);
            this.no_buscartxt.MaxLength = 10;
            this.no_buscartxt.Name = "no_buscartxt";
            this.no_buscartxt.Size = new System.Drawing.Size(105, 22);
            this.no_buscartxt.TabIndex = 52;
            this.no_buscartxt.Visible = false;
            this.no_buscartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.no_buscartxt_KeyPress);
            // 
            // fecha_consultadtp
            // 
            this.fecha_consultadtp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_consultadtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_consultadtp.Location = new System.Drawing.Point(98, 15);
            this.fecha_consultadtp.Name = "fecha_consultadtp";
            this.fecha_consultadtp.Size = new System.Drawing.Size(105, 23);
            this.fecha_consultadtp.TabIndex = 48;
            this.fecha_consultadtp.Value = new System.DateTime(2018, 9, 1, 11, 37, 47, 0);
            this.fecha_consultadtp.Visible = false;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarbtn.BorderRadius = 0;
            this.buscarbtn.ButtonText = "Buscar";
            this.buscarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarbtn.DisabledColor = System.Drawing.Color.Gray;
            this.buscarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.buscarbtn.Iconimage = null;
            this.buscarbtn.Iconimage_right = null;
            this.buscarbtn.Iconimage_right_Selected = null;
            this.buscarbtn.Iconimage_Selected = null;
            this.buscarbtn.IconMarginLeft = 0;
            this.buscarbtn.IconMarginRight = 0;
            this.buscarbtn.IconRightVisible = false;
            this.buscarbtn.IconRightZoom = 0D;
            this.buscarbtn.IconVisible = false;
            this.buscarbtn.IconZoom = 90D;
            this.buscarbtn.IsTab = false;
            this.buscarbtn.Location = new System.Drawing.Point(36, 41);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.buscarbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buscarbtn.selected = false;
            this.buscarbtn.Size = new System.Drawing.Size(79, 25);
            this.buscarbtn.TabIndex = 50;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buscarbtn.Textcolor = System.Drawing.Color.White;
            this.buscarbtn.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // buscar_fechatxt
            // 
            this.buscar_fechatxt.AutoSize = true;
            this.buscar_fechatxt.Location = new System.Drawing.Point(128, 44);
            this.buscar_fechatxt.Name = "buscar_fechatxt";
            this.buscar_fechatxt.Size = new System.Drawing.Size(54, 15);
            this.buscar_fechatxt.TabIndex = 57;
            this.buscar_fechatxt.TabStop = true;
            this.buscar_fechatxt.Text = "Fecha";
            this.buscar_fechatxt.UseVisualStyleBackColor = true;
            // 
            // buscar_numerotxt
            // 
            this.buscar_numerotxt.AutoSize = true;
            this.buscar_numerotxt.Location = new System.Drawing.Point(201, 44);
            this.buscar_numerotxt.Name = "buscar_numerotxt";
            this.buscar_numerotxt.Size = new System.Drawing.Size(67, 15);
            this.buscar_numerotxt.TabIndex = 58;
            this.buscar_numerotxt.TabStop = true;
            this.buscar_numerotxt.Text = "Numero";
            this.buscar_numerotxt.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 392);
            this.Controls.Add(this.buscar_numerotxt);
            this.Controls.Add(this.buscar_fechatxt);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.reloadpctb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.inventariodtgrdvw);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventariodtgrdvw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reloadpctb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid inventariodtgrdvw;
        private System.Windows.Forms.Timer desplegartmr;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.PictureBox reloadpctb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton buscarbtn;
        private Bunifu.Framework.UI.BunifuFlatButton buscartxt;
        private System.Windows.Forms.TextBox no_buscartxt;
        private MetroFramework.Controls.MetroRadioButton buscar_fechatxt;
        private MetroFramework.Controls.MetroRadioButton buscar_numerotxt;
        private System.Windows.Forms.DateTimePicker fecha_consultadtp;
    }
}