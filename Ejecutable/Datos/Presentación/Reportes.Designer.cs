namespace Presentación
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.desplegartmr = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.datos_clientepnl = new System.Windows.Forms.Panel();
            this.general_rdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.especifica_rdbtn = new MetroFramework.Controls.MetroRadioButton();
            this.generar_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_consulta = new System.Windows.Forms.ComboBox();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.datos_clientepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // desplegartmr
            // 
            this.desplegartmr.Tick += new System.EventHandler(this.desplegartmr_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.datos_clientepnl);
            this.panel2.Location = new System.Drawing.Point(6, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 162);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_consulta);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 27);
            this.panel1.TabIndex = 4;
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consulta.ForeColor = System.Drawing.Color.White;
            this.lbl_consulta.Location = new System.Drawing.Point(15, 3);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(73, 20);
            this.lbl_consulta.TabIndex = 0;
            this.lbl_consulta.Text = "Consulta";
            // 
            // datos_clientepnl
            // 
            this.datos_clientepnl.BackColor = System.Drawing.SystemColors.Window;
            this.datos_clientepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datos_clientepnl.Controls.Add(this.general_rdbtn);
            this.datos_clientepnl.Controls.Add(this.especifica_rdbtn);
            this.datos_clientepnl.Controls.Add(this.generar_btn);
            this.datos_clientepnl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_clientepnl.Location = new System.Drawing.Point(1, 40);
            this.datos_clientepnl.Name = "datos_clientepnl";
            this.datos_clientepnl.Size = new System.Drawing.Size(407, 100);
            this.datos_clientepnl.TabIndex = 1;
            // 
            // general_rdbtn
            // 
            this.general_rdbtn.AutoSize = true;
            this.general_rdbtn.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.general_rdbtn.Location = new System.Drawing.Point(50, 26);
            this.general_rdbtn.Name = "general_rdbtn";
            this.general_rdbtn.Size = new System.Drawing.Size(72, 19);
            this.general_rdbtn.TabIndex = 3;
            this.general_rdbtn.TabStop = true;
            this.general_rdbtn.Text = "General";
            this.general_rdbtn.UseVisualStyleBackColor = true;
            // 
            // especifica_rdbtn
            // 
            this.especifica_rdbtn.AutoSize = true;
            this.especifica_rdbtn.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.especifica_rdbtn.Location = new System.Drawing.Point(50, 55);
            this.especifica_rdbtn.Name = "especifica_rdbtn";
            this.especifica_rdbtn.Size = new System.Drawing.Size(82, 19);
            this.especifica_rdbtn.TabIndex = 2;
            this.especifica_rdbtn.TabStop = true;
            this.especifica_rdbtn.Text = "Especifica";
            this.especifica_rdbtn.UseVisualStyleBackColor = true;
            // 
            // generar_btn
            // 
            this.generar_btn.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.generar_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.generar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generar_btn.BorderRadius = 0;
            this.generar_btn.ButtonText = "Generar";
            this.generar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generar_btn.DisabledColor = System.Drawing.Color.Gray;
            this.generar_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.generar_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("generar_btn.Iconimage")));
            this.generar_btn.Iconimage_right = null;
            this.generar_btn.Iconimage_right_Selected = null;
            this.generar_btn.Iconimage_Selected = null;
            this.generar_btn.IconMarginLeft = 0;
            this.generar_btn.IconMarginRight = 0;
            this.generar_btn.IconRightVisible = true;
            this.generar_btn.IconRightZoom = 0D;
            this.generar_btn.IconVisible = true;
            this.generar_btn.IconZoom = 30D;
            this.generar_btn.IsTab = false;
            this.generar_btn.Location = new System.Drawing.Point(232, 26);
            this.generar_btn.Name = "generar_btn";
            this.generar_btn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.generar_btn.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.generar_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.generar_btn.selected = false;
            this.generar_btn.Size = new System.Drawing.Size(109, 39);
            this.generar_btn.TabIndex = 55;
            this.generar_btn.Text = "Generar";
            this.generar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generar_btn.Textcolor = System.Drawing.Color.White;
            this.generar_btn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar_btn.Click += new System.EventHandler(this.generar_btn_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.BorderRadius = 0;
            this.btn_buscar.ButtonText = "Consultar";
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_buscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_buscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Iconimage")));
            this.btn_buscar.Iconimage_right = null;
            this.btn_buscar.Iconimage_right_Selected = null;
            this.btn_buscar.Iconimage_Selected = null;
            this.btn_buscar.IconMarginLeft = 0;
            this.btn_buscar.IconMarginRight = 0;
            this.btn_buscar.IconRightVisible = true;
            this.btn_buscar.IconRightZoom = 0D;
            this.btn_buscar.IconVisible = true;
            this.btn_buscar.IconZoom = 30D;
            this.btn_buscar.IsTab = false;
            this.btn_buscar.Location = new System.Drawing.Point(276, 74);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btn_buscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(169)))));
            this.btn_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscar.selected = false;
            this.btn_buscar.Size = new System.Drawing.Size(94, 25);
            this.btn_buscar.TabIndex = 60;
            this.btn_buscar.Text = "Consultar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscar.Textcolor = System.Drawing.Color.White;
            this.btn_buscar.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Reporte";
            // 
            // cmb_consulta
            // 
            this.cmb_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_consulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_consulta.FormattingEnabled = true;
            this.cmb_consulta.Items.AddRange(new object[] {
            "Empleados",
            "Clientes",
            "Productos"});
            this.cmb_consulta.Location = new System.Drawing.Point(132, 75);
            this.cmb_consulta.Name = "cmb_consulta";
            this.cmb_consulta.Size = new System.Drawing.Size(138, 24);
            this.cmb_consulta.TabIndex = 58;
            // 
            // backbtn
            // 
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(14, 26);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(22, 15);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbtn.TabIndex = 57;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Reportes";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 322);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_consulta);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.datos_clientepnl.ResumeLayout(false);
            this.datos_clientepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer desplegartmr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.Panel datos_clientepnl;
        private Bunifu.Framework.UI.BunifuFlatButton generar_btn;
        private MetroFramework.Controls.MetroRadioButton especifica_rdbtn;
        private Bunifu.Framework.UI.BunifuFlatButton btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_consulta;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroRadioButton general_rdbtn;
    }
}