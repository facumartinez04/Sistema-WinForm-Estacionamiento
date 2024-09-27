using SERVICE.DAL.Implementations;
using SERVICE.Domain;
using SERVICE.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public static class LanguageManager
    {
        public static string Translate(string key)
        {
            try
            {
                return LanguageRepository.Translate(key);
            }
            catch (WordNotFoundException ex)
            {
                LanguageRepository.WriteKey(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return key;
        }
    }
}
