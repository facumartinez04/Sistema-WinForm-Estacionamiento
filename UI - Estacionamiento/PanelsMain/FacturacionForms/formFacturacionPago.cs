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
using UI___Estacionamiento.PanelsMain.IngresosForms;

namespace UI___Estacionamiento.PanelsMain.FacturacionForms
{
    public partial class formFacturacionPago : Form
    {

        private Ingreso _ingreso;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public formFacturacionPago(Ingreso ingreso)
        {
            _ingreso = ingreso;
            InitializeComponent();
        }
        private void formFacturacionPago_Load(object sender, EventArgs e)
        {
            CargarLabels();
            this.MouseDown += new MouseEventHandler(panel2_MouseDown);
            this.Paint += formFacturacionPago_Paint;
            CargarTiempos();
            tiempos.Interval = 1000;
            tiempos.Tick += new EventHandler(tiempos_Tick_1);
            tiempos.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }


        private void CargarLabels()
        {
            lblDiaSalida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraSalida.Text = DateTime.Now.ToString("HH:mm:ss tt");
            txtPatente.Text = _ingreso.vehiculo.patente;
            txtTarifa.Text = _ingreso.objTipoTarifa.descripcion;
            txtMontoHora.Text = _ingreso.objTipoTarifa.monto_por_hora.ToString("C");
            txtCobro.Text = _ingreso.CalcularImporte(_ingreso.fechaIngreso,DateTime.Now,_ingreso.objTipoTarifa).ToString("C");

            if (_ingreso != null)
            {

                lblDiaIngreso.Text = _ingreso.fechaIngreso.ToString("dd/MM/yyyy");
                lblHoraIngreso.Text = _ingreso.fechaIngreso.ToString("HH:mm:ss tt");
            }
        }

        private void CargarTiempos()
        {

            lblHoraSalida.Text = DateTime.Now.ToString("HH:mm:ss tt");
            if (_ingreso != null)
            {
                lblDiaTranscurrido.Text = (DateTime.Now - _ingreso.fechaIngreso).Days.ToString();
                lblHorasTranscurridas.Text = (DateTime.Now - _ingreso.fechaIngreso).Hours.ToString();
                lblMinutosTranscurridos.Text = (DateTime.Now - _ingreso.fechaIngreso).Minutes.ToString();
                lblsegundosTranscurridos.Text = (DateTime.Now - _ingreso.fechaIngreso).Seconds.ToString();



            }

        }
     
        private void tiempos_Tick_1(object sender, EventArgs e)
        {
               CargarTiempos();
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();

            Close();
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formFacturacionPago_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
