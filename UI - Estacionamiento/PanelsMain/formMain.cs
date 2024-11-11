using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.PanelsMain.IngresosForms;
using UI___Estacionamiento.PanelsMain.TarifaForms;

namespace UI___Estacionamiento.PanelsMain
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            formIngresoMain formIngresoMain = new formIngresoMain();
            formIngresoMain.Show();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            formTarifasMain formtarifa = new formTarifasMain();
            formtarifa.Show();
        }
    }
}
