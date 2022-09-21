using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSM
{
    public partial class Login : Form
    {
        DBHelper DBHelper = new DBHelper();
        public Login()
        {
            InitializeComponent();
        }


        public void validacionCredenciales()
        {
            //Metodo en la clase DBHelper que obtiene la conexion a utcain.com para obtener datos
            DBHelper.connectionDomain(textBoxUsuario.Text);
            //Metodo para comprobar que tipo de usuario es
            DBHelper.EsAdministrador();
            DBHelper.EsSupervisor();
            //Open the homescreen and hide this form
            Menu openForm = new Menu();
            openForm.Show();
            MessageBox.Show("Abrir menu con privilegios para " + Data.CUENTA);

            this.Hide();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkBoxNoTengoCredenciales.Checked == false)
            {
                if (textBoxContraseña.Text == "" || textBoxUsuario.Text == "")
                {
                    MessageBox.Show("Escribe tu usuario y contraseña correcto");
                }
                else
                {
                    using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "utcain.com"))
                    {
                        //Variable booleana que comprueba si son validas las credenciales
                        bool esValido = pc.ValidateCredentials(textBoxUsuario.Text, textBoxContraseña.Text);

                        if (!esValido)
                        {
                            // Si no es valido
                            MessageBox.Show("Credenciales Invalidas");
                        }
                        else
                        {
                            //Las ccredenciales son validas
                            validacionCredenciales();
                            
                        }
                    }
                }
            }
            else
            {
                if (checkBoxNoTengoCredenciales.Checked == true)
                { 
                    Menu openForm = new Menu();
                    openForm.Show();                    
                }
            }
        }

        private void checkBoxNoTengoCredenciales_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNoTengoCredenciales.Checked== true)
            {
                panelCredenciales.Visible = false;
                textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";
                panelInvitado.Visible = true;
            }
            if (checkBoxNoTengoCredenciales.Checked == false)
            {
                panelCredenciales.Visible = true;
                panelInvitado.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

  
}

