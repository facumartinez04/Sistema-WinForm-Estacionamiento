using BLL.Interfaces;
using Dao.Factory;
using DAO.Implementations.SqlServer;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public sealed class ClienteBusiness : IGenericBusiness<Cliente>
    {



  
       #region singleton
            private readonly static ClienteBusiness _instance = new ClienteBusiness();

            public static ClienteBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private ClienteBusiness()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
      

        public void Add(Cliente entity)
        {
            try
            {
                entity.idCliente = Guid.NewGuid();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.ClienteRepository.Add(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    return context.Repositories.ClienteRepository.GetAll();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Cliente GetById(Guid id)
        {
            using (var context = FactoryDao.UnitOfWork.Create())
            {
                return context.Repositories.ClienteRepository.GetById(id);
            }
        }

        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
