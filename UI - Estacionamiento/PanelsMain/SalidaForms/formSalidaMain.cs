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
using UI___Estacionamiento.PanelsMain.FacturacionForms;

namespace UI___Estacionamiento.PanelsMain.SalidaForms
{
    public partial class formSalidaMain : Form, IFormObserver
    {

        private Ingreso _ingreso;


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public formSalidaMain()
        {
            InitializeComponent();
            Update(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void ListarIngresos()
        {
            DBIngresosList.DataSource = null;

            List<Ingreso> ingresos = IngresoBusiness.Current.IngresosActuales();

            var listaResumen = ingresos.Select(i => new
            {
                idIngreso = i.idIngreso,
                PatenteVehiculo = i.vehiculo.patente,
                IngresoFecha = i.fechaIngreso.ToString("dd/MM/yyyy"),
                Horario = i.fechaIngreso.ToString("HH:mm:ss"),
                TipoDeTarifa = i.objTipoTarifa.descripcion
            }).ToList();

            DBIngresosList.DataSource = listaResumen;

            ConfigurarDataGridView(DBIngresosList);

            DBIngresosList.Columns["idIngreso"].Visible = false;



            DBIngresosList.Columns["PatenteVehiculo"].HeaderText = "patent".Translate();
            DBIngresosList.Columns["IngresoFecha"].HeaderText = "date".Translate();
            DBIngresosList.Columns["Horario"].HeaderText = "time".Translate();
            DBIngresosList.Columns["TipoDeTarifa"].HeaderText = "rate".Translate();


        }

        private void formSalidaMain_Load(object sender, EventArgs e)
        {
            ListarIngresos();
            CargarLabels();
            CargarTiempos();
            tiempos.Interval = 1000;
            tiempos.Tick += new EventHandler(tiempos_Tick);
            tiempos.Start();

            this.MouseDown += new MouseEventHandler(formSalidaMain_MouseDown);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarLabels()
        {
            lblDiaSalida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraSalida.Text = DateTime.Now.ToString("HH:mm:ss");

            if(_ingreso != null)
            {

                lblDiaIngreso.Text = _ingreso.fechaIngreso.ToString("dd/MM/yyyy");
                lblHoraIngreso.Text = _ingreso.fechaIngreso.ToString("HH:mm:ss");
            }
        }

        private void CargarTiempos()
        {

            lblHoraSalida.Text = DateTime.Now.ToString("HH:mm:ss");
            if (_ingreso != null)
            {
                lblDiaTranscurrido.Text = (DateTime.Now - _ingreso.fechaIngreso).Days.ToString();
                lblHorasTranscurridas.Text = (DateTime.Now - _ingreso.fechaIngreso).Hours.ToString();
                lblMinutosTranscurridos.Text = (DateTime.Now - _ingreso.fechaIngreso).Minutes.ToString();
                lblsegundosTranscurridos.Text = (DateTime.Now - _ingreso.fechaIngreso).Seconds.ToString();



            }

        }

        private void tiempos_Tick(object sender, EventArgs e)
        {
            CargarTiempos();
        }

        private void searchPatente_Click(object sender, EventArgs e)
        {
            try
            {


                
                Ingreso ingreso = IngresoBusiness.Current.BuscarUnaPatente(txtPatente.Text);

                _ingreso = ingreso;

                MessageBox.Show("patente-search-success".Translate());

                CargarTiempos();
                CargarLabels();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                LimpiarTodo();


            }
        }

        private void ClearTodo_Click(object sender, EventArgs e)
        {
            txtPatente.Text = "";
            _ingreso = null;
            CargarLabels();
            CargarTiempos();
            lblDiaIngreso.Text = "00:00:00";
            lblHoraIngreso.Text = "00/00/0000";
            lblHorasTranscurridas.Text = "00";
            lblMinutosTranscurridos.Text = "00";
            lblsegundosTranscurridos.Text = "00";
            lblDiaTranscurrido.Text = "00";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListarIngresos();

        }

        public void LimpiarTodo()
        {
            ClearTodo_Click(null, null);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (_ingreso == null)
            {
                MessageBox.Show("have-to-enter-the-patent".Translate());
                return;
            }
            formFacturacionPago formFacturacionPago = new formFacturacionPago(_ingreso,this);
            formFacturacionPago.Show();

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void formSalidaMain_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                searchPatente_Click(sender, e);
            }

        }

        public void Update(Form form)
        {
            lblpatente.Text = "patent".Translate();
            lblIngresados.Text = "vehicles-entered".Translate();
            lblfechahorarioIngreso.Text = "date-and-hour-joined".Translate();
            label8lblfechahorarioSalida.Text = "date-and-hour-exited".Translate();
            btnPagar.Text = "charge".Translate();
            lblday.Text = "days".Translate();
            lblhours.Text = "hours".Translate();
            lblminutes.Text = "minutes".Translate();
            lblseconds.Text = "seconds".Translate();
            btnClose.Text = "close".Translate();
            gbtiempotrans.Text = "time-elapsed".Translate();
        }
    }
}
