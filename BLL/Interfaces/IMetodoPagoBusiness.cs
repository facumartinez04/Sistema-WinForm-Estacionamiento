using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    /// <summary>
    /// //Interface for MetodoPago business
    /// </summary>
    internal interface IMetodoPagoBusiness : IGenericBusiness<MetodoPago>
    {
        /// <summary>
        /// //Delete MetodoPago
        /// </summary>
        /// <param name="id"></param>
        void Eliminar(int id);

        /// <summary>
        /// //Get all MetodoPago
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MetodoPago ObtenerPorId(int id);

    }
}
