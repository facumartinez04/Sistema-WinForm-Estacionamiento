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
    /// //Pensamos un CRUD para cualquier entidad
    /// </summary>
    public interface IMetodoPagoDAO : IGenericDao<MetodoPago>
    {
        void Eliminar(int id);

        MetodoPago ObtenerPorId(int id);
    }
}
