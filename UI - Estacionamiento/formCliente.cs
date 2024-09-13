using BLL.Implementations;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente { 
                    nombre = txtNombre.Text,
                    dni = Convert.ToInt32(txtDni.Text),
                    fechaNacimiento = Convert.ToDateTime(dataNacimiento.Text)

                };
                ClienteBusiness.Current.Add(cliente);
                MessageBox.Show("Cliente agregado correctamente");
                Listar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Listar()
        {
            dataClientes.DataSource = null;
            dataClientes.DataSource = ClienteBusiness.Current.GetAll();

        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
