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
    public partial class MSM : Form
    {
        DBHelper DBHelper = new DBHelper();

        public MSM()
        {
            InitializeComponent();
        }

        private void MSM_Load(object sender, EventArgs e)
        {
            DBHelper.ObtenerAreasEnComboBox(comboBoxArea);
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
