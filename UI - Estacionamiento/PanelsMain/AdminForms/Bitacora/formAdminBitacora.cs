using SERVICE.Domain;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.PanelsMain.AdminForms
{
    public partial class formAdminBitacora : Form
    {
        public formAdminBitacora()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void ListarBitacora()
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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                ListarBitacoraPorUsuario(usuario);





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ListarBitacoraPorUsuario(string usuario)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = BitacoraService.ObtenerBitacoraPorUsuario(usuario);
            dgvBitacora.DataSource = null;

            var lista = bitacoras.Select(b => new
            {
                usuario = b.usuario,
                fecha = b.fecha.ToString("dd/MM/yyyy"),
                hora = b.fecha.ToString("HH:mm:ss"),
                accion = b.accion,
                detalles = b.detalles
            }).ToList();

            dgvBitacora.DataSource = lista;

            dgvBitacora.Columns[0].HeaderText = "Usuario";
            dgvBitacora.Columns[0].FillWeight = 20;
            dgvBitacora.Columns[1].HeaderText = "Fecha";
            dgvBitacora.Columns[1].FillWeight = 20;
            dgvBitacora.Columns[2].HeaderText = "Hora";
            dgvBitacora.Columns[2].FillWeight = 20;
            dgvBitacora.Columns[3].HeaderText = "Accion";
            dgvBitacora.Columns[4].Visible = false;
            ConfigurarDataGridView(dgvBitacora);



        }

        private void ListarBitacoraPorFecha(DateTime dateTime)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = BitacoraService.ObtenerBitacoraPorFecha(dateTime);
            dgvBitacora.DataSource = null;

            var lista = bitacoras.Select(b => new
            {
                usuario = b.usuario,
                fecha = b.fecha.ToString("dd/MM/yyyy"),
                hora = b.fecha.ToString("HH:mm:ss"),
                accion = b.accion,
                detalles = b.detalles
            }).ToList();

            dgvBitacora.DataSource = lista;

            dgvBitacora.Columns[0].HeaderText = "Usuario";
            dgvBitacora.Columns[0].FillWeight = 20;
            dgvBitacora.Columns[1].HeaderText = "Fecha";
            dgvBitacora.Columns[1].FillWeight = 20;
            dgvBitacora.Columns[2].HeaderText = "Hora";
            dgvBitacora.Columns[2].FillWeight = 20;
            dgvBitacora.Columns[3].HeaderText = "Accion";
            dgvBitacora.Columns[4].Visible = false;
            ConfigurarDataGridView(dgvBitacora);

        }


        private void ListarBitacoraPorUserFecha(string user, DateTime dateTime)
        {
            List<Bitacora> bitacoras = new List<Bitacora>();
            bitacoras = BitacoraService.ObtenerBitacoraPorUsuarioFecha(user,dateTime);
            dgvBitacora.DataSource = null;

            var lista = bitacoras.Select(b => new
            {
                usuario = b.usuario,
                fecha = b.fecha.ToString("dd/MM/yyyy"),
                hora = b.fecha.ToString("HH:mm:ss"),
                accion = b.accion,
                detalles = b.detalles
            }).ToList();

            dgvBitacora.DataSource = lista;

            dgvBitacora.Columns[0].HeaderText = "Usuario";
            dgvBitacora.Columns[0].FillWeight = 20;
            dgvBitacora.Columns[1].HeaderText = "Fecha";
            dgvBitacora.Columns[1].FillWeight = 20;
            dgvBitacora.Columns[2].HeaderText = "Hora";
            dgvBitacora.Columns[2].FillWeight = 20;
            dgvBitacora.Columns[3].HeaderText = "Accion";
            dgvBitacora.Columns[4].Visible = false;
            ConfigurarDataGridView(dgvBitacora);

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnBuscarUsuario_Click(sender, e);
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            try
            {
                ListarBitacoraPorFecha(dtpOnlyFecha.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnFechaUser_Click(object sender, EventArgs e)
        {
            try
            {
                ListarBitacoraPorUserFecha(txtUser.Text, dtpFecha.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }

        }
    }
}
