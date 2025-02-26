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
    /// Clase para manejar la lógica de negocio de TipoTarifa
    /// </summary>
    public sealed class TipoTarifaBusiness : ITipoTarifaBusiness
    {
        #region singleton
        /// <summary>
        /// Instancia singleton de TipoTarifaBusiness
        /// </summary>
        private readonly static TipoTarifaBusiness _instance = new TipoTarifaBusiness();

        /// <summary>
        /// Propiedad para acceder a la instancia singleton
        /// </summary>
        public static TipoTarifaBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón singleton
        /// </summary>
        private TipoTarifaBusiness()
        {
            // Implementar aquí la inicialización del singleton
        }
        #endregion

        /// <summary>
        /// Método para agregar una nueva tarifa
        /// </summary>
        /// <param name="entity">La tarifa a agregar</param>
        public void Add(TipoTarifa entity)
        {
            try
            {
                if (entity.descripcion == "") throw new BLLException("error-rate-description-empty".Translate());
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Agregó la tarifa con nombre {entity.descripcion}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Add(entity);
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
        /// Método para eliminar una tarifa por su ID
        /// </summary>
        /// <param name="id">El ID de la tarifa a eliminar</param>
        public void Delete(Guid id)
        {
            try
            {
                if (id == Guid.Empty) throw new BLLException("error-id-empty".Translate());

                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Eliminó la tarifa con el ID {id}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Remove(id);
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
        /// Método para obtener todas las tarifas
        /// </summary>
        /// <returns>Lista de tarifas</returns>
        public List<TipoTarifa> GetAll()
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió la lista de tarifas"));
                List<TipoTarifa> data = new List<TipoTarifa>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.TipoTarifaRepository.GetAll();
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
        /// Método para obtener una tarifa por su ID
        /// </summary>
        /// <param name="id">El ID de la tarifa</param>
        /// <returns>La tarifa correspondiente</returns>
        public TipoTarifa GetById(Guid id)
        {
            return null; // Implementación pendiente
        }

        /// <summary>
        /// Método para actualizar una tarifa
        /// </summary>
        /// <param name="entity">La tarifa a actualizar</param>
        public void Update(TipoTarifa entity)
        {
            try
            {
                if (entity.descripcion == "") throw new BLLException("error-rate-description-empty".Translate());
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Actualizó la tarifa con el nombre {entity.descripcion}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.TipoTarifaRepository.Update(entity);
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
        /// Método para obtener una tarifa por su ID
        /// </summary>
        /// <param name="id">El ID de la tarifa</param>
        /// <returns>La tarifa correspondiente</returns>
        public TipoTarifa ListByID(int id)
        {
            try
            {
                if (id == 0) throw new BLLException("error-id-empty".Translate());
                TipoTarifa data = null;
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió la tarifa con el ID {id}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.TipoTarifaRepository.ListById(id);
                    return data;
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
