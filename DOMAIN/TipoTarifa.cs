using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class TipoTarifa
    { 
        public int idTipoTarifa { get; set; }

        public double monto_por_hora { get; set; }
        public string descripcion { get; set; }
    }
}
