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
    public partial class MSM_Area : Form
    {
        DBHelper DBHelper = new DBHelper();
        public MSM_Area()
        {
            InitializeComponent();
        }

        public void diseñoMSM()
        {
            for (int i = 2; dataGridViewMultiskill.ColumnCount > i; i++)
            {
                for (int x = 0; dataGridViewMultiskill.RowCount > x; x++)
                {
                    if (dataGridViewMultiskill.Rows[x].Cells[i].Value != null)
                    {
                        if (dataGridViewMultiskill.Rows[x].Cells[i].Value.ToString() == String.Empty)
                            dataGridViewMultiskill.Rows[x].Cells[i].Value = 0;
                    }
                    try
                    {
                        char delimitador = '[';
                        char separador = '-';
                        if (dataGridViewMultiskill.Rows[x].Cells[i].Value != null)
                        {
                            string fechaNivelCompetencia = dataGridViewMultiskill.Rows[x].Cells[i].Value.ToString();
                            string[] informacionCertificacion = fechaNivelCompetencia.Split(delimitador);
                            string certificacionEntrenamiento = dataGridViewMultiskill.Columns[i].HeaderText;
                            string[] certificacionEntrenamientoNombre = certificacionEntrenamiento.Split(separador);
                            string fechaVencimiento = informacionCertificacion[1];
                            string duracion = DBHelper.ObtenerDuracionCertificacionEntrenamiento(certificacionEntrenamientoNombre[1]);
                            int duracionDias = int.Parse(duracion);
                            fechaVencimiento = fechaVencimiento.Remove(fechaVencimiento.Length - 1);

                            var fechaVigencia = DateTime.Parse(fechaVencimiento);
                            fechaVigencia = fechaVigencia.AddDays(-duracionDias);
                            if (fechaVigencia <= DateTime.Today)
                            {
                                dataGridViewMultiskill.Rows[x].Cells[i].Style.BackColor = Color.Red;


                            }
                        }
                    }
                    catch
                    {

                    }
                }
                //dataGridViewMultiskill.Columns[i].DefaultCellStyle = norStyle;  //Metodo para que aparezcan las meatballs
            }
        }

        private void MSM_Area_Load(object sender, EventArgs e)
        {
            DBHelper.ObtenerAreasEnComboBox(comboBoxArea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.MostrarTablaMultiSkill(dataGridViewMultiskill, comboBoxArea.Text);
            //System.Windows.Forms.DataGridViewCellStyle norStyle = new System.Windows.Forms.DataGridViewCellStyle();
            //norStyle.Font = new System.Drawing.Font("Lean Status Symbols", 14.0F, System.Drawing.FontStyle.Regular);

            dataGridViewMultiskill.AutoResizeColumns();
            dataGridViewMultiskill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            diseñoMSM();

            dataGridViewMultiskill.Columns[1].Frozen = true;

        }

        private void dataGridViewMultiskill_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //REVISAR SI ES NECESARIO POR EL CLICK DERECHO
            char delimitador = '-';

            var certificacionSeleccionada = dataGridViewMultiskill.CurrentRow;
            try
            {
                string certificacion = dataGridViewMultiskill.Columns[e.ColumnIndex].HeaderText;
                string[] informacionCertificacion = certificacion.Split(delimitador);
                Data.CODIGO = informacionCertificacion[2];
                MSM_Detalles openForm = new MSM_Detalles();
                openForm.Show();
            }
            catch
            {

            }
        }

        private void dataGridViewMultiskill_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            diseñoMSM();

            if (e.Button == MouseButtons.Right)
            {
                char delimitador = '-';

                var certificacionSeleccionada = dataGridViewMultiskill.CurrentRow;
                try
                {
                    string certificacion = dataGridViewMultiskill.Columns[e.ColumnIndex].HeaderText;
                    string[] informacionCertificacion = certificacion.Split(delimitador);
                    Data.CODIGO = informacionCertificacion[2];
                    MSM_Detalles openForm = new MSM_Detalles();
                    openForm.Show();
                }
                catch
                {

                }
            }
        }
    }
}
    