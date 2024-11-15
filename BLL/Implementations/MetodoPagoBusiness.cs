using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{

    

    public sealed class MetodoPagoBusiness : IMetodoPagoBusiness
    {


        
        #region singleton
            private readonly static MetodoPagoBusiness _instance = new MetodoPagoBusiness();

            public static MetodoPagoBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private MetodoPagoBusiness()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public void Add(MetodoPago entity)
        {

            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Add(entity);

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
        }

        public List<MetodoPago> GetAll()
        {
            try
            {
                List<MetodoPago> data = new List<MetodoPago>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.MetodoPagoRepository.GetAll();
                }

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public MetodoPago GetById(Guid id)
        {
            try
            {
                MetodoPago data = new MetodoPago();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.MetodoPagoRepository.GetById(id);
                }

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public void Update(MetodoPago entity)
        {

            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Update(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Eliminar(id);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public MetodoPago ObtenerPorId(int id)
        {
            try
            {
                MetodoPago data = new MetodoPago();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.MetodoPagoRepository.ObtenerPorId(id);
                }

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
