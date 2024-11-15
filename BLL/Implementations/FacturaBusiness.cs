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
    public sealed class FacturaBusiness : IFacturaBusiness
    {

         #region singleton
            private readonly static FacturaBusiness _instance = new FacturaBusiness();

            public static FacturaBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private FacturaBusiness()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public void Add(Factura entity)
        {


            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.FacturaRepository.Add(entity);

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

        public List<Factura> GetAll()
        {
            try
            {
                List<Factura> data = new List<Factura>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.FacturaRepository.GetAll();
                }

                return data;

            }
            catch (Exception ex)

            {
                throw;
            }
        }

        public Factura GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Factura obtenerPorID(int ID)
        {
            Factura factura = null;

            using (var context = FactoryDao.UnitOfWork.Create())
            {
                factura = context.Repositories.FacturaRepository.obtenerPorID(ID);
            }

            return factura;
        }

        public void Update(Factura entity)
        {

            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.FacturaRepository.Update(entity);

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
