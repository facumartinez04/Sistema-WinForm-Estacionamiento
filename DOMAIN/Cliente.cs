using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Cliente
    {

        public Guid idCliente { get; set; }

        public string nombre { get; set; }

        public int dni { get; set; }

        public DateTime fechaNacimiento { get; set; }
    }
}
