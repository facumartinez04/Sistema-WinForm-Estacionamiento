using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw ex;
            }
        }

        public List<MetodoPago> GetAll()
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

        public MetodoPago GetById(Guid id)
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
                throw ex;
            }
        }

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
                throw ex;
            }
        }

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
                throw ex;
            }
        }

        public MetodoPago ObtenerPorId(int id)
        {
            MetodoPago metodo = null;
            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                               new SqlParameter("@idMetodoPago", id)))
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
    }
}
