using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.AdminPanels.RolesyPermisos;

namespace UI___Estacionamiento.AdminPanels
{
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void btnRoles_Click(object sender, EventArgs e)
        {
            formRolesyPermisos formRolesyPermisos = new formRolesyPermisos();
            AbrirForm(new formRolesyPermisos());

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

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
