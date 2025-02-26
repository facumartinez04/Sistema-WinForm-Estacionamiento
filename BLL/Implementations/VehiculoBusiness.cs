using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Domain;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Facade.Extentions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL.Implementations
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de Vehículo
    /// </summary>
    public sealed class VehiculoBusiness : IGenericBusiness<Vehiculo>
    {
        #region singleton
        /// <summary>
        /// Instancia singleton de VehiculoBusiness
        /// </summary>
        private readonly static VehiculoBusiness _instance = new VehiculoBusiness();

        /// <summary>
        /// Propiedad para acceder a la instancia singleton
        /// </summary>
        public static VehiculoBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón singleton
        /// </summary>
        private VehiculoBusiness()
        {
            // Implementar aquí la inicialización del singleton
        }
        #endregion

        /// <summary>
        /// Método para agregar un vehículo
        /// </summary>
        /// <param name="entity">El vehículo a agregar</param>
        public void Add(Vehiculo entity)
        {
            try
            {
                if (entity.patente == "") throw new BLLException("error-patent-empty".Translate());
                entity.idVehiculo = Guid.NewGuid();

                Vehiculo vehiculo = GetAll().FirstOrDefault(x => x.patente == entity.patente);
                if (vehiculo != null) throw new BLLException("error-vehicle-exists".Translate());

                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Agregó el vehículo con la patente {entity.patente}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.VehiculoRepository.Add(entity);
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
        /// Método para eliminar un vehículo por su ID
        /// </summary>
        /// <param name="id">El ID del vehículo a eliminar</param>
        public void Delete(Guid id)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Eliminó el vehículo con el ID {id}"));
                Vehiculo vehiculo = GetById(id);

                List<Ingreso> ingresos = IngresoBusiness.Current.GetAll().Where(x => x.vehiculo.idVehiculo == id).ToList();

                if (ingresos.Count > 0) throw new BLLException("error-vehicle-already-has-ingress-or-egress".Translate());


                if (vehiculo == null) throw new BLLException("error-vehicle-not-exists".Translate());


                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.VehiculoRepository.Remove(id);
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
        /// Método para listar todos los vehículos
        /// </summary>
        /// <returns>Lista de vehículos</returns>
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
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener un vehículo por su ID
        /// </summary>
        /// <param name="id">El ID del vehículo</param>
        /// <returns>El vehículo correspondiente</returns>
        /// <exception cref="BLLException">Se lanza si el ID está vacío</exception>
        public Vehiculo GetById(Guid id)
        {
            if (id == Guid.Empty) throw new BLLException("error-patent-empty".Translate());
            BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió listar el vehículo con ID {id}"));
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
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para actualizar un vehículo
        /// </summary>
        /// <param name="entity">El vehículo a actualizar</param>
        public void Update(Vehiculo entity)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió actualizar el vehículo con patente {entity.patente}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.VehiculoRepository.Update(entity);
                    context.SaveChanges();
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
