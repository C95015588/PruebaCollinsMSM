namespace MSM
{
    partial class Menu
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
            this.buttonMultiSkills = new System.Windows.Forms.Button();
            this.buttonAdministrador = new System.Windows.Forms.Button();
            this.buttonKardex = new System.Windows.Forms.Button();
            this.buttonFechasDeCertificacionesYEntrenaminetos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBannerAdministrador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonReportePorVencer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMultiSkills
            // 
            this.buttonMultiSkills.Location = new System.Drawing.Point(27, 69);
            this.buttonMultiSkills.Name = "buttonMultiSkills";
            this.buttonMultiSkills.Size = new System.Drawing.Size(113, 31);
            this.buttonMultiSkills.TabIndex = 0;
            this.buttonMultiSkills.Text = "MultiSkills";
            this.buttonMultiSkills.UseVisualStyleBackColor = true;
            this.buttonMultiSkills.Click += new System.EventHandler(this.buttonMultiSkills_Click);
            // 
            // buttonAdministrador
            // 
            this.buttonAdministrador.Location = new System.Drawing.Point(4, 3);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(109, 55);
            this.buttonAdministrador.TabIndex = 1;
            this.buttonAdministrador.Text = "Administrador";
            this.buttonAdministrador.UseVisualStyleBackColor = true;
            this.buttonAdministrador.Visible = false;
            this.buttonAdministrador.Click += new System.EventHandler(this.buttonAdministrador_Click);
            // 
            // buttonKardex
            // 
            this.buttonKardex.Location = new System.Drawing.Point(27, 119);
            this.buttonKardex.Name = "buttonKardex";
            this.buttonKardex.Size = new System.Drawing.Size(113, 36);
            this.buttonKardex.TabIndex = 2;
            this.buttonKardex.Text = "Kardex";
            this.buttonKardex.UseVisualStyleBackColor = true;
            this.buttonKardex.Click += new System.EventHandler(this.buttonKardex_Click);
            // 
            // buttonFechasDeCertificacionesYEntrenaminetos
            // 
            this.buttonFechasDeCertificacionesYEntrenaminetos.Location = new System.Drawing.Point(4, 3);
            this.buttonFechasDeCertificacionesYEntrenaminetos.Name = "buttonFechasDeCertificacionesYEntrenaminetos";
            this.buttonFechasDeCertificacionesYEntrenaminetos.Size = new System.Drawing.Size(174, 69);
            this.buttonFechasDeCertificacionesYEntrenaminetos.TabIndex = 3;
            this.buttonFechasDeCertificacionesYEntrenaminetos.Text = "Fechas de certificaciones y entrenamientos";
            this.buttonFechasDeCertificacionesYEntrenaminetos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Certification and training dates";
            // 
            // labelBannerAdministrador
            // 
            this.labelBannerAdministrador.AutoSize = true;
            this.labelBannerAdministrador.Location = new System.Drawing.Point(23, 36);
            this.labelBannerAdministrador.Name = "labelBannerAdministrador";
            this.labelBannerAdministrador.Size = new System.Drawing.Size(67, 13);
            this.labelBannerAdministrador.TabIndex = 5;
            this.labelBannerAdministrador.Text = "Administrator";
            this.labelBannerAdministrador.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBannerAdministrador);
            this.panel1.Controls.Add(this.buttonAdministrador);
            this.panel1.Location = new System.Drawing.Point(27, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 62);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonFechasDeCertificacionesYEntrenaminetos);
            this.panel2.Location = new System.Drawing.Point(146, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 77);
            this.panel2.TabIndex = 7;
            // 
            // buttonReportePorVencer
            // 
            this.buttonReportePorVencer.Location = new System.Drawing.Point(27, 265);
            this.buttonReportePorVencer.Name = "buttonReportePorVencer";
            this.buttonReportePorVencer.Size = new System.Drawing.Size(113, 31);
            this.buttonReportePorVencer.TabIndex = 8;
            this.buttonReportePorVencer.Text = "Reporte Por Vencer";
            this.buttonReportePorVencer.UseVisualStyleBackColor = true;
            this.buttonReportePorVencer.Click += new System.EventHandler(this.buttonReportePorVencer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.buttonReportePorVencer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKardex);
            this.Controls.Add(this.buttonMultiSkills);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMultiSkills;
        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Button buttonKardex;
        private System.Windows.Forms.Button buttonFechasDeCertificacionesYEntrenaminetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBannerAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReportePorVencer;
    }
}