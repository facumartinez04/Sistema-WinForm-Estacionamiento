using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IGenericBusiness<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(Guid id);

        T GetById(Guid id);

        List<T> GetAll();   


    }
}
