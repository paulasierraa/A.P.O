namespace Presentación
{
    partial class Cliente_general
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_general));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RptCliente_general1 = new Presentación.RptCliente_general();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cerrar_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 23);
            this.panel1.TabIndex = 1;
            // 
            // cerrar_btn
            // 
            this.cerrar_btn.BackColor = System.Drawing.Color.White;
            this.cerrar_btn.Image = ((System.Drawing.Image)(resources.GetObject("cerrar_btn.Image")));
            this.cerrar_btn.ImageActive = null;
            this.cerrar_btn.Location = new System.Drawing.Point(1079, 3);
            this.cerrar_btn.Name = "cerrar_btn";
            this.cerrar_btn.Size = new System.Drawing.Size(30, 16);
            this.cerrar_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_btn.TabIndex = 1;
            this.cerrar_btn.TabStop = false;
            this.cerrar_btn.Zoom = 10;
            this.cerrar_btn.Click += new System.EventHandler(this.cerrar_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 23);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RptCliente_general1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1110, 508);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // Cliente_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 531);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_general";
            this.Text = "Cliente_general";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton cerrar_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private RptCliente_general RptCliente_general1;
    }
}