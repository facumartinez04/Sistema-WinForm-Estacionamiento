using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain
{
    public class Bitacora
    {
        public Guid idBitacora { get; set; }

        public string usuario { get; set; }

        public DateTime fecha { get; set; }
        public string accion { get; set; }
        public string detalles { get; set; }


    }
}
