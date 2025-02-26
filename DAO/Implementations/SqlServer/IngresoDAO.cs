using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using SERVICE.Domain.Composite;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase que implementa la interfaz IIngresoDAO para manejar operaciones CRUD sobre la entidad Ingreso en la base de datos.
/// </summary>
namespace DAO.Implementations.SqlServer
{
    public class IngresoDAO : SqlTransactRepository, IIngresoDAO
    {
        public IngresoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Ingreso] (idIngreso,idVehiculo,FechaHorario_Ingreso,idTipoTarifa,estado) VALUES (@idIngreso,@idVehiculo,@fechaHorario_Ingreso,@idTipoTarifa,@estado)";
        }

        private string IngresosActualesStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE FechaHorario_Salida IS NULL";
        }

        private string IngresoPorPatenteStatement
        {
            get => "SELECT * FROM [DBEstacionamiento].[dbo].[Ingreso] i INNER JOIN [DBEstacionamiento].[dbo].[Vehiculo] v ON i.idVehiculo = v.idVehiculo INNER JOIN [DBEstacionamiento].[dbo].[TipoTarifa] t ON i.idTipoTarifa = t.idTipoTarifa WHERE v.patente = @patente AND FechaHorario_Salida IS NOT NULL";
        }

        private string RegistroSalida
        {
            get => "UPDATE [dbo].[Ingreso] SET FechaHorario_Salida = @FechaHorario_Salida WHERE idIngreso = @idIngreso";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Ingreso] SET (idIngreso,idCliente,FechaHorario_Ingreso,FechaHorario_Salida,estado) WHERE idIngreso = @idIngreso";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Ingreso] WHERE idIngreso = @idIngreso";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE idIngreso = @idIngreso";
        }

        private string SeleccionarPorFechas
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE  FechaHorario_Salida IS NOT NULL AND FechaHorario_Salida >= @fechaInicio AND FechaHorario_Salida <= @fechaFin";
        }

        private string BuscarLaPatente
        {
            get => "SELECT * FROM [dbo].[Ingreso] i INNER JOIN [dbo].[Vehiculo] v ON i.idVehiculo = v.idVehiculo WHERE v.patente = @patente AND i.FechaHorario_Salida IS NULL;";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso]";
        }

        private string CountIngresosActuales
        {
            get => "SELECT COUNT(*) FROM [dbo].[Ingreso] WHERE FechaHorario_Salida IS NULL";
        }

        private string CountIngresoDelDia
        {
            get => "SELECT COUNT(*) FROM [dbo].[Ingreso] WHERE CONVERT(DATE, FechaHorario_Ingreso) = @fechaActual";
        }
        #endregion

            /// <summary>
            /// Agrega un nuevo Ingreso a la base de datos.
            /// </summary>
            /// <param name="obj">Objeto Ingreso a agregar.</param>
        public void Add(Ingreso obj)
        {
        }

        /// <summary>
        /// Obtiene todos los ingresos registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Ingreso.</returns>
        public List<Ingreso> GetAll()
        {
            List<Ingreso> ingresos = new List<Ingreso>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Ingreso ingreso = IngresoMapper.Current.Fill(data);
                    ingresos.Add(ingreso);
                }
            }
            return ingresos;
        }

        /// <summary>
        /// Obtiene un Ingreso por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del Ingreso.</param>
        /// <returns>Objeto Ingreso.</returns>
        public Ingreso GetById(Guid id)
        {
            try
            {
                Ingreso ingreso = null;
                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@idIngreso", id) }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        ingreso = IngresoMapper.Current.Fill(data);
                    }
                    return ingreso;
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Registra la entrada de un vehículo en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Ingreso con los datos de la entrada.</param>
        public void RegistrarEntrada(Ingreso obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter[] {
                        new SqlParameter("@idIngreso", obj.idIngreso),
                        new SqlParameter("@idVehiculo", obj.vehiculo.idVehiculo),
                        new SqlParameter("@idTipoTarifa", obj.objTipoTarifa.idTipoTarifa),
                        new SqlParameter("@estado", obj.estado),
                        new SqlParameter("@fechaHorario_Ingreso", obj.fechaIngreso)
                    });

                if (esCargado == 0) throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Registra la salida de un vehículo en la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Ingreso con los datos de la salida.</param>
        public void RegistrarSalida(Ingreso obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(RegistroSalida, CommandType.Text,
                    new SqlParameter[] {
                        new SqlParameter("@idIngreso", obj.idIngreso),
                        new SqlParameter("@FechaHorario_Salida", obj.fechaEgreso)
                    });

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo insertar el registro");
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Elimina un Ingreso por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del Ingreso.</param>
        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actualiza los datos de un Ingreso existente.
        /// </summary>
        /// <param name="obj">Objeto Ingreso con los datos actualizados.</param>
        public void Update(Ingreso obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene la lista de ingresos actuales (sin salida registrada).
        /// </summary>
        /// <returns>Lista de objetos Ingreso.</returns>
        public List<Ingreso> IngresosActuales()
        {
            try
            {
                List<Ingreso> ingresos = new List<Ingreso>();
                using (var reader = ExecuteReader(IngresosActualesStatement, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Ingreso ingreso = IngresoMapper.Current.Fill(data);
                        ingresos.Add(ingreso);
                    }
                }
                return ingresos;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Busca ingresos relacionados con una patente específica.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <returns>Lista de objetos Ingreso.</returns>
        public List<Ingreso> BuscarPorPatente(string patente)
        {
            try
            {
                List<Ingreso> ingresos = new List<Ingreso>();
                using (var reader = ExecuteReader(IngresoPorPatenteStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@patente", patente) }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Ingreso ingreso = IngresoMapper.Current.Fill(data);
                        ingresos.Add(ingreso);
                    }
                }
                return ingresos;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Lista ingresos registrados entre dos fechas específicas.
        /// </summary>
        /// <param name="desde">Fecha inicial del rango.</param>
        /// <param name="hasta">Fecha final del rango.</param>
        /// <returns>Lista de objetos Ingreso.</returns>
        public List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta)
        {
            try
            {
                List<Ingreso> ingresos = new List<Ingreso>();

                string desdeConversion = desde.ToString("yyyy-MM-dd 00:00:00");
                string hastaConversion = hasta.ToString("yyyy-MM-dd 23:59:59");

                using (var reader = ExecuteReader(SeleccionarPorFechas, CommandType.Text,
                    new SqlParameter[] {
                        new SqlParameter("@fechaInicio",  desdeConversion),
                        new SqlParameter("@fechaFin", hastaConversion)
                    }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Ingreso ingreso = IngresoMapper.Current.Fill(data);
                        ingresos.Add(ingreso);
                    }
                }
                return ingresos;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Busca un ingreso relacionado con una patente específica que no tenga salida registrada.
        /// </summary>
        /// <param name="patente">Patente del vehículo.</param>
        /// <returns>Objeto Ingreso.</returns>
        public Ingreso BuscarUnaPatente(string patente)
        {
            try
            {
                Ingreso ingreso = null;

                using (var reader = ExecuteReader(BuscarLaPatente, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@patente", patente) }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        ingreso = IngresoMapper.Current.Fill(data);
                    }
                }
                return ingreso;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        public int GetCountIngresosActuales()
        {
            try
            {
                string fechaConversion = DateTime.Now.Date.ToString("yyyy-MM-dd");

                object returnValue = ExecuteScalar( CountIngresosActuales, CommandType.Text);

                return (int)returnValue;

            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }


        public int GetCountIngresoDelDia()
        {
            try
            {
                string fechaConversion = DateTime.Now.Date.ToString("yyyy-MM-dd");

                object returnValue = ExecuteScalar(CountIngresoDelDia, CommandType.Text, new SqlParameter[] { new SqlParameter("@fechaActual", fechaConversion) });

                return (int)returnValue;





            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }
    }
}
