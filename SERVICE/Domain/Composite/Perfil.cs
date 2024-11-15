using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.Composite
{
    public class Perfil : Acceso
    {


        public string Nombre { get; set; }

        public List<Acceso> Accesos { get; set; }

        public Perfil()
        {
            Accesos = new List<Acceso>();
        }

        public override void Add(Acceso component)
        {
            Accesos.Add(component);
        }
      
        public override void Remove(Acceso component)
        {

            Accesos.Remove(component);
        }

        public override int GetCount()
        {
            return Accesos.Count;
        }
    }
}
