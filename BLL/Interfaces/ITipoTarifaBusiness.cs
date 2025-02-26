using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{

    /// <summary>
    /// //Generic interface for business layer
    /// </summary>
    internal interface ITipoTarifaBusiness : IGenericBusiness<TipoTarifa>
    {
        /// <summary>
        /// //Get all entities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TipoTarifa ListByID(int id);
    }
}
