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
    public sealed class VehiculoBusiness : IGenericBusiness<Vehiculo>
    {


      
        #region singleton
            private readonly static VehiculoBusiness _instance = new VehiculoBusiness();

            public static VehiculoBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private VehiculoBusiness()
            {
                //Implent here the initialization of your singleton
            }
            #endregion


        public void Add(Vehiculo entity)
        {

            try
            {
                entity.idVehiculo = Guid.NewGuid();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.VehiculoRepository.Add(entity);

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
                    context.Repositories.VehiculoRepository.Remove(id);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Vehiculo> GetAll()
        {
            try
            {
                List<Vehiculo> data = new List<Vehiculo>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.VehiculoRepository.GetAll();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Vehiculo GetById(Guid id)
        {
            try
            {
                Vehiculo data = null;
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.VehiculoRepository.GetById(id);

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Vehiculo entity)
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.VehiculoRepository.Update(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
