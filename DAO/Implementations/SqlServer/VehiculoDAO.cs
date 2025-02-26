using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts.UnitOfWork;
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
/// Clase que implementa la interfaz IVehiculoDAO para manejar operaciones CRUD sobre la entidad Vehiculo en la base de datos.
/// </summary>
namespace DAO.Implementations.SqlServer
{
    public class VehiculoDAO : SqlTransactRepository, IVehiculoDAO
    {
        public VehiculoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Vehiculo] (idVehiculo,patente,marca,modelo) VALUES (@idVehiculo,@patente,@marca,@modelo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Vehiculo] SET patente = @patente,marca = @marca,modelo = @modelo WHERE idVehiculo = @idVehiculo";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Vehiculo] WHERE idVehiculo = @idVehiculo";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Vehiculo] WHERE idVehiculo = @idVehiculo";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Vehiculo]";
        }
        #endregion

        /// <summary>
        /// Agrega un nuevo vehículo a la base de datos.
        /// </summary>
        /// <param name="obj">Objeto Vehiculo a agregar.</param>
        public void Add(Vehiculo obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter[] {
                        new SqlParameter("@idVehiculo", obj.idVehiculo),
                        new SqlParameter("@patente", obj.patente),
                        new SqlParameter("@marca", obj.marca),
                        new SqlParameter("@modelo", obj.modelo)
                    });

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo insertar el vehículo");
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene todos los vehículos registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Vehiculo.</returns>
        public List<Vehiculo> GetAll()
        {
            try
            {
                List<Vehiculo> vehiculos = new List<Vehiculo>();

                using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text,
                    new SqlParameter[] { }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Vehiculo vehiculo = VehiculoMapper.Current.Fill(data);
                        vehiculos.Add(vehiculo);
                    }
                }

                return vehiculos;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene un vehículo por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del Vehiculo.</param>
        /// <returns>Objeto Vehiculo.</returns>
        public Vehiculo GetById(Guid id)
        {
            try
            {
                Vehiculo vehiculo = null;

                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@idVehiculo", id) }))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        vehiculo = VehiculoMapper.Current.Fill(data);
                    }
                }

                return vehiculo;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Elimina un vehículo por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del Vehiculo.</param>
        public void Remove(Guid id)
        {
            try
            {
                int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@idVehiculo", id) });

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo eliminar el vehículo");
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Actualiza los datos de un vehículo existente.
        /// </summary>
        /// <param name="obj">Objeto Vehiculo con los datos actualizados.</param>
        public void Update(Vehiculo obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                    new SqlParameter[] {
                        new SqlParameter("@idVehiculo", obj.idVehiculo),
                        new SqlParameter("@patente", obj.patente),
                        new SqlParameter("@marca", obj.marca),
                        new SqlParameter("@modelo", obj.modelo)
                    });

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo actualizar el vehículo");
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
