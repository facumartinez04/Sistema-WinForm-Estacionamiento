using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.PanelsMain.AdminForms.Backup;
using UI___Estacionamiento.PanelsMain.AdminForms.RolesPermisos;

namespace UI___Estacionamiento.PanelsMain.AdminForms
{
    public partial class formAdminMain : Form
    {
        public formAdminMain()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new formUsuarios());

        }

        private void AbrirFormPanel(object formPanel)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fp = formPanel as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fp);
            this.panelContenedor.Tag = fp;
            fp.Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new formAdminBitacora());

        }

        private void btnBackups_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new formAdminBackups());
        }
    }
}
