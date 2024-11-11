using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    public interface ITipoTarifaDAO : IGenericDao<TipoTarifa>
    {
        TipoTarifa ListById(int id);
    }
}
