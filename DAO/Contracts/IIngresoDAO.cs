using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{

    /// <summary>
    /// //La interfaz IIngresoDAO hereda de IGenericDao<Ingreso> y agrega metodos especificos para la entidad Ingreso
    /// </summary>
    public interface IIngresoDAO : IGenericDao<Ingreso>
    {

        void RegistrarEntrada(Ingreso ingreso);

        void RegistrarSalida(Ingreso ingreso);

        List<Ingreso> IngresosActuales();

        List<Ingreso> BuscarPorPatente(string patente);

        List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta);


        Ingreso BuscarUnaPatente(string patente);


        int GetCountIngresosActuales();

        int GetCountIngresoDelDia();


    }
}
