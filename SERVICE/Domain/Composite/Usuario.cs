using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Domain.Composite
{
    public class Usuario
    {
        public Guid idUsuario { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string HashDH
        {
            get
            {
                return CryptographyService.HashPassword(Username + Password);
            }
        }

        public string HashPassword
        {
            get
            {
                return CryptographyService.HashPassword(this.Password);
            }
        }

        public List<Acceso> Permisos { get; set; }

        public Usuario()
        {
            Permisos = new List<Acceso>();
        }




        private static void RecorrerComposite(List<Patente> patentes, List<Acceso> components, string tab)
        {
            foreach (var item in components)
            {
                if (item.GetCount() == 0)
                {
                    Patente patente1 = item as Patente;
                    Console.WriteLine($"{tab} Patente: {patente1.Name}");

                    if (!patentes.Exists(o => o.Name == patente1.Name))
                        patentes.Add(patente1);
                }
                else
                {
                    Familia familia = item as Familia;
                    RecorrerComposite(patentes, familia.GetChildrens(), tab + "-");
                }
            }
        }
    }

}
