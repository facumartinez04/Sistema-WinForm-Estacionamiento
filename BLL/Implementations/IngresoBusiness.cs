using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Domain;
using SERVICE.Domain.Composite;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Facade.Extentions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Ingreso;
namespace BLL.Implementations
{

    /// <summary>
    /// Clase para manejar la lógica de negocio de Ingresos
    ///   </summary>
    public sealed class IngresoBusiness : IIngresoBusiness
    {
        #region singleton
        /// <summary>
        /// Instancia singleton de IngresoBusiness
        /// </summary>
        private readonly static IngresoBusiness _instance = new IngresoBusiness();

        /// <summary>
        /// Propiedad para acceder a la instancia singleton
        /// </summary>
        public static IngresoBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón singleton
        /// </summary>
        private IngresoBusiness()
        {
            // Implementar aquí la inicialización del singleton
        }
        #endregion

        /// <summary>
        /// Método para agregar un nuevo ingreso
        /// </summary>
        /// <param name="entity">La entidad ingreso a agregar</param>
        public void Add(Ingreso entity)
        {
            // Implementación pendiente
        }

        /// <summary>
        /// Método para eliminar un ingreso por su ID
        /// </summary>
        /// <param name="id">El ID del ingreso a eliminar</param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método para obtener todos los ingresos
        /// </summary>
        /// <returns>Lista de ingresos</returns>
        public List<Ingreso> GetAll()
        {
            try
            {
                List<Ingreso> data = new List<Ingreso>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.GetAll();

                    foreach (var item in data)
                    {
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener un ingreso por su ID
        /// </summary>
        /// <param name="id">El ID del ingreso</param>
        /// <returns>El ingreso correspondiente</returns>
        public Ingreso GetById(Guid id)
        {
            try
            {
                Ingreso ingreso = null;

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    ingreso = context.Repositories.IngresoRepository.GetById(id);

                    if (ingreso != null)
                    {
                        ingreso.vehiculo = VehiculoBusiness.Current.GetById(ingreso.vehiculo.idVehiculo);
                        ingreso.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(ingreso.objTipoTarifa.idTipoTarifa);
                    }

                    return ingreso;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para registrar una entrada
        /// </summary>
        /// <param name="entity">La entidad ingreso</param>
        public void RegistrarEntrada(Ingreso entity)
        {
            try
            {
                if (entity.vehiculo.patente == "") throw new Exception($"vehicle-text-empty".Translate());

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
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Ingresó el vehículo {entity.vehiculo.patente}"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.IngresoRepository.RegistrarEntrada(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para registrar una salida
        /// </summary>
        /// <param name="entity">La entidad ingreso</param>
        public void RegistrarSalida(Ingreso entity)
        {
            try
            {
                Ingreso ingresoCheck = IngresosActuales().FirstOrDefault(x => x.idIngreso == entity.idIngreso);

                if (ingresoCheck == null) throw new Exception($"vehicle-not-entered".Translate());

                entity.fechaEgreso = DateTime.Now;
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Registró la salida del vehículo {entity.vehiculo.patente}"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.IngresoRepository.RegistrarSalida(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener los ingresos actuales
        /// </summary>
        /// <returns>Lista de ingresos actuales</returns>
        public List<Ingreso> IngresosActuales()
        {
            try
            {
                List<Ingreso> data = new List<Ingreso>();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió la lista de vehículos ingresados actualmente"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.IngresosActuales();

                    foreach (var item in data)
                    {
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para buscar ingresos por patente
        /// </summary>
        /// <param name="patente">La patente del vehículo</param>
        /// <returns>Lista de ingresos asociados</returns>
        public List<Ingreso> BuscarPorPatente(string patente)
        {
            try
            {
                if (patente == "") throw new Exception($"vehicle-text-empty".Translate());
                List<Ingreso> data = new List<Ingreso>();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Buscó al vehículo con la patente {patente}"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.BuscarPorPatente(patente);

                    foreach (var item in data)
                    {
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para listar ingresos por rango de fechas
        /// </summary>
        /// <param name="desde">Fecha de inicio</param>
        /// <param name="hasta">Fecha de fin</param>
        /// <returns>Lista de ingresos en el rango de fechas</returns>
        public List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta)
        {
            try
            {
                List<Ingreso> data = new List<Ingreso>();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Listó por fecha desde {desde} hasta {hasta}"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.ListarPorFechas(desde, hasta);

                    foreach (var item in data)
                    {
                        item.vehiculo = VehiculoBusiness.Current.GetById(item.vehiculo.idVehiculo);
                        item.objTipoTarifa = TipoTarifaBusiness.Current.ListByID(item.objTipoTarifa.idTipoTarifa);
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para buscar un ingreso por patente
        /// </summary>
        /// <param name="patente">La patente del vehículo</param>
        /// <returns>El ingreso correspondiente</returns>
        public Ingreso BuscarUnaPatente(string patente)
        {
            try
            {
                if (patente == "") throw new Exception($"vehicle-text-empty".Translate());
                Ingreso data = new Ingreso();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Buscó al vehículo con la patente {patente}"));

                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.IngresoRepository.BuscarUnaPatente(patente);

                    if (data != null)
                    {
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
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        public void Update(Ingreso entity)
        {
            throw new NotImplementedException();
        }

        public int GetCountIngresosActuales()
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {

                    return context.Repositories.IngresoRepository.GetCountIngresosActuales();

                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        public int GetCountIngresoDelDia()
        {
            try
            {
                using (var context = FactoryDao.UnitOfWork.Create())
                {

                    return context.Repositories.IngresoRepository.GetCountIngresoDelDia();

                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }
    }
}
