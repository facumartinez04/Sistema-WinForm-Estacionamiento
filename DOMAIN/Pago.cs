using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Pago
    {
        public int idPago { get; set; }
        public Factura factura { get; set; }
        public MetodoPago metodoPago { get; set; }
        public Double monto { get; set; }
    }
}
