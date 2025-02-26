using BLL.Implementations;
using DOMAIN;
using SERVICE.Facade.Extentions;
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
using UI___Estacionamiento.Domain.Observer;

namespace UI___Estacionamiento.PanelsMain.HistorialForms
{
    public partial class formHistorialMain : Form, IFormObserver
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public formHistorialMain()
        {
            InitializeComponent();
            Update(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            try
            {

                ListarPorFecha();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarFechas()
        {
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dd/MM/yyyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd/MM/yyyy";
        }

        private void formHistorialMain_Load(object sender, EventArgs e)
        {
             CargarFechas();
            this.MouseDown += new MouseEventHandler(formHistorialMain_MouseDown);
        }

        private void ListarPorFecha()
        {
            dataGridView1.DataSource = null;

            List<Ingreso> ingresos = IngresoBusiness.Current.ListarPorFechas(Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value));


            var listaResumen = ingresos.Select(i => new
            {
                PatenteVehiculo = i.vehiculo.patente,
                FechaIngreso = i.fechaIngreso.ToString("dd/MM/yyyy"),
                FechaSalida = i.fechaEgreso?.ToString("dd/MM/yyyy"),
                HorarioIngreso = i.fechaIngreso.ToString("HH:mm:ss"),
                HorarioEgreso = i.fechaEgreso?.ToString("HH:mm:ss"),
                TipoDeTarifa = i.objTipoTarifa.descripcion,
            }).ToList();

            dataGridView1.DataSource = listaResumen;


            dataGridView1.Columns["PatenteVehiculo"].HeaderText = "patent".Translate();

            dataGridView1.Columns["FechaIngreso"].HeaderText = "date-joined".Translate();

            dataGridView1.Columns["FechaSalida"].HeaderText = "date-exited".Translate();

            dataGridView1.Columns["HorarioIngreso"].HeaderText = "hour-joined".Translate();

            dataGridView1.Columns["HorarioEgreso"].HeaderText = "hour-exited".Translate();

            dataGridView1.Columns["TipoDeTarifa"].HeaderText = "rate".Translate();


            ConfigurarDataGridView(dataGridView1);




        }



            private void ListarPorPatente()
            {
                dataGridView1.DataSource = null;
                List<Ingreso> ingresos = IngresoBusiness.Current.BuscarPorPatente(txtPatente.Text);

            var resumido = ingresos.Select(i => new
                {
                    PatenteVehiculo = i.vehiculo.patente,
                    FechaIngreso = i.fechaIngreso.ToString("dd/MM/yyyy"),
                    FechaSalida = i.fechaEgreso?.ToString("dd/MM/yyyy"),
                    HorarioIngreso = i.fechaIngreso.ToString("HH:mm:ss"),
                    HorarioEgreso = i.fechaEgreso?.ToString("HH:mm:ss"),
                    TipoDeTarifa = i.objTipoTarifa.descripcion
                }).ToList();

                dataGridView1.DataSource = resumido;



                dataGridView1.Columns["PatenteVehiculo"].HeaderText = "patent".Translate();

                dataGridView1.Columns["FechaIngreso"].HeaderText = "date-joined".Translate();

                dataGridView1.Columns["FechaSalida"].HeaderText = "date-exited".Translate();

                dataGridView1.Columns["HorarioIngreso"].HeaderText = "hour-joined".Translate();

                dataGridView1.Columns["HorarioEgreso"].HeaderText = "hour-exited".Translate();

                dataGridView1.Columns["TipoDeTarifa"].HeaderText = "rate".Translate();


            ConfigurarDataGridView(dataGridView1);


            



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

        private void btnBuscarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                ListarPorPatente();
                txtPatente.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void formHistorialMain_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        public void Update(Form form)
        {
            gbseachpatente.Text = "title-search-patent".Translate();
            gbsearchfechas.Text = "title-search-date".Translate();
            lbldesde.Text = "from".Translate();
            lblhasta.Text = "to".Translate();

            btnBuscarFecha.Text = "search".Translate();
            btnBuscarPatente.Text = "search".Translate();
            lblPatente.Text = "patent".Translate();
            btnClose.Text = "close".Translate();
        }
    }
}
