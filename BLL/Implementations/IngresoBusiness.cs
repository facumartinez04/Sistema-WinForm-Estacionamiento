using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
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
            throw new NotImplementedException();
        }

        public void Update(Ingreso entity)
        {
            throw new NotImplementedException();
        }

        public void RegistrarEntrada(Ingreso entity)
        {
            try
            {

              

                if(entity.cliente == null)
                {
                    entity.cliente = new Cliente {
                        idCliente = Guid.Empty
                    };
                }

                Vehiculo vehiculoCheck = VehiculoBusiness.Current.GetAll().FirstOrDefault(x => x.patente == entity.vehiculo.patente);

   
                if(vehiculoCheck != null ) {

                    Ingreso ingresocheck = IngresoBusiness.Current.GetAll().FirstOrDefault(x => x.vehiculo.idVehiculo == vehiculoCheck.idVehiculo && x.fechaEgreso != DateTime.Parse("01/01/0001") || x.fechaEgreso == DateTime.Parse("1/1/0001"));
                    
                   if(ingresocheck != null) if (ingresocheck.fechaEgreso.ToString().Contains("1/1/0001") || ingresocheck.fechaEgreso.ToString().Contains("01/01/0001")) throw new Exception("El auto ya esta ingresado");

                }


                if (vehiculoCheck == null)
                {
                    VehiculoBusiness.Current.Add(entity.vehiculo);
                }

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
                Ingreso ingresoCheck = GetAll().FirstOrDefault(x => x.idIngreso == entity.idIngreso);

                if(ingresoCheck.fechaEgreso.Value != DateTime.Parse("01/01/0001"))
                {
                    throw new Exception("La salida ya fue registrada.");
                }
            

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
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Ingreso BuscarPorPatente(string patente)
        {
            throw new NotImplementedException();
        }
    }
}
