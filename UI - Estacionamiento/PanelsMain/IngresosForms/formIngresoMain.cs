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

namespace UI___Estacionamiento.PanelsMain.IngresosForms
{
    public partial class formIngresoMain : Form
    {
        public formIngresoMain()
        {
            InitializeComponent();
        }

        private void formIngresoMain_Load(object sender, EventArgs e)
        {
            ListarIngresos();
            ListarComboTarifas();
        }

        private void ListarIngresos()
        {
            DBIngresosList.DataSource = null;

            List<Ingreso> ingresos = new List<Ingreso>();

            DBIngresosList.DataSource = ingresos;





        }

        private void ListarComboTarifas()
        {
            cmbTarifas.DataSource = null;
            cmbTarifas.Items.Clear();
            cmbTarifas.DataSource = TipoTarifaBusiness.Current.GetAll();
            cmbTarifas.ValueMember = "idTipoTarifa";
            cmbTarifas.DisplayMember = "descripcion";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var objIngreso = new Ingreso
                {
                    vehiculo = new Vehiculo
                    {
                        patente = txtPatente.Text,
                    },
                    objTipoTarifa = new TipoTarifa
                    {
                        idTipoTarifa = (int)cmbTarifas.SelectedValue
                    }

                };

                IngresoBusiness.Current.RegistrarEntrada(objIngreso);
                MessageBox.Show("Vehiculo ingresado correctamente");
                ListarIngresos();
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
