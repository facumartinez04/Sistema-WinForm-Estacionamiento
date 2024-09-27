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
    public partial class formAuthLogin : Form
    {

        private formAuth _formAuth;


        public formAuthLogin(formAuth formAuth)
        {
            _formAuth = formAuth;

            InitializeComponent();
        }

        private void formAuthLogin_Load(object sender, EventArgs e)
        {
            txtContra.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Username = txtUsuario.Text;
                user.Password = txtContra.Text;

                LoginService.Validate(user);

                MessageBox.Show("Usuario logueado con exito");



                this.Close();
                _formAuth.Hide();


                Form1 form1 = new Form1();  
                form1.Show();







            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
         



        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
            
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
