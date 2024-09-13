using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Empleado
    {
        public int idEmpleado {  get; set; }

        public Rol rol { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public DateTime fecha_ingreso { get; set; }

        public int DNI { get; set; }

        public DateTime fecha_nacimiento { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }    


    }
}
