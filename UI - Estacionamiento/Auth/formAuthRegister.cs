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
    public partial class formAuthRegister : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public formAuthRegister()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';

            MessageBox.Show(
            "¡Bienvenido a nuestro sistema de estacionamiento!\n\n" +
            "Como es la primera vez que accedes, la cuenta que estás creando será configurada como Administrador. " +
            "Asegúrate de usar credenciales seguras y guardar esta información de acceso en un lugar seguro.",
            "Configuración Inicial - Administrador",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUsuario.Text == "" || txtContra.Text == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos");
                }
                else
                {
                   
                        var user = new Usuario();
                        user.UserName = txtUsuario.Text;
                        user.Password = txtContra.Text;
                        
                        LoginService.Register(user);
                        MessageBox.Show("Usuario registrado con exito");
                        this.Hide();
                        formAuthMain formAuthMain = new formAuthMain();
                        formAuthMain.Show();
                        Properties.Settings.Default.IsFirstTime = false;
                        Properties.Settings.Default.Save();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReg_Click(sender, e);
            }

        }
    }
}
