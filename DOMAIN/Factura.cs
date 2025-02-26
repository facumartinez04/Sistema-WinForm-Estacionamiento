using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Factura 
    {
        public int idFactura { get; set; }
        public Ingreso ingreso { get; set; }
        public MetodoPago metodoPago { get; set; }

        public Decimal monto_total { get; set; }

        public DateTime fechaRegistro { get; set; }

        public string verificador { get; set; }
    }
}
