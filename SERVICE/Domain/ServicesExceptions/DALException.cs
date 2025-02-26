using SERVICE.DAL;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.ServicesExceptions
{
    public class DALException : Exception
    {
        public DALException(Exception exBase) : base("Ocurrio un error al intentar conectar a la base de datos", exBase)
        { 

        }
    }
}
