using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.Composite
{
    public class Familia : Acceso
    {
        private List<Acceso> accesos = new List<Acceso>();

        public Guid idFamilia { get; set; }

        public string Nombre { get; set; }

        public Familia()
        {

        }

        public Familia(Acceso component, string nombre)
        {

            accesos.Add(component);

            Nombre = nombre;
        }

        public List<Acceso> GetChildrens()
        {
            return accesos;
        }


        public override void Add(Acceso component)
        {
            accesos.Add(component);
        }

        public override int GetCount()
        {
            return accesos.Count;
        }

        public override void Remove(Acceso component)
        {
            accesos.Remove(component);
        }
    }
}
