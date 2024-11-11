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
    public sealed class TipoTarifaBusiness : ITipoTarifaBusiness
    {


      
        #region singleton
            private readonly static TipoTarifaBusiness _instance = new TipoTarifaBusiness();

            public static TipoTarifaBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private TipoTarifaBusiness()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public void Add(TipoTarifa entity)
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Add(entity);

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

            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Remove(id);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TipoTarifa> GetAll()
        {
            try
            {
                List<TipoTarifa> data = new List<TipoTarifa>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.TipoTarifaRepository.GetAll();


                    return data;
                }




            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TipoTarifa GetById(Guid id)
        {
            return null;
           
        }

        public void Update(TipoTarifa entity)
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Update(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TipoTarifa ListByID(int id)
        {
            try
            {
                TipoTarifa data = null;
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.TipoTarifaRepository.ListById(id);

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
