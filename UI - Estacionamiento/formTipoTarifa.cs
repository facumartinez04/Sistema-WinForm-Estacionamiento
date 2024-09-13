using BLL.Implementations;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Estacionamiento
{
    public partial class formTipoTarifa : Form
    {
        public formTipoTarifa()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {

                TipoTarifaBusiness.Current.Add(new TipoTarifa()
                {
                    descripcion = txtPatente.Text,
                    monto_por_hora = Convert.ToDouble(txtPrecio.Text)
                });

                MessageBox.Show("Tipo de tarifa agregada correctamente");

                Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }

        private void Listar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TipoTarifaBusiness.Current.GetAll();
        }

        private void formTipoTarifa_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
