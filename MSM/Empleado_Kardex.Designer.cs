namespace MSM
{
    partial class Empleado_Kardex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.dataGridViewCertificacionesEmpleado = new System.Windows.Forms.DataGridView();
            this.labelBannerIngresarNumeroEmpleado = new System.Windows.Forms.Label();
            this.textBoxNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.buttonBuscarIngresarElNumeroEmpleado = new System.Windows.Forms.Button();
            this.panelIngresarNumeroEmpleado = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBannerBuscar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBannerIngresarNum = new System.Windows.Forms.Label();
            this.labelBannerNombreEmpleado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFiltrarBussinessUnitIngles = new System.Windows.Forms.Label();
            this.comboBoxBusinessUnit = new System.Windows.Forms.ComboBox();
            this.labelBannerBusines = new System.Windows.Forms.Label();
            this.labelBannerInglesArea = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.buttonBorrarFiltro = new System.Windows.Forms.Button();
            this.labelEntrenamientosNoObtenidosIngles = new System.Windows.Forms.Label();
            this.labelEntrenamientosNoObtenidos = new System.Windows.Forms.Label();
            this.dataGridViewEntrenamientosNoObtenidos = new System.Windows.Forms.DataGridView();
            this.labelBannerInglesFiltrar = new System.Windows.Forms.Label();
            this.labelBannerFiltrarEntrenamientos = new System.Windows.Forms.Label();
            this.comboBoxAreaEmpleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertificacionesEmpleado)).BeginInit();
            this.panelIngresarNumeroEmpleado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenamientosNoObtenidos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(410, 10);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(77, 13);
            this.labelNombreEmpleado.TabIndex = 1;
            this.labelNombreEmpleado.Text = "Nombre/Name";
            // 
            // dataGridViewCertificacionesEmpleado
            // 
            this.dataGridViewCertificacionesEmpleado.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewCertificacionesEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCertificacionesEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCertificacionesEmpleado.GridColor = System.Drawing.Color.OrangeRed;
            this.dataGridViewCertificacionesEmpleado.Location = new System.Drawing.Point(6, 95);
            this.dataGridViewCertificacionesEmpleado.Name = "dataGridViewCertificacionesEmpleado";
            this.dataGridViewCertificacionesEmpleado.ReadOnly = true;
            this.dataGridViewCertificacionesEmpleado.Size = new System.Drawing.Size(655, 274);
            this.dataGridViewCertificacionesEmpleado.TabIndex = 6;
            this.dataGridViewCertificacionesEmpleado.Visible = false;
            // 
            // labelBannerIngresarNumeroEmpleado
            // 
            this.labelBannerIngresarNumeroEmpleado.AutoSize = true;
            this.labelBannerIngresarNumeroEmpleado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBannerIngresarNumeroEmpleado.Location = new System.Drawing.Point(3, 28);
            this.labelBannerIngresarNumeroEmpleado.Name = "labelBannerIngresarNumeroEmpleado";
            this.labelBannerIngresarNumeroEmpleado.Size = new System.Drawing.Size(201, 13);
            this.labelBannerIngresarNumeroEmpleado.TabIndex = 7;
            this.labelBannerIngresarNumeroEmpleado.Text = "Enter the employee number to search for:";
            // 
            // textBoxNumeroEmpleado
            // 
            this.textBoxNumeroEmpleado.Location = new System.Drawing.Point(245, 10);
            this.textBoxNumeroEmpleado.Name = "textBoxNumeroEmpleado";
            this.textBoxNumeroEmpleado.Size = new System.Drawing.Size(98, 20);
            this.textBoxNumeroEmpleado.TabIndex = 9;
            this.textBoxNumeroEmpleado.TextChanged += new System.EventHandler(this.textBoxNumeroEmpleado_TextChanged);
            // 
            // buttonBuscarIngresarElNumeroEmpleado
            // 
            this.buttonBuscarIngresarElNumeroEmpleado.Location = new System.Drawing.Point(39, 3);
            this.buttonBuscarIngresarElNumeroEmpleado.Name = "buttonBuscarIngresarElNumeroEmpleado";
            this.buttonBuscarIngresarElNumeroEmpleado.Size = new System.Drawing.Size(101, 25);
            this.buttonBuscarIngresarElNumeroEmpleado.TabIndex = 10;
            this.buttonBuscarIngresarElNumeroEmpleado.Text = "Buscar";
            this.buttonBuscarIngresarElNumeroEmpleado.UseVisualStyleBackColor = true;
            this.buttonBuscarIngresarElNumeroEmpleado.Click += new System.EventHandler(this.buttonOkIngresarElNumeroEmpleado_Click);
            // 
            // panelIngresarNumeroEmpleado
            // 
            this.panelIngresarNumeroEmpleado.Controls.Add(this.panel1);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.label1);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.labelBannerIngresarNum);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.textBoxNumeroEmpleado);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.labelNombreEmpleado);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.labelBannerIngresarNumeroEmpleado);
            this.panelIngresarNumeroEmpleado.Controls.Add(this.labelBannerNombreEmpleado);
            this.panelIngresarNumeroEmpleado.Location = new System.Drawing.Point(17, 12);
            this.panelIngresarNumeroEmpleado.Name = "panelIngresarNumeroEmpleado";
            this.panelIngresarNumeroEmpleado.Size = new System.Drawing.Size(650, 112);
            this.panelIngresarNumeroEmpleado.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBannerBuscar);
            this.panel1.Controls.Add(this.buttonBuscarIngresarElNumeroEmpleado);
            this.panel1.Location = new System.Drawing.Point(245, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 35);
            this.panel1.TabIndex = 15;
            // 
            // labelBannerBuscar
            // 
            this.labelBannerBuscar.AutoSize = true;
            this.labelBannerBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBannerBuscar.Location = new System.Drawing.Point(143, 9);
            this.labelBannerBuscar.Name = "labelBannerBuscar";
            this.labelBannerBuscar.Size = new System.Drawing.Size(41, 13);
            this.labelBannerBuscar.TabIndex = 14;
            this.labelBannerBuscar.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(349, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // labelBannerIngresarNum
            // 
            this.labelBannerIngresarNum.AutoSize = true;
            this.labelBannerIngresarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBannerIngresarNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBannerIngresarNum.Location = new System.Drawing.Point(3, 13);
            this.labelBannerIngresarNum.Name = "labelBannerIngresarNum";
            this.labelBannerIngresarNum.Size = new System.Drawing.Size(236, 15);
            this.labelBannerIngresarNum.TabIndex = 12;
            this.labelBannerIngresarNum.Text = "Ingresa el numero de empleado a buscar:";
            // 
            // labelBannerNombreEmpleado
            // 
            this.labelBannerNombreEmpleado.AutoSize = true;
            this.labelBannerNombreEmpleado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBannerNombreEmpleado.Location = new System.Drawing.Point(349, 23);
            this.labelBannerNombreEmpleado.Name = "labelBannerNombreEmpleado";
            this.labelBannerNombreEmpleado.Size = new System.Drawing.Size(41, 13);
            this.labelBannerNombreEmpleado.TabIndex = 0;
            this.labelBannerNombreEmpleado.Text = "Name: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFiltrarBussinessUnitIngles);
            this.panel2.Controls.Add(this.comboBoxBusinessUnit);
            this.panel2.Controls.Add(this.labelBannerBusines);
            this.panel2.Controls.Add(this.labelBannerInglesArea);
            this.panel2.Controls.Add(this.labelArea);
            this.panel2.Controls.Add(this.buttonBorrarFiltro);
            this.panel2.Controls.Add(this.labelEntrenamientosNoObtenidosIngles);
            this.panel2.Controls.Add(this.labelEntrenamientosNoObtenidos);
            this.panel2.Controls.Add(this.dataGridViewEntrenamientosNoObtenidos);
            this.panel2.Controls.Add(this.labelBannerInglesFiltrar);
            this.panel2.Controls.Add(this.labelBannerFiltrarEntrenamientos);
            this.panel2.Controls.Add(this.comboBoxAreaEmpleado);
            this.panel2.Controls.Add(this.dataGridViewCertificacionesEmpleado);
            this.panel2.Location = new System.Drawing.Point(6, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 372);
            this.panel2.TabIndex = 12;
            // 
            // labelFiltrarBussinessUnitIngles
            // 
            this.labelFiltrarBussinessUnitIngles.AutoSize = true;
            this.labelFiltrarBussinessUnitIngles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelFiltrarBussinessUnitIngles.Location = new System.Drawing.Point(172, 13);
            this.labelFiltrarBussinessUnitIngles.Name = "labelFiltrarBussinessUnitIngles";
            this.labelFiltrarBussinessUnitIngles.Size = new System.Drawing.Size(107, 13);
            this.labelFiltrarBussinessUnitIngles.TabIndex = 23;
            this.labelFiltrarBussinessUnitIngles.Text = "Filter by business unit";
            this.labelFiltrarBussinessUnitIngles.Visible = false;
            // 
            // comboBoxBusinessUnit
            // 
            this.comboBoxBusinessUnit.FormattingEnabled = true;
            this.comboBoxBusinessUnit.Location = new System.Drawing.Point(6, 29);
            this.comboBoxBusinessUnit.Name = "comboBoxBusinessUnit";
            this.comboBoxBusinessUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBusinessUnit.TabIndex = 22;
            this.comboBoxBusinessUnit.Visible = false;
            this.comboBoxBusinessUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusinessUnit_SelectedIndexChanged);
            // 
            // labelBannerBusines
            // 
            this.labelBannerBusines.AutoSize = true;
            this.labelBannerBusines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBannerBusines.Location = new System.Drawing.Point(3, 11);
            this.labelBannerBusines.Name = "labelBannerBusines";
            this.labelBannerBusines.Size = new System.Drawing.Size(137, 15);
            this.labelBannerBusines.TabIndex = 21;
            this.labelBannerBusines.Text = "Filtrar por business unit ";
            this.labelBannerBusines.Visible = false;
            // 
            // labelBannerInglesArea
            // 
            this.labelBannerInglesArea.AutoSize = true;
            this.labelBannerInglesArea.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBannerInglesArea.Location = new System.Drawing.Point(917, 83);
            this.labelBannerInglesArea.Name = "labelBannerInglesArea";
            this.labelBannerInglesArea.Size = new System.Drawing.Size(17, 13);
            this.labelBannerInglesArea.TabIndex = 20;
            this.labelBannerInglesArea.Text = "\"\"";
            this.labelBannerInglesArea.Visible = false;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(917, 59);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(15, 15);
            this.labelArea.TabIndex = 14;
            this.labelArea.Text = "\"\"";
            this.labelArea.Visible = false;
            // 
            // buttonBorrarFiltro
            // 
            this.buttonBorrarFiltro.Location = new System.Drawing.Point(354, 66);
            this.buttonBorrarFiltro.Name = "buttonBorrarFiltro";
            this.buttonBorrarFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarFiltro.TabIndex = 19;
            this.buttonBorrarFiltro.Text = "Borrar filtro";
            this.buttonBorrarFiltro.UseVisualStyleBackColor = true;
            this.buttonBorrarFiltro.Click += new System.EventHandler(this.buttonBorrarFiltro_Click);
            // 
            // labelEntrenamientosNoObtenidosIngles
            // 
            this.labelEntrenamientosNoObtenidosIngles.AutoSize = true;
            this.labelEntrenamientosNoObtenidosIngles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelEntrenamientosNoObtenidosIngles.Location = new System.Drawing.Point(697, 83);
            this.labelEntrenamientosNoObtenidosIngles.Name = "labelEntrenamientosNoObtenidosIngles";
            this.labelEntrenamientosNoObtenidosIngles.Size = new System.Drawing.Size(138, 13);
            this.labelEntrenamientosNoObtenidosIngles.TabIndex = 18;
            this.labelEntrenamientosNoObtenidosIngles.Text = "Missing trainings in this area";
            this.labelEntrenamientosNoObtenidosIngles.Visible = false;
            // 
            // labelEntrenamientosNoObtenidos
            // 
            this.labelEntrenamientosNoObtenidos.AutoSize = true;
            this.labelEntrenamientosNoObtenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrenamientosNoObtenidos.Location = new System.Drawing.Point(697, 59);
            this.labelEntrenamientosNoObtenidos.Name = "labelEntrenamientosNoObtenidos";
            this.labelEntrenamientosNoObtenidos.Size = new System.Drawing.Size(204, 15);
            this.labelEntrenamientosNoObtenidos.TabIndex = 13;
            this.labelEntrenamientosNoObtenidos.Text = "Entrenamientos faltantes en el area:";
            this.labelEntrenamientosNoObtenidos.Visible = false;
            // 
            // dataGridViewEntrenamientosNoObtenidos
            // 
            this.dataGridViewEntrenamientosNoObtenidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntrenamientosNoObtenidos.Location = new System.Drawing.Point(700, 99);
            this.dataGridViewEntrenamientosNoObtenidos.Name = "dataGridViewEntrenamientosNoObtenidos";
            this.dataGridViewEntrenamientosNoObtenidos.Size = new System.Drawing.Size(343, 273);
            this.dataGridViewEntrenamientosNoObtenidos.TabIndex = 17;
            this.dataGridViewEntrenamientosNoObtenidos.Visible = false;
            // 
            // labelBannerInglesFiltrar
            // 
            this.labelBannerInglesFiltrar.AutoSize = true;
            this.labelBannerInglesFiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBannerInglesFiltrar.Location = new System.Drawing.Point(217, 52);
            this.labelBannerInglesFiltrar.Name = "labelBannerInglesFiltrar";
            this.labelBannerInglesFiltrar.Size = new System.Drawing.Size(67, 13);
            this.labelBannerInglesFiltrar.TabIndex = 15;
            this.labelBannerInglesFiltrar.Text = "Filter by area";
            this.labelBannerInglesFiltrar.Visible = false;
            // 
            // labelBannerFiltrarEntrenamientos
            // 
            this.labelBannerFiltrarEntrenamientos.AutoSize = true;
            this.labelBannerFiltrarEntrenamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBannerFiltrarEntrenamientos.Location = new System.Drawing.Point(6, 50);
            this.labelBannerFiltrarEntrenamientos.Name = "labelBannerFiltrarEntrenamientos";
            this.labelBannerFiltrarEntrenamientos.Size = new System.Drawing.Size(90, 15);
            this.labelBannerFiltrarEntrenamientos.TabIndex = 8;
            this.labelBannerFiltrarEntrenamientos.Text = "Filtrar por area:";
            this.labelBannerFiltrarEntrenamientos.Visible = false;
            // 
            // comboBoxAreaEmpleado
            // 
            this.comboBoxAreaEmpleado.FormattingEnabled = true;
            this.comboBoxAreaEmpleado.Location = new System.Drawing.Point(6, 68);
            this.comboBoxAreaEmpleado.Name = "comboBoxAreaEmpleado";
            this.comboBoxAreaEmpleado.Size = new System.Drawing.Size(319, 21);
            this.comboBoxAreaEmpleado.TabIndex = 7;
            this.comboBoxAreaEmpleado.Visible = false;
            this.comboBoxAreaEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxAreaEmpleado_SelectedIndexChanged);
            // 
            // Empleado_Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelIngresarNumeroEmpleado);
            this.Name = "Empleado_Kardex";
            this.Text = "Empleado_Kardex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCertificacionesEmpleado)).EndInit();
            this.panelIngresarNumeroEmpleado.ResumeLayout(false);
            this.panelIngresarNumeroEmpleado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntrenamientosNoObtenidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewCertificacionesEmpleado;
        private System.Windows.Forms.Label labelBannerIngresarNumeroEmpleado;
        private System.Windows.Forms.TextBox textBoxNumeroEmpleado;
        private System.Windows.Forms.Button buttonBuscarIngresarElNumeroEmpleado;
        private System.Windows.Forms.Panel panelIngresarNumeroEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBannerBuscar;
        private System.Windows.Forms.Label labelBannerIngresarNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBannerFiltrarEntrenamientos;
        private System.Windows.Forms.ComboBox comboBoxAreaEmpleado;
        private System.Windows.Forms.Label labelBannerInglesFiltrar;
        private System.Windows.Forms.Label labelEntrenamientosNoObtenidosIngles;
        private System.Windows.Forms.Label labelEntrenamientosNoObtenidos;
        private System.Windows.Forms.DataGridView dataGridViewEntrenamientosNoObtenidos;
        private System.Windows.Forms.Button buttonBorrarFiltro;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBannerNombreEmpleado;
        private System.Windows.Forms.Label labelBannerInglesArea;
        private System.Windows.Forms.Label labelFiltrarBussinessUnitIngles;
        private System.Windows.Forms.ComboBox comboBoxBusinessUnit;
        private System.Windows.Forms.Label labelBannerBusines;
    }
}