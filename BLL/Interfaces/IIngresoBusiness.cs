using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IIngresoBusiness : IGenericBusiness<Ingreso>
    {
        void RegistrarEntrada(Ingreso ingreso);
        void RegistrarSalida(Ingreso ingreso);

        List<Ingreso> IngresosActuales();

        List<Ingreso> BuscarPorPatente(string patente);


        List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta);

        Ingreso BuscarUnaPatente(string patente);

    }
}
