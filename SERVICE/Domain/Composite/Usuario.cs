using SERVICE.DAL.Implementations;
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
        public Guid IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Timestamp { get; set; }

        public string HashDH
        {
            get
            {
                return CryptographyService.HashPassword(UserName + Password);
            }
        }

        public string HashPassword
        {
            get
            {
                return CryptographyService.HashPassword(this.Password);
            }
        }

        public List<Acceso> Accesos { get; set; } = new List<Acceso>();

        public List<Patente> GetAllPatentes()
        {
            List<Patente> patentes = new List<Patente>();
            GetAllPatentesRecursive(Accesos, patentes);
            return patentes;
        }



        private void GetAllPatentesRecursive(List<Acceso> accesos, List<Patente> patentesReturn)
        {
            foreach (var acceso in accesos)
            {
                if (acceso is Patente patente)
                {
                    if (!patentesReturn.Any(o => o.Id == patente.Id))
                    {
                        patentesReturn.Add(patente);
                    }
                }
                else if (acceso is Familia familia)
                {
                    GetAllPatentesRecursive(familia.Componentes, patentesReturn);
                }
            }
        }

        public List<Familia> GetFamilias()
        {
            List<Familia> familias = new List<Familia>();
            GetAllFamilias(Accesos, familias);
            return familias;
        }

        private void GetAllFamilias(List<Acceso> accesos, List<Familia> familiasReturn)
        {
            foreach (var acceso in accesos)
            {
                if (acceso is Familia familia)
                {
                    if (!familiasReturn.Any(o => o.Id == familia.Id))
                    {
                        familiasReturn.Add(familia);
                    }
                    GetAllFamilias(familia.Componentes, familiasReturn);
                }
            }
        }
    }
}
