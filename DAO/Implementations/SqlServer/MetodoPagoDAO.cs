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
/// Clase que implementa la interfaz IMetodoPagoDAO para manejar operaciones CRUD sobre la entidad MetodoPago en la base de datos.
/// </summary>
namespace DAO.Implementations.SqlServer
{
    public sealed class MetodoPagoDAO : SqlTransactRepository, IMetodoPagoDAO
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[MetodoPago] (descripcion) VALUES (@descripcion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[MetodoPago] SET descripcion = @descripcion WHERE idMetodoPago = @idMetodoPago";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[MetodoPago] WHERE idMetodoPago = @idMetodoPago";
        }

        private string SelectOneStatement
        {
            get => "SELECT idMetodoPago,descripcion FROM [dbo].[MetodoPago] WHERE idMetodoPago = @idMetodoPago";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[MetodoPago]";
        }
        #endregion

        public MetodoPagoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        /// <summary>
        /// Agrega un nuevo MetodoPago a la base de datos.
        /// </summary>
        /// <param name="obj">Objeto MetodoPago a agregar.</param>
        public void Add(MetodoPago obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
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
        /// Obtiene todos los métodos de pago registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos MetodoPago.</returns>
        public List<MetodoPago> GetAll()
        {
            try
            {
                List<MetodoPago> metodos = new List<MetodoPago>();
                using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        MetodoPago metodo = MetodoPagoMapper.Current.Fill(data);
                        metodos.Add(metodo);
                    }
                }
                return metodos;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Obtiene un método de pago por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del MetodoPago.</param>
        /// <returns>Objeto MetodoPago.</returns>
        public MetodoPago GetById(Guid id)
        {
            try
            {
                MetodoPago metodo = null;
                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                    new SqlParameter("@idMetodoPago", id)
                ))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        metodo = MetodoPagoMapper.Current.Fill(data);
                    }
                }
                return metodo;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        /// <summary>
        /// Elimina un método de pago por su identificador único.
        /// </summary>
        /// <param name="id">Identificador único del MetodoPago.</param>
        public void Remove(Guid id)
        {
            try
            {
                int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                    new SqlParameter("@idMetodoPago", id)
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
        /// Actualiza los datos de un método de pago existente.
        /// </summary>
        /// <param name="obj">Objeto MetodoPago con los datos actualizados.</param>
        public void Update(MetodoPago obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                    new SqlParameter("@idMetodoPago", obj.idMetodoPago),
                    new SqlParameter("@descripcion", obj.descripcion)
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

        /// <summary>
        /// Elimina un método de pago por su identificador único (versión adicional).
        /// </summary>
        /// <param name="id">Identificador único del MetodoPago.</param>
        public void Eliminar(int id)
        {
            try
            {
                int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                    new SqlParameter("@idMetodoPago", id)
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
        /// Obtiene un método de pago por su identificador único (versión adicional).
        /// </summary>
        /// <param name="id">Identificador único del MetodoPago.</param>
        /// <returns>Objeto MetodoPago.</returns>
        public MetodoPago ObtenerPorId(int id)
        {
            try
            {
                MetodoPago metodo = null;
                using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                    new SqlParameter("@idMetodoPago", id)
                ))
                {
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        metodo = MetodoPagoMapper.Current.Fill(data);
                    }
                }
                return metodo;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }
    }
}
