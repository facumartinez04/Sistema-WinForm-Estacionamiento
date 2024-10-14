using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Facade.Extentions
{
    public static class StringExtention
    {
        public static string Translate(this string key)
        {
            return LanguageService.Translate(key);
        }

        public static string ToUpperCapital(this string word)
        {
            return word;
        }

        public static string ExtentionWithParameters(this string word, int a, string pepe)
        {
            return "hola";
        }
    }
}
