using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Contracts
{
    internal interface IBitacoraDAO : IGenericDAO<Bitacora>
    {

        List<Bitacora> obtenerPorUsuario(string usuario);   
        List<Bitacora> obtenerPorFecha(DateTime dateTime);   

        List<Bitacora> obtenerPorUsuarioFecha(string usuario, DateTime dateTime);


    }
}
