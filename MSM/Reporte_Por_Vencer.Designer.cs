namespace MSM
{
    partial class Reporte_Por_Vencer
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
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewReporte.Location = new System.Drawing.Point(0, 145);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(1004, 335);
            this.dataGridViewReporte.TabIndex = 0;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(105, 50);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArea.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(254, 48);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "button1";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Reporte_Por_Vencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 480);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.dataGridViewReporte);
            this.Name = "Reporte_Por_Vencer";
            this.Text = "|";
            this.Load += new System.EventHandler(this.Reporte_Por_Vencer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Button Buscar;
    }
}