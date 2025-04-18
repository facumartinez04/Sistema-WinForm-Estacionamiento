using BLL.Implementations;
using DOMAIN;
using SERVICE.Facade.Extentions;
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
using UI___Estacionamiento.Domain.Observer;

namespace UI___Estacionamiento.PanelsMain.FacturacionForms
{
    public partial class formGenerarTicket: Form ,  IFormObserver
    {

        private readonly int idTicket;

        private readonly Form form;

        private readonly Factura facturaGen;

        public formGenerarTicket(int idTicket)
        {
            this.idTicket = idTicket;

            form = this;

            facturaGen = FacturaBusiness.Current.obtenerPorID(idTicket);

            InitializeComponent();
            Update(this);
        }

        private void formGenerarTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            FacturaService.GenerarFactura(FacturaBusiness.Current.obtenerPorID(idTicket));

            this.Close();
        }

        public void Update(Form form)
        {
            form.Text = "pay-ticket".Translate() + $" {facturaGen.idFactura}";
            btnCerrar.Text = "close".Translate();
            btnGenerar.Text = "generate-now".Translate();
            label1.Text = "generate-question".Translate();



        }
    }
}
