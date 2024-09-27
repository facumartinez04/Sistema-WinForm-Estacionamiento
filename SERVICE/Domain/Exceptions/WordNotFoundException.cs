using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.Exceptions
{
    internal class WordNotFoundException : Exception
    { 
        public WordNotFoundException(string message) : base(message)
        {

        }
        public WordNotFoundException() : base("La palabra no fue encontrada")
        {

        }
    }
}
