﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public class CryptographyService
    {
        public static string HashPassword(string textPlainPass)
        
        {
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] retVal = md5.ComputeHash(Encoding.Unicode.GetBytes(textPlainPass));
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
            }
            return sb.ToString();
        }




        public static bool ComparePassword(string textPlainPass, string hashPass)
        
        {
            return HashPassword(textPlainPass) == hashPass;
        }
    }
}
