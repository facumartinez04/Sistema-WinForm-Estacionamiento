using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain
{
    public class Log
    {
        public Log(string message, TraceLevel level = TraceLevel.Info)
        {
            this.Message = message;
            Level = level;
        }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Message { get; set; }

        public TraceLevel Level { get; set; }
    }
}
