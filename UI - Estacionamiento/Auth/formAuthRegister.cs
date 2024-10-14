using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento.Auth
{
    public partial class formAuthRegister : Form
    {

        private s _formAuth;


        public formAuthRegister(s formAuth)
        {

            InitializeComponent();
            _formAuth = formAuth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAuthRegister_Load(object sender, EventArgs e)
        {
            lblContra.PasswordChar = '*';
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario user = new Usuario();
                user.Username = lblUser.Text;
                user.Password = lblContra.Text;

                CheckContras();
                LoginService.Register(user);

                MessageBox.Show("Usuario registrado con exito");

                _formAuth.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckContras()
        {
            if (lblContra.Text != lblConfirmar.Text)
            {
                throw new Exception("Las contraseñas no coinciden");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            _formAuth.Show();
            this.Hide();

        }
    }
}
