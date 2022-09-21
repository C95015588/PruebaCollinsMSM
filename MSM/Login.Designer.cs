namespace MSM
{
    partial class Login
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.checkBoxNoTengoCredenciales = new System.Windows.Forms.CheckBox();
            this.panelCredenciales = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipNoCredenciales = new System.Windows.Forms.ToolTip(this.components);
            this.labelInvitado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInvitado = new System.Windows.Forms.Panel();
            this.panelCredenciales.SuspendLayout();
            this.panelInvitado.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(528, 212);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(159, 58);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Iniciar sesión";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(3, 56);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(3, 127);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(100, 20);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(3, 8);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(74, 24);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelContraseña.Location = new System.Drawing.Point(3, 79);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(106, 24);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "Contraseña";
            // 
            // checkBoxNoTengoCredenciales
            // 
            this.checkBoxNoTengoCredenciales.AutoSize = true;
            this.checkBoxNoTengoCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNoTengoCredenciales.Location = new System.Drawing.Point(46, 212);
            this.checkBoxNoTengoCredenciales.Name = "checkBoxNoTengoCredenciales";
            this.checkBoxNoTengoCredenciales.Size = new System.Drawing.Size(293, 28);
            this.checkBoxNoTengoCredenciales.TabIndex = 8;
            this.checkBoxNoTengoCredenciales.Text = "Modo de lectura (Visualización)";
            this.toolTipNoCredenciales.SetToolTip(this.checkBoxNoTengoCredenciales, "Si eres usuario sin computadora presiona aqui prro");
            this.checkBoxNoTengoCredenciales.UseVisualStyleBackColor = true;
            this.checkBoxNoTengoCredenciales.CheckedChanged += new System.EventHandler(this.checkBoxNoTengoCredenciales_CheckedChanged);
            // 
            // panelCredenciales
            // 
            this.panelCredenciales.Controls.Add(this.label2);
            this.panelCredenciales.Controls.Add(this.label1);
            this.panelCredenciales.Controls.Add(this.labelUsuario);
            this.panelCredenciales.Controls.Add(this.textBoxUsuario);
            this.panelCredenciales.Controls.Add(this.labelContraseña);
            this.panelCredenciales.Controls.Add(this.textBoxContraseña);
            this.panelCredenciales.Location = new System.Drawing.Point(47, 20);
            this.panelCredenciales.Name = "panelCredenciales";
            this.panelCredenciales.Size = new System.Drawing.Size(219, 174);
            this.panelCredenciales.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // labelInvitado
            // 
            this.labelInvitado.AutoSize = true;
            this.labelInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelInvitado.Location = new System.Drawing.Point(3, 16);
            this.labelInvitado.Name = "labelInvitado";
            this.labelInvitado.Size = new System.Drawing.Size(289, 24);
            this.labelInvitado.TabIndex = 13;
            this.labelInvitado.Text = "Da click en el boton iniciar sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Read Only (Visualization)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click on login button (Iniciar sesión)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Login";
            // 
            // panelInvitado
            // 
            this.panelInvitado.Controls.Add(this.label4);
            this.panelInvitado.Controls.Add(this.labelInvitado);
            this.panelInvitado.Location = new System.Drawing.Point(46, 20);
            this.panelInvitado.Name = "panelInvitado";
            this.panelInvitado.Size = new System.Drawing.Size(293, 100);
            this.panelInvitado.TabIndex = 15;
            this.panelInvitado.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 273);
            this.Controls.Add(this.panelInvitado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelCredenciales);
            this.Controls.Add(this.checkBoxNoTengoCredenciales);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelCredenciales.ResumeLayout(false);
            this.panelCredenciales.PerformLayout();
            this.panelInvitado.ResumeLayout(false);
            this.panelInvitado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.CheckBox checkBoxNoTengoCredenciales;
        private System.Windows.Forms.Panel panelCredenciales;
        private System.Windows.Forms.ToolTip toolTipNoCredenciales;
        private System.Windows.Forms.Label labelInvitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelInvitado;
    }
}

