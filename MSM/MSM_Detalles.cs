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
    public partial class MSM_Detalles : Form
    {
        DBHelper DBHelper = new DBHelper();
        string[] datosDetalles = new string[8];
        public MSM_Detalles()
        {
            InitializeComponent();
        }

        private void MSM_Detalles_Load(object sender, EventArgs e)
        {
            datosDetalles = DBHelper.MostrarMSMDetalles(Data.CODIGO);
            labelNombre.Text = datosDetalles[0];
            labelCodigo.Text = datosDetalles[1];
            labelDescripcion.Text = datosDetalles[2];
            labelTipo.Text = datosDetalles[3];
            labelFrecuencia.Text = datosDetalles[4];
            labelAgente.Text = datosDetalles[5];
            labelFuncion.Text = datosDetalles[6];
            labelDuracion.Text = datosDetalles[7];

            labelEvidencias.Text = DBHelper.MostrarEvidencias(labelTipo.Text);

        }
    }
}
