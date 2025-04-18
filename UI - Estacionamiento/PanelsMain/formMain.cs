using BLL.Implementations;
using SERVICE.Domain.Composite;
using SERVICE.Facade.Extentions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.Auth;
using UI___Estacionamiento.Domain.Observer;
using UI___Estacionamiento.PanelsMain.AdminForms;
using UI___Estacionamiento.PanelsMain.FacturacionForms;
using UI___Estacionamiento.PanelsMain.HistorialForms;
using UI___Estacionamiento.PanelsMain.IngresosForms;
using UI___Estacionamiento.PanelsMain.MetodoPagoForms;
using UI___Estacionamiento.PanelsMain.SalidaForms;
using UI___Estacionamiento.PanelsMain.TarifaForms;
using UI___Estacionamiento.PanelsMain.VehiculoForms;

namespace UI___Estacionamiento.PanelsMain
{
    public partial class formMain : Form, IFormObserver
    {
        private Usuario _user;
        private int previousFormHeight;
        private formAuthMain _formAuthMain;
        public formMain(formAuthMain formAuthMain)
        {
            _formAuthMain = formAuthMain;
            _user = SessionService.GetUsuario();

            InitializeComponent();

            ListarPorPermisos();
            previousFormHeight = this.Height;



            this.Shown += formMain_Shown;

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ActualizarDiayHorario();
            horarioDia.Interval = 1000;
            horarioDia.Tick += new EventHandler(horarioDia_Tick);
            horarioDia.Start();

            lblUser.Text = _user.UserName.ToUpper();

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


        private void ListarPorPermisos()
        {

            if (_user.GetFamilias().FirstOrDefault(x => x.NombreFamilia == "Administrador") != null) return;
            


            List<Patente> patentes = _user.GetAllPatentes();



            button4.Visible = false;
            button1.Visible = false;
            btnTarifa.Visible = false;
            btnMetodoPago.Visible = false;
            btnHistorial.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            btnVehiculo.Visible = false;






            foreach (var patente in patentes)
            {
                switch (patente.DataKey)
                {
                    case "mnuIngresos":
                        button4.Visible = true;
                        break;
                    case "mnuFacturacion":
                        button1.Visible = true;
                        break;
                    case "mnuTarifas":
                        btnTarifa.Visible = true;
                        break;
                    case "mnuMetodosPago":
                        btnMetodoPago.Visible = true;
                        break;
                    case "mnuHistorial":
                        btnHistorial.Visible = true;
                        break;
                    case "mnuSalidas":
                        button2.Visible = true;
                        break;
                    case "mnuAdmin":
                        button3.Visible = true;
                        break;
                    case "mnuVehiculos":
                        btnVehiculo.Visible = true;
                        break;
                }
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            _formAuthMain.Show();
            SessionService.Clear();
            this.Close();

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formAdminMain());
        }

        private void formMain_Click(object sender, EventArgs e)
        {


        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SessionService.IsLogged())
            {
                BackupService.RealizarBackup("MainConString", "Estacionamiento");
                BackupService.RealizarBackup("ServicesPP", "ServicesPP");
                Application.Exit();
            }
            else
            {

                _formAuthMain.Show();
            }
        }

        public void Update(Form form)
        {
            string translatedText = "income".Translate();
            button4.Text = translatedText;
            button4.Visible = true;
            button4.Enabled = true;



            lblautosingresados.Text = IngresoBusiness.Current.GetCountIngresosActuales().ToString();
            lblingresosdia.Text = IngresoBusiness.Current.GetCountIngresoDelDia().ToString();
            button1.Text = "billing".Translate();
            btnTarifa.Text = "rates".Translate();
            btnMetodoPago.Text = "payment-methods".Translate();
            btnHistorial.Text = "history".Translate();
            btnCerrar.Text = "logout".Translate();
            button2.Text = "leaves".Translate();
            button3.Text = "admin".Translate();
            lblwelcome.Text = "welcome".Translate();
            btnVehiculo.Text = "vehicles".Translate();
            lblSelectIdioma.Text = "select-language".Translate();
            form.Invalidate();
            form.Refresh();

        }

        private void spainLeng_Click(object sender, EventArgs e)
        {
            _formAuthMain.SetLenguaje("es-ES");
            ReloadForm();
        }

        private void EngLeng_Click(object sender, EventArgs e)
        {
            _formAuthMain.SetLenguaje("en-US");

            ReloadForm();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            
            Update(this);
        }

        public void ReloadForm()
        {

            Form parent = this.Owner;

            this.Dispose();

            formMain newForm = new formMain(_formAuthMain);

            if (parent != null)
            {
                newForm.Owner = parent;
            }

            newForm.Show();
        }
        
        private void formMain_Resize(object sender, EventArgs e)
        {
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            int maxPanel4Height = 85;
            int maxPanel2Height = 43;
            int maxPanel3Height = 100;

            int panel4Height = Math.Min(maxPanel4Height, panelHeight);
            panelHeight -= panel4Height;

            int panel2Height = Math.Min(maxPanel2Height, panelHeight);
            panelHeight -= panel2Height;

            int panel3Height = Math.Min(maxPanel3Height, panelHeight);
            panelHeight -= panel3Height;

            int panelBotonesHeight = Math.Max(panelHeight, 0);

            panel4.Width = panelWidth;
            panel4.Height = panel4Height;
            panel4.Location = new Point(0, 0);

            panel3.Width = panelWidth;
            panel3.Height = panel3Height;
            panel3.Location = new Point(0, panel4Height + panel2Height);

            panelbotones.Width = panelWidth;
            panelbotones.Height = panelBotonesHeight;
            panelbotones.Location = new Point(0, panel4Height + panel2Height + panel3Height);

            AdjustButtonsInPanel(panelbotones);
        }

        private void AdjustButtonsInPanel(Panel panelBotones)
        {
            int buttonCount = panelBotones.Controls.OfType<Button>().Count();
            if (buttonCount == 0) return;

            int availableHeight = panelBotones.Height;
            int buttonHeight = Math.Min(78, availableHeight / buttonCount);

            int yOffset = 0;
            foreach (Control control in panelBotones.Controls)
            {
                if (control is Button button)
                {
                    button.Width = panelBotones.Width;
                    button.Height = buttonHeight;
                    button.Location = new Point(0, yOffset);
                    yOffset += buttonHeight;
                }
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formVehiculoMain());

        }
    }
}
