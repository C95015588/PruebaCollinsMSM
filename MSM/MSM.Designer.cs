namespace MSM
{
    partial class MSM
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
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.buttonIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(229, 61);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArea.TabIndex = 0;
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxArea_SelectedIndexChanged);
            // 
            // buttonIr
            // 
            this.buttonIr.Location = new System.Drawing.Point(480, 94);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(75, 23);
            this.buttonIr.TabIndex = 1;
            this.buttonIr.Text = "Ir";
            this.buttonIr.UseVisualStyleBackColor = true;
            // 
            // MSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 129);
            this.Controls.Add(this.buttonIr);
            this.Controls.Add(this.comboBoxArea);
            this.Name = "MSM";
            this.Text = "MSM";
            this.Load += new System.EventHandler(this.MSM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Button buttonIr;
    }
}