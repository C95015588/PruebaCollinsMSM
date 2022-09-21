using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSM
{
    public partial class Administracion_actualizar_nivel : Form
    {
        public Administracion_actualizar_nivel()
        {
            InitializeComponent();
        }

        private void textBoxNumeroEmpleado_TextChanged(object sender, EventArgs e)
        {
            DBHelper DBHelper = new DBHelper();
            //Variable para contar los caracteres ingresaras en el textbox
            int contadorcaracteres = 0;
            contadorcaracteres = textBoxNumeroEmpleado.Text.Trim().Length;



            if (contadorcaracteres > 7)
            {
                //Obtiene el nombre del usuario y lo guarda en una variable para despues
                //mostrarlo en pantalla
                DBHelper.ObtenerNombreEmpleadoViaNumero(textBoxNumeroEmpleado.Text);
                labelNombreEmpleado.Text = Data.NOMBREEMPLEADO;

            }

            if (contadorcaracteres <= 7)
            {
                labelNombreEmpleado.Text = "Escribe el numero de empleado";
            }
        }

        private void Administracion_actualizar_nivel_Load(object sender, EventArgs e)
        {
           
        }

        private void labelNombreEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
    }

