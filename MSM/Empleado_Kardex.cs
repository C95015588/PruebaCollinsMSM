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
    public partial class Empleado_Kardex : Form
    {            DBHelper DBHelper = new DBHelper();
        public Empleado_Kardex()
        {
            InitializeComponent();
      

        }
        private void buttonOkIngresarElNumeroEmpleado_Click(object sender, EventArgs e)
        {

            DBHelper.ObtenerNombreEmpleadoViaNumero(textBoxNumeroEmpleado.Text);

            dataGridViewCertificacionesEmpleado.DataSource = null;
            dataGridViewEntrenamientosNoObtenidos.DataSource = null;
            comboBoxAreaEmpleado.SelectedIndex = -1;


            DBHelper.ObtenerKardex(textBoxNumeroEmpleado.Text, dataGridViewCertificacionesEmpleado);
            
            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Lean Status Symbols", 8.25F, System.Drawing.FontStyle.Regular);
            dataGridViewCertificacionesEmpleado.Columns[2].DefaultCellStyle = norStyle;  //Metodo para que aparezcan las meatballs

            comboBoxBusinessUnit.Visible = true;
            labelBannerBusines.Visible = true;
            labelFiltrarBussinessUnitIngles.Visible = true; 
            dataGridViewCertificacionesEmpleado.Visible = true;
            buttonBorrarFiltro.Visible = false; 

           

            comboBoxBusinessUnit.Items.Clear();

            DBHelper.ObtenerBussinesUnitEnComboBox(comboBoxBusinessUnit);


            //DBHelper.ObtenerAreasEnComboBox(comboBoxAreaEmpleado);
            







            if (Data.NOMBREEMPLEADO.Equals("No de empleado incorrecto"))
            {

                comboBoxAreaEmpleado.Visible = false;
                labelBannerFiltrarEntrenamientos.Visible = false;
                dataGridViewCertificacionesEmpleado.Visible = false;
                labelBannerInglesFiltrar.Visible = false;


                MessageBox.Show("Numero de empleado incorrecto");
                this.Show();
             

            }

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
        private void comboBoxAreaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBHelper.FiltraKardexPorArea(textBoxNumeroEmpleado.Text, comboBoxAreaEmpleado.Text, dataGridViewCertificacionesEmpleado);
            DBHelper.FiltraEntrenamientosNoObtenidos(textBoxNumeroEmpleado.Text, comboBoxAreaEmpleado.Text, dataGridViewEntrenamientosNoObtenidos);

            String nombreArea = comboBoxAreaEmpleado.Text;
            comboBoxAreaEmpleado.SelectedIndex = -1;

            labelArea.Text = nombreArea;
            labelBannerInglesArea.Text = nombreArea;

            labelEntrenamientosNoObtenidos.Visible = true;
            labelEntrenamientosNoObtenidosIngles.Visible = true;
            dataGridViewEntrenamientosNoObtenidos.Visible = true;
            labelArea.Visible = true;
            labelEntrenamientosNoObtenidos.Visible = true;
            labelBannerInglesArea.Visible = true;
            buttonBorrarFiltro.Visible = true;


            
        }

      

        private void buttonBorrarFiltro_Click(object sender, EventArgs e)
        {
            comboBoxAreaEmpleado.SelectedIndex = -1;


            DBHelper.ObtenerKardex(textBoxNumeroEmpleado.Text, dataGridViewCertificacionesEmpleado);

            System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            norStyle.Font = new System.Drawing.Font("Lean Status Symbols", 8.25F, System.Drawing.FontStyle.Regular);
            dataGridViewCertificacionesEmpleado.Columns[2].DefaultCellStyle = norStyle;  //Metodo para que aparezcan las meatballs

            comboBoxAreaEmpleado.Visible = true;
            labelBannerFiltrarEntrenamientos.Visible = true;
            dataGridViewCertificacionesEmpleado.Visible = true;
            labelBannerInglesFiltrar.Visible = true;

            labelEntrenamientosNoObtenidos.Visible = false;
            labelEntrenamientosNoObtenidosIngles.Visible = false;
            dataGridViewEntrenamientosNoObtenidos.Visible = false;
            labelArea.Visible = false;
            labelEntrenamientosNoObtenidos.Visible = false;
            labelBannerInglesArea.Visible = false;
            buttonBorrarFiltro.Visible = false;



        }

        private void comboBoxBusinessUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAreaEmpleado.SelectedIndex = -1;
            comboBoxAreaEmpleado.Items.Clear();
    

            DBHelper.FiltrarAreaBussinesUnit(comboBoxAreaEmpleado, comboBoxBusinessUnit.Text);

            labelBannerFiltrarEntrenamientos.Visible = true;
            labelBannerInglesFiltrar.Visible = true;
            comboBoxAreaEmpleado.Visible = true; 
        }
    }
    }
    

    

