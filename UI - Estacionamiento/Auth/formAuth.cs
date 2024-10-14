using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SERVICE.Facade;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Drawing.Text;
using SERVICE.Domain.Composite;
using UI___Estacionamiento.Domain.Observer;
using SERVICE.Facade.Extentions;

namespace UI___Estacionamiento.Auth
{
    public partial class s : Form
    {


        private static List<IFormObserver> formularios = new List<IFormObserver>();


        private Form activeForm;

        public s()
        {
            InitializeComponent();
        }

       


        //public void AbrirForm(Form childForm)
        //{
        //    if (activeForm != null) activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelContenedor.Controls.Add(childForm);
        //    panelContenedor.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

  

        private void formAuth_Load(object sender, EventArgs e)
        {
        }

     
        private void BtnInicioSesion_Click(object sender, EventArgs e)
            {
                try
                {
                    Logear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        public static void Detach(IFormObserver formulario)
        {
            formularios.Remove(formulario);
        }

        private void S_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            ActualizarLabels();
            lblContra.PasswordChar = '*';
        }

        private void LblContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                Logear();
            }
        }

        public void Notify()
        {
            foreach (IFormObserver formulario in formularios)
            {
                formulario.Update(this);
            }
        }

        public static void Attach(IFormObserver formulario)
        {
            formularios.Add(formulario);
        }


        private void Logear()
        {
            try
            {
                Usuario user = new Usuario();
                user.Username = lblUser.Text;
                user.Password = lblContra.Text;

                LoginService.Validate(user);

                MessageBox.Show("Usuario logueado con exito");



                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            formAuthRegister formAuthRegister = new formAuthRegister(this);
            formAuthRegister.Show();

            this.Hide();

        }

        private void CargarIdioma()
        {
            CultureInfo culture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            foreach (IFormObserver formulario in formularios)
            {
                formulario.Update(this);
            }
        }


        private void ActualizarLabels()
        {

            btnInicioSesion.Text = "login".Translate();
        }


    }
}
