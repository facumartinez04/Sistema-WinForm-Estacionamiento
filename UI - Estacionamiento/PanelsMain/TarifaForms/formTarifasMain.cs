using BLL.Implementations;
using DOMAIN;
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

namespace UI___Estacionamiento.PanelsMain.TarifaForms
{
    public partial class formTarifasMain : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
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


            DBTarifasList.Columns["idTipoTarifa"].Visible = false;

            DBTarifasList.Columns["descripcion"].HeaderText = "Nombre de Tarifa";

            DBTarifasList.Columns["monto_por_hora"].HeaderText = "Monto por Hora";

            DBTarifasList.Columns["monto_por_hora"].DefaultCellStyle.Format = "C";
            DBTarifasList.Columns["monto_por_hora"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");

            ConfigurarDataGridView(DBTarifasList);


            DBTarifasList.Columns["descripcion"].ReadOnly = true;
            DBTarifasList.Columns["monto_por_hora"].ReadOnly = true;

            // dataGridPermisos.Columns["Nombre"].Visible = true;
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

        private void txtMontoTarifa_TextChanged(object sender, EventArgs e)
        {

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

        private void txtMontoTarifa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formTarifasMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
