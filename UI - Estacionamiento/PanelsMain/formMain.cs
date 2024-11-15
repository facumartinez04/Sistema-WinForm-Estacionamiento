using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.PanelsMain.FacturacionForms;
using UI___Estacionamiento.PanelsMain.HistorialForms;
using UI___Estacionamiento.PanelsMain.IngresosForms;
using UI___Estacionamiento.PanelsMain.MetodoPagoForms;
using UI___Estacionamiento.PanelsMain.SalidaForms;
using UI___Estacionamiento.PanelsMain.TarifaForms;

namespace UI___Estacionamiento.PanelsMain
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            ActualizarDiayHorario();
            horarioDia.Interval = 1000;
            horarioDia.Tick += new EventHandler(horarioDia_Tick);
            horarioDia.Start();


        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.StartPosition = FormStartPosition.Manual;

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;

            CenterFormInPanel(formHijo);
            formHijo.Show();


            this.Resize += (s, e) => CenterFormInPanel(formHijo);
        }

        private void CenterFormInPanel(Form formHijo)
        {
            formHijo.Location = new Point(
                (this.panelContenedor.Width - formHijo.Width) / 2,
                (this.panelContenedor.Height - formHijo.Height) / 2
            );
        }

        private void ActualizarDiayHorario()
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHorario.Text = DateTime.Now.ToString("hh:mm:ss tt");    
        }

        private void lblHorario_Click(object sender, EventArgs e)
        {

            

        }

        private void horarioDia_Tick(object sender, EventArgs e)
        {
            ActualizarDiayHorario();
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formIngresoMain());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formFacturacionMain());

        }

        private void btnTarifa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formTarifasMain());
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formMetodoPagoMain());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formHistorialMain());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formSalidaMain());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
