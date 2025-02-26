using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Domain;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL.Implementations
{
    /// <summary>
    /// Clase para manejar la lógica de negocio de Métodos de Pago
    /// </summary>
    public sealed class MetodoPagoBusiness : IMetodoPagoBusiness
    {
        #region singleton
        /// <summary>
        /// Instancia singleton de MetodoPagoBusiness
        /// </summary>
        private readonly static MetodoPagoBusiness _instance = new MetodoPagoBusiness();

        /// <summary>
        /// Propiedad para acceder a la instancia singleton
        /// </summary>
        public static MetodoPagoBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón singleton
        /// </summary>
        private MetodoPagoBusiness()
        {
            // Implementar aquí la inicialización del singleton
        }
        #endregion

        /// <summary>
        /// Método para agregar un método de pago
        /// </summary>
        /// <param name="entity">El método de pago a agregar</param>
        public void Add(MetodoPago entity)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Agregó el método de pago con nombre {entity.descripcion}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Add(entity);
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
        /// Método para eliminar un método de pago (implementación pendiente)
        /// </summary>
        /// <param name="id">El ID del método de pago a eliminar</param>
        public void Delete(Guid id)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Quiere eliminar un metodo de pago"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Remove(id);
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
        /// Método para obtener todos los métodos de pago
        /// </summary>
        /// <returns>Lista de métodos de pago</returns>
        public List<MetodoPago> GetAll()
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió la lista con todos los métodos de pago"));
                List<MetodoPago> data = new List<MetodoPago>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.MetodoPagoRepository.GetAll();
                }

                return data;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener un método de pago por su ID
        /// </summary>
        /// <param name="id">El ID del método de pago</param>
        /// <returns>El método de pago correspondiente</returns>
        public MetodoPago GetById(Guid id)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Pidió el método de pago con ID {id}"));
                MetodoPago data = new MetodoPago();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.MetodoPagoRepository.GetById(id);
                }

                return data;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para actualizar un método de pago
        /// </summary>
        /// <param name="entity">El método de pago a actualizar</param>
        public void Update(MetodoPago entity)
        {
            try
            {

                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Actualizó el método de pago con nombre {entity.descripcion}"));

                MetodoPago check = GetAll().FirstOrDefault(x => x.descripcion == entity.descripcion);

                if (check != null && check.idMetodoPago != entity.idMetodoPago)
                {
                    throw new BLLException("Ya existe un método de pago con ese nombre", true);
                }


                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    context.Repositories.MetodoPagoRepository.Update(entity);
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
        /// Método para eliminar un método de pago por su ID (int)
        /// </summary>
        /// <param name="id">El ID del método de pago a eliminar</param>
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
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener un método de pago por su ID (int)
        /// </summary>
        /// <param name="id">El ID del método de pago</param>
        /// <returns>El método de pago correspondiente</returns>
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
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }
    }
}
