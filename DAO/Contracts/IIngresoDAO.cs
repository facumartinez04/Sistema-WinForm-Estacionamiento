using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface IIngresoDAO : IGenericDao<Ingreso>
    {

        void RegistrarEntrada(Ingreso ingreso);

        void RegistrarSalida(Ingreso ingreso);

        List<Ingreso> IngresosActuales();

        Ingreso BuscarPorPatente(string patente);



    }
}
