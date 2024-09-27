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
    public partial class formSalidas : Form
    {

        private Guid idIngresoPrueba;


        public formSalidas()
        {
            InitializeComponent();
        }

        private Ingreso ingreso;

        private void formSalidas_Load(object sender, EventArgs e)
        {
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


        private TimeSpan ComprobarTiempo()
        {
            DateTime fechaActual = DateTime.Now;

            DateTime fechaIngreso = DateTime.Parse(ingreso.fechaIngreso.ToString());

            TimeSpan tiempo = fechaActual - fechaIngreso;



            return tiempo;

        }



        private void TimerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss tt");

            if (ingreso != null)
            {
                TimeSpan tiempo = ComprobarTiempo();
                lbltiempotrans.Text = $" {tiempo.Days} dias {tiempo.Hours} horas {tiempo.Minutes} minutos {tiempo.Seconds} segundos";
            }
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                var pantenteGuardada = txtPatente.Text;
                e.Handled = true;
                LimpiarLbls();
                try
                    {

                    ingreso = null; 
                    ingreso = IngresoBusiness.Current.IngresosActuales().FirstOrDefault(x => x.vehiculo.patente == pantenteGuardada);


                 

                    if (ingreso == null)
                    {
                        MessageBox.Show("No se encontro la patente");
                        return;
                    }
                    
                    lblpatente.Text = ingreso.vehiculo.patente;
                    lblhorario.Text = DateTime.Parse(ingreso.fechaIngreso.ToString()).ToString("HH:mm:ss tt");
                    lblFechaI.Text = DateTime.Parse(ingreso.fechaIngreso.ToString()).ToString("dd/MM/yyyy");
                    ComprobarTiempo();
                    idIngresoPrueba = ingreso.idIngreso;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }


        private void LimpiarLbls()
        {
            lblFechaI.Text = "";
            txtPatente.Text = "";
            lblhorario.Text = "";
            lbltiempotrans.Text = "";
            lblpatente.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idIngresoPrueba == Guid.Empty)
            {
                MessageBox.Show("Seleccione un ingreso");
                return;
            }
            try
            {
                var ingreso = new Ingreso
                {
                    idIngreso = idIngresoPrueba
                };
                IngresoBusiness.Current.RegistrarSalida(ingreso);
                MessageBox.Show("El vehiculo salio correctamente");

                idIngresoPrueba = Guid.Empty;
                LimpiarLbls();
                timerHora.Stop();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
