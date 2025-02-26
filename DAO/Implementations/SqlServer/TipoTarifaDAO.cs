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
/// Clase que implementa la interfaz ITipoTarifaDAO para manejar operaciones CRUD sobre la entidad TipoTarifa en la base de datos.
/// </summary>
namespace DAO.Implementations.SqlServer
{
    public class TipoTarifaDAO : SqlTransactRepository, ITipoTarifaDAO
    {
        public TipoTarifaDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[TipoTarifa] (monto_por_hora,descripcion) VALUES (@monto_por_hora,@descripcion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[TipoTarifa] SET monto_por_hora = @monto_por_hora ,descripcion = @descripcion WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[TipoTarifa] WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string SelectOneStatement
        {
            get => "SELECT idTipoTarifa, monto_por_hora,descripcion FROM [dbo].[TipoTarifa] WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[TipoTarifa]";
        }
        #endregion

        /// <summary>
        /// Agrega un nuevo TipoTarifa a la base de datos.
        /// </summary>
        /// <param name="obj">Objeto TipoTarifa a agregar.</param>
        public void Add(TipoTarifa obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter("@monto_por_hora", obj.monto_por_hora),
                    new SqlParameter("@descripcion", obj.descripcion)
                );

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
        /// Obtiene todos los tipos de tarifa registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos TipoTarifa.</returns>
        public List<TipoTarifa> GetAll()
        {
            try
            {
                List<TipoTarifa> tarifas = new List<TipoTarifa>();
                using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        TipoTarifa tarifa = TipoTarifaMapper.Current.Fill(data);
                        tarifas.Add(tarifa);
                    }
                }
                return tarifas;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        public TipoTarifa GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene un tipo de tarifa por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del TipoTarifa.</param>
        /// <returns>Objeto TipoTarifa.</returns>
        public TipoTarifa ListById(int id)
        {
            try
            {
                TipoTarifa tarifa = null;
                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                    new SqlParameter("@idTipoTarifa", id)
                ))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        tarifa = TipoTarifaMapper.Current.Fill(data);
                    }
                }
                return tarifa;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Elimina un tipo de tarifa por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del TipoTarifa.</param>
        public void Remove(Guid id)
        {
            try
            {
                int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                    new SqlParameter("@idTipoTarifa", id)
                );

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo eliminar el registro");
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Actualiza los datos de un tipo de tarifa existente.
        /// </summary>
        /// <param name="obj">Objeto TipoTarifa con los datos actualizados.</param>
        public void Update(TipoTarifa obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                    new SqlParameter("@monto_por_hora", obj.monto_por_hora),
                    new SqlParameter("@descripcion", obj.descripcion),
                    new SqlParameter("@idTipoTarifa", obj.idTipoTarifa)
                );

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo actualizar el registro");
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
