using BLL.Implementations;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento
{
    public partial class formIngresos : Form
    {
        public formIngresos()
        {
            InitializeComponent();
        }

        private Guid idEgreso;


        private void btnIngreso_Click(object sender, EventArgs e)
        {
           

        }

        private void ListarClientes()
        {
            /*
            comboBox1.Items.Clear();
            comboBox1.DataSource = ClienteBusiness.Current.GetAll();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idCliente";
            */
        }

        private void Listar()
        {
           /* dataIngresos.DataSource = null;
            List<Ingreso> ingresos = IngresoBusiness.Current.GetAll();
            dataIngresos.DataSource = ingresos.Select(x => new
            {
                x.idIngreso,
                x.vehiculo.patente,
                x.fechaIngreso,
                x.fechaEgreso,
                x.cliente.nombre
            }).ToList();
           */
        }

        private void formIngresos_Load(object sender, EventArgs e)
        {
            Listar();
            ListarClientes();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblFecha.Text = CargarFecha();    
            timerHora.Interval = 1000;
            timerHora.Tick += new EventHandler(TimerHora_Tick);
            timerHora.Start();
        }

        private string CargarFecha()
        {
            DateTime fechaActual = DateTime.Now;
    

            CultureInfo cultura = new CultureInfo("es-ES");

            string diaSemana = cultura.DateTimeFormat.GetDayName(fechaActual.DayOfWeek); 
            string dia = fechaActual.Day.ToString(); 
            string mes = cultura.DateTimeFormat.GetMonthName(fechaActual.Month); 
            string anio = fechaActual.Year.ToString();

            return $"{diaSemana} {dia} de {mes} de {anio}";
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss tt"); 
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if(idEgreso == Guid.Empty)
            {
                MessageBox.Show("Seleccione un ingreso");
                return;
            }
            try
            {
                var ingreso = new Ingreso
                {
                    idIngreso = idEgreso
                };
                IngresoBusiness.Current.RegistrarSalida(ingreso);
                MessageBox.Show("Salida editada correctamente");
                Listar();
                idEgreso = Guid.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void dataIngresos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
          /*  idEgreso = Guid.Parse(dataIngresos.Rows[e.RowIndex].Cells[0].Value.ToString());

            dataIngresos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            dataIngresos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

            */
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                var ingreso = new Ingreso
                {
                    cliente = new Cliente { },

                    vehiculo = new Vehiculo
                    {

                        patente = txtPatente.Text,
                    },

                };
                IngresoBusiness.Current.RegistrarEntrada(ingreso);
                MessageBox.Show("Ingreso agregado correctamente");
                Listar();
                txtPatente.Text = "";
            }
            catch (Exception ex)
            {
                txtPatente.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {

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
