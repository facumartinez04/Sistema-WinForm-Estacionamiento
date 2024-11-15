using BLL.Implementations;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.PanelsMain.MetodoPagoForms
{
    public partial class formMetodoPagoMain : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private MetodoPago _metodoPago;

        public formMetodoPagoMain()
        {
            InitializeComponent();
        }

        private void btnEditarAddMP_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEditarAddMP.Text == "Agregar")
                {
                    NuevoMetodoPago();
                }
                else
                {
                    EditarMetodoPago();
                }

                txtMetodoPago.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }


        }

        private void NuevoMetodoPago()
        {
            MetodoPago metodo = new MetodoPago();

            metodo.descripcion = txtMetodoPago.Text;

            MetodoPagoBusiness.Current.Add(metodo);

            ListarMetodos();

        }

        private void EditarMetodoPago()
        {
            MetodoPago metodo = new MetodoPago();

            metodo.idMetodoPago = _metodoPago.idMetodoPago;

            metodo.descripcion = txtMetodoPago.Text;



            MetodoPagoBusiness.Current.Update(metodo);

            ListarMetodos();

            _metodoPago = null;

            btnEditarAddMP.Text = "Agregar";
        }

        private void ListarMetodos()
        {
            DBMetodosPago.DataSource = null;

            List<MetodoPago> metodos = MetodoPagoBusiness.Current.GetAll();

            DBMetodosPago.DataSource = metodos;

            DBMetodosPago.Columns["idMetodoPago"].Visible = false;

            DBMetodosPago.Columns["descripcion"].HeaderText = "Nombre de Metodo de Pago";


            ConfigurarDataGridView(DBMetodosPago);

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

        private void formMetodoPagoMain_Load(object sender, EventArgs e)
        {
            ListarMetodos();

        }

        private void DBMetodosPago_DoubleClick(object sender, EventArgs e)
        {
            txtMetodoPago.Text = DBMetodosPago.CurrentRow.Cells["descripcion"].Value.ToString();

            _metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(int.Parse(DBMetodosPago.CurrentRow.Cells["idMetodoPago"].Value.ToString()));




            btnEditarAddMP.Text = "Editar";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMetodoPagoMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
