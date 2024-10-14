using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Facade
{

  internal static class LanguageService
    {
        public static string Translate(string key)
        {
            return LanguageManager.Translate(key);
        }
    }
}

