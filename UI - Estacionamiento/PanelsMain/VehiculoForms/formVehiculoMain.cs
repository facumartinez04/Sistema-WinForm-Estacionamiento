using BLL.Implementations;
using DOMAIN;
using SERVICE.Facade.Extentions;
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
using UI___Estacionamiento.Domain.Observer;

namespace UI___Estacionamiento.PanelsMain.VehiculoForms
{
    public partial class formVehiculoMain : Form, IFormObserver
    {


        private Guid idEditVehiculo;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formVehiculoMain()
        {
            InitializeComponent();
            Update(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void ListarVehiculos()
        {
            try
            {

                var listaVehiculos = VehiculoBusiness.Current.GetAll();

                DBVehiculosList.DataSource = null;

                var listaselect = listaVehiculos.Select(x => new
                {
                    x.idVehiculo,
                    x.patente,
                    x.marca,
                    x.modelo
                }).ToList();

                DBVehiculosList.DataSource = listaselect;

                DBVehiculosList.Columns["idVehiculo"].Visible = false;

                DBVehiculosList.Columns["patente"].HeaderText = "patent".Translate();

                DBVehiculosList.Columns["marca"].HeaderText = "brand".Translate();

                DBVehiculosList.Columns["modelo"].HeaderText = "model".Translate();


                ConfigurarDataGridView(DBVehiculosList);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.FromArgb(45, 45, 48);
            dataGridView.ForeColor = Color.White;
            dataGridView.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
        }

        private void formVehiculoMain_Load(object sender, EventArgs e)
        {
            ListarVehiculos();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DBVehiculosList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void DBVehiculosList_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (DBVehiculosList.SelectedRows.Count > 0)
                {
                    idEditVehiculo = Guid.Parse(DBVehiculosList.SelectedRows[0].Cells["idVehiculo"].Value.ToString());
                    txtPatente.Text = DBVehiculosList.SelectedRows[0].Cells["patente"].Value.ToString();
                    txtMarca.Text = DBVehiculosList.SelectedRows[0].Cells["marca"].Value.ToString();
                    txtModelo.Text = DBVehiculosList.SelectedRows[0].Cells["modelo"].Value.ToString();
                    btnAddEditVehiculo.Text = "edit".Translate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnAddEditVehiculo_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnAddEditVehiculo.Text == "add".Translate())
                {
                    NuevoVehiculo();
                    LimpiarTextBox();
                }
                else
                {
                    EditarVehiculo();
                    LimpiarTextBox();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                LimpiarTextBox();
            }
        }

        private void EditarVehiculo()
        {
            var objVehiculo = new Vehiculo
            {
                idVehiculo = idEditVehiculo,
                patente = txtPatente.Text,
                marca = txtMarca.Text,
                modelo = txtModelo.Text

            };

            VehiculoBusiness.Current.Update(objVehiculo);
            MessageBox.Show("vehicle-edited-sucess".Translate());
            ListarVehiculos();
            LimpiarTextBox();
            idEditVehiculo = Guid.Empty;
            btnAddEditVehiculo.Text = "add".Translate();
        }

        private void LimpiarTextBox()
        {
            txtPatente.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
        }

        private void NuevoVehiculo()
        {

            var objVehiculo = new Vehiculo
            {
                patente = txtPatente.Text,
                marca = txtMarca.Text,
                modelo = txtModelo.Text
            };

            VehiculoBusiness.Current.Add(objVehiculo);

            MessageBox.Show("vehicle-added-sucess".Translate());

        }

        public void Update(Form form)
        {
            btnAddEditVehiculo.Text = "add".Translate();
            btnClose.Text = "close".Translate();
            lblVehiculos.Text = "vehicles".Translate();
            lblmarca.Text = "brand".Translate();
            lblmodelo.Text = "model".Translate();
            lblanamepatente.Text = "number-patent".Translate();


        }
    }
}
