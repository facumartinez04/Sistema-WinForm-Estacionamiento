using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Clase que implementa la interfaz IFacturaDAO para manejar operaciones CRUD sobre la entidad Factura en la base de datos.
/// </summary>
namespace DAO.Implementations.SqlServer
{
    public class FacturaDAO : SqlTransactRepository, IFacturaDAO
    {
        public FacturaDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Factura] (idIngreso,idMetodoPago,monto_total,fecha_registro,verificador) VALUES (@idIngreso,@idMetodoPago,@monto_total,@fecha_registro,@verificador)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Factura] SET (idFactura,idIngreso,idMetodoPago,monto_total) WHERE idFactura = @idFactura";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Factura] WHERE idFactura = @idFactura";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Factura] WHERE idFactura = @idFactura";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Factura]";
        }

        private string SelectPorPatenteStatement
        {
            get => "SELECT f.idFactura, f.idIngreso, f.idMetodoPago, f.monto_total, f.fecha_registro, f.verificador, i.idIngreso, i.idVehiculo, i.FechaHorario_Ingreso, i.FechaHorario_Salida, i.idTipoTarifa, i.estado, v.idVehiculo, v.patente, v.marca, v.modelo FROM [DBEstacionamiento].[dbo].[Factura] f JOIN [DBEstacionamiento].[dbo].[Ingreso] i ON f.idIngreso = i.idIngreso JOIN [DBEstacionamiento].[dbo].[Vehiculo] v ON i.idVehiculo = v.idVehiculo WHERE v.patente = @patente;";
        }

        private string SelectPorFechaStatement
        {
            get => "SELECT * FROM [dbo].[Factura] WHERE fecha_registro BETWEEN @fechaDesde AND @fechaHasta";
        }
        #endregion

        /// <summary>
        /// Agrega una nueva Factura a la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Factura a agregar.</param>
        public void Add(Factura obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter("@idIngreso", obj.ingreso.idIngreso),
                    new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
                    new SqlParameter("@monto_total", obj.monto_total),
                    new SqlParameter("@fecha_registro", obj.fechaRegistro),
                    new SqlParameter("@verificador", obj.verificador)
                );

                if (esCargado == 0)
                {
                    throw new Exception("No se ha podido cargar la factura");
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene todas las Facturas de la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Factura.</returns>
        public List<Factura> GetAll()
        {
            try
            {
                List<Factura> facturas = new List<Factura>();
                using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Factura factura = FacturaMapper.Current.Fill(data);
                        facturas.Add(factura);
                    }
                }
                return facturas;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene una Factura por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único de la Factura.</param>
        /// <returns>Objeto Factura.</returns>
        public Factura GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene una lista de Facturas registradas entre dos fechas específicas.
        /// </summary>
        /// <param name="fechaDesde">Fecha inicial del rango.</param>
        /// <param name="fechaHasta">Fecha final del rango.</param>
        /// <returns>Lista de objetos Factura.</returns>
        public List<Factura> obtenerPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                using (var reader = ExecuteReader(SelectPorFechaStatement, CommandType.Text,
                new SqlParameter("@fechaDesde", fechaDesde.ToString("yyyy-MM-dd 00:00:00")),
                new SqlParameter("@fechaHasta", fechaHasta.ToString("yyyy-MM-dd 23:59:59"))))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Factura factura = FacturaMapper.Current.Fill(data);
                        facturas.Add(factura);
                    }
                    return facturas;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene una Factura por su identificador.
        /// </summary>
        /// <param name="ID">Identificador único de la Factura.</param>
        /// <returns>Objeto Factura.</returns>
        public Factura obtenerPorID(int ID)
        {
            try
            {
                Factura factura = null;

                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                                   new SqlParameter("@idFactura", ID)))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        factura = FacturaMapper.Current.Fill(data);
                    }

                    return factura;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene una lista de Facturas relacionadas con un vehículo por su patente.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <returns>Lista de objetos Factura.</returns>
        public List<Factura> obtenerPorPatente(string patente)
        {
            try
            {
                List<Factura> facturas = new List<Factura>();
                using (var reader = ExecuteReader(SelectPorPatenteStatement, CommandType.Text,
                    new SqlParameter("@patente", patente)))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Factura factura = FacturaMapper.Current.Fill(data);
                        facturas.Add(factura);
                    }
                }
                return facturas;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Elimina una Factura por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único de la Factura.</param>
        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actualiza los datos de una Factura existente en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Factura con los datos actualizados.</param>
        public void Update(Factura obj)
        {
            try
            {
                using (var reader = ExecuteReader(UpdateStatement, CommandType.Text,
           new SqlParameter("@idFactura", obj.idFactura),
           new SqlParameter("@idIngreso", obj.ingreso.idIngreso),
           new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
           new SqlParameter("@monto_total", obj.monto_total),
           new SqlParameter("@verificador", obj.verificador)
           ))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Factura factura = FacturaMapper.Current.Fill(data);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }
    }
}