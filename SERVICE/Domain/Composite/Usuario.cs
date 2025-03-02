﻿using SERVICE.DAL.Implementations;
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
        public List<Acceso> Accesos { get; set; } = new List<Acceso>();


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




        public List<Patente> GetAllPatentes()
        {
            List<Patente> patentesReturn = new List<Patente>();
            UsuarioPatenteRepository.Current.usuarioPatentes(this.IdUsuario).ForEach(o => patentesReturn.Add(PatenteRepository.Current.GetById(o.idPatente)));
            return patentesReturn;
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
            UsuarioFamiliaRepository.Current.GetFamiliasByUsuario(this.IdUsuario).ForEach(o => familias.Add(FamiliaRepository.Current.GetById(o.idFamilia)));
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
