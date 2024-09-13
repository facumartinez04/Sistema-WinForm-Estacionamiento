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

        public Double monto_total { get; set; }
    }
}
