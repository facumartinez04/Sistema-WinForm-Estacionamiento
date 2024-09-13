using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento
{
    public partial class Form1 : Form
    {

        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formCliente formCliente = new formCliente();
            formCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            formIngresos formIngresos = new formIngresos();
            AbrirForm(formIngresos);


        }


        public void AbrirForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            formSalidas formSalidas = new formSalidas();
            AbrirForm(formSalidas);

        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            formTipoTarifa formTipoTarifa = new formTipoTarifa();
            AbrirForm(formTipoTarifa);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
