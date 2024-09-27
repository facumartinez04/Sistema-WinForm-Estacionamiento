using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Contracts
{
    public interface IGenericDAO<T>
    {
        bool Add(T obj);

        bool Update(T obj);

        bool Remove(Guid id);

        T GetById(Guid id);

        List<T> GetAll();
    }
}
