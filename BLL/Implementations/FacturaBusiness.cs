using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Services;
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
                    entity.verificador = CryptographyService.HashPassword(entity.ingreso.ToString() + entity.metodoPago);
                    entity.fechaRegistro = DateTime.Now;
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



                    foreach (var item in data)
                    {
                        item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                        item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                    }





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
            try
            {
                Factura factura = null;
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    factura = context.Repositories.FacturaRepository.GetById(id);
                }

                return factura;
            }
            catch (Exception ex)
            {
                throw;
            }
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

                    entity.verificador = CryptographyService.HashPassword(entity.idFactura.ToString() + entity.ingreso + entity.metodoPago);


                    context.Repositories.FacturaRepository.Update(entity);

                    context.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Factura> obtenerPorPatente(string patente)
        {

            try
            {
                List<Factura> facturas = new List<Factura>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    facturas = context.Repositories.FacturaRepository.obtenerPorPatente(patente);
                }


                foreach (var item in facturas)
                {
                    item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                    item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                }

                return facturas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Factura> obtenerPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {

            try
            {
                List<Factura> facturas = new List<Factura>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    facturas = context.Repositories.FacturaRepository.obtenerPorFecha(fechaDesde, fechaHasta);
                }


                foreach (var item in facturas)
                {
                    item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                    item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                }

                return facturas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    
}
