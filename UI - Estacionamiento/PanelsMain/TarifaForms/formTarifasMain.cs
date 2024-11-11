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

namespace UI___Estacionamiento.PanelsMain.TarifaForms
{
    public partial class formTarifasMain : Form
    {

        private int idEditTarifa;

        public formTarifasMain()
        {
            InitializeComponent();
        }

        private void btnAddEditTarifa_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnAddEditTarifa.Text == "Agregar")
                {
                    NuevaTarifa();
                }
                else{
                    EditarTarifa();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }



        private void CargarListaTarifas()
        {
            DBTarifasList.DataSource = null;

            List<TipoTarifa> tarifas = TipoTarifaBusiness.Current.GetAll();

            DBTarifasList.DataSource = tarifas;
        }

        private void formTarifasMain_Load(object sender, EventArgs e)
        {
            CargarListaTarifas();
        }

        private void NuevaTarifa()
        {
            var objTarifa = new TipoTarifa
            {
                descripcion = txtNombreTarifa.Text,
                monto_por_hora = Convert.ToDouble(txtMontoTarifa.Text)
            };

            TipoTarifaBusiness.Current.Add(objTarifa);
            MessageBox.Show("Se ingreso una nueva tarifa correctamente");
            CargarListaTarifas();

        }

        private void EditarTarifa()
        {
            var objTarifa = new TipoTarifa
            {
                idTipoTarifa = idEditTarifa,
                descripcion = txtNombreTarifa.Text,
                monto_por_hora = Convert.ToDouble(txtMontoTarifa.Text)
            };

            TipoTarifaBusiness.Current.Update(objTarifa);
            MessageBox.Show("Se edito la tarifa correctamente");
            CargarListaTarifas();
            LimpiarTextBox();
            idEditTarifa = 0;
            btnAddEditTarifa.Text = "Agregar";

        }


        private void LimpiarTextBox()
        {
            txtMontoTarifa.Text = "";
            txtNombreTarifa.Text = "";
        }

        private void DBTarifasList_DoubleClick(object sender, EventArgs e)
        {
            try
            {





                if (DBTarifasList.SelectedRows.Count > 0)
                {
                    idEditTarifa = Convert.ToInt32(DBTarifasList.SelectedRows[0].Cells["idTipoTarifa"].Value);
                    txtNombreTarifa.Text = DBTarifasList.SelectedRows[0].Cells["descripcion"].Value.ToString();
                    txtMontoTarifa.Text = DBTarifasList.SelectedRows[0].Cells["monto_por_hora"].Value.ToString();
                    btnAddEditTarifa.Text = "Editar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }
    }
}
