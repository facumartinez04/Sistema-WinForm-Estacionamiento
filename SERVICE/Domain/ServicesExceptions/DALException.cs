using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.ServicesExceptions
{
    public class DALException : Exception
    {
        public DALException(Exception exBase) : base("Exception generado por Acceso datos", exBase)
        {

        }
    }
}
