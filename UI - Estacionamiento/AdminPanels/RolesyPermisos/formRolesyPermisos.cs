using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.AdminPanels.RolesyPermisos
{
    public partial class formRolesyPermisos : Form
    {
        public formRolesyPermisos()
        {
            InitializeComponent();
        }

        private string Tipo;
        private Guid id;


        private Form activeForm;

        private void btnRol_Click(object sender, EventArgs e)
        {
            AbrirCostado("Rol", Guid.Empty);

        }

        public void CargarRoles()
        {
            dataGridRoles.DataSource = null;
            var familias = FamiliaRepository.Current.GetAll();
            dataGridRoles.DataSource = familias;
            dataGridRoles.Columns["Nombre"].Visible = true;
            dataGridRoles.Columns["Nombre"].HeaderText = "Nombre de Rol";

            dataGridRoles.Columns["idFamilia"].Visible = false;
            dataGridRoles.Columns["Id"].Visible = false;
            dataGridRoles.Columns["Name"].Visible = false;
        }

        public void CargarPermisos()
        {
            dataGridPermisos.DataSource = null;
            var patentes = PatenteRepository.Current.GetAll();
            dataGridPermisos.DataSource = patentes;

            dataGridPermisos.Columns["Nombre"].Visible = true;
            dataGridPermisos.Columns["Nombre"].HeaderText = "Nombre del permiso";
            dataGridPermisos.Columns["Nombre"].DisplayIndex = 0;
            dataGridPermisos.Columns["Nombre"].Width = 200;

            dataGridPermisos.Columns["DataKey"].Visible = true;
            dataGridPermisos.Columns["DataKey"].HeaderText = "Permiso";
            dataGridPermisos.Columns["DataKey"].DisplayIndex = 1;
            dataGridPermisos.Columns["DataKey"].Width = 200;

            dataGridPermisos.Columns["idPatente"].Visible = false;
            dataGridPermisos.Columns["Id"].Visible = false;
            dataGridPermisos.Columns["TipoAcceso"].Visible = false;
            dataGridPermisos.Columns["Name"].Visible = false;
        }

        private void formRolesyPermisos_Load(object sender, EventArgs e)
        {
            CargarPermisos();
            CargarRoles();
            ConfigurarDataGridView(dataGridPermisos);
            ConfigurarDataGridView(dataGridRoles);
        }

        private void dataGridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(45, 45, 48);
            dataGridView.ForeColor = Color.White;
            dataGridView.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
        }

        public void AbrirForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor1.Controls.Add(childForm);
            panelContenedor1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirCostado("Permiso", Guid.Empty);

        }

        private void AbrirCostado(string tipo, Guid id)
        {
            Tipo = tipo;
            this.id = id;
            formRolyPermsCE formRolyPermsCE = new formRolyPermsCE(Tipo, id, this);
            AbrirForm(new formRolyPermsCE(Tipo, id, this));

            Tipo = null;
            id = Guid.Empty;
        }

        private void dataGridPermisos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid id = (Guid)dataGridPermisos.Rows[e.RowIndex].Cells["idPatente"].Value;
            AbrirCostado("Permiso", id);

        }
    }
}
