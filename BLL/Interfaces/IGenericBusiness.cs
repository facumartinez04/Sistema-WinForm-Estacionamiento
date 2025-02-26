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
    /// <typeparam name="T"></typeparam>
    public interface IGenericBusiness<T>
    {
        /// <summary>
        /// //Add entity
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// //Update entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);


        /// <summary>
        /// //Delete entity
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);

        /// <summary>
        /// //Get entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(Guid id);
        /// <summary>
        /// //Get all entities
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();   


    }
}
