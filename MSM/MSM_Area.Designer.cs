namespace MSM
{
    partial class MSM_Area
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
            this.dataGridViewMultiskill = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiskill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMultiskill
            // 
            this.dataGridViewMultiskill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMultiskill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMultiskill.Location = new System.Drawing.Point(0, 72);
            this.dataGridViewMultiskill.Name = "dataGridViewMultiskill";
            this.dataGridViewMultiskill.Size = new System.Drawing.Size(1272, 590);
            this.dataGridViewMultiskill.TabIndex = 0;
            this.dataGridViewMultiskill.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMultiskill_ColumnHeaderMouseClick);
            this.dataGridViewMultiskill.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMultiskill_ColumnHeaderMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(12, 32);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArea.TabIndex = 2;
            // 
            // MSM_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 662);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMultiskill);
            this.Name = "MSM_Area";
            this.Text = "MSM_Area";
            this.Load += new System.EventHandler(this.MSM_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMultiskill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMultiskill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxArea;
    }
}