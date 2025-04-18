using BLL.Implementations;
using DOMAIN;
using SERVICE.Facade.Extentions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.Domain.Observer;
using UI___Estacionamiento.PanelsMain.IngresosForms;

namespace UI___Estacionamiento.PanelsMain.FacturacionForms
{
    public partial class formFacturacionMain : Form, IFormObserver
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private formIngresoMain form;
        private Ingreso _ingreso;

        public formFacturacionMain()
        {

            InitializeComponent();
            Update(this);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formFacturacionMain_Load_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ListarFacturas()
        {
            List<Factura> facturas = FacturaBusiness.Current.GetAll();
            dgvFacturas.DataSource = null;

            var listafacturas = facturas.Select(f => new
            {
                
                Patente = f.ingreso.vehiculo.patente,
                fecha = f.fechaRegistro.ToString("dd/MM/yyyy"),
                hora = f.fechaRegistro.ToString("HH:mm:ss"),
                monto_total = f.monto_total.ToString("C", new CultureInfo("es-AR")),
                metodoPago = f.metodoPago.descripcion,
                verificador = f.verificador,
                idFactura = f.idFactura
            }).ToList();

            dgvFacturas.DataSource = listafacturas;


            dgvFacturas.Columns[0].HeaderText = "patent".Translate();
            dgvFacturas.Columns[1].HeaderText = "date".Translate();
            dgvFacturas.Columns[2].HeaderText = "hour".Translate();
            dgvFacturas.Columns[3].HeaderText = "total-mount".Translate();
            dgvFacturas.Columns[4].HeaderText = "payment-method".Translate();


            dgvFacturas.Columns[5].Visible = false;
            dgvFacturas.Columns[6].Visible = false;



            ConfigurarDataGridView(dgvFacturas);


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

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnBuscarPatente_Click(object sender, EventArgs e)
        {
            try
            {

                var lista = FacturaBusiness.Current.obtenerPorPatente(txtPatente.Text);

                dgvFacturas.DataSource = null;

                var listafacturas = lista.Select(f => new
                {
                    Patente = f.ingreso.vehiculo.patente,
                    fecha = f.fechaRegistro.ToString("dd/MM/yyyy"),
                    hora = f.fechaRegistro.ToString("HH:mm:ss"),
                    monto_total = f.monto_total.ToString("C", new CultureInfo("es-AR")),
                    metodoPago = f.metodoPago.descripcion,
                    verificador = f.verificador,
                    idFactura = f.idFactura
                }).ToList();

                dgvFacturas.DataSource = listafacturas;

                dgvFacturas.Columns[0].HeaderText = "patent".Translate();
                dgvFacturas.Columns[1].HeaderText = "date".Translate();
                dgvFacturas.Columns[2].HeaderText = "hour".Translate();
                dgvFacturas.Columns[3].HeaderText = "total-mount".Translate();
                dgvFacturas.Columns[4].HeaderText = "payment-method".Translate();

                dgvFacturas.Columns[5].Visible = false;

                dgvFacturas.Columns[6].Visible = false;

                ConfigurarDataGridView(dgvFacturas);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   

        }

   
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {

            var lista = FacturaBusiness.Current.obtenerPorFecha(dtpDesde.Value, dtpHasta.Value);

            dgvFacturas.DataSource = null;

            var listafacturas = lista.Select(f => new
            {
                Patente = f.ingreso.vehiculo.patente,
                fecha = f.fechaRegistro.ToString("dd/MM/yyyy"),
                hora = f.fechaRegistro.ToString("HH:mm:ss"),
                monto_total = f.monto_total.ToString("C", new CultureInfo("es-AR")),
                metodoPago = f.metodoPago.descripcion,
                verificador = f.verificador,
                idFactura = f.idFactura
            }).ToList();

            dgvFacturas.DataSource = listafacturas;

            dgvFacturas.Columns[0].HeaderText = "patent".Translate();
            dgvFacturas.Columns[1].HeaderText = "date".Translate();
            dgvFacturas.Columns[2].HeaderText = "hour".Translate();
            dgvFacturas.Columns[3].HeaderText = "total-mount".Translate();
            dgvFacturas.Columns[4].HeaderText = "payment-method".Translate();



            dgvFacturas.Columns[5].Visible = false;
            dgvFacturas.Columns[6].Visible = false;

            ConfigurarDataGridView(dgvFacturas);

        }

        public void Update(Form form)
        {
            lbldesde.Text = "from".Translate();
            lblhasta.Text = "to".Translate();
            lblIngresarPatente.Text = "entry-the-patent".Translate();
            btnClose.Text = "close".Translate();
            btnBuscarPatente.Text = "search".Translate();
            btnBuscarFecha.Text = "search".Translate();
            gboxdate.Text = "title-search-date".Translate();
            gboxpatente.Text = "title-search-patent".Translate();
            gboxdate.Refresh();
            gboxpatente.Refresh();
        }

        private void dgvFacturas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                var idFactura = dgvFacturas.Rows[e.RowIndex].Cells[6].Value.ToString();
                FacturaService.GenerarFactura(FacturaBusiness.Current.obtenerPorID(Convert.ToInt32(idFactura)));


            }
        }

        

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }

        }
    }
}
