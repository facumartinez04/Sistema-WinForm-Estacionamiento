using SERVICE.DAL.Implementations;
using SERVICE.Domain;
using SERVICE.Domain.Composite;
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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI___Estacionamiento.Domain.Observer;
using UI___Estacionamiento.PanelsMain;

namespace UI___Estacionamiento.Auth
{
    public partial class formAuthMain : Form
    {

        private static List<IFormObserver> formularios = new List<IFormObserver>();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formAuthMain()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {


                var Usuario = new Usuario()
                {
                    UserName = txtUsuario.Text,
                    Password = txtContra.Text
                };

                var data = CryptographyService.HashPassword(Usuario.Password);

                
                Usuario userCargado = LoginService.Validate(Usuario);

                MessageBox.Show("user-login-success".Translate());

                List<Patente> list = new List<Patente>();
                list = userCargado.GetAllPatentes();

                SessionService.SetUsuario(userCargado);

                this.Hide();

                formMain form = new formMain(this);
                form.Show();

                txtContra.Text = "";
                txtUsuario.Text = "";
                AddFormularios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }

        }


        public static void Detach(IFormObserver formulario)
        {
            formularios.Remove(formulario);
        }


        public void Notify()
        {
            foreach (IFormObserver formulario in formularios)
            {
                formulario.Update(this);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formAuthMain_Load(object sender, EventArgs e)
        {
          
        }

        public void SetLenguaje(string leng)
        {
            if(leng == "es-ES")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                Notify();
            }
            else
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                Notify();   
            }
        }

        private void AddFormularios()
        {
            formularios.Add(new formMain(this));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAuthRegister form = new formAuthRegister();
            form.Show();
        }
    }
}
