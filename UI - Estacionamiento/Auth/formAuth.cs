using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SERVICE.Facade;
using System.Windows.Forms;

namespace UI___Estacionamiento.Auth
{
    public partial class formAuth : Form
    {



        private Form activeForm;

        private formAuthLogin formAuthLogin;

        public formAuth()
        {
            InitializeComponent();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            formAuthLogin formAuthLogin = new formAuthLogin(this);
            AbrirForm(formAuthLogin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAuthRegister formAuthRegister = new formAuthRegister(this);
            AbrirForm(formAuthRegister);
        }

        private void formAuth_Load(object sender, EventArgs e)
        {
        }

        private void formAuth_Load_1(object sender, EventArgs e)
        {

            formAuthLogin formAuthLogin = new formAuthLogin(this);
            AbrirForm(formAuthLogin);

        }


    }
}
