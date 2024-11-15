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
        public Guid IdFamilia { get; set; }
        public string NombreFamilia { get; set; }
        public List<Acceso> Componentes { get; set; } = new List<Acceso>();
        public DateTime Timestamp { get; set; }

        public override void Add(Acceso component)
        {
            Componentes.Add(component);
        }

        public override void Remove(Acceso component)
        {
            Componentes.Remove(component);
        }

        public override int GetCount()
        {
            return Componentes.Count;
        }
    }
}
