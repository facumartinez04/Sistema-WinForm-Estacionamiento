using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
using SERVICE.Services;
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

namespace UI___Estacionamiento.Auth
{
    public partial class formAuthMain : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formAuthMain()
        {
            InitializeComponent();
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

                Usuario userCargado = LoginService.Validate(Usuario);

                MessageBox.Show("Usuario logueado con exito");

                List<Patente> list = new List<Patente>();
                list = userCargado.GetAllPatentes();
                foreach (Patente item in list) {
                    MessageBox.Show(item.Nombre);
                }




                this.Hide();



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
    }
}
