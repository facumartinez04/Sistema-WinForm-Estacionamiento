using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    /// <summary>
    /// //Interface for Ingreso business
    /// </summary>
    internal interface IIngresoBusiness : IGenericBusiness<Ingreso>
    {

        /// <summary>
        /// //Register entry
        /// </summary>
        /// <param name="ingreso"></param>
        void RegistrarEntrada(Ingreso ingreso);
        /// <summary>
        /// //Register exit
        /// </summary>
        /// <param name="ingreso"></param>
        void RegistrarSalida(Ingreso ingreso);

        /// <summary>
        /// //Get current entries
        /// </summary>
        /// <returns></returns>
        List<Ingreso> IngresosActuales();

        /// <summary>
        /// //Search by patent
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        List<Ingreso> BuscarPorPatente(string patente);

        /// <summary>
        /// //List by dates
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta);

        /// <summary>
        /// //Search by patent
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        Ingreso BuscarUnaPatente(string patente);


        int GetCountIngresosActuales();

        int GetCountIngresoDelDia();
    }
}
