using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.Composite
{
    public class Patente : Acceso
    {

        public Guid idPatente { get; set; }

        public TipoAcceso TipoAcceso { get; set; }

        public string DataKey { get; set; }

        public string Nombre { get; set; }

        public override void Add(Acceso component)
        {
            throw new NotImplementedException();
        }

        public override int GetCount()
        {
            return 0;
        }

        public override void Remove(Acceso component)
        {
            throw new NotImplementedException();
        }

    }
}

public enum TipoAcceso
{
    UI,
    Control,
    UseCases
}