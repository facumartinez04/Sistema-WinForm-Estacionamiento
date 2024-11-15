using BLL.Implementations;
using DOMAIN;
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
using UI___Estacionamiento.PanelsMain.FacturacionForms;

namespace UI___Estacionamiento.PanelsMain.IngresosForms
{
    public partial class formIngresoMain : Form
    {
        private Ingreso _ingresoseleccionado;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formIngresoMain()
        {
            InitializeComponent();
        }

        private void formIngresoMain_Load(object sender, EventArgs e)
        {
            ListarIngresos();
            ListarComboTarifas();
            CargarHora();
            lblMes.Text = DateTime.Now.ToString("MMMM", new CultureInfo("es-ES"));
            lblDia.Text = DateTime.Now.ToString("dd", new CultureInfo("es-ES"));
            lblAno.Text = DateTime.Now.ToString("yyyy");
            txtPatente.MaxLength = 9;


            horayDiaIngreso.Interval = 1000;
            horayDiaIngreso.Tick += new EventHandler(horayDiaIngreso_Tick);
            horayDiaIngreso.Start();
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



            DBIngresosList.Columns["PatenteVehiculo"].HeaderText = "Patente";
            DBIngresosList.Columns["IngresoFecha"].HeaderText = "Fecha";
            DBIngresosList.Columns["Horario"].HeaderText = "Horario";
            DBIngresosList.Columns["TipoDeTarifa"].HeaderText = "Tarifa";


        }

        private void ListarComboTarifas()
        {
            cmbTarifas.DataSource = null;
            cmbTarifas.Items.Clear();
            cmbTarifas.DataSource = TipoTarifaBusiness.Current.GetAll();
            cmbTarifas.ValueMember = "idTipoTarifa";
            cmbTarifas.DisplayMember = "descripcion";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var objIngreso = new Ingreso
                {
                    vehiculo = new Vehiculo
                    {
                        patente = txtPatente.Text.ToUpper(),
                    },
                    objTipoTarifa = new TipoTarifa
                    {
                        idTipoTarifa = (int)cmbTarifas.SelectedValue
                    }

                };

                IngresoBusiness.Current.RegistrarEntrada(objIngreso);
                MessageBox.Show("Vehiculo ingresado correctamente");
                ListarIngresos();
                txtPatente.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CargarHora()
        {

            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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

    

        private void DBIngresosList_DoubleClick(object sender, EventArgs e)
        {
            if (DBIngresosList.CurrentRow != null)
            {
                var selectedRow = DBIngresosList.CurrentRow;

                Guid patenteVehiculo = (Guid)selectedRow.Cells["idIngreso"].Value;

                _ingresoseleccionado = IngresoBusiness.Current.GetById(patenteVehiculo);

                

                _ingresoseleccionado = null;
            }
        }

        private void formIngresoMain_Enter(object sender, EventArgs e)
        {
            ListarIngresos();


        }

        private void horayDiaIngreso_Tick(object sender, EventArgs e)
        {

            CargarHora();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearPatente_Click(object sender, EventArgs e)
        {
            txtPatente.Text = "";
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {



        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListarIngresos();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();


            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
