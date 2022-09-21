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
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            if(Data.ESADMINISTRADOR == true)
            {
                buttonAdministrador.Visible = true;
                labelBannerAdministrador.Visible = true;
                
            }
            if(Data.ESSUPERVISOR == true)
            {
                buttonAdministrador.Visible = true;
                labelBannerAdministrador.Visible = true;
            }
        }

        //PELICANO 
        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            Administracion PantallaAdministracion = new Administracion();
            PantallaAdministracion.Show();
        }

        private void buttonMultiSkills_Click(object sender, EventArgs e)
        {
            MSM_Area PantallaMsm = new MSM_Area();
            PantallaMsm.Show();
        }

        private void buttonKardex_Click(object sender, EventArgs e)
        {
            Empleado_Kardex PantallaKardex = new Empleado_Kardex();
            PantallaKardex.Show();
        }

        private void buttonReportePorVencer_Click(object sender, EventArgs e)
        {
            Reporte_Por_Vencer PantallaReporte = new Reporte_Por_Vencer();
            PantallaReporte.Show();
        }
    }
}
