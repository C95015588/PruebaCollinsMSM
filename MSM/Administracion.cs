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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void buttonCapturarNivelDeCompetencia_Click(object sender, EventArgs e)
        {
            Administracion_actualizar_nivel PantallaActualizarNivel = new Administracion_actualizar_nivel ();
            PantallaActualizarNivel.Show();
        }

        private void buttonEditarCertificacionesOEntrenamientos_Click(object sender, EventArgs e)
        {
            Administracion_Certificacion_Entrenamiento PantallaAdministrarCertificacionesEntrenamientos = new Administracion_Certificacion_Entrenamiento();
            PantallaAdministrarCertificacionesEntrenamientos.Show();
        }
    }
}
