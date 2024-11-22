using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Facade.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Ingreso;

namespace BLL.Implementations
{
    public sealed class IngresoBusiness : IIngresoBusiness
    {


        #region singleton
            private readonly static IngresoBusiness _instance = new IngresoBusiness();

            public static IngresoBusiness Current
            {
                get
                {
                    return _instance;
                }
            }

            private IngresoBusiness()
            {
                //Implent here the initialization of your singleton
            }
        #endregion



        public void Add(Ingreso entity)
        { 

          
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Ingreso> GetAll()
        {
            try
            {
                List<Ingreso> data = new List<Ingreso>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data =  context.Repositories.IngresoRepository.GetAll();


                    foreach (var item in data)
                    {
                        item.cliente = ClienteBusiness.Current.GetById(item.cliente.idCliente);
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }




            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Ingreso GetById(Guid id)
        {

            Ingreso ingreso = null;

            using (var context = FactoryDao.UnitOfWork.Create())
            {
                ingreso = context.Repositories.IngresoRepository.GetById(id);

                if (ingreso != null)
                {
                    ingreso.cliente = ClienteBusiness.Current.GetById(ingreso.cliente.idCliente);
                    ingreso.vehiculo = VehiculoBusiness.Current.GetById(ingreso.vehiculo.idVehiculo);

                    ingreso.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(ingreso.objTipoTarifa.idTipoTarifa);

                }
                return ingreso;
            }
        }


        public void Update(Ingreso entity)
        {
            throw new NotImplementedException();
        }

        public void RegistrarEntrada(Ingreso entity)
        {
            try
            {

               if(entity.vehiculo.patente == "") throw new Exception($"vehicle-text-empty".Translate());

                if (entity.cliente == null)
                {
                    entity.cliente = new Cliente {
                        idCliente = Guid.Empty
                    };
                }

                Vehiculo vehiculoCheck = VehiculoBusiness.Current.GetAll().FirstOrDefault(x => x.patente == entity.vehiculo.patente);
                Ingreso ingresocheck = IngresoBusiness.Current.IngresosActuales().FirstOrDefault(x => x.vehiculo.patente == entity.vehiculo.patente);
                if (vehiculoCheck == null)
                {
                    VehiculoBusiness.Current.Add(entity.vehiculo);
                }

                if (ingresocheck != null) throw new Exception($"vehicle-error-car-already-entered".Translate());


                entity.vehiculo = VehiculoBusiness.Current.GetAll().FirstOrDefault(x => x.patente == entity.vehiculo.patente);
                entity.idIngreso = Guid.NewGuid();
                entity.fechaIngreso = DateTime.Now;
                entity.estado = (Estado)Estado.Ingresado;
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.IngresoRepository.RegistrarEntrada(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RegistrarSalida(Ingreso entity)
        {
            try
            {
                Ingreso ingresoCheck = IngresosActuales().FirstOrDefault(x => x.idIngreso == entity.idIngreso);

                if (ingresoCheck == null) throw new Exception($"vehicle-not-entered".Translate());


                entity.fechaEgreso = DateTime.Now;
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.IngresoRepository.RegistrarSalida(entity);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<Ingreso> IngresosActuales()
        {
            try
            {
                List<Ingreso> data = new List<Ingreso>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.IngresosActuales();

                    foreach (var item in data)
                    {
                        item.cliente = ClienteBusiness.Current.GetById(item.cliente.idCliente);
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Ingreso> BuscarPorPatente(string patente)
        {
            try
            {
                if (patente == "") throw new Exception($"vehicle-text-empty".Translate());
                List <Ingreso> data = new List<Ingreso>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.BuscarPorPatente(patente);

                    foreach (var item in data)
                    {
                        item.cliente = ClienteBusiness.Current.GetById(item.cliente.idCliente);
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta)
        {

            try
            {
                List<Ingreso> data = new List<Ingreso>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.ListarPorFechas(desde, hasta);

                    foreach (var item in data)
                    {
                        item.cliente = ClienteBusiness.Current.GetById(item.cliente.idCliente);
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;


            }
        }

        public Ingreso BuscarUnaPatente(string patente)
        {


            try
            {

                if (patente == "") throw new Exception($"vehicle-text-empty".Translate());
                Ingreso data = new Ingreso();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.BuscarUnaPatente(patente);

                    if (data != null)
                    {
                        data.cliente = ClienteBusiness.Current.GetById(data.cliente.idCliente);
                        data.vehiculo = VehiculoBusiness.Current.GetById(data.vehiculo.idVehiculo);
                        data.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(data.objTipoTarifa.idTipoTarifa);
                    }
                    else
                    {
                        throw new Exception($"vehicle-not-found".Translate());
                    }

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
