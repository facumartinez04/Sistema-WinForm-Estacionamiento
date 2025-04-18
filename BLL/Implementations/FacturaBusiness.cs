using BLL.Interfaces;
using Dao.Factory;
using DOMAIN;
using SERVICE.Domain.Composite;
using SERVICE.Domain;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SERVICE.Facade.Extentions;

namespace BLL.Implementations
{

    /// <summary>
    ///  /// Clase para manejar la lógica de negocio de Facturas
    /// </summary>
    public sealed class FacturaBusiness : IFacturaBusiness
    {
        #region singleton
        /// <summary>
        /// Instancia singleton de FacturaBusiness
        /// </summary>
        private readonly static FacturaBusiness _instance = new FacturaBusiness();

        /// <summary>
        /// Propiedad para acceder a la instancia singleton
        /// </summary>
        public static FacturaBusiness Current
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Constructor privado para implementar el patrón singleton
        /// </summary>
        private FacturaBusiness()
        {
            // Implementar aquí la inicialización del singleton
        }
        #endregion

        /// <summary>
        /// Método para agregar una nueva factura
        /// </summary>
        /// <param name="entity">La entidad factura a agregar</param>
        /// 
        public void Add(Factura entity)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Agregó la factura del vehículo con patente {entity.ingreso.vehiculo.patente}"));
                string resultado = entity.ingreso.idIngreso.ToString() + entity.metodoPago + entity.monto_total.ToString(CultureInfo.InvariantCulture);
                entity.verificador = CryptographyService.HashPassword(resultado);
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    entity.fechaRegistro = DateTime.Now;
                    context.Repositories.FacturaRepository.Add(entity);
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
        /// Método para eliminar una factura por su ID
        /// </summary>
        /// <param name="id">El ID de la factura a eliminar</param>
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método para obtener todas las facturas
        /// </summary>
        /// <returns>Lista de facturas</returns>
        public List<Factura> GetAll()
        {
            try
            {
                Boolean verificarCambios = true;
                Factura facturaeditada = null;
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Solicitó la lista de todas las facturas"));
                List<Factura> data = new List<Factura>();
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    data = context.Repositories.FacturaRepository.GetAll();

                    foreach (var item in data)
                    {
                        item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                        item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                        string resultado = item.ingreso.idIngreso.ToString() + item.metodoPago + item.monto_total.ToString(CultureInfo.InvariantCulture);

                        verificarCambios = CryptographyService.ComparePassword(resultado, item.verificador.ToString());

                        if (!verificarCambios)
                        {
                            facturaeditada = item;
                        }
                    }
                }
                if (!verificarCambios)
                {
                    if (SessionService.GetUsuario().GetFamilias().Any(x => x.NombreFamilia == "Administrador"))
                    {
                        MessageBox.Show("error-verificate-digit".Translate(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
        /// Método para obtener una factura por su ID
        /// </summary>
        /// <param name="id">El ID de la factura</param>
        /// <returns>La factura correspondiente</returns>
        public Factura GetById(Guid id)
        {
            try
            {
                Factura factura = null;
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Solicitó la factura con ID {id}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    factura = context.Repositories.FacturaRepository.GetById(id);
                }

                return factura;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener una factura por ID específico
        /// </summary>
        /// <param name="ID">El ID de la factura</param>
        /// <returns>La factura correspondiente</returns>
        public Factura obtenerPorID(int ID)
        {
            try
            {
                Factura factura = null;
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Solicitó la factura con ID {ID}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    factura = context.Repositories.FacturaRepository.obtenerPorID(ID);


                    factura.ingreso = IngresoBusiness.Current.GetById(factura.ingreso.idIngreso);
                    factura.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(factura.metodoPago.idMetodoPago);
                }
                return factura;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para actualizar una factura
        /// </summary>
        /// <param name="entity">La factura a actualizar</param>
        public void Update(Factura entity)
        {
            try
            {
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Actualizó la factura con ID {entity.idFactura}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    entity.verificador = CryptographyService.HashPassword(entity.idFactura.ToString() + entity.ingreso + entity.metodoPago);

                    context.Repositories.FacturaRepository.Update(entity);
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
        /// Método para obtener facturas por patente
        /// </summary>
        /// <param name="patente">La patente del vehículo</param>
        /// <returns>Lista de facturas asociadas</returns>
        public List<Factura> obtenerPorPatente(string patente)
        {
            try
            {
                Boolean verificarCambios = true;
                Factura facturaeditada = null;
                List<Factura> facturas = new List<Factura>();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Solicitó las facturas con la patente {patente}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    facturas = context.Repositories.FacturaRepository.obtenerPorPatente(patente);
                }

                foreach (var item in facturas)
                {
                    item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                    item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                    string resultado = item.ingreso.idIngreso.ToString() + item.metodoPago + item.monto_total.ToString(CultureInfo.InvariantCulture);

                    verificarCambios = CryptographyService.ComparePassword(resultado, item.verificador.ToString());

                    if (!verificarCambios)
                    {
                        facturaeditada = item;
                    }
                }

                if (!verificarCambios)
                {
                    if (SessionService.GetUsuario().GetFamilias().Any(x => x.NombreFamilia == "Administrador"))
                    {
                        MessageBox.Show("error-verificate-digit".Translate(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                return facturas;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }

        /// <summary>
        /// Método para obtener facturas por rango de fechas
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio</param>
        /// <param name="fechaHasta">Fecha de fin</param>
        /// <returns>Lista de facturas en el rango de fechas</returns>
        public List<Factura> obtenerPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                Boolean verificarCambios = true;
                Factura facturaeditada = null;
                List<Factura> facturas = new List<Factura>();
                BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Solicitó las facturas desde {fechaDesde} hasta {fechaHasta}"));
                using (var context = FactoryDao.UnitOfWork.Create())
                {
                    facturas = context.Repositories.FacturaRepository.obtenerPorFecha(fechaDesde, fechaHasta);
                }

                foreach (var item in facturas)
                {
                    item.ingreso = IngresoBusiness.Current.GetById(item.ingreso.idIngreso);
                    item.metodoPago = MetodoPagoBusiness.Current.ObtenerPorId(item.metodoPago.idMetodoPago);

                    string resultado = item.ingreso.idIngreso.ToString() + item.metodoPago + item.monto_total.ToString(CultureInfo.InvariantCulture);

                    verificarCambios = CryptographyService.ComparePassword(resultado, item.verificador.ToString());

                    if (!verificarCambios)
                    {
                        facturaeditada = item;
                    }
                }

                if (!verificarCambios)
                {
                    if (SessionService.GetUsuario().GetFamilias().Any(x => x.NombreFamilia == "Administrador"))
                    {
                        MessageBox.Show("error-verificate-digit".Translate(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                return facturas;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw;
            }
        }
    }
}
