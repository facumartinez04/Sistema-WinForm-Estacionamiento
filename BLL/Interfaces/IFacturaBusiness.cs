using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{

    /// <summary>
    /// //Interfaz de FacturaBusiness
    /// </summary>
    public interface IFacturaBusiness : IGenericBusiness<Factura>
    {
        /// <summary>
        /// //Metodo para obtener una factura por ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Factura obtenerPorID(int ID);

        /// <summary>
        /// //Metodo para obtener una factura por patente
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        List<Factura> obtenerPorPatente(string patente);


        /// <summary>
        /// //Metodo para obtener una factura por fecha
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        List<Factura> obtenerPorFecha(DateTime fechaDesde, DateTime fechaHasta);
    }
}
